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
    public class RoleController : TableController<Role>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<Role>(context, Request, Services);
        }

        // GET tables/Role
        public IQueryable<Role> GetAllRole()
        {
            return Query(); 
        }

        // GET tables/Role/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Role> GetRole(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Role/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Role> PatchRole(string id, Delta<Role> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Role
        public async Task<IHttpActionResult> PostRole(Role item)
        {
            Role current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Role/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteRole(string id)
        {
             return DeleteAsync(id);
        }

    }
}