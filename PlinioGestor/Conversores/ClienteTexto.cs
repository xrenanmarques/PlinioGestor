using Biblioteca.Model;
using System;

namespace PlinioGestor.Conversores
{
    class ClienteTexto
    {
        public static string ConverterParaTexto(Cliente cliente)
        {
            return $"{cliente.Nome}, {cliente.DataNascimento}, {cliente.Telefone}, {cliente.CPF}, {cliente.RG}," +
                $"{cliente.CEP}, {cliente.Estado}, {cliente.Cidade}, {cliente.Endereco}";
        }

        public static Cliente ConverterParaCliente(String Linha)
        {
            string[] elementos = Linha.Split(',');

            Cliente cliente = new Cliente();

            cliente.Nome = elementos[0];
            cliente.DataNascimento = DateTime.Parse(elementos[1]);
            cliente.Telefone = elementos[2];
            cliente.CPF = elementos[3];
            cliente.RG = elementos[4];
            cliente.CEP = int.Parse(elementos[5]);
            cliente.Estado = elementos[6];
            cliente.Cidade = elementos[7];
            cliente.Endereco = elementos[8];

            return cliente;
        }
    }
}
