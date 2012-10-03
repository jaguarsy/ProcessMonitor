using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TaskmgrMonitor.Entity
{
    /// <summary>
    /// 黑名单进程列表
    /// </summary>
    [XmlRoot("processList")]
    public class BlackProcessList
    {
        private static BlackProcessList processListInstance;

        public static BlackProcessList processList
        {
            get
            {
                if (processListInstance == null)
                    processListInstance = new BlackProcessList();
                return processListInstance;
            }
        }

        private BlackProcessList() { }

        [XmlElement("processes")]
        public List<MyProcess> processes = new List<MyProcess>();
    }
}
