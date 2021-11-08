using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Robo_WarehouseAPI.Models
{
    public class Stock
    {
        public Int16 Stock_Code { get; set; }
        public string Stock_Name { get; set; }
        public string Stock_Desc { get; set; }
    }
}
