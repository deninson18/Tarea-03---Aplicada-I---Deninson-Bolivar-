namespace ProgramEjercicios2_3_4_5
{
    partial class Ejercicio2_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumTextBox1 = new System.Windows.Forms.TextBox();
            this.NumTextBox2 = new System.Windows.Forms.TextBox();
            this.sumaLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sumar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar Primer Numero:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar Segundo Numero:";
            // 
            // NumTextBox1
            // 
            this.NumTextBox1.Location = new System.Drawing.Point(188, 48);
            this.NumTextBox1.Name = "NumTextBox1";
            this.NumTextBox1.Size = new System.Drawing.Size(100, 20);
            this.NumTextBox1.TabIndex = 3;
            this.NumTextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NumTextBox2
            // 
            this.NumTextBox2.Location = new System.Drawing.Point(188, 89);
            this.NumTextBox2.Name = "NumTextBox2";
            this.NumTextBox2.Size = new System.Drawing.Size(100, 20);
            this.NumTextBox2.TabIndex = 4;
            this.NumTextBox2.TextChanged += new System.EventHandler(this.NumTextBox2_TextChanged);
            // 
            // sumaLabel
            // 
            this.sumaLabel.AutoSize = true;
            this.sumaLabel.Location = new System.Drawing.Point(12, 141);
            this.sumaLabel.Name = "sumaLabel";
            this.sumaLabel.Size = new System.Drawing.Size(0, 13);
            this.sumaLabel.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Ejercicio2_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 235);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sumaLabel);
            this.Controls.Add(this.NumTextBox2);
            this.Controls.Add(this.NumTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Ejercicio2_2";
            this.Text = "Ejercicio2_2";
            this.Load += new System.EventHandler(this.Ejercicio2_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumTextBox1;
        private System.Windows.Forms.TextBox NumTextBox2;
        private System.Windows.Forms.Label sumaLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}