using S7.Net;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.XPath;

namespace PLCTester
{
    public partial class MainForm : Form
    {
        private Plc plc;

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Set default values and event handlers
            cmbCpuType.SelectedIndex = 2; // Default S7-400
            cmbDataType.SelectedIndex = 0;
            cmbDataType.SelectedIndexChanged += CmbDataType_SelectedIndexChanged;
            btnConnect.Click += BtnConnect_Click;
            btnDisconnect.Click += BtnDisconnect_Click;
            btnRead.Click += BtnRead_Click;
        }

        private void CmbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show length field only for String type
            bool isString = cmbDataType.SelectedIndex == 5;

            Label lblLength = (Label)((GroupBox)cmbDataType.Parent).Controls.Find("lblLength", false)[0];

            foreach (Control ctrl in ((GroupBox)cmbDataType.Parent).Controls)
            {
                if (ctrl.Name == "lblLength" || ctrl == txtLength)
                {
                    ctrl.Visible = isString;
                }
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse CPU Type
                CpuType cpuType = CpuType.S7400;
                switch (cmbCpuType.SelectedIndex)
                {
                    case 0: cpuType = CpuType.S7200; break;
                    case 1: cpuType = CpuType.S7300; break;
                    case 2: cpuType = CpuType.S7400; break;
                    case 3: cpuType = CpuType.S71200; break;
                    case 4: cpuType = CpuType.S71500; break;
                }

                // Create PLC instance
                plc = new Plc(
                    cpuType,
                    txtIpAddress.Text,
                    Convert.ToInt16(numRack.Value),
                    Convert.ToInt16(numSlot.Value)
                );

                // Connect
                plc.Open();

                if (plc.IsConnected)
                {
                    lblConnectionStatus.Text = "Stato: Connesso";
                    lblConnectionStatus.ForeColor = Color.Green;

                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                    btnRead.Enabled = true;
                    btnArrayReader.Enabled = true;

                    // Disable connection settings
                    cmbCpuType.Enabled = false;
                    txtIpAddress.Enabled = false;
                    numRack.Enabled = false;
                    numSlot.Enabled = false;

                    txtResult.Text = "Connessione stabilita con successo!\r\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore di connessione:\r\n{ex.Message}",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (plc != null)
                {
                    plc.Close();
                    plc = null;
                }
            }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null && plc.IsConnected)
                {
                    plc.Close();
                }

                lblConnectionStatus.Text = "Stato: Disconnesso";
                lblConnectionStatus.ForeColor = Color.Red;

                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                btnRead.Enabled = false;
                btnArrayReader.Enabled = false;

                // Enable connection settings
                cmbCpuType.Enabled = true;
                txtIpAddress.Enabled = true;
                numRack.Enabled = true;
                numSlot.Enabled = true;

                txtResult.Text = "Disconnesso.\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la disconnessione:\r\n{ex.Message}",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc == null || !plc.IsConnected)
                {
                    MessageBox.Show("Non connesso al PLC!", "Errore",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int dbNumber = int.Parse(txtDbNumber.Text);
                int offset = int.Parse(txtOffset.Text);

                object result = null;
                string resultText = "";

                switch (cmbDataType.SelectedIndex)
                {
                    case 0: // Bool
                        result = plc.Read($"DB{dbNumber}.DBX{offset}.0");
                        resultText = $"Bool letto da DB{dbNumber}.DBX{offset}.0:\r\n{result}";
                        break;

                    case 1: // Byte
                        result = plc.Read($"DB{dbNumber}.DBB{offset}");
                        resultText = $"Byte letto da DB{dbNumber}.DBB{offset}:\r\n{result}";
                        break;

                    case 2: // Int (16-bit)
                        result = plc.Read($"DB{dbNumber}.DBW{offset}");
                        resultText = $"Int letto da DB{dbNumber}.DBW{offset}:\r\n{result}";
                        break;

                    case 3: // DInt (32-bit)
                        result = plc.Read($"DB{dbNumber}.DBD{offset}");
                        resultText = $"DInt letto da DB{dbNumber}.DBD{offset}:\r\n{result}";
                        break;

                    case 4: // Real (32-bit)
                        result = plc.Read($"DB{dbNumber}.DBD{offset}");
                        // Convert to float
                        if (result is byte[] bytes && bytes.Length >= 4)
                        {
                            result = S7.Net.Types.Double.FromByteArray(bytes);
                        }
                        resultText = $"Real letto da DB{dbNumber}.DBD{offset}:\r\n{result}";
                        break;

                    case 5: // String
                        int length = int.Parse(txtLength.Text);
                        // Read string (first 2 bytes are max length and current length)
                        byte[] stringBytes = plc.ReadBytes(DataType.DataBlock, dbNumber, offset, length + 2);

                        // S7 String structure: [0]=max length, [1]=actual length, [2..N]=chars
                        int actualLength = stringBytes[1];
                        string stringValue = System.Text.Encoding.ASCII.GetString(stringBytes, 2, actualLength);

                        result = stringValue;
                        resultText = $"String letta da DB{dbNumber}.DBB{offset} (lunghezza max {length}, effettiva {actualLength}):\r\n\"{result}\"";
                        break;
                }

                txtResult.Text = resultText + "\r\n\r\nLettura completata con successo.";
            }
            catch (Exception ex)
            {
                txtResult.Text = $"ERRORE durante la lettura:\r\n{ex.Message}\r\n\r\nStack Trace:\r\n{ex.StackTrace}";
                MessageBox.Show($"Errore durante la lettura:\r\n{ex.Message}",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (plc != null && plc.IsConnected)
            {
                plc.Close();
            }
            base.OnFormClosing(e);
        }

        private void btnArrayReader_Click(object sender, EventArgs e)
        {
            if (plc == null || !plc.IsConnected)
            {
                MessageBox.Show("Non connesso al PLC!", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ArrayStructReaderForm arrayForm = new ArrayStructReaderForm(plc);
            arrayForm.ShowDialog();
        }
    }
}