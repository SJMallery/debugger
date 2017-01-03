namespace debugger
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.rBug = new System.Windows.Forms.Button();
            this.sBug = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please choose what you would like to do.";
            // 
            // rBug
            // 
            this.rBug.Location = new System.Drawing.Point(41, 109);
            this.rBug.Name = "rBug";
            this.rBug.Size = new System.Drawing.Size(76, 37);
            this.rBug.TabIndex = 3;
            this.rBug.Text = "Report Bug";
            this.rBug.UseVisualStyleBackColor = true;
            this.rBug.Click += new System.EventHandler(this.rBug_Click);
            // 
            // sBug
            // 
            this.sBug.Location = new System.Drawing.Point(166, 109);
            this.sBug.Name = "sBug";
            this.sBug.Size = new System.Drawing.Size(75, 37);
            this.sBug.TabIndex = 4;
            this.sBug.Text = "Bugs";
            this.sBug.UseVisualStyleBackColor = true;
            this.sBug.Click += new System.EventHandler(this.sBug_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Solved Bugs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sBug);
            this.Controls.Add(this.rBug);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rBug;
        private System.Windows.Forms.Button sBug;
        private System.Windows.Forms.Button button1;
    }
}