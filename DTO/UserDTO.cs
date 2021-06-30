using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public enum egender { male, female }
    public  class UserDTO
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BornDate { get; set; }
        public string Gender { get; set; }
        public string HMO { get; set; }
        public List<ChildDTO> Children { get; set; } = new List<ChildDTO>();
    }
}
