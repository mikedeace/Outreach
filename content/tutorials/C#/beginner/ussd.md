### USSD
===========

1. Create a new project,
>> 1. On the menu bar choose file ,then select new project.
>> 2. select visual c# web and then name your project.
>> 3. select an empty project then at select both the mvc checkbox and web api checkbox 
>> 4. Click ok

2. Check to ensure there is a ``RouteConfig.cs`` file and ``WebApiConfig.cs`` file in the App_Start folder. 
3. On the controllers folder right click and select Add->controller, select Web Api Controller empty and name it for example MobileController.
4. copy paste this

```cs

using System;
using System.Collections;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AT_.Controllers
{
    public class ServerModels
    {
        public string text { get; set; }
        public string phoneNumber { get; set; }
        public String sessionId { get; set; }
        public string serviceCode { get; set; }
    }
    [RoutePrefix("africas/talking")]
    public class MobileController : ApiController
    {
        [Route("ussd")]
            [HttpPost, ActionName("ussd")]
            public HttpResponseMessage ussd([FromBody]ServerModels serverModels)
            {
                HttpResponseMessage rs;
                string response;

                if (serverModels.text == null)
                {
                    serverModels.text = "";
                }

                if (serverModels.text.Equals("", StringComparison.Ordinal))
                {
                    response = "CON Welcome to" +serverModels.serviceCode+ "\n";
                    response += "1. An inspiring message \n";
                    response += "2. An inspiring call \n";
                    response += "3. Is it your lucky day? \n ";
                }
                else if (serverModels.text.Equals("1", StringComparison.Ordinal))
                {
                response = "END We will be sending you an inspiring message shortly/n";      
                }
                else if (serverModels.text.Equals("2", StringComparison.Ordinal))
                {
                response = "END You should be recieving our call any minute now/n";
                }
                else if (serverModels.text.Equals("3", StringComparison.Ordinal))
                {
                 response = "END You are our lucky winner of ten shilling airtime/n";
                }
                else
                {
                    response = "END bad option";
                }
                rs = Request.CreateResponse(HttpStatusCode.Created, response);
                rs.Content = new StringContent(response, System.Text.Encoding.UTF8, "text/plain");

                return rs;
            }
    }
```

5. Save and run your project. 
6. When the browser pops up , navigate `your localhost`/africas/talking/ussd
7. open ngrok and run 
8. copy paste the ngrok url and its postfix ``/africas/talking/ussd`` to your aficastalking account 