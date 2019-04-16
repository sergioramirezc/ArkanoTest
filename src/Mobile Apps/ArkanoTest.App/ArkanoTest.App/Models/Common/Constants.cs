using System;
using System.Collections.Generic;
using System.Text;

namespace ArkanoTest.App.Models.Common
{
    public class Constants
    {
        public const string BaseEndpoint = "http://arkanotest.azurewebsites.net";

        public struct ErrorTypes
        {
            public const string Service = "Service";
            public const string ViewModel = "ViewModel";
        }

        public struct HttpMethod
        {
            public const string Get = "Get";
            public const string Post = "Post";
            public const string Put = "Put";
        }
    }
}
