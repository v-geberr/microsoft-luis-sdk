// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class JSONRegexFeature
    {
        /// <summary>
        /// Initializes a new instance of the JSONRegexFeature class.
        /// </summary>
        public JSONRegexFeature()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JSONRegexFeature class.
        /// </summary>
        public JSONRegexFeature(string pattern = default(string), bool? activated = default(bool?), string name = default(string))
        {
            Pattern = pattern;
            Activated = activated;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activated")]
        public bool? Activated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
