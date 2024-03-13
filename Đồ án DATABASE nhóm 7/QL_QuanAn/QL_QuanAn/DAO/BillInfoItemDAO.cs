using QL_QuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAn.DAO
{
    internal class BillInfoItemDAO
    {
        private static BillInfoItemDAO instance;
        public static BillInfoItemDAO Instance
        {
            get { if (instance == null) instance = new BillInfoItemDAO(); return BillInfoItemDAO.instance; }
            set { BillInfoItemDAO.Instance = value; }
        }

        public BillInfoItemDAO() { }

        public List<BillInfoItemDTO> getAll(int id)
        {
            string query = "EXEC USP_LAYBILLINFOITEM " + id;
            List<BillInfoItemDTO> BillInfos = getBillInfoItems(query);
            return BillInfos;
        }


        public List<BillInfoItemDTO> getBillInfoItems(string query)
        {
            List<BillInfoItemDTO> BillInfoItems = new List<BillInfoItemDTO>();
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow row in data.Rows)
            {
                BillInfoItemDTO BillInfoItem = new BillInfoItemDTO(row);
                BillInfoItems.Add(BillInfoItem);
            }
            return BillInfoItems;
        }
    }
}

