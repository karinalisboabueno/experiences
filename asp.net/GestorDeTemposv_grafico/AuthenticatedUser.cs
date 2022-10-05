using System.Security.Principal;

namespace GestorDeTempos
{
    public class AuthenticatedUser : IIdentity
    {
        public AuthenticatedUser(string authenticateType, bool isAuthenticated, string name)
        {
            AuthenticationType = authenticateType;
            IsAuthenticated = isAuthenticated;
            Name = name;
        }

        public string AuthenticationType { get; set; }

        public bool IsAuthenticated { get; }

        public string? Name { get; set; }

    }
}
