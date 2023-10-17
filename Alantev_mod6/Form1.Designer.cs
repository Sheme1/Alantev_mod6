namespace Alantev_mod6
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
            dataGridView1 = new DataGridView();
            Addbutton = new Button();
            Changebutton = new Button();
            Deletebutton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 326);
            dataGridView1.TabIndex = 0;
            // 
            // Addbutton
            // 
            Addbutton.Location = new Point(12, 401);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(94, 37);
            Addbutton.TabIndex = 1;
            Addbutton.Text = "Добавить";
            Addbutton.UseVisualStyleBackColor = true;
            Addbutton.Click += Addbutton_Click;
            // 
            // Changebutton
            // 
            Changebutton.Location = new Point(112, 401);
            Changebutton.Name = "Changebutton";
            Changebutton.Size = new Size(94, 37);
            Changebutton.TabIndex = 2;
            Changebutton.Text = "Изменить";
            Changebutton.UseVisualStyleBackColor = true;
            Changebutton.Click += Changebutton_Click;
            // 
            // Deletebutton
            // 
            Deletebutton.Location = new Point(212, 401);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(94, 37);
            Deletebutton.TabIndex = 3;
            Deletebutton.Text = "Удалить";
            Deletebutton.UseVisualStyleBackColor = true;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 372);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 372);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 372);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(330, 372);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 354);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 8;
            label1.Text = "ИМЯ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 354);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 9;
            label2.Text = "ФАМИЛИЯ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 354);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 10;
            label3.Text = "ДОЛЖНОСТЬ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 354);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(37, 15);
            label4.TabIndex = 11;
            label4.Text = "ДАТА";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Deletebutton);
            Controls.Add(Changebutton);
            Controls.Add(Addbutton);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Addbutton;
        private Button Changebutton;
        private Button Deletebutton;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}