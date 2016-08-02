using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Mobile.Service;

namespace NorbisHotDog.Backend.DataObjects
{
    public class User : EntityData
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Id_Role { get; set; }

    }
}