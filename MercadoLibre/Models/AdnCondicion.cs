using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoLibre.Models
{
    public class AdnCondicion
    {
        [Onlyacgt(ErrorMessage ="Solo se permite las letras a,c,g,t")]
        public string[] Adn { get; set; }
    }
    public class Onlyacgt : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string[] list = (string[])value;
            int variable = 0;
            bool result = true;
            do
            {
                for (int i = 0; i < list.Length; i++)
                {
                    for (int j = 0; j < list[i].Length; j++)
                    {
                        string elemento = Convert.ToString(list[i][j]);
                        if (
                        elemento.Contains("b") || elemento.Contains("D") || elemento.Contains("e") || elemento.Contains("F") ||
                        elemento.Contains("B") || elemento.Contains("d") || elemento.Contains("E") || elemento.Contains("f") ||
                        elemento.Contains("h") || elemento.Contains("i") || elemento.Contains("J") || elemento.Contains("K") ||
                        elemento.Contains("H") || elemento.Contains("I") || elemento.Contains("j") || elemento.Contains("k") ||
                        elemento.Contains("l") || elemento.Contains("m") || elemento.Contains("n") || elemento.Contains("o") ||
                        elemento.Contains("L") || elemento.Contains("M") || elemento.Contains("N") || elemento.Contains("O") ||
                        elemento.Contains("p") || elemento.Contains("q") || elemento.Contains("r") || elemento.Contains("s") ||
                        elemento.Contains("P") || elemento.Contains("Q") || elemento.Contains("R") || elemento.Contains("S") ||
                        elemento.Contains("p") || elemento.Contains("q") || elemento.Contains("r") || elemento.Contains("s") ||
                        elemento.Contains("P") || elemento.Contains("Q") || elemento.Contains("R") || elemento.Contains("S") ||
                        elemento.Contains("V") || elemento.Contains("W") || elemento.Contains("X") || elemento.Contains("Y") ||
                        elemento.Contains("v") || elemento.Contains("w") || elemento.Contains("x") || elemento.Contains("y") ||
                        elemento.Contains("Z") || elemento.Contains("Ñ") || elemento.Contains("z") || elemento.Contains("ñ")
                        )
                        {
                            variable = 1;
                        }
                    }
                }

            } while (variable == 0);            
            if (variable > 0) 
            {
                result = false;
            }
            return result;
        }
    }
}
