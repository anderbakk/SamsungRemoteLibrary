using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Number
{
    public class Nine : INumberButton, IChannelButton
    {
        public string Code { get { return "KEY_9"; } }
        public int Number { get { return 9; } }
    }
}