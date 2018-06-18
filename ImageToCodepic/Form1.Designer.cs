namespace ImageToCodepic
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openImageBtn = new System.Windows.Forms.Button();
            this.showCodePicTextbox = new System.Windows.Forms.TextBox();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.generateProgressBar = new System.Windows.Forms.ProgressBar();
            this.fontSizeText = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeText)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageBtn
            // 
            this.openImageBtn.Location = new System.Drawing.Point(13, 12);
            this.openImageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openImageBtn.Name = "openImageBtn";
            this.openImageBtn.Size = new System.Drawing.Size(110, 32);
            this.openImageBtn.TabIndex = 0;
            this.openImageBtn.Text = "打开文件";
            this.openImageBtn.UseVisualStyleBackColor = true;
            this.openImageBtn.Click += new System.EventHandler(this.openImageBtn_Click);
            // 
            // showCodePicTextbox
            // 
            this.showCodePicTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showCodePicTextbox.Font = new System.Drawing.Font("宋体", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showCodePicTextbox.Location = new System.Drawing.Point(13, 52);
            this.showCodePicTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showCodePicTextbox.Multiline = true;
            this.showCodePicTextbox.Name = "showCodePicTextbox";
            this.showCodePicTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showCodePicTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.showCodePicTextbox.Size = new System.Drawing.Size(903, 473);
            this.showCodePicTextbox.TabIndex = 1;
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.FileName = "openImageFileDialog";
            // 
            // generateProgressBar
            // 
            this.generateProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateProgressBar.Location = new System.Drawing.Point(130, 12);
            this.generateProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateProgressBar.Name = "generateProgressBar";
            this.generateProgressBar.Size = new System.Drawing.Size(669, 32);
            this.generateProgressBar.TabIndex = 2;
            // 
            // fontSizeText
            // 
            this.fontSizeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fontSizeText.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fontSizeText.Location = new System.Drawing.Point(806, 14);
            this.fontSizeText.Name = "fontSizeText";
            this.fontSizeText.Size = new System.Drawing.Size(110, 28);
            this.fontSizeText.TabIndex = 3;
            this.fontSizeText.ValueChanged += new System.EventHandler(this.fontSizeText_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 536);
            this.Controls.Add(this.fontSizeText);
            this.Controls.Add(this.generateProgressBar);
            this.Controls.Add(this.showCodePicTextbox);
            this.Controls.Add(this.openImageBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openImageBtn;
        private System.Windows.Forms.TextBox showCodePicTextbox;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.ProgressBar generateProgressBar;
        private System.Windows.Forms.NumericUpDown fontSizeText;
    }
}

