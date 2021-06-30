using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using PersonDetails.DAL;


namespace PersonDetails.BLL.Converts
{
    public class ConvertUser
    {
        public static UserDTO ConvertUserDTO(User user)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.FirstName = user.FirstName;
            userDTO.LastName = user.LastName;
            userDTO.ID = user.ID;
            userDTO.HMO = user.HMO;
            userDTO.BornDate = user.BornDate;
            if (user.Gender == "0")
                userDTO.Gender = "male";
            else
                userDTO.Gender = "female";
            //userDTO.Children = new List<ChildDTO>(user.Children);
            //Collections.copy(userDTO.Children, user.Children);
            return userDTO;

        }
        public static DAL.User ConvertToUser(DTO.UserDTO user)
        {
            DAL.User userDal = new DAL.User();
            userDal.FirstName = user.FirstName;
            userDal.LastName = user.LastName;
            userDal.ID = user.ID;
            userDal.BornDate = user.BornDate;
            userDal.HMO = user.HMO;
            userDal.Gender = user.Gender;
            //foreach (var item in user.Children)
            //{
            //    userDal.Children.Add(item);
            //}
            return userDal;
        }
    }
}
