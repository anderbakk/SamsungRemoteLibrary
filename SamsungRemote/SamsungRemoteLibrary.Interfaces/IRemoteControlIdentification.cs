namespace SamsungRemoteLibrary.Interfaces
{
    public interface IRemoteControlIdentification
    {
        string RemoteControlIp { get; }
        string RemoteControlMac { get; }
        string AppName { get; }
    }

    public interface ITvSettings
    {
        string TvIp { get; }
        int TvPortNumber { get; }
    }
}