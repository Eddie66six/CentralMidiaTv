namespace CentralMidiaTv.Dominio._Comum.Repositorio
{
    public interface IBaseRepositorio<T> where T : class
    {
        T Adicionar(T obj);
        void Atualizar(T obj);
        void Remover(T obj);
    }
}
