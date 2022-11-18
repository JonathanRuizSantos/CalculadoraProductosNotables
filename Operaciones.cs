using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIPN
{
    internal class Operaciones
    {
        bool esNumero_a;
        int value_a;
        bool esNumero_b;
        int value_b;
        double suma;
        string valor_a = "", valor_b = "";
        int valor_a_entero, valor_b_entero;

        public string binomioCuadradoPositivo(string a, string b, ref string resultado)
        {
            resultado = "";
            valor_a = "";
            valor_b = "";
            suma = 0;

            esNumero_a = int.TryParse(a, out value_a);
            esNumero_b = int.TryParse(b, out value_b);

            if (esNumero_a && !esNumero_b)
            {
                if(b.Length == 1)
                {
                    resultado = Math.Pow(value_a, 2).ToString() + " + " + (2 * value_a).ToString() + b + " + " + b + "^2";
                }
                else if(b.Length > 1)
                {
                    for (int i = 0; i < b.Length - 1; i++)
                    {
                        valor_b = valor_b + b[i].ToString();
                    }
                    resultado = Math.Pow(value_a,2).ToString() + " + " 
                        +(2 * value_a * int.Parse(valor_b)).ToString() + b[b.Length-1] + " + " 
                        + Math.Pow(int.Parse(valor_b),2).ToString() + b[b.Length - 1] + "^2 ";
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }
            }
            else if(!esNumero_a && esNumero_b)
            {
                if(a.Length == 1)
                {
                    resultado = a + "^2 + " + (2 * value_b).ToString() + a + " + " + Math.Pow(value_b, 2).ToString();
                }
                else if(a.Length > 1)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        valor_a = valor_a + a[i].ToString();
                    }

                    resultado = Math.Pow(int.Parse(valor_a), 2).ToString() + a[a.Length - 1] + "^2 + " +
                        (2 * int.Parse(valor_a) * int.Parse(b)).ToString() + a[a.Length - 1] + " + " +
                        Math.Pow(int.Parse(b), 2).ToString();
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }
            }
            else if(esNumero_a && esNumero_b)
            {
                resultado = Math.Pow(value_a, 2).ToString() + " + " + (2 * value_a * value_b).ToString() + " + " +
                    Math.Pow(value_b, 2).ToString();
                suma = Math.Pow(value_a, 2) + (2 * value_a * value_b) + Math.Pow(value_b, 2);
                resultado = resultado + " = " + suma.ToString();
            }
            else if (!esNumero_a && !esNumero_b)
            {
                if (a.Length == 1 && b.Length == 1)
                {
                    resultado = a + "^2 + " + "2" + a + b + " + " + b + "^2";
                }
                else if(a.Length > 1 && b.Length == 1)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        valor_a = valor_a + a[i].ToString();
                    }

                    resultado = Math.Pow(int.Parse(valor_a), 2).ToString() + a[a.Length - 1] + "^2 + " +
                        (2 * int.Parse(valor_a)) + a[a.Length - 1] + b + " + " + b + "^2";
                }
                else if(a.Length == 1 && b.Length > 1)
                {
                    for (int i = 0; i < b.Length - 1; i++)
                    {
                        valor_b = valor_b + b[i].ToString();
                    }

                    resultado = a + "^2 + " + (2 * int.Parse(valor_b)) + a + b[b.Length - 1] + " + " + 
                        Math.Pow(int.Parse(valor_b),2).ToString() +b[b.Length - 1] + "^2";
                }
                else if(a.Length > 1 && b.Length > 1)
                {
                    if (a[a.Length-1] == b[b.Length-1])
                    {
                        for (int i = 0; i < a.Length - 1; i++)
                        {
                            valor_a = valor_a + a[i].ToString();
                        }
                        for (int i = 0; i < b.Length - 1; i++)
                        {
                            valor_b = valor_b + b[i].ToString();
                        }

                        resultado = Math.Pow((int.Parse(valor_a)+int.Parse(valor_b)),2).ToString() + a[a.Length-1] + "^2";
                    }
                    else
                    {
                        for (int i = 0; i < a.Length - 1; i++)
                        {
                            valor_a = valor_a + a[i].ToString();
                        }
                        for (int i = 0; i < b.Length - 1; i++)
                        {
                            valor_b = valor_b + b[i].ToString();
                        }

                        resultado = Math.Pow(int.Parse(valor_a), 2).ToString() + a[a.Length - 1] + "^2 + " +
                            (2 * int.Parse(valor_a) * int.Parse(valor_b)).ToString() + a[a.Length - 1] +
                            b[b.Length - 1] + " + " + Math.Pow(int.Parse(valor_b), 2).ToString() + b[b.Length - 1] + "^2";
                    }
                    
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }

            }
            else
            {
                MessageBox.Show("Error");
            }

            return resultado;
        }

        public string binomioCuadradoNegativo(string a, string b, ref string resultado)
        {
            resultado = "";
            valor_a = "";
            valor_b = "";
            suma = 0;

            esNumero_a = int.TryParse(a, out value_a);
            esNumero_b = int.TryParse(b, out value_b);

            if (esNumero_a && !esNumero_b)
            {
                if (b.Length == 1)
                {
                    resultado = Math.Pow(value_a, 2).ToString() + " - " + (2 * value_a).ToString() + b + " + " + b + "^2";
                }
                else if (b.Length > 1)
                {
                    for (int i = 0; i < b.Length - 1; i++)
                    {
                        valor_b = valor_b + b[i].ToString();
                    }
                    resultado = Math.Pow(value_a, 2).ToString() + " - "
                        + (2 * value_a * int.Parse(valor_b)).ToString() + b[b.Length - 1] + " + "
                        + Math.Pow(int.Parse(valor_b), 2).ToString() + b[b.Length - 1] + "^2 ";
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }
            }
            else if (!esNumero_a && esNumero_b)
            {
                if (a.Length == 1)
                {
                    resultado = a + "^2 + " + (2 * value_b).ToString() + a + " + " + Math.Pow(value_b, 2).ToString();
                }
                else if (a.Length > 1)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        valor_a = valor_a + a[i].ToString();
                    }

                    resultado = Math.Pow(int.Parse(valor_a), 2).ToString() + a[a.Length - 1] + "^2 - " +
                        (2 * int.Parse(valor_a) * int.Parse(b)).ToString() + a[a.Length - 1] + " + " +
                        Math.Pow(int.Parse(b), 2).ToString();
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }
            }
            else if (esNumero_a && esNumero_b)
            {
                resultado = Math.Pow(value_a, 2).ToString() + " - " + (2 * value_a * value_b).ToString() + " + " +
                    Math.Pow(value_b, 2).ToString();
                suma = Math.Pow(value_a, 2) - (2 * value_a * value_b) + Math.Pow(value_b, 2);
                resultado = resultado + " = " + suma.ToString();
            }
            else if (!esNumero_a && !esNumero_b)
            {
                if (a.Length == 1 && b.Length == 1)
                {
                    resultado = a + "^2 - " + "2" + a + b + " + " + b + "^2";
                }
                else if (a.Length > 1 && b.Length == 1)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        valor_a = valor_a + a[i].ToString();
                    }

                    resultado = Math.Pow(int.Parse(valor_a), 2).ToString() + a[a.Length - 1] + "^2 - " +
                        (2 * int.Parse(valor_a)) + a[a.Length - 1] + b + " + " + b + "^2";
                }
                else if (a.Length == 1 && b.Length > 1)
                {
                    for (int i = 0; i < b.Length - 1; i++)
                    {
                        valor_b = valor_b + b[i].ToString();
                    }

                    resultado = a + "^2 - " + (2 * int.Parse(valor_b)) + a + b[b.Length - 1] + " + " +
                        Math.Pow(int.Parse(valor_b), 2).ToString() + b[b.Length - 1] + "^2";
                }
                else if (a.Length > 1 && b.Length > 1)
                {
                    if (a[a.Length - 1] == b[b.Length - 1])
                    {
                        for (int i = 0; i < a.Length - 1; i++)
                        {
                            valor_a = valor_a + a[i].ToString();
                        }
                        for (int i = 0; i < b.Length - 1; i++)
                        {
                            valor_b = valor_b + b[i].ToString();
                        }

                        resultado = Math.Pow((int.Parse(valor_a) - int.Parse(valor_b)), 2).ToString() + a[a.Length - 1] + "^2";
                    }
                    else
                    {
                        for (int i = 0; i < a.Length - 1; i++)
                        {
                            valor_a = valor_a + a[i].ToString();
                        }
                        for (int i = 0; i < b.Length - 1; i++)
                        {
                            valor_b = valor_b + b[i].ToString();
                        }

                        resultado = Math.Pow(int.Parse(valor_a), 2).ToString() + a[a.Length - 1] + "^2 - " +
                            (2 * int.Parse(valor_a) * int.Parse(valor_b)).ToString() + a[a.Length - 1] +
                            b[b.Length - 1] + " + " + Math.Pow(int.Parse(valor_b), 2).ToString() + b[b.Length - 1] + "^2";
                    }
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }

            }
            else
            {
                MessageBox.Show("Error");
            }

            return resultado;
        }

        public string binomioAlCuboPositivo(string a, string b, ref string resultado)
        {
            resultado = "";
            valor_a = "";
            valor_b = "";
            suma = 0;

            esNumero_a = int.TryParse(a, out value_a);
            esNumero_b = int.TryParse(b, out value_b);

            if (esNumero_a && !esNumero_b)
            {
                if (b.Length == 1)
                {
                    resultado = Math.Pow(value_a, 3).ToString() + " + " 
                        + (3 * Math.Pow(value_a,2)).ToString() + b + " + " 
                        + (3 * value_a).ToString() + b + "^2 +" 
                        + b + "^3";
                }
                else if (b.Length > 1)
                {
                    for (int i = 0; i < b.Length - 1; i++)
                    {
                        valor_b = valor_b + b[i].ToString();
                    }
                    resultado = Math.Pow(value_a, 3).ToString() + " + "
                        + (3 * Math.Pow(value_a, 2) * int.Parse(valor_b)).ToString() + b[b.Length-1] + " + "
                        + (3 * value_a * Math.Pow(int.Parse(valor_b),2)).ToString() + b[b.Length-1] + "^2 +"
                        + Math.Pow(int.Parse(valor_b),3).ToString() + b[b.Length-1] + "^3";
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }
            }
            else if (!esNumero_a && esNumero_b)
            {
                if (a.Length == 1)
                {
                    resultado = a + "^3 +"
                        + (3 * value_b).ToString() + a + "^2 + "
                        + (3 * Math.Pow(value_b, 2)).ToString() + a + " + "
                        + Math.Pow(value_b,3);
                }
                else if (a.Length > 1)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        valor_a = valor_a + a[i].ToString();
                    }
                    
                    resultado = Math.Pow(int.Parse(valor_a), 3).ToString() + a[a.Length - 1] + "^3 + "
                        + (3 * Math.Pow(int.Parse(valor_a), 2) * value_b).ToString() + a[a.Length - 1] + "^2 + "
                        + (3 * int.Parse(valor_a) * Math.Pow(value_b, 2)).ToString() + a[a.Length - 1] + " + "
                        + Math.Pow(value_b, 3);
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }
            }
            else if (esNumero_a && esNumero_b)
            {
                resultado = Math.Pow(value_a, 3).ToString() + " + "
                        + (3 * Math.Pow(value_a, 2) * value_b).ToString() + " + "
                        + (3 * value_a * Math.Pow(value_b, 2)).ToString() + " + "
                        + Math.Pow(value_b, 3).ToString();
                suma = Math.Pow(value_a, 3) 
                    + (3 * Math.Pow(value_a, 2) * value_b) 
                    + (3 * value_a * Math.Pow(value_b,2)) 
                    + Math.Pow(value_b, 3);

                resultado = resultado + " = " + suma.ToString();
            }
            else if (!esNumero_a && !esNumero_b)
            {
                if (a.Length == 1 && b.Length == 1)
                {
                    resultado = a + "^3 + 3" + a + "^2" + b + " + 3" + a + b + "^2 + " + b + "^3"; 
                }
                else if (a.Length > 1 && b.Length == 1)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        valor_a = valor_a + a[i].ToString();
                    }

                    resultado = Math.Pow(int.Parse(valor_a), 3).ToString() + a[a.Length - 1] + "^3 + "
                        + (3 * Math.Pow(int.Parse(valor_a), 2)).ToString() + a[a.Length - 1] + "^2" + b + " + "
                        + (3 * int.Parse(valor_a)).ToString() + a[a.Length - 1] + b + "^2 +"
                        + b + "^3";
                }
                else if (a.Length == 1 && b.Length > 1)
                {
                    for (int i = 0; i < b.Length - 1; i++)
                    {
                        valor_b = valor_b + b[i].ToString();
                    }
                    valor_b_entero = int.Parse(valor_b);

                    resultado = a + "^3 + "
                        + (3 * valor_b_entero).ToString() + a + "^2" + b[b.Length - 1] + " + "
                        + (3 * Math.Pow(valor_b_entero, 2)).ToString() + a + b[b.Length - 1] + "^2 +"
                        + Math.Pow(valor_b_entero, 3) + b[b.Length-1] + "^3";
                }
                else if (a.Length > 1 && b.Length > 1)
                {
                    if (a[a.Length - 1] == b[b.Length - 1])
                    {
                        for (int i = 0; i < a.Length - 1; i++)
                        {
                            valor_a = valor_a + a[i].ToString();
                        }
                        for (int i = 0; i < b.Length - 1; i++)
                        {
                            valor_b = valor_b + b[i].ToString();
                        }

                        resultado = Math.Pow((int.Parse(valor_a) + int.Parse(valor_b)), 3).ToString() + a[a.Length - 1] + "^3";
                    }
                    else
                    {
                        for (int i = 0; i < a.Length - 1; i++)
                        {
                            valor_a = valor_a + a[i].ToString();
                        }
                        for (int i = 0; i < b.Length - 1; i++)
                        {
                            valor_b = valor_b + b[i].ToString();
                        }
                        valor_a_entero = int.Parse(valor_a);
                        valor_b_entero = int.Parse(valor_b);

                        resultado = Math.Pow(valor_a_entero, 3).ToString() + a[a.Length - 1] + "^3 + "
                            + (3 * Math.Pow(valor_a_entero, 2) * valor_b_entero).ToString() + a[a.Length - 1] + "^2" + b[b.Length - 1] + " + "
                            + (3 * valor_a_entero * Math.Pow(valor_b_entero, 2)).ToString() + a[a.Length - 1] + b[b.Length - 1] + "^2 + "
                            + Math.Pow(valor_b_entero, 3).ToString() + b[b.Length - 1] + "^3";
                    }
                    
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }

            }
            else
            {
                MessageBox.Show("Error");
            }

            return resultado;
        }

        public string binomioAlCuboNegativo(string a, string b, ref string resultado)
        {
            resultado = "";
            valor_a = "";
            valor_b = "";
            suma = 0;

            esNumero_a = int.TryParse(a, out value_a);
            esNumero_b = int.TryParse(b, out value_b);

            if (esNumero_a && !esNumero_b)
            {
                if (b.Length == 1)
                {
                    resultado = Math.Pow(value_a, 3).ToString() + " - "
                        + (3 * Math.Pow(value_a, 2)).ToString() + b + " + "
                        + (3 * value_a).ToString() + b + "^2 -"
                        + b + "^3";
                }
                else if (b.Length > 1)
                {
                    for (int i = 0; i < b.Length - 1; i++)
                    {
                        valor_b = valor_b + b[i].ToString();
                    }
                    resultado = Math.Pow(value_a, 3).ToString() + " - "
                        + (3 * Math.Pow(value_a, 2) * int.Parse(valor_b)).ToString() + b[b.Length - 1] + " + "
                        + (3 * value_a * Math.Pow(int.Parse(valor_b), 2)).ToString() + b[b.Length - 1] + "^2 -"
                        + Math.Pow(int.Parse(valor_b), 3).ToString() + b[b.Length - 1] + "^3";
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }
            }
            else if (!esNumero_a && esNumero_b)
            {
                if (a.Length == 1)
                {
                    resultado = a + "^3 -"
                        + (3 * value_b).ToString() + a + "^2 + "
                        + (3 * Math.Pow(value_b, 2)).ToString() + a + " - "
                        + Math.Pow(value_b, 3);
                }
                else if (a.Length > 1)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        valor_a = valor_a + a[i].ToString();
                    }

                    resultado = Math.Pow(int.Parse(valor_a), 3).ToString() + a[a.Length - 1] + "^3 - "
                        + (3 * Math.Pow(int.Parse(valor_a), 2) * value_b).ToString() + a[a.Length - 1] + "^2 + "
                        + (3 * int.Parse(valor_a) * Math.Pow(value_b, 2)).ToString() + a[a.Length - 1] + " - "
                        + Math.Pow(value_b, 3);
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }
            }
            else if (esNumero_a && esNumero_b)
            {
                resultado = Math.Pow(value_a, 3).ToString() + " - "
                        + (3 * Math.Pow(value_a, 2) * value_b).ToString() + " + "
                        + (3 * value_a * Math.Pow(value_b, 2)).ToString() + " - "
                        + Math.Pow(value_b, 3).ToString();
                suma = Math.Pow(value_a, 3)
                    - (3 * Math.Pow(value_a, 2) * value_b)
                    + (3 * value_a * Math.Pow(value_b, 2))
                    - Math.Pow(value_b, 3);

                resultado = resultado + " = " + suma.ToString();
            }
            else if (!esNumero_a && !esNumero_b)
            {
                if (a.Length == 1 && b.Length == 1)
                {
                    resultado = a + "^3 - 3" + a + "^2" + b + " + 3" + a + b + "^2 - " + b + "^3";
                }
                else if (a.Length > 1 && b.Length == 1)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        valor_a = valor_a + a[i].ToString();
                    }

                    resultado = Math.Pow(int.Parse(valor_a), 3).ToString() + a[a.Length - 1] + "^3 - "
                        + (3 * Math.Pow(int.Parse(valor_a), 2)).ToString() + a[a.Length - 1] + "^2" + b + " + "
                        + (3 * int.Parse(valor_a)).ToString() + a[a.Length - 1] + b + "^2 -"
                        + b + "^3";
                }
                else if (a.Length == 1 && b.Length > 1)
                {
                    for (int i = 0; i < b.Length - 1; i++)
                    {
                        valor_b = valor_b + b[i].ToString();
                    }
                    valor_b_entero = int.Parse(valor_b);

                    resultado = a + "^3 - "
                        + (3 * valor_b_entero).ToString() + a + "^2" + b[b.Length - 1] + " + "
                        + (3 * Math.Pow(valor_b_entero, 2)).ToString() + a + b[b.Length - 1] + "^2 -"
                        + Math.Pow(valor_b_entero, 3) + b[b.Length - 1] + "^3";
                }
                else if (a.Length > 1 && b.Length > 1)
                {
                    if (a[a.Length - 1] == b[b.Length - 1])
                    {
                        for (int i = 0; i < a.Length - 1; i++)
                        {
                            valor_a = valor_a + a[i].ToString();
                        }
                        for (int i = 0; i < b.Length - 1; i++)
                        {
                            valor_b = valor_b + b[i].ToString();
                        }

                        resultado = Math.Pow((int.Parse(valor_a) - int.Parse(valor_b)), 3).ToString() + a[a.Length - 1] + "^3";
                    }
                    else
                    {
                        for (int i = 0; i < a.Length - 1; i++)
                        {
                            valor_a = valor_a + a[i].ToString();
                        }
                        for (int i = 0; i < b.Length - 1; i++)
                        {
                            valor_b = valor_b + b[i].ToString();
                        }
                        valor_a_entero = int.Parse(valor_a);
                        valor_b_entero = int.Parse(valor_b);

                        resultado = Math.Pow(valor_a_entero, 3).ToString() + a[a.Length - 1] + "^3 - "
                            + (3 * Math.Pow(valor_a_entero, 2) * valor_b_entero).ToString() + a[a.Length - 1] + "^2" + b[b.Length - 1] + " + "
                            + (3 * valor_a_entero * Math.Pow(valor_b_entero, 2)).ToString() + a[a.Length - 1] + b[b.Length - 1] + "^2 - "
                            + Math.Pow(valor_b_entero, 3).ToString() + b[b.Length - 1] + "^3";
                    }
                    
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }

            }
            else
            {
                MessageBox.Show("Error");
            }

            return resultado;
        }

        public string diferenciaCuadrados(string a, string b, ref string resultado)
        {
            resultado = "";
            valor_a = "";
            valor_b = "";
            suma = 0;

            esNumero_a = int.TryParse(a, out value_a);
            esNumero_b = int.TryParse(b, out value_b);

            if (esNumero_a && !esNumero_b)
            {
                if (b.Length == 1)
                {
                    resultado = "(" + a + " + " + b + ")" + "(" + a + " - " + b + ")";
                }
                else if (b.Length > 1)
                {
                    for (int i = 0; i < b.Length - 1; i++)
                    {
                        valor_b = valor_b + b[i].ToString();
                    }
                    double raiz_b = Math.Sqrt(double.Parse(valor_b));
                    resultado = "(" + a + " + " + raiz_b + b[b.Length-1] +")" + "(" + a + " - " + raiz_b + b[b.Length - 1] + ")";
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }
            }
            else if (!esNumero_a && esNumero_b)
            {
                if (a.Length == 1)
                {
                    resultado = "(" + a + " + " + b + ")" + "(" + a + " - " + b + ")";
                }
                else if (a.Length > 1)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        valor_a = valor_a + a[i].ToString();
                    }

                    resultado = "(" + Math.Sqrt(double.Parse(valor_a)) + a[a.Length - 1] + " + " + b + ")("
                        + Math.Sqrt(double.Parse(valor_a)) + a[a.Length - 1] + " - " + b + ")";
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }
            }
            else if (esNumero_a && esNumero_b)
            {
                suma = Math.Pow(value_a, 2) - Math.Pow(value_b, 2);
                resultado = "(" + a + "^2 - " + b + "^2)" + " = " + suma.ToString();
            }
            else if (!esNumero_a && !esNumero_b)
            {/*
                if (a.Length == 1 && b.Length == 1)
                {
                    resultado = a + "^3 - 3" + a + "^2" + b + " + 3" + a + b + "^2 - " + b + "^3";
                }
                else if (a.Length > 1 && b.Length == 1)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        valor_a = valor_a + a[i].ToString();
                    }

                    resultado = Math.Pow(int.Parse(valor_a), 3).ToString() + a[a.Length - 1] + "^3 - "
                        + (3 * Math.Pow(int.Parse(valor_a), 2)).ToString() + a[a.Length - 1] + "^2" + b + " + "
                        + (3 * int.Parse(valor_a)).ToString() + a[a.Length - 1] + b + "^2 -"
                        + b + "^3";
                }
                else if (a.Length == 1 && b.Length > 1)
                {
                    for (int i = 0; i < b.Length - 1; i++)
                    {
                        valor_b = valor_b + b[i].ToString();
                    }
                    valor_b_entero = int.Parse(valor_b);

                    resultado = a + "^3 - "
                        + (3 * valor_b_entero).ToString() + a + "^2" + b[b.Length - 1] + " + "
                        + (3 * Math.Pow(valor_b_entero, 2)).ToString() + a + b[b.Length - 1] + "^2 -"
                        + Math.Pow(valor_b_entero, 3) + b[b.Length - 1] + "^3";
                }
                else if (a.Length > 1 && b.Length > 1)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        valor_a = valor_a + a[i].ToString();
                    }
                    for (int i = 0; i < b.Length - 1; i++)
                    {
                        valor_b = valor_b + b[i].ToString();
                    }
                    valor_a_entero = int.Parse(valor_a);
                    valor_b_entero = int.Parse(valor_b);

                    resultado = Math.Pow(valor_a_entero, 3).ToString() + a[a.Length - 1] + "^3 - "
                        + (3 * Math.Pow(valor_a_entero, 2) * valor_b_entero).ToString() + a[a.Length - 1] + "^2" + b[b.Length - 1] + " + "
                        + (3 * valor_a_entero * Math.Pow(valor_b_entero, 2)).ToString() + a[a.Length - 1] + b[b.Length - 1] + "^2 - "
                        + Math.Pow(valor_b_entero, 3).ToString() + b[b.Length - 1] + "^3";
                }
                else
                {
                    MessageBox.Show("¡Uy!, Algo salio mal, revisa que las entradas sean las correctas :) ");
                }
                */
            }
            else
            {
                MessageBox.Show("Error");
            }

            return resultado;
        }
    }

    
}
