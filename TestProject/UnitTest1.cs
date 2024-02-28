using RestSharp;
using System.Net;
using Newtonsoft;
using Newtonsoft.Json;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGET()
        {
            service service = new service();
            RestResponse response = service.GET();

            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            Assert.AreEqual("application/json", response.ContentType);

            List<Temp> t1 = JsonConvert.DeserializeObject<List<Temp>>(response.Content);

            Assert.AreEqual("", t1[0].Name);
            
        }
    }
}