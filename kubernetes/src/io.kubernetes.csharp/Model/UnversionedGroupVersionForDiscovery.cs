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
    /// GroupVersion contains the \&quot;group/version\&quot; and \&quot;version\&quot; string of a version. It is made a struct to keep extensibility.
    /// </summary>
    [DataContract]
    public partial class UnversionedGroupVersionForDiscovery :  IEquatable<UnversionedGroupVersionForDiscovery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnversionedGroupVersionForDiscovery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnversionedGroupVersionForDiscovery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnversionedGroupVersionForDiscovery" /> class.
        /// </summary>
        /// <param name="GroupVersion">groupVersion specifies the API group and version in the form \&quot;group/version\&quot; (required).</param>
        /// <param name="Version">version specifies the version in the form of \&quot;version\&quot;. This is to save the clients the trouble of splitting the GroupVersion. (required).</param>
        public UnversionedGroupVersionForDiscovery(string GroupVersion = default(string), string Version = default(string))
        {
            // to ensure "GroupVersion" is required (not null)
            if (GroupVersion == null)
            {
                throw new InvalidDataException("GroupVersion is a required property for UnversionedGroupVersionForDiscovery and cannot be null");
            }
            else
            {
                this.GroupVersion = GroupVersion;
            }
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new InvalidDataException("Version is a required property for UnversionedGroupVersionForDiscovery and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
        }
        
        /// <summary>
        /// groupVersion specifies the API group and version in the form \&quot;group/version\&quot;
        /// </summary>
        /// <value>groupVersion specifies the API group and version in the form \&quot;group/version\&quot;</value>
        [DataMember(Name="groupVersion", EmitDefaultValue=false)]
        public string GroupVersion { get; set; }
        /// <summary>
        /// version specifies the version in the form of \&quot;version\&quot;. This is to save the clients the trouble of splitting the GroupVersion.
        /// </summary>
        /// <value>version specifies the version in the form of \&quot;version\&quot;. This is to save the clients the trouble of splitting the GroupVersion.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnversionedGroupVersionForDiscovery {\n");
            sb.Append("  GroupVersion: ").Append(GroupVersion).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as UnversionedGroupVersionForDiscovery);
        }

        /// <summary>
        /// Returns true if UnversionedGroupVersionForDiscovery instances are equal
        /// </summary>
        /// <param name="other">Instance of UnversionedGroupVersionForDiscovery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnversionedGroupVersionForDiscovery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GroupVersion == other.GroupVersion ||
                    this.GroupVersion != null &&
                    this.GroupVersion.Equals(other.GroupVersion)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.GroupVersion != null)
                    hash = hash * 59 + this.GroupVersion.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}