using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class service
    {
        private static string baseURL = "";
        RestClient client = new RestClient(baseURL);

        public RestResponse GET()
        {
            RestRequest request = new RestRequest("",Method.Get);

            RestResponse response = new RestResponse();
            
            response = client.Execute(request);

            return response;
        }

        public RestResponse POST()
        {
            RestRequest request = new RestRequest("products",Method.Post);
            request.AddHeader("Authorization", "Bearer " + "1bH4yPoJRzWQutloMlod");
            string json = "ufgrhfgbr";
            request.AddBody(json);
            RestResponse response = new RestResponse();
            response = client.Execute(request);
            return response;
        }

        public RestResponse PUT()
        {
            RestRequest request = new RestRequest("products", Method.Put);
            String json = "";
            request.AddBody(json);
            RestResponse response = new RestResponse();

            response = client.Execute(request);
            return response;
        }
    }
}
