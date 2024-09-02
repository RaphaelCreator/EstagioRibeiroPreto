using System;

class Program
{
    static void Main()
    {

       
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        Verifica(numero);    
                 
       
        
           
        
    }

   
    static bool Verifica(int numero)
    {
        if (numero == 0 || numero <0)
        {
            Console.WriteLine($"Tal numero digitado ({numero}) não é uma opção válida!") ;
            return false;
            
        }

        int a = 0;
        int b = 1;

       
        while (a <= numero)
        {
            if (a == numero)
            {
                Console.WriteLine($"Tal numero digitado ({numero}) é Fibonacci:");
                return true;
            }

            int temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine($"Tal opção digitada ({numero}) não é Fibonacci:");
        return false;
        
    }
}
