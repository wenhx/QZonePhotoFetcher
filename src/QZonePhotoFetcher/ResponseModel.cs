/* Copyright 2013 wenhx, https://github.com/wenhx.

   This file is part of QZonePhotoFetcher.

   QZonePhotoFetcher是WooYun-2013-21225的演示项目，只作演示用途，任何人都可以下载代码和程序，并不受限制的修改和运行，但是不可以再分发。
   WooYun-2013-21225的详细信息请看http://www.wooyun.org/bugs/wooyun-2010-021225
*/
namespace QZonePhotoFetcher
{
    using System;
    using System.Collections.Generic;

    public class ResponseModel
    {
        public int Priv { get; set; }
        public string PriveateDisplayName 
        {
            get
            {
                switch (Priv)
                {
                    case 0:
                        return "公开";
                    case 1:
                        return "私密";
                    default:
                        return "未知";
                }
            }
        }
        public string Desc { get; set; }
        public int Count { get; set; }
        public ResponseItem[] Items { get; set; }
    }

    public class ResponseItem
    {
        public string Thumb { get; set; }
        public string Url { get; set; }
    }
}