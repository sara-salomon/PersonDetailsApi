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

            foreach (var item in user.Children)
            {
                userDTO.Children.Add(ConvertChildTODTO(item));
            }


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
            if (user.Gender == "0")
                userDal.Gender = "male";
            else
                userDal.Gender = "female";

            foreach (var item in user.Children)
            {
                userDal.Children.Add(ConvertChild(item));
            }
            return userDal;
        }
        public static DAL.Child ConvertChild(DTO.Child child)
        {
            DAL.Child c = new DAL.Child();
            c.FirstName = child.FirstName;
            c.Tz = child.Tz;
            c.BornDate = child.BornDate;
            return c;
        }

        public static DTO.Child ConvertChildTODTO(PersonDetails.DAL.Child child)
        {
            DTO.Child c = new DTO.Child();
            c.FirstName = child.FirstName;
            c.Tz = child.Tz;
            c.BornDate = child.BornDate;
            return c;
        }
    }
}
