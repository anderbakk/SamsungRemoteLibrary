using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Button.Number
{
    public class Four : INumberButton, IChannelButton
    {
        public string Code { get { return "KEY_4"; } }
        public int Number { get { return 4; } }
    }
}