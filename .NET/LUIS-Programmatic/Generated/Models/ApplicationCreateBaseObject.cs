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

    public partial class ApplicationCreateBaseObject
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationCreateBaseObject
        /// class.
        /// </summary>
        public ApplicationCreateBaseObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationCreateBaseObject
        /// class.
        /// </summary>
        public ApplicationCreateBaseObject(string culture = default(string), string usageScenario = default(string), string description = default(string), string domain = default(string), string name = default(string))
        {
            Culture = culture;
            UsageScenario = usageScenario;
            Description = description;
            Domain = domain;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Culture")]
        public string Culture { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UsageScenario")]
        public string UsageScenario { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Domain")]
        public string Domain { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

    }
}
