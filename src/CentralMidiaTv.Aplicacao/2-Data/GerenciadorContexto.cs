using System.Web;

namespace CentralMidiaTv.Aplicacao._2_Data
{
    public class GerenciadorContexto
    {
        public Contexto GetContext()
        {
            if (HttpContext.Current.Items["ContextManager.Context"] == null)
            {

                HttpContext.Current.Items["ContextManager.Context"] = new Contexto();
            }

            return (Contexto)HttpContext.Current.Items["ContextManager.Context"];
        }
    }
}