using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.WindowsAzure.Mobile.Service;

namespace NorbisHotDog.Backend.DataObjects
{
    public class HotDog : EntityData
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Price { get; set; }
        public bool Available { get; set; }
    }
}
