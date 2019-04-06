namespace Bank_Database_Management_System.User_Controls
{
    partial class Accounts_UC
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
            this.AccNoTextField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeTextField = new System.Windows.Forms.TextBox();
            this.BalTextField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchAccTextField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Br_idtextfield = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cust_idtextfield = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AccNoTextField
            // 
            this.AccNoTextField.Location = new System.Drawing.Point(78, 71);
            this.AccNoTextField.Name = "AccNoTextField";
            this.AccNoTextField.Size = new System.Drawing.Size(190, 20);
            this.AccNoTextField.TabIndex = 28;
            this.AccNoTextField.TextChanged += new System.EventHandler(this.CustIDTextField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Acc No. :";
            // 
            // TypeTextField
            // 
            this.TypeTextField.Location = new System.Drawing.Point(78, 111);
            this.TypeTextField.Name = "TypeTextField";
            this.TypeTextField.Size = new System.Drawing.Size(190, 20);
            this.TypeTextField.TabIndex = 32;
            this.TypeTextField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BalTextField
            // 
            this.BalTextField.Location = new System.Drawing.Point(78, 151);
            this.BalTextField.Name = "BalTextField";
            this.BalTextField.Size = new System.Drawing.Size(190, 20);
            this.BalTextField.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Balance:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 181);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 31);
            this.label4.TabIndex = 39;
            this.label4.Text = "Account";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(118, 261);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(96, 35);
            this.AddButton.TabIndex = 40;
            this.AddButton.Text = "Add Record";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(576, 68);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(174, 23);
            this.SearchButton.TabIndex = 41;
            this.SearchButton.Text = "Search Record";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchAccTextField
            // 
            this.SearchAccTextField.Location = new System.Drawing.Point(363, 70);
            this.SearchAccTextField.Name = "SearchAccTextField";
            this.SearchAccTextField.Size = new System.Drawing.Size(190, 20);
            this.SearchAccTextField.TabIndex = 42;
            this.SearchAccTextField.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Acc No. :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(118, 306);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(99, 13);
            this.StatusLabel.TabIndex = 45;
            this.StatusLabel.Text = "Successfully added";
            this.StatusLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Branch ID :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Br_idtextfield
            // 
            this.Br_idtextfield.Location = new System.Drawing.Point(78, 191);
            this.Br_idtextfield.Name = "Br_idtextfield";
            this.Br_idtextfield.Size = new System.Drawing.Size(190, 20);
            this.Br_idtextfield.TabIndex = 46;
            this.Br_idtextfield.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Cust ID :";
            // 
            // cust_idtextfield
            // 
            this.cust_idtextfield.Location = new System.Drawing.Point(78, 231);
            this.cust_idtextfield.Name = "cust_idtextfield";
            this.cust_idtextfield.Size = new System.Drawing.Size(190, 20);
            this.cust_idtextfield.TabIndex = 48;
            // 
            // Accounts_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cust_idtextfield);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Br_idtextfield);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchAccTextField);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BalTextField);
            this.Controls.Add(this.TypeTextField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AccNoTextField);
            this.Name = "Accounts_UC";
            this.Size = new System.Drawing.Size(766, 351);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Accounts_UC_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AccNoTextField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TypeTextField;
        private System.Windows.Forms.TextBox BalTextField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchAccTextField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Br_idtextfield;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cust_idtextfield;
    }
}
