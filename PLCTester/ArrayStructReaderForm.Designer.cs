using System.Drawing;
using System.Windows.Forms;

namespace PLCTester
{
    partial class ArrayStructReaderForm
    {
        private Label lblDbNumber;
        private TextBox txtDbNumber;
        private Label lblStartOffset;
        private TextBox txtStartOffset;
        private Label lblArrayCount;
        private NumericUpDown numArrayCount;
        private Button btnDefineStructure;
        private Button btnReadArray;
        private TreeView treeData;
        private Label lblStructureInfo;

        private void InitializeComponent()
        {
            this.lblDbNumber = new System.Windows.Forms.Label();
            this.txtDbNumber = new System.Windows.Forms.TextBox();
            this.lblStartOffset = new System.Windows.Forms.Label();
            this.txtStartOffset = new System.Windows.Forms.TextBox();
            this.lblArrayCount = new System.Windows.Forms.Label();
            this.numArrayCount = new System.Windows.Forms.NumericUpDown();
            this.btnDefineStructure = new System.Windows.Forms.Button();
            this.btnReadArray = new System.Windows.Forms.Button();
            this.treeData = new System.Windows.Forms.TreeView();
            this.lblStructureInfo = new System.Windows.Forms.Label();
            this.grpConfig = new System.Windows.Forms.GroupBox();
            this.lblTree = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numArrayCount)).BeginInit();
            this.grpConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDbNumber
            // 
            this.lblDbNumber.Location = new System.Drawing.Point(15, 30);
            this.lblDbNumber.Name = "lblDbNumber";
            this.lblDbNumber.Size = new System.Drawing.Size(100, 23);
            this.lblDbNumber.TabIndex = 0;
            this.lblDbNumber.Text = "DB Number:";
            // 
            // txtDbNumber
            // 
            this.txtDbNumber.Location = new System.Drawing.Point(86, 27);
            this.txtDbNumber.Name = "txtDbNumber";
            this.txtDbNumber.Size = new System.Drawing.Size(100, 20);
            this.txtDbNumber.TabIndex = 1;
            this.txtDbNumber.Text = "1";
            // 
            // lblStartOffset
            // 
            this.lblStartOffset.Location = new System.Drawing.Point(210, 30);
            this.lblStartOffset.Name = "lblStartOffset";
            this.lblStartOffset.Size = new System.Drawing.Size(100, 23);
            this.lblStartOffset.TabIndex = 2;
            this.lblStartOffset.Text = "Offset Inizio:";
            // 
            // txtStartOffset
            // 
            this.txtStartOffset.Location = new System.Drawing.Point(277, 27);
            this.txtStartOffset.Name = "txtStartOffset";
            this.txtStartOffset.Size = new System.Drawing.Size(100, 20);
            this.txtStartOffset.TabIndex = 3;
            this.txtStartOffset.Text = "0";
            // 
            // lblArrayCount
            // 
            this.lblArrayCount.Location = new System.Drawing.Point(410, 30);
            this.lblArrayCount.Name = "lblArrayCount";
            this.lblArrayCount.Size = new System.Drawing.Size(77, 23);
            this.lblArrayCount.TabIndex = 4;
            this.lblArrayCount.Text = "N° Elementi:";
            // 
            // numArrayCount
            // 
            this.numArrayCount.Location = new System.Drawing.Point(480, 27);
            this.numArrayCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numArrayCount.Name = "numArrayCount";
            this.numArrayCount.Size = new System.Drawing.Size(120, 20);
            this.numArrayCount.TabIndex = 5;
            this.numArrayCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnDefineStructure
            // 
            this.btnDefineStructure.Location = new System.Drawing.Point(15, 70);
            this.btnDefineStructure.Name = "btnDefineStructure";
            this.btnDefineStructure.Size = new System.Drawing.Size(140, 35);
            this.btnDefineStructure.TabIndex = 6;
            this.btnDefineStructure.Text = "Definisci Struttura";
            this.btnDefineStructure.Click += new System.EventHandler(this.BtnDefineStructure_Click);
            // 
            // btnReadArray
            // 
            this.btnReadArray.Enabled = false;
            this.btnReadArray.Location = new System.Drawing.Point(480, 70);
            this.btnReadArray.Name = "btnReadArray";
            this.btnReadArray.Size = new System.Drawing.Size(170, 35);
            this.btnReadArray.TabIndex = 8;
            this.btnReadArray.Text = "Leggi Array";
            this.btnReadArray.Click += new System.EventHandler(this.BtnReadArray_Click);
            // 
            // treeData
            // 
            this.treeData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeData.Font = new System.Drawing.Font("Consolas", 9F);
            this.treeData.Location = new System.Drawing.Point(10, 165);
            this.treeData.Name = "treeData";
            this.treeData.Size = new System.Drawing.Size(670, 420);
            this.treeData.TabIndex = 2;
            // 
            // lblStructureInfo
            // 
            this.lblStructureInfo.ForeColor = System.Drawing.Color.Red;
            this.lblStructureInfo.Location = new System.Drawing.Point(170, 78);
            this.lblStructureInfo.Name = "lblStructureInfo";
            this.lblStructureInfo.Size = new System.Drawing.Size(304, 23);
            this.lblStructureInfo.TabIndex = 7;
            this.lblStructureInfo.Text = "Nessuna struttura definita";
            // 
            // grpConfig
            // 
            this.grpConfig.Controls.Add(this.txtDbNumber);
            this.grpConfig.Controls.Add(this.txtStartOffset);
            this.grpConfig.Controls.Add(this.numArrayCount);
            this.grpConfig.Controls.Add(this.lblDbNumber);
            this.grpConfig.Controls.Add(this.lblStartOffset);
            this.grpConfig.Controls.Add(this.lblArrayCount);
            this.grpConfig.Controls.Add(this.btnDefineStructure);
            this.grpConfig.Controls.Add(this.lblStructureInfo);
            this.grpConfig.Controls.Add(this.btnReadArray);
            this.grpConfig.Location = new System.Drawing.Point(10, 10);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Size = new System.Drawing.Size(670, 120);
            this.grpConfig.TabIndex = 0;
            this.grpConfig.TabStop = false;
            this.grpConfig.Text = "Configurazione Lettura";
            // 
            // lblTree
            // 
            this.lblTree.Location = new System.Drawing.Point(10, 140);
            this.lblTree.Name = "lblTree";
            this.lblTree.Size = new System.Drawing.Size(100, 23);
            this.lblTree.TabIndex = 1;
            this.lblTree.Text = "Dati Letti:";
            // 
            // ArrayStructReaderForm
            // 
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.grpConfig);
            this.Controls.Add(this.lblTree);
            this.Controls.Add(this.treeData);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "ArrayStructReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lettore Array di Struct";
            ((System.ComponentModel.ISupportInitialize)(this.numArrayCount)).EndInit();
            this.grpConfig.ResumeLayout(false);
            this.grpConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        private GroupBox grpConfig;
        private Label lblTree;
    }
}