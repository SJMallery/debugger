namespace debugger
{
    partial class Form2
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
            this.usernameText = new System.Windows.Forms.RichTextBox();
            this.passwordText = new System.Windows.Forms.RichTextBox();
            this.logUserLabel = new System.Windows.Forms.Label();
            this.logPassLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.loginMessage = new System.Windows.Forms.Label();
            this.logError = new System.Windows.Forms.Label();
            this.repBug = new System.Windows.Forms.Button();
            this.solveBug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(106, 76);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(219, 33);
            this.usernameText.TabIndex = 0;
            this.usernameText.Text = "";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(106, 131);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(219, 33);
            this.passwordText.TabIndex = 1;
            this.passwordText.Text = "";
            // 
            // logUserLabel
            // 
            this.logUserLabel.AutoSize = true;
            this.logUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logUserLabel.Location = new System.Drawing.Point(29, 84);
            this.logUserLabel.Name = "logUserLabel";
            this.logUserLabel.Size = new System.Drawing.Size(71, 16);
            this.logUserLabel.TabIndex = 2;
            this.logUserLabel.Text = "Username";
            // 
            // logPassLabel
            // 
            this.logPassLabel.AutoSize = true;
            this.logPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logPassLabel.Location = new System.Drawing.Point(32, 139);
            this.logPassLabel.Name = "logPassLabel";
            this.logPassLabel.Size = new System.Drawing.Size(68, 16);
            this.logPassLabel.TabIndex = 3;
            this.logPassLabel.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginMessage
            // 
            this.loginMessage.AutoSize = true;
            this.loginMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginMessage.Location = new System.Drawing.Point(102, 42);
            this.loginMessage.Name = "loginMessage";
            this.loginMessage.Size = new System.Drawing.Size(18, 20);
            this.loginMessage.TabIndex = 7;
            this.loginMessage.Text = "1";
            this.loginMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logError
            // 
            this.logError.AutoSize = true;
            this.logError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logError.Location = new System.Drawing.Point(102, 42);
            this.logError.Name = "logError";
            this.logError.Size = new System.Drawing.Size(18, 20);
            this.logError.TabIndex = 9;
            this.logError.Text = "2";
            this.logError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logError.Click += new System.EventHandler(this.logError_Click);
            // 
            // repBug
            // 
            this.repBug.Location = new System.Drawing.Point(90, 153);
            this.repBug.Name = "repBug";
            this.repBug.Size = new System.Drawing.Size(75, 23);
            this.repBug.TabIndex = 10;
            this.repBug.Text = "Report Bug";
            this.repBug.UseVisualStyleBackColor = true;
            this.repBug.Click += new System.EventHandler(this.repBug_Click);
            // 
            // solveBug
            // 
            this.solveBug.Location = new System.Drawing.Point(237, 153);
            this.solveBug.Name = "solveBug";
            this.solveBug.Size = new System.Drawing.Size(75, 23);
            this.solveBug.TabIndex = 11;
            this.solveBug.Text = "Solve Bug";
            this.solveBug.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.solveBug);
            this.Controls.Add(this.repBug);
            this.Controls.Add(this.logError);
            this.Controls.Add(this.loginMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logPassLabel);
            this.Controls.Add(this.logUserLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox usernameText;
        private System.Windows.Forms.RichTextBox passwordText;
        private System.Windows.Forms.Label logUserLabel;
        private System.Windows.Forms.Label logPassLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label loginMessage;
        private System.Windows.Forms.Label logError;
        private System.Windows.Forms.Button repBug;
        private System.Windows.Forms.Button solveBug;
    }
}