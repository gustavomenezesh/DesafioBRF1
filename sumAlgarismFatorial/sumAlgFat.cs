using System;

namespace sumAlgarismFatorial
{
    public class sumAlgFat
    {

        //fatorial de um número
        public static int fat(int n)
        {

            //inicializando a variável com elemento neutro da multiplicação
            int fatorial = 1;

            //multiplicação acumulativa para simular o fatorial
            for (int i = n; i > 0; i--)
            {
                fatorial = i * fatorial;
            }
            return fatorial;
        }

        //somando todos os digitos de um número
        public static int f(int n)
        {

            int sum = 0;

            //verificando se o resultado do fatorial está no intervalo [0,2000]
            if (n >= 0 && n <= 2000)
            {

                //transformando o fatorial em string para trabalhar com os algarismos individualmente
                string numb = n.ToString();

                //somando todos os algarismos
                for (int i = 0; i < numb.Length; i++)
                {
                    sum = sum + int.Parse(numb[i].ToString());
                }
                return sum;

            }
            else
            {
                return -1;
            }

        }

        static void Main(string[] args)
        {

            //número que iré ser feito a soma dos algarismos do seu fatorial
            int n = 3;

            int result = f(fat(n));

            //mostrando o resultado da função
            if (result != -1)
                Console.WriteLine("f(" + n + ") = " + result);
            else
                Console.WriteLine("Fatorial fora do intervalo permitido");
        }
    }
}
