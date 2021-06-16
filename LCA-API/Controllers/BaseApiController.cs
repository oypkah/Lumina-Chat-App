using LCA_Common.Client.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace LCA_API.Controllers
{
    [Produces("application/json")]
    [ApiController]
    public class BaseApiController<T> : ControllerBase where T : BaseApiController<T>
    {
        private IWorkContext _workContext;
        public BaseApiController()
        {

        }

        public IWorkContext WorkContext {
            get {
                if (_workContext == null)
                    _workContext = HttpContext.RequestServices.GetService<IWorkContext>();
                return _workContext;
            }
            set {
                _workContext = value;
            }
        }
    }
}
