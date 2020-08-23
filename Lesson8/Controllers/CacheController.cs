using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyCaching.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

namespace Lesson8.Controllers
{
    public class CacheController : ControllerBase
    {
        private readonly IEasyCachingProvider cachingProvider;
        private readonly IEasyCachingProviderFactory cachingProviderFactory;

        public CacheController(IEasyCachingProviderFactory cachingProviderFactory)
        {
            this.cachingProviderFactory = cachingProviderFactory;
            this.cachingProvider = this.cachingProviderFactory.GetCachingProvider("redis");
        }

        [HttpGet("Set")]
        public IActionResult SetCache(string key, JsonResult val)
        {
            this.cachingProvider.Set(key, val, TimeSpan.FromMinutes(60));

            return Ok();
        }

        [HttpGet("Get")]
        public IActionResult GetCache(string key)
        {
            var item = this.cachingProvider.Get<JsonResult>(key);

            return Ok(item);
        }
    }
}
