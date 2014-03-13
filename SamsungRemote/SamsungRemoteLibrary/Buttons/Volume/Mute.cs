using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Volume
{
    public class Mute : IVolumeButton
    {
        public string Code { get { return "KEY_MUTE"; } }
    }
}