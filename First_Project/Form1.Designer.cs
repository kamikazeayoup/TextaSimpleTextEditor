namespace First_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ok_btn = new System.Windows.Forms.Button();
            usernametxt = new System.Windows.Forms.TextBox();
            passwordtxt = new System.Windows.Forms.TextBox();
            userlabel = new System.Windows.Forms.Label();
            passlabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // ok_btn
            // 
            ok_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            ok_btn.Location = new System.Drawing.Point(414, 193);
            ok_btn.Name = "ok_btn";
            ok_btn.Size = new System.Drawing.Size(75, 23);
            ok_btn.TabIndex = 0;
            ok_btn.Text = "OK";
            ok_btn.UseVisualStyleBackColor = true;
            ok_btn.Click += ok_btn_Click;
            ok_btn.KeyPress += ok_btn_KeyPress;
            // 
            // usernametxt
            // 
            usernametxt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            usernametxt.Location = new System.Drawing.Point(221, 81);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new System.Drawing.Size(241, 23);
            usernametxt.TabIndex = 1;
            // 
            // passwordtxt
            // 
            passwordtxt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            passwordtxt.Location = new System.Drawing.Point(221, 134);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '*';
            passwordtxt.Size = new System.Drawing.Size(241, 23);
            passwordtxt.TabIndex = 2;
            // 
            // userlabel
            // 
            userlabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            userlabel.AutoSize = true;
            userlabel.Location = new System.Drawing.Point(85, 84);
            userlabel.Name = "userlabel";
            userlabel.Size = new System.Drawing.Size(59, 15);
            userlabel.TabIndex = 3;
            userlabel.Text = "username";
            // 
            // passlabel
            // 
            passlabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            passlabel.AutoSize = true;
            passlabel.Location = new System.Drawing.Point(85, 134);
            passlabel.Name = "passlabel";
            passlabel.Size = new System.Drawing.Size(57, 15);
            passlabel.TabIndex = 4;
            passlabel.Text = "password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(569, 270);
            Controls.Add(passlabel);
            Controls.Add(userlabel);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(ok_btn);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MinimumSize = new System.Drawing.Size(585, 309);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResizeBegin += OpacityResize;
            ResizeEnd += OpacityEndResize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label passlabel;
    }
}
