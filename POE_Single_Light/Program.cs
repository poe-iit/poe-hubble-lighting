using System;
using Igor.Gateway.Api.Sdk.Apis.Lights;
using Igor.Gateway.Api.Sdk.Apis.Actions;
using Igor.Gateway.Api.Sdk.Apis.LightSensors;
using System.Threading;

using Igor.Gateway.Dtos.Events;
using System.Collections;
using Igor.Gateway.Dtos.LightSensors;
using System.Linq;

namespace SingleLightBlink
{
    class Program
    {
        static ActionService actionService;
        static LightSensorService lightSensorService;


        static void Main(string[] args)
        {
            actionService = new ActionService("903f1e7c45b646db959749ff3bb66bc1", "http://192.168.2.100");
            lightSensorService = new LightSensorService("903f1e7c45b646db959749ff3bb66bc1", "http://192.168.2.100");

            actionService.Execute(2039, 3043);
            actionService.Execute(2039, 3046);



            while (true)
            {
                var sensor1 = lightSensorService.GetEvents(3009); //Light 2034, Sensor 3009
                var lst1 = sensor1.Result.List.ToArray();
                String val1 = lst1[lst1.Length - 1].Value;
                Console.WriteLine(lst1.Length - 1);

                
                var sensor2 = lightSensorService.GetEvents(3007);
                var lst2 = sensor2.Result.List.ToArray();
                String val2 = lst2[lst2.Length - 1].Value;
                //Console.WriteLine(lst2.Length - 1);

                var sensor3 = lightSensorService.GetEvents(3007);
                var lst3 = sensor3.Result.List.ToArray();
                String val3 = lst3[lst3.Length - 1].Value;
                //Console.WriteLine(lst3.Length - 1);

                var sensor4 = lightSensorService.GetEvents(3007);
                var lst4 = sensor4.Result.List.ToArray();
                String val4 = lst1[lst4.Length - 1].Value;
                //Console.WriteLine(lst4.Length - 1);

                var sensor5 = lightSensorService.GetEvents(3007);
                var lst5 = sensor5.Result.List.ToArray();
                String val5 = lst1[lst5.Length - 1].Value;
                //Console.WriteLine(lst5.Length - 1);

                var sensor6 = lightSensorService.GetEvents(3007);
                var lst6 = sensor6.Result.List.ToArray();
                String val6 = lst6[lst6.Length - 1].Value;
                //Console.WriteLine(lst6.Length - 1);
            


                if (!val1.Equals("Online") && !val1.Equals("0"))
                {
                    Console.WriteLine("FIRE IN 1!!!!");
                    while (true)
                    {

                        actionService.Execute(2039, 3045);
                        actionService.Execute(2039, 3043);
                        Thread.Sleep(100);
                        actionService.Execute(2039, 3044);
                        Thread.Sleep(100);

                    }
                }
               
                if (!val2.Equals("Online") && !val2.Equals("0"))
                {
                    Console.WriteLine("FIRE IN 2!!!!");
                    while (true)
                    {

                        actionService.Execute(3038, 3041);
                        Thread.Sleep(100);
                        actionService.Execute(3038, 3042);
                        Thread.Sleep(100);

                    }
                }

                if (!val3.Equals("Online") && !val3.Equals("0"))
                {
                    Console.WriteLine("FIRE IN 3!!!!");
                    while (true)
                    {

                        actionService.Execute(3038, 3041);
                        Thread.Sleep(100);
                        actionService.Execute(3038, 3042);
                        Thread.Sleep(100);

                    }
                }
                if (!val4.Equals("Online") && !val4.Equals("0"))
                {
                    Console.WriteLine("FIRE IN 4!!!!");
                    while (true)
                    {

                        actionService.Execute(3038, 3041);
                        Thread.Sleep(100);
                        actionService.Execute(3038, 3042);
                        Thread.Sleep(100);

                    }
                }

                if (!val5.Equals("Online") && !val5.Equals("0"))
                {
                    Console.WriteLine("FIRE IN 5!!!!");
                    while (true)
                    {

                        actionService.Execute(3038, 3041);
                        Thread.Sleep(100);
                        actionService.Execute(3038, 3042);
                        Thread.Sleep(100);

                    }
                }

                if (!val6.Equals("Online") && !val6.Equals("0"))
                {
                    Console.WriteLine("FIRE IN 6!!!!");
                    while (true)
                    {

                        actionService.Execute(3038, 3041);
                        Thread.Sleep(100);
                        actionService.Execute(3038, 3042);
                        Thread.Sleep(100);

                    }
                }
 

            }



        }


    }
}