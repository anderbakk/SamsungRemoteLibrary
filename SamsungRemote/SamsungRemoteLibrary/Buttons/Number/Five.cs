using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Number
{
    public class Five : INumberButton, IChannelButton
    {
        public string Code { get { return "KEY_5"; } }
        public int Number { get { return 5; } }
    }
}