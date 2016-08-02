using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Mobile.Service;

namespace NorbisHotDog.Backend.DataObjects
{
    public class Role : EntityData
    {
        public string Name { get; set; }
    }
}