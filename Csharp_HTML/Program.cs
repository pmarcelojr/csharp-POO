using System;
using System.IO;

namespace Csharp_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando e Executando um arquivo HTML.\n\n");
            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine();

            // Inicia a Table
            string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 12pt;font-family:arial'>";

            // Incluir o Header
            html += "<tr>";
            html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>Nome</th>";
            html += "</tr>";

            // Adiciona uma linha
            html += "<tr>";
            html += $"<td style='width:120px;border: 1px solid #ccc'>{nome}</td>";
            html += "</tr>";

            // Fecha a table
            html += "</table>";

            // Define o caminho e cria o arquivo HTML
            var caminhoArquivoHTML = @"C:\Users\masp\Documents\LearnNet\Csharp_HTML\html\Console.htm";
            
            File.WriteAllText(caminhoArquivoHTML, html);

            Console.WriteLine("Arquivo HTML arquivo com sucesso...\n");
            Console.WriteLine("Tecle ENTER para abrir o arquivo.");
            Console.ReadLine();

            // Executa o arquivo HTML no navegador padrão
            var pInfo = new System.Diagnostics.ProcessStartInfo();
            pInfo.UseShellExecute = true;
            pInfo.FileName = "Console.htm";
            pInfo.WorkingDirectory = @"C:\Users\masp\Documents\LearnNet\Csharp_HTML\html\"; 
            System.Diagnostics.Process.Start(pInfo);
        }
    }
}
