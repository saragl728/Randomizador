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
            this.lAtaEsp = new System.Windows.Forms.Label();
            this.lDefEsp = new System.Windows.Forms.Label();
            this.lVeloc = new System.Windows.Forms.Label();
            this.bRandom = new System.Windows.Forms.Button();
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
            // lAtaEsp
            // 
            this.lAtaEsp.AutoSize = true;
            this.lAtaEsp.Location = new System.Drawing.Point(402, 90);
            this.lAtaEsp.Name = "lAtaEsp";
            this.lAtaEsp.Size = new System.Drawing.Size(84, 13);
            this.lAtaEsp.TabIndex = 3;
            this.lAtaEsp.Text = "Ataque Especial";
            // 
            // lDefEsp
            // 
            this.lDefEsp.AutoSize = true;
            this.lDefEsp.Location = new System.Drawing.Point(306, 140);
            this.lDefEsp.Name = "lDefEsp";
            this.lDefEsp.Size = new System.Drawing.Size(90, 13);
            this.lDefEsp.TabIndex = 4;
            this.lDefEsp.Text = "Defensa Especial";
            // 
            // lVeloc
            // 
            this.lVeloc.AutoSize = true;
            this.lVeloc.Location = new System.Drawing.Point(416, 140);
            this.lVeloc.Name = "lVeloc";
            this.lVeloc.Size = new System.Drawing.Size(54, 13);
            this.lVeloc.TabIndex = 5;
            this.lVeloc.Text = "Velocidad";
            // 
            // bRandom
            // 
            this.bRandom.Location = new System.Drawing.Point(344, 222);
            this.bRandom.Name = "bRandom";
            this.bRandom.Size = new System.Drawing.Size(87, 27);
            this.bRandom.TabIndex = 6;
            this.bRandom.Text = "Randomizar";
            this.bRandom.UseVisualStyleBackColor = true;
            // 
            // fRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bRandom);
            this.Controls.Add(this.lVeloc);
            this.Controls.Add(this.lDefEsp);
            this.Controls.Add(this.lAtaEsp);
            this.Controls.Add(this.lDefensa);
            this.Controls.Add(this.lAtaque);
            this.Controls.Add(this.lPS);
            this.Name = "fRandom";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPS;
        private System.Windows.Forms.Label lAtaque;
        private System.Windows.Forms.Label lDefensa;
        private System.Windows.Forms.Label lAtaEsp;
        private System.Windows.Forms.Label lDefEsp;
        private System.Windows.Forms.Label lVeloc;
        private System.Windows.Forms.Button bRandom;
    }
}

