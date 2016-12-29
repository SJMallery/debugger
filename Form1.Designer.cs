namespace debugger
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
            this.nameInsertBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codeInsertBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.langInsertBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descInsertBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameInsertBox
            // 
            this.nameInsertBox.Location = new System.Drawing.Point(93, 43);
            this.nameInsertBox.Name = "nameInsertBox";
            this.nameInsertBox.Size = new System.Drawing.Size(181, 35);
            this.nameInsertBox.TabIndex = 0;
            this.nameInsertBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // codeInsertBox
            // 
            this.codeInsertBox.Location = new System.Drawing.Point(172, 190);
            this.codeInsertBox.Name = "codeInsertBox";
            this.codeInsertBox.Size = new System.Drawing.Size(372, 150);
            this.codeInsertBox.TabIndex = 2;
            this.codeInsertBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code";
            // 
            // langInsertBox
            // 
            this.langInsertBox.Location = new System.Drawing.Point(442, 43);
            this.langInsertBox.Name = "langInsertBox";
            this.langInsertBox.Size = new System.Drawing.Size(181, 35);
            this.langInsertBox.TabIndex = 4;
            this.langInsertBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Language";
            // 
            // descInsertBox
            // 
            this.descInsertBox.Location = new System.Drawing.Point(172, 125);
            this.descInsertBox.Name = "descInsertBox";
            this.descInsertBox.Size = new System.Drawing.Size(372, 43);
            this.descInsertBox.TabIndex = 6;
            this.descInsertBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(303, 364);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(102, 41);
            this.uploadButton.TabIndex = 10;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 425);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descInsertBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.langInsertBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeInsertBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameInsertBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox nameInsertBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox codeInsertBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox langInsertBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox descInsertBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uploadButton;
    }
}

