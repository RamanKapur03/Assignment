using RestSharp;
using System.Net;
using System.Net.NetworkInformation;

namespace Movie.Movie
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void TestGETBOOK()
        {
            movie movie = new movie();

            RestResponse response = movie.GETBOOK();

            Assert.IsNotNull(response);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [Test]
        public void TestGETBOOK1()
        {
            movie movie = new movie();
            RestResponse response = movie.GETBOOK1();
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            String exep = response.Content.Split(",")[1].Split(":")[1].Split("}")[0];
            exep = exep.Replace("\"", "");
            Assert.AreEqual("The Fellowship Of The Ring", exep);
        }

        [Test]
        public void TestGETMOVIE()
        {
            movie movie = new movie();

            RestResponse response = movie.GETMOVIE();
            Assert.IsNotNull(response);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);


        }

        [Test]
        public void TestGETMOVIE1()
        {
            movie movie = new movie();

            RestResponse response = movie.GETMOVIE1();
            Assert.IsNotNull(response);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            Assert.AreEqual("application/json", response.ContentType);

            string expec = response.Content.Split(",")[1].Split(":")[1];
            expec = expec.Replace("\"", "");
            Assert.AreEqual("The Lord of the Rings Series",expec);



        }
    }
}