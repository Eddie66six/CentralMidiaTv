using CentralMidiaTv.Aplicacao._1_Aplicacao._Comum;
using CentralMidiaTv.Aplicacao._2_Data;
using CentralMidiaTv.Dominio._Comum.Repositorio;
using CentralMidiaTv.Dominio.Funcionario.Aplicacao;
using CentralMidiaTv.Dominio.Funcionario.Repositorio;
using CentralMidiaTv.Dominio.Funcionario.ViewModel;

namespace CentralMidiaTv.Aplicacao._1_Aplicacao.Funcionario
{
    public class FuncionarioAplicacao : AppBase, IFuncionarioAplicacao
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;
        public FuncionarioAplicacao(IUnitOfWork unitOfWork, IFuncionarioRepositorio funcionarioRepositorio) : base(unitOfWork)
        {
            _funcionarioRepositorio = funcionarioRepositorio;
        }

        public Dominio.Funcionario.Entidade.Funcionario RegistrarFuncionario(NovoFuncionarioViewModel novoFuncionario)
        {
            return null;
        }

        public BasicoFuncionario Logar(string usuario, string senha)
        {
            var funcionario = _funcionarioRepositorio.Logar(usuario, senha);
            if (funcionario == null)
                new DomainNotification("Logar", "Login invalido");
            return funcionario;
        }
    }
}