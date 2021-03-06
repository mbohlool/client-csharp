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
    /// APIGroup contains the name, the supported versions, and the preferred version of a group.
    /// </summary>
    [DataContract]
    public partial class UnversionedAPIGroup :  IEquatable<UnversionedAPIGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnversionedAPIGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnversionedAPIGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnversionedAPIGroup" /> class.
        /// </summary>
        /// <param name="ApiVersion">APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources.</param>
        /// <param name="Kind">Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds.</param>
        /// <param name="Name">name is the name of the group. (required).</param>
        /// <param name="PreferredVersion">preferredVersion is the version preferred by the API server, which probably is the storage version..</param>
        /// <param name="ServerAddressByClientCIDRs">a map of client CIDR to server address that is serving this group. This is to help clients reach servers in the most network-efficient way possible. Clients can use the appropriate server address as per the CIDR that they match. In case of multiple matches, clients should use the longest matching CIDR. The server returns only those CIDRs that it thinks that the client can match. For example: the master will return an internal IP CIDR only, if the client reaches the server using an internal IP. Server looks at X-Forwarded-For header or X-Real-Ip header or request.RemoteAddr (in that order) to get the client IP. (required).</param>
        /// <param name="Versions">versions are the versions supported in this group. (required).</param>
        public UnversionedAPIGroup(string ApiVersion = default(string), string Kind = default(string), string Name = default(string), UnversionedGroupVersionForDiscovery PreferredVersion = default(UnversionedGroupVersionForDiscovery), List<UnversionedServerAddressByClientCIDR> ServerAddressByClientCIDRs = default(List<UnversionedServerAddressByClientCIDR>), List<UnversionedGroupVersionForDiscovery> Versions = default(List<UnversionedGroupVersionForDiscovery>))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for UnversionedAPIGroup and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ServerAddressByClientCIDRs" is required (not null)
            if (ServerAddressByClientCIDRs == null)
            {
                throw new InvalidDataException("ServerAddressByClientCIDRs is a required property for UnversionedAPIGroup and cannot be null");
            }
            else
            {
                this.ServerAddressByClientCIDRs = ServerAddressByClientCIDRs;
            }
            // to ensure "Versions" is required (not null)
            if (Versions == null)
            {
                throw new InvalidDataException("Versions is a required property for UnversionedAPIGroup and cannot be null");
            }
            else
            {
                this.Versions = Versions;
            }
            this.ApiVersion = ApiVersion;
            this.Kind = Kind;
            this.PreferredVersion = PreferredVersion;
        }
        
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources
        /// </summary>
        /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources</value>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }
        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds
        /// </summary>
        /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds</value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public string Kind { get; set; }
        /// <summary>
        /// name is the name of the group.
        /// </summary>
        /// <value>name is the name of the group.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// preferredVersion is the version preferred by the API server, which probably is the storage version.
        /// </summary>
        /// <value>preferredVersion is the version preferred by the API server, which probably is the storage version.</value>
        [DataMember(Name="preferredVersion", EmitDefaultValue=false)]
        public UnversionedGroupVersionForDiscovery PreferredVersion { get; set; }
        /// <summary>
        /// a map of client CIDR to server address that is serving this group. This is to help clients reach servers in the most network-efficient way possible. Clients can use the appropriate server address as per the CIDR that they match. In case of multiple matches, clients should use the longest matching CIDR. The server returns only those CIDRs that it thinks that the client can match. For example: the master will return an internal IP CIDR only, if the client reaches the server using an internal IP. Server looks at X-Forwarded-For header or X-Real-Ip header or request.RemoteAddr (in that order) to get the client IP.
        /// </summary>
        /// <value>a map of client CIDR to server address that is serving this group. This is to help clients reach servers in the most network-efficient way possible. Clients can use the appropriate server address as per the CIDR that they match. In case of multiple matches, clients should use the longest matching CIDR. The server returns only those CIDRs that it thinks that the client can match. For example: the master will return an internal IP CIDR only, if the client reaches the server using an internal IP. Server looks at X-Forwarded-For header or X-Real-Ip header or request.RemoteAddr (in that order) to get the client IP.</value>
        [DataMember(Name="serverAddressByClientCIDRs", EmitDefaultValue=false)]
        public List<UnversionedServerAddressByClientCIDR> ServerAddressByClientCIDRs { get; set; }
        /// <summary>
        /// versions are the versions supported in this group.
        /// </summary>
        /// <value>versions are the versions supported in this group.</value>
        [DataMember(Name="versions", EmitDefaultValue=false)]
        public List<UnversionedGroupVersionForDiscovery> Versions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnversionedAPIGroup {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PreferredVersion: ").Append(PreferredVersion).Append("\n");
            sb.Append("  ServerAddressByClientCIDRs: ").Append(ServerAddressByClientCIDRs).Append("\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
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
            return this.Equals(obj as UnversionedAPIGroup);
        }

        /// <summary>
        /// Returns true if UnversionedAPIGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of UnversionedAPIGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnversionedAPIGroup other)
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
                    this.Kind == other.Kind ||
                    this.Kind != null &&
                    this.Kind.Equals(other.Kind)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PreferredVersion == other.PreferredVersion ||
                    this.PreferredVersion != null &&
                    this.PreferredVersion.Equals(other.PreferredVersion)
                ) && 
                (
                    this.ServerAddressByClientCIDRs == other.ServerAddressByClientCIDRs ||
                    this.ServerAddressByClientCIDRs != null &&
                    this.ServerAddressByClientCIDRs.SequenceEqual(other.ServerAddressByClientCIDRs)
                ) && 
                (
                    this.Versions == other.Versions ||
                    this.Versions != null &&
                    this.Versions.SequenceEqual(other.Versions)
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
                if (this.Kind != null)
                    hash = hash * 59 + this.Kind.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PreferredVersion != null)
                    hash = hash * 59 + this.PreferredVersion.GetHashCode();
                if (this.ServerAddressByClientCIDRs != null)
                    hash = hash * 59 + this.ServerAddressByClientCIDRs.GetHashCode();
                if (this.Versions != null)
                    hash = hash * 59 + this.Versions.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
