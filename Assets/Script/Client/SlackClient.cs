using RestSharp;
using UnityEngine;

namespace Assets.Script.Client
{
    public class SlackClient : MonoBehaviour
    {
        public static void SendSlackMsg(string text)
        {
            var client = new RestClient("https://slack.com/api/chat.postMessage");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Authorization", "Bearer xoxb-2057794773027-2076539941845-si2kiGtvB9hlF0YTLsG0UBHl");
            request.AddParameter("text", text);
            request.AddParameter("channel", "C022AQNV95G");
            IRestResponse response = client.Execute(request);
            print(response.StatusCode);
        }
    }
}
