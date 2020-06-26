using System;
using System.Collections.Generic;
using System.Text;
using WG_Data_Library.Intenal.DataAccess;
using WG_Data_Library.Models;

namespace WG_Data_Library.DataAccess
{
    public class UserData
    {
        //The is the user's information

        public List<UserModel> GetUserById(string Id)
        {

            SQLDataAccess sql = new SQLDataAccess();
            
            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", new { Id= Id}, "DefaultConnection");

            return output;
        }

       
    }
}
