using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Volume
{
    public class VolumeUp : IVolumeButton
    {
        public string Code { get { return "KEY_VOLUP"; } }
    }
}
