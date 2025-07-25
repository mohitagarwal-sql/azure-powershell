// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.PowerShell;

    /// <summary>The base virtual machine configuration for a lab.</summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineProfileTypeConverter))]
    public partial class VirtualMachineProfile
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.VirtualMachineProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualMachineProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.VirtualMachineProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualMachineProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualMachineProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VirtualMachineProfile" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.VirtualMachineProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualMachineProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReference = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImageReference) content.GetValueForProperty("ImageReference",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReference, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("AdditionalCapability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdditionalCapability = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineAdditionalCapabilities) content.GetValueForProperty("AdditionalCapability",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdditionalCapability, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.VirtualMachineAdditionalCapabilitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AdminUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdminUser = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ICredentials) content.GetValueForProperty("AdminUser",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdminUser, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.CredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("NonAdminUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).NonAdminUser = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ICredentials) content.GetValueForProperty("NonAdminUser",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).NonAdminUser, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.CredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CreateOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).CreateOption = (string) content.GetValueForProperty("CreateOption",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).CreateOption, global::System.Convert.ToString);
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).OSType, global::System.Convert.ToString);
            }
            if (content.Contains("UsageQuota"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).UsageQuota = (global::System.TimeSpan) content.GetValueForProperty("UsageQuota",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).UsageQuota, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("UseSharedPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).UseSharedPassword = (string) content.GetValueForProperty("UseSharedPassword",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).UseSharedPassword, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceOffer = (string) content.GetValueForProperty("ImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferencePublisher = (string) content.GetValueForProperty("ImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceSku = (string) content.GetValueForProperty("ImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceVersion = (string) content.GetValueForProperty("ImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceExactVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceExactVersion = (string) content.GetValueForProperty("ImageReferenceExactVersion",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceExactVersion, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("SkuTier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuTier, global::System.Convert.ToString);
            }
            if (content.Contains("SkuSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuSize = (string) content.GetValueForProperty("SkuSize",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuSize, global::System.Convert.ToString);
            }
            if (content.Contains("SkuFamily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuFamily = (string) content.GetValueForProperty("SkuFamily",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuFamily, global::System.Convert.ToString);
            }
            if (content.Contains("SkuCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuCapacity = (int?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceId = (string) content.GetValueForProperty("ImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalCapabilityInstallGpuDriver"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdditionalCapabilityInstallGpuDriver = (string) content.GetValueForProperty("AdditionalCapabilityInstallGpuDriver",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdditionalCapabilityInstallGpuDriver, global::System.Convert.ToString);
            }
            if (content.Contains("AdminUserUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdminUserUsername = (string) content.GetValueForProperty("AdminUserUsername",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdminUserUsername, global::System.Convert.ToString);
            }
            if (content.Contains("AdminUserPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdminUserPassword = (System.Security.SecureString) content.GetValueForProperty("AdminUserPassword",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdminUserPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("NonAdminUserUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).NonAdminUserUsername = (string) content.GetValueForProperty("NonAdminUserUsername",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).NonAdminUserUsername, global::System.Convert.ToString);
            }
            if (content.Contains("NonAdminUserPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).NonAdminUserPassword = (System.Security.SecureString) content.GetValueForProperty("NonAdminUserPassword",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).NonAdminUserPassword, (object ss) => (System.Security.SecureString)ss);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.VirtualMachineProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualMachineProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReference = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImageReference) content.GetValueForProperty("ImageReference",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReference, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("AdditionalCapability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdditionalCapability = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineAdditionalCapabilities) content.GetValueForProperty("AdditionalCapability",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdditionalCapability, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.VirtualMachineAdditionalCapabilitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AdminUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdminUser = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ICredentials) content.GetValueForProperty("AdminUser",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdminUser, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.CredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("NonAdminUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).NonAdminUser = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ICredentials) content.GetValueForProperty("NonAdminUser",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).NonAdminUser, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.CredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CreateOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).CreateOption = (string) content.GetValueForProperty("CreateOption",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).CreateOption, global::System.Convert.ToString);
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).OSType, global::System.Convert.ToString);
            }
            if (content.Contains("UsageQuota"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).UsageQuota = (global::System.TimeSpan) content.GetValueForProperty("UsageQuota",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).UsageQuota, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("UseSharedPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).UseSharedPassword = (string) content.GetValueForProperty("UseSharedPassword",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).UseSharedPassword, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceOffer = (string) content.GetValueForProperty("ImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferencePublisher = (string) content.GetValueForProperty("ImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceSku = (string) content.GetValueForProperty("ImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceVersion = (string) content.GetValueForProperty("ImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceExactVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceExactVersion = (string) content.GetValueForProperty("ImageReferenceExactVersion",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceExactVersion, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("SkuTier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuTier, global::System.Convert.ToString);
            }
            if (content.Contains("SkuSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuSize = (string) content.GetValueForProperty("SkuSize",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuSize, global::System.Convert.ToString);
            }
            if (content.Contains("SkuFamily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuFamily = (string) content.GetValueForProperty("SkuFamily",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuFamily, global::System.Convert.ToString);
            }
            if (content.Contains("SkuCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuCapacity = (int?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceId = (string) content.GetValueForProperty("ImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).ImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalCapabilityInstallGpuDriver"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdditionalCapabilityInstallGpuDriver = (string) content.GetValueForProperty("AdditionalCapabilityInstallGpuDriver",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdditionalCapabilityInstallGpuDriver, global::System.Convert.ToString);
            }
            if (content.Contains("AdminUserUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdminUserUsername = (string) content.GetValueForProperty("AdminUserUsername",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdminUserUsername, global::System.Convert.ToString);
            }
            if (content.Contains("AdminUserPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdminUserPassword = (System.Security.SecureString) content.GetValueForProperty("AdminUserPassword",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).AdminUserPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("NonAdminUserUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).NonAdminUserUsername = (string) content.GetValueForProperty("NonAdminUserUsername",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).NonAdminUserUsername, global::System.Convert.ToString);
            }
            if (content.Contains("NonAdminUserPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).NonAdminUserPassword = (System.Security.SecureString) content.GetValueForProperty("NonAdminUserPassword",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProfileInternal)this).NonAdminUserPassword, (object ss) => (System.Security.SecureString)ss);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// The base virtual machine configuration for a lab.
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineProfileTypeConverter))]
    public partial interface IVirtualMachineProfile

    {

    }
}