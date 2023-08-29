using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using NCalc;
using System.Linq.Expressions;

namespace Planta
{
    public class CE
    {
        public void MainnCE()
        {
            string function_str = Console.ReadLine();
            NCalc.Expression evaluator = new NCalc.Expression(function_str);
            try
            {
                int inicio = -10;
                int outicio = 10;
                Console.WriteLine("Valores [-10,10]");
                for (int x = -10; x <= 10; x++)
                {
                    string expression = function_str.Replace("x", x.ToString());
                    NCalc.Expression resuelto = new  NCalc.Expression(expression);
                    NCalc.Expression resultado = new  NCalc.Expression(resuelto.ToString());
                    object var1 = resultado.Evaluate();

                    Console.WriteLine("f(ex3)=" + var1);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("problema");
            }
        }

    }

    
}
