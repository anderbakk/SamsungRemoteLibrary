using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Recording
{
    public class Rewind : IRecordingButton
    {
        public string Code { get { return "KEY_REWIND"; } }
    }
}