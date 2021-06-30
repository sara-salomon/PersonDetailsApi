using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace PersonDetails.DAL.FunctionsDal
{
    public class UsersDal
    {
        public static User GetUsers()
        {
            try
            {
                User user;
                string path = @"C:\תכנות תשפא\מקצועות\TestCitiBook\PersonDetailsApi\User.txt";
                string fileUser;
                using (StreamReader reader = File.OpenText(path))
                    while ((fileUser = reader.ReadLine()) != null)
                    {
                        user = JsonConvert.DeserializeObject<User>(fileUser);
                        return user;
                    }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void PostUser(User p)
        {
            string path = @"C:\תכנות תשפא\מקצועות\TestCitiBook\PersonDetailsApi\User.txt";
            FileStream myfile = new FileStream(path, FileMode.Create);
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DAL.User));
                ser.WriteObject(myfile, p);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally { myfile.Close(); }
        }
    }
}
