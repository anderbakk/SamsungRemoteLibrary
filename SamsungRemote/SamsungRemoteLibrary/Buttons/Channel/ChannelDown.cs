using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Channel
{
    public class ChannelDown : IChannelButton
    {
        public string Code { get { return "KEY_CHDOWN"; } }
    }
}