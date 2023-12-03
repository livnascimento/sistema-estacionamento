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
        Console.WriteLine("4- Encerrar o programa.");

        opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Insira a placa do veículo a ser adicionado.");
                veiculo = Console.ReadLine();
                estacionamento.AdicionarVeiculo(veiculo);
                Console.WriteLine("Veículo adicionado.");
                Thread.Sleep(3000);
                Menu();
                break;
            case "2":
                Console.WriteLine("Insira a placa do veículo a ser removido.");
                veiculo = Console.ReadLine();
                Console.WriteLine("Quantas horas o veículo permaneceu no estacionamento?");
                int horas = int.Parse(Console.ReadLine());
                double total = estacionamento.CalcularTotal(horas);
                estacionamento.RemoverVeiculo(veiculo);
                Console.WriteLine($"Veículo removido, o total a pagar é de: {total:C}");
                Thread.Sleep(3000);
                Menu();
                break;
            case "3":
                Console.WriteLine("------- Veículos -------");
                estacionamento.ListarVeiculos();
                Thread.Sleep(3000);
                Menu();
                break;
            case "4":
                System.Environment.Exit(1);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

}

