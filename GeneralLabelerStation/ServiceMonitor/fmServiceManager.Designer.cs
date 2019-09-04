namespace GeneralLabelerStation.ServiceMonitor
{
    partial class fmServiceManager
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
            this.dGVItem = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tCurUse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tItemName = new System.Windows.Forms.TextBox();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bServiced = new System.Windows.Forms.Button();
            this.lMonitor = new System.Windows.Forms.Label();
            this.lMonitorValue = new System.Windows.Forms.TextBox();
            this.cbEnable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVItem
            // 
            this.dGVItem.AllowUserToAddRows = false;
            this.dGVItem.AllowUserToDeleteRows = false;
            this.dGVItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGVItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.dGVItem.Location = new System.Drawing.Point(0, 0);
            this.dGVItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dGVItem.Name = "dGVItem";
            this.dGVItem.ReadOnly = true;
            this.dGVItem.RowTemplate.Height = 23;
            this.dGVItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVItem.Size = new System.Drawing.Size(729, 494);
            this.dGVItem.TabIndex = 0;
            this.dGVItem.SelectionChanged += new System.EventHandler(this.dGVItem_SelectionChanged);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "启用";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "当前使用";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "可使用";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 120F;
            this.Column4.HeaderText = "维护时间";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(729, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 286);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tCurUse, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tItemName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bUpdate, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.bAdd, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.bDelete, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.bServiced, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lMonitor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lMonitorValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbEnable, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tCurUse
            // 
            this.tCurUse.Location = new System.Drawing.Point(133, 33);
            this.tCurUse.Name = "tCurUse";
            this.tCurUse.ReadOnly = true;
            this.tCurUse.Size = new System.Drawing.Size(100, 26);
            this.tCurUse.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "当前使用";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tItemName
            // 
            this.tItemName.Location = new System.Drawing.Point(133, 3);
            this.tItemName.Name = "tItemName";
            this.tItemName.Size = new System.Drawing.Size(100, 26);
            this.tItemName.TabIndex = 1;
            // 
            // bUpdate
            // 
            this.bUpdate.BackColor = System.Drawing.Color.Yellow;
            this.bUpdate.Enabled = false;
            this.bUpdate.Location = new System.Drawing.Point(3, 153);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(124, 40);
            this.bUpdate.TabIndex = 8;
            this.bUpdate.Text = "更新";
            this.bUpdate.UseVisualStyleBackColor = false;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Red;
            this.bAdd.Location = new System.Drawing.Point(133, 153);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(124, 40);
            this.bAdd.TabIndex = 9;
            this.bAdd.Text = "添加";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.Red;
            this.bDelete.Location = new System.Drawing.Point(133, 203);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(124, 40);
            this.bDelete.TabIndex = 10;
            this.bDelete.Text = "删除";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bServiced
            // 
            this.bServiced.BackColor = System.Drawing.Color.Yellow;
            this.bServiced.Location = new System.Drawing.Point(3, 203);
            this.bServiced.Name = "bServiced";
            this.bServiced.Size = new System.Drawing.Size(124, 40);
            this.bServiced.TabIndex = 13;
            this.bServiced.Text = "维护OK";
            this.bServiced.UseVisualStyleBackColor = false;
            this.bServiced.Click += new System.EventHandler(this.bServiced_Click);
            // 
            // lMonitor
            // 
            this.lMonitor.Location = new System.Drawing.Point(3, 60);
            this.lMonitor.Name = "lMonitor";
            this.lMonitor.Size = new System.Drawing.Size(124, 30);
            this.lMonitor.TabIndex = 6;
            this.lMonitor.Text = "监控时长(小时)";
            this.lMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lMonitorValue
            // 
            this.lMonitorValue.Location = new System.Drawing.Point(133, 63);
            this.lMonitorValue.Name = "lMonitorValue";
            this.lMonitorValue.Size = new System.Drawing.Size(100, 26);
            this.lMonitorValue.TabIndex = 7;
            this.lMonitorValue.Text = "24";
            // 
            // cbEnable
            // 
            this.cbEnable.AutoSize = true;
            this.cbEnable.Location = new System.Drawing.Point(133, 93);
            this.cbEnable.Name = "cbEnable";
            this.cbEnable.Size = new System.Drawing.Size(56, 24);
            this.cbEnable.TabIndex = 12;
            this.cbEnable.Text = "启用";
            this.cbEnable.UseVisualStyleBackColor = true;
            // 
            // fmServiceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGVItem);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmServiceManager";
            this.Text = "耗材管控";
            this.Load += new System.EventHandler(this.FmServiceManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tItemName;
        private System.Windows.Forms.TextBox tCurUse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lMonitorValue;
        private System.Windows.Forms.Label lMonitor;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.CheckBox cbEnable;
        private System.Windows.Forms.Button bServiced;
    }
}