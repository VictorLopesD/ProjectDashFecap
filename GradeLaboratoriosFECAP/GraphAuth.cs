using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;


namespace GradeLaboratoriosFECAP
{
    internal class GraphAuth
    {
        private const string ClientId = "7cb4458a-e8ed-4ce9-a823-ea9ee4b9e134";
        private const string TenantId = "3e29e08c-3085-4363-aa91-1713dda9438a";

        private static IPublicClientApplication _clienteApp;

        public static async Task<string> GetTokenAsync()
        {
            if (_clienteApp == null)
            {
                _clienteApp = PublicClientApplicationBuilder.Create(ClientId)
                            .WithAuthority($"https://login.microsoftonline.com/{TenantId}")
                            .WithDefaultRedirectUri()   // ✅ deixa o MSAL escolher localhost + porta
                            .Build();
            }
            var acounts = await _clienteApp.GetAccountsAsync();
            AuthenticationResult result;

            try
            {
                result = await _clienteApp.AcquireTokenSilent(new[] { "Files.Read.All", "User.Read" }, acounts.FirstOrDefault())
                    .ExecuteAsync();
            }
            catch(MsalUiRequiredException)
            {
                result = await _clienteApp.AcquireTokenInteractive(new[] { "Files.Read.All", "User.Read" }).ExecuteAsync();


            }

            return result.AccessToken;

        }


    }
}
