using System;
using System.Text;
using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.TvConnector
{
    public class RequestBuilder : IRequestBuilder
    {
        private const string AppString = "samsung.remote"; 

        public byte[] CreateIdentifier(String callerMacAddress, String applicationName, String callerIpAddress)
        {
            var myIpBase64 = Base64Encode(callerIpAddress);
            var myMacBase64 = Base64Encode(callerMacAddress);
            var nameBase64 = Base64Encode(applicationName);

            var message =
                char.ToString((char)0x64) +
                char.ToString((char)0x00) +
                char.ToString((char)myIpBase64.Length) +
                char.ToString((char)0x00) +
                myIpBase64 +
                char.ToString((char)myMacBase64.Length) +
                char.ToString((char)0x00) +
                myMacBase64 +
                char.ToString((char)nameBase64.Length) +
                char.ToString((char)0x00) +
                nameBase64;

            var part =
                char.ToString((char)0x00) +
                char.ToString((char)AppString.Length) +
                char.ToString((char)0x00) +
                AppString +
                char.ToString((char)message.Length) +
                char.ToString((char)0x00) +
                message;

            return ConvertToBytes(part);
        }

        //Might be used for some TV models... 
        public byte[] CreateSecondParameter()
        {
            var message = ((char)0xc8) +
                          ((char)0x00) + string.Empty;

            var part =
                char.ToString((char)0x00) +
                char.ToString((char)AppString.Length) +
                char.ToString((char)0x00) +
                AppString +
                char.ToString((char)message.Length) +
                char.ToString((char)0x00) +
                message;
            return ConvertToBytes(part);
        }

        public byte[] CreateCommand(string command)
        {
            var commandBase64 = Base64Encode(command);

            var message =
                char.ToString((char)0x00) +
                char.ToString((char)0x00) +
                char.ToString((char)0x00) +
                char.ToString((char)commandBase64.Length) +
                char.ToString((char)0x00) +
                commandBase64;

            var part =
                char.ToString((char)0x00) +
                char.ToString((char)AppString.Length) +
                char.ToString((char)0x00) +
                AppString +
                char.ToString((char)message.Length) +
                char.ToString((char)0x00) +
                message;

            return ConvertToBytes(part);
        }

        public byte[] CreateText(String text)
        {
            var textBase64 = Base64Encode(text);

            var message =
                    char.ToString((char)0x01) +
                    char.ToString((char)0x00) +
                    char.ToString((char)textBase64.Length) +
                    char.ToString((char)0x00) +
                    textBase64;

            var part =
                    char.ToString((char)0x01) +
                    char.ToString((char)AppString.Length) +
                    char.ToString((char)0x00) +
                    AppString +
                    char.ToString((char)message.Length) +
                    char.ToString((char)0x00) +
                    message;

            return ConvertToBytes(part);
        }

        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        private static byte[] ConvertToBytes(string value)
        {
            return Encoding.ASCII.GetBytes(value);
        }
    }
}
