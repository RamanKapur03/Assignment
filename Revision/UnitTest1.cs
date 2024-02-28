using RestSharp;
using System.Net;

namespace Revision
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        Practice service = new Practice();

        [Test]
        public void GET_TEST()
        {
            
            RestResponse response = service.GET();
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [Test]
        public void POST_TEST()
        {
            RestResponse response = service.POST();
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK,response.StatusCode);
        }

    }
}