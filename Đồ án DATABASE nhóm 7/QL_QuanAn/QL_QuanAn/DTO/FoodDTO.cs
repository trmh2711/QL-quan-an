using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAn.DTO
{
    internal class FoodDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int IDCategory { get; set; }
        public double Price { get; set; }
        public int IsDelete { get; set; }

        public FoodDTO() { }
        public FoodDTO(DataRow row)
        {
            this.ID= Convert.ToInt32(row["id"]);
            this.Name= Convert.ToString(row["name"]);
            this.IDCategory= Convert.ToInt32(row["idCategory"]);
            this.Price = Convert.ToDouble(row["price"]);
            this.IsDelete = Convert.ToInt32(row["isDelete"]);
        }
    }
}
