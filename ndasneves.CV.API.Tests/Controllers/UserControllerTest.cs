using Microsoft.VisualStudio.TestTools.UnitTesting;
using ndasneves.CV.API.Models;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ndasneves.CV.API.Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        [TestMethod]
        public void Get()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiUrl"]);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("user").Result;
            Console.WriteLine("RequestUri : " + response.RequestMessage.RequestUri);
            Assert.AreEqual(true, response.IsSuccessStatusCode);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var userInfo = response.Content.ReadAsAsync<UserInfo>().Result;
            Assert.AreEqual("Nicolas", userInfo.FirstName);
            Assert.AreEqual("das Neves", userInfo.LastName);
            Assert.AreEqual(new DateTime(1988, 10, 01), userInfo.BirthDate);
        }
    }
}
