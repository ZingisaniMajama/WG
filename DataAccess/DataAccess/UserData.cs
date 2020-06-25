using System;
using System.Collections.Generic;
using System.Text;
using WG_Data_Library.Intenal.DataAccess;
using WG_Data_Library.Models;

namespace WG_Data_Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)
        {

            SQLDataAccess sql = new SQLDataAccess();

            var p = new { Id = Id };

            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "DefaultCollection");

            return output;
        }
    }
}
