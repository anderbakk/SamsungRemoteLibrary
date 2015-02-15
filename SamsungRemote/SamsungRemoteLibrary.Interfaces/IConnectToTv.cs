namespace SamsungRemoteLibrary.Interfaces
{
    public interface IConnectToTv
    {
        void Send(IButton button);
        void Send(string button);
    }
}