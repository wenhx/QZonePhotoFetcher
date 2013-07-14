/* Copyright 2013 wenhx, https://github.com/wenhx.

   This file is part of QZonePhotoFetcher.

   QZonePhotoFetcher是WooYun-2013-21225的演示项目，只作演示用途，任何人都可以下载代码和程序，并不受限制的修改和运行，但是不可以再分发。
   WooYun-2013-21225的详细信息请看http://www.wooyun.org/bugs/wooyun-2010-021225
*/
namespace QZonePhotoFetcher
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;

    public class FetcherManager
    {
        public static void FetchPhotoUrl(int qqNumber, Action<ICollection<ResponseModel>> got)
        {
            var config = GlobalConfiguration.Configuration;
            int length = (config.EndFId - config.StartFId) / config.ThreadCount;
            int start = config.StartFId;
            for (int i = 0; i < config.ThreadCount; i++)
            {
                Fetcher fetcher = new Fetcher(start, start + length);
                System.Diagnostics.Debug.WriteLine(string.Format("start: {0}, length: {1}", start, start + length));
                ThreadPool.QueueUserWorkItem(delegate(object state) 
                {
                    var f = (Fetcher)state;
                    var models = f.GetPhotoUrls(qqNumber);
                    if (models.Count > 0)
                    {
                        got(models);
                    }
                }, fetcher);
                start = start + length;
            }
        }
        public static void FetchPhotoImage(ResponseModel model)
        {
            if (model == null)
                return;

            LoggerHelper.WriteLine("开始下载{0}相册《{1}》，共有{2}张。",
                model.PriveateDisplayName, model.Desc, model.Count);
            if (GlobalConfiguration.Store != null)
            {
                GlobalConfiguration.Store.Store(model);
            }
            else
            {
                LoggerHelper.WriteLine("没有发现存储组件，相册《{0}》存储失败。〉", model.Desc);
            }
        }
        public static void FetchPhotoImage(IEnumerable<ResponseModel> models)
        {
            foreach (var item in models)
            {
                FetchPhotoImage(item);
            }
        }
    }
}