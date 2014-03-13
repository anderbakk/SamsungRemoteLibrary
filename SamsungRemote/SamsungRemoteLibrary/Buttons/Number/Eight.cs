using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Number
{
    public class Eight : INumberButton, IChannelButton
    {
        public string Code { get { return "KEY_8"; } }
        public int Number { get { return 8; } }
    }
}