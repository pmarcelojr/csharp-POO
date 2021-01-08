using System;
using System.IO;

namespace _13a_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando a instrução using os recursos são liberados após a conclusão da operação
            
            // 1: Acessa o arquivo e ler uma linha do arquivo texto usando o metodo ReadLine().
            //string linha;
            //using (StreamReader sr = new StreamReader(@"C:\temp\macoratti.txt"))
            //{
            //    linha = sr.ReadLine();
            //}
            //Console.WriteLine(linha);
            ///////////////////////////////////////////////////////////////////////////////////
            // É uma boa pratica verificar se o arquivo a ser lido existe ou se encontra no local indicado.
            // 2: Para ler mais linhas use o while e percorrer o arquivo enquanto não for encontrado um caracter null
            string arquivo = @"C:\temp\macoratti.txt";
            if (File.Exists(arquivo))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(arquivo))
                    {
                        string linha;
                        // Lê linha por linha até o final do arquivo
                        while ((linha = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(linha);
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine($"O arquivo {arquivo} não foi localizado !");
            }

        }
    }
}
