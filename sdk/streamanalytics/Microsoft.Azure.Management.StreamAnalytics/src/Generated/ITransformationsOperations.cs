// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.StreamAnalytics
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// TransformationsOperations operations.
    /// </summary>
    public partial interface ITransformationsOperations
    {
        /// <summary>
        /// Creates a transformation or replaces an already existing
        /// transformation under an existing streaming job.
        /// </summary>
        /// <param name='transformation'>
        /// The definition of the transformation that will be used to create a
        /// new transformation or replace the existing one under the streaming
        /// job.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='jobName'>
        /// The name of the streaming job.
        /// </param>
        /// <param name='transformationName'>
        /// The name of the transformation.
        /// </param>
        /// <param name='ifMatch'>
        /// The ETag of the transformation. Omit this value to always overwrite
        /// the current transformation. Specify the last-seen ETag value to
        /// prevent accidentally overwritting concurrent changes.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Set to '*' to allow a new transformation to be created, but to
        /// prevent updating an existing transformation. Other values will
        /// result in a 412 Pre-condition Failed response.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Transformation,TransformationsCreateOrReplaceHeaders>> CreateOrReplaceWithHttpMessagesAsync(Transformation transformation, string resourceGroupName, string jobName, string transformationName, string ifMatch = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates an existing transformation under an existing streaming job.
        /// This can be used to partially update (ie. update one or two
        /// properties) a transformation without affecting the rest the job or
        /// transformation definition.
        /// </summary>
        /// <param name='transformation'>
        /// A Transformation object. The properties specified here will
        /// overwrite the corresponding properties in the existing
        /// transformation (ie. Those properties will be updated). Any
        /// properties that are set to null here will mean that the
        /// corresponding property in the existing transformation will remain
        /// the same and not change as a result of this PATCH operation.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='jobName'>
        /// The name of the streaming job.
        /// </param>
        /// <param name='transformationName'>
        /// The name of the transformation.
        /// </param>
        /// <param name='ifMatch'>
        /// The ETag of the transformation. Omit this value to always overwrite
        /// the current transformation. Specify the last-seen ETag value to
        /// prevent accidentally overwritting concurrent changes.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Transformation,TransformationsUpdateHeaders>> UpdateWithHttpMessagesAsync(Transformation transformation, string resourceGroupName, string jobName, string transformationName, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets details about the specified transformation.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='jobName'>
        /// The name of the streaming job.
        /// </param>
        /// <param name='transformationName'>
        /// The name of the transformation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Transformation,TransformationsGetHeaders>> GetWithHttpMessagesAsync(string resourceGroupName, string jobName, string transformationName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}