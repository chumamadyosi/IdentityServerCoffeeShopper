namespace Client.Services
{
    public interface IIdentitySettingsService
    {
        string GetDiscoveryUrl { get; }
        string GetClientName { get; }
        string GetClientPassword { get; }
        bool GetUseHttps { get; }

    }
}
