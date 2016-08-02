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
    public class UserDataController : TableController<UserData>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<UserData>(context, Request, Services);
        }

        // GET tables/UserData
        public IQueryable<UserData> GetAllUserData()
        {
            return Query(); 
        }

        // GET tables/UserData/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<UserData> GetUserData(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/UserData/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<UserData> PatchUserData(string id, Delta<UserData> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/UserData
        public async Task<IHttpActionResult> PostUserData(UserData item)
        {
            UserData current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/UserData/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteUserData(string id)
        {
             return DeleteAsync(id);
        }

    }
}