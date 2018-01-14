namespace WinForm.Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxA = new System.Windows.Forms.TextBox();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtAdd = new System.Windows.Forms.RadioButton();
            this.rbtSub = new System.Windows.Forms.RadioButton();
            this.rbtMul = new System.Windows.Forms.RadioButton();
            this.rbtDiv = new System.Windows.Forms.RadioButton();
            this.btnExeRbtSelection = new System.Windows.Forms.Button();
            this.cbxOps = new System.Windows.Forms.ComboBox();
            this.OpSelectionListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExeCbxSelection = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.tbxRes = new System.Windows.Forms.TextBox();
            this.tbxMsg = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProtocolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpSelectionListBindingSource)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProtocolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.hilfeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.dlgÖffnenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.hilfeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // dlgÖffnenToolStripMenuItem
            // 
            this.dlgÖffnenToolStripMenuItem.Name = "dlgÖffnenToolStripMenuItem";
            this.dlgÖffnenToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.dlgÖffnenToolStripMenuItem.Text = "DlgÖffnen";
            this.dlgÖffnenToolStripMenuItem.Click += new System.EventHandler(this.dlgÖffnenToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 254);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(644, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(644, 230);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.04059F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.95941F));
            this.tableLayoutPanel1.Controls.Add(this.tbxA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExeRbtSelection, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbxOps, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnExeCbxSelection, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbxRes, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbxMsg, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 230);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbxA
            // 
            this.tbxA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxA.Location = new System.Drawing.Point(3, 3);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(153, 20);
            this.tbxA.TabIndex = 0;
            this.tbxA.Text = "0";
            this.tbxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxB
            // 
            this.tbxB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxB.Location = new System.Drawing.Point(3, 28);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(153, 20);
            this.tbxB.TabIndex = 1;
            this.tbxB.Text = "0";
            this.tbxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbtAdd);
            this.flowLayoutPanel1.Controls.Add(this.rbtSub);
            this.flowLayoutPanel1.Controls.Add(this.rbtMul);
            this.flowLayoutPanel1.Controls.Add(this.rbtDiv);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(153, 24);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // rbtAdd
            // 
            this.rbtAdd.AutoSize = true;
            this.rbtAdd.Checked = true;
            this.rbtAdd.Location = new System.Drawing.Point(3, 3);
            this.rbtAdd.Name = "rbtAdd";
            this.rbtAdd.Size = new System.Drawing.Size(31, 17);
            this.rbtAdd.TabIndex = 0;
            this.rbtAdd.TabStop = true;
            this.rbtAdd.Text = "+";
            this.rbtAdd.UseVisualStyleBackColor = true;
            // 
            // rbtSub
            // 
            this.rbtSub.AutoSize = true;
            this.rbtSub.Location = new System.Drawing.Point(40, 3);
            this.rbtSub.Name = "rbtSub";
            this.rbtSub.Size = new System.Drawing.Size(28, 17);
            this.rbtSub.TabIndex = 1;
            this.rbtSub.Text = "-";
            this.rbtSub.UseVisualStyleBackColor = true;
            // 
            // rbtMul
            // 
            this.rbtMul.AutoSize = true;
            this.rbtMul.Location = new System.Drawing.Point(74, 3);
            this.rbtMul.Name = "rbtMul";
            this.rbtMul.Size = new System.Drawing.Size(29, 17);
            this.rbtMul.TabIndex = 2;
            this.rbtMul.Text = "*";
            this.rbtMul.UseVisualStyleBackColor = true;
            // 
            // rbtDiv
            // 
            this.rbtDiv.AutoSize = true;
            this.rbtDiv.Location = new System.Drawing.Point(109, 3);
            this.rbtDiv.Name = "rbtDiv";
            this.rbtDiv.Size = new System.Drawing.Size(30, 17);
            this.rbtDiv.TabIndex = 4;
            this.rbtDiv.Text = "/";
            this.rbtDiv.UseVisualStyleBackColor = true;
            // 
            // btnExeRbtSelection
            // 
            this.btnExeRbtSelection.BackColor = System.Drawing.Color.Brown;
            this.btnExeRbtSelection.Location = new System.Drawing.Point(162, 53);
            this.btnExeRbtSelection.Name = "btnExeRbtSelection";
            this.btnExeRbtSelection.Size = new System.Drawing.Size(75, 23);
            this.btnExeRbtSelection.TabIndex = 3;
            this.btnExeRbtSelection.Text = "EXE";
            this.btnExeRbtSelection.UseVisualStyleBackColor = false;
            this.btnExeRbtSelection.Click += new System.EventHandler(this.btnExeRbtSelection_Click);
            // 
            // cbxOps
            // 
            this.cbxOps.DataSource = this.OpSelectionListBindingSource;
            this.cbxOps.DisplayMember = "OpTxt";
            this.cbxOps.FormattingEnabled = true;
            this.cbxOps.Location = new System.Drawing.Point(3, 83);
            this.cbxOps.Name = "cbxOps";
            this.cbxOps.Size = new System.Drawing.Size(121, 21);
            this.cbxOps.TabIndex = 4;
            this.cbxOps.ValueMember = "Op";
            // 
            // OpSelectionListBindingSource
            // 
            this.OpSelectionListBindingSource.DataSource = typeof(WinForm.Calculator.CalcController);
            // 
            // btnExeCbxSelection
            // 
            this.btnExeCbxSelection.Location = new System.Drawing.Point(162, 83);
            this.btnExeCbxSelection.Name = "btnExeCbxSelection";
            this.btnExeCbxSelection.Size = new System.Drawing.Size(75, 23);
            this.btnExeCbxSelection.TabIndex = 5;
            this.btnExeCbxSelection.Text = "EXE";
            this.btnExeCbxSelection.UseVisualStyleBackColor = true;
            this.btnExeCbxSelection.Click += new System.EventHandler(this.btnExeCbxSelection_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAdd);
            this.flowLayoutPanel2.Controls.Add(this.btnSub);
            this.flowLayoutPanel2.Controls.Add(this.btnMul);
            this.flowLayoutPanel2.Controls.Add(this.btnDiv);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 113);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(153, 34);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(40, 3);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(28, 23);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(74, 3);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(29, 23);
            this.btnMul.TabIndex = 2;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(109, 3);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(30, 23);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // tbxRes
            // 
            this.tbxRes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRes.ForeColor = System.Drawing.Color.Green;
            this.tbxRes.Location = new System.Drawing.Point(3, 153);
            this.tbxRes.Name = "tbxRes";
            this.tbxRes.Size = new System.Drawing.Size(153, 26);
            this.tbxRes.TabIndex = 7;
            this.tbxRes.Text = "0";
            this.tbxRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxMsg
            // 
            this.tbxMsg.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.tbxMsg, 2);
            this.tbxMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMsg.Location = new System.Drawing.Point(3, 183);
            this.tbxMsg.Multiline = true;
            this.tbxMsg.Name = "tbxMsg";
            this.tbxMsg.Size = new System.Drawing.Size(265, 44);
            this.tbxMsg.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logDateDataGridViewTextBoxColumn,
            this.opDataGridViewTextBoxColumn,
            this.opADataGridViewTextBoxColumn,
            this.opBDataGridViewTextBoxColumn,
            this.resDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ProtocolBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // logDateDataGridViewTextBoxColumn
            // 
            this.logDateDataGridViewTextBoxColumn.DataPropertyName = "LogDate";
            this.logDateDataGridViewTextBoxColumn.HeaderText = "LogDate";
            this.logDateDataGridViewTextBoxColumn.Name = "logDateDataGridViewTextBoxColumn";
            // 
            // opDataGridViewTextBoxColumn
            // 
            this.opDataGridViewTextBoxColumn.DataPropertyName = "Op";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.opDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.opDataGridViewTextBoxColumn.HeaderText = "Op";
            this.opDataGridViewTextBoxColumn.Name = "opDataGridViewTextBoxColumn";
            // 
            // opADataGridViewTextBoxColumn
            // 
            this.opADataGridViewTextBoxColumn.DataPropertyName = "OpA";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.opADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.opADataGridViewTextBoxColumn.HeaderText = "OpA";
            this.opADataGridViewTextBoxColumn.Name = "opADataGridViewTextBoxColumn";
            // 
            // opBDataGridViewTextBoxColumn
            // 
            this.opBDataGridViewTextBoxColumn.DataPropertyName = "OpB";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.opBDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.opBDataGridViewTextBoxColumn.HeaderText = "OpB";
            this.opBDataGridViewTextBoxColumn.Name = "opBDataGridViewTextBoxColumn";
            // 
            // resDataGridViewTextBoxColumn
            // 
            this.resDataGridViewTextBoxColumn.DataPropertyName = "Res";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.resDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.resDataGridViewTextBoxColumn.HeaderText = "Res";
            this.resDataGridViewTextBoxColumn.Name = "resDataGridViewTextBoxColumn";
            // 
            // ProtocolBindingSource
            // 
            this.ProtocolBindingSource.DataSource = typeof(CS.Calculator.CalcBase.ProtocolEntry);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 276);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WinForm Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpSelectionListBindingSource)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProtocolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbtAdd;
        private System.Windows.Forms.RadioButton rbtSub;
        private System.Windows.Forms.RadioButton rbtMul;
        private System.Windows.Forms.RadioButton rbtDiv;
        private System.Windows.Forms.Button btnExeRbtSelection;
        private System.Windows.Forms.ComboBox cbxOps;
        private System.Windows.Forms.Button btnExeCbxSelection;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox tbxRes;
        private System.Windows.Forms.BindingSource OpSelectionListBindingSource;
        private System.Windows.Forms.BindingSource ProtocolBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbxMsg;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dlgÖffnenToolStripMenuItem;
    }
}

