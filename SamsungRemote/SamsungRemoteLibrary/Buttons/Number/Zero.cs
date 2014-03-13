using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Number
{
    public class Zero : INumberButton, IChannelButton
    {
        public string Code { get { return "KEY_0"; } }
        public int Number { get { return 0; } }
    }
}