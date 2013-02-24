namespace TBAuction
{
    partial class frmAuction
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAuct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.chkProperties = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTransport = new System.Windows.Forms.CheckBox();
            this.chkPromotion = new System.Windows.Forms.CheckBox();
            this.chkShopPromotion = new System.Windows.Forms.CheckBox();
            this.chkAnoy = new System.Windows.Forms.CheckBox();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.chkQuantity = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPriceBorder = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBeginTime = new System.Windows.Forms.TextBox();
            this.chkBeginTime = new System.Windows.Forms.CheckBox();
            this.chkInterval = new System.Windows.Forms.CheckBox();
            this.chkPriceBorder = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.chkMemo = new System.Windows.Forms.CheckBox();
            this.txtTeminateTime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkTeminateTime = new System.Windows.Forms.CheckBox();
            this.chkSkuidNull = new System.Windows.Forms.CheckBox();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(268, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(152, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(454, 15);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 25);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "网址";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(81, 62);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(339, 20);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // btnAuct
            // 
            this.btnAuct.Location = new System.Drawing.Point(454, 60);
            this.btnAuct.Name = "btnAuct";
            this.btnAuct.Size = new System.Drawing.Size(114, 25);
            this.btnAuct.TabIndex = 17;
            this.btnAuct.Text = "抢拍";
            this.btnAuct.UseVisualStyleBackColor = true;
            this.btnAuct.Click += new System.EventHandler(this.btnAuct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "商品属性";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(111, 109);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(61, 20);
            this.txtSize.TabIndex = 19;
            this.txtSize.TextChanged += new System.EventHandler(this.txtProperties_TextChanged);
            // 
            // chkProperties
            // 
            this.chkProperties.AutoSize = true;
            this.chkProperties.Location = new System.Drawing.Point(76, 135);
            this.chkProperties.Name = "chkProperties";
            this.chkProperties.Size = new System.Drawing.Size(98, 17);
            this.chkProperties.TabIndex = 20;
            this.chkProperties.Text = "显示属性列表";
            this.chkProperties.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(222, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 14);
            this.label5.TabIndex = 21;
            this.label5.Text = "订单属性设置区域";
            // 
            // chkTransport
            // 
            this.chkTransport.AutoSize = true;
            this.chkTransport.Location = new System.Drawing.Point(74, 268);
            this.chkTransport.Name = "chkTransport";
            this.chkTransport.Size = new System.Drawing.Size(98, 17);
            this.chkTransport.TabIndex = 22;
            this.chkTransport.Text = "修改运输方式";
            this.chkTransport.UseVisualStyleBackColor = true;
            // 
            // chkPromotion
            // 
            this.chkPromotion.AutoSize = true;
            this.chkPromotion.Location = new System.Drawing.Point(76, 308);
            this.chkPromotion.Name = "chkPromotion";
            this.chkPromotion.Size = new System.Drawing.Size(122, 17);
            this.chkPromotion.TabIndex = 23;
            this.chkPromotion.Text = "选择最优促销方式";
            this.chkPromotion.UseVisualStyleBackColor = true;
            // 
            // chkShopPromotion
            // 
            this.chkShopPromotion.AutoSize = true;
            this.chkShopPromotion.Location = new System.Drawing.Point(237, 308);
            this.chkShopPromotion.Name = "chkShopPromotion";
            this.chkShopPromotion.Size = new System.Drawing.Size(122, 17);
            this.chkShopPromotion.TabIndex = 24;
            this.chkShopPromotion.Text = "选择最优店铺优惠";
            this.chkShopPromotion.UseVisualStyleBackColor = true;
            // 
            // chkAnoy
            // 
            this.chkAnoy.AutoSize = true;
            this.chkAnoy.Location = new System.Drawing.Point(396, 308);
            this.chkAnoy.Name = "chkAnoy";
            this.chkAnoy.Size = new System.Drawing.Size(98, 17);
            this.chkAnoy.TabIndex = 25;
            this.chkAnoy.Text = "选择匿名购买";
            this.chkAnoy.UseVisualStyleBackColor = true;
            // 
            // txtTransport
            // 
            this.txtTransport.Location = new System.Drawing.Point(180, 265);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(312, 20);
            this.txtTransport.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(240, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 14);
            this.label6.TabIndex = 27;
            this.label6.Text = "附加功能区域";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(181, 183);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(312, 20);
            this.txtQuantity.TabIndex = 29;
            this.txtQuantity.Text = "1";
            // 
            // chkQuantity
            // 
            this.chkQuantity.AutoSize = true;
            this.chkQuantity.Location = new System.Drawing.Point(75, 185);
            this.chkQuantity.Name = "chkQuantity";
            this.chkQuantity.Size = new System.Drawing.Size(98, 17);
            this.chkQuantity.TabIndex = 28;
            this.chkQuantity.Text = "修改购买数量";
            this.chkQuantity.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "页面刷新间隔";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(167, 432);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(154, 20);
            this.txtInterval.TabIndex = 35;
            this.txtInterval.Text = "500";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "毫秒";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "设定价格界限";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "分";
            // 
            // txtPriceBorder
            // 
            this.txtPriceBorder.Location = new System.Drawing.Point(167, 480);
            this.txtPriceBorder.Name = "txtPriceBorder";
            this.txtPriceBorder.Size = new System.Drawing.Size(154, 20);
            this.txtPriceBorder.TabIndex = 38;
            this.txtPriceBorder.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(74, 390);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "抢拍开始时刻";
            // 
            // txtBeginTime
            // 
            this.txtBeginTime.Location = new System.Drawing.Point(167, 387);
            this.txtBeginTime.Name = "txtBeginTime";
            this.txtBeginTime.Size = new System.Drawing.Size(195, 20);
            this.txtBeginTime.TabIndex = 41;
            // 
            // chkBeginTime
            // 
            this.chkBeginTime.AutoSize = true;
            this.chkBeginTime.Location = new System.Drawing.Point(380, 391);
            this.chkBeginTime.Name = "chkBeginTime";
            this.chkBeginTime.Size = new System.Drawing.Size(122, 17);
            this.chkBeginTime.TabIndex = 42;
            this.chkBeginTime.Text = "使用开始时刻设置";
            this.chkBeginTime.UseVisualStyleBackColor = true;
            // 
            // chkInterval
            // 
            this.chkInterval.AutoSize = true;
            this.chkInterval.Location = new System.Drawing.Point(380, 434);
            this.chkInterval.Name = "chkInterval";
            this.chkInterval.Size = new System.Drawing.Size(122, 17);
            this.chkInterval.TabIndex = 43;
            this.chkInterval.Text = "使用刷新间隔设置";
            this.chkInterval.UseVisualStyleBackColor = true;
            // 
            // chkPriceBorder
            // 
            this.chkPriceBorder.AutoSize = true;
            this.chkPriceBorder.Location = new System.Drawing.Point(380, 482);
            this.chkPriceBorder.Name = "chkPriceBorder";
            this.chkPriceBorder.Size = new System.Drawing.Size(122, 17);
            this.chkPriceBorder.TabIndex = 44;
            this.chkPriceBorder.Text = "使用价格界限设置";
            this.chkPriceBorder.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(207, 611);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 25);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(179, 223);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(312, 20);
            this.txtMemo.TabIndex = 47;
            // 
            // chkMemo
            // 
            this.chkMemo.AutoSize = true;
            this.chkMemo.Location = new System.Drawing.Point(73, 225);
            this.chkMemo.Name = "chkMemo";
            this.chkMemo.Size = new System.Drawing.Size(74, 17);
            this.chkMemo.TabIndex = 46;
            this.chkMemo.Text = "修改留言";
            this.chkMemo.UseVisualStyleBackColor = true;
            // 
            // txtTeminateTime
            // 
            this.txtTeminateTime.Location = new System.Drawing.Point(167, 524);
            this.txtTeminateTime.Name = "txtTeminateTime";
            this.txtTeminateTime.Size = new System.Drawing.Size(195, 20);
            this.txtTeminateTime.TabIndex = 49;
            this.txtTeminateTime.TextChanged += new System.EventHandler(this.txtTeminateTime_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 528);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "设定中断时刻";
            // 
            // chkTeminateTime
            // 
            this.chkTeminateTime.AutoSize = true;
            this.chkTeminateTime.Location = new System.Drawing.Point(377, 530);
            this.chkTeminateTime.Name = "chkTeminateTime";
            this.chkTeminateTime.Size = new System.Drawing.Size(122, 17);
            this.chkTeminateTime.TabIndex = 50;
            this.chkTeminateTime.Text = "使用中断时刻设置";
            this.chkTeminateTime.UseVisualStyleBackColor = true;
            this.chkTeminateTime.CheckedChanged += new System.EventHandler(this.chkTeminateTime_CheckedChanged);
            // 
            // chkSkuidNull
            // 
            this.chkSkuidNull.AutoSize = true;
            this.chkSkuidNull.Location = new System.Drawing.Point(213, 135);
            this.chkSkuidNull.Name = "chkSkuidNull";
            this.chkSkuidNull.Size = new System.Drawing.Size(134, 17);
            this.chkSkuidNull.TabIndex = 51;
            this.chkSkuidNull.Text = "商品属性为空时终止";
            this.chkSkuidNull.UseVisualStyleBackColor = true;
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(81, 569);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(146, 17);
            this.chkLog.TabIndex = 52;
            this.chkLog.Text = "打开调试信息显示功能";
            this.chkLog.UseVisualStyleBackColor = true;
            this.chkLog.CheckedChanged += new System.EventHandler(this.chkLog_CheckedChanged);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(241, 564);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(156, 25);
            this.btnLog.TabIndex = 53;
            this.btnLog.Text = "强制显示日志窗口";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "尺码";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(210, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "颜色";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(250, 109);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(83, 20);
            this.txtColor.TabIndex = 56;
            this.txtColor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmAuction
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 646);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.chkLog);
            this.Controls.Add(this.chkSkuidNull);
            this.Controls.Add(this.chkTeminateTime);
            this.Controls.Add(this.txtTeminateTime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.chkMemo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkPriceBorder);
            this.Controls.Add(this.chkInterval);
            this.Controls.Add(this.chkBeginTime);
            this.Controls.Add(this.txtBeginTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPriceBorder);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.chkQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.chkAnoy);
            this.Controls.Add(this.chkShopPromotion);
            this.Controls.Add(this.chkPromotion);
            this.Controls.Add(this.chkTransport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkProperties);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAuct);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAuction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "淘宝抢拍测试版";
            this.Load += new System.EventHandler(this.frmAuction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAuct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.CheckBox chkProperties;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkTransport;
        private System.Windows.Forms.CheckBox chkPromotion;
        private System.Windows.Forms.CheckBox chkShopPromotion;
        private System.Windows.Forms.CheckBox chkAnoy;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.CheckBox chkQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPriceBorder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBeginTime;
        private System.Windows.Forms.CheckBox chkBeginTime;
        private System.Windows.Forms.CheckBox chkInterval;
        private System.Windows.Forms.CheckBox chkPriceBorder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.CheckBox chkMemo;
        private System.Windows.Forms.TextBox txtTeminateTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkTeminateTime;
        private System.Windows.Forms.CheckBox chkSkuidNull;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtColor;
    }
}

