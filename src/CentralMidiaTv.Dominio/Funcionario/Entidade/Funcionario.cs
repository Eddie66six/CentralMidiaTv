using CentralMidiaTv.Dominio._Comum.Entidade;
using CentralMidiaTv.Dominio.Funcionario.Enum;
using System;
using System.Collections.Generic;

namespace CentralMidiaTv.Dominio.Funcionario.Entidade
{
    public class Funcionario
    {
        protected Funcionario()
        {
            FuncionariosCadastrados = new List<Funcionario>();
            FuncionariosExcluidos = new List<Funcionario>();
            Contatos = new List<Contato>();
        }
        public Funcionario(string nome, string sobrenome, string usuario, string senha, ETipoFuncionario tipoFuncionario, int idFuncionarioCadastro)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Usuario = usuario;
            Senha = senha;
            DataCadastro = DateTime.UtcNow;
            TipoFuncionario = tipoFuncionario;
            IdFuncionarioCadastro = IdFuncionarioCadastro;
            FuncionariosCadastrados = new List<Funcionario>();
            FuncionariosExcluidos = new List<Funcionario>();
            Contatos = new List<Contato>();
        }
        #region Metodos
        public string ObterNomeCompleto()
        {
            return Nome + (!string.IsNullOrEmpty(Sobrenome) ? " " + Sobrenome : "");
        }
        #endregion
        #region Atributos
        public int IdFuncionario { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Usuario { get; private set; }
        public string Senha { get; private set; }
        public ETipoFuncionario TipoFuncionario { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public int? IdFuncionarioCadastro { get; private set; }
        public Funcionario FuncionarioCadastro { get; private set; }
        public virtual List<Funcionario> FuncionariosCadastrados { get; private set; }
        public int? IdFuncionarioExclusao { get; private set; }
        public Funcionario FuncionarioExclusao { get; private set; }
        public DateTime? DataExclusao { get; set; }
        public virtual List<Funcionario> FuncionariosExcluidos { get; private set; }
        public virtual List<Contato> Contatos { get; private set; }
        #endregion
    }
}
