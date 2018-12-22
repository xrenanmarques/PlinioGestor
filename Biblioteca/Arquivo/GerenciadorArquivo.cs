using System.IO;

namespace Biblioteca.Arquivo
{
    public class GerenciadorArquivo
    {
        public static void GravarArquivo(string nome, string texto)
        {
            string diretorio = "C:\\Users\\Renan Marques\\Documents\\Arquivo\\" + nome + ".txt";

            if (File.Exists(diretorio))
            {
                using (StreamWriter wr = File.AppendText(diretorio))
                {
                    wr.WriteLine(texto);
                }
            }
            else
            {
                using (StreamWriter wr = new StreamWriter(diretorio))
                {
                    wr.WriteLine(texto);
                }
            }
        }

        public static string[] LerArquivo(string nome)
        {
            string diretorio = "C:\\Users\\Renan Marques\\Documents\\Arquivo\\" + nome + ".txt";

            return File.ReadAllLines(diretorio);
        }
    }
}
