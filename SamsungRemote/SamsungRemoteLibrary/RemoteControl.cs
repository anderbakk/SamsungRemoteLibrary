using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary
{
    public class RemoteControl : IRemoteControl
    {
        private readonly IConnectToTv _tvConnector;
        
        public RemoteControl(IConnectToTv tvConnector)
        {
            _tvConnector = tvConnector;
        }

        public void Push(IButton button)
        {
            _tvConnector.Send(button);
        }
    }

}
