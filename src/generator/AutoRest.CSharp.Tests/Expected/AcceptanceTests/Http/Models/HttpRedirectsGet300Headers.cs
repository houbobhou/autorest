// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsHttp.Models
{
    using Fixtures.AcceptanceTestsHttp;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for get300 operation.
    /// </summary>
    public partial class HttpRedirectsGet300Headers
    {
        /// <summary>
        /// Initializes a new instance of the HttpRedirectsGet300Headers class.
        /// </summary>
        public HttpRedirectsGet300Headers() { }

        /// <summary>
        /// Initializes a new instance of the HttpRedirectsGet300Headers class.
        /// </summary>
        /// <param name="location">The redirect location for this request.
        /// Possible values include: '/http/success/get/200'</param>
        public HttpRedirectsGet300Headers(string location = default(string))
        {
            Location = location;
        }

        /// <summary>
        /// Gets or sets the redirect location for this request. Possible
        /// values include: '/http/success/get/200'
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
