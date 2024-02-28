using RestSharp;
using System.Net;
using Newtonsoft;
using Newtonsoft.Json;

namespace FakeAPI.FakeAPI
{

    
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        FakeAPI service = new FakeAPI();

        [Test]
        public void TestGET()
        {
            RestResponse response = service.GET();
            Assert.IsNotNull(response);

            string content = response.Content;

            List<Product> p1 = JsonConvert.DeserializeObject<List<Product>>(content);



            Assert.AreEqual("Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops", p1[0].Title);
        }

        /*        [Test]
        public void TestGET1()
        {

            RestResponse response = service.GET1();

            Assert.IsNotNull(response);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            string id = response.Content.Split(",")[0].Split(":")[1];
            Assert.AreEqual(id,"1");

        }*/

        [Test]
        public void TestGET1()
        {

            RestResponse response = service.GET1();
            Assert.IsNotNull(response);
            

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);



            string content = response.Content;

            Product p1 = JsonConvert.DeserializeObject<Product>(content);
            Assert.AreEqual("Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops", p1.Title);

            Assert.AreEqual("109.95", p1.Price);


        }




        [Test]
        public void TestPOST()
        {

            RestResponse response = service.POST();

            Assert.IsNotNull(response);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        }
        [Test]
        public void TestPUT()
        {
            

            RestResponse response = service.PUT();

            Assert.IsNotNull(response);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        }

        [Test]
        public void TestPATCH()
        {
            

            RestResponse response = service.PATCH();

            Assert.IsNotNull(response);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        }


        [Test]
        public void TestDELETE()
        {
           

            RestResponse response = service.DELETE();

            Assert.IsNotNull(response);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        }
    }
}