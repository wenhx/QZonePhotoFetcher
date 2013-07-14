/* Copyright 2013 wenhx, https://github.com/wenhx.

   This file is part of QZonePhotoFetcher.

   QZonePhotoFetcher是WooYun-2013-21225的演示项目，只作演示用途，任何人都可以下载代码和程序，并不受限制的修改和运行，但是不可以再分发。
   WooYun-2013-21225的详细信息请看http://www.wooyun.org/bugs/wooyun-2010-021225
*/
namespace QZonePhotoFetcher
{
    using System;

    public static class GlobalConfiguration
    {
        static readonly Configuration _DefaultConfiguration = new Configuration 
        {
            ThreadCount = 2,
            StartFId = 0,
            EndFId = 100000,
            OnlyPraviatePhotoAlbum = false,
            QQNumber = 10000 /*马总？*/
        };

        public static Configuration Configuration 
        {
            get
            {
                return _DefaultConfiguration;
            }
        }
        public static ILogger Logger { get; set; }
        public static IErrorHandler ErrorHandler { get; set; }
        public static IStore Store { get; set; }
    }
}
