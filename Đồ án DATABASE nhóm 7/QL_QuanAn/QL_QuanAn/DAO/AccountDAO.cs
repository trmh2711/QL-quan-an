using QL_QuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAn.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            set { AccountDAO.Instance = value; }
        }

        public AccountDAO() { }

        public List<AccountDTO> getAll()
        {
            string query = "EXEC USP_LAYACCOUNT ";
            List<AccountDTO> accounts = getAccount(query);
            return accounts;
        }
        public AccountDTO getAccountByID(int id)
        {
            string query = "EXEC USP_LAYACCOUNTBYID "+ id;
            AccountDTO account = getAccount(query).FirstOrDefault();
            return account;
        }

        public List<AccountDTO> searchAccount(string txt)
        {
            string query = "EXEC USP_TIMACCOUNT " + txt;
            List<AccountDTO> accounts = getAccount(query);
            return accounts;
        }
        public AccountDTO getAccountByUName(string uName)
        {
            string query = "EXEC USP_TIMACCOUNTU " + uName;
            AccountDTO acc = getAccount(query).FirstOrDefault();
            return acc;
        }
        public void addAccount(string tk, string mk, int type)
        {
            string query = $"EXEC USP_TAOACCOUNT {tk}, {mk}, {type}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void deleteAccount(int id)
        {
            string query = $"EXEC USP_XOAACCOUNT {id}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<AccountDTO> getAccount(string query)
        {
            List<AccountDTO> accounts = new List<AccountDTO>();
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AccountDTO account = new AccountDTO(row);
                accounts.Add(account);
            }
            return accounts;
        }
    }
}
