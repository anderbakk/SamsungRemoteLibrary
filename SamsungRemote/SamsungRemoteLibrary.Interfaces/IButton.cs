namespace SamsungRemoteLibrary.Interfaces
{
    public interface IButton
    {
        string Code { get; }
    }

    public interface IChannelButton : IButton
    {
    }

    public interface INumberButton : IButton
    {
        int Number { get; }
    }

    public interface IRecordingButton : IButton { }

    public interface INavigationButton : IButton
    {
    }

    public interface IVolumeButton : IButton
    {
    }

    public interface IPowerButton : IButton
    { }

    public interface IMenuButton : IButton
    {

    }
    public interface IMiscButton : IButton
    {
    }
}
