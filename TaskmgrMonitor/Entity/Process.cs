using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TaskmgrMonitor.Entity
{
    /// <summary>
    /// 进程类
    /// </summary>
    public class MyProcess
    {
        private string name;

        public MyProcess() { }

        public MyProcess(string name)
        {
            this.name = name;
        }

        [XmlElement("processname")]
        public string processName
        {
            get { return name; }
            set { name = value; }
        }
    }
}
