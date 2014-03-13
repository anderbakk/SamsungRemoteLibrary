using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Button.Channel
{
    public class ChannelDown : IChannelButton
    {
        public string Code { get { return "KEY_CHDOWN"; } }
    }
}