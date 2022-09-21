using DesafioFundamentos.Models;
using System;
using System.Text.RegularExpressions;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string precoInicial2 = "";
string precoPorHora2 = "";
bool validacao = true;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
                  
precoInicial2 = (Console.ReadLine());

while (validacao)
{
    Console.Clear();
    if (Regex.IsMatch(precoInicial2, @"^[0-9]+$"))
    {

        decimal precoInicial = Convert.ToDecimal(precoInicial2);

        Console.WriteLine("Agora digite o preço por hora:");

        precoPorHora2 = (Console.ReadLine());

        while (validacao)
        {
            Console.Clear();
            if (Regex.IsMatch(precoPorHora2, @"^[0-9]+$"))
            {

                decimal precoPorHora = Convert.ToDecimal(precoPorHora2);
                
                Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

                string opcao = string.Empty;
                bool exibirMenu = true;

                while (exibirMenu)
                {
                    Console.Clear();
                    Console.WriteLine("Digite a sua opção:");
                    Console.WriteLine("1 - Cadastrar veículo");
                    Console.WriteLine("2 - Remover veículo");
                    Console.WriteLine("3 - Listar veículos");
                    Console.WriteLine("4 - Encerrar");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            es.AdicionarVeiculo();
                            break;

                        case "2":
                            es.RemoverVeiculo();
                            break;

                        case "3":
                            es.ListarVeiculos();
                            break;

                        case "4":
                            exibirMenu = false;
                            validacao = false;
                            break;

                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }

                    Console.WriteLine("Pressione uma tecla para continuar");
                    Console.ReadLine();
                }

                Console.WriteLine("O programa se encerrou");
            }
            else
            {
                Console.WriteLine("Preço inválido, digite um novo preço por hora.");
                precoPorHora2 = (Console.ReadLine());

            }
        }
    }
    else
    {
        Console.WriteLine("Preço incorreto, digite um novo preço inicial.");
        precoInicial2 = (Console.ReadLine());
    }
}