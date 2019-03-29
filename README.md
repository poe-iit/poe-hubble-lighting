# POElighting

This project is the backend solution to the Power over Ethernet Lighting Cybersecurity Vulnerabilities and Capabilities Analysis. 


## Getting Started
In order to communicate with the PowerHUBB sensors the Igor Gateway Api is needed. It is included in this repo but for future reference 
it can be found [here](https://bitbucket.org/igordev/igor-gateway-api-c-sdk/overview). The avaliable functions of the API can be found 
[here](https://bitbucket.org/igordev/igor-gateway-api-c-sdk/src/80866661bab47ca0ce63ecca92ca5e2fc483debb/src/Igor.Gateway.Api.Sdk/Apis/?at=master)

In order to use the text messaging functionality, the Twilio package will need to be installed. 
This can be done through the Visual Studio Package 
Manager Console with the command
```bash
Install-Package Twilio
```
It can also be installed using .NET core command line tools by running this command within the project directory **/POE_Single_Light/**

```bash
$ dotnet add package Twilio
```
