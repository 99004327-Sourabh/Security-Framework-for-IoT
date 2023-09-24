namespace UserApp
{
    partial class CheckStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckStatus));
            this.label1 = new System.Windows.Forms.Label();
            this.CheckStatusBtn = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSha = new System.Windows.Forms.Label();
            this.lblPrvKey = new System.Windows.Forms.Label();
            this.picDownloadBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CheckStatusBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownloadBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click following image to check status";
            // 
            // CheckStatusBtn
            // 
            this.CheckStatusBtn.Image = ((System.Drawing.Image)(resources.GetObject("CheckStatusBtn.Image")));
            this.CheckStatusBtn.Location = new System.Drawing.Point(16, 54);
            this.CheckStatusBtn.Name = "CheckStatusBtn";
            this.CheckStatusBtn.Size = new System.Drawing.Size(135, 134);
            this.CheckStatusBtn.TabIndex = 1;
            this.CheckStatusBtn.TabStop = false;
            this.CheckStatusBtn.Click += new System.EventHandler(this.CheckStatusBtn_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 83);
            this.label4.TabIndex = 6;
            this.label4.Text = "Note : In really world application , no certificates shown to view/user. If appro" +
                "ved following is just for demo.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identity certificate";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Exchange certificate";
            this.label3.Visible = false;
            // 
            // lblSha
            // 
            this.lblSha.Location = new System.Drawing.Point(45, 518);
            this.lblSha.Name = "lblSha";
            this.lblSha.Size = new System.Drawing.Size(420, 126);
            this.lblSha.TabIndex = 4;
            this.lblSha.Visible = false;
            // 
            // lblPrvKey
            // 
            this.lblPrvKey.Location = new System.Drawing.Point(49, 406);
            this.lblPrvKey.Name = "lblPrvKey";
            this.lblPrvKey.Size = new System.Drawing.Size(416, 126);
            this.lblPrvKey.TabIndex = 5;
            this.lblPrvKey.Visible = false;
            // 
            // picDownloadBtn
            // 
            this.picDownloadBtn.Image = ((System.Drawing.Image)(resources.GetObject("picDownloadBtn.Image")));
            this.picDownloadBtn.Location = new System.Drawing.Point(389, 610);
            this.picDownloadBtn.Name = "picDownloadBtn";
            this.picDownloadBtn.Size = new System.Drawing.Size(85, 108);
            this.picDownloadBtn.TabIndex = 7;
            this.picDownloadBtn.TabStop = false;
            this.picDownloadBtn.Visible = false;
            this.picDownloadBtn.Click += new System.EventHandler(this.picDownloadBtn_Click);
            // 
            // CheckStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 208);
            this.Controls.Add(this.picDownloadBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrvKey);
            this.Controls.Add(this.lblSha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckStatusBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CheckStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckStatus form";
            this.Load += new System.EventHandler(this.CheckStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckStatusBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownloadBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CheckStatusBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSha;
        private System.Windows.Forms.Label lblPrvKey;
        private System.Windows.Forms.PictureBox picDownloadBtn;
    }
}