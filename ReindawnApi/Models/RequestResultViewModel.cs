﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace ReindawnApi.Models
{
    public class RequestResultViewModel
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
    }
}