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
        // Dany não sei

        // Example #2
        // Leia cada linha do arquivo em uma matriz de seqüência de caracteres. Cada elemento
        //Da matriz é uma linha do arquivo.
        string[] lines = File.ReadAllLines(@"E:\Desktop\CTI\Sala de provas\gararitos errados\3º ano C.dat");


        // Exibir o conteúdo do arquivo usando um loop foreach.
        foreach (string line in lines)
        {
            // Use uma guia para recuar cada linha do arquivo.
            //Console.WriteLine("\t" + line);
            
            var aux = Regex.Match(line.Substring(0, 7), @"\d+");
            var qtd = aux.Length;
            try
            {
                //Abrir o arquivo
                StreamWriter valor = new StreamWriter("E:\\Desktop\\CTI\\Sala de provas\\gabaritos transformados\\3º ano C.dat", true, Encoding.ASCII);
                switch (qtd)
                {
                    case 1:
                        Console.WriteLine("000000" + line.Substring(0, 1) + line.Substring(7, 93));
                        valor.WriteLine("000000" + line.Substring(0, 1) + line.Substring(7, 93));
                        break;
                    case 2:
                        Console.WriteLine("00000" + line.Substring(0, 2) + line.Substring(7, 93));
                        valor.WriteLine("00000" + line.Substring(0, 2) + line.Substring(7, 93));
                        break;
                    case 3:
                        Console.WriteLine("0000" + line.Substring(0, 3) + line.Substring(7, 93));
                        valor.WriteLine("0000" + line.Substring(0, 3) + line.Substring(7, 93));
                        break;
                    case 4:
                        Console.WriteLine("000" + line.Substring(0, 4) + line.Substring(7, 93));
                        valor.WriteLine("000" + line.Substring(0, 4) + line.Substring(7, 93));
                        break;
                    case 5:
                        Console.WriteLine("00" + line.Substring(0, 5) + line.Substring(7, 93));
                        valor.WriteLine("00" + line.Substring(0, 5) + line.Substring(7, 93));
                        break;
                    case 6:
                        Console.WriteLine("0" + line.Substring(0, 6) + line.Substring(7, 93));
                        valor.WriteLine("0" + line.Substring(0, 6) + line.Substring(7, 93));
                        break;
                    default:
                        Console.WriteLine(line.Substring(0, 7) + line.Substring(7, 93));
                        valor.WriteLine(line.Substring(0, 7) + line.Substring(7, 93));
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