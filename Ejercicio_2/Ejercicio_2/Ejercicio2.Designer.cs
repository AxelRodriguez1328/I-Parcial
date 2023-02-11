namespace Ejercicio_2
{
    partial class Ejercicio2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nota1 = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.Nota1TextBox = new System.Windows.Forms.TextBox();
            this.Nota2 = new System.Windows.Forms.Label();
            this.Nota2TextBox = new System.Windows.Forms.TextBox();
            this.Nota3 = new System.Windows.Forms.Label();
            this.Nota3TextBox = new System.Windows.Forms.TextBox();
            this.Nota4 = new System.Windows.Forms.Label();
            this.Nota4TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nota1
            // 
            this.Nota1.AutoSize = true;
            this.Nota1.Location = new System.Drawing.Point(59, 104);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(75, 13);
            this.Nota1.TabIndex = 0;
            this.Nota1.Text = "Ingesar nota 1";
            this.Nota1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(364, 185);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(101, 25);
            this.CalcularButton.TabIndex = 1;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.Calcularbutton1_Click);
            // 
            // Nota1TextBox
            // 
            this.Nota1TextBox.Location = new System.Drawing.Point(140, 99);
            this.Nota1TextBox.Name = "Nota1TextBox";
            this.Nota1TextBox.Size = new System.Drawing.Size(96, 20);
            this.Nota1TextBox.TabIndex = 2;
            // 
            // Nota2
            // 
            this.Nota2.AutoSize = true;
            this.Nota2.Location = new System.Drawing.Point(56, 133);
            this.Nota2.Name = "Nota2";
            this.Nota2.Size = new System.Drawing.Size(78, 13);
            this.Nota2.TabIndex = 3;
            this.Nota2.Text = "Ingresar nota 2";
            // 
            // Nota2TextBox
            // 
            this.Nota2TextBox.Location = new System.Drawing.Point(140, 126);
            this.Nota2TextBox.Name = "Nota2TextBox";
            this.Nota2TextBox.Size = new System.Drawing.Size(96, 20);
            this.Nota2TextBox.TabIndex = 4;
            // 
            // Nota3
            // 
            this.Nota3.AutoSize = true;
            this.Nota3.Location = new System.Drawing.Point(56, 163);
            this.Nota3.Name = "Nota3";
            this.Nota3.Size = new System.Drawing.Size(78, 13);
            this.Nota3.TabIndex = 5;
            this.Nota3.Text = "Ingresar nota 3";
            // 
            // Nota3TextBox
            // 
            this.Nota3TextBox.Location = new System.Drawing.Point(140, 156);
            this.Nota3TextBox.Name = "Nota3TextBox";
            this.Nota3TextBox.Size = new System.Drawing.Size(96, 20);
            this.Nota3TextBox.TabIndex = 6;
            // 
            // Nota4
            // 
            this.Nota4.AutoSize = true;
            this.Nota4.Location = new System.Drawing.Point(54, 191);
            this.Nota4.Name = "Nota4";
            this.Nota4.Size = new System.Drawing.Size(80, 13);
            this.Nota4.TabIndex = 7;
            this.Nota4.Text = "Ingresar Nota 4";
            // 
            // Nota4TextBox
            // 
            this.Nota4TextBox.Location = new System.Drawing.Point(140, 184);
            this.Nota4TextBox.Name = "Nota4TextBox";
            this.Nota4TextBox.Size = new System.Drawing.Size(96, 20);
            this.Nota4TextBox.TabIndex = 8;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nota4TextBox);
            this.Controls.Add(this.Nota4);
            this.Controls.Add(this.Nota3TextBox);
            this.Controls.Add(this.Nota3);
            this.Controls.Add(this.Nota2TextBox);
            this.Controls.Add(this.Nota2);
            this.Controls.Add(this.Nota1TextBox);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.Nota1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nota1;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.TextBox Nota1TextBox;
        private System.Windows.Forms.Label Nota2;
        private System.Windows.Forms.TextBox Nota2TextBox;
        private System.Windows.Forms.Label Nota3;
        private System.Windows.Forms.TextBox Nota3TextBox;
        private System.Windows.Forms.Label Nota4;
        private System.Windows.Forms.TextBox Nota4TextBox;
    }
}

