using System.Collections.Generic;
using NorbisHotDog.Model;
using NorbisHotDog.Repository;

namespace NorbisHotDog.Service
{
    public class HotDogDataService
    {
        private static HotDogRepository hotDogRepository = new HotDogRepository();

        public List<HotDog> GetAllHotDogs()
        {
            return hotDogRepository.GetAllHotDogs();
        }
        public HotDog GetHotDogById(int hotDogId)
        {
            return hotDogRepository.GetHotDogById(hotDogId);
        }
    }
}