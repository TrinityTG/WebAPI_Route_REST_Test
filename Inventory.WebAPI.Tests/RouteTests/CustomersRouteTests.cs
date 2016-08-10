using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Inventory.WebAPI.Tests.RouteTests
{
    [TestClass]
    public class CustomersRouteTests
    {
        // GET

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Customers_GET()
        {
            // PASS
            //await RouteTest.Get("api/Customers");  

            // FAIL
            await RouteTest.Get("api/fail");   
        }

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Customers_id_GET()
        {
            await RouteTest.Get("api/Customers/0");
        }

        // POST

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Customers_POST()
        {
            await RouteTest.Post("api/Customers/");
        }

        // PUT

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Customers_PUT()
        {
            await RouteTest.Put("api/Customers/");
        }

        // DELETE

        [TestMethod]
        [TestCategory("Route Tests")]
        public async Task Customers_DELETE()
        {
            await RouteTest.Delete("api/Customers/0");
        }
    }
}
