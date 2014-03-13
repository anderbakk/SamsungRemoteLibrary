using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Recording
{
    public class Record : IRecordingButton
    {
        public string Code { get { return "KEY_REC"; } }
    }
}
