using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Misc
{
    public class PowerOff : IPowerButton
    {
        public string Code { get { return "KEY_POWEROFF"; } }
    }
}