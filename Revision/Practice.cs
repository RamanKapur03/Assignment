using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    public class Practice
    {
        static string baseUrl = "https://fakestoreapi.com/";
        RestClient client = new RestClient(baseUrl);
        public RestResponse GET()
        {
            
            RestRequest request = new RestRequest("products", Method.Get);
            RestResponse response = new RestResponse();
            response = client.Execute(request);
            return response;
        }

        public RestResponse POST()
        {

            RestRequest request = new RestRequest("products", Method.Post);
            string json = "{\"id\": 99,\"title\": \"Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops\",\"price\": 109.95,\"description\": \"Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday\",\"category\": \"men's clothing\",\"image\": \"https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg\",\"rating\": {\"rate\": 3.9,\"count\": 120    }}";
            request.AddBody(json);
            RestResponse response = new RestResponse();
            response = client.Execute(request);
            return response;

        }
    }
}
