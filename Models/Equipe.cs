using E_Jogos.Interface;
using System.Collections.Generic;
using System.IO;

namespace E_Jogos.Models
{
    //Classe Equipe herdando de EjogosBase
    public class Equipe : EJogosBase,IEquipe
    {
        // Construtor CTOR TAB TAB
        // FUNÇÃO QUE EXECUTAR/INICIAR ASSIM QUE A CLASSE FOR INSTANCIADA

        private const string path = "Database/equipe.csv";
        public Equipe()
        {
            CreateFolderAndFile(path);
        }

        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        // FUNÇÃO QUE VAI PREPARAR CONVERTER DE STRING PARA O TIPO EQUIPE
        private string Prepare(Equipe e)
        {
            return $"{e.IdEquipe};{e.Nome};{e.Imagem}";
        }
        
        public void Create(Equipe nova_equipe)
        {
            // Receber um objeto de Equipe e gravar no .csv
           
            string[] linha = {Prepare(nova_equipe)};
            File.AppendAllLines(path, linha);
            
        }

        public void Delete(int idEquipe)
        {
            throw new System.NotImplementedException();
        }

        public List<Equipe> ReadAll()
        {
            List<Equipe> equipes = new List<Equipe>();
            string[] linhas = File.ReadAllLines(path);
            foreach (string item in linhas)
            {
                Equipe equipe = new Equipe();
                equipe.IdEquipe = int.Parse(item.Split(';')[0]);
                equipe.Nome = (item.Split(';')[0]);
                equipe.Imagem = (item.Split(';')[0]);

                equipes.Add(equipe);
            }
            return equipes;
        }

        public void Update(Equipe equipe)
        {
            throw new System.NotImplementedException();
        }
    }
}
