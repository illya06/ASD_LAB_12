namespace ASD_LAB_12
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
            this.word = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.RichTextBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(136, 63);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(100, 20);
            this.word.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TEXT : ";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(55, 61);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 2;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // text
            // 
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Location = new System.Drawing.Point(283, 66);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(100, 96);
            this.text.TabIndex = 3;
            this.text.Text = "";
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Location = new System.Drawing.Point(55, 90);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(181, 72);
            this.result.TabIndex = 4;
            this.result.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(472, 226);
            this.Controls.Add(this.result);
            this.Controls.Add(this.text);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.word);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.RichTextBox result;
    }
}

