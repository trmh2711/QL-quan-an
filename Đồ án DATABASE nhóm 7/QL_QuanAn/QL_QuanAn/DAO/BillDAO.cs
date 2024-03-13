using QL_QuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAn.DAO
{
    internal class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            set { BillDAO.Instance = value; }
        }

        public BillDAO() { }

        // lấy toàn bộ bill 
        public List<BillDTO> getAll()
        {
            string query = "EXEC USP_LAYBILL";
            List<BillDTO> billDTOs = getBills(query);
            return billDTOs;
        }

        //lấy thông tin của một bill
        public BillDTO getBillById(int id)
        {
            string query = "EXEC USP_LAYBILLTHEOID "+ id;
            BillDTO billDTO = getBills(query).FirstOrDefault();
            return billDTO;
        }

        public List<BillDTO> getBills(string query)
        {
            List<BillDTO> billDTOs = new List<BillDTO>();
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow row in data.Rows)
            {
                BillDTO billDTO = new BillDTO(row);
                billDTOs.Add(billDTO);
            }
            return billDTOs;
        }

        public List<BillDTO> fillterBills(DateTime start, DateTime end)
        {
            string query = $"EXEC USP_LOCBILL '{start}', '{end}'";
            List<BillDTO> billDTOs = getBills(query);
            return billDTOs;
        }

        // lấy bill chưa thanh toán của bàn
        public BillDTO getUnpaidBill(int idroom)
        {
            string query1 = "EXEC USP_LAYBILLCHUATHANHTOAN " + idroom;
            BillDTO billDTO = getBills(query1).FirstOrDefault();
            if(billDTO != null)
            {
                string query2 = "EXEC USP_TINHROOMFE " + billDTO.ID;
                DataProvider.Instance.ExecuteNonQuery(query2);
                string query3 = "EXEC USP_TINHTOTALPRICE " +  billDTO.ID;
                DataProvider.Instance.ExecuteNonQuery(query3);
            }
            billDTO = getBills(query1).FirstOrDefault();
            return billDTO;
        }

        // trả phòng 
        public void traPhong(int id)
        {
            string query = "EXEC USP_TRAPHONG " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
            String query2 = "exec capnhatLastPrice " +id;
            DataProvider.Instance.ExecuteNonQuery(query2);
        }

        // đặt phòng 
        public void taoBill(int idRoom, int idAcc)
        {
            string query = "insert into bill(idRoom,idAccount) values ("+idRoom+", "+idAcc+")";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void updateDiscount(int id, int value)
        {
            string query = "EXEC USP_CAPNHATDISCOUNT "+id+", "+value+"";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}

