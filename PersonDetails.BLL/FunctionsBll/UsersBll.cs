using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using PersonDetails.BLL.Converts;
using PersonDetails.DAL;

namespace PersonDetails.BLL.FunctionsBll
{
 public  class UsersBll
    {
        public UsersBll()
        {
                        
        }
        public static UserDTO GetUsers()
        {
            var user = DAL.FunctionsDal.UsersDal.GetUsers();
           return Converts.ConvertUser.ConvertUserDTO(user);
        }
        public void PostUser(UserDTO user)
        {
            DAL.FunctionsDal.UsersDal.PostUser(Converts.ConvertUser.ConvertToUser(user));
        }
    }
}
