namespace Bank_Database_Management_System.User_Controls
{
    partial class Customers_UC
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchCustIDTextField = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustIDTextField = new System.Windows.Forms.TextBox();
            this.CustNameTextField = new System.Windows.Forms.TextBox();
            this.PhoneTextField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressTextField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 189);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cust ID :";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(563, 60);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(190, 23);
            this.SearchButton.TabIndex = 35;
            this.SearchButton.Text = "Search Record";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchCustIDTextField
            // 
            this.SearchCustIDTextField.Location = new System.Drawing.Point(355, 61);
            this.SearchCustIDTextField.Name = "SearchCustIDTextField";
            this.SearchCustIDTextField.Size = new System.Drawing.Size(190, 20);
            this.SearchCustIDTextField.TabIndex = 34;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(195, 263);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 33;
            this.DeleteButton.Text = "Delete Record";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(121, 299);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(99, 13);
            this.StatusLabel.TabIndex = 32;
            this.StatusLabel.Text = "Successfully added";
            this.StatusLabel.Visible = false;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(80, 263);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 31;
            this.AddButton.Text = "Add Record";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Customer ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Cust Name  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Phone :";
            // 
            // CustIDTextField
            // 
            this.CustIDTextField.Location = new System.Drawing.Point(80, 97);
            this.CustIDTextField.Name = "CustIDTextField";
            this.CustIDTextField.Size = new System.Drawing.Size(190, 20);
            this.CustIDTextField.TabIndex = 27;
            // 
            // CustNameTextField
            // 
            this.CustNameTextField.Location = new System.Drawing.Point(80, 134);
            this.CustNameTextField.Name = "CustNameTextField";
            this.CustNameTextField.Size = new System.Drawing.Size(190, 20);
            this.CustNameTextField.TabIndex = 26;
            // 
            // PhoneTextField
            // 
            this.PhoneTextField.Location = new System.Drawing.Point(80, 171);
            this.PhoneTextField.Name = "PhoneTextField";
            this.PhoneTextField.Size = new System.Drawing.Size(190, 20);
            this.PhoneTextField.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Address :";
            // 
            // AddressTextField
            // 
            this.AddressTextField.Location = new System.Drawing.Point(80, 208);
            this.AddressTextField.Name = "AddressTextField";
            this.AddressTextField.Size = new System.Drawing.Size(190, 20);
            this.AddressTextField.TabIndex = 38;
            // 
            // Customers_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddressTextField);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchCustIDTextField);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustIDTextField);
            this.Controls.Add(this.CustNameTextField);
            this.Controls.Add(this.PhoneTextField);
            this.Controls.Add(this.label2);
            this.Name = "Customers_UC";
            this.Size = new System.Drawing.Size(766, 351);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Customers_UC_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchCustIDTextField;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustIDTextField;
        private System.Windows.Forms.TextBox CustNameTextField;
        private System.Windows.Forms.TextBox PhoneTextField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddressTextField;
    }
}
