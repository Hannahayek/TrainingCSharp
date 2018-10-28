using System;

namespace Composition
{
    public class Installer { 
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void install()
        {
          _logger.Log("we are installing the application");
        }
    }
}