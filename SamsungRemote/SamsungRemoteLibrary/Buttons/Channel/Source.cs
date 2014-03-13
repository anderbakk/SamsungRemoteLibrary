using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Channel
{
    public class Source : IChannelButton
    {
        public string Code { get { return "KEY_SOURCE"; } }
    }
}