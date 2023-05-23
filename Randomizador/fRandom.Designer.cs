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
            this.tPS = new System.Windows.Forms.TextBox();
            this.tAtaque = new System.Windows.Forms.TextBox();
            this.tDefensa = new System.Windows.Forms.TextBox();
            this.tAtaEsp = new System.Windows.Forms.TextBox();
            this.tDefEsp = new System.Windows.Forms.TextBox();
            this.tVeloc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lPS
            // 
            this.lPS.AutoSize = true;
            this.lPS.Location = new System.Drawing.Point(65, 41);
            this.lPS.Name = "lPS";
            this.lPS.Size = new System.Drawing.Size(21, 13);
            this.lPS.TabIndex = 0;
            this.lPS.Text = "PS";
            // 
            // lAtaque
            // 
            this.lAtaque.AutoSize = true;
            this.lAtaque.Location = new System.Drawing.Point(294, 41);
            this.lAtaque.Name = "lAtaque";
            this.lAtaque.Size = new System.Drawing.Size(41, 13);
            this.lAtaque.TabIndex = 1;
            this.lAtaque.Text = "Ataque";
            // 
            // lDefensa
            // 
            this.lDefensa.AutoSize = true;
            this.lDefensa.Location = new System.Drawing.Point(564, 41);
            this.lDefensa.Name = "lDefensa";
            this.lDefensa.Size = new System.Drawing.Size(47, 13);
            this.lDefensa.TabIndex = 2;
            this.lDefensa.Text = "Defensa";
            // 
            // lAtaEsp
            // 
            this.lAtaEsp.AutoSize = true;
            this.lAtaEsp.Location = new System.Drawing.Point(65, 110);
            this.lAtaEsp.Name = "lAtaEsp";
            this.lAtaEsp.Size = new System.Drawing.Size(84, 13);
            this.lAtaEsp.TabIndex = 3;
            this.lAtaEsp.Text = "Ataque Especial";
            // 
            // lDefEsp
            // 
            this.lDefEsp.AutoSize = true;
            this.lDefEsp.Location = new System.Drawing.Point(294, 110);
            this.lDefEsp.Name = "lDefEsp";
            this.lDefEsp.Size = new System.Drawing.Size(90, 13);
            this.lDefEsp.TabIndex = 4;
            this.lDefEsp.Text = "Defensa Especial";
            // 
            // lVeloc
            // 
            this.lVeloc.AutoSize = true;
            this.lVeloc.Location = new System.Drawing.Point(564, 110);
            this.lVeloc.Name = "lVeloc";
            this.lVeloc.Size = new System.Drawing.Size(54, 13);
            this.lVeloc.TabIndex = 5;
            this.lVeloc.Text = "Velocidad";
            // 
            // bRandom
            // 
            this.bRandom.Location = new System.Drawing.Point(400, 222);
            this.bRandom.Name = "bRandom";
            this.bRandom.Size = new System.Drawing.Size(87, 27);
            this.bRandom.TabIndex = 6;
            this.bRandom.Text = "Randomizar";
            this.bRandom.UseVisualStyleBackColor = true;
            this.bRandom.Click += new System.EventHandler(this.bRandom_Click);
            // 
            // tPS
            // 
            this.tPS.Location = new System.Drawing.Point(167, 41);
            this.tPS.Name = "tPS";
            this.tPS.Size = new System.Drawing.Size(85, 20);
            this.tPS.TabIndex = 7;
            // 
            // tAtaque
            // 
            this.tAtaque.Location = new System.Drawing.Point(390, 41);
            this.tAtaque.Name = "tAtaque";
            this.tAtaque.Size = new System.Drawing.Size(85, 20);
            this.tAtaque.TabIndex = 8;
            // 
            // tDefensa
            // 
            this.tDefensa.Location = new System.Drawing.Point(666, 41);
            this.tDefensa.Name = "tDefensa";
            this.tDefensa.Size = new System.Drawing.Size(85, 20);
            this.tDefensa.TabIndex = 9;
            // 
            // tAtaEsp
            // 
            this.tAtaEsp.Location = new System.Drawing.Point(167, 110);
            this.tAtaEsp.Name = "tAtaEsp";
            this.tAtaEsp.Size = new System.Drawing.Size(85, 20);
            this.tAtaEsp.TabIndex = 10;
            // 
            // tDefEsp
            // 
            this.tDefEsp.Location = new System.Drawing.Point(390, 110);
            this.tDefEsp.Name = "tDefEsp";
            this.tDefEsp.Size = new System.Drawing.Size(85, 20);
            this.tDefEsp.TabIndex = 11;
            // 
            // tVeloc
            // 
            this.tVeloc.Location = new System.Drawing.Point(666, 110);
            this.tVeloc.Name = "tVeloc";
            this.tVeloc.Size = new System.Drawing.Size(85, 20);
            this.tVeloc.TabIndex = 12;
            // 
            // fRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tVeloc);
            this.Controls.Add(this.tDefEsp);
            this.Controls.Add(this.tAtaEsp);
            this.Controls.Add(this.tDefensa);
            this.Controls.Add(this.tAtaque);
            this.Controls.Add(this.tPS);
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
        private System.Windows.Forms.TextBox tPS;
        private System.Windows.Forms.TextBox tAtaque;
        private System.Windows.Forms.TextBox tDefensa;
        private System.Windows.Forms.TextBox tAtaEsp;
        private System.Windows.Forms.TextBox tDefEsp;
        private System.Windows.Forms.TextBox tVeloc;
    }
}

