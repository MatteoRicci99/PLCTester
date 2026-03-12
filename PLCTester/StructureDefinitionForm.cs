using System;
using System.Drawing;
using System.Windows.Forms;

namespace PLCTester
{
    public partial class StructureDefinitionForm : Form
    {
        private PlcStructure structure;

        public PlcStructure Structure
        {
            get { return structure; }
        }

        public StructureDefinitionForm(PlcStructure existingStructure = null)
        {
            if (existingStructure != null)
                structure = existingStructure;
            else
                structure = new PlcStructure();

            InitializeComponent();

            if (existingStructure != null)
            {
                LoadStructure();
            }
        }

        private void CmbFieldType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isString = cmbFieldType.SelectedIndex == 5;
            lblFieldLength.Visible = isString;
            numFieldLength.Visible = isString;
        }

        private void BtnAddField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFieldName.Text))
            {
                MessageBox.Show("Inserisci un nome per il campo!", "Attenzione",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FieldDataType dataType = (FieldDataType)cmbFieldType.SelectedIndex;
            int length = (dataType == FieldDataType.String) ? (int)numFieldLength.Value : 0;

            StructField field = new StructField(txtFieldName.Text, dataType, length);
            structure.AddField(field);

            UpdateFieldsList();
            UpdateTotalSize();

            txtFieldName.Clear();
            txtFieldName.Focus();
        }

        private void BtnRemoveField_Click(object sender, EventArgs e)
        {
            if (lstFields.SelectedIndex >= 0)
            {
                structure.RemoveField(lstFields.SelectedIndex);
                UpdateFieldsList();
                UpdateTotalSize();
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStructName.Text))
            {
                MessageBox.Show("Inserisci un nome per la struttura!", "Attenzione",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }

            if (structure.Fields.Count == 0)
            {
                MessageBox.Show("Aggiungi almeno un campo alla struttura!", "Attenzione",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }

            structure.Name = txtStructName.Text;

            // Salva dimensione manuale se impostata
            if (numManualSize.Value > 0)
                structure.ManualStructSize = (int)numManualSize.Value;
            else
                structure.ManualStructSize = null;
        }

        private void LoadStructure()
        {
            txtStructName.Text = structure.Name;
            if (structure.ManualStructSize.HasValue)
                numManualSize.Value = structure.ManualStructSize.Value;
            UpdateFieldsList();
            UpdateTotalSize();
        }

        private void UpdateFieldsList()
        {
            lstFields.Items.Clear();

            foreach (var field in structure.Fields)
            {
                string line = string.Format("{0,-20} {1,-10} Offset: {2,3} Size: {3,2}",
                    field.Name,
                    field.DataType == FieldDataType.String ? $"String[{field.Length}]" : field.DataType.ToString(),
                    field.Offset,
                    field.GetSize());
                lstFields.Items.Add(line);
            }
        }

        private void UpdateTotalSize()
        {
            lblTotalSize.Text = $"Dimensione totale: {structure.GetTotalSize()} byte";
        }
    }
}