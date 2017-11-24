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
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Features.
    /// </summary>
    public static partial class FeaturesExtensions
    {
            /// <summary>
            /// Creates a new pattern feature.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID of the task.
            /// </param>
            /// <param name='patternCreateObject'>
            /// A JSON object containing Name and Pattern of the feature.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<double?> CreatePatternFeatureAsync(this IFeatures operations, AzureRegions azureRegion, string appId, string versionId, PatternCreateObject patternCreateObject = default(PatternCreateObject), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreatePatternFeatureWithHttpMessagesAsync(azureRegion, appId, versionId, patternCreateObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all application version pattern features.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID of the task.
            /// </param>
            /// <param name='skip'>
            /// The number of entries to skip. Default value is 0.
            /// </param>
            /// <param name='take'>
            /// The number of entries to return. Maximum page size is 500. Default is 100.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PatternFeatureInfo>> GetApplicationVersionPatternFeaturesAsync(this IFeatures operations, AzureRegions azureRegion, string appId, string versionId, int skip = 0, int take = 100, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetApplicationVersionPatternFeaturesWithHttpMessagesAsync(azureRegion, appId, versionId, skip, take, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new phraselist feature.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID of the task.
            /// </param>
            /// <param name='phraselistCreateObject'>
            /// A JSON object containing Name, comma-separated Phrases and the
            /// isExchangeable boolean.            Default value for isExchangeable is
            /// true.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<double?> CreatePhraselistFeatureAsync(this IFeatures operations, AzureRegions azureRegion, string appId, string versionId, PhraselistCreateObject phraselistCreateObject = default(PhraselistCreateObject), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreatePhraselistFeatureWithHttpMessagesAsync(azureRegion, appId, versionId, phraselistCreateObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all application phraselist features.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID of the task.
            /// </param>
            /// <param name='skip'>
            /// The number of entries to skip. Default value is 0.
            /// </param>
            /// <param name='take'>
            /// The number of entries to return. Maximum page size is 500. Default is 100.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PhraseListFeatureInfo>> GetApplicationVersionPhraselistFeaturesAsync(this IFeatures operations, AzureRegions azureRegion, string appId, string versionId, int skip = 0, int take = 100, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetApplicationVersionPhraselistFeaturesWithHttpMessagesAsync(azureRegion, appId, versionId, skip, take, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all application version features.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID of the task.
            /// </param>
            /// <param name='skip'>
            /// The number of entries to skip. Default value is 0.
            /// </param>
            /// <param name='take'>
            /// The number of entries to return. Maximum page size is 500. Default is 100.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FeaturesResponseObject> GetApplicationVersionFeaturesAsync(this IFeatures operations, AzureRegions azureRegion, string appId, string versionId, int skip = 0, int take = 100, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetApplicationVersionFeaturesWithHttpMessagesAsync(azureRegion, appId, versionId, skip, take, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets pattern feature info.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID of the task.
            /// </param>
            /// <param name='patternId'>
            /// The pattern feature ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PatternFeatureInfo> GetPatternFeatureInfoAsync(this IFeatures operations, AzureRegions azureRegion, string appId, string versionId, int patternId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPatternFeatureInfoWithHttpMessagesAsync(azureRegion, appId, versionId, patternId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the pattern, the name and the state of the pattern feature.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID of the task.
            /// </param>
            /// <param name='patternId'>
            /// The pattern feature ID.
            /// </param>
            /// <param name='patternUpdateObject'>
            /// A JSON object containing either:&lt;/br&gt;1- Just a boolean called
            /// IsActive, in which case the status of the feature will be
            /// changed.&lt;/br&gt;2- Name, Pattern and a boolean called IsActive to update
            /// the feature.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdatePatternFeatureAsync(this IFeatures operations, AzureRegions azureRegion, string appId, string versionId, int patternId, PatternUpdateObject patternUpdateObject = default(PatternUpdateObject), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdatePatternFeatureWithHttpMessagesAsync(azureRegion, appId, versionId, patternId, patternUpdateObject, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes a pattern feature from an application version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID of the task.
            /// </param>
            /// <param name='patternId'>
            /// The pattern feature ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeletePatternFeatureAsync(this IFeatures operations, AzureRegions azureRegion, string appId, string versionId, int patternId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeletePatternFeatureWithHttpMessagesAsync(azureRegion, appId, versionId, patternId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets phraselist feature info.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID of the task.
            /// </param>
            /// <param name='phraselistId'>
            /// The ID of the feature to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PhraseListFeatureInfo> GetPhraselistFeatureInfoAsync(this IFeatures operations, AzureRegions azureRegion, string appId, string versionId, int phraselistId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPhraselistFeatureInfoWithHttpMessagesAsync(azureRegion, appId, versionId, phraselistId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the phrases, the state and the name of the phraselist feature.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID of the task.
            /// </param>
            /// <param name='phraselistId'>
            /// The ID of the feature to be deleted.
            /// </param>
            /// <param name='phraselistUpdateObject'>
            /// A JSON object containing either:&lt;/br&gt;1- Just a boolean called
            /// IsActive, in which case the status of the feature will be
            /// changed.&lt;/br&gt;2- Name, Pattern, Mode, and a boolean called IsActive to
            /// update the feature.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdatePhraselistFeatureAsync(this IFeatures operations, AzureRegions azureRegion, string appId, string versionId, int phraselistId, PhraselistUpdateObject phraselistUpdateObject = default(PhraselistUpdateObject), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdatePhraselistFeatureWithHttpMessagesAsync(azureRegion, appId, versionId, phraselistId, phraselistUpdateObject, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes a phraselist feature from an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID of the task.
            /// </param>
            /// <param name='phraselistId'>
            /// The ID of the feature to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeletePhraselistFeatureAsync(this IFeatures operations, AzureRegions azureRegion, string appId, string versionId, int phraselistId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeletePhraselistFeatureWithHttpMessagesAsync(azureRegion, appId, versionId, phraselistId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}