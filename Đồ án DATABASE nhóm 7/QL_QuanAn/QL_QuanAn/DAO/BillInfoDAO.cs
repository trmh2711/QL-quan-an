using QL_QuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAn.DAO
{
    internal class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            set { BillInfoDAO.Instance = value; }
        }

        public BillInfoDAO() { }

        public List<BillInfoDTO> getAll()
        {
            string query = "EXEC USP_LAYBILLINFO";
            List<BillInfoDTO> BillInfos = getBillInfos(query);
            return BillInfos;
        }

        public List<BillInfoDTO> getBillInfoByIdBill(int idbill)
        {
            string query = "EXEC USP_LAYBILLINFOTHEOBILL " + idbill;
            List<BillInfoDTO> BillInfos = getBillInfos(query);
            return BillInfos;
        }

        public void addBillInfo(int idBill, int idfood, int count)
        {
            string query = "EXEC USP_GOIMON " + idBill + ", " + idfood + ", "+ count;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public List<BillInfoDTO> getBillInfos(string query)
        {
            List<BillInfoDTO> BillInfos = new List<BillInfoDTO>();
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow row in data.Rows)
            {
                BillInfoDTO BillInfo = new BillInfoDTO(row);
                BillInfos.Add(BillInfo);
            }
            return BillInfos;
        }
    }
}
