using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Net.Security;

namespace ReceiveMessage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //StudnetIotHub.azure-devices.net;DeviceId=Test01

            MqttClient newclient = new MqttClient("StudnetIotHub.azure-devices.net");
            var client = new MqttClient("StudnetIotHub.azure-devices.net", 8883, true,MqttSslProtocols.SSLv3, (a,s,d,f)=> { return true; }, ()=> { return null; });
            // string deviceId = "IgusDE023";
            string deviceId = "Test01";

            string userName = "StudnetIotHub.azure-devices.net/Test01/api-version=2016-02-03";
           // string userName = "daenethub.azure-devices.net/IgusDE023/api-version=2016-11-14";
           // string password = "SharedAccessSignature sr=StudnetIotHub.azure-devices.net&sig=rJCizqCHFbPkx%2FejSSGLS%2FU5rqOn2AvMOXOiijOMts8%3D&se=1519129853&skn=iothubowner";
            string password = "SharedAccessSignature sr=StudnetIotHub.azure-devices.net%2fdevices%2fTest01&sig=3RYKJqTzpDWekPfFdmjetlbTQwvRcne6SZ7WwlvBnY0%3d&se=1487853795";
            newclient.Connect(deviceId,userName,password);

            Console.WriteLine("This is successfully Connected!!!");

            Console.ReadKey();

        }
    }
}
