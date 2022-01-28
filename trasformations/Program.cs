using System;

namespace trasformations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lower("           Hello World!             "));
            Console.WriteLine(upper("           Hello World!             "));
            Console.WriteLine(trim("           Hello World!             "));
            Console.WriteLine(title("           hello world!             "));
            Console.WriteLine(ltrim("           hello world!             "));
            Console.WriteLine(rtrim("           hello world!             ") + ".");
        }


        static string lower(string texto)
        {
            string lcase = "";
            for (int i = 0; i < texto.Length; i++)
            {
                lcase += texto.Substring(i, 1).ToLower();
            }
            return lcase;
        }

        static string upper(string texto)
        {
            string ucase = "";
            for (int i = 0; i < texto.Length; i++)
            {
                ucase += texto.Substring(i, 1).ToUpper();
            }
            return ucase;
        }


        static string trim(string texto)
        {
            string trimedL = "";
            bool letraEncontrada = false;
            for (int i = 0; i < texto.Length; i++)
            {

                if (texto.Substring(i, 1) != " " && !letraEncontrada)
                {
                    trimedL += texto.Substring(i, 1);
                    letraEncontrada = true;
                }
              
            }
            letraEncontrada = false;
            string trimed = "";
            for (int i = trimedL.Length-1; i >-1; i--)
            {
                if (trimedL.Substring(i, 1) != " " && !letraEncontrada)
                    trimed = trimedL.Substring(i, 1) + trimed;
            }
            return trimed;
        }


        static string title(string texto)
        {
            string tcase = "";
            bool changeCase = true;
            for (int i = 0; i < texto.Length; i++)
            {

                if (changeCase) 
                    tcase += texto.Substring(i, 1).ToLower();
                else
                    tcase += texto.Substring(i, 1).ToUpper();

                if (texto.Substring(i, 1) != " ")
                    changeCase = true;
                else
                    changeCase = false;

                
            }
            return tcase;
        }

        static string ltrim(string texto)
        {
            string trimedL = "";
            bool letraEncontrada = false;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto.Substring(i, 1) != " " && !letraEncontrada)
                    trimedL += texto.Substring(i, 1);
            }
            return trimedL;
        }

        static string rtrim(string texto)
        {
            string trimedR = "";
            bool letraEncontrada = false;
          
   
            for (int i = texto.Length - 1; i > -1; i--)
            {
                
                if (texto.Substring(i, 1) != " " )
                    trimedR = texto.Substring(i, 1) + trimedR;
                 
            }
            return trimedR;
        }

    }


}
