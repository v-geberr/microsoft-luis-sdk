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

    public partial class ModelTrainingDetails
    {
        /// <summary>
        /// Initializes a new instance of the ModelTrainingDetails class.
        /// </summary>
        public ModelTrainingDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModelTrainingDetails class.
        /// </summary>
        /// <param name="status">Possible values include: 'Queued',
        /// 'InProgress', 'UpToDate', 'Fail', 'Success'</param>
        public ModelTrainingDetails(double? statusId = default(double?), string status = default(string), double? exampleCount = default(double?), string trainingDateTime = default(string), string failureReason = default(string))
        {
            StatusId = statusId;
            Status = status;
            ExampleCount = exampleCount;
            TrainingDateTime = trainingDateTime;
            FailureReason = failureReason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statusId")]
        public double? StatusId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Queued', 'InProgress',
        /// 'UpToDate', 'Fail', 'Success'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exampleCount")]
        public double? ExampleCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "trainingDateTime")]
        public string TrainingDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "failureReason")]
        public string FailureReason { get; set; }

    }
}
