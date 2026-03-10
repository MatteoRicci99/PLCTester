using System.Drawing;
using System.Windows.Forms;

namespace PLCTester
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.lblCpuType = new System.Windows.Forms.Label();
            this.cmbCpuType = new System.Windows.Forms.ComboBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.lblRack = new System.Windows.Forms.Label();
            this.numRack = new System.Windows.Forms.NumericUpDown();
            this.lblSlot = new System.Windows.Forms.Label();
            this.numSlot = new System.Windows.Forms.NumericUpDown();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.grpRead = new System.Windows.Forms.GroupBox();
            this.lblDataType = new System.Windows.Forms.Label();
            this.cmbDataType = new System.Windows.Forms.ComboBox();
            this.lblDb = new System.Windows.Forms.Label();
            this.txtDbNumber = new System.Windows.Forms.TextBox();
            this.lblOffset = new System.Windows.Forms.Label();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.grpConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSlot)).BeginInit();
            this.grpRead.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.lblCpuType);
            this.grpConnection.Controls.Add(this.cmbCpuType);
            this.grpConnection.Controls.Add(this.lblIp);
            this.grpConnection.Controls.Add(this.txtIpAddress);
            this.grpConnection.Controls.Add(this.lblRack);
            this.grpConnection.Controls.Add(this.numRack);
            this.grpConnection.Controls.Add(this.lblSlot);
            this.grpConnection.Controls.Add(this.numSlot);
            this.grpConnection.Controls.Add(this.btnConnect);
            this.grpConnection.Controls.Add(this.btnDisconnect);
            this.grpConnection.Controls.Add(this.lblConnectionStatus);
            this.grpConnection.Location = new System.Drawing.Point(10, 10);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(570, 150);
            this.grpConnection.TabIndex = 0;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connessione PLC";
            // 
            // lblCpuType
            // 
            this.lblCpuType.AutoSize = true;
            this.lblCpuType.Location = new System.Drawing.Point(15, 30);
            this.lblCpuType.Name = "lblCpuType";
            this.lblCpuType.Size = new System.Drawing.Size(56, 13);
            this.lblCpuType.TabIndex = 0;
            this.lblCpuType.Text = "Tipo CPU:";
            // 
            // cmbCpuType
            // 
            this.cmbCpuType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCpuType.FormattingEnabled = true;
            this.cmbCpuType.Items.AddRange(new object[] {
            "S7-200",
            "S7-300",
            "S7-400",
            "S7-1200",
            "S7-1500"});
            this.cmbCpuType.Location = new System.Drawing.Point(120, 27);
            this.cmbCpuType.Name = "cmbCpuType";
            this.cmbCpuType.Size = new System.Drawing.Size(150, 21);
            this.cmbCpuType.TabIndex = 1;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(15, 65);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(61, 13);
            this.lblIp.TabIndex = 2;
            this.lblIp.Text = "Indirizzo IP:";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(120, 62);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(150, 20);
            this.txtIpAddress.TabIndex = 3;
            this.txtIpAddress.Text = "192.168.0.1";
            // 
            // lblRack
            // 
            this.lblRack.AutoSize = true;
            this.lblRack.Location = new System.Drawing.Point(300, 30);
            this.lblRack.Name = "lblRack";
            this.lblRack.Size = new System.Drawing.Size(36, 13);
            this.lblRack.TabIndex = 4;
            this.lblRack.Text = "Rack:";
            // 
            // numRack
            // 
            this.numRack.Location = new System.Drawing.Point(360, 27);
            this.numRack.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numRack.Name = "numRack";
            this.numRack.Size = new System.Drawing.Size(60, 20);
            this.numRack.TabIndex = 5;
            // 
            // lblSlot
            // 
            this.lblSlot.AutoSize = true;
            this.lblSlot.Location = new System.Drawing.Point(300, 65);
            this.lblSlot.Name = "lblSlot";
            this.lblSlot.Size = new System.Drawing.Size(28, 13);
            this.lblSlot.TabIndex = 6;
            this.lblSlot.Text = "Slot:";
            // 
            // numSlot
            // 
            this.numSlot.Location = new System.Drawing.Point(360, 62);
            this.numSlot.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSlot.Name = "numSlot";
            this.numSlot.Size = new System.Drawing.Size(60, 20);
            this.numSlot.TabIndex = 7;
            this.numSlot.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(450, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 30);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connetti";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(450, 62);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 30);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnetti";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(15, 110);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(117, 13);
            this.lblConnectionStatus.TabIndex = 10;
            this.lblConnectionStatus.Text = "Stato: Disconnesso";
            // 
            // grpRead
            // 
            this.grpRead.Controls.Add(this.lblDataType);
            this.grpRead.Controls.Add(this.cmbDataType);
            this.grpRead.Controls.Add(this.lblDb);
            this.grpRead.Controls.Add(this.txtDbNumber);
            this.grpRead.Controls.Add(this.lblOffset);
            this.grpRead.Controls.Add(this.txtOffset);
            this.grpRead.Controls.Add(this.lblLength);
            this.grpRead.Controls.Add(this.txtLength);
            this.grpRead.Controls.Add(this.btnRead);
            this.grpRead.Location = new System.Drawing.Point(10, 170);
            this.grpRead.Name = "grpRead";
            this.grpRead.Size = new System.Drawing.Size(570, 150);
            this.grpRead.TabIndex = 1;
            this.grpRead.TabStop = false;
            this.grpRead.Text = "Lettura Dati";
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Location = new System.Drawing.Point(15, 30);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(57, 13);
            this.lblDataType.TabIndex = 0;
            this.lblDataType.Text = "Tipo Dato:";
            // 
            // cmbDataType
            // 
            this.cmbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataType.FormattingEnabled = true;
            this.cmbDataType.Items.AddRange(new object[] {
            "Bool",
            "Byte",
            "Int (16-bit)",
            "DInt (32-bit)",
            "Real (32-bit)",
            "String"});
            this.cmbDataType.Location = new System.Drawing.Point(120, 27);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Size = new System.Drawing.Size(150, 21);
            this.cmbDataType.TabIndex = 1;
            // 
            // lblDb
            // 
            this.lblDb.AutoSize = true;
            this.lblDb.Location = new System.Drawing.Point(15, 65);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(65, 13);
            this.lblDb.TabIndex = 2;
            this.lblDb.Text = "DB Number:";
            // 
            // txtDbNumber
            // 
            this.txtDbNumber.Location = new System.Drawing.Point(120, 62);
            this.txtDbNumber.Name = "txtDbNumber";
            this.txtDbNumber.Size = new System.Drawing.Size(80, 20);
            this.txtDbNumber.TabIndex = 3;
            this.txtDbNumber.Text = "1";
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(220, 65);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(38, 13);
            this.lblOffset.TabIndex = 4;
            this.lblOffset.Text = "Offset:";
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(280, 62);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(80, 20);
            this.txtOffset.TabIndex = 5;
            this.txtOffset.Text = "0";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(15, 100);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(62, 13);
            this.lblLength.TabIndex = 6;
            this.lblLength.Text = "Lunghezza:";
            this.lblLength.Visible = false;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(120, 97);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(80, 20);
            this.txtLength.TabIndex = 7;
            this.txtLength.Text = "10";
            this.txtLength.Visible = false;
            // 
            // btnRead
            // 
            this.btnRead.Enabled = false;
            this.btnRead.Location = new System.Drawing.Point(450, 57);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(100, 40);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Leggi";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.txtResult);
            this.grpResult.Location = new System.Drawing.Point(10, 330);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(570, 140);
            this.grpResult.TabIndex = 2;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Risultato";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(15, 25);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(540, 100);
            this.txtResult.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpRead);
            this.Controls.Add(this.grpConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLC S7 Tester";
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSlot)).EndInit();
            this.grpRead.ResumeLayout(false);
            this.grpRead.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.Label lblCpuType;
        private System.Windows.Forms.ComboBox cmbCpuType;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label lblRack;
        private System.Windows.Forms.NumericUpDown numRack;
        private System.Windows.Forms.Label lblSlot;
        private System.Windows.Forms.NumericUpDown numSlot;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.GroupBox grpRead;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.ComboBox cmbDataType;
        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.TextBox txtDbNumber;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}