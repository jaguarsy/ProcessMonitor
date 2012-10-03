using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using com.haoest.Forms;
using System.Threading;
using TaskmgrMonitor.Controller;
using TaskmgrMonitor.Entity;

namespace TaskmgrMonitor
{
    public partial class MainForm : Win8Form
    {
        //进程列表
        private Process[] sysProcess;
        //白名单列表
        private WhiteListForm whiteList = new WhiteListForm();
        private WhiteProcessList whiteProcessList = WhiteProcessList.processList;

        public MainForm()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.MultiSelect = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            whiteProcessList = XmlControl.GetWhite(@".\process.xml");
        }

        //刷新数据
        private void btStart_Click(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        //在dataGridView上双击
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int processId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    ShowProcessInfo(Process.GetProcessById(processId));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常,原因是：" + ex.Message);
            }
        }

        //获取所有进程
        private void GetAllProcess()
        {
            dataGridView1.Rows.Clear();
            sysProcess = Process.GetProcesses();
            foreach (Process p in sysProcess)
            {
                int newRowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[newRowIndex];
                row.Cells[0].Value = p.Id;
                row.Cells[1].Value = p.ProcessName;
                row.Cells[2].Value = string.Format("{0:###,##0.00}MB", p.WorkingSet64 / 1024.0f / 1024.0f);
                //有些进程无法获取启动时间和文件名信息，所以要用try/catch
                try
                {
                    row.Cells[3].Value = string.Format("{0}", p.StartTime);
                    row.Cells[4].Value = p.MainModule.FileName;
                }
                catch
                {
                    row.Cells[3].Value = "";
                    row.Cells[4].Value = "";
                }
            }
        }

        //显示进程详细信息
        private void ShowProcessInfo(Process p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("进程名称：" + p.ProcessName + "，  ID：" + p.Id);
            try
            {
                sb.AppendLine("进程优先级：" + p.BasePriority + "（优先级类别： " + p.PriorityClass + "）");
                ProcessModule m = p.MainModule;
                sb.AppendLine("文件名：" + m.FileName);
                sb.AppendLine("版本：" + m.FileVersionInfo.FileVersion);
                sb.AppendLine("描述：" + m.FileVersionInfo.FileDescription);
                sb.AppendLine("语言：" + m.FileVersionInfo.Language);
                sb.AppendLine("------------------------");
                if (p.Modules != null)
                {
                    ProcessModuleCollection pmc = p.Modules;
                    sb.AppendLine("调用的模块(.dll)：");
                    for (int i = 1; i < pmc.Count; i++)
                    {
                        sb.AppendLine(
                            "模块名：" + pmc[i].ModuleName + "\t" +
                            "版本：" + pmc[i].FileVersionInfo.FileVersion + "\t" +
                            "描述：" + pmc[i].FileVersionInfo.FileDescription);
                    }
                }
            }
            catch
            {
                sb.AppendLine("其他信息：无法获取");
            }
            MessageBox.Show(sb.ToString(), "详细信息");
        }

        //显示白名单
        private void btWhiteList_Click(object sender, EventArgs e)
        {
            whiteList.ShowDialog();
        }

        //添加到白名单
        private void ToolStripMenuItemAddWhite_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    string s = dataGridView1.SelectedRows[i].Cells[1].Value.ToString();
                    if (s != null)
                    {
                        MyProcess p = new MyProcess(s);
                        if (!findProcessInWhite(p))
                        {
                            //添加过程
                            whiteProcessList.processes.Add(new MyProcess(s));
                            XmlControl.SetWhite(@".\process.xml", whiteProcessList);
                            MessageBox.Show("添加成功！", "提示");
                        }
                        else
                        {
                            MessageBox.Show("已存在。", "提示");
                        }
                    }
                }
            }
        }

        //寻找某个元素
        private bool findProcessInWhite(MyProcess p)
        {
            foreach (MyProcess tmp in whiteProcessList.processes)
            {
                if (tmp.processName.Equals(p.processName)) return true;
            }
            return false;
        }

        private bool isMonitor = false;
        //开始监控
        private void buttonMonitor_Click(object sender, EventArgs e)
        {
            if (!isMonitor)
            {
                timer.Start();
                buttonMonitor.Text = "停止监控";
                isMonitor = true;
            }
            else
            {
                timer.Stop();
                buttonMonitor.Text = "开始监控";
                isMonitor = false;
            }
        }

        //进程监控
        private void timer_Tick(object sender, EventArgs e)
        {
            sysProcess = Process.GetProcesses();
            MyProcess mp = new MyProcess();
            foreach (Process p in sysProcess)
            {
                if (p.ProcessName != null)
                {
                    mp.processName = p.ProcessName;
                    if (!findProcessInWhite(mp))
                    {
                        //暂时将计时器停止
                        timer.Stop();
                        if (PopForm.popShow("提示", "进程" + mp.processName +
                            "不在白名单中，是否关闭？\n\n点击是则将其关闭；\n点击否则将其加入白名单。\n不做任何处理则视为否。"
                            ) == DialogResult.OK)
                        {
                            //强制进程退出，丢失所有的资源和数据
                            //结束没有图像界面的应用程序只能用这个方法
                            p.Kill();
                        }
                        else
                        {
                            whiteProcessList.processes.Add(new MyProcess(mp.processName));
                            XmlControl.SetWhite(@".\process.xml", whiteProcessList);
                        }
                        //重新开启
                        timer.Start();
                    }
                }
            }
        }
    }
}
