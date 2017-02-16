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
    /// SelfSubjectAccessReviewSpec is a description of the access request.  Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set
    /// </summary>
    [DataContract]
    public partial class V1beta1SelfSubjectAccessReviewSpec :  IEquatable<V1beta1SelfSubjectAccessReviewSpec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1SelfSubjectAccessReviewSpec" /> class.
        /// </summary>
        /// <param name="NonResourceAttributes">NonResourceAttributes describes information for a non-resource access request.</param>
        /// <param name="ResourceAttributes">ResourceAuthorizationAttributes describes information for a resource access request.</param>
        public V1beta1SelfSubjectAccessReviewSpec(V1beta1NonResourceAttributes NonResourceAttributes = default(V1beta1NonResourceAttributes), V1beta1ResourceAttributes ResourceAttributes = default(V1beta1ResourceAttributes))
        {
            this.NonResourceAttributes = NonResourceAttributes;
            this.ResourceAttributes = ResourceAttributes;
        }
        
        /// <summary>
        /// NonResourceAttributes describes information for a non-resource access request
        /// </summary>
        /// <value>NonResourceAttributes describes information for a non-resource access request</value>
        [DataMember(Name="nonResourceAttributes", EmitDefaultValue=false)]
        public V1beta1NonResourceAttributes NonResourceAttributes { get; set; }
        /// <summary>
        /// ResourceAuthorizationAttributes describes information for a resource access request
        /// </summary>
        /// <value>ResourceAuthorizationAttributes describes information for a resource access request</value>
        [DataMember(Name="resourceAttributes", EmitDefaultValue=false)]
        public V1beta1ResourceAttributes ResourceAttributes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1beta1SelfSubjectAccessReviewSpec {\n");
            sb.Append("  NonResourceAttributes: ").Append(NonResourceAttributes).Append("\n");
            sb.Append("  ResourceAttributes: ").Append(ResourceAttributes).Append("\n");
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
            return this.Equals(obj as V1beta1SelfSubjectAccessReviewSpec);
        }

        /// <summary>
        /// Returns true if V1beta1SelfSubjectAccessReviewSpec instances are equal
        /// </summary>
        /// <param name="other">Instance of V1beta1SelfSubjectAccessReviewSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1beta1SelfSubjectAccessReviewSpec other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NonResourceAttributes == other.NonResourceAttributes ||
                    this.NonResourceAttributes != null &&
                    this.NonResourceAttributes.Equals(other.NonResourceAttributes)
                ) && 
                (
                    this.ResourceAttributes == other.ResourceAttributes ||
                    this.ResourceAttributes != null &&
                    this.ResourceAttributes.Equals(other.ResourceAttributes)
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
                if (this.NonResourceAttributes != null)
                    hash = hash * 59 + this.NonResourceAttributes.GetHashCode();
                if (this.ResourceAttributes != null)
                    hash = hash * 59 + this.ResourceAttributes.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
