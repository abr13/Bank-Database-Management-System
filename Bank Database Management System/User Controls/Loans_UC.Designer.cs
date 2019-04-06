namespace Bank_Database_Management_System.User_Controls
{
    partial class Loans_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LoanNoTextField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AmtTextField = new System.Windows.Forms.TextBox();
            this.TypeTextField = new System.Windows.Forms.TextBox();
            this.CustIdTextField = new System.Windows.Forms.TextBox();
            this.BranchNoTextfield = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchLoanTextField = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loans";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoanNoTextField
            // 
            this.LoanNoTextField.Location = new System.Drawing.Point(75, 43);
            this.LoanNoTextField.Name = "LoanNoTextField";
            this.LoanNoTextField.Size = new System.Drawing.Size(166, 20);
            this.LoanNoTextField.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Loan No. :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 168);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AmtTextField
            // 
            this.AmtTextField.Location = new System.Drawing.Point(75, 80);
            this.AmtTextField.Name = "AmtTextField";
            this.AmtTextField.Size = new System.Drawing.Size(166, 20);
            this.AmtTextField.TabIndex = 40;
            // 
            // TypeTextField
            // 
            this.TypeTextField.Location = new System.Drawing.Point(305, 43);
            this.TypeTextField.Name = "TypeTextField";
            this.TypeTextField.Size = new System.Drawing.Size(166, 20);
            this.TypeTextField.TabIndex = 41;
            // 
            // CustIdTextField
            // 
            this.CustIdTextField.Location = new System.Drawing.Point(305, 80);
            this.CustIdTextField.Name = "CustIdTextField";
            this.CustIdTextField.Size = new System.Drawing.Size(166, 20);
            this.CustIdTextField.TabIndex = 42;
            // 
            // BranchNoTextfield
            // 
            this.BranchNoTextfield.Location = new System.Drawing.Point(75, 120);
            this.BranchNoTextfield.Name = "BranchNoTextfield";
            this.BranchNoTextfield.Size = new System.Drawing.Size(166, 20);
            this.BranchNoTextfield.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Amount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Cust ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Branch No. :";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(305, 120);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(166, 23);
            this.AddButton.TabIndex = 48;
            this.AddButton.Text = "Add Record";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Loan No. :";
            // 
            // SearchLoanTextField
            // 
            this.SearchLoanTextField.Location = new System.Drawing.Point(556, 176);
            this.SearchLoanTextField.Name = "SearchLoanTextField";
            this.SearchLoanTextField.Size = new System.Drawing.Size(166, 20);
            this.SearchLoanTextField.TabIndex = 49;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(556, 216);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(166, 58);
            this.SearchButton.TabIndex = 51;
            this.SearchButton.Text = "Search Record";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(342, 146);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(99, 13);
            this.StatusLabel.TabIndex = 52;
            this.StatusLabel.Text = "Successfully added";
            this.StatusLabel.Visible = false;
            // 
            // Loans_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchLoanTextField);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BranchNoTextfield);
            this.Controls.Add(this.CustIdTextField);
            this.Controls.Add(this.TypeTextField);
            this.Controls.Add(this.AmtTextField);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoanNoTextField);
            this.Controls.Add(this.label1);
            this.Name = "Loans_UC";
            this.Size = new System.Drawing.Size(766, 351);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Loans_UC_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoanNoTextField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox AmtTextField;
        private System.Windows.Forms.TextBox TypeTextField;
        private System.Windows.Forms.TextBox CustIdTextField;
        private System.Windows.Forms.TextBox BranchNoTextfield;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SearchLoanTextField;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label StatusLabel;
    }
}
