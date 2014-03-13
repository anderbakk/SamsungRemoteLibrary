using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Button.Number
{
    public class Seven : INumberButton, IChannelButton
    {
        public string Code { get { return "KEY_7"; } }
        public int Number { get { return 7; } }
    }
}