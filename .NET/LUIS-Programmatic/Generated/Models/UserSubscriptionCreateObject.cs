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

    public partial class UserSubscriptionCreateObject
    {
        /// <summary>
        /// Initializes a new instance of the UserSubscriptionCreateObject
        /// class.
        /// </summary>
        public UserSubscriptionCreateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserSubscriptionCreateObject
        /// class.
        /// </summary>
        public UserSubscriptionCreateObject(string subscriptionName = default(string), string subscriptionKey = default(string))
        {
            SubscriptionName = subscriptionName;
            SubscriptionKey = subscriptionKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubscriptionName")]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubscriptionKey")]
        public string SubscriptionKey { get; set; }

    }
}
