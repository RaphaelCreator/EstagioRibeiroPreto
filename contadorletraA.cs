using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Digite uma string: ");
        string input = Console.ReadLine();

        
        int count = ContarLetraA(input);

      
        if (count > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {count} vez(es) na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não aparece na string.");
        }
    }

 
    static int ContarLetraA(string texto)
    {
        int contar = 0;
        int vezes = 0;

    
        foreach (char c in texto)
        {
          
            if (c == 'a' || c == 'A')
            {
                contar++;
                vezes++;
                Console.WriteLine($"{c} = {vezes}!");
            }
        }
        
        return contar;
    }
}
