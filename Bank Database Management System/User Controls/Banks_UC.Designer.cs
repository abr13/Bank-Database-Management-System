namespace Bank_Database_Management_System.User_Controls
{
    partial class Banks_UC
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
            this.IDTextField = new System.Windows.Forms.TextBox();
            this.NameTextField = new System.Windows.Forms.TextBox();
            this.AddressTextField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchIDTextField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDTextField
            // 
            this.IDTextField.Location = new System.Drawing.Point(71, 110);
            this.IDTextField.Name = "IDTextField";
            this.IDTextField.Size = new System.Drawing.Size(190, 20);
            this.IDTextField.TabIndex = 0;
            // 
            // NameTextField
            // 
            this.NameTextField.Location = new System.Drawing.Point(71, 156);
            this.NameTextField.Name = "NameTextField";
            this.NameTextField.Size = new System.Drawing.Size(190, 20);
            this.NameTextField.TabIndex = 1;
            // 
            // AddressTextField
            // 
            this.AddressTextField.Location = new System.Drawing.Point(71, 202);
            this.AddressTextField.Name = "AddressTextField";
            this.AddressTextField.Size = new System.Drawing.Size(190, 20);
            this.AddressTextField.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address :";
            // 
            // SearchIDTextField
            // 
            this.SearchIDTextField.Location = new System.Drawing.Point(347, 49);
            this.SearchIDTextField.Name = "SearchIDTextField";
            this.SearchIDTextField.Size = new System.Drawing.Size(190, 20);
            this.SearchIDTextField.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID :";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(71, 243);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(190, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add Record";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(555, 48);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(190, 23);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search Record";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(117, 269);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(99, 13);
            this.StatusLabel.TabIndex = 10;
            this.StatusLabel.Text = "Successfully added";
            this.StatusLabel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 156);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Banks";
            // 
            // Banks_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchIDTextField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTextField);
            this.Controls.Add(this.NameTextField);
            this.Controls.Add(this.IDTextField);
            this.Name = "Banks_UC";
            this.Size = new System.Drawing.Size(766, 351);
            this.Load += new System.EventHandler(this.Banks_UC_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Banks_UC_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDTextField;
        private System.Windows.Forms.TextBox NameTextField;
        private System.Windows.Forms.TextBox AddressTextField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchIDTextField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}
