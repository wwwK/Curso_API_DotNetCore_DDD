using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variaveis
            int variavelInteira;
            variavelInteira = 123;

            bool variavelBooleana = false;

            if (variavelBooleana == false){
                variavelInteira = 765;
            }

            var testeInteger = 111;
            var testeBool = true;
            var testeString = "aula";

            // testeString = 222;

            Console.WriteLine("O valor da variavel é {0}", variavelInteira);
            Console.WriteLine("O valor da variavel é {0}", testeInteger);
            Console.WriteLine("O valor da variavel é {0}", testeBool);
            Console.WriteLine("O valor da variavel é {0}", testeString);

            //Operadores Aritméticos => +, -, *, %
            int var1, var2 , total = 0;
            var1 = 10;
            var2 = 55;
            total = var2 % var1;
            Console.WriteLine("Total: {0}", total);

            // Incremento e Decremento
            total++;
            Console.WriteLine("Incremento {0}", total);
            total--;
            Console.WriteLine("Decremento {0}", total);

            /*Operadores lógicos
            And = E = &&
            Or = Ou = ||
            Not = Não = !*/

            bool logico1 = true;
            bool logico2 = true;

            Console.WriteLine(logico1 && logico2);
            Console.WriteLine(logico1 || logico2);

            /*Operadores Relacionais
            == igual a
            != diferente de 
            > maior que 
            < menor que 
            >= maior ou igual que
            <= menor ou igual que */

            var relacionais1 = 10;
            var relacionais2 = 50;
            Console.WriteLine(relacionais1 == relacionais2);
            Console.WriteLine(relacionais1 != relacionais2);
            Console.WriteLine(relacionais1 >= relacionais2);
            Console.WriteLine(relacionais1 < relacionais2);
        }
    }
}
