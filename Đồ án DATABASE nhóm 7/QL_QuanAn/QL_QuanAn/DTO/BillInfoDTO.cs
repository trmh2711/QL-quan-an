using QL_QuanAn.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAn.DTO
{
    internal class BillInfoDTO
    {
        public int ID { get; set; }
        public int IDBill { get; set; }
        public int IDFood { get; set; }
        public int Count { get; set; }
        public BillInfoDTO () { }
        public BillInfoDTO(DataRow row)
        {
            this.ID= Convert.ToInt32(row["id"]);
            this.IDBill= Convert.ToInt32(row["idBill"]);
            this.IDFood= Convert.ToInt32(row["idFood"]);
            this.Count= Convert.ToInt32(row["count"]);
        }
        
    }
}
