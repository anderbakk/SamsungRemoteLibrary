namespace SamsungUniversalRemoteLibrary
{
    public interface IConnectToTv
    {
        void Send(IButton button);
        void Send(string button);
    }
}