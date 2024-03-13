using QL_QuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QL_QuanAn.DAO
{
    internal class RoomDAO
    {
        private static RoomDAO instance;
        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance; }
            set { RoomDAO.Instance = value; }
        }

        public RoomDAO() { }

        public List<RoomDTO> getAll()
        {
            string query = "EXEC USP_LAYROOM";
            List<RoomDTO> RoomDTOs = getTables(query);
            return RoomDTOs;
        }
        public RoomDTO getRoomByID(int id)
        {
            string query = "EXEC USP_LAYROOMTHEOID "+ id;
            RoomDTO RoomDTO = getTables(query).FirstOrDefault();
            return RoomDTO;
        }

        public List<RoomDTO> searchRoom(string txt)
        {
            string query = "EXEC USP_TIMROOM " + txt;
            List<RoomDTO> RoomDTOs = getTables(query);
            return RoomDTOs;
        }

        public void addRoom(string name, double price)
        {
            string query = $"EXEC USP_THEMROOM N'{name}', {price}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void editRoom(int id, string name, double price)
        {
            string query = $"EXEC USP_SUAROOM {id}, N'{name}', {price}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void deleteRoom(int id)
        {
            string query = $"EXEC USP_XOAROOM {id}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<RoomDTO> getTables(string query)
        {
            List<RoomDTO> RoomDTOs = new List<RoomDTO>();
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RoomDTO FoodDTO = new RoomDTO(row);
                RoomDTOs.Add(FoodDTO);
            }
            return RoomDTOs;
        }
    }
}
