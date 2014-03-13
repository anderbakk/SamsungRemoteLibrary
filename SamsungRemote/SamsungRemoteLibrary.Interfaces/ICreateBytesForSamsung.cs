using System;

namespace SamsungRemoteLibrary.Interfaces
{
    public interface ICreateBytesForSamsung
    {
        byte[] CreateIdentifier();
        byte[] CreateSecondParameter();
        byte[] CreateCommand(string command);
    }
}