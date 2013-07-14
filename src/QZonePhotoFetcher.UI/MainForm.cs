/* Copyright 2013 wenhx, https://github.com/wenhx.

   This file is part of QZonePhotoFetcher.

   QZonePhotoFetcher是WooYun-2013-21225的演示项目，只作演示用途，任何人都可以下载代码和程序，并不受限制的修改和运行，但是不可以再分发。
   WooYun-2013-21225的详细信息请看http://www.wooyun.org/bugs/wooyun-2010-021225
*/
namespace QZonePhotoFetcher.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        static readonly string _ErrorTitle = "错误";

        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            GlobalConfiguration.Logger = new TextBoxConsole(UI_Textbox_Console);
            GlobalConfiguration.Store = new XmlFileStore();
            GlobalConfiguration.ErrorHandler = new DefaultErrorHandler();
        }

        private void UI_Button_GO_Click(object sender, EventArgs e)
        {
            if (!PrepareFetch())
                return;
            
            try
            {
                FetcherManager.FetchPhotoUrl(GlobalConfiguration.Configuration.QQNumber,
                    models =>
                    {
                        DownloadPhotoList(models);
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, _ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool PrepareFetch()
        {
            var messages = GlobalConfiguration.Configuration.UpdateFromString(
                UI_TextBox_QQNumber.Text, UI_TextBox_StartFId.Text, UI_TextBox_EndFId.Text, UI_NumberUpDown_ThreadCount.Value.ToString());
            if (messages.Count == 0)
            {
                UI_Textbox_Console.Clear();
                return true;
            }
            Alert(string.Join(Environment.NewLine, new List<string>(messages).ToArray()));
            return false;
        }

        private static void Alert(string message)
        {
            MessageBox.Show(message, _ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DownloadPhotoList(ICollection<ResponseModel> models)
        {
            if (models.Count == 0)
                return;

            FetcherManager.FetchPhotoImage(models);
        }
    }
}
