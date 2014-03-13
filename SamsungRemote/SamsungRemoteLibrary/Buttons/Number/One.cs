using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Button.Number
{
    public class One : INumberButton, IChannelButton
    {
        public string Code { get { return "KEY_1"; }}
        public int Number { get { return 1; } }
    }
}
