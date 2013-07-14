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
    using System.Xml;
    using System.Xml.Xsl;

    public class XmlFileStore : IStore
    {
        public void Store(ResponseModel model)
        {
            var xmlFileName = model.Desc + ".xml";
            using (XmlTextWriter writer = new XmlTextWriter(xmlFileName, Encoding.UTF8))
            {
                writer.WriteStartDocument();
                var stylesheet = "type='text/xsl' href='album.xsl'";
                writer.WriteProcessingInstruction("xml-stylesheet", stylesheet);
                writer.WriteStartElement("album");
                writer.WriteElementString("name", model.Desc);
                writer.WriteStartElement("photos");
                foreach (var item in model.Items)
                {
                    writer.WriteStartElement("photo");
                    writer.WriteElementString("url", item.Url);
                    writer.WriteElementString("thumb", item.Thumb);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            XslTransform xsltransform = new XslTransform();
            xsltransform.Load("album.xslt");
            xsltransform.Transform(xmlFileName, model.Desc + ".html", null);
            System.IO.File.Delete(xmlFileName);
        }
    }
}
