/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.5.1-660c2a2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace io.kubernetes.csharp.Model
{
    /// <summary>
    /// RoleList is a collection of Roles
    /// </summary>
    [DataContract]
    public partial class V1alpha1RoleList :  IEquatable<V1alpha1RoleList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1alpha1RoleList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1alpha1RoleList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1alpha1RoleList" /> class.
        /// </summary>
        /// <param name="ApiVersion">APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources.</param>
        /// <param name="Items">Items is a list of Roles (required).</param>
        /// <param name="Kind">Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds.</param>
        /// <param name="Metadata">Standard object&#39;s metadata..</param>
        public V1alpha1RoleList(string ApiVersion = default(string), List<V1alpha1Role> Items = default(List<V1alpha1Role>), string Kind = default(string), UnversionedListMeta Metadata = default(UnversionedListMeta))
        {
            // to ensure "Items" is required (not null)
            if (Items == null)
            {
                throw new InvalidDataException("Items is a required property for V1alpha1RoleList and cannot be null");
            }
            else
            {
                this.Items = Items;
            }
            this.ApiVersion = ApiVersion;
            this.Kind = Kind;
            this.Metadata = Metadata;
        }
        
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources
        /// </summary>
        /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources</value>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }
        /// <summary>
        /// Items is a list of Roles
        /// </summary>
        /// <value>Items is a list of Roles</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<V1alpha1Role> Items { get; set; }
        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds
        /// </summary>
        /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds</value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public string Kind { get; set; }
        /// <summary>
        /// Standard object&#39;s metadata.
        /// </summary>
        /// <value>Standard object&#39;s metadata.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public UnversionedListMeta Metadata { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1alpha1RoleList {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V1alpha1RoleList);
        }

        /// <summary>
        /// Returns true if V1alpha1RoleList instances are equal
        /// </summary>
        /// <param name="other">Instance of V1alpha1RoleList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1alpha1RoleList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiVersion == other.ApiVersion ||
                    this.ApiVersion != null &&
                    this.ApiVersion.Equals(other.ApiVersion)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) && 
                (
                    this.Kind == other.Kind ||
                    this.Kind != null &&
                    this.Kind.Equals(other.Kind)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ApiVersion != null)
                    hash = hash * 59 + this.ApiVersion.GetHashCode();
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                if (this.Kind != null)
                    hash = hash * 59 + this.Kind.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
