using Microsoft.SqlServer.Server;
using QL_QuanAn.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAn.DAO
{
    internal class FoodCategoryDAO
    {
        private static FoodCategoryDAO instance;
        public static FoodCategoryDAO Instance
        {
            get { if (instance == null) instance = new FoodCategoryDAO(); return FoodCategoryDAO.instance; }
            set { FoodCategoryDAO.Instance = value; }
        }

        public FoodCategoryDAO() { }
        public List<FoodCategoryDTO> getAll()
        {
            string query = "EXEC USP_LAYFOODCATEGORY";
            List<FoodCategoryDTO> foodCategoryDTOs = getFoodCategories(query);
            return foodCategoryDTOs;
        }
        public FoodCategoryDTO getFoodCateByID(int id)
        {
            string query = "EXEC USP_LAYFOODCATETHEOID " + id;
            FoodCategoryDTO foodCategoryDTO = getFoodCategories(query).FirstOrDefault();
            return foodCategoryDTO;
        }

        public List<FoodCategoryDTO> searchFoodCategory(string txt)
        {
            string query = "EXEC USP_TIMFOODCATE "+ txt;
            List<FoodCategoryDTO> foodCategoryDTOs = getFoodCategories(query);
            return foodCategoryDTOs;
        }
        public void addFoodCategory(string name)
        {
            string query = $"EXEC USP_THEMCATEGORY N'{name}'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void editFoodCategory(int id, string name)
        {
            string query = $"EXEC USP_SUACATEGORY {id}, N'{name}'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void deleteFoodCategory(int id)
        {
            string query = $"EXEC USP_XOACATEGORY {id}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<FoodCategoryDTO> getFoodCategories(string query)
        {
            List<FoodCategoryDTO> foodCategoryDTOs = new List<FoodCategoryDTO>();
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow row in data.Rows)
            {
                FoodCategoryDTO bil = new FoodCategoryDTO(row);
                foodCategoryDTOs.Add(bil);
            }
            return foodCategoryDTOs;
        }


    }
}
