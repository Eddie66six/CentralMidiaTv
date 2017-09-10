using CentralMidiaTv.Dominio._Comum.Repositorio;
using System.Data.Entity;

namespace CentralMidiaTv.Aplicacao._2_Data.Repositorio
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {
        protected Contexto Db => _gerenciadorContexto.GetContext();
        protected readonly GerenciadorContexto _gerenciadorContexto;
        public BaseRepositorio(GerenciadorContexto gerenciadorContexto)
        {
            _gerenciadorContexto = gerenciadorContexto;
        }
        public T Adicionar(T obj)
        {
            Db.Set<T>().Add(obj);
            return obj;
        }

        public void Atualizar(T obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
        }

        public void Remover(T obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
        }
    }
}