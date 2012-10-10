namespace TaskmgrMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始获取ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置白名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btStart = new System.Windows.Forms.Button();
            this.btWhiteList = new System.Windows.Forms.Button();
            this.buttonMonitor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemAddWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.从白名单删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonSetMonitor = new System.Windows.Forms.Button();
            this.btBlackList = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btBlackList);
            this.panel2.Controls.Add(this.buttonSetMonitor);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.buttonMonitor);
            this.panel2.Controls.Add(this.btWhiteList);
            this.panel2.Controls.Add(this.btStart);
            this.panel2.Size = new System.Drawing.Size(465, 416);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(60, 36);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(303, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始获取ToolStripMenuItem,
            this.设置白名单ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 开始获取ToolStripMenuItem
            // 
            this.开始获取ToolStripMenuItem.Name = "开始获取ToolStripMenuItem";
            this.开始获取ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.开始获取ToolStripMenuItem.Text = "开始获取";
            // 
            // 设置白名单ToolStripMenuItem
            // 
            this.设置白名单ToolStripMenuItem.Name = "设置白名单ToolStripMenuItem";
            this.设置白名单ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.设置白名单ToolStripMenuItem.Text = "设置白名单";
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btStart.FlatAppearance.BorderSize = 0;
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.Location = new System.Drawing.Point(11, 375);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(65, 30);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "刷新数据";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btWhiteList
            // 
            this.btWhiteList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btWhiteList.FlatAppearance.BorderSize = 0;
            this.btWhiteList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWhiteList.Location = new System.Drawing.Point(82, 375);
            this.btWhiteList.Name = "btWhiteList";
            this.btWhiteList.Size = new System.Drawing.Size(65, 30);
            this.btWhiteList.TabIndex = 3;
            this.btWhiteList.Text = "白名单";
            this.btWhiteList.UseVisualStyleBackColor = false;
            this.btWhiteList.Click += new System.EventHandler(this.btWhiteList_Click);
            // 
            // buttonMonitor
            // 
            this.buttonMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMonitor.FlatAppearance.BorderSize = 0;
            this.buttonMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMonitor.Location = new System.Drawing.Point(153, 375);
            this.buttonMonitor.Name = "buttonMonitor";
            this.buttonMonitor.Size = new System.Drawing.Size(65, 30);
            this.buttonMonitor.TabIndex = 4;
            this.buttonMonitor.Text = "开始监控";
            this.buttonMonitor.UseVisualStyleBackColor = false;
            this.buttonMonitor.Click += new System.EventHandler(this.buttonMonitor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.processName,
            this.workingSet,
            this.startTime,
            this.fullName});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(443, 357);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // processName
            // 
            this.processName.HeaderText = "进程名";
            this.processName.Name = "processName";
            this.processName.ReadOnly = true;
            // 
            // workingSet
            // 
            this.workingSet.HeaderText = "内存";
            this.workingSet.Name = "workingSet";
            this.workingSet.ReadOnly = true;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "时间";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "全称";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddWhite,
            this.从白名单删除ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 48);
            // 
            // ToolStripMenuItemAddWhite
            // 
            this.ToolStripMenuItemAddWhite.Name = "ToolStripMenuItemAddWhite";
            this.ToolStripMenuItemAddWhite.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItemAddWhite.Text = "添加到白名单";
            this.ToolStripMenuItemAddWhite.Click += new System.EventHandler(this.ToolStripMenuItemAddWhite_Click);
            // 
            // 从白名单删除ToolStripMenuItem
            // 
            this.从白名单删除ToolStripMenuItem.Name = "从白名单删除ToolStripMenuItem";
            this.从白名单删除ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.从白名单删除ToolStripMenuItem.Text = "从白名单删除";
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonSetMonitor
            // 
            this.buttonSetMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSetMonitor.FlatAppearance.BorderSize = 0;
            this.buttonSetMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetMonitor.Location = new System.Drawing.Point(224, 375);
            this.buttonSetMonitor.Name = "buttonSetMonitor";
            this.buttonSetMonitor.Size = new System.Drawing.Size(65, 30);
            this.buttonSetMonitor.TabIndex = 6;
            this.buttonSetMonitor.Text = "监控设置";
            this.buttonSetMonitor.UseVisualStyleBackColor = false;
            // 
            // btBlackList
            // 
            this.btBlackList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btBlackList.FlatAppearance.BorderSize = 0;
            this.btBlackList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBlackList.Location = new System.Drawing.Point(295, 375);
            this.btBlackList.Name = "btBlackList";
            this.btBlackList.Size = new System.Drawing.Size(65, 30);
            this.btBlackList.TabIndex = 7;
            this.btBlackList.Text = "黑名单";
            this.btBlackList.UseVisualStyleBackColor = false;
            this.btBlackList.Click += new System.EventHandler(this.btBlackList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 479);
            this.FormIconImage = ((System.Drawing.Image)(resources.GetObject("$this.FormIconImage")));
            this.MainMenu = this.menuStrip;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MinimumSize = new System.Drawing.Size(467, 425);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "任务管理器监控工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btWhiteList;
        private System.Windows.Forms.ToolStripMenuItem 开始获取ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置白名单ToolStripMenuItem;
        private System.Windows.Forms.Button buttonMonitor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn processName;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddWhite;
        private System.Windows.Forms.ToolStripMenuItem 从白名单删除ToolStripMenuItem;
        private System.Windows.Forms.Button buttonSetMonitor;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btBlackList;
    }
}

