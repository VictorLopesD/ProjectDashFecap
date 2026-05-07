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
        private const string TenantId = "common";

        private static IPublicClientApplication _clienteApp;

        public static async Task<string> GetTokenAsync()
        {
            if (_clienteApp == null)
            {
                _clienteApp = PublicClientApplicationBuilder.Create(ClientId)
                                .WithAuthority("https://login.microsoftonline.com/common")
                                .WithDefaultRedirectUri()
                                .Build();
            }
            var acounts = await _clienteApp.GetAccountsAsync();
            AuthenticationResult result;

            try
            {
                result = await _clienteApp.AcquireTokenSilent(new[] { "Sites.ReadWrite.All" }, acounts.FirstOrDefault())
                    .ExecuteAsync();
            }
            catch(MsalUiRequiredException)
            {
                result = await _clienteApp.AcquireTokenInteractive(new[] { "Sites.ReadWrite.All" }).ExecuteAsync();


            }

            return result.AccessToken;

        }


    }
}
