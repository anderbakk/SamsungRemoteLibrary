using SamsungRemoteLibrary.Interfaces;
using SamsungRemoteLibrary.TvConnector;

namespace SamsungRemoteLibrary.Demo.Console
{
    public class Program
    {
        class YourSettings : IRemoteControlIdentification, ITvSettings
        {
            // Change these properties 
            public string RemoteControlIp{get{return "192.168.1.35";}}
            public string TvIp{get{return "192.168.1.184";}}
            public int TvPortNumber{get{return 55000;}}
            public string RemoteControlMac{get{return "0C-89-10-CD-43-28";}}
            public string AppName{get{return "Anderbakk remote";}}

            public override string ToString()
            {
                return string.Format(
                        "Application name:{4}\nRemote control IP: {0}\nRemote control mac: {1}\nTv address: {2}:{3}\n",
                        RemoteControlIp, RemoteControlMac, TvIp, TvPortNumber, AppName);
            }
        }

        static void Main()
        {
            DisplayLogo();
            var yourSettings = new YourSettings();

            System.Console.WriteLine(yourSettings);

            var remote = new RemoteControl(new SamsungTvConnection(yourSettings, new SamsungBytesBuilder(yourSettings)));

            remote.Push("KEY_VOLDOWN");
            System.Console.WriteLine("Command sent to TV.");

            System.Console.ReadLine();
        }

        private static void DisplayLogo()
        {
            System.Console.WriteLine(@"
     _              _           _           _    _    _     
    / \   _ __   __| | ___ _ __| |__   __ _| | _| | _( )___ 
   / _ \ | '_ \ / _` |/ _ \ '__| '_ \ / _` | |/ / |/ /// __|
  / ___ \| | | | (_| |  __/ |  | |_) | (_| |   <|   <  \__ \
 /_/__ \_\_| |_|\__,_|\___|_|  |_.__/ \__,_|_|\_\_|\_\ |___/
 |  _ \ ___ _ __ ___   ___ | |_ ___                         
 | |_) / _ \ '_ ` _ \ / _ \| __/ _ \                        
 |  _ <  __/ | | | | | (_) | ||  __/                        
 |_| \_\___|_| |_| |_|\___/ \__\___|                        
                                                            ");
        }
    }


}
