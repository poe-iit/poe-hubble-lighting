using System;
using Igor.Gateway.Api.Sdk.Apis.Lights;
using Igor.Gateway.Api.Sdk.Apis.Actions;
using Igor.Gateway.Api.Sdk.Apis.LightSensors;
using System.Threading;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Igor.Gateway.Dtos.Events;
using System.Collections;
using Igor.Gateway.Dtos.LightSensors;

namespace SingleLightBlink
{
    class Program
    {
        static ActionService actionService;
        static LightSensorService lightSensorService;


        const string twilioAccountSid = "AC2480df9d5dbe061d560c2d11c223e286";
        const string authToken = "eba8a696984fa781daaea94e09f22c9a";





      //test to see changes





        static void Main(string[] args)
        {
            actionService = new ActionService("903f1e7c45b646db959749ff3bb66bc1", "http://192.168.2.100");
            lightSensorService = new LightSensorService("903f1e7c45b646db959749ff3bb66bc1", "http://192.168.2.100");

            // we need to listen for the signal from the smoke detector
            // if we get one, flash the lights
            // need to specify which lights to flash as an action of the webconsole




            TwilioClient.Init(twilioAccountSid, authToken);

            //send text message upon signal
            var message = MessageResource.Create(
                body: "Fire in Room 222",
                from: new Twilio.Types.PhoneNumber("+17042759233"),
                to: new Twilio.Types.PhoneNumber("+13127927171")
                );


            Thread.Sleep(1000);
            Console.WriteLine(message.Sid);
            Console.WriteLine(message.Status);


            while (true)
            {
                var x = lightSensorService.GetEvents(2006);
                IEnumerator enumerator = x.Result.List.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(((EventDto)enumerator.Current).Value);
                }

            }



        }


    }
}