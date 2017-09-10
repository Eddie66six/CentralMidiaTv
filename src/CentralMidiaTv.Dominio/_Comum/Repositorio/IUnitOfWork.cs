using System;

namespace CentralMidiaTv.Dominio._Comum.Repositorio
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
