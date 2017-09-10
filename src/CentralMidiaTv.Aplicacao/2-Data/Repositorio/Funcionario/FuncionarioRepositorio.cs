using CentralMidiaTv.Dominio.Funcionario.Repositorio;
using CentralMidiaTv.Dominio.Funcionario.ViewModel;
using Dapper;
using System.Data.SqlClient;
using System.Linq;

namespace CentralMidiaTv.Aplicacao._2_Data.Repositorio.Funcionario
{
    public class FuncionarioRepositorio : BaseRepositorio<Dominio.Funcionario.Entidade.Funcionario>, IFuncionarioRepositorio
    {
        public FuncionarioRepositorio(GerenciadorContexto gerenciadorContexto) : base(gerenciadorContexto)
        {
        }

        public BasicoFuncionario Logar(string usuario, string senha)
        {
            var query = @"Select IdFuncionario,Nome,Sobrenome from Funcionario
                        where Usuario = @usuario and Senha = @senha";

            using (var sqlConnection = new SqlConnection(Db.Database.Connection.ConnectionString))
            {
                var funcionario = sqlConnection.Query<BasicoFuncionario>(query, new { usuario = usuario, senha = senha });
                return funcionario.FirstOrDefault();
            }
        }
    }
}