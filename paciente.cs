using System;
using System.Diagnostics.Contracts;
using Microsoft.VisualBasic;

namespace desafio1;

public class Paciente()
{
    public string? nomePaciente;
    public int idadePaciente;
    public string? idadePacienteString;
    public int nivelDor;
    //listas
    List<string> listavermelha = new List<string>();
        List<string> listaverde = new List<string>();
            List<string> listaamrela = new List<string>();
                List<string> listaPacientes = new List<string>();

    //metodos (ações que pertencem a minha classe)
    //adicionar paciente
    public void AdicionarPaciente()
    {
       Console.WriteLine("Digite o nome do paciente: ");
       nomePaciente = Console.ReadLine() ?? "";
       Console.WriteLine("Digite a idade do paciente: ");
       idadePacienteString = Console.ReadLine();
       if(int.TryParse(idadePacienteString, out idadePaciente)){
            Console.WriteLine("digite o nivel de dor do paciente: ");
            if(int.TryParse(Console.ReadLine(), out nivelDor))
            {
                ClassificarPrioridade(nomePaciente, idadePaciente, nivelDor);
            }      
            else
            {
                Console.WriteLine("Dor nao identificada. digite um numero");
            }
        }   
        else
        {
            Console.WriteLine("A idade não é um numero.");
        }
    }


    public void ClassificarPrioridade(string nomePaciente, int idadePaciente, int nivelDor)
    {
        if (nivelDor >= 9 || idadePaciente >= 80)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Prioriade Alta - Pulseira Vermelha");
                listavermelha.Add(nomePaciente);
                Console.ResetColor();
            }
            else if (nivelDor >= 5 && nivelDor <= 8)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Prioriade media - Pulseira Amarela");
                listaamrela.Add(nomePaciente);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Prioriade media - Pulseira Verde");
                listaverde.Add(nomePaciente);
                Console.ResetColor();
            }
    }

    public void ListarPaciente()

    {
        int contadoramarelo = 0;
        int Contadorverde = 0;
        listaPacientes = new List<string>();
        foreach (var nome in listavermelha){
            listaPacientes.Add(nome);
        }
        while (contadoramarelo<listaamrela.Count() || Contadorverde < listaverde.Count())
        {
            int i=0;
            while(contadoramarelo<listaamrela.Count() && i < 2)
            {
                listaPacientes.Add(listaverde[Contadorverde]);
                Contadorverde++;
            }
        }
    }

    public void ChamarProximo()
    {
        ListarPaciente();
        Console.WriteLine($" {listaPacientes[0]} Dirigi-se ao Consultorio");
        ExcluirPaciente();
    }
    public void ExcluirPaciente()
    {
        if(listavermelha.Contains(listaPacientes[0]))
        {
        listavermelha.RemoveAt(0);
        }
        else if (listaamrela.Contains(listaPacientes[0]))
        {
            listaamrela.RemoveAt(0);
        }
        else
        {
            listaverde.RemoveAt(0);
        }
        listaPacientes.RemoveAt(0);
    }

public void verificarListaAtendimento()

    {
        ListarPaciente();
        int i=1;
        foreach (var nome in listaPacientes)
        {
            Console.WriteLine($"{1} - {nome}");
            i++;
        }
    }
}