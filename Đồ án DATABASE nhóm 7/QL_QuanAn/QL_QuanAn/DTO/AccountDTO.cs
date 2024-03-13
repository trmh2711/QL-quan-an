using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAn.DTO
{
    public class AccountDTO
    {
        public int ID { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }
        public AccountDTO() { }
        public AccountDTO(DataRow row)
        {
            this.ID= Convert.ToInt32(row["id"]);
            this.DisplayName= Convert.ToString(row["DisplayName"]);
            this.UserName= Convert.ToString(row["UserName"]);
            this.Password= Convert.ToString(row["Password"]);
            this.Type = Convert.ToInt32(row["Type"]);
        }

        public AccountDTO(AccountDTO ACC)
        {
            this.ID= ACC.ID;
            this.DisplayName= ACC.DisplayName;
            this.UserName= ACC.UserName;
            this.Password= ACC.Password;
            this.Type = ACC.Type;
        }
    }
}
