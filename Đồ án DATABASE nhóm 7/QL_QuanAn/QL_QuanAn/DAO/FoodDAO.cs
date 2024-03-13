using QL_QuanAn.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace QL_QuanAn.DTO
{
    internal class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            set { FoodDAO.Instance = value; }
        }

        public FoodDAO() { }

        public List<FoodDTO> getAll()
        {
            string query = "EXEC USP_LAYFOOD";
            List<FoodDTO> FoodDTOs = getFood(query);
            return FoodDTOs;
        }
        public List<FoodDTO> getFoodByIdCategory(int idcate)
        {
            string query = "EXEC USP_LAYFOODTHEOIDCATE " + idcate;
            List<FoodDTO> FoodDTOs = getFood(query);
            return FoodDTOs;
        }

        public FoodDTO getFoodByID(int id)
        {
            string query = "EXEC USP_LAYFOODTHEOID " + id;
            FoodDTO FoodDTO = getFood(query).FirstOrDefault();
            return FoodDTO;
        }
        public List<FoodDTO> searchFood(string txt)
        {
            string query = "EXEC USP_TIMFOOD "+ txt;
            List<FoodDTO> FoodDTOs = getFood(query);
            return FoodDTOs;
        }

        public void addFood(string name, int idcate, double price)
        {
            string query = $"EXEC USP_THEMFOOD N'{name}', {idcate}, {price}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void editFood(int id, string name, int idcate, double price)
        {
            string query = $"EXEC USP_SUAFOOD {id}, N'{name}', {idcate}, {price}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void deleteFood(int id)
        {
            String query = $"EXEC USP_XOAFOOD {id}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<FoodDTO> getFood(string query)
        {
            List<FoodDTO> FoodDTOs = new List<FoodDTO>();
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow row in data.Rows)
            {
                FoodDTO FoodDTO = new FoodDTO(row);
                FoodDTOs.Add(FoodDTO);
            }
            return FoodDTOs;
        }
    }
}
