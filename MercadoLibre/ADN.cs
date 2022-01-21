using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoLibre
{
    public class ADN
    {
        public bool isMutant(string[] dna)
        {
            if (dna != null)
            {
                int cantidad = 0;
                int horizontal = 0;
                int oblicuoD = 0;
                int oblicuoI = 0;
                //--vertical
                //recorre las filas 
                for (int i = 0; i < dna.Length; i++)
                {
                    //recorre las columnas de la fila
                    for (int j = 0; j < dna[i].Length; j++)
                    {
                        string elemento = Convert.ToString(dna[i][j]);
                        if (j > 0)
                        {
                            string ant_elemento = Convert.ToString(dna[i][j - 1]);
                            if (ant_elemento == elemento)
                            {
                                cantidad = cantidad + 1;
                            }
                        }
                    }
                    if (i > 0)
                    {
                        //encuentra la fila anterior
                        string ant_fila = dna[i - 1];
                        //recorre la actual fila
                        for (int f = 0; f < dna[i].Length; f++)
                        {
                            //obtiene el elemento actual
                            string elemento = Convert.ToString(dna[i][f]);
                            //recorre la anterior fila
                            for (int e = 0; e < ant_fila.Length; e++)
                            {
                                //obtiene el elemento anterior
                                string ant_elemento = Convert.ToString(ant_fila[e]);
                                if (f == e)
                                {
                                    if (elemento == ant_elemento)
                                    {
                                        horizontal = horizontal + 1;
                                    }
                                }
                                if (f > 0 && e == f - 1 && e < ant_fila.Length)
                                {
                                    if (elemento == ant_elemento)
                                    {
                                        oblicuoD = oblicuoD + 1;
                                    }
                                }
                                if (e > 0 && e == f + 1 && f < dna[i].Length)
                                {
                                    if (elemento == ant_elemento)
                                    {
                                        oblicuoI = oblicuoI + 1;
                                    }
                                }
                            }
                        }
                    }

                }
                if(cantidad >= 3|| horizontal >= 3 || oblicuoD >= 3 || oblicuoI >= 3 )
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }
            }
            else { return false; }
        }
        
    }
}
