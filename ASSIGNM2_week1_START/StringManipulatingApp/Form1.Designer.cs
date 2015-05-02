namespace StringManipulatingApp
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
            this.btnToCapitals = new System.Windows.Forms.Button();
            this.btnDashToUnderscore = new System.Windows.Forms.Button();
            this.richTextBoxIn = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOut = new System.Windows.Forms.RichTextBox();
            this.btnRemoveVowels = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToCapitals
            // 
            this.btnToCapitals.Location = new System.Drawing.Point(246, 27);
            this.btnToCapitals.Name = "btnToCapitals";
            this.btnToCapitals.Size = new System.Drawing.Size(180, 23);
            this.btnToCapitals.TabIndex = 2;
            this.btnToCapitals.Text = "Change to capitals";
            this.btnToCapitals.UseVisualStyleBackColor = true;
            this.btnToCapitals.Click += new System.EventHandler(this.btnToCapitals_Click);
            // 
            // btnDashToUnderscore
            // 
            this.btnDashToUnderscore.Location = new System.Drawing.Point(246, 56);
            this.btnDashToUnderscore.Name = "btnDashToUnderscore";
            this.btnDashToUnderscore.Size = new System.Drawing.Size(180, 23);
            this.btnDashToUnderscore.TabIndex = 3;
            this.btnDashToUnderscore.Text = "Change Spaces to underscores";
            this.btnDashToUnderscore.UseVisualStyleBackColor = true;
            this.btnDashToUnderscore.Click += new System.EventHandler(this.btnDashToUnderscore_Click);
            // 
            // richTextBoxIn
            // 
            this.richTextBoxIn.Location = new System.Drawing.Point(46, 29);
            this.richTextBoxIn.Name = "richTextBoxIn";
            this.richTextBoxIn.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxIn.TabIndex = 4;
            this.richTextBoxIn.Text = "";
            // 
            // richTextBoxOut
            // 
            this.richTextBoxOut.Location = new System.Drawing.Point(553, 27);
            this.richTextBoxOut.Name = "richTextBoxOut";
            this.richTextBoxOut.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxOut.TabIndex = 5;
            this.richTextBoxOut.Text = "";
            // 
            // btnRemoveVowels
            // 
            this.btnRemoveVowels.Location = new System.Drawing.Point(246, 85);
            this.btnRemoveVowels.Name = "btnRemoveVowels";
            this.btnRemoveVowels.Size = new System.Drawing.Size(180, 23);
            this.btnRemoveVowels.TabIndex = 6;
            this.btnRemoveVowels.Text = "Remove Vowels";
            this.btnRemoveVowels.UseVisualStyleBackColor = true;
            this.btnRemoveVowels.Click += new System.EventHandler(this.btnRemoveVowels_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "All First Letters ToUpper";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoveVowels);
            this.Controls.Add(this.richTextBoxOut);
            this.Controls.Add(this.richTextBoxIn);
            this.Controls.Add(this.btnDashToUnderscore);
            this.Controls.Add(this.btnToCapitals);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToCapitals;
        private System.Windows.Forms.Button btnDashToUnderscore;
        private System.Windows.Forms.RichTextBox richTextBoxIn;
        private System.Windows.Forms.RichTextBox richTextBoxOut;
        private System.Windows.Forms.Button btnRemoveVowels;
        private System.Windows.Forms.Button button1;
    }
}

