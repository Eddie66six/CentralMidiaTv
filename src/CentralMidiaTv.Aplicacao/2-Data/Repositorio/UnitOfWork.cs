using CentralMidiaTv.Dominio._Comum.Repositorio;
using System;

namespace CentralMidiaTv.Aplicacao._2_Data.Repositorio
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly GerenciadorContexto _gerenciadorContexto;
        private Contexto contexto => _gerenciadorContexto.GetContext();
        public UnitOfWork(GerenciadorContexto gerenciadorContexto)
        {
            _gerenciadorContexto = gerenciadorContexto;
        }
        public bool Commit()
        {
            try
            {
                contexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                new DomainNotification("SaveChanges", e.ToString());
                return false;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    if (contexto != null)
            //    {
            //        contexto.Dispose();
            //        contexto = null;
            //    }
            //}
        }
    }
}