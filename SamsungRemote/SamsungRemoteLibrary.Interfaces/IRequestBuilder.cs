using System;

namespace SamsungRemoteLibrary.Interfaces
{
    public interface IRequestBuilder
    {
        byte[] CreateIdentifier(String callerMacAddress, String applicationName, String callerIpAddress);
        byte[] CreateSecondParameter();
        byte[] CreateCommand(string command);
        byte[] CreateText(String text);
    }
}