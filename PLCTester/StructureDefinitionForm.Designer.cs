namespace PLCTester
{
    partial class StructureDefinitionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtStructName;
        private System.Windows.Forms.ListBox lstFields;
        private System.Windows.Forms.ComboBox cmbFieldType;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.NumericUpDown numFieldLength;
        private System.Windows.Forms.Label lblFieldLength;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Button btnRemoveField;
        private System.Windows.Forms.Label lblTotalSize;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblManualSize;
        private System.Windows.Forms.NumericUpDown numManualSize;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblStructName;
            System.Windows.Forms.Label lblFields;
            System.Windows.Forms.GroupBox grpAddField;
            System.Windows.Forms.Label lblFieldName;
            System.Windows.Forms.Label lblFieldType;

            lblStructName = new System.Windows.Forms.Label();
            this.txtStructName = new System.Windows.Forms.TextBox();
            lblFields = new System.Windows.Forms.Label();
            this.lstFields = new System.Windows.Forms.ListBox();
            grpAddField = new System.Windows.Forms.GroupBox();
            lblFieldName = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            lblFieldType = new System.Windows.Forms.Label();
            this.cmbFieldType = new System.Windows.Forms.ComboBox();
            this.lblFieldLength = new System.Windows.Forms.Label();
            this.numFieldLength = new System.Windows.Forms.NumericUpDown();
            this.btnAddField = new System.Windows.Forms.Button();
            this.btnRemoveField = new System.Windows.Forms.Button();
            this.lblTotalSize = new System.Windows.Forms.Label();
            this.lblManualSize = new System.Windows.Forms.Label();
            this.numManualSize = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            grpAddField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFieldLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numManualSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStructName
            // 
            lblStructName.AutoSize = true;
            lblStructName.Location = new System.Drawing.Point(15, 15);
            lblStructName.Name = "lblStructName";
            lblStructName.Size = new System.Drawing.Size(90, 13);
            lblStructName.TabIndex = 0;
            lblStructName.Text = "Nome Struttura:";
            // 
            // txtStructName
            // 
            this.txtStructName.Location = new System.Drawing.Point(120, 12);
            this.txtStructName.Name = "txtStructName";
            this.txtStructName.Size = new System.Drawing.Size(350, 20);
            this.txtStructName.TabIndex = 1;
            this.txtStructName.Text = "Struct";
            // 
            // lblFields
            // 
            lblFields.AutoSize = true;
            lblFields.Location = new System.Drawing.Point(15, 50);
            lblFields.Name = "lblFields";
            lblFields.Size = new System.Drawing.Size(40, 13);
            lblFields.TabIndex = 2;
            lblFields.Text = "Campi:";
            // 
            // lstFields
            // 
            this.lstFields.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFields.FormattingEnabled = true;
            this.lstFields.ItemHeight = 14;
            this.lstFields.Location = new System.Drawing.Point(15, 75);
            this.lstFields.Name = "lstFields";
            this.lstFields.Size = new System.Drawing.Size(470, 200);
            this.lstFields.TabIndex = 3;
            // 
            // grpAddField
            // 
            grpAddField.Controls.Add(lblFieldName);
            grpAddField.Controls.Add(this.txtFieldName);
            grpAddField.Controls.Add(lblFieldType);
            grpAddField.Controls.Add(this.cmbFieldType);
            grpAddField.Controls.Add(this.lblFieldLength);
            grpAddField.Controls.Add(this.numFieldLength);
            grpAddField.Controls.Add(this.btnAddField);
            grpAddField.Controls.Add(this.btnRemoveField);
            grpAddField.Location = new System.Drawing.Point(15, 290);
            grpAddField.Name = "grpAddField";
            grpAddField.Size = new System.Drawing.Size(470, 150);
            grpAddField.TabIndex = 4;
            grpAddField.TabStop = false;
            grpAddField.Text = "Aggiungi Campo";
            // 
            // lblFieldName
            // 
            lblFieldName.AutoSize = true;
            lblFieldName.Location = new System.Drawing.Point(15, 30);
            lblFieldName.Name = "lblFieldName";
            lblFieldName.Size = new System.Drawing.Size(38, 13);
            lblFieldName.TabIndex = 0;
            lblFieldName.Text = "Nome:";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(80, 27);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(150, 20);
            this.txtFieldName.TabIndex = 1;
            // 
            // lblFieldType
            // 
            lblFieldType.AutoSize = true;
            lblFieldType.Location = new System.Drawing.Point(250, 30);
            lblFieldType.Name = "lblFieldType";
            lblFieldType.Size = new System.Drawing.Size(31, 13);
            lblFieldType.TabIndex = 2;
            lblFieldType.Text = "Tipo:";
            // 
            // cmbFieldType
            // 
            this.cmbFieldType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFieldType.FormattingEnabled = true;
            this.cmbFieldType.Items.AddRange(new object[] {
            "Bool",
            "Byte",
            "Int",
            "DInt",
            "Real",
            "String"});
            this.cmbFieldType.Location = new System.Drawing.Point(290, 27);
            this.cmbFieldType.Name = "cmbFieldType";
            this.cmbFieldType.Size = new System.Drawing.Size(100, 21);
            this.cmbFieldType.TabIndex = 3;
            this.cmbFieldType.SelectedIndexChanged += new System.EventHandler(this.CmbFieldType_SelectedIndexChanged);
            // 
            // lblFieldLength
            // 
            this.lblFieldLength.AutoSize = true;
            this.lblFieldLength.Location = new System.Drawing.Point(15, 70);
            this.lblFieldLength.Name = "lblFieldLength";
            this.lblFieldLength.Size = new System.Drawing.Size(66, 13);
            this.lblFieldLength.TabIndex = 4;
            this.lblFieldLength.Text = "Lunghezza:";
            this.lblFieldLength.Visible = false;
            // 
            // numFieldLength
            // 
            this.numFieldLength.Location = new System.Drawing.Point(100, 67);
            this.numFieldLength.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numFieldLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFieldLength.Name = "numFieldLength";
            this.numFieldLength.Size = new System.Drawing.Size(80, 20);
            this.numFieldLength.TabIndex = 5;
            this.numFieldLength.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFieldLength.Visible = false;
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(15, 105);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(120, 30);
            this.btnAddField.TabIndex = 6;
            this.btnAddField.Text = "Aggiungi Campo";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.BtnAddField_Click);
            // 
            // btnRemoveField
            // 
            this.btnRemoveField.Location = new System.Drawing.Point(150, 105);
            this.btnRemoveField.Name = "btnRemoveField";
            this.btnRemoveField.Size = new System.Drawing.Size(140, 30);
            this.btnRemoveField.TabIndex = 7;
            this.btnRemoveField.Text = "Rimuovi Selezionato";
            this.btnRemoveField.UseVisualStyleBackColor = true;
            this.btnRemoveField.Click += new System.EventHandler(this.BtnRemoveField_Click);
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.AutoSize = true;
            this.lblTotalSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSize.Location = new System.Drawing.Point(15, 455);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(138, 13);
            this.lblTotalSize.TabIndex = 5;
            this.lblTotalSize.Text = "Dimensione totale: 0 byte";
            // 
            // lblManualSize
            // 
            this.lblManualSize.AutoSize = true;
            this.lblManualSize.Location = new System.Drawing.Point(15, 480);
            this.lblManualSize.Name = "lblManualSize";
            this.lblManualSize.Size = new System.Drawing.Size(263, 13);
            this.lblManualSize.TabIndex = 6;
            this.lblManualSize.Text = "Dimensione reale struct (lascia vuoto se uguale):";
            // 
            // numManualSize
            // 
            this.numManualSize.Location = new System.Drawing.Point(290, 478);
            this.numManualSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numManualSize.Name = "numManualSize";
            this.numManualSize.Size = new System.Drawing.Size(80, 20);
            this.numManualSize.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(315, 510);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 35);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(405, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // StructureDefinitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 560);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numManualSize);
            this.Controls.Add(this.lblManualSize);
            this.Controls.Add(this.lblTotalSize);
            this.Controls.Add(grpAddField);
            this.Controls.Add(this.lstFields);
            this.Controls.Add(lblFields);
            this.Controls.Add(this.txtStructName);
            this.Controls.Add(lblStructName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StructureDefinitionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Definizione Struttura";
            grpAddField.ResumeLayout(false);
            grpAddField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFieldLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numManualSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}