namespace debugger
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testDBDataSet = new debugger.testDBDataSet();
            this.bugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugsTableAdapter = new debugger.testDBDataSetTableAdapters.bugsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solvedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.solvedUpdateBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descUpdateBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.langUpdateBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeUpdateBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameUpdateBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.solvedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bugsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // testDBDataSet
            // 
            this.testDBDataSet.DataSetName = "testDBDataSet";
            this.testDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugsBindingSource
            // 
            this.bugsBindingSource.DataMember = "bugs";
            this.bugsBindingSource.DataSource = this.testDBDataSet;
            // 
            // bugsTableAdapter
            // 
            this.bugsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "language";
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // solvedDataGridViewTextBoxColumn
            // 
            this.solvedDataGridViewTextBoxColumn.DataPropertyName = "solved";
            this.solvedDataGridViewTextBoxColumn.HeaderText = "solved";
            this.solvedDataGridViewTextBoxColumn.Name = "solvedDataGridViewTextBoxColumn";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(321, 586);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(83, 55);
            this.updateButton.TabIndex = 34;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Solved Yes/No";
            // 
            // solvedUpdateBox
            // 
            this.solvedUpdateBox.Location = new System.Drawing.Point(377, 539);
            this.solvedUpdateBox.Name = "solvedUpdateBox";
            this.solvedUpdateBox.Size = new System.Drawing.Size(101, 41);
            this.solvedUpdateBox.TabIndex = 32;
            this.solvedUpdateBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Description";
            // 
            // descUpdateBox
            // 
            this.descUpdateBox.Location = new System.Drawing.Point(189, 300);
            this.descUpdateBox.Name = "descUpdateBox";
            this.descUpdateBox.Size = new System.Drawing.Size(372, 43);
            this.descUpdateBox.TabIndex = 30;
            this.descUpdateBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Language";
            // 
            // langUpdateBox
            // 
            this.langUpdateBox.Location = new System.Drawing.Point(449, 224);
            this.langUpdateBox.Name = "langUpdateBox";
            this.langUpdateBox.Size = new System.Drawing.Size(181, 35);
            this.langUpdateBox.TabIndex = 28;
            this.langUpdateBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Code";
            // 
            // codeUpdateBox
            // 
            this.codeUpdateBox.Location = new System.Drawing.Point(189, 365);
            this.codeUpdateBox.Name = "codeUpdateBox";
            this.codeUpdateBox.Size = new System.Drawing.Size(372, 150);
            this.codeUpdateBox.TabIndex = 26;
            this.codeUpdateBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // nameUpdateBox
            // 
            this.nameUpdateBox.Location = new System.Drawing.Point(100, 224);
            this.nameUpdateBox.Name = "nameUpdateBox";
            this.nameUpdateBox.Size = new System.Drawing.Size(181, 35);
            this.nameUpdateBox.TabIndex = 24;
            this.nameUpdateBox.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 673);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.solvedUpdateBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descUpdateBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.langUpdateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeUpdateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameUpdateBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private testDBDataSet testDBDataSet;
        private System.Windows.Forms.BindingSource bugsBindingSource;
        private testDBDataSetTableAdapters.bugsTableAdapter bugsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solvedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox solvedUpdateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox descUpdateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox langUpdateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox codeUpdateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox nameUpdateBox;
    }
}