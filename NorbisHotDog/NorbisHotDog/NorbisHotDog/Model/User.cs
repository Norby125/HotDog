﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace NorbisHotDog.Model
{
    public class User 
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Id_Role { get; set;} 

    }
}
