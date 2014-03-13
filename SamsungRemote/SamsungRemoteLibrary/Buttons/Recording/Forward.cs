using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Recording
{
    public class Forward : IRecordingButton
    {
        public string Code { get { return "KEY_FF"; } }
    }
}