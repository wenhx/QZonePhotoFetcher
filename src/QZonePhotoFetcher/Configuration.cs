/* Copyright 2013 wenhx, https://github.com/wenhx.

   This file is part of QZonePhotoFetcher.

   QZonePhotoFetcher是WooYun-2013-21225的演示项目，只作演示用途，任何人都可以下载代码和程序，并不受限制的修改和运行，但是不可以再分发。
   WooYun-2013-21225的详细信息请看http://www.wooyun.org/bugs/wooyun-2010-021225
*/
namespace QZonePhotoFetcher
{
    using System;
    using System.Collections.Generic;

    public class Configuration
    {
        static readonly int _MaxThreadCount = 20;
        int m_ThreadCount;
        public int ThreadCount
        {
            get
            {
                return m_ThreadCount;
            }
            set
            {
                if (CheckThreadCount(value))
                {
                    m_ThreadCount = value;
                    System.Net.ServicePointManager.DefaultConnectionLimit = value;
                }
            }
        }

        private bool CheckThreadCount(int value)
        {
            if (value > 0 && value <= _MaxThreadCount)
                return true;
            return false;
        }
        public bool OnlyPraviatePhotoAlbum { get; set; }
        public int QQNumber { get; set; }
        public int StartFId { get; set; }
        public int EndFId { get; set; }
        public bool IsConfigurationValid()
        {
            if (ThreadCount <= 0 && ThreadCount > _MaxThreadCount)
                return false;
            if (QQNumber <= 10000)
                return false;
            if (StartFId <= 0)
                return false;
            if (StartFId > EndFId)
                return false;
            return true;
        }
        public ICollection<string> UpdateFromString(string qq, string start, string end, string threadCount)
        {
            List<string> result = new List<string>();
            int qqNumber;
            if (!int.TryParse(qq, out qqNumber))
            {
                result.Add("QQ号码必须是数字");
            }
            int startFId;
            if (!int.TryParse(start, out startFId) && startFId < 0)
            {
                result.Add("开始Id必须是数字，且大于0。");
            }
            int endFId;
            if (!int.TryParse(end, out endFId) && endFId < 0 && startFId > endFId)
            {
                result.Add("结束Id必须是数字，且大于开始Id。");
            }
            int count;
            if (!int.TryParse(threadCount, out count) && CheckThreadCount(count))
            {
                result.Add(string.Concat("线程数量必须大于0且小于",  _MaxThreadCount, "。"));
            }
            if (result.Count == 0)
            {
                QQNumber = qqNumber;
                StartFId = startFId;
                EndFId = endFId;
                ThreadCount = count;
            }
            return result;
        }
    }
}
