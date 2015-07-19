using System.Net;
using System.Net.Http;
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
		public HttpResponseMessage Get()
		{
			return new HttpResponseMessage
			{
				StatusCode = HttpStatusCode.OK,
				Content = new StringContent(_store.GetRandom())
			};
		}
    }
}
