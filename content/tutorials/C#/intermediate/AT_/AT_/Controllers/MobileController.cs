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
                //change the recipient to serverModels.phoneNumber

                this.getSms();
                response = "END We will be sending you an inspiring message shortly/n";      
                }
                else if (serverModels.text.Equals("2", StringComparison.Ordinal))
                {

                //change 'string to = serverModel.phoneNumber'
                this.getCall();
                response = "END You should be recieving our call any minute now/n";
                }
                else if (serverModels.text.Equals("3", StringComparison.Ordinal))
                {
                this.getAirtime();
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
        [Route("sms")]
        public void getSms()
        {
            //if getSms is to be used as part of the ussd then change the uncomment this
            //string recipient = serverModels.phoneNumber;
            string recipient = "+254716XXYYZZ";
            string message = "Hi mr. In order to succeed, we must first believe that we can.\n Read more at: http://www.brainyquote.com/quotes/topics/topic_motivational.html";
            AfricasTalkingGateway gateway = new AfricasTalkingGateway("username", "apiKey");
            gateway.sendMessage(recipient, message);
        }
        [Route("call")]
        public void getCall()
        {
            //use your africastalking phonenumber

            string from = "+25471108YYZZ";
            //uncomment if its to be used in ussd
            //string to = serverModels.phoneNumber;
            string to = "+254716XXYYZZ ";

            AfricasTalkingGateway gateway = new AfricasTalkingGateway("username", "apiKey");

            gateway.call(from, to);
        }
        [Route("airtime")]
        public void getAirtime()
        {
            // Specify an array list to hold numbers to receive airtime
            ArrayList AirtimeRecipientsList = new ArrayList();

            // Declare hashtable to hold the first number
            // Please ensure you include the country code for phone numbers (+254 for Kenya in this case)
            // Specify the country currency and the amount as shown below (KES for Kenya in this case)

            Hashtable rec1 = new Hashtable();
            rec1["phoneNumber"] = "+254722XXXYYY";
            rec1["amount"] = "KES XXX";

            // Add recipient to list
            AirtimeRecipientsList.Add(rec1);

            // Declare hashtable to hold the another number
            Hashtable rec2 = new Hashtable();
            rec2["phoneNumber"] = "+254722XXXYYY";
            rec2["amount"] = "KES XXX";

            // Add recipient to list
            AirtimeRecipientsList.Add(rec2);

            // Create a new instance of our awesome gateway class
            AfricasTalkingGateway gateway = new AfricasTalkingGateway("MyAfricasTalking_Username", "MyAfricasTalking_APIKey");
            gateway.sendAirtime(AirtimeRecipientsList);
        }
        }

    }

