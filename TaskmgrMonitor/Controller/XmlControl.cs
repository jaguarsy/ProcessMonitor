using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using TaskmgrMonitor.Entity;

namespace TaskmgrMonitor.Controller
{
    /// <summary>
    /// xml序列化与反序列化类
    /// </summary>
    public static class XmlControl
    {
        //白名单列表
        private static WhiteProcessList whiteProcessList = null;
        //黑名单列表
        private static BlackProcessList blackProcessList = null;

        #region 通过文件流反序列化进程类
        /// <summary>
        /// 通过文件流反序列化试卷
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns>进程类</returns>
        public static WhiteProcessList GetWhite(String path)
        {
            if (whiteProcessList == null)
            {
                FileStream fs = null;
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(WhiteProcessList));
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    whiteProcessList = (WhiteProcessList)xs.Deserialize(fs);
                    fs.Close();
                    return whiteProcessList;
                }
                catch
                {
                    if (fs != null)
                        fs.Close();
                    throw new Exception("Xml deserialization failed!");
                }
            }
            else
            {
                return whiteProcessList;
            }
        }
        #endregion

        #region 将进程序列化为xml
        /// <summary>
        /// 将进程序列化为xml
        /// </summary>
        /// <param name="path">文件保存路径</param>
        /// <param name="examPaper">进程类实例</param>
        public static void SetWhite(string path, WhiteProcessList processlst)
        {
            if (processlst == null)
                throw new Exception("Parameter ExaminationPaper is null!");

            FileStream fs = null;
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(WhiteProcessList));
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                long fileLength = fs.Length;//获取流的长度
                xs.Serialize(fs, processlst);
                fs.Close();
            }
            catch
            {
                if (fs != null)
                    fs.Close();
                throw new Exception("Xml serialization failed!");
            }
        }
        #endregion

        #region 通过文件流反序列化进程类
        /// <summary>
        /// 通过文件流反序列化试卷
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns>进程类</returns>
        public static BlackProcessList GetBlack(String path)
        {
            if (blackProcessList == null)
            {
                FileStream fs = null;
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(BlackProcessList));
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    blackProcessList = (BlackProcessList)xs.Deserialize(fs);
                    fs.Close();
                    return blackProcessList;
                }
                catch
                {
                    if (fs != null)
                        fs.Close();
                    throw new Exception("Xml deserialization failed!");
                }
            }
            else
            {
                return blackProcessList;
            }
        }
        #endregion

        #region 将进程序列化为xml
        /// <summary>
        /// 将进程序列化为xml
        /// </summary>
        /// <param name="path">文件保存路径</param>
        /// <param name="examPaper">进程类实例</param>
        public static void SetBlack(string path, BlackProcessList processlst)
        {
            if (processlst == null)
                throw new Exception("Parameter ExaminationPaper is null!");

            FileStream fs = null;
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(WhiteProcessList));
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                long fileLength = fs.Length;//获取流的长度
                xs.Serialize(fs, processlst);
                fs.Close();
            }
            catch
            {
                if (fs != null)
                    fs.Close();
                throw new Exception("Xml serialization failed!");
            }
        }
        #endregion
    }
}
