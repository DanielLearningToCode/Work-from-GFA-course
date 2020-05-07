using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using REST;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;

        public IntegrationTests(WebApplicationFactory<Startup> factory)
        {
            this.factory = factory;
        }

        /*        [Theory]
                [InlineData(1,2)]
                [InlineData(10, 20)]
                public async Task Doubling_CorrectInput_Success(int input, int expected)
                {
                    HttpResponseMessage responseMessage = await factory.CreateClient().GetAsync($"/doubling/{input}");
                    string json = responseMessage.Content.ReadAsStringAsync().Result;
                    Dictionary<string, int> dict = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);
                    //int actual = dict["result"];
                    dict.TryGetValue("result", out int actual);
                    Assert.Equal(expected, actual);
                    responseMessage.EnsureSuccessStatusCode();
                }*/
        /*        [Fact]
                public async Task Doubling_NullInput()
                {
                    HttpResponseMessage responseMessage = await factory.CreateClient().GetAsync($"/doubling/{null}");
                    Assert.Equal(HttpStatusCode.BadRequest, responseMessage.StatusCode);
                }
        */
        /*[Fact]
        public async Task Greeter_CorrectInput_Success()
        {
            HttpResponseMessage responseMessage = await factory.CreateClient().GetAsync($"/greeter?Name=Pepa&Title=Student");
            string json = responseMessage.Content.ReadAsStringAsync().Result;
            Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            dict.TryGetValue("welcome_message", out string actual);
            string expected = "Oh, hi there Pepa, my dear Student!";
            Assert.Equal(expected, actual);
        }*/
        /*        [Fact]
                public async Task Greeter_MissingInput()
                {
                    HttpResponseMessage responseMessage = await factory.CreateClient().GetAsync("/greeter");
                    string json = responseMessage.Content.ReadAsStringAsync().Result;
                    Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                    dict.TryGetValue("error", out string actual);
                    string expected = "Please provide a name and a title!";
                    Assert.Equal(expected, actual);
                    Assert.Equal(HttpStatusCode.BadRequest, responseMessage.StatusCode);
                }*/
        /*
                [Theory]
                [InlineData("kuty", "kutya")]
                [InlineData("Pep", "Pepa")]
                public async Task AppendA_CorrectInput_Success(string appendable, string expected)
                {
                    HttpResponseMessage responseMessage = await factory.CreateClient().GetAsync($"/appenda/{appendable}");
                    string json = responseMessage.Content.ReadAsStringAsync().Result;
                    Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>> (json);
                    dict.TryGetValue("appended", out string actual);
                    Assert.Equal(expected, actual);
                    Assert.Equal(HttpStatusCode.OK, responseMessage.StatusCode);
                }*/
        /*
                [Fact]
                public async Task AppendA_NullInput()
                {
                    HttpResponseMessage responseMessage = await factory.CreateClient().GetAsync("/appenda");
                    Assert.Equal(HttpStatusCode.NotFound, responseMessage.StatusCode);
                }*/

        /*        [Theory]
                [InlineData("sum", 5, 15)]
                [InlineData("factor", 3, 6)]
                public async Task DoUntil_CorrectInput_Success(string act, int until, int expected)
                {
                    //string content = JsonConvert.SerializeObject(new { number = until });    // contents of the HttpPost body in json
                    Number num = new Number() { Act = act, Until = until };
                    var numJson = JsonConvert.SerializeObject(num);
                    var httpContent = new StringContent(numJson, Encoding.UTF8, "application/json");
                    HttpResponseMessage responseMessage = await factory.CreateClient().PostAsync($"dountil/{act}", httpContent);
                    string json = responseMessage.Content.ReadAsStringAsync().Result;
                    Dictionary<string, int> dict = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);
                    dict.TryGetValue("result", out int actual);
                    Assert.Equal(expected, actual);
                }*/
        /*
                [Fact]
                public async Task DoUntil_MissingInput()
                {
                    HttpResponseMessage responseMessage = await factory.CreateClient().PostAsync("dountil/sum", null);
                    // string json = JsonConvert.SerializeObject(responseMessage.Content);
                    //string json = responseMessage.Content.ReadAsStringAsync().Result;
                    Assert.Equal(HttpStatusCode.BadRequest, responseMessage.StatusCode);
                }*/
        //[Fact]
        [Theory]
        [InlineData(new int[] { 1, 5, 7 }, "sum", 13)]
        [InlineData(new int[] { 1, 5, 7 }, "multiply", 35)]
        [InlineData(new int[] { 1, 5, 7 }, "doubleAll", new int[] { 2, 10, 14 })]  // does not work.
        public async Task Arrays_CorrectInput_Success(int[] numbers, string what, dynamic expected)
        {
            //int[] numbers = { 1, 5, 6 };
            //string numbersJson = JsonConvert.SerializeObject(numbers);
            //string what = "sum";
            //string whatJson = JsonConvert.SerializeObject(what);
            //ArrayHandler handler = new ArrayHandler() { Numbers = numbers, What = what };
            string handlerJson = JsonConvert.SerializeObject(new { Numbers = numbers, What = what });
            StringContent httpContent = new StringContent(handlerJson, Encoding.UTF8, "application/json");
            //StringContent httpContent = new StringContent(numbersJson + "," + whatJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await factory.CreateClient().PostAsync("/arrays", httpContent);
            string resultJson = responseMessage.Content.ReadAsStringAsync().Result;
            Dictionary<string, dynamic> dict = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(resultJson);
            dict.TryGetValue("result", out dynamic actual);
            //int res = Convert.ToInt32(actual);
            Assert.Equal(expected, actual);   
        }


    }
}
