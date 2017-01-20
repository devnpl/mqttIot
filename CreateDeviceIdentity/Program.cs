using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
//using uPLibrary.Networking.M2Mqtt;

namespace CreateDeviceIdentity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MqttClient mqttClient = new MqttClient("daenethub.azure-devices.net");
            string uniqid = Guid.NewGuid().ToString();
            mqttClient.Connect(uniqid);

            Console.WriteLine("Enter the topic name");
            string topic = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Enter yoúr Messagge");
                byte msg = Console.ReadLine();

                mqttClient.Publish(topic, )
            }
      
            

        }
    }
}
