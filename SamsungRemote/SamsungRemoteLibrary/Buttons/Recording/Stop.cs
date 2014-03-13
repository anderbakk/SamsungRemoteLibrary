using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Recording
{
    public class Stop : IRecordingButton
    {
        public string Code { get { return "KEY_STOP"; } }
    }
}