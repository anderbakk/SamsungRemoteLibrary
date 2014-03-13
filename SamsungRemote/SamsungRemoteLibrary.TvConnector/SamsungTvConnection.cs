using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.TvConnector
{
    public class SamsungTvConnection : IConnectToTv
    {
        private readonly IRemoteControlSettings _settings;
        private readonly IRequestBuilder _requestBuilder;

        public SamsungTvConnection(IRemoteControlSettings settings, IRequestBuilder requestBuilder)
        {
            _settings = settings;
            _requestBuilder = requestBuilder;
        }

        public void Send(IButton button)
        {
            var identifier = _requestBuilder.CreateIdentifier(_settings.RemoteControlMac, _settings.AppName,
                _settings.RemoteControlIp);

            var secondParameter = _requestBuilder.CreateSecondParameter();

            var command = _requestBuilder.CreateCommand(button.Code);

            Send(_settings.TvIp, _settings.TvPortNumber,
                new List<byte[]>
                {
                    identifier,
                    secondParameter,
                    command
                });
        }

        private void Send(string ipAddress, int portNumber, IEnumerable<byte[]> messages)
        {
            var listOfByteArrays = messages as IList<byte[]> ?? messages.ToList();
            using (var socket = new Socket(SocketType.Stream, ProtocolType.Tcp))
            {
                socket.Connect(ipAddress, portNumber);

                foreach (var message in listOfByteArrays)
                {
                    socket.Send(message);            
                }
            }
        }
    }
}
