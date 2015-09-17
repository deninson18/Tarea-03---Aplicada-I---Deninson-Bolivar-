namespace ProgramEjercicios2_3_4_5
{
    partial class Ejercicio2_1
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
            this.ResButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LongTextBox = new System.Windows.Forms.TextBox();
            this.NumTextBox2 = new System.Windows.Forms.TextBox();
            this.ResTextBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResButton
            // 
            this.ResButton.Location = new System.Drawing.Point(67, 194);
            this.ResButton.Name = "ResButton";
            this.ResButton.Size = new System.Drawing.Size(75, 23);
            this.ResButton.TabIndex = 0;
            this.ResButton.Text = "Calcular";
            this.ResButton.UseVisualStyleBackColor = true;
            this.ResButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar Longitud:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar Numero de la Lados:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LongTextBox
            // 
            this.LongTextBox.Location = new System.Drawing.Point(172, 35);
            this.LongTextBox.Name = "LongTextBox";
            this.LongTextBox.Size = new System.Drawing.Size(100, 20);
            this.LongTextBox.TabIndex = 3;
            // 
            // NumTextBox2
            // 
            this.NumTextBox2.Location = new System.Drawing.Point(172, 82);
            this.NumTextBox2.Name = "NumTextBox2";
            this.NumTextBox2.Size = new System.Drawing.Size(100, 20);
            this.NumTextBox2.TabIndex = 4;
            // 
            // ResTextBox3
            // 
            this.ResTextBox3.Location = new System.Drawing.Point(15, 147);
            this.ResTextBox3.Name = "ResTextBox3";
            this.ResTextBox3.Size = new System.Drawing.Size(257, 20);
            this.ResTextBox3.TabIndex = 5;
            // 
            // Ejercicio2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ResTextBox3);
            this.Controls.Add(this.NumTextBox2);
            this.Controls.Add(this.LongTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResButton);
            this.Name = "Ejercicio2_1";
            this.Text = "Ejercicio2_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LongTextBox;
        private System.Windows.Forms.TextBox NumTextBox2;
        private System.Windows.Forms.TextBox ResTextBox3;
    }
}