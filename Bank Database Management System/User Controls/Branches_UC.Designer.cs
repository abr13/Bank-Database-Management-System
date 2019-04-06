namespace Bank_Database_Management_System.User_Controls
{
    partial class Branches_UC
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
            this.StatusLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BranchIDTextField = new System.Windows.Forms.TextBox();
            this.AddressTextField = new System.Windows.Forms.TextBox();
            this.NameTextField = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBranchIDTextField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BidTextField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(115, 305);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(99, 13);
            this.StatusLabel.TabIndex = 18;
            this.StatusLabel.Text = "Successfully added";
            this.StatusLabel.Visible = false;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(74, 263);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Add Record";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Branch ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name :";
            // 
            // BranchIDTextField
            // 
            this.BranchIDTextField.Location = new System.Drawing.Point(74, 97);
            this.BranchIDTextField.Name = "BranchIDTextField";
            this.BranchIDTextField.Size = new System.Drawing.Size(190, 20);
            this.BranchIDTextField.TabIndex = 13;
            // 
            // AddressTextField
            // 
            this.AddressTextField.Location = new System.Drawing.Point(74, 143);
            this.AddressTextField.Name = "AddressTextField";
            this.AddressTextField.Size = new System.Drawing.Size(190, 20);
            this.AddressTextField.TabIndex = 12;
            // 
            // NameTextField
            // 
            this.NameTextField.Location = new System.Drawing.Point(74, 189);
            this.NameTextField.Name = "NameTextField";
            this.NameTextField.Size = new System.Drawing.Size(190, 20);
            this.NameTextField.TabIndex = 11;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(189, 263);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Delete Record";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(557, 44);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(190, 23);
            this.SearchButton.TabIndex = 22;
            this.SearchButton.Text = "Search Record";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBranchIDTextField
            // 
            this.SearchBranchIDTextField.Location = new System.Drawing.Point(349, 45);
            this.SearchBranchIDTextField.Name = "SearchBranchIDTextField";
            this.SearchBranchIDTextField.Size = new System.Drawing.Size(190, 20);
            this.SearchBranchIDTextField.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Branch ID :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 156);
            this.dataGridView1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Branches";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Bank ID :";
            // 
            // BidTextField
            // 
            this.BidTextField.Location = new System.Drawing.Point(74, 233);
            this.BidTextField.Name = "BidTextField";
            this.BidTextField.Size = new System.Drawing.Size(190, 20);
            this.BidTextField.TabIndex = 26;
            // 
            // Branches_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BidTextField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBranchIDTextField);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BranchIDTextField);
            this.Controls.Add(this.AddressTextField);
            this.Controls.Add(this.NameTextField);
            this.Name = "Branches_UC";
            this.Size = new System.Drawing.Size(766, 351);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Branches_UC_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BranchIDTextField;
        private System.Windows.Forms.TextBox AddressTextField;
        private System.Windows.Forms.TextBox NameTextField;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBranchIDTextField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BidTextField;
    }
}
