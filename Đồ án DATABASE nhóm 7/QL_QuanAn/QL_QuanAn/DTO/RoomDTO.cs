using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAn.DTO
{
    internal class RoomDTO
    {
        public  int ID { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public string Status { get; set; }
        public int IsDelete { get; set; }

        public RoomDTO() { }
        public RoomDTO(DataRow row)
        {
            this.ID= Convert.ToInt32(row["id"]);
            this.Name= Convert.ToString(row["name"]);
            this.price = Convert.ToDouble(row["price"]);
            this.Status= Convert.ToString(row["status"]);
            this.IsDelete = Convert.ToInt32(row["isDelete"]);
        }
    }
}
