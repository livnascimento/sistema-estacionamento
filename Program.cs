using System;
using sistema_estacionamento.Models;

internal class Program
{
    private static Estacionamento estacionamento = new()
    {
        Veiculos = []
    };
    private static void Main(string[] args)
    {   
        Console.WriteLine("Qual é o valor cobrado para estacionar?");
        estacionamento.ValorInicial = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Qual é o valor cobrado por hora?");
        estacionamento.ValorHora = double.Parse(Console.ReadLine());

        Menu();
    }

    private static void Menu () 
    {
        string opcao, veiculo;

        Console.WriteLine("-------------------- Menu --------------------");
        Console.WriteLine("------- Digite o número correspondente -------\n");
        Console.WriteLine("1- Adicionar Carro.");
        Console.WriteLine("2- Remover Carro.");
        Console.WriteLine("3- Listar Carros.");
        Console.WriteLine("4- Fechar caixa.");

        opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("Insira a placa do veículo a ser adicionado.");
                veiculo = Console.ReadLine();
                estacionamento.AdicionarVeiculo(veiculo);
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("Insira a placa do veículo a ser removido.");
                veiculo = Console.ReadLine();
                Console.WriteLine("Quantas horas o veículo permaneceu no estacionamento?");
                int horas = int.Parse(Console.ReadLine());
                estacionamento.RemoverVeiculo(veiculo, horas);
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case "3":
                Console.Clear();
                Console.WriteLine("------- Veículos -------");
                estacionamento.ListarVeiculos();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case "4":
                estacionamento.FecharCaixa();
                Console.Clear();
                Menu();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
        }
    }

}

