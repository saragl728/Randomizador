namespace Randomizador
{
    partial class fRandom
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
            this.lPS = new System.Windows.Forms.Label();
            this.lAtaque = new System.Windows.Forms.Label();
            this.lDefensa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lPS
            // 
            this.lPS.AutoSize = true;
            this.lPS.Location = new System.Drawing.Point(314, 50);
            this.lPS.Name = "lPS";
            this.lPS.Size = new System.Drawing.Size(21, 13);
            this.lPS.TabIndex = 0;
            this.lPS.Text = "PS";
            // 
            // lAtaque
            // 
            this.lAtaque.AutoSize = true;
            this.lAtaque.Location = new System.Drawing.Point(402, 49);
            this.lAtaque.Name = "lAtaque";
            this.lAtaque.Size = new System.Drawing.Size(41, 13);
            this.lAtaque.TabIndex = 1;
            this.lAtaque.Text = "Ataque";
            // 
            // lDefensa
            // 
            this.lDefensa.AutoSize = true;
            this.lDefensa.Location = new System.Drawing.Point(306, 90);
            this.lDefensa.Name = "lDefensa";
            this.lDefensa.Size = new System.Drawing.Size(47, 13);
            this.lDefensa.TabIndex = 2;
            this.lDefensa.Text = "Defensa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lDefensa);
            this.Controls.Add(this.lAtaque);
            this.Controls.Add(this.lPS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPS;
        private System.Windows.Forms.Label lAtaque;
        private System.Windows.Forms.Label lDefensa;
    }
}

