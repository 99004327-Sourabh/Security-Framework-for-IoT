namespace UserApp
{
    partial class ControlIOT
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
            this.OSXStyleToggleSwitch = new JCS.ToggleSwitch();
            this.RequestBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OSXStyleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OSXStyleToggleSwitch
            // 
            this.OSXStyleToggleSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OSXStyleToggleSwitch.Location = new System.Drawing.Point(17, 168);
            this.OSXStyleToggleSwitch.Name = "OSXStyleToggleSwitch";
            this.OSXStyleToggleSwitch.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSXStyleToggleSwitch.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSXStyleToggleSwitch.Size = new System.Drawing.Size(75, 19);
            this.OSXStyleToggleSwitch.TabIndex = 16;
            // 
            // RequestBtn
            // 
            this.RequestBtn.BackColor = System.Drawing.Color.Black;
            this.RequestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestBtn.ForeColor = System.Drawing.Color.Yellow;
            this.RequestBtn.Location = new System.Drawing.Point(12, 223);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(286, 53);
            this.RequestBtn.TabIndex = 0;
            this.RequestBtn.Text = "Send Command";
            this.RequestBtn.UseVisualStyleBackColor = false;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO IOT ENVIRONMENT CONTROL PANEL";
            // 
            // OSXStyleLabel
            // 
            this.OSXStyleLabel.AutoSize = true;
            this.OSXStyleLabel.Location = new System.Drawing.Point(71, 152);
            this.OSXStyleLabel.Name = "OSXStyleLabel";
            this.OSXStyleLabel.Size = new System.Drawing.Size(21, 13);
            this.OSXStyleLabel.TabIndex = 8;
            this.OSXStyleLabel.Text = "On";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Off";
            // 
            // ControlIOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 294);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RequestBtn);
            this.Controls.Add(this.OSXStyleToggleSwitch);
            this.Controls.Add(this.OSXStyleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ControlIOT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IOT Control Screen";
            this.Load += new System.EventHandler(this.ControlIOT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RequestBtn;
        private System.Windows.Forms.Label label1;
        private JCS.ToggleSwitch OSXStyleToggleSwitch;
        private System.Windows.Forms.Label OSXStyleLabel;
        private System.Windows.Forms.Label label2;
        
    }
}