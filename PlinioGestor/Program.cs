using PlinioGestor.Telas;
using System;

namespace PlinioGestor
{
    class Program
    {
        static void Main(string[] args)
        {
            ManterCliente telaCliente = new ManterCliente();
            ManterFuncionario telaFuncionario = new ManterFuncionario();

            int opcao = 0;

            while (opcao != 5)
            {
                Console.Write("Plínio Gestor\n\n--------------------------------\n\n1 - Cadastrar Cliente\n2 - Listar Cliente\n3 - Cadastrar Funcionário\n4 - Listar Funcionários\n5 - Sair\n\n\n");

                Console.Write("Selecione a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        telaCliente.CadastrarCliente();
                        break;

                    case 2:
                        telaCliente.ListarClientes();
                        break;

                    case 3:
                        telaFuncionario.CadastrarFuncionario();
                        break;

                    case 4:
                        telaFuncionario.ListarFuncionarios();
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Digite uma das opções do menu");
                        break;
                }
            }
        }
    }
}
