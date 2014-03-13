namespace SamsungRemoteLibrary.Interfaces
{
    public interface IRemoteControlSettings
    {
        string RemoteControlIp { get; }
        string TvIp { get; }
        int TvPortNumber { get; }
        string RemoteControlMac { get; }
        string AppName { get; }
    }
}