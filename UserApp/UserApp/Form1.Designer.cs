namespace UserApp
{
    partial class Form1
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnRequest = new System.Windows.Forms.Button();
            this.TxtDateTime = new System.Windows.Forms.TextBox();
            this.TxtMacName = new System.Windows.Forms.TextBox();
            this.TxtIpAddress = new System.Windows.Forms.TextBox();
            this.TxtMacId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(352, 77);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(86, 32);
            this.BtnClose.TabIndex = 23;
            this.BtnClose.Text = "&Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnRequest
            // 
            this.BtnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRequest.Location = new System.Drawing.Point(352, 25);
            this.BtnRequest.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRequest.Name = "BtnRequest";
            this.BtnRequest.Size = new System.Drawing.Size(86, 32);
            this.BtnRequest.TabIndex = 22;
            this.BtnRequest.Text = "&Send Request";
            this.BtnRequest.UseVisualStyleBackColor = false;
            this.BtnRequest.Click += new System.EventHandler(this.BtnRequest_Click);
            // 
            // TxtDateTime
            // 
            this.TxtDateTime.BackColor = System.Drawing.Color.Black;
            this.TxtDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDateTime.ForeColor = System.Drawing.Color.Yellow;
            this.TxtDateTime.Location = new System.Drawing.Point(153, 226);
            this.TxtDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDateTime.Name = "TxtDateTime";
            this.TxtDateTime.ReadOnly = true;
            this.TxtDateTime.Size = new System.Drawing.Size(168, 26);
            this.TxtDateTime.TabIndex = 21;
            // 
            // TxtMacName
            // 
            this.TxtMacName.BackColor = System.Drawing.Color.Black;
            this.TxtMacName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMacName.ForeColor = System.Drawing.Color.Yellow;
            this.TxtMacName.Location = new System.Drawing.Point(153, 180);
            this.TxtMacName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMacName.Name = "TxtMacName";
            this.TxtMacName.ReadOnly = true;
            this.TxtMacName.Size = new System.Drawing.Size(168, 26);
            this.TxtMacName.TabIndex = 20;
            // 
            // TxtIpAddress
            // 
            this.TxtIpAddress.AcceptsReturn = true;
            this.TxtIpAddress.BackColor = System.Drawing.Color.Black;
            this.TxtIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIpAddress.ForeColor = System.Drawing.Color.Yellow;
            this.TxtIpAddress.Location = new System.Drawing.Point(153, 128);
            this.TxtIpAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIpAddress.Name = "TxtIpAddress";
            this.TxtIpAddress.ReadOnly = true;
            this.TxtIpAddress.Size = new System.Drawing.Size(168, 26);
            this.TxtIpAddress.TabIndex = 19;
            // 
            // TxtMacId
            // 
            this.TxtMacId.BackColor = System.Drawing.Color.Black;
            this.TxtMacId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMacId.ForeColor = System.Drawing.Color.Yellow;
            this.TxtMacId.Location = new System.Drawing.Point(153, 71);
            this.TxtMacId.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMacId.Name = "TxtMacId";
            this.TxtMacId.ReadOnly = true;
            this.TxtMacId.Size = new System.Drawing.Size(168, 26);
            this.TxtMacId.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(16, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "DateTime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(16, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Machine name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(16, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "MacId";
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.Color.Black;
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.Color.Yellow;
            this.TxtUsername.Location = new System.Drawing.Point(153, 22);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.ReadOnly = true;
            this.TxtUsername.Size = new System.Drawing.Size(168, 26);
            this.TxtUsername.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 276);
            this.ControlBox = false;
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnRequest);
            this.Controls.Add(this.TxtDateTime);
            this.Controls.Add(this.TxtMacName);
            this.Controls.Add(this.TxtIpAddress);
            this.Controls.Add(this.TxtMacId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User request form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnRequest;
        private System.Windows.Forms.TextBox TxtDateTime;
        private System.Windows.Forms.TextBox TxtMacName;
        private System.Windows.Forms.TextBox TxtIpAddress;
        private System.Windows.Forms.TextBox TxtMacId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label1;
      
    }
}

