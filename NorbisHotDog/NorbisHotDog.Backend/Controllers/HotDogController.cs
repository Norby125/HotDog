using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using NorbisHotDog.Backend.DataObjects;
using NorbisHotDog.Backend.Models;

namespace NorbisHotDog.Backend.Controllers
{
    public class HotDogController : TableController<HotDog>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<HotDog>(context, Request, Services);
        }

        // GET tables/HotDog
        public IQueryable<HotDog> GetAllHotDog()
        {
            return Query(); 
        }

        // GET tables/HotDog/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<HotDog> GetHotDog(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/HotDog/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<HotDog> PatchHotDog(string id, Delta<HotDog> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/HotDog
        public async Task<IHttpActionResult> PostHotDog(HotDog item)
        {
            HotDog current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/HotDog/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteHotDog(string id)
        {
             return DeleteAsync(id);
        }

    }
}