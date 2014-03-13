using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.Buttons.Navigation
{
    public class Return : INavigationButton
    {
        public string Code { get { return "KEY_RETURN"; } }
    }
}