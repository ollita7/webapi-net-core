using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace tupe.dal
{
    public class BaseRepo
    {
        private readonly IConfigurationRoot config;

        public BaseRepo(IConfigurationRoot config)
        {
            this.config = config;
        }
    }
}
