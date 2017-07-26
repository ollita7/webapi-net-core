using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tupe.sdk.Configuration;
using Microsoft.Extensions.Options;
using tupe.sdk.configuration.models;

namespace tupe.sl.Controllers
{
    public class SettingsController : Controller
    {
        private readonly TupeSettings _settings;
        private readonly CommonSettings _common;

        public SettingsController(IOptions<TupeSettings> options, IOptions<CommonSettings> common) {
            this._settings = options.Value;
            this._common = common.Value;
        }

        [Route("api/settings/get")]
        [HttpGet]
        public object Get()
        {
            return new {TupeSettings = this._settings, CommonSettings = this._common};
        }
    }
}
