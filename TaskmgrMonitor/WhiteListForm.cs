using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;

using com.haoest.Forms;
using TaskmgrMonitor.Controller;
using TaskmgrMonitor.Entity;
using com.cage.InputBox;

namespace TaskmgrMonitor
{
    public partial class WhiteListForm : Win8Form
    {
        private WhiteProcessList processList = WhiteProcessList.processList;

        public WhiteListForm()
        {
            InitializeComponent();
        }

        private void WhiteList_Load(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            processList = XmlControl.GetWhite(".\\process.xml");
            foreach (MyProcess p in processList.processes)
            {
                listBox.Items.Add(p.processName);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //processList.processes.Add(new Process("Idle"));
            //XmlControl.Set(".\\process.xml", processList);
            string name = InputBox.Input("添加到白名单", "请输入进程名称", "");
            if (name != "")
            {
                listBox.Items.Add(name);
                processList.processes.Add(new MyProcess(name));
                XmlControl.SetWhite(".\\process.xml", processList);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            object[] selected_objs = new object[listBox.SelectedItems.Count];
            listBox.SelectedItems.CopyTo(selected_objs, 0);
            foreach (object oval in selected_objs)
            {
                listBox.Items.Remove(oval);
            }
            //删除所有
            processList.processes.Clear();
            foreach (string s in listBox.Items)
            {
                processList.processes.Add(new MyProcess(s));
            }
            XmlControl.SetWhite(".\\process.xml", processList);
        }

        private void listBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox.SelectedItems.Count > 0)
            {
                buttonDelete.Enabled = true;
            }
        }
    }
}
