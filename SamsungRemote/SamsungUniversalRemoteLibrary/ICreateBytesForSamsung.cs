namespace SamsungUniversalRemoteLibrary
{
    public interface ICreateBytesForSamsung
    {
        byte[] CreateIdentifier();
        byte[] CreateSecondParameter();
        byte[] CreateCommand(string command);
    }
}