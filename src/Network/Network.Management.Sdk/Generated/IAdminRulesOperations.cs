// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// AdminRulesOperations operations.
    /// </summary>
    public partial interface IAdminRulesOperations
    {
        /// <summary>
        /// List all network manager security configuration admin rules.
        /// </summary>
        /// <remarks>
        /// List all network manager security configuration admin rules.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='configurationName'>
        /// The name of the network manager Security Configuration.
        /// </param>
        /// <param name='ruleCollectionName'>
        /// The name of the network manager security Configuration rule collection.
        /// </param>
        /// <param name='top'>
        /// An optional query parameter which specifies the maximum number of records
        /// to be returned by the server.
        /// </param>
        /// <param name='skipToken'>
        /// SkipToken is only used if a previous operation returned a partial result.
        /// If a previous response contains a nextLink element, the value of the
        /// nextLink element will include a skipToken parameter that specifies a
        /// starting point to use for subsequent calls.
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<BaseAdminRule>>> ListWithHttpMessagesAsync(string resourceGroupName, string networkManagerName, string configurationName, string ruleCollectionName, int? top = default(int?), string skipToken = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets a network manager security configuration admin rule.
        /// </summary>
        /// <remarks>
        /// Gets a network manager security configuration admin rule.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='configurationName'>
        /// The name of the network manager Security Configuration.
        /// </param>
        /// <param name='ruleCollectionName'>
        /// The name of the network manager security Configuration rule collection.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the rule.
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<BaseAdminRule>> GetWithHttpMessagesAsync(string resourceGroupName, string networkManagerName, string configurationName, string ruleCollectionName, string ruleName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates or updates an admin rule.
        /// </summary>
        /// <remarks>
        /// Creates or updates an admin rule.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='configurationName'>
        /// The name of the network manager Security Configuration.
        /// </param>
        /// <param name='ruleCollectionName'>
        /// The name of the network manager security Configuration rule collection.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the rule.
        /// </param>
        /// <param name='adminRule'>
        /// The admin rule to create or update
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<BaseAdminRule>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string networkManagerName, string configurationName, string ruleCollectionName, string ruleName, BaseAdminRule adminRule, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes an admin rule.
        /// </summary>
        /// <remarks>
        /// Deletes an admin rule.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='configurationName'>
        /// The name of the network manager Security Configuration.
        /// </param>
        /// <param name='ruleCollectionName'>
        /// The name of the network manager security Configuration rule collection.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the rule.
        /// </param>
        /// <param name='force'>
        /// Deletes the resource even if it is part of a deployed configuration. If the
        /// configuration has been deployed, the service will do a cleanup deployment
        /// in the background, prior to the delete.
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<AdminRulesDeleteHeaders>> DeleteWithHttpMessagesAsync(string resourceGroupName, string networkManagerName, string configurationName, string ruleCollectionName, string ruleName, bool? force = default(bool?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes an admin rule.
        /// </summary>
        /// <remarks>
        /// Deletes an admin rule.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='configurationName'>
        /// The name of the network manager Security Configuration.
        /// </param>
        /// <param name='ruleCollectionName'>
        /// The name of the network manager security Configuration rule collection.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the rule.
        /// </param>
        /// <param name='force'>
        /// Deletes the resource even if it is part of a deployed configuration. If the
        /// configuration has been deployed, the service will do a cleanup deployment
        /// in the background, prior to the delete.
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<AdminRulesDeleteHeaders>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string networkManagerName, string configurationName, string ruleCollectionName, string ruleName, bool? force = default(bool?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all network manager security configuration admin rules.
        /// </summary>
        /// <remarks>
        /// List all network manager security configuration admin rules.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<BaseAdminRule>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}