using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Recording
{
    public class Play : IRecordingButton
    {
        public string Code { get { return "KEY_PLAY"; } }
    }
}