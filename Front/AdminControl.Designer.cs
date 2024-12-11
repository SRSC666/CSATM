namespace CSATM.Front
{
    partial class AdminControl
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
            buttonAdd = new Button();
            textBoxBankName = new TextBox();
            buttonDelete = new Button();
            buttonBack = new Button();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.None;
            panel.Controls.Add(buttonBack);
            panel.Controls.Add(buttonDelete);
            panel.Controls.Add(buttonAdd);
            panel.Controls.Add(textBoxBankName);
            panel.Location = new Point(200, 250);
            panel.Margin = new Padding(0);
            panel.Name = "panel";
            panel.Size = new Size(400, 100);
            panel.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.Location = new Point(145, 20);
            buttonAdd.Margin = new Padding(0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 30);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "添加银行";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxBankName
            // 
            textBoxBankName.Anchor = AnchorStyles.None;
            textBoxBankName.Location = new Point(10, 20);
            textBoxBankName.Margin = new Padding(0);
            textBoxBankName.Multiline = true;
            textBoxBankName.Name = "textBoxBankName";
            textBoxBankName.Size = new Size(120, 30);
            textBoxBankName.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.Location = new Point(260, 20);
            buttonDelete.Margin = new Padding(0);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 30);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "删除银行";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.None;
            buttonBack.Location = new Point(145, 60);
            buttonBack.Margin = new Padding(0);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 30);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "返回";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // AdminControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel);
            Margin = new Padding(0);
            Name = "AdminControl";
            Size = new Size(800, 600);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private TextBox textBoxBankName;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonBack;
    }
}
