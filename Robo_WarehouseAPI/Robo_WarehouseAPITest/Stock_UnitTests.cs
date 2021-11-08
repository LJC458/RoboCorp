using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Robo_WarehouseAPI.Models;
using Robo_WarehouseAPI.Controllers;
using Xunit;

namespace Robo_WarehouseAPITest
{
    public class Stock_UnitTests
    {
        private readonly StockContext _context;

        [Fact]
        public void tStock_GET()
        {
            var actionResponse = _context.Stock.FromSqlRaw("Select * FROM [dbo].[Test]").ToString();
            Assert.Equal("Hello World!", actionResponse);

            //TODO Fix Test
        }
    }
}
