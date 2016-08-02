using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Web.Http;
using NorbisHotDog.Backend.DataObjects;
using NorbisHotDog.Backend.Models;
using Microsoft.WindowsAzure.Mobile.Service;

namespace NorbisHotDog.Backend
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            // Use this class to set configuration options for your mobile service
            ConfigOptions options = new ConfigOptions();

            // Use this class to set WebAPI configuration options
            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));

            // To display errors in the browser during development, uncomment the following
            // line. Comment it out again when you deploy your service for production use.
            // config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

            Database.SetInitializer(new MobileServiceInitializer());
        }
    }

    public class MobileServiceInitializer : DropCreateDatabaseIfModelChanges<MobileServiceContext>
    {
        public MobileServiceInitializer()
        {
            
        }

        protected override void Seed(MobileServiceContext context)
        {

            List<HotDog> hotDogs = new List<HotDog>
            {
            new HotDog() {Id = "1",Available = true, Description = "New Yorkers eat more hot dogs than any other group in the country. From downtown Manhattan to Coney Island, when you buy your hot dog in the Big Apple, it will come served with steamed onions and a pale, deli-style yellow mustard.", ImagePath = "", Name = "New York City", Price = 20, ShortDescription = "This the Hotdog1" },
            new HotDog() {Id = "2", Available = true, Description = "fglkgndfklg", ImagePath = "", Name = "Hotdog2", Price = 20, ShortDescription = "This the Hotdog2" },
            new HotDog() {Id = "3", Available = true, Description = "sdjkfgnsdjlfkndfg", ImagePath = "", Name = "Hotdog3", Price = 20, ShortDescription = "This the Hotdog3" },
            new HotDog() {Id = "4", Available = true, Description = "sdfgsdufgnsdfogjisdfogjiiodf", ImagePath = "", Name = "Hotdog4", Price = 20, ShortDescription = "This the Hotdog4" },
            new HotDog() {Id = "5", Available = true, Description = "sdfuigsdifgsjofdg", ImagePath = "", Name = "Hotdog5", Price = 20, ShortDescription = "This the Hotdog5" },
            new HotDog() {Id = "6", Available = true, Description = "dfghdfghdfghdfghhdf", ImagePath = "", Name = "Hotdog6", Price = 20, ShortDescription = "This the Hotdog6" },
            new HotDog() {Id = "7", Available = true, Description = "jhkuhjlsdfsdfsd", ImagePath = "", Name = "Hotdog7", Price = 20, ShortDescription = "This the Hotdog7" },
            new HotDog() {Id = "8", Available = true, Description = "dfgsdfhiilsduhi", ImagePath = "", Name = "Hotdog8", Price = 20, ShortDescription = "This the Hotdog8" },
            new HotDog() {Id = "9", Available = true, Description = "dsfzugsdfhgruiegheirughs", ImagePath = "", Name = "Hotdog9", Price = 20, ShortDescription = "This the Hotdog9" },
            new HotDog() {Id = "10", Available = true, Description = "serghdkfhskfjsgdflgj", ImagePath = "", Name = "Hotdog10", Price = 20, ShortDescription = "This the Hotdog10" },
            new HotDog() {Id = "11", Available = true, Description = "sdfkjghkseudrghrjkdfnglsdfkgnsersghlruie", ImagePath = "", Name = "Hotdog11", Price = 20, ShortDescription = "This the Hotdog11" },

            };

            foreach (HotDog hotDog in hotDogs)
            {
                context.Set<HotDog>().Add(hotDog);
            }

            List<User> users=new List<User>()
            {
                new User() {Id = "1",UserName = "asd",Password = "asdasd"},
                new User() {Id = "2",UserName = "Norbi",Password = "asdasdasd"}
            };
            foreach (User user in users)
            {
                context.Set<User>().Add(user);
            }
            base.Seed(context);
        }
    }
}

