using System.IO;

namespace E_Jogos.Models
{
    public class EJogosBase
    {
        // Adicionar uma função para criar a pasta e o arquivo.

        //String "path" é o parâmetro da função que armazena o caminho para análise
        public void CreateFolderAndFile(string path)
        {
            // pasta / arquivo.csv
            string folder = path.Split('/')[0]; // armazena em folder o nome da pasta
            string file = path.Split('/')[1]; // armazena em file o nome do arquivo

            // Se não existir, cria a pasta
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            // Se não existir, cria o arquivo
            if (!Directory.Exists(file))
            {
                File.Create(path);
            }
            
        }


    }
}
