using System;
using System.Text;
using System.Windows.Forms;
using S7.Net;

namespace PLCTester
{
    public partial class ArrayStructReaderForm : Form
    {
        private Plc plc;
        private PlcStructure structure;

        public ArrayStructReaderForm(Plc plcConnection)
        {
            plc = plcConnection;
            structure = null;

            InitializeComponent();
        }

        private void BtnDefineStructure_Click(object sender, EventArgs e)
        {
            StructureDefinitionForm form = new StructureDefinitionForm(structure);

            if (form.ShowDialog() == DialogResult.OK)
            {
                structure = form.Structure;
                lblStructureInfo.Text = structure.ToString();
                lblStructureInfo.ForeColor = System.Drawing.Color.Green;
                btnReadArray.Enabled = true;
            }
        }

        private void BtnReadArray_Click(object sender, EventArgs e)
        {
            if (plc == null || !plc.IsConnected)
            {
                MessageBox.Show("PLC non connesso!", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (structure == null || structure.Fields.Count == 0)
            {
                MessageBox.Show("Definisci prima la struttura!", "Attenzione",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                treeData.Nodes.Clear();

                int dbNumber = int.Parse(txtDbNumber.Text);
                int startOffset = int.Parse(txtStartOffset.Text);
                int arrayCount = (int)numArrayCount.Value;
                int structSize = structure.GetActualSize();

                TreeNode rootNode = new TreeNode($"DB{dbNumber} - {arrayCount} elementi ({structure.Name})");
                treeData.Nodes.Add(rootNode);

                for (int i = 0; i < arrayCount; i++)
                {
                    int elementOffset = startOffset + (i * structSize);

                    TreeNode elementNode = new TreeNode($"[{i}] - Offset: {elementOffset}");

                    foreach (var field in structure.Fields)
                    {
                        int fieldOffset = elementOffset + field.Offset;
                        object value = ReadField(dbNumber, fieldOffset, field);

                        TreeNode fieldNode = new TreeNode($"{field.Name} = {value}");
                        elementNode.Nodes.Add(fieldNode);
                    }

                    rootNode.Nodes.Add(elementNode);
                }

                rootNode.Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la lettura:\r\n{ex.Message}",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private object ReadField(int dbNumber, int offset, StructField field)
        {
            switch (field.DataType)
            {
                case FieldDataType.Bool:
                    return plc.Read($"DB{dbNumber}.DBX{offset}.0");

                case FieldDataType.Byte:
                    return plc.Read($"DB{dbNumber}.DBB{offset}");

                case FieldDataType.Int:
                    return plc.Read($"DB{dbNumber}.DBW{offset}");

                case FieldDataType.DInt:
                    return plc.Read($"DB{dbNumber}.DBD{offset}");

                case FieldDataType.Real:
                    var realBytes = plc.ReadBytes(DataType.DataBlock, dbNumber, offset, 4);
                    return S7.Net.Types.Double.FromByteArray(realBytes);

                case FieldDataType.String:
                    byte[] stringBytes = plc.ReadBytes(DataType.DataBlock, dbNumber, offset, field.Length + 2);
                    int actualLength = stringBytes[1];

                    if (actualLength > field.Length)
                        actualLength = field.Length;

                    return $"\"{Encoding.ASCII.GetString(stringBytes, 2, actualLength)}\"";

                default:
                    return "N/A";
            }
        }
    }
}