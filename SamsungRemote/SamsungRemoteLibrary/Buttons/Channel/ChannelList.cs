using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Button.Channel
{
    public class ChannelList :  IChannelButton
    {
        public string Code { get { return "KEY_CH_LIST"; } }
    }
}