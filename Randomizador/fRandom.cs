using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizador
{
    public partial class fRandom : Form
    {
        public fRandom()
        {
            InitializeComponent();
        }

        private void bRandom_Click(object sender, EventArgs e)
        {
            try
            {
                //declaro variables
                int salud = Convert.ToInt32(tPS.Text);
                int ataque = Convert.ToInt32(tAtaque.Text);
                int defensa = Convert.ToInt32(tDefensa.Text);
                int ataEsp = Convert.ToInt32(tAtaEsp.Text);
                int defEsp = Convert.ToInt32(tDefEsp.Text);
                int velocidad = Convert.ToInt32(tVeloc.Text);
                int[] estadisticas = new int[6];    //array de los stats nuevos

                //añado excepciones
                if (salud <= 0) throw new Exception("Los stats tienen que ser superiores a 0");
                if (ataque <= 0) throw new Exception("Los stats tienen que ser superiores a 0");
                if (defensa <= 0) throw new Exception("Los stats tienen que ser superiores a 0");
                if (ataEsp <= 0) throw new Exception("Los stats tienen que ser superiores a 0");
                if (defEsp <= 0) throw new Exception("Los stats tienen que ser superiores a 0");
                if (velocidad <= 0) throw new Exception("Los stats tienen que ser superiores a 0");
                if ((salud + ataque + defensa + ataEsp + defEsp + velocidad) > 1530) throw new Exception("La suma de stats es demasiado grande para el Randomizado");
                // se hace el randomizado
                estadisticas = Calculo.RandomizarStats(salud, ataque, defensa, ataEsp, defEsp, velocidad);

                //se muestran los stats randomizados
                MessageBox.Show($"Los nuevos stats son:\nPS: {estadisticas[0]}\nAtaque: {estadisticas[1]}\nDefensa: {estadisticas[2]}\nAtaque Especial: {estadisticas[3]}\nDefensa Especial: {estadisticas[4]}\nVelocidad: {estadisticas[5]}", "Resultado del randomizado", MessageBoxButtons.OK);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "Entrada incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException error)
            {
                MessageBox.Show(error.Message, "Entrada incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Entrada incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
