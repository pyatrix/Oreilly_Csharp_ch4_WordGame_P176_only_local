namespace Oreilly_Csharp_ch4_WordGame_P176_only_local
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Time1 = new System.Windows.Forms.Timer(this.components);
            this.correctLabelcontrol = new System.Windows.Forms.StatusStrip();
            this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.missdLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.accuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficulityProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.correctLabelcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 120;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(860, 136);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // Time1
            // 
            this.Time1.Enabled = true;
            this.Time1.Tick += new System.EventHandler(this.Time1_Tick);
            // 
            // correctLabelcontrol
            // 
            this.correctLabelcontrol.BackColor = System.Drawing.SystemColors.Control;
            this.correctLabelcontrol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.missdLabel,
            this.totalLabel,
            this.accuracyLabel,
            this.StatusLabel,
            this.difficulityProgressBar});
            this.correctLabelcontrol.Location = new System.Drawing.Point(0, 114);
            this.correctLabelcontrol.Name = "correctLabelcontrol";
            this.correctLabelcontrol.Size = new System.Drawing.Size(860, 22);
            this.correctLabelcontrol.TabIndex = 1;
            // 
            // correctLabel
            // 
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(58, 17);
            this.correctLabel.Text = "Correct:0";
            // 
            // missdLabel
            // 
            this.missdLabel.Name = "missdLabel";
            this.missdLabel.Size = new System.Drawing.Size(57, 17);
            this.missdLabel.Text = "Missed:0";
            // 
            // totalLabel
            // 
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(46, 17);
            this.totalLabel.Text = "Total:0";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(81, 17);
            this.accuracyLabel.Text = "Accuracy: 0%";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(501, 17);
            this.StatusLabel.Spring = true;
            this.StatusLabel.Text = "Difficulty";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // difficulityProgressBar
            // 
            this.difficulityProgressBar.Name = "difficulityProgressBar";
            this.difficulityProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 136);
            this.Controls.Add(this.correctLabelcontrol);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.correctLabelcontrol.ResumeLayout(false);
            this.correctLabelcontrol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer Time1;
        private System.Windows.Forms.StatusStrip correctLabelcontrol;
        private System.Windows.Forms.ToolStripStatusLabel correctLabel;
        private System.Windows.Forms.ToolStripStatusLabel missdLabel;
        private System.Windows.Forms.ToolStripStatusLabel totalLabel;
        private System.Windows.Forms.ToolStripStatusLabel accuracyLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripProgressBar difficulityProgressBar;
    }
}

