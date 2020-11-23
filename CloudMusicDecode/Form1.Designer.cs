namespace CloudMusicDecode
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chooseInputPath = new System.Windows.Forms.Button();
            this.inputPath = new System.Windows.Forms.TextBox();
            this.inputPathLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chooseOutPath = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.outPath = new System.Windows.Forms.TextBox();
            this.outPathLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chooseInputPath);
            this.groupBox1.Controls.Add(this.inputPath);
            this.groupBox1.Controls.Add(this.inputPathLabel);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入";
            // 
            // chooseInputPath
            // 
            this.chooseInputPath.Location = new System.Drawing.Point(709, 41);
            this.chooseInputPath.Name = "chooseInputPath";
            this.chooseInputPath.Size = new System.Drawing.Size(30, 27);
            this.chooseInputPath.TabIndex = 2;
            this.chooseInputPath.Text = "...";
            this.chooseInputPath.UseVisualStyleBackColor = true;
            this.chooseInputPath.Click += new System.EventHandler(this.chooseInputPath_Click);
            // 
            // inputPath
            // 
            this.inputPath.Location = new System.Drawing.Point(82, 41);
            this.inputPath.Name = "inputPath";
            this.inputPath.Size = new System.Drawing.Size(620, 27);
            this.inputPath.TabIndex = 1;
            // 
            // inputPathLabel
            // 
            this.inputPathLabel.AutoSize = true;
            this.inputPathLabel.Location = new System.Drawing.Point(6, 47);
            this.inputPathLabel.Name = "inputPathLabel";
            this.inputPathLabel.Size = new System.Drawing.Size(69, 20);
            this.inputPathLabel.TabIndex = 0;
            this.inputPathLabel.Text = "文件路径";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chooseOutPath);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.outPath);
            this.groupBox2.Controls.Add(this.outPathLabel);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出";
            // 
            // chooseOutPath
            // 
            this.chooseOutPath.Location = new System.Drawing.Point(709, 44);
            this.chooseOutPath.Name = "chooseOutPath";
            this.chooseOutPath.Size = new System.Drawing.Size(30, 27);
            this.chooseOutPath.TabIndex = 3;
            this.chooseOutPath.Text = "...";
            this.chooseOutPath.UseVisualStyleBackColor = true;
            this.chooseOutPath.Click += new System.EventHandler(this.chooseOutPath_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(82, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(274, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "在缓存文件目录下创建同名mp4文件";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // outPath
            // 
            this.outPath.Location = new System.Drawing.Point(82, 44);
            this.outPath.Name = "outPath";
            this.outPath.Size = new System.Drawing.Size(620, 27);
            this.outPath.TabIndex = 2;
            // 
            // outPathLabel
            // 
            this.outPathLabel.AutoSize = true;
            this.outPathLabel.Location = new System.Drawing.Point(6, 47);
            this.outPathLabel.Name = "outPathLabel";
            this.outPathLabel.Size = new System.Drawing.Size(69, 20);
            this.outPathLabel.TabIndex = 1;
            this.outPathLabel.Text = "输出路径";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startButton.Location = new System.Drawing.Point(12, 249);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(90, 30);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "开始转换";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.closeButton.Location = new System.Drawing.Point(680, 249);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(90, 30);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "退出";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(109, 249);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(565, 29);
            this.progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 303);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "网易云缓存转换";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button chooseInputPath;
        private System.Windows.Forms.TextBox inputPath;
        private System.Windows.Forms.Label inputPathLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button chooseOutPath;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox outPath;
        private System.Windows.Forms.Label outPathLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

