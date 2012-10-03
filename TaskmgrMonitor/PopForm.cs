using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaskmgrMonitor
{
    public partial class PopForm : Form
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

        public PopForm()
        {
            InitializeComponent();
        }

        private void PopForm_Load(object sender, EventArgs e)
        {
            //获取屏幕的高度
            int Heightone = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            //获取工作区的高度
            int Heighttwo = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            //获取屏幕的宽度
            int screenX = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            //屏幕的高度减去工作区的高度，得到任务栏的高度，只所以获取任务栏的高度，
            //是由于一些时候任务栏的高度不固定。避免窗体被任务栏遮挡住
            int renwu = Heightone - Heighttwo;
            //距离上边的距离＝屏幕的高度－窗体的高度－任务栏的高度
            this.Top = Heightone - this.Height - renwu;
            //距离左边的距离＝屏幕的宽度－窗体的宽度
            this.Left = screenX - 290;           
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value == 0)
            {
                timer.Stop();
                AnimateWindow(this.FindForm().Handle, 400, AW_BLEND | AW_HIDE | AW_CENTER);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        /// <summary>
        /// 窗体动画
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="dwTime"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32")]       //使用AnimateWindow（）函数必备
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        /// <summary>
        /// 静态方法，显示弹出窗口
        /// </summary>
        /// <param name="Title">窗口标题</param>
        /// <param name="Text">提示内容</param>
        /// <returns>返回结果</returns>
        public static DialogResult popShow(string Title, string Text)
        {
            PopForm popForm = new PopForm();
            popForm.labelTitle.Text = Title;
            popForm.labelText.Text = Text;
            DialogResult result = popForm.ShowDialog();
            return result;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
