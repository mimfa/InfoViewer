namespace MiMFa.UIL.InfoViewer
{
    partial class ListViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewer));
            this.btn_exit = new System.Windows.Forms.Button();
            this.p_Open = new System.Windows.Forms.Panel();
            this.tb_SelectPath = new System.Windows.Forms.TextBox();
            this.btn_SelectPath = new System.Windows.Forms.Button();
            this.l_GetFileInfo = new System.Windows.Forms.Label();
            this.btn_Done = new System.Windows.Forms.Button();
            this.InfoGrid = new System.Windows.Forms.DataGridView();
            this.dgv_tb_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tb_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_Open.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.AutoSize = true;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(570, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(28, 28);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "✕";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // p_Open
            // 
            this.p_Open.AutoSize = true;
            this.p_Open.Controls.Add(this.tb_SelectPath);
            this.p_Open.Controls.Add(this.btn_SelectPath);
            this.p_Open.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Open.Location = new System.Drawing.Point(10, 31);
            this.p_Open.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.p_Open.Name = "p_Open";
            this.p_Open.Padding = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.p_Open.Size = new System.Drawing.Size(578, 46);
            this.p_Open.TabIndex = 13;
            // 
            // tb_SelectPath
            // 
            this.tb_SelectPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SelectPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_SelectPath.Location = new System.Drawing.Point(46, 12);
            this.tb_SelectPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_SelectPath.Name = "tb_SelectPath";
            this.tb_SelectPath.ReadOnly = true;
            this.tb_SelectPath.Size = new System.Drawing.Size(527, 22);
            this.tb_SelectPath.TabIndex = 0;
            this.tb_SelectPath.TabStop = false;
            // 
            // btn_SelectPath
            // 
            this.btn_SelectPath.AutoSize = true;
            this.btn_SelectPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_SelectPath.FlatAppearance.BorderSize = 0;
            this.btn_SelectPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectPath.Font = new System.Drawing.Font("Microsoft YaHei", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectPath.Location = new System.Drawing.Point(5, 12);
            this.btn_SelectPath.Margin = new System.Windows.Forms.Padding(0);
            this.btn_SelectPath.Name = "btn_SelectPath";
            this.btn_SelectPath.Size = new System.Drawing.Size(41, 22);
            this.btn_SelectPath.TabIndex = 8;
            this.btn_SelectPath.Text = "Select";
            this.btn_SelectPath.UseVisualStyleBackColor = false;
            this.btn_SelectPath.Click += new System.EventHandler(this.btn_SelectPath_Click);
            // 
            // l_GetFileInfo
            // 
            this.l_GetFileInfo.BackColor = System.Drawing.Color.Transparent;
            this.l_GetFileInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_GetFileInfo.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_GetFileInfo.Location = new System.Drawing.Point(10, 0);
            this.l_GetFileInfo.Name = "l_GetFileInfo";
            this.l_GetFileInfo.Size = new System.Drawing.Size(578, 31);
            this.l_GetFileInfo.TabIndex = 10;
            this.l_GetFileInfo.Text = "Properties";
            this.l_GetFileInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Done
            // 
            this.btn_Done.AutoSize = true;
            this.btn_Done.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Done.Location = new System.Drawing.Point(246, 0);
            this.btn_Done.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Padding = new System.Windows.Forms.Padding(6);
            this.btn_Done.Size = new System.Drawing.Size(80, 40);
            this.btn_Done.TabIndex = 16;
            this.btn_Done.Text = "Save Info";
            this.btn_Done.UseVisualStyleBackColor = false;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // InfoGrid
            // 
            this.InfoGrid.AllowUserToAddRows = false;
            this.InfoGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.InfoGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InfoGrid.ColumnHeadersVisible = false;
            this.InfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_tb_Name,
            this.dgv_tb_Value});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.InfoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoGrid.Location = new System.Drawing.Point(3, 4);
            this.InfoGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoGrid.Name = "InfoGrid";
            this.InfoGrid.ReadOnly = true;
            this.InfoGrid.RowHeadersVisible = false;
            this.InfoGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Empty;
            this.InfoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InfoGrid.Size = new System.Drawing.Size(572, 381);
            this.InfoGrid.TabIndex = 17;
            this.InfoGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_fileinfo_CellDoubleClick);
            // 
            // dgv_tb_Name
            // 
            this.dgv_tb_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgv_tb_Name.Frozen = true;
            this.dgv_tb_Name.HeaderText = "Name";
            this.dgv_tb_Name.Name = "dgv_tb_Name";
            this.dgv_tb_Name.ReadOnly = true;
            this.dgv_tb_Name.Width = 5;
            // 
            // dgv_tb_Value
            // 
            this.dgv_tb_Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgv_tb_Value.HeaderText = "Value";
            this.dgv_tb_Value.Name = "dgv_tb_Value";
            this.dgv_tb_Value.ReadOnly = true;
            this.dgv_tb_Value.Width = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.InfoGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 77);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 437);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Done, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 393);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(572, 40);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.p_Open);
            this.panel1.Controls.Add(this.l_GetFileInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel1.Size = new System.Drawing.Size(600, 526);
            this.panel1.TabIndex = 19;
            // 
            // ListViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 526);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListViewer";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiMFa Get File Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowInfo_FormClosing);
            this.p_Open.ResumeLayout(false);
            this.p_Open.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel p_Open;
        private System.Windows.Forms.TextBox tb_SelectPath;
        private System.Windows.Forms.Button btn_SelectPath;
        private System.Windows.Forms.Label l_GetFileInfo;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.DataGridView InfoGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tb_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tb_Value;
        private System.Windows.Forms.Panel panel1;
    }
}

