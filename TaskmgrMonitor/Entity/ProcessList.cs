using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TaskmgrMonitor.Entity
{
    /// <summary>
    /// 白名单进程列表
    /// </summary>
    [XmlRoot("processList")]
    public class WhiteProcessList
    {
        private static WhiteProcessList processListInstance;

        public static WhiteProcessList processList
        {
            get
            {
                if (processListInstance == null)
                    processListInstance = new WhiteProcessList();
                return processListInstance;
            }
        }

        private WhiteProcessList() { }

        [XmlElement("processes")]
        public List<MyProcess> processes = new List<MyProcess>();
    }
}
