using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using SamsungRemoteLibrary.Interfaces;

namespace SamsungRemoteLibrary.TvConnector
{
    public class SamsungTvConnection : IConnectToTv
    {
        private readonly ITvSettings _settings;
        private readonly ICreateBytesForSamsung _createBytesForSamsung;

        public SamsungTvConnection(ITvSettings settings, ICreateBytesForSamsung createBytesForSamsung)
        {
            _settings = settings;
            _createBytesForSamsung = createBytesForSamsung;
        }

        public void Send(IButton button)
        {
            var identifier = _createBytesForSamsung.CreateIdentifier();
            var secondParameter = _createBytesForSamsung.CreateSecondParameter();
            var command = _createBytesForSamsung.CreateCommand(button.Code);

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
