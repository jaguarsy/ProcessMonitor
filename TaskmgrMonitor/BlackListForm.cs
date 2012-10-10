using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.haoest.Forms;
using TaskmgrMonitor.Controller;
using TaskmgrMonitor.Entity;
using TaskmgrMonitor.GlobalOptions;

namespace TaskmgrMonitor
{
    public partial class BlackListForm : Win8Form
    {
        //白名单动态数组
        private BlackProcessList processList = BlackProcessList.processList;

        public BlackListForm()
        {
            InitializeComponent();
        }

        private void BlackListForm_Load(object sender, EventArgs e)
        {
            //清空listBox
            listBox.Items.Clear();
            //反序列化xml，获取内容
            processList = XmlControl.GetBlack(GlobalConstants.BLACK_LIST_PATH);
            //获取白名单进程列表，增加到listBox中
            foreach (MyProcess p in processList.processes)
            {
                listBox.Items.Add(p.processName);
            }
        }
    }
}
