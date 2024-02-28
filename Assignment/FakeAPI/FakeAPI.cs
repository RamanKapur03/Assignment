using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace FakeAPI.FakeAPI
{
    public class FakeAPI
    {
        private static string baseURl = "https://fakestoreapi.com/";
        RestClient client = new RestClient(baseURl);
        public RestResponse GET()
        {
            

            RestRequest request = new RestRequest("products",Method.Get);

            RestResponse response = new RestResponse();

            response = client.Execute(request);
            return response;
        }

        public RestResponse GET1()
        {
           

            RestRequest request = new RestRequest("products/1", Method.Get);

            RestResponse response = new RestResponse();

            response = client.Execute(request);
            return response;
        }

        public RestResponse POST()
        {
            

            RestRequest request = new RestRequest("products", Method.Post);
            string json = "{\"id\": 99,\"title\": \"Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops\",\"price\": 109.95,\"description\": \"Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday\",\"category\": \"men's clothing\",\"image\": \"https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg\",\"rating\": {\"rate\": 3.9,\"count\": 120}}";
            RestResponse response = new RestResponse();

            response = client.Execute(request);
            return response;
        }

        public RestResponse PUT()
        {
           

            RestRequest request = new RestRequest("products/4", Method.Put);
            string json = "{\"id\": 1,\"title\": \"Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops\",\"price\": 109.95,\"description\": \"Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday\",\"category\": \"men's clothing\",\"image\": \"https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg\",\"rating\": {\"rate\": 3.9,\"count\": 120}}";
            request.AddBody(json);
            RestResponse response = new RestResponse();

            response = client.Execute(request);
            return response;
        }

        public RestResponse PATCH()
        {
            

            RestRequest request = new RestRequest("products/2", Method.Patch);
            string json = "{\"id\": 1,\"price\": 109.95,\"category\": \"men's clothing\",\"image\": \"https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg\",\"rating\": {\"rate\": 3.9,\"count\": 120}}";
            request.AddBody(json);
            RestResponse response = new RestResponse();

            response = client.Execute(request);
            return response;
        }

        public RestResponse DELETE()
        {
            

            RestRequest request = new RestRequest("products/1", Method.Delete);
            RestResponse response = new RestResponse();

            response = client.Execute(request);
            return response;
        }
    }
}
