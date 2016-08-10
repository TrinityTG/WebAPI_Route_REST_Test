using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Inventory.WebAPI.Tests.RouteTests
{
    [TestClass]
    public class OrdersRouteTests
    {
        // Get

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Orders_GET()
        {             
            await RouteTest.Get("api/Orders");
        }

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Orders_id_GET()
        {
            await RouteTest.Get("api/Orders/0");
        }

        // Post

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Orders_POST()
        {
            await RouteTest.Post("api/Orders/");
        }

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Orders_PUT()
        {
            await RouteTest.Put("api/Orders/");
        }

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Orders_DELETE()
        {
            await RouteTest.Delete("api/Orders/0");
        }
    }
}
