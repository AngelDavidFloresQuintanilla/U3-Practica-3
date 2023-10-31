namespace U3_Practica_3
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
            label1 = new Label();
            f_num = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            Total = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(662, 45);
            label1.TabIndex = 0;
            label1.Text = "Este programa suma los numeros capturados";
            // 
            // f_num
            // 
            f_num.AutoSize = true;
            f_num.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            f_num.Location = new Point(158, 111);
            f_num.Name = "f_num";
            f_num.Size = new Size(307, 41);
            f_num.TabIndex = 1;
            f_num.Text = "Introduce un numero:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(514, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(541, 191);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 3;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(796, 94);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 420);
            listBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(49, 409);
            button2.Name = "button2";
            button2.Size = new Size(215, 121);
            button2.TabIndex = 5;
            button2.Text = "Sumar  numeros";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Total.Location = new Point(158, 343);
            Total.Name = "Total";
            Total.Size = new Size(316, 41);
            Total.TabIndex = 6;
            Total.Text = "La suma de todos son:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(514, 346);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 565);
            Controls.Add(textBox2);
            Controls.Add(Total);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(f_num);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label f_num;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Label Total;
        private TextBox textBox2;
    }
}