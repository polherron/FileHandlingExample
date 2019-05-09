namespace FileHandlingExample
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRread = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.rtbWrite = new System.Windows.Forms.RichTextBox();
            this.rtbRead = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(64, 303);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(143, 31);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRread
            // 
            this.btnRread.Location = new System.Drawing.Point(275, 302);
            this.btnRread.Name = "btnRread";
            this.btnRread.Size = new System.Drawing.Size(103, 32);
            this.btnRread.TabIndex = 1;
            this.btnRread.Text = "Read";
            this.btnRread.UseVisualStyleBackColor = true;
            this.btnRread.Click += new System.EventHandler(this.btnRread_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(64, 351);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(143, 32);
            this.btnAppend.TabIndex = 2;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // rtbWrite
            // 
            this.rtbWrite.Location = new System.Drawing.Point(64, 105);
            this.rtbWrite.Name = "rtbWrite";
            this.rtbWrite.Size = new System.Drawing.Size(143, 168);
            this.rtbWrite.TabIndex = 3;
            this.rtbWrite.Text = "";
            // 
            // rtbRead
            // 
            this.rtbRead.Location = new System.Drawing.Point(275, 105);
            this.rtbRead.Name = "rtbRead";
            this.rtbRead.Size = new System.Drawing.Size(143, 168);
            this.rtbRead.TabIndex = 4;
            this.rtbRead.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 517);
            this.Controls.Add(this.rtbRead);
            this.Controls.Add(this.rtbWrite);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnRread);
            this.Controls.Add(this.btnWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRread;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.RichTextBox rtbWrite;
        private System.Windows.Forms.RichTextBox rtbRead;
    }
}

