using System.Web.Http;

namespace DoAsYoureToldAPI
{
	[RoutePrefix("")]
    public class DoAsYoureToldController : ApiController
    {
		private readonly DoAsYoureToldStore _store;

		public DoAsYoureToldController()
		{
			_store = new DoAsYoureToldStore();
		}

		[HttpGet]
		[Route("")]
		public string Get()
		{
			return _store.GetRandom();
		}
    }
}
