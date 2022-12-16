using System;

using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace TestProject1.Service
{
    public static class SearchCreate
    {
        private static readonly ILoggerFactory _loggerFactory = new LoggerFactory();
        private static readonly ILogger _logger = _loggerFactory.CreateLogger("CustomCategory");

        private static String _searchString = "рюкзак";

        public static Models.Search CreateSearchWithCredentialsString()
        {
            var search = new Models.Search(_searchString);
            _logger.LogInformation("Search created with credentials string");
            return search;
        }

        public static Models.Search CreateSearchWithEmptyString()
        {
            var search = new Models.Search("");
            _logger.LogInformation("Search created with empty string");
            return search;
        }

        
    }
}