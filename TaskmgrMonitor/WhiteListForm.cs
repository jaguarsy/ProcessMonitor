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
using TaskmgrMonitor.GlobalOptions;

namespace TaskmgrMonitor
{
    /// <summary>
    /// 白名单窗口
    /// <para>作者：商煜</para>
    /// </summary>
    public partial class WhiteListForm : Win8Form
    {
        //白名单动态数组
        private WhiteProcessList processList = WhiteProcessList.processList;

        public WhiteListForm()
        {
            InitializeComponent();
        }

        //窗体加载事件
        private void WhiteList_Load(object sender, EventArgs e)
        {
            //清空listBox
            listBox.Items.Clear();
            //反序列化xml，获取内容
            processList = XmlControl.GetWhite(GlobalConstants.WHITE_LIST_PATH);
            //获取白名单进程列表，增加到listBox中
            foreach (MyProcess p in processList.processes)
            {
                listBox.Items.Add(p.processName);
            }
        }

        //单击增加按钮
        private void btAdd_Click(object sender, EventArgs e)
        {
            //显示InputBox，等待用户输入
            string name = InputBox.Input("添加到白名单", "请输入进程名称", "");
            //当输入不为空值时
            if (name != "")
            {
                //增加进程名到listBox
                listBox.Items.Add(name);
                //增加进程到白名单列表
                processList.processes.Add(new MyProcess(name));
                //写入xml保存
                XmlControl.SetWhite(GlobalConstants.WHITE_LIST_PATH, processList);
            }
        }

        //单击删除按钮
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //初始化一个对象数组，长度等于listBox中被选中项的个数
            object[] selected_objs = new object[listBox.SelectedItems.Count];
            //将listBox中被选中的项复制到这个对象数组中去
            listBox.SelectedItems.CopyTo(selected_objs, 0);
            //枚举这个对象数组中的对象
            foreach (object oval in selected_objs)
            {
                //在listBox删除这个对象
                listBox.Items.Remove(oval);
            }
            //删除白名单中所有的进程
            processList.processes.Clear();
            //更新进程名
            foreach (string s in listBox.Items)
            {
                processList.processes.Add(new MyProcess(s));
            }
            //写入xml
            XmlControl.SetWhite(GlobalConstants.WHITE_LIST_PATH, processList);
        }

        //单击listBox
        private void listBox_MouseClick(object sender, MouseEventArgs e)
        {
            //如果listBox中被选中项个数大于0
            if (listBox.SelectedItems.Count > 0)
            {
                //激活删除按钮
                buttonDelete.Enabled = true;
            }
        }
    }
}
