namespace calificarNotas
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
            txtNombre = new TextBox();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            btnCalcular_Click = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblNotaFinal = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(56, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(639, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(96, 185);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(121, 23);
            txtNota1.TabIndex = 1;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(309, 185);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(119, 23);
            txtNota2.TabIndex = 2;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(536, 185);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(118, 23);
            txtNota3.TabIndex = 3;
            // 
            // btnCalcular_Click
            // 
            btnCalcular_Click.Location = new Point(309, 288);
            btnCalcular_Click.Name = "btnCalcular_Click";
            btnCalcular_Click.Size = new Size(126, 23);
            btnCalcular_Click.TabIndex = 4;
            btnCalcular_Click.Text = "Calcular y Guardar";
            btnCalcular_Click.UseVisualStyleBackColor = true;
            btnCalcular_Click.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 52);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre de estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 167);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "Nota 1";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 167);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Nota 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(570, 167);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Nota 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(345, 384);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 9;
            label5.Click += label5_Click;
            // 
            // lblNotaFinal
            // 
            lblNotaFinal.AutoSize = true;
            lblNotaFinal.Location = new Point(332, 369);
            lblNotaFinal.Name = "lblNotaFinal";
            lblNotaFinal.Size = new Size(65, 15);
            lblNotaFinal.TabIndex = 10;
            lblNotaFinal.Text = "Resultado: ";
            lblNotaFinal.Click += lblNotaFinal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 449);
            Controls.Add(lblNotaFinal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular_Click);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Button btnCalcular_Click;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblNotaFinal;
    }
}
