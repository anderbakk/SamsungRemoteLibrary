using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Recording
{
    public class Pause : IRecordingButton
    {
        public string Code { get { return "KEY_PAUSE"; } }
    }
}