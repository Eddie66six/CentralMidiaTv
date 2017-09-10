using CentralMidiaTv.Dominio._Comum.Repositorio;
using System.Web;

namespace CentralMidiaTv.Aplicacao._1_Aplicacao._Comum
{
    public class AppBase
    {
        private readonly IUnitOfWork _unitOfWork;
        protected AppBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Commit()
        {
            if (HttpContext.Current.Items["DomainNotification.message"] != null)
                return false;
            return _unitOfWork.Commit();
        }
    }
}