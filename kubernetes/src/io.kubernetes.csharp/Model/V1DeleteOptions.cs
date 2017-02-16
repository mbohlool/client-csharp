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
    /// DeleteOptions may be provided when deleting an API object
    /// </summary>
    [DataContract]
    public partial class V1DeleteOptions :  IEquatable<V1DeleteOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1DeleteOptions" /> class.
        /// </summary>
        /// <param name="ApiVersion">APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources.</param>
        /// <param name="GracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately..</param>
        /// <param name="Kind">Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds.</param>
        /// <param name="OrphanDependents">Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list..</param>
        /// <param name="Preconditions">Must be fulfilled before a deletion is carried out. If not possible, a 409 Conflict status will be returned..</param>
        public V1DeleteOptions(string ApiVersion = default(string), long? GracePeriodSeconds = default(long?), string Kind = default(string), bool? OrphanDependents = default(bool?), V1Preconditions Preconditions = default(V1Preconditions))
        {
            this.ApiVersion = ApiVersion;
            this.GracePeriodSeconds = GracePeriodSeconds;
            this.Kind = Kind;
            this.OrphanDependents = OrphanDependents;
            this.Preconditions = Preconditions;
        }
        
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources
        /// </summary>
        /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources</value>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }
        /// <summary>
        /// The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.
        /// </summary>
        /// <value>The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</value>
        [DataMember(Name="gracePeriodSeconds", EmitDefaultValue=false)]
        public long? GracePeriodSeconds { get; set; }
        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds
        /// </summary>
        /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds</value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public string Kind { get; set; }
        /// <summary>
        /// Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list.
        /// </summary>
        /// <value>Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list.</value>
        [DataMember(Name="orphanDependents", EmitDefaultValue=false)]
        public bool? OrphanDependents { get; set; }
        /// <summary>
        /// Must be fulfilled before a deletion is carried out. If not possible, a 409 Conflict status will be returned.
        /// </summary>
        /// <value>Must be fulfilled before a deletion is carried out. If not possible, a 409 Conflict status will be returned.</value>
        [DataMember(Name="preconditions", EmitDefaultValue=false)]
        public V1Preconditions Preconditions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1DeleteOptions {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  GracePeriodSeconds: ").Append(GracePeriodSeconds).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  OrphanDependents: ").Append(OrphanDependents).Append("\n");
            sb.Append("  Preconditions: ").Append(Preconditions).Append("\n");
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
            return this.Equals(obj as V1DeleteOptions);
        }

        /// <summary>
        /// Returns true if V1DeleteOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of V1DeleteOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1DeleteOptions other)
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
                    this.GracePeriodSeconds == other.GracePeriodSeconds ||
                    this.GracePeriodSeconds != null &&
                    this.GracePeriodSeconds.Equals(other.GracePeriodSeconds)
                ) && 
                (
                    this.Kind == other.Kind ||
                    this.Kind != null &&
                    this.Kind.Equals(other.Kind)
                ) && 
                (
                    this.OrphanDependents == other.OrphanDependents ||
                    this.OrphanDependents != null &&
                    this.OrphanDependents.Equals(other.OrphanDependents)
                ) && 
                (
                    this.Preconditions == other.Preconditions ||
                    this.Preconditions != null &&
                    this.Preconditions.Equals(other.Preconditions)
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
                if (this.GracePeriodSeconds != null)
                    hash = hash * 59 + this.GracePeriodSeconds.GetHashCode();
                if (this.Kind != null)
                    hash = hash * 59 + this.Kind.GetHashCode();
                if (this.OrphanDependents != null)
                    hash = hash * 59 + this.OrphanDependents.GetHashCode();
                if (this.Preconditions != null)
                    hash = hash * 59 + this.Preconditions.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
