﻿using System.Net.Http;
using Newtonsoft.Json;

namespace AtomicAssetsApiClient.Core
{
    public static class HttpResponseMessageExtension
    {
        public static T ContentAs<T>(this HttpResponseMessage message)
        {
            return JsonConvert.DeserializeObject<T>(message.Content.ReadAsStringAsync().Result);
        }
    }
}
