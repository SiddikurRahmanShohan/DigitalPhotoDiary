using DigitalPhotoDiary.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPhotoDiary.DataAccessLayer
{
    class UserDataAccess: DataAccess
    {
        public User GetUser(int id) {
            string sql = "SELECT Username fROM Users WHERE UserId=" + id;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read()) {
                User user = new User();
                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.Username = reader["Username"].ToString();
                return user;
            }
            return null;
        }

        public int AddUser(User user) {
            string sql = "INSERT INTO Users(Name,Username,Password) VALUES ('"+user.Name+ "', '" + user.Username + "', '" + user.Password + "')";
            return this.ExecuteQuery(sql);
        }
    }
}
