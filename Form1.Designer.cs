namespace CRUDapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(59, 404);
            button1.Name = "button1";
            button1.Size = new Size(110, 42);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 192);
            button2.Location = new Point(204, 404);
            button2.Name = "button2";
            button2.Size = new Size(110, 42);
            button2.TabIndex = 1;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Location = new Point(347, 404);
            button3.Name = "button3";
            button3.Size = new Size(110, 42);
            button3.TabIndex = 2;
            button3.Text = "Read";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 255, 255);
            button4.Location = new Point(491, 404);
            button4.Name = "button4";
            button4.Size = new Size(110, 42);
            button4.TabIndex = 3;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 128);
            button5.Location = new Point(633, 404);
            button5.Name = "button5";
            button5.Size = new Size(110, 42);
            button5.TabIndex = 4;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Abril Fatface", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 117);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Abril Fatface", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(221, 171);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Abril Fatface", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(221, 223);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 7;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Abril Fatface", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(221, 273);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Abril Fatface", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(221, 326);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 9;
            label5.Text = "Passward";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(387, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 23);
            txtEmail.TabIndex = 10;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(387, 215);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 23);
            txtName.TabIndex = 11;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(387, 265);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(174, 23);
            txtUser.TabIndex = 12;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(387, 323);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(174, 23);
            txtPass.TabIndex = 13;
            txtPass.UseSystemPasswordChar = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(387, 109);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(174, 23);
            numericUpDown1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(150, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(501, 313);
            dataGridView1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Abril Fatface", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(175, 41);
            label6.Name = "label6";
            label6.Size = new Size(459, 36);
            label6.TabIndex = 16;
            label6.Text = "WELCOME TO CRUD APPLICATION";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(793, 545);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(numericUpDown1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD Application";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtUser;
        private TextBox txtPass;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private Label label6;
    }
}
