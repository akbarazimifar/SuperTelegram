﻿namespace enroll
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.sure = new Sunny.UI.UIButton();
            this.acc = new Sunny.UI.UITextBox();
            this.name = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.phone = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.email = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.pass1 = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.pass2 = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.ErrorText = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLabel1.Location = new System.Drawing.Point(40, 169);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(132, 36);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "账  号：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiLabel1.Click += new System.EventHandler(this.uiLabel1_Click);
            // 
            // sure
            // 
            this.sure.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sure.Location = new System.Drawing.Point(140, 557);
            this.sure.MinimumSize = new System.Drawing.Size(1, 1);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(125, 44);
            this.sure.TabIndex = 2;
            this.sure.Text = "注  册";
            this.sure.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.sure.Click += new System.EventHandler(this.sure_Click);
            // 
            // acc
            // 
            this.acc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acc.Location = new System.Drawing.Point(151, 169);
            this.acc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acc.MinimumSize = new System.Drawing.Size(1, 16);
            this.acc.Name = "acc";
            this.acc.ShowText = false;
            this.acc.Size = new System.Drawing.Size(188, 36);
            this.acc.TabIndex = 3;
            this.acc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.acc.Watermark = "";
            this.acc.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(150, 233);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.MinimumSize = new System.Drawing.Size(1, 16);
            this.name.Name = "name";
            this.name.ShowText = false;
            this.name.Size = new System.Drawing.Size(188, 36);
            this.name.TabIndex = 5;
            this.name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.name.Watermark = "";
            this.name.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(39, 233);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(132, 36);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "用户名：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phone.Location = new System.Drawing.Point(151, 297);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone.MinimumSize = new System.Drawing.Size(1, 16);
            this.phone.Name = "phone";
            this.phone.ShowText = false;
            this.phone.Size = new System.Drawing.Size(188, 36);
            this.phone.TabIndex = 5;
            this.phone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.phone.Watermark = "";
            this.phone.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel3.Location = new System.Drawing.Point(40, 297);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(132, 36);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "手机号：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(151, 359);
            this.email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email.MinimumSize = new System.Drawing.Size(1, 16);
            this.email.Name = "email";
            this.email.ShowText = false;
            this.email.Size = new System.Drawing.Size(188, 36);
            this.email.TabIndex = 7;
            this.email.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.email.Watermark = "";
            this.email.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel4.Location = new System.Drawing.Point(40, 359);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(132, 36);
            this.uiLabel4.TabIndex = 6;
            this.uiLabel4.Text = "邮  箱：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pass1
            // 
            this.pass1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass1.Location = new System.Drawing.Point(151, 422);
            this.pass1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pass1.MinimumSize = new System.Drawing.Size(1, 16);
            this.pass1.Name = "pass1";
            this.pass1.PasswordChar = '*';
            this.pass1.ShowText = false;
            this.pass1.Size = new System.Drawing.Size(188, 36);
            this.pass1.TabIndex = 9;
            this.pass1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.pass1.Watermark = "";
            this.pass1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel5.Location = new System.Drawing.Point(40, 422);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(132, 36);
            this.uiLabel5.TabIndex = 8;
            this.uiLabel5.Text = "密  码：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pass2
            // 
            this.pass2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass2.Location = new System.Drawing.Point(151, 482);
            this.pass2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pass2.MinimumSize = new System.Drawing.Size(1, 16);
            this.pass2.Name = "pass2";
            this.pass2.PasswordChar = '*';
            this.pass2.ShowText = false;
            this.pass2.Size = new System.Drawing.Size(188, 36);
            this.pass2.TabIndex = 12;
            this.pass2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.pass2.Watermark = "";
            this.pass2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel6.Location = new System.Drawing.Point(27, 482);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(132, 36);
            this.uiLabel6.TabIndex = 11;
            this.uiLabel6.Text = "重复密码：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ErrorText
            // 
            this.ErrorText.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(249, 400);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(140, 17);
            this.ErrorText.Style = Sunny.UI.UIStyle.Custom;
            this.ErrorText.TabIndex = 13;
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ErrorText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(389, 632);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.email);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton sure;
        private Sunny.UI.UITextBox acc;
        private Sunny.UI.UITextBox name;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox phone;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox email;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox pass1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox pass2;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel ErrorText;
    }
}