using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace desafio1;

public class program()
{
    public static void Main()
  
    {
        
        bool continuar = true;



        while(continuar){
            Console.WriteLine("--- Sistema de Triagem HeathConnect ---");


            Console.Write("Digite o nome do paciente: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade do paciente: ");
            int idade = int.Parse(Console.ReadLine());



            Console.Write("Digite o nível de dor (0 a 10): ");
            int niveldeDor = int.Parse(Console.ReadLine());

             
      
            if (niveldeDor >= 9 || idade >= 80)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nPaciente: {nome}");
                Console.WriteLine("Nível de Observação: VERMELHA");
                Console.ResetColor();
            }
            else if (niveldeDor >= 5 && niveldeDor <= 8)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nPaciente: {nome}");
                Console.WriteLine("Nivel de Obvservação: AMARELA");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nPaciente: {nome}");
                Console.WriteLine("Nível de Observação: VERDE");
                Console.ResetColor();
            }
            Console.Write("Deseja verificar outro paciente? (s/n): ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta != "s")
        {
            continuar = false; 
        
            Console.WriteLine("Encerrando o sistema...");
        }
                }
    }
}   

