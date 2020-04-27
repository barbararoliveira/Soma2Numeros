using System;

namespace soma2numeross
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Olá usuário, vou ajudá-lo a somar."); 
          Console.WriteLine("Pressione enter para continuar.");

          Console.ReadKey ();

          Console.WriteLine("Digite um número inteiro."); 
          int valor1 = Int32.Parse (Console.ReadLine ()); 

          Console.WriteLine("Digite outro número inteiro");
          int valor2 = Int32.Parse (Console.ReadLine ());

          int resultadodasoma = valor1 + valor2; 
          Console.WriteLine ("Resultado da soma:" + resultadodasoma);
          
          Console.ReadKey ();
        }
    }
}
