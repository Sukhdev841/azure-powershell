// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    public partial class ConnectedMachineIdentity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject into a new instance of <see cref="ConnectedMachineIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ConnectedMachineIdentity(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)_subscriptionId;}
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)_resourceGroupName;}
            {_licenseName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("licenseName"), out var __jsonLicenseName) ? (string)__jsonLicenseName : (string)_licenseName;}
            {_machineName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("machineName"), out var __jsonMachineName) ? (string)__jsonMachineName : (string)_machineName;}
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)_name;}
            {_licenseProfileName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("licenseProfileName"), out var __jsonLicenseProfileName) ? (string)__jsonLicenseProfileName : (string)_licenseProfileName;}
            {_extensionName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("extensionName"), out var __jsonExtensionName) ? (string)__jsonExtensionName : (string)_extensionName;}
            {_location = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("location"), out var __jsonLocation) ? (string)__jsonLocation : (string)_location;}
            {_publisher = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("publisher"), out var __jsonPublisher) ? (string)__jsonPublisher : (string)_publisher;}
            {_extensionType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("extensionType"), out var __jsonExtensionType) ? (string)__jsonExtensionType : (string)_extensionType;}
            {_version = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)_version;}
            {_metadataName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("metadataName"), out var __jsonMetadataName) ? (string)__jsonMetadataName : (string)_metadataName;}
            {_oSType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("osType"), out var __jsonOSType) ? (string)__jsonOSType : (string)_oSType;}
            {_runCommandName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("runCommandName"), out var __jsonRunCommandName) ? (string)__jsonRunCommandName : (string)_runCommandName;}
            {_scopeName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("scopeName"), out var __jsonScopeName) ? (string)__jsonScopeName : (string)_scopeName;}
            {_privateLinkScopeId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("privateLinkScopeId"), out var __jsonPrivateLinkScopeId) ? (string)__jsonPrivateLinkScopeId : (string)_privateLinkScopeId;}
            {_groupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("groupName"), out var __jsonGroupName) ? (string)__jsonGroupName : (string)_groupName;}
            {_privateEndpointConnectionName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("privateEndpointConnectionName"), out var __jsonPrivateEndpointConnectionName) ? (string)__jsonPrivateEndpointConnectionName : (string)_privateEndpointConnectionName;}
            {_resourceUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("resourceUri"), out var __jsonResourceUri) ? (string)__jsonResourceUri : (string)_resourceUri;}
            {_perimeterName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("perimeterName"), out var __jsonPerimeterName) ? (string)__jsonPerimeterName : (string)_perimeterName;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)_id;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IConnectedMachineIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IConnectedMachineIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IConnectedMachineIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject json ? new ConnectedMachineIdentity(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ConnectedMachineIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ConnectedMachineIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            AddIf( null != (((object)this._licenseName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._licenseName.ToString()) : null, "licenseName" ,container.Add );
            AddIf( null != (((object)this._machineName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._machineName.ToString()) : null, "machineName" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._licenseProfileName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._licenseProfileName.ToString()) : null, "licenseProfileName" ,container.Add );
            AddIf( null != (((object)this._extensionName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._extensionName.ToString()) : null, "extensionName" ,container.Add );
            AddIf( null != (((object)this._location)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._location.ToString()) : null, "location" ,container.Add );
            AddIf( null != (((object)this._publisher)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._publisher.ToString()) : null, "publisher" ,container.Add );
            AddIf( null != (((object)this._extensionType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._extensionType.ToString()) : null, "extensionType" ,container.Add );
            AddIf( null != (((object)this._version)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._version.ToString()) : null, "version" ,container.Add );
            AddIf( null != (((object)this._metadataName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._metadataName.ToString()) : null, "metadataName" ,container.Add );
            AddIf( null != (((object)this._oSType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._oSType.ToString()) : null, "osType" ,container.Add );
            AddIf( null != (((object)this._runCommandName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._runCommandName.ToString()) : null, "runCommandName" ,container.Add );
            AddIf( null != (((object)this._scopeName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._scopeName.ToString()) : null, "scopeName" ,container.Add );
            AddIf( null != (((object)this._privateLinkScopeId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._privateLinkScopeId.ToString()) : null, "privateLinkScopeId" ,container.Add );
            AddIf( null != (((object)this._groupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._groupName.ToString()) : null, "groupName" ,container.Add );
            AddIf( null != (((object)this._privateEndpointConnectionName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._privateEndpointConnectionName.ToString()) : null, "privateEndpointConnectionName" ,container.Add );
            AddIf( null != (((object)this._resourceUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._resourceUri.ToString()) : null, "resourceUri" ,container.Add );
            AddIf( null != (((object)this._perimeterName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._perimeterName.ToString()) : null, "perimeterName" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}