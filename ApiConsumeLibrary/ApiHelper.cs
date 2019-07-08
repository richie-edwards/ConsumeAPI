﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SWAPITestDriveLibrary
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }
        
        public static void InitClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("https://swapi.co/api/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

    }
}
