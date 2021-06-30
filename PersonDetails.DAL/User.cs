using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDetails.DAL
{
    public enum egender { male, female }
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public DateTime BornDate { get; set; }
        public string Gender { get; set; }
        public string HMO { get; set; }
        public List<Child> Children { get; set; } = new List<Child>();
    }
}
