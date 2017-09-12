using CentralMidiaTv.Dominio.Funcionario.Aplicacao;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;

namespace CentralMidiaTv.servico.Controllers.Funcionario
{
    [Authorize]
    [RoutePrefix("api/v1/funcionario")]
    public class FuncionarioController : BaseController
    {
        private readonly IFuncionarioAplicacao _funcionarioAplicacao;
        public FuncionarioController(IFuncionarioAplicacao funcionarioAplicacao) :base()
        {
            _funcionarioAplicacao = funcionarioAplicacao;
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("login")]
        public Task<HttpResponseMessage> Login(string usuario, string senha)
        {
            var funcionario = _funcionarioAplicacao.Logar(usuario, senha);
            if (funcionario == null)
                return CreateResponse(HttpStatusCode.OK, null);

            var identity = new ClaimsIdentity("Bearer");
            var ticket = ConfigureAuthenticationTicket(identity);
            var token = Startup.OAuthServerOptions.AccessTokenFormat.Protect(ticket);
            return CreateResponse(HttpStatusCode.OK, new { Funcionario = funcionario, LoginData = new { Token = token, ExpiresIn = ticket.Properties.ExpiresUtc } });
        }

        [HttpGet]
        [Route("registrar")]
        public Task<HttpResponseMessage> Registrar(string usuario, string senha)
        {
            var funcionario = _funcionarioAplicacao.Logar(usuario, senha);
            return CreateResponse(HttpStatusCode.OK, funcionario);
        }
    }
}