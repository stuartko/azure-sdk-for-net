// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// AzureAccounts operations.
    /// </summary>
    public partial interface IAzureAccounts
    {
        /// <summary>
        /// apps - Assign a LUIS azure account to an application
        /// </summary>
        /// <remarks>
        /// Assigns an azure account to the application.
        /// </remarks>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='azureAccountInfoObject'>
        /// The azure account information object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<OperationStatus>> AssignToAppWithHttpMessagesAsync(System.Guid appId, AzureAccountInfoObject azureAccountInfoObject = default(AzureAccountInfoObject), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// apps - Get LUIS azure accounts assigned to the application
        /// </summary>
        /// <remarks>
        /// Gets the LUIS azure accounts assigned to the application for the
        /// user using his ARM token.
        /// </remarks>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<AzureAccountInfoObject>>> GetAssignedWithHttpMessagesAsync(System.Guid appId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// apps - Removes an assigned LUIS azure account from an application
        /// </summary>
        /// <remarks>
        /// Removes assigned azure account from the application.
        /// </remarks>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='azureAccountInfoObject'>
        /// The azure account information object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<OperationStatus>> RemoveFromAppWithHttpMessagesAsync(System.Guid appId, AzureAccountInfoObject azureAccountInfoObject = default(AzureAccountInfoObject), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// user - Get LUIS azure accounts
        /// </summary>
        /// <remarks>
        /// Gets the LUIS azure accounts for the user using his ARM token.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<AzureAccountInfoObject>>> GetUserLUISAccountsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
