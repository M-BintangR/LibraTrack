using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraTrack.Model
{
    internal class UserModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string City { get; set; }  
        public string Address { get; set; }

        public UserModel(string id, string name, string email, string role, string city, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Role = role;
            this.City = city;
            this.Address = address;
        }
    }
}
