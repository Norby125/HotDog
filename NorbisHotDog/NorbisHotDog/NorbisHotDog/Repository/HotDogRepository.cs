using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using NorbisHotDog.Model;


namespace NorbisHotDog.Repository
{
    class HotDogRepository 
    {
        private List<HotDog> _hotDogs;

        private string url =
            "http://192.168.0.8/NorbisHotDog/tables/Hotdog";
        public HotDogRepository()
        {
            //Init();
            //Task.Run(() => this.LoadDataAsync(url)).Wait();
            Task.Run(() => this.LoadDataAsync2(url)).Wait();
        }
        public void Init()
        {
            _hotDogs = new List<HotDog>();

            _hotDogs.Add(new HotDog() { Id = 1, Available = true, Description = "New Yorkers eat more hot dogs than any other group in the country. From downtown Manhattan to Coney Island, when you buy your hot dog in the Big Apple, it will come served with steamed onions and a pale, deli-style yellow mustard.", ImagePath = "", Name = "New York City", Price = 20, ShortDescription = "This the Hotdog1" });
            _hotDogs.Add(new HotDog() { Id = 2, Available = true, Description = "fglkgndfklg", ImagePath = "", Name = "Hotdog2", Price = 20, ShortDescription = "This the Hotdog2" });
            _hotDogs.Add(new HotDog() { Id = 3, Available = true, Description = "sdjkfgnsdjlfkndfg", ImagePath = "", Name = "Hotdog3", Price = 20, ShortDescription = "This the Hotdog3" });
            _hotDogs.Add(new HotDog() { Id = 4, Available = true, Description = "sdfgsdufgnsdfogjisdfogjiiodf", ImagePath = "", Name = "Hotdog4", Price = 20, ShortDescription = "This the Hotdog4" });
            _hotDogs.Add(new HotDog() { Id = 5, Available = true, Description = "sdfuigsdifgsjofdg", ImagePath = "", Name = "Hotdog5", Price = 20, ShortDescription = "This the Hotdog5" });
            _hotDogs.Add(new HotDog() { Id = 6, Available = true, Description = "dfghdfghdfghdfghhdf", ImagePath = "", Name = "Hotdog6", Price = 20, ShortDescription = "This the Hotdog6" });
            _hotDogs.Add(new HotDog() { Id = 7, Available = true, Description = "jhkuhjlsdfsdfsd", ImagePath = "", Name = "Hotdog7", Price = 20, ShortDescription = "This the Hotdog7" });
            _hotDogs.Add(new HotDog() { Id = 8, Available = true, Description = "dfgsdfhiilsduhi", ImagePath = "", Name = "Hotdog8", Price = 20, ShortDescription = "This the Hotdog8" });
            _hotDogs.Add(new HotDog() { Id = 9, Available = true, Description = "dsfzugsdfhgruiegheirughs", ImagePath = "", Name = "Hotdog9", Price = 20, ShortDescription = "This the Hotdog9" });
            _hotDogs.Add(new HotDog() { Id = 10, Available = true, Description = "serghdkfhskfjsgdflgj", ImagePath = "", Name = "Hotdog10", Price = 20, ShortDescription = "This the Hotdog10" });
            _hotDogs.Add(new HotDog() { Id = 11, Available = true, Description = "sdfkjghkseudrghrjkdfnglsdfkgnsersghlruie", ImagePath = "", Name = "Hotdog11", Price = 20, ShortDescription = "This the Hotdog11" });

        }

        public List<HotDog> GetAllHotDogs()
        {
            return _hotDogs;
        }
        public HotDog GetHotDogById(int hotDogId)
        {
            return _hotDogs.Where(c => c.Id == hotDogId).FirstOrDefault();
        }
        private async Task LoadDataAsync(string uri)
        {
            string responseJsonString = null;

            using (var httpClient = new HttpClient())
            {
                try
                {
                    Task<HttpResponseMessage> getResponse = httpClient.GetAsync(uri);

                    HttpResponseMessage response = await getResponse;

                    responseJsonString = await response.Content.ReadAsStringAsync();
                    _hotDogs = JsonConvert.DeserializeObject<List<HotDog>>(responseJsonString);
                }
                catch (Exception ex)
                {
                    //handle any errors here, not part of the sample app
                    string message = ex.Message;
                }
            }
        }

        private async Task LoadDataAsync2(string uri)
        {
            MobileServiceClient mobileServiceClient=new MobileServiceClient("http://192.168.0.8/NorbisHotDog/");
            var hotDogs = await mobileServiceClient.GetTable<HotDog>().ReadAsync();
            _hotDogs = hotDogs.ToList();
        }
    }
}
