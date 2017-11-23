// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Prediction operations.
    /// </summary>
    public partial interface IPrediction
    {
        /// <summary>
        /// Gets the published endpoint predictions for the given query.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='q'>
        /// The query to predict.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Either Subscription Key or Programmatic Key.
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='timezoneOffset'>
        /// The timezone offset for the location of the request.
        /// </param>
        /// <param name='verbose'>
        /// If true will return all intents instead of just the topscoring
        /// intent.
        /// </param>
        /// <param name='spellCheck'>
        /// Enable spell checking.
        /// </param>
        /// <param name='staging'>
        /// Use staging endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<LuisResult>> GetPredictionsFromEndpointViaGetWithHttpMessagesAsync(AzureRegions azureRegion, string q, string ocpApimSubscriptionKey, string appId, double? timezoneOffset = default(double?), bool? verbose = default(bool?), bool? spellCheck = default(bool?), bool? staging = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the published endpoint prediction for the given long query.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Either Subscription Key or Programmatic Key.
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='q'>
        /// The query to predict.
        /// </param>
        /// <param name='timezoneOffset'>
        /// The timezone offset for the location of the request.
        /// </param>
        /// <param name='verbose'>
        /// If true will return all intents instead of just the topscoring
        /// intent.
        /// </param>
        /// <param name='spellCheck'>
        /// Enable spell checking.
        /// </param>
        /// <param name='staging'>
        /// Use staging endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<LuisResult>> GetPredictionsFromEndpointViaPostWithHttpMessagesAsync(AzureRegions azureRegion, string ocpApimSubscriptionKey, string appId, string q = default(string), double? timezoneOffset = default(double?), bool? verbose = default(bool?), bool? spellCheck = default(bool?), bool? staging = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
