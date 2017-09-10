using CentralMidiaTv.Dominio.Funcionario.Repositorio;
using CentralMidiaTv.Dominio.Funcionario.ViewModel;

namespace CentralMidiaTv.Dominio.Funcionario.Aplicacao
{
    public interface IFuncionarioAplicacao : IFuncionarioRepositorio
    {
        Entidade.Funcionario RegistrarFuncionario(NovoFuncionarioViewModel novoFuncionario);
    }
}