using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.cage.InputBox
{
    /// <summary>
    /// 输入框
    /// <para>作者：商煜</para>
    /// </summary>
    public class InputBox : Form
    {
        const int AW_HOR_POSITIVE = 0x0001;         //从左向右显示
        const int AW_HOR_NEGATIVE = 0x0002;         //从右到左显示
        const int AW_VER_POSITIVE = 0X0004;         //从上到下显示
        const int AW_VER_NEGATIVE = 0x0008;         //从下到上显示         
        const int AW_CENTER = 0x0010;               //若使用了AW_HIDE标志，则使窗口向内重叠，即收缩窗口；否则使窗口向外扩展，即展开窗口
        const int AW_HIDE = 0x10000;                //隐藏窗口，缺省则显示窗口
        const int AW_ACTIVATE = 0x20000;            //激活窗口。在使用了AW_HIDE标志后不能使用这个标志
        const int AW_SLIDE = 0x40000;               //使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略
        const int AW_BLEND = 0x80000;               //透明度从高到低

        private Button buttonClose;
        private Button buttonMin;
        private Label labelTitle;
        private Panel panelBottom;
        private Button buttonOK;
        private Label labelText;
        private TextBox textboxValue;
        private Panel mainPanel;
        private TableLayoutPanel tableLayoutPanelTop;

        private void InitializeComponent()
        {
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.textboxValue = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelTop.Controls.Add(this.buttonClose, 2, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonMin, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(327, 25);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = global::com.cage.InputBox.Properties.Resources.close_0;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(297, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 25);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseClick);
            // 
            // buttonMin
            // 
            this.buttonMin.BackgroundImage = global::com.cage.InputBox.Properties.Resources.min_0;
            this.buttonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Location = new System.Drawing.Point(267, 0);
            this.buttonMin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(30, 25);
            this.buttonMin.TabIndex = 1;
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(267, 30);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "标题";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseMove);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBottom.Controls.Add(this.buttonOK);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 118);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(327, 34);
            this.panelBottom.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(270, 0);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(57, 34);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BackColor = System.Drawing.Color.Transparent;
            this.labelText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelText.Location = new System.Drawing.Point(22, 45);
            this.labelText.Margin = new System.Windows.Forms.Padding(0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(32, 17);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "提示";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textboxValue
            // 
            this.textboxValue.Location = new System.Drawing.Point(25, 76);
            this.textboxValue.Name = "textboxValue";
            this.textboxValue.Size = new System.Drawing.Size(280, 21);
            this.textboxValue.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.panelBottom);
            this.mainPanel.Controls.Add(this.textboxValue);
            this.mainPanel.Controls.Add(this.tableLayoutPanelTop);
            this.mainPanel.Controls.Add(this.labelText);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(329, 154);
            this.mainPanel.TabIndex = 4;
            // 
            // InputBox
            // 
            this.AcceptButton = this.buttonOK;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(329, 154);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        public InputBox()
        {
            InitializeComponent();
        }

        public void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AnimateWindow(this.FindForm().Handle, 400, AW_BLEND | AW_HIDE | AW_CENTER);
                this.Close();
            }
        }

        /// <summary>
        /// InputBox的静态函数，返回输入的字符串
        /// </summary>
        /// <param name="Title">窗口标题</param>
        /// <param name="Text">提示文本</param>
        /// <param name="DefaultValue">默认值</param>
        /// <returns>返回字符串</returns>
        public static string Input(string Title, string Text, string DefaultValue)
        {
            InputBox inputBox = new InputBox();
            inputBox.labelTitle.Text = Title;
            inputBox.labelText.Text = Text;
            DialogResult result = inputBox.ShowDialog();
            if (result == DialogResult.OK)
                return inputBox.textboxValue.Text;
            else
                return DefaultValue;
        }

        #region 窗口拖动
        private Point oldPoint;
        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            oldPoint.X = e.X;
            oldPoint.Y = e.Y;
        }

        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += (e.X - oldPoint.X);
                this.Top += (e.Y - oldPoint.Y);
            }
        }
        #endregion

        /// <summary>
        /// 窗体动画
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="dwTime"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32")]       //使用AnimateWindow（）函数必备
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
    }
}
