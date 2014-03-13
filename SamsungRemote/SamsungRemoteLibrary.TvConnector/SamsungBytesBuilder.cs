using System;
using System.Text;
using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.TvConnector
{
    /// <summary>
    /// Builds the different byte arrays with app identification and the actual command.
    /// 
    /// Ported to .NET from https://github.com/instant-solutions/Java-Samsung-Remote-Library 
    /// </summary>
    public class SamsungBytesBuilder : ICreateBytesForSamsung
    {
        private readonly IRemoteControlIdentification _settings;
        private const string AppString = "samsung.remote";
        private readonly string _nullValue = char.ToString((char) 0x00);

        public SamsungBytesBuilder(IRemoteControlIdentification settings)
        {
            _settings = settings;
        }

        public byte[] CreateIdentifier()
        {
            var myIpBase64 = Base64Encode(_settings.RemoteControlIp);
            var myMacBase64 = Base64Encode(_settings.RemoteControlMac);
            var nameBase64 = Base64Encode(_settings.AppName);

            var message =
                char.ToString((char)0x64) +
                _nullValue +
                Format(myIpBase64.Length) +
                _nullValue +
                myIpBase64 +
                Format(myMacBase64.Length) +
                _nullValue +
                myMacBase64 +
                Format(nameBase64.Length) +
                _nullValue +
                nameBase64;

            var wrappedMessage =
                _nullValue +
                Format(AppString.Length) +
                _nullValue +
                AppString +
                Format(message.Length) +
                _nullValue +
                message;

            return ConvertToBytes(wrappedMessage);
        }

        //Might be used for some TV models... 
        public byte[] CreateSecondParameter()
        {
            var message = ((char)0xc8) +
                          ((char)0x00) + string.Empty;

            var wrappedMessage =
                _nullValue +
                Format(AppString.Length) +
                _nullValue +
                AppString +
                Format(message.Length) +
                _nullValue +
                message;
            return ConvertToBytes(wrappedMessage);
        }

        public byte[] CreateCommand(string command)
        {
            var encodedCommand = Base64Encode(command);

            var message =
                _nullValue +
                _nullValue +
                _nullValue +
                char.ToString((char)encodedCommand.Length) +
                _nullValue +
                encodedCommand;

            var wrappedMessage =
                _nullValue +
                Format(AppString.Length) +
                _nullValue +
                AppString +
                Format(message.Length) +
                _nullValue +
                message;

            return ConvertToBytes(wrappedMessage);
        }

        private static string Format(int value)
        {
            return char.ToString((char)value);
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
