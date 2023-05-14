namespace TextEditorApp
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
            openbtn = new System.Windows.Forms.Button();
            savebtn = new System.Windows.Forms.Button();
            exitbtn = new System.Windows.Forms.Button();
            fontbtn = new System.Windows.Forms.Button();
            colorbtn = new System.Windows.Forms.Button();
            richtxt = new System.Windows.Forms.RichTextBox();
            dlgopen = new System.Windows.Forms.OpenFileDialog();
            dlgsave = new System.Windows.Forms.SaveFileDialog();
            dlgfont = new System.Windows.Forms.FontDialog();
            dlgcolor = new System.Windows.Forms.ColorDialog();
            clearbtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // openbtn
            // 
            openbtn.Location = new System.Drawing.Point(100, 31);
            openbtn.Name = "openbtn";
            openbtn.Size = new System.Drawing.Size(94, 29);
            openbtn.TabIndex = 0;
            openbtn.Text = "Open";
            openbtn.UseVisualStyleBackColor = true;
            openbtn.Click += openbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            savebtn.Location = new System.Drawing.Point(381, 31);
            savebtn.Name = "savebtn";
            savebtn.Size = new System.Drawing.Size(94, 29);
            savebtn.TabIndex = 1;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // exitbtn
            // 
            exitbtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            exitbtn.Location = new System.Drawing.Point(638, 31);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new System.Drawing.Size(94, 29);
            exitbtn.TabIndex = 2;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            // 
            // fontbtn
            // 
            fontbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            fontbtn.Location = new System.Drawing.Point(100, 401);
            fontbtn.Name = "fontbtn";
            fontbtn.Size = new System.Drawing.Size(94, 29);
            fontbtn.TabIndex = 3;
            fontbtn.Text = "Font";
            fontbtn.UseVisualStyleBackColor = true;
            fontbtn.Click += fontbtn_Click;
            // 
            // colorbtn
            // 
            colorbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            colorbtn.Location = new System.Drawing.Point(381, 401);
            colorbtn.Name = "colorbtn";
            colorbtn.Size = new System.Drawing.Size(94, 29);
            colorbtn.TabIndex = 4;
            colorbtn.Text = "Color";
            colorbtn.UseVisualStyleBackColor = true;
            colorbtn.Click += colorbtn_Click;
            // 
            // richtxt
            // 
            richtxt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richtxt.Location = new System.Drawing.Point(58, 66);
            richtxt.Name = "richtxt";
            richtxt.Size = new System.Drawing.Size(713, 329);
            richtxt.TabIndex = 6;
            richtxt.Text = "";
            // 
            // dlgopen
            // 
            dlgopen.InitialDirectory = "D:";
            // 
            // clearbtn
            // 
            clearbtn.Location = new System.Drawing.Point(638, 401);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new System.Drawing.Size(94, 29);
            clearbtn.TabIndex = 7;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += clearbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(821, 472);
            Controls.Add(clearbtn);
            Controls.Add(richtxt);
            Controls.Add(colorbtn);
            Controls.Add(fontbtn);
            Controls.Add(exitbtn);
            Controls.Add(savebtn);
            Controls.Add(openbtn);
            MinimumSize = new System.Drawing.Size(839, 519);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button openbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button fontbtn;
        private System.Windows.Forms.Button colorbtn;
        private System.Windows.Forms.RichTextBox richtxt;
        private System.Windows.Forms.OpenFileDialog dlgopen;
        private System.Windows.Forms.SaveFileDialog dlgsave;
        private System.Windows.Forms.FontDialog dlgfont;
        private System.Windows.Forms.ColorDialog dlgcolor;
        private System.Windows.Forms.Button clearbtn;
    }
}
