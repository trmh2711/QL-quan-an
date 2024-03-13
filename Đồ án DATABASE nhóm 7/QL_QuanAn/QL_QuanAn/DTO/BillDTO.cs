using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAn.DTO
{
    public class BillDTO
    {
        public int ID { get; set; }
        public int IDRoom { get; set; }
        public int IDAccount { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public double roomPrice { get; set; }
        public double TotalPrice { get; set; }
        public double lastPrice { get; set; }
        public int DisCount { get; set; }
        public int Status { get; set; }

        public BillDTO() { }
        public BillDTO(BillDTO bill)
        {
            this.ID = bill.ID;
            this.IDRoom = bill.IDRoom;
            this.IDAccount = bill.IDAccount;
            this.DateCheckIn= bill.DateCheckIn;
            this.DateCheckOut= bill.DateCheckOut;
            this.roomPrice= bill.roomPrice;
            this.TotalPrice= bill.TotalPrice;
            this.lastPrice= bill.lastPrice;
            this.DisCount= bill.DisCount;
            this.Status= bill.Status;
        }

        public BillDTO(DataRow row)
        {
            this.ID= Convert.ToInt32(row["id"]);
            this.IDRoom = Convert.ToInt32(row["idroom"]);
            this.IDAccount = Convert.ToInt32(row["idAccount"]);
            this.DateCheckIn = Convert.ToDateTime(row["dateCheckIn"]);
            this.DateCheckOut = row["dateCheckOut"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["dateCheckOut"]);
            this.roomPrice = Convert.ToDouble(row["roomfe"]);
            this.TotalPrice = Convert.ToDouble(row["totalPrice"]);
            this.lastPrice = Convert.ToDouble(row["lastprice"]);
            this.DisCount = Convert.ToInt32(row["discount"]);
            this.Status= Convert.ToInt32(row["status"]);
        }
    }
}
