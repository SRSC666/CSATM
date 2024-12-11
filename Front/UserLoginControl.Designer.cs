namespace CSATM.Front
{
    partial class UserLoginControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            labelBankName = new Label();
            panel1 = new Panel();
            buttonBack = new Button();
            buttonLogin = new Button();
            buttonSignup = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            labelUsername = new Label();
            textBoxNumber = new TextBox();
            labelNumber = new Label();
            textBoxBankName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelBankName
            // 
            labelBankName.Anchor = AnchorStyles.None;
            labelBankName.Location = new Point(0, 0);
            labelBankName.Margin = new Padding(0);
            labelBankName.Name = "labelBankName";
            labelBankName.Size = new Size(100, 30);
            labelBankName.TabIndex = 0;
            labelBankName.Text = "银行名：";
            labelBankName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(buttonSignup);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUsername);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(textBoxNumber);
            panel1.Controls.Add(labelNumber);
            panel1.Controls.Add(textBoxBankName);
            panel1.Controls.Add(labelBankName);
            panel1.Location = new Point(275, 175);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 250);
            panel1.TabIndex = 1;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.None;
            buttonBack.Location = new Point(170, 200);
            buttonBack.Margin = new Padding(0);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 30);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "返回";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.Location = new Point(90, 200);
            buttonLogin.Margin = new Padding(0);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 30);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "登录";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonSignup
            // 
            buttonSignup.Anchor = AnchorStyles.None;
            buttonSignup.Location = new Point(10, 200);
            buttonSignup.Margin = new Padding(0);
            buttonSignup.Name = "buttonSignup";
            buttonSignup.Size = new Size(75, 30);
            buttonSignup.TabIndex = 6;
            buttonSignup.Text = "注册";
            buttonSignup.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(100, 150);
            textBoxPassword.Margin = new Padding(0);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(150, 30);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.None;
            textBoxUsername.Location = new Point(100, 100);
            textBoxUsername.Margin = new Padding(0);
            textBoxUsername.Multiline = true;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(150, 30);
            textBoxUsername.TabIndex = 5;
            textBoxUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.None;
            labelPassword.Location = new Point(0, 150);
            labelPassword.Margin = new Padding(0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(100, 30);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "密码：";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.None;
            labelUsername.Location = new Point(0, 100);
            labelUsername.Margin = new Padding(0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(100, 30);
            labelUsername.TabIndex = 4;
            labelUsername.Text = "用户名：";
            labelUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Anchor = AnchorStyles.None;
            textBoxNumber.Location = new Point(100, 50);
            textBoxNumber.Margin = new Padding(0);
            textBoxNumber.Multiline = true;
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(150, 30);
            textBoxNumber.TabIndex = 3;
            textBoxNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // labelNumber
            // 
            labelNumber.Anchor = AnchorStyles.None;
            labelNumber.Location = new Point(0, 50);
            labelNumber.Margin = new Padding(0);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(100, 30);
            labelNumber.TabIndex = 2;
            labelNumber.Text = "卡号：";
            labelNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxBankName
            // 
            textBoxBankName.Anchor = AnchorStyles.None;
            textBoxBankName.Location = new Point(100, 0);
            textBoxBankName.Margin = new Padding(0);
            textBoxBankName.Multiline = true;
            textBoxBankName.Name = "textBoxBankName";
            textBoxBankName.Size = new Size(150, 30);
            textBoxBankName.TabIndex = 1;
            textBoxBankName.TextAlign = HorizontalAlignment.Center;
            // 
            // UserLoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "UserLoginControl";
            Size = new Size(800, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelBankName;
        private Panel panel1;
        private TextBox textBoxBankName;
        private TextBox textBoxNumber;
        private Label labelNumber;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Button buttonSignup;
        private Button buttonLogin;
        private Button buttonBack;
    }
}
