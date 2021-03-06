﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Extensibility
{



   
    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("migrations started at {0}"+ DateTime.Now);

            _logger.LogInfo("migrations finished at {0}" + DateTime.Now);
            //detauls of migrating the database
        }

    }
}
