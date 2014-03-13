using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Button.Number
{
    public class Three : INumberButton, IChannelButton
    {
        public string Code { get { return "KEY_3"; } }
        public int Number { get { return 3; } }
    }
}