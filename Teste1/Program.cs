using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
using System.Linq;

class ReadFromFile
{
    static void Main()
    {
        // Os arquivos usados neste exemplo são criados no tópico
        // Como: Gravar em um arquivo de texto. Você pode alterar o caminho e
        // Arquivo para substituir arquivos de texto do seu próprio.

        // Example #2
        // Leia cada linha do arquivo em uma matriz de seqüência de caracteres. Cada elemento
        //Da matriz é uma linha do arquivo.
        string[] lines = File.ReadAllLines(@"E:\Desktop\CTI\Sala de provas\BTI1MA.TXT");


        // Exibir o conteúdo do arquivo usando um loop foreach.
        foreach (string line in lines)
        {
            // Use uma guia para recuar cada linha do arquivo.
            //Console.WriteLine("\t" + line);
            string espaco = line.Replace("	", "");
            
            var aux = Regex.Match(espaco.Substring(0, 10), @"\d+");
            var qtd = aux.Length;
            try
            {
                //Abrir o arquivo
                StreamWriter valor = new StreamWriter("E:\\Desktop\\CTI\\Sala de provas\\BTI1MAB.TXT", true, Encoding.ASCII);
                switch (qtd)
                {
                    case 4:
                        Console.WriteLine("000000" + espaco.Substring(0, 1) + espaco.Substring(1, 93));
                        valor.WriteLine("000000" + espaco.Substring(0, 1) + espaco.Substring(1, 93));
                       // string correctString = errString.Replace("docment", "document");
                        break;
                    case 5:
                        Console.WriteLine("00000" + espaco.Substring(0, 2) + espaco.Substring(2, 93));
                        valor.WriteLine("00000" + espaco.Substring(0, 2) + espaco.Substring(2, 93));
                        break;
                    case 6:
                        Console.WriteLine("0000" + espaco.Substring(0, 3) + espaco.Substring(3, 93));
                        valor.WriteLine("0000" + espaco.Substring(0, 3) + espaco.Substring(3, 93));
                        break;
                    case 7:
                        Console.WriteLine("000" + espaco.Substring(0, 4) + espaco.Substring(4, 93));
                        valor.WriteLine("000" + espaco.Substring(0, 4) + espaco.Substring(4, 93));
                        break;
                    case 8:
                        Console.WriteLine("00" + espaco.Substring(0, 5) + espaco.Substring(5, 93));
                        valor.WriteLine("00" + espaco.Substring(0, 5) + espaco.Substring(5, 93));
                        break;
                    case 9:
                        Console.WriteLine("0" + espaco.Substring(0, 6) + espaco.Substring(6, 93));
                        valor.WriteLine("0" + espaco.Substring(0, 6) + espaco.Substring(6, 93));
                        break;
                    default:
                        Console.WriteLine(espaco.Substring(0, 7) + espaco.Substring(7, 93));
                        valor.WriteLine(espaco.Substring(0, 7) + espaco.Substring(7, 93));
                        break;
                }
                //Fecha o arquivo
                valor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }

        Console.ReadKey();
    }
}