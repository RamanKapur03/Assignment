using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Movie
{
    class movie
    {
        private static string baseURL = "https://the-one-api.dev/v2/";
        RestClient client = new RestClient(baseURL);
        string bToken = "1bH4yPoJRzWQutloMlod";



        public RestResponse GETBOOK()
        {
            

            RestRequest request = new RestRequest("book", Method.Get);

            RestResponse response = new RestResponse();
            response = client.Execute(request);

            return response;
        }
        public RestResponse GETBOOK1()
        {
            

            RestRequest request = new RestRequest("book/5cf5805fb53e011a64671582", Method.Get);

            RestResponse response = new RestResponse();
            response = client.Execute(request);


            return response;
        }

        public RestResponse GETMOVIE()
        {
         
            //client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", "1bH4yPoJRzWQutloMlod"));
            RestRequest request = new RestRequest("movie",Method.Get);
            //request.AddHeader("Authorization", "Bearer " + "1bH4yPoJRzWQutloMlod");

            request.AddHeader("Authorization","Bearer "+bToken);
            RestResponse response = new RestResponse();

            response = client.Execute(request);
            return response;
        }

        public RestResponse GETMOVIE1()
        {
            
            client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", "1bH4yPoJRzWQutloMlod"));
            RestRequest request = new RestRequest("movie/5cd95395de30eff6ebccde56", Method.Get);
            //request.AddHeader("Authorization", "Bearer " + "1bH4yPoJRzWQutloMlod");
            RestResponse response = new RestResponse();

            response = client.Execute(request);
            return response;
        }


    }
}
