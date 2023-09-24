namespace UserApp
{
    partial class ControlRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlRequest));
            this.BtnRequest = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRequestId = new System.Windows.Forms.Label();
            this.BtnFindControlRequest = new System.Windows.Forms.Button();
            this.picNextButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNextButton)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRequest
            // 
            this.BtnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRequest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRequest.BackgroundImage")));
            this.BtnRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRequest.Location = new System.Drawing.Point(23, 22);
            this.BtnRequest.Name = "BtnRequest";
            this.BtnRequest.Size = new System.Drawing.Size(672, 64);
            this.BtnRequest.TabIndex = 0;
            this.BtnRequest.Text = "Request to get access";
            this.BtnRequest.UseVisualStyleBackColor = false;
            this.BtnRequest.Click += new System.EventHandler(this.BtnRequest_Click);
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.ForeColor = System.Drawing.Color.White;
            this.Log.FormattingEnabled = true;
            this.Log.ItemHeight = 18;
            this.Log.Location = new System.Drawing.Point(22, 132);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(453, 184);
            this.Log.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Background event logger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Request Id :";
            // 
            // lblRequestId
            // 
            this.lblRequestId.AutoSize = true;
            this.lblRequestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestId.Location = new System.Drawing.Point(126, 334);
            this.lblRequestId.Name = "lblRequestId";
            this.lblRequestId.Size = new System.Drawing.Size(27, 20);
            this.lblRequestId.TabIndex = 4;
            this.lblRequestId.Text = "00";
            // 
            // BtnFindControlRequest
            // 
            this.BtnFindControlRequest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFindControlRequest.BackgroundImage")));
            this.BtnFindControlRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnFindControlRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindControlRequest.Location = new System.Drawing.Point(490, 132);
            this.BtnFindControlRequest.Name = "BtnFindControlRequest";
            this.BtnFindControlRequest.Size = new System.Drawing.Size(205, 184);
            this.BtnFindControlRequest.TabIndex = 5;
            this.BtnFindControlRequest.Text = "Find Status of my request";
            this.BtnFindControlRequest.UseVisualStyleBackColor = true;
            this.BtnFindControlRequest.Click += new System.EventHandler(this.BtnFindControlRequest_Click);
            // 
            // picNextButton
            // 
            this.picNextButton.Location = new System.Drawing.Point(569, 334);
            this.picNextButton.Name = "picNextButton";
            this.picNextButton.Size = new System.Drawing.Size(126, 91);
            this.picNextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNextButton.TabIndex = 6;
            this.picNextButton.TabStop = false;
            this.picNextButton.Click += new System.EventHandler(this.picNextButton_Click);
            // 
            // ControlRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 439);
            this.Controls.Add(this.picNextButton);
            this.Controls.Add(this.BtnFindControlRequest);
            this.Controls.Add(this.lblRequestId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.BtnRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ControlRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Request";
            this.Load += new System.EventHandler(this.ControlRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNextButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRequest;
        private System.Windows.Forms.ListBox Log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRequestId;
        private System.Windows.Forms.Button BtnFindControlRequest;
        private System.Windows.Forms.PictureBox picNextButton;
    }
}