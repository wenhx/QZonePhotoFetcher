/* Copyright 2013 wenhx, https://github.com/wenhx.

   This file is part of QZonePhotoFetcher.

   QZonePhotoFetcher是WooYun-2013-21225的演示项目，只作演示用途，任何人都可以下载代码和程序，并不受限制的修改和运行，但是不可以再分发。
   WooYun-2013-21225的详细信息请看http://www.wooyun.org/bugs/wooyun-2010-021225
*/
namespace QZonePhotoFetcher.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UI_TextBox_QQNumber = new System.Windows.Forms.TextBox();
            this.UI_Button_GO = new System.Windows.Forms.Button();
            this.UI_Textbox_Console = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UI_TextBox_StartFId = new System.Windows.Forms.TextBox();
            this.UI_TextBox_EndFId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UI_NumberUpDown_ThreadCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumberUpDown_ThreadCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "号 码：";
            // 
            // UI_TextBox_QQNumber
            // 
            this.UI_TextBox_QQNumber.Location = new System.Drawing.Point(86, 13);
            this.UI_TextBox_QQNumber.Name = "UI_TextBox_QQNumber";
            this.UI_TextBox_QQNumber.Size = new System.Drawing.Size(100, 25);
            this.UI_TextBox_QQNumber.TabIndex = 1;
            // 
            // UI_Button_GO
            // 
            this.UI_Button_GO.Location = new System.Drawing.Point(492, 12);
            this.UI_Button_GO.Name = "UI_Button_GO";
            this.UI_Button_GO.Size = new System.Drawing.Size(75, 23);
            this.UI_Button_GO.TabIndex = 2;
            this.UI_Button_GO.Text = "GO";
            this.UI_Button_GO.UseVisualStyleBackColor = true;
            this.UI_Button_GO.Click += new System.EventHandler(this.UI_Button_GO_Click);
            // 
            // UI_Textbox_Console
            // 
            this.UI_Textbox_Console.Location = new System.Drawing.Point(12, 188);
            this.UI_Textbox_Console.Multiline = true;
            this.UI_Textbox_Console.Name = "UI_Textbox_Console";
            this.UI_Textbox_Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UI_Textbox_Console.Size = new System.Drawing.Size(555, 553);
            this.UI_Textbox_Console.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(476, 90);
            this.label3.TabIndex = 6;
            this.label3.Text = "说明：  起始表示搜索以这个值为起始，\r\n        结束表示搜索的fid以这个值为结尾。\r\n        线程表示同时进行探测的连接数，1-20。 \r\n " +
    "       由于这个漏洞只针对动感影集，所以没有太大意义。\r\n        因此没有真正实现图片的下载。\r\n        请通过在程序的根目录生成相册同名" +
    "的网页文件来浏览图片。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "起 始：";
            // 
            // UI_TextBox_StartFId
            // 
            this.UI_TextBox_StartFId.Location = new System.Drawing.Point(86, 49);
            this.UI_TextBox_StartFId.Name = "UI_TextBox_StartFId";
            this.UI_TextBox_StartFId.Size = new System.Drawing.Size(100, 25);
            this.UI_TextBox_StartFId.TabIndex = 8;
            this.UI_TextBox_StartFId.Text = "0";
            // 
            // UI_TextBox_EndFId
            // 
            this.UI_TextBox_EndFId.Location = new System.Drawing.Point(280, 49);
            this.UI_TextBox_EndFId.Name = "UI_TextBox_EndFId";
            this.UI_TextBox_EndFId.Size = new System.Drawing.Size(100, 25);
            this.UI_TextBox_EndFId.TabIndex = 9;
            this.UI_TextBox_EndFId.Text = "100000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "结 束：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "线 程：";
            // 
            // UI_NumberUpDown_ThreadCount
            // 
            this.UI_NumberUpDown_ThreadCount.Location = new System.Drawing.Point(492, 47);
            this.UI_NumberUpDown_ThreadCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UI_NumberUpDown_ThreadCount.Name = "UI_NumberUpDown_ThreadCount";
            this.UI_NumberUpDown_ThreadCount.Size = new System.Drawing.Size(75, 25);
            this.UI_NumberUpDown_ThreadCount.TabIndex = 12;
            this.UI_NumberUpDown_ThreadCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.UI_NumberUpDown_ThreadCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UI_TextBox_EndFId);
            this.Controls.Add(this.UI_TextBox_StartFId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UI_Textbox_Console);
            this.Controls.Add(this.UI_Button_GO);
            this.Controls.Add(this.UI_TextBox_QQNumber);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "QQ空间动感影集照片下载器";
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumberUpDown_ThreadCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_TextBox_QQNumber;
        private System.Windows.Forms.Button UI_Button_GO;
        private System.Windows.Forms.TextBox UI_Textbox_Console;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UI_TextBox_StartFId;
        private System.Windows.Forms.TextBox UI_TextBox_EndFId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown UI_NumberUpDown_ThreadCount;
    }
}

