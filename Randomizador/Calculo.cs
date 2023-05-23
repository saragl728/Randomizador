using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizador
{
    public static class Calculo
    {
        public static int[] RandomizarStats(int ps, int ata, int def, int atasp, int defesp, int veloc)
        {
            int[] stats = new int[6];
            int i;  //para los bucles
            // saco la suma de stats
            Random aux = new Random();  //para randomizar
            int suma = ps + ata + def + atasp + defesp + veloc;
            do
            {
                for (i = 0; i < 6; i++)
                {
                    stats[i] = aux.Next(255);
                }
            } while ((stats[0] + stats[1] + stats[2] + stats[3] + stats[4] + stats[5]) != suma);
            return stats;
        }
    }
}
