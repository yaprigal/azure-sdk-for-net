// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent
{
    using Azure;
    using Management;
    using Network;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualNetworkGatewaysOperations.
    /// </summary>
    public static partial class VirtualNetworkGatewaysOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or update virtual network gateway operation.
            /// </param>
            public static VirtualNetworkGatewayInner CreateOrUpdate(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGatewayInner parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, virtualNetworkGatewayName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or update virtual network gateway operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGatewayInner> CreateOrUpdateAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGatewayInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified virtual network gateway by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            public static VirtualNetworkGatewayInner Get(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
            {
                return operations.GetAsync(resourceGroupName, virtualNetworkGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified virtual network gateway by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGatewayInner> GetAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified virtual network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            public static void Delete(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
            {
                operations.DeleteAsync(resourceGroupName, virtualNetworkGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified virtual network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets all virtual network gateways by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<VirtualNetworkGatewayInner> List(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all virtual network gateways by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetworkGatewayInner>> ListAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Resets the primary of the virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='gatewayVip'>
            /// Virtual network gateway vip address supplied to the begin reset of the
            /// active-active feature enabled gateway.
            /// </param>
            public static VirtualNetworkGatewayInner Reset(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string gatewayVip = default(string))
            {
                return operations.ResetAsync(resourceGroupName, virtualNetworkGatewayName, gatewayVip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resets the primary of the virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='gatewayVip'>
            /// Virtual network gateway vip address supplied to the begin reset of the
            /// active-active feature enabled gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGatewayInner> ResetAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string gatewayVip = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ResetWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, gatewayVip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Generates VPN client package for P2S client of the virtual network gateway
            /// in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='processorArchitecture'>
            /// VPN client Processor Architecture. Possible values are: 'AMD64' and 'X86'.
            /// Possible values include: 'Amd64', 'X86'
            /// </param>
            public static string Generatevpnclientpackage(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string processorArchitecture)
            {
                return operations.GeneratevpnclientpackageAsync(resourceGroupName, virtualNetworkGatewayName, processorArchitecture).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates VPN client package for P2S client of the virtual network gateway
            /// in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='processorArchitecture'>
            /// VPN client Processor Architecture. Possible values are: 'AMD64' and 'X86'.
            /// Possible values include: 'Amd64', 'X86'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GeneratevpnclientpackageAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string processorArchitecture, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GeneratevpnclientpackageWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, processorArchitecture, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or update virtual network gateway operation.
            /// </param>
            public static VirtualNetworkGatewayInner BeginCreateOrUpdate(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGatewayInner parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, virtualNetworkGatewayName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or update virtual network gateway operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGatewayInner> BeginCreateOrUpdateAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGatewayInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified virtual network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            public static void BeginDelete(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
            {
                operations.BeginDeleteAsync(resourceGroupName, virtualNetworkGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified virtual network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Resets the primary of the virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='gatewayVip'>
            /// Virtual network gateway vip address supplied to the begin reset of the
            /// active-active feature enabled gateway.
            /// </param>
            public static VirtualNetworkGatewayInner BeginReset(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string gatewayVip = default(string))
            {
                return operations.BeginResetAsync(resourceGroupName, virtualNetworkGatewayName, gatewayVip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resets the primary of the virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='gatewayVip'>
            /// Virtual network gateway vip address supplied to the begin reset of the
            /// active-active feature enabled gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGatewayInner> BeginResetAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string gatewayVip = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginResetWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, gatewayVip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all virtual network gateways by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualNetworkGatewayInner> ListNext(this IVirtualNetworkGatewaysOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all virtual network gateways by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetworkGatewayInner>> ListNextAsync(this IVirtualNetworkGatewaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
