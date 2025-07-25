// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace ADT.Models
{
    using static ADT.Runtime.Extensions;

    public partial class UserAssignedIdentities :
        ADT.Runtime.IAssociativeArray<ADT.Models.IUserAssignedIdentity>
    {
        protected global::System.Collections.Generic.Dictionary<global::System.String,ADT.Models.IUserAssignedIdentity> __additionalProperties = new global::System.Collections.Generic.Dictionary<global::System.String,ADT.Models.IUserAssignedIdentity>();

        global::System.Collections.Generic.IDictionary<global::System.String,ADT.Models.IUserAssignedIdentity> ADT.Runtime.IAssociativeArray<ADT.Models.IUserAssignedIdentity>.AdditionalProperties { get => __additionalProperties; }

        int ADT.Runtime.IAssociativeArray<ADT.Models.IUserAssignedIdentity>.Count { get => __additionalProperties.Count; }

        global::System.Collections.Generic.IEnumerable<global::System.String> ADT.Runtime.IAssociativeArray<ADT.Models.IUserAssignedIdentity>.Keys { get => __additionalProperties.Keys; }

        global::System.Collections.Generic.IEnumerable<ADT.Models.IUserAssignedIdentity> ADT.Runtime.IAssociativeArray<ADT.Models.IUserAssignedIdentity>.Values { get => __additionalProperties.Values; }

        public ADT.Models.IUserAssignedIdentity this[global::System.String index] { get => __additionalProperties[index]; set => __additionalProperties[index] = value; }

        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(global::System.String key, ADT.Models.IUserAssignedIdentity value) => __additionalProperties.Add( key, value);

        public void Clear() => __additionalProperties.Clear();

        /// <param name="key"></param>
        public bool ContainsKey(global::System.String key) => __additionalProperties.ContainsKey( key);

        /// <param name="source"></param>
        public void CopyFrom(global::System.Collections.IDictionary source)
        {
            if (null != source)
            {
                foreach( var property in  ADT.Runtime.PowerShell.TypeConverterExtensions.GetFilteredProperties(source, new global::System.Collections.Generic.HashSet<global::System.String>() {  } ) )
                {
                    if ((null != property.Key && null != property.Value))
                    {
                        this.__additionalProperties.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<ADT.Models.IUserAssignedIdentity>( property.Value));
                    }
                }
            }
        }

        /// <param name="source"></param>
        public void CopyFrom(global::System.Management.Automation.PSObject source)
        {
            if (null != source)
            {
                foreach( var property in  ADT.Runtime.PowerShell.TypeConverterExtensions.GetFilteredProperties(source, new global::System.Collections.Generic.HashSet<global::System.String>() {  } ) )
                {
                    if ((null != property.Key && null != property.Value))
                    {
                        this.__additionalProperties.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<ADT.Models.IUserAssignedIdentity>( property.Value));
                    }
                }
            }
        }

        /// <param name="key"></param>
        public bool Remove(global::System.String key) => __additionalProperties.Remove( key);

        /// <param name="key"></param>
        /// <param name="value"></param>
        public bool TryGetValue(global::System.String key, out ADT.Models.IUserAssignedIdentity value) => __additionalProperties.TryGetValue( key, out value);

        /// <param name="source"></param>

        public static implicit operator global::System.Collections.Generic.Dictionary<global::System.String,ADT.Models.IUserAssignedIdentity>(ADT.Models.UserAssignedIdentities source) => source.__additionalProperties;
    }
}