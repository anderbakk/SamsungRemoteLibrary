using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Button.Number
{
    public class Six : INumberButton, IChannelButton
    {
        public string Code { get { return "KEY_6"; } }
        public int Number { get { return 6; } }
    }
}