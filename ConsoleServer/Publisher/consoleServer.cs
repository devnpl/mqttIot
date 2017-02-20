﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace ConsoleServer
{
    public class Program
    {
        public static void Main(string[] args)

            
        {
            MqttClient client = new MqttClient("test.mosquitto.org");
            string uniqueserverid = Guid.NewGuid().ToString();
            client.Connect(uniqueserverid);
            try
            {
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                {
                    if (name.ToLower().Equals("dev"))

                
                Console.WriteLine("Enter the Topic name to publish");
                string topic = Console.ReadLine();
                   
                   

                bool repeat = true;
                   

                while (repeat)
                {
                    Console.WriteLine("Write the msg or 'x' to close :");
                    string msg = Console.ReadLine();
                      
                    if (msg.ToLower().Equals("x"))
                    {
                        repeat = false;
                            break;
                    }
                       
                    client.Publish(topic, Encoding.ASCII.GetBytes(msg));
                              
                    }
                    

                
                }
               
                Console.WriteLine("Publish stopped. Please exit the application");
                

            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

            

        }

        
    }
}
