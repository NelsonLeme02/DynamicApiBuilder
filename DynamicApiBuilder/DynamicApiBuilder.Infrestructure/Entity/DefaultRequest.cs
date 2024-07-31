using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicApiBuilder.Infrestructure.Enums;

namespace DynamicApiBuilder.Infrestructure.Entity
{
    public class DefaultRequest
    {
        public DefaultRequest(HttpAction httpMethod, ConfigurationApplicationAction? configurationApplicationAction, object requestBody, object requestHeaders)
        {
            TrackingId = Ulid.NewUlid();
            HttpMethod = httpMethod;
            ConfigurationApplicationEndpoint = configurationApplicationAction;
            RequestBody = requestBody;
            RequestHeaders = requestHeaders;
        }
        public Ulid TrackingId { get; set; }
        public HttpAction HttpMethod { get; set; }
        public ConfigurationApplicationAction? ConfigurationApplicationEndpoint { get; set; }
        public object? RequestBody { get; set; }
        public object RequestHeaders { get; set; }
    }
}
