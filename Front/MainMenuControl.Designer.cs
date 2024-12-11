namespace CSATM.Front
{
    partial class MainMenuControl
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
            tableLayoutPanel = new TableLayoutPanel();
            buttonAdmin = new Button();
            buttonUser = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(buttonUser, 0, 1);
            tableLayoutPanel.Controls.Add(buttonAdmin, 0, 0);
            tableLayoutPanel.Location = new Point(300, 250);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(200, 100);
            tableLayoutPanel.TabIndex = 0;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Anchor = AnchorStyles.None;
            buttonAdmin.Location = new Point(50, 10);
            buttonAdmin.Margin = new Padding(0);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(100, 30);
            buttonAdmin.TabIndex = 0;
            buttonAdmin.Text = "管理员";
            buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonUser
            // 
            buttonUser.Anchor = AnchorStyles.None;
            buttonUser.Location = new Point(50, 60);
            buttonUser.Margin = new Padding(0);
            buttonUser.Name = "buttonUser";
            buttonUser.Size = new Size(100, 30);
            buttonUser.TabIndex = 1;
            buttonUser.Text = "用户";
            buttonUser.UseVisualStyleBackColor = true;
            // 
            // MainMenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Name = "MainMenuControl";
            Size = new Size(800, 600);
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Button buttonAdmin;
        private Button buttonUser;
    }
}
