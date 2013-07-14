/* Copyright 2013 wenhx, https://github.com/wenhx.

   This file is part of QZonePhotoFetcher.

   QZonePhotoFetcher是WooYun-2013-21225的演示项目，只作演示用途，任何人都可以下载代码和程序，并不受限制的修改和运行，但是不可以再分发。
   WooYun-2013-21225的详细信息请看http://www.wooyun.org/bugs/wooyun-2010-021225
*/
namespace QZonePhotoFetcher.UI
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    class TextBoxConsole : ILogger
    {
        TextBox m_Instance;

        public TextBoxConsole(TextBox box)
        {
            if (box == null)
                throw new ArgumentNullException();

            m_Instance = box;
        }

        public void WriteLine(string message)
        {
            if (message == null)
                throw new ArgumentNullException();

            lock (typeof(TextBoxConsole))
            {
                MethodInvoker method = new MethodInvoker(delegate
                {
                    m_Instance.AppendText(string.Format("{0}: {1}\r\n", DateTime.Now, message));
                });
                m_Instance.BeginInvoke(method);
            }
        }

        public void WriteLine(string format, params object[] args)
        {
            WriteLine(string.Format(format, args));
        }
    }
}