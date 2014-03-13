using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Volume
{
    public class VolumeDown : IVolumeButton
    {
        public string Code { get { return "KEY_VOLDOWN"; } }
    }
}