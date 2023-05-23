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
                int salud = Convert.ToInt32(tPS);
                int ataque = Convert.ToInt32(tAtaque);
                int defensa = Convert.ToInt32(tDefensa);
                int ataEsp = Convert.ToInt32(tAtaEsp);
                int defEsp = Convert.ToInt32(tDefEsp);
                int velocidad = Convert.ToInt32(tVeloc);
                //añado excepciones
                if (salud <= 0) throw new Exception("Los stats tienen que ser superiores a 0");
                if (ataque <= 0) throw new Exception("Los stats tienen que ser superiores a 0");
                if (defensa <= 0) throw new Exception("Los stats tienen que ser superiores a 0");
                if (ataEsp <= 0) throw new Exception("Los stats tienen que ser superiores a 0");
                if (defEsp <= 0) throw new Exception("Los stats tienen que ser superiores a 0");
                if (velocidad <= 0) throw new Exception("Los stats tienen que ser superiores a 0");
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
