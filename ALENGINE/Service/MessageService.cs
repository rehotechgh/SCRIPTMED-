using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace easyply.Service
{
    public class MessageService
    {
        //public async Task<String> SendSms(string contact, string message)
        //{
        //    var _contact = new string(contact.ToCharArray().Where(c => char.IsDigit(c)).ToArray());
        //    //var endPoint = $"https://apps.mnotify.net/smsapi?key=TOdkRPCFwgfCbusbKpMqyYnSn&to={contact}&msg={message}&sender_id=AMSEROIL";
        //   var endPoint = $"https://sms.arkesel.com/sms/api?action=send-sms&api_key=OjZqeWo4QlFOSEc5V2xwb2g==&to={contact}&from=AMSEROIL&sms={message}";
        //    //https://sms.arkesel.com/sms/api?action=send-sms&api_key=OjZqeWo4QlFOSEc5V2xwb2g==&to=PhoneNumber&from=SenderID&sms=YourMessage
        //    HttpClient httpClient = new HttpClient();
        //    HttpClient client = httpClient;
        //    var response = await client.GetAsync(endPoint);
        //    return "Success";
        //}

        public async Task SendSMS(string phoneNumber, string message)
        {
            if (phoneNumber is not null && message is not null)
            {
                var request = new { sender = "AGMH", message = message, recipients = new string[] { phoneNumber } };
                var json = JsonConvert.SerializeObject(request);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var endPoint = $"https://sms.arkesel.com/api/v2/sms/send";
                using HttpClient client = new();
                client.DefaultRequestHeaders.Add("api-key", "OjZqeWo4QlFOSEc5V2xwb2g=");
                var response = await client.PostAsync(endPoint, data);
            }
        }
    }
}

