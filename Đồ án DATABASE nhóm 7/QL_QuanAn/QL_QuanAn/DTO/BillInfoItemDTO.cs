using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAn.DTO
{
    internal class BillInfoItemDTO
    {
        public string Name { get; set; }
        public double price { get; set; }
        public int count { get; set; }
        public double total { get; set; }
        public BillInfoItemDTO() { }
        public BillInfoItemDTO(DataRow row)
        {
            this.Name= Convert.ToString(row["Name"]);
            this.price= Convert.ToDouble(row["price"]);
            this.count= Convert.ToInt32(row["count"]);
            this.total= Convert.ToDouble(row["total"]);
        }
    }
}
