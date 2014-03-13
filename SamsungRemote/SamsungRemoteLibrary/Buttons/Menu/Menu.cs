using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Menu
{
    public class Menu : IMenuButton
    {
        public string Code { get { return "KEY_MENU"; } }
    }
}