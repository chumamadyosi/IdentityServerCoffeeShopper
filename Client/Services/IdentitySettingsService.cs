using Microsoft.Extensions.Options;
using System.Runtime;

namespace Client.Services
{
    public class IdentitySettingsService : IIdentitySettingsService
    {
        private IdentityServerSettings _settings;
        public IdentitySettingsService(IOptions<IdentityServerSettings> config)
        {
            _settings = config.Value;
        }

        public string GetClientName => _settings.ClientName;

        public string GetClientPassword => _settings.ClientPassword;

        public string GetDiscoveryUrl => _settings.DiscoveryUrl;

        public bool GetUseHttps => _settings.UseHttps;
    }
}
