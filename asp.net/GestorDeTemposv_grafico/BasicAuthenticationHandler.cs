using GestorDeTempos.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;

namespace GestorDeTempos
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            //adicionar nestes argumentos, a possibilidade de aceder à base de dados:
            ApplicationDbContext context
            ) : base(options, logger, encoder, clock)
        {
            db = context;   //aqui: tranferir a context para a db (db é local)
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {

            Response.Headers.Add("WWW-Authenticate", "Basic");

            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return Task.FromResult(AuthenticateResult.Fail("Auhorization Header Missing"));
            }

            var authorizationHeader = Request.Headers["Authorization"].ToString();
            var authHeaderRegex = new Regex("Basic (.*)");

            if (!authHeaderRegex.IsMatch(authorizationHeader))
            {
                return Task.FromResult(AuthenticateResult.Fail("Authorization code not formated properly"));
            }

            var authBase64 = Encoding.UTF8.GetString(Convert.FromBase64String(authHeaderRegex.Replace(authorizationHeader, "$1")));
            var authSplit = authBase64.Split(Convert.ToChar(":"), 2);
            var authUsername = authSplit[0];
            var authPassword = authSplit.Length > 1 ? authSplit[1] : throw new Exception("Unable to get password");


            // ##################################################################################
            //aqui:
            if (VerificarLogin(authUsername, authPassword))
            {
                authUsername = "roundthecode";
                authPassword = "roundthecode";//pode ser outro literal qualquer...
            }
            // ##################################################################################




            if (authUsername != "roundthecode" || authPassword != "roundthecode")
            {
                return Task.FromResult(AuthenticateResult.Fail("The userrname or password is not correct"));
            }

            var authenticatedUser = new AuthenticatedUser("BasicAuthentication", true, "roundthecode");

            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(authenticatedUser));

            return Task.FromResult(AuthenticateResult.Success(new AuthenticationTicket(claimsPrincipal, Scheme.Name)));

        }



        //#####################################################################
        //AQUI: verificar se o par user / senha é válido na base de dados:

        public readonly ApplicationDbContext db;
        public bool VerificarLogin(string utilizador, string senha)
        {
            bool encontrado = false;//encontrou o utilizador na base de dados?
            var T = from s in db.TUtilizadores select s; //sintaxe LINQ alternativa...

            foreach (var item in T)
            {
                if (item.UtilizadorName == utilizador && item.Senha == senha)

                {//existe na BD:
                    encontrado = true;
                }
            }
            if (encontrado)
                return true;
            else
                return false;
        }

    }
}
