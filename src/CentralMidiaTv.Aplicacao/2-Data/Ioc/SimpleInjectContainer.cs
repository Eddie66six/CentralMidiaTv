using CentralMidiaTv.Aplicacao._1_Aplicacao.Funcionario;
using CentralMidiaTv.Aplicacao._2_Data.Repositorio;
using CentralMidiaTv.Aplicacao._2_Data.Repositorio.Funcionario;
using CentralMidiaTv.Dominio._Comum.Repositorio;
using CentralMidiaTv.Dominio.Funcionario.Aplicacao;
using CentralMidiaTv.Dominio.Funcionario.Repositorio;
using SimpleInjector;

namespace CentralMidiaTv.Aplicacao._2_Data.Ioc
{
    public static class SimpleInjectContainer
    {
        public static Container RegistrarIoc()
        {
            var registro = new Container();
            registro.Register<Contexto>();
            registro.Register<GerenciadorContexto>();

            #region Comum
            registro.Register<IUnitOfWork, UnitOfWork>();
            #endregion
            #region Funcionario
            registro.Register<IFuncionarioRepositorio, FuncionarioRepositorio>();
            registro.Register<IFuncionarioAplicacao, FuncionarioAplicacao>();
            #endregion
            return registro;
        }
    }
}