using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System;
using System.Threading.Tasks;

namespace Inventory.WebAPI.Tests.RouteTests
{
    public class RouteTest
    {
        private static string BaseAddress = "http://localhost:24442/"; // Change this value based on your settings
        public static async Task Get(string uri)
        {
            ProcessHttpResponse(await TestRoute(HttpMethod.Get, uri), uri);
        }

        public static async Task Post(string uri)
        {
            ProcessHttpResponse(await TestRoute(HttpMethod.Post, uri), uri);
        }

        public static async Task Put(string uri)
        {
            ProcessHttpResponse(await TestRoute(HttpMethod.Put, uri), uri);
        }

        public static async Task Delete(string uri)
        {
            ProcessHttpResponse(await TestRoute(HttpMethod.Delete, uri), uri);
        }

        private static void ProcessHttpResponse(HttpResponseMessage response, string uri)
        {
            Assert.IsFalse(response.StatusCode == HttpStatusCode.NotFound, ErrorMessage(response, uri));
            Assert.IsFalse(response.StatusCode == HttpStatusCode.MethodNotAllowed, ErrorMessage(response, uri));
        }

        private static string ErrorMessage(HttpResponseMessage response, string uri)
        {
            return "\r\n" + response.ReasonPhrase + "\r\n" + uri;
        }

        private static async Task<HttpResponseMessage> TestRoute(HttpMethod method, string uri)
        {
            using (var client = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true }))
            {
                HttpResponseMessage response = new HttpResponseMessage();

                client.BaseAddress = new Uri(BaseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                if (method == HttpMethod.Get)
                {
                    response = await client.GetAsync(uri);
                }

                if (method == HttpMethod.Post)
                {
                    response = await client.PostAsync(uri, new StringContent(""));
                }

                if (method == HttpMethod.Put)
                {
                    response = await client.PostAsync(uri, new StringContent(""));
                }

                if (method == HttpMethod.Delete)
                {
                    response = await client.DeleteAsync(uri);
                }

                return response;
            }
        }
    }
}

