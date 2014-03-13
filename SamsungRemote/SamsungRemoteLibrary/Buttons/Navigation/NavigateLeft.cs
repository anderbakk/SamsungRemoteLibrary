using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Navigation
{
    public class NavigateLeft : INavigationButton
    {
        public string Code { get { return "KEY_LEFT"; } }
    }
}