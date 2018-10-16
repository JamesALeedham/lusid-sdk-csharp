// <auto-generated>
// Copyright © 2018 FINBOURNE TECHNOLOGY LTD
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
// </auto-generated>

namespace Finbourne.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Instrument
    {
        /// <summary>
        /// Initializes a new instance of the Instrument class.
        /// </summary>
        public Instrument()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Instrument class.
        /// </summary>
        public Instrument(string href = default(string), string uid = default(string), Version version = default(Version), string commonName = default(string), IDictionary<string, string> aliases = default(IDictionary<string, string>), IList<Property> properties = default(IList<Property>), string marketIdentifierCode = default(string), ResourceId lookthroughPortfolio = default(ResourceId), IList<Link> links = default(IList<Link>))
        {
            Href = href;
            Uid = uid;
            Version = version;
            CommonName = commonName;
            Aliases = aliases;
            Properties = properties;
            MarketIdentifierCode = marketIdentifierCode;
            LookthroughPortfolio = lookthroughPortfolio;
            Links = links;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uid")]
        public string Uid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public Version Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "commonName")]
        public string CommonName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "aliases")]
        public IDictionary<string, string> Aliases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<Property> Properties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "marketIdentifierCode")]
        public string MarketIdentifierCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lookthroughPortfolio")]
        public ResourceId LookthroughPortfolio { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public IList<Link> Links { get; set; }

    }
}
