using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAn.DTO
{
    internal class FoodCategoryDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int IsDelete { get; set; }
        public FoodCategoryDTO() { }

        public FoodCategoryDTO(DataRow row)
        {
            this.ID= Convert.ToInt32(row["id"]);
            this.Name= Convert.ToString(row["name"]);
            this.IsDelete = Convert.ToInt32(row["isDelete"]);
        }
    }
}
