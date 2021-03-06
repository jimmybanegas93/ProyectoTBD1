﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Pharma.Api.Models;

namespace Pharma.Api.Controllers
{
    public class BaseApiController : ApiController
    {
        protected UserTokenModel GetUserTokenModel()
        {
            IEnumerable<string> headerValues = Request.Headers.GetValues("Authorization");
            var authorizationToken = headerValues.FirstOrDefault();
            var userTokenModel = AuthRequestFactory.BuildDecryptedRequest(authorizationToken);
            return userTokenModel;
        }
    }
}