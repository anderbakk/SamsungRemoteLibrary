using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Button.Channel
{
    public class Source : IChannelButton
    {
        public string Code { get { return "KEY_SOURCE"; } }
    }
}