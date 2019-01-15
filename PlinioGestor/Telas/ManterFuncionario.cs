using Biblioteca.Arquivo;
using Biblioteca.Model;
using PlinioGestor.Conversores;
using System;

namespace PlinioGestor.Telas
{
    class ManterFuncionario
    {
        public void CadastrarFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            Console.Clear();

            Console.WriteLine("--- CADASTRAR FUNCIONÁRIO ---");

            Console.WriteLine("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Data de Nascimento: ");
            funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Telefone: ");
            funcionario.Telefone = Console.ReadLine();

            Console.WriteLine("CPF: ");
            funcionario.CPF = Console.ReadLine();

            Console.WriteLine("RG: ");
            funcionario.RG = Console.ReadLine();

            Console.WriteLine("CEP: ");
            funcionario.CEP = int.Parse(Console.ReadLine());

            Console.WriteLine("Estado: ");
            funcionario.Estado = Console.ReadLine();

            Console.WriteLine("Cidade: ");
            funcionario.Cidade = Console.ReadLine();

            Console.WriteLine("Endereço: ");
            funcionario.Endereco = Console.ReadLine();

            Console.WriteLine("Cargo: ");
            funcionario.Cargo = Console.ReadLine();

            Console.WriteLine("Salário: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Data Contratação: ");
            funcionario.DataContratacao = DateTime.Parse(Console.ReadLine());


            GerenciadorArquivo.GravarArquivo("funcionario", FuncionarioTexto.ConverterParaTexto(funcionario));
        }

        public void ListarFuncionarios()
        {
            Console.Clear();

            Console.WriteLine("-- LISTAGEM DE FUNCIONÁRIOS --");

            string[] linhas = GerenciadorArquivo.LerArquivo("funcionario");

            foreach (string linha in linhas)
            {
                Funcionario funcionario = Conversores.FuncionarioTexto.ConverterParaFuncionario(linha);

                Console.WriteLine("NOME: " + funcionario.Nome + "/nCARGO: " + funcionario.Cargo);
            }
        }
    }
}
