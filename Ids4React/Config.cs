using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ids4React
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };


        public static IEnumerable<ApiResource> Apis =>
           new List<ApiResource>
            {
                new ApiResource("sap-api", "Spa API")
            };


        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                        ClientId = "spa api",
                        AllowedGrantTypes=GrantTypes.Implicit,
                        ClientSecrets =new List<Secret>()
                        {
                            new Secret("123456".Sha256())
                        },
                        AllowedScopes =
                        {
                            IdentityServerConstants.StandardScopes.OpenId,
                            IdentityServerConstants.StandardScopes.Profile,
                            IdentityServerConstants.StandardScopes.Email,
                            "spaapi"
                        },
                }
            };

    }
}
