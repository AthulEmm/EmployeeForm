namespace EmployeeForm
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
            this.Eid_label = new System.Windows.Forms.Label();
            this.GrossPay_label = new System.Windows.Forms.Label();
            this.PF_label = new System.Windows.Forms.Label();
            this.HRA_label = new System.Windows.Forms.Label();
            this.Allowance_label = new System.Windows.Forms.Label();
            this.Sal_label = new System.Windows.Forms.Label();
            this.EName_label = new System.Windows.Forms.Label();
            this.PF_result_label = new System.Windows.Forms.Label();
            this.GrossPay_result_label = new System.Windows.Forms.Label();
            this.EID_textBox = new System.Windows.Forms.TextBox();
            this.E_Name_textBox = new System.Windows.Forms.TextBox();
            this.Sal_textBox = new System.Windows.Forms.TextBox();
            this.Allowance_textBox = new System.Windows.Forms.TextBox();
            this.Hra_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Eid_label
            // 
            this.Eid_label.AutoSize = true;
            this.Eid_label.Location = new System.Drawing.Point(48, 36);
            this.Eid_label.Name = "Eid_label";
            this.Eid_label.Size = new System.Drawing.Size(94, 16);
            this.Eid_label.TabIndex = 0;
            this.Eid_label.Text = "Eployee Code";
            // 
            // GrossPay_label
            // 
            this.GrossPay_label.AutoSize = true;
            this.GrossPay_label.Location = new System.Drawing.Point(323, 380);
            this.GrossPay_label.Name = "GrossPay_label";
            this.GrossPay_label.Size = new System.Drawing.Size(70, 16);
            this.GrossPay_label.TabIndex = 1;
            this.GrossPay_label.Text = "Gross Pay";
            // 
            // PF_label
            // 
            this.PF_label.AutoSize = true;
            this.PF_label.Location = new System.Drawing.Point(323, 326);
            this.PF_label.Name = "PF_label";
            this.PF_label.Size = new System.Drawing.Size(89, 16);
            this.PF_label.TabIndex = 2;
            this.PF_label.Text = "PF Allowance";
            // 
            // HRA_label
            // 
            this.HRA_label.AutoSize = true;
            this.HRA_label.Location = new System.Drawing.Point(48, 258);
            this.HRA_label.Name = "HRA_label";
            this.HRA_label.Size = new System.Drawing.Size(36, 16);
            this.HRA_label.TabIndex = 3;
            this.HRA_label.Text = "HRA";
            // 
            // Allowance_label
            // 
            this.Allowance_label.AutoSize = true;
            this.Allowance_label.Location = new System.Drawing.Point(48, 203);
            this.Allowance_label.Name = "Allowance_label";
            this.Allowance_label.Size = new System.Drawing.Size(69, 16);
            this.Allowance_label.TabIndex = 4;
            this.Allowance_label.Text = "Allowance";
            // 
            // Sal_label
            // 
            this.Sal_label.AutoSize = true;
            this.Sal_label.Location = new System.Drawing.Point(48, 142);
            this.Sal_label.Name = "Sal_label";
            this.Sal_label.Size = new System.Drawing.Size(83, 16);
            this.Sal_label.TabIndex = 5;
            this.Sal_label.Text = "Basic Salary";
            // 
            // EName_label
            // 
            this.EName_label.AutoSize = true;
            this.EName_label.Location = new System.Drawing.Point(48, 87);
            this.EName_label.Name = "EName_label";
            this.EName_label.Size = new System.Drawing.Size(109, 16);
            this.EName_label.TabIndex = 6;
            this.EName_label.Text = "Employee Name";
            // 
            // PF_result_label
            // 
            this.PF_result_label.AutoSize = true;
            this.PF_result_label.Location = new System.Drawing.Point(510, 326);
            this.PF_result_label.Name = "PF_result_label";
            this.PF_result_label.Size = new System.Drawing.Size(14, 16);
            this.PF_result_label.TabIndex = 7;
            this.PF_result_label.Text = "0";
            // 
            // GrossPay_result_label
            // 
            this.GrossPay_result_label.AutoSize = true;
            this.GrossPay_result_label.Location = new System.Drawing.Point(510, 380);
            this.GrossPay_result_label.Name = "GrossPay_result_label";
            this.GrossPay_result_label.Size = new System.Drawing.Size(14, 16);
            this.GrossPay_result_label.TabIndex = 8;
            this.GrossPay_result_label.Text = "0";
            // 
            // EID_textBox
            // 
            this.EID_textBox.Location = new System.Drawing.Point(255, 36);
            this.EID_textBox.Name = "EID_textBox";
            this.EID_textBox.Size = new System.Drawing.Size(100, 22);
            this.EID_textBox.TabIndex = 9;
            this.EID_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EID_textBox_KeyPress);
            // 
            // E_Name_textBox
            // 
            this.E_Name_textBox.Location = new System.Drawing.Point(255, 84);
            this.E_Name_textBox.Name = "E_Name_textBox";
            this.E_Name_textBox.Size = new System.Drawing.Size(100, 22);
            this.E_Name_textBox.TabIndex = 10;
            this.E_Name_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.E_Name_textBox_KeyPress);
            // 
            // Sal_textBox
            // 
            this.Sal_textBox.Location = new System.Drawing.Point(255, 136);
            this.Sal_textBox.Name = "Sal_textBox";
            this.Sal_textBox.Size = new System.Drawing.Size(100, 22);
            this.Sal_textBox.TabIndex = 11;
            this.Sal_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sal_textBox_KeyPress);
            // 
            // Allowance_textBox
            // 
            this.Allowance_textBox.Location = new System.Drawing.Point(255, 197);
            this.Allowance_textBox.Name = "Allowance_textBox";
            this.Allowance_textBox.Size = new System.Drawing.Size(100, 22);
            this.Allowance_textBox.TabIndex = 12;
            this.Allowance_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Allowance_textBox_KeyPress);
            // 
            // Hra_textBox
            // 
            this.Hra_textBox.Location = new System.Drawing.Point(255, 258);
            this.Hra_textBox.Name = "Hra_textBox";
            this.Hra_textBox.Size = new System.Drawing.Size(100, 22);
            this.Hra_textBox.TabIndex = 13;
            this.Hra_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hra_textBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Hra_textBox);
            this.Controls.Add(this.Allowance_textBox);
            this.Controls.Add(this.Sal_textBox);
            this.Controls.Add(this.E_Name_textBox);
            this.Controls.Add(this.EID_textBox);
            this.Controls.Add(this.GrossPay_result_label);
            this.Controls.Add(this.PF_result_label);
            this.Controls.Add(this.EName_label);
            this.Controls.Add(this.Sal_label);
            this.Controls.Add(this.Allowance_label);
            this.Controls.Add(this.HRA_label);
            this.Controls.Add(this.PF_label);
            this.Controls.Add(this.GrossPay_label);
            this.Controls.Add(this.Eid_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Eid_label;
        private System.Windows.Forms.Label GrossPay_label;
        private System.Windows.Forms.Label PF_label;
        private System.Windows.Forms.Label HRA_label;
        private System.Windows.Forms.Label Allowance_label;
        private System.Windows.Forms.Label Sal_label;
        private System.Windows.Forms.Label EName_label;
        private System.Windows.Forms.Label PF_result_label;
        private System.Windows.Forms.Label GrossPay_result_label;
        private System.Windows.Forms.TextBox EID_textBox;
        private System.Windows.Forms.TextBox E_Name_textBox;
        private System.Windows.Forms.TextBox Sal_textBox;
        private System.Windows.Forms.TextBox Allowance_textBox;
        private System.Windows.Forms.TextBox Hra_textBox;
        private System.Windows.Forms.Button button1;
    }
}

