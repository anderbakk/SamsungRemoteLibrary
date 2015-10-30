namespace SamsungUniversalRemoteLibrary
{
    public interface IRemoteControlIdentification
    {
        string RemoteControlIp { get; }
        string RemoteControlMac { get; }
        string AppName { get; }
    }
}