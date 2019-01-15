using Biblioteca.Arquivo;
using Biblioteca.Model;
using PlinioGestor.Conversores;
using System;

namespace PlinioGestor.Telas
{
    class ManterCliente
    {
        public void CadastrarCliente()
        {
            Cliente cliente = new Cliente();

            Console.Clear();

            Console.WriteLine("--- CADASTRAR CLIENTE ---");

            Console.WriteLine("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Data de Nascimento: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.WriteLine("CPF: ");
            cliente.CPF = Console.ReadLine();

            Console.WriteLine("RG: ");
            cliente.RG = Console.ReadLine();

            Console.WriteLine("CEP: ");
            cliente.CEP = int.Parse(Console.ReadLine());

            Console.WriteLine("Estado: ");
            cliente.Estado = Console.ReadLine();

            Console.WriteLine("Cidade: ");
            cliente.Cidade = Console.ReadLine();

            Console.WriteLine("Endereço: ");
            cliente.Endereco = Console.ReadLine();


            GerenciadorArquivo.GravarArquivo("cliente", ClienteTexto.ConverterParaTexto(cliente));
        }

        public void ListarClientes()
        {
            Console.Clear();

            Console.WriteLine("-- LISTAGEM DE CLIENTES --");

            string[] linhas = GerenciadorArquivo.LerArquivo("cliente");

            foreach (string linha in linhas)
            {
                Cliente cliente = Conversores.ClienteTexto.ConverterParaCliente(linha);

                Console.WriteLine("NOME: " + cliente.Nome);
            }
        }
    }
}
