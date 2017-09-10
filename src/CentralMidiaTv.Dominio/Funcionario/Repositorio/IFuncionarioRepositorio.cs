using CentralMidiaTv.Dominio.Funcionario.ViewModel;

namespace CentralMidiaTv.Dominio.Funcionario.Repositorio
{
    public interface IFuncionarioRepositorio
    {
        BasicoFuncionario Logar(string usuario, string senha);
    }
}
