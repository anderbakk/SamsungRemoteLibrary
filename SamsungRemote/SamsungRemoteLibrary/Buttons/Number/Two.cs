using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Number
{
    public class Two : INumberButton, IChannelButton
    {
        public string Code { get { return "KEY_2"; } }
        public int Number { get { return 2; } }
    }
}