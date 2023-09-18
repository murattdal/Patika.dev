﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class LogManager:ILogger
    {
        public ILogger _logger;

        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteLog()
        {
            //throw new NotImplementedException();
            _logger.WriteLog();
        }
    }
}
