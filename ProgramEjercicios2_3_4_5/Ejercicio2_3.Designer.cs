namespace ProgramEjercicios2_3_4_5
{
    partial class Ejercicio2_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradoButton = new System.Windows.Forms.Button();
            this.gradoTextBox1 = new System.Windows.Forms.TextBox();
            this.RtextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultadotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radianes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grado";
            // 
            // gradoButton
            // 
            this.gradoButton.Location = new System.Drawing.Point(22, 229);
            this.gradoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gradoButton.Name = "gradoButton";
            this.gradoButton.Size = new System.Drawing.Size(112, 35);
            this.gradoButton.TabIndex = 2;
            this.gradoButton.Text = "Calcular";
            this.gradoButton.UseVisualStyleBackColor = true;
            this.gradoButton.Click += new System.EventHandler(this.gradoButton_Click);
            // 
            // gradoTextBox1
            // 
            this.gradoTextBox1.Location = new System.Drawing.Point(22, 128);
            this.gradoTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gradoTextBox1.MaxLength = 32766;
            this.gradoTextBox1.Name = "gradoTextBox1";
            this.gradoTextBox1.Size = new System.Drawing.Size(294, 26);
            this.gradoTextBox1.TabIndex = 3;
            // 
            // RtextBox2
            // 
            this.RtextBox2.Location = new System.Drawing.Point(134, 37);
            this.RtextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RtextBox2.Name = "RtextBox2";
            this.RtextBox2.Size = new System.Drawing.Size(178, 26);
            this.RtextBox2.TabIndex = 4;
            this.RtextBox2.Text = "0.0174532925";
            this.RtextBox2.TextChanged += new System.EventHandler(this.RtextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // resultadotextBox
            // 
            this.resultadotextBox.Location = new System.Drawing.Point(22, 192);
            this.resultadotextBox.Name = "resultadotextBox";
            this.resultadotextBox.Size = new System.Drawing.Size(294, 26);
            this.resultadotextBox.TabIndex = 6;
            // 
            // Ejercicio2_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 269);
            this.Controls.Add(this.resultadotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RtextBox2);
            this.Controls.Add(this.gradoTextBox1);
            this.Controls.Add(this.gradoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ejercicio2_3";
            this.Text = "Ejercicio2_3";
            this.Load += new System.EventHandler(this.Ejercicio2_3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gradoButton;
        private System.Windows.Forms.TextBox gradoTextBox1;
        private System.Windows.Forms.TextBox RtextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultadotextBox;
    }
}