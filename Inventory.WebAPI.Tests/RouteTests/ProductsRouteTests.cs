using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Inventory.WebAPI.Tests.RouteTests
{
    [TestClass]
    public class ProductsRouteTests
    {
        // Get

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Products_GET()
        {             
            await RouteTest.Get("api/Products");
        }

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Products_id_GET()
        {
            await RouteTest.Get("api/Products/0");
        }

        // Post

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Products_POST()
        {
            await RouteTest.Post("api/Products/");
        }

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Products_PUT()
        {
            await RouteTest.Put("api/Products/");
        }

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Products_DELETE()
        {
            await RouteTest.Delete("api/Products/0");
        }
    }
}
