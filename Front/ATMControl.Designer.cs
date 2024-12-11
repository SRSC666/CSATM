namespace CSATM.Front
{
    partial class ATMControl
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
            panel = new Panel();
            buttonSave = new Button();
            textBoxAmount = new TextBox();
            buttonWithdraw = new Button();
            buttonExit = new Button();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.None;
            panel.Controls.Add(buttonExit);
            panel.Controls.Add(buttonWithdraw);
            panel.Controls.Add(buttonSave);
            panel.Controls.Add(textBoxAmount);
            panel.Location = new Point(300, 225);
            panel.Margin = new Padding(0);
            panel.Name = "panel";
            panel.Size = new Size(200, 150);
            panel.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(10, 40);
            buttonSave.Margin = new Padding(0);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 25);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "存钱";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Anchor = AnchorStyles.None;
            textBoxAmount.Location = new Point(0, 0);
            textBoxAmount.Multiline = true;
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(200, 30);
            textBoxAmount.TabIndex = 0;
            // 
            // buttonWithdraw
            // 
            buttonWithdraw.Location = new Point(115, 40);
            buttonWithdraw.Margin = new Padding(0);
            buttonWithdraw.Name = "buttonWithdraw";
            buttonWithdraw.Size = new Size(75, 25);
            buttonWithdraw.TabIndex = 1;
            buttonWithdraw.Text = "取钱";
            buttonWithdraw.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(65, 75);
            buttonExit.Margin = new Padding(0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 25);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "退出";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // ATMControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel);
            Margin = new Padding(0);
            Name = "ATMControl";
            Size = new Size(800, 600);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private TextBox textBoxAmount;
        private Button buttonSave;
        private Button buttonWithdraw;
        private Button buttonExit;
    }
}
