using IdentityModel.Client;
using Microsoft.Extensions.Options;

namespace Client.Services
{
    public class TokenService : ITokenService
    {
        public readonly IOptions<IdentityServerSettings> identityServerSettings;
        public readonly DiscoveryDocumentResponse discoveryDocument;
        private readonly HttpClient httpclient;

        public TokenService(IOptions<IdentityServerSettings> identityServerSettings)
        {
            this.identityServerSettings = identityServerSettings;

            httpclient = new HttpClient();
            this.discoveryDocument = httpclient.GetDiscoveryDocumentAsync(this.identityServerSettings.Value.DiscoveryUrl).Result;

            if (discoveryDocument.IsError)
            {
                throw new Exception("Unable to get discovery", discoveryDocument.Exception);
            }
        }
        public async Task<TokenResponse> GetToken(string scope)
        {
            var tokenResponse = await httpclient.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = this.discoveryDocument.TokenEndpoint,
                ClientId = this.identityServerSettings.Value.ClientName,
                ClientSecret = identityServerSettings.Value.ClientPassword,
                Scope = scope
            });

            if (tokenResponse.IsError)
            {
                throw new Exception("Unable to get token", tokenResponse.Exception);
            }

            return tokenResponse;
        }
    }
}
