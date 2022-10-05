using Microsoft.AspNetCore.Authorization;

namespace GestorDeTempos
{
    public class BasicAuthorizeAttribute : AuthorizeAttribute
    {
        public BasicAuthorizeAttribute()
        {
            Policy = "BasicAuthentication";
        }
    }
}
