using E_Jogos.Models;
using System.Collections.Generic;

namespace E_Jogos.Interface
{
    /// <summary>
    /// RESPONSÁVEL POR DETERMINAR QUAIS MÉTODOS UMA CLASSE TERÁ.
    /// É O CONTRATO DA CLASSE.
    /// </summary>
    public interface IEquipe
    {
        //CREATE
        void Create(Equipe nova_equipe);

        //READALL
        List<Equipe> ReadAll();

        //UPDATE
        void Update(Equipe equipe);

        //DELETE
        void Delete(int idEquipe);
    }
}
