using Microsoft.AspNetCore.Antiforgery;
using fuwo.Controllers;

namespace fuwo.Web.Host.Controllers
{
    public class AntiForgeryController : fuwoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
