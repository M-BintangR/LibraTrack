using LibraTrack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraTrack.Session
{
    internal class UserSession
    {
        public static UserModel UserCurrent { get; set; }
    }
}
