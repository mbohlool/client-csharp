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
    /// TokenReviewStatus is the result of the token authentication request.
    /// </summary>
    [DataContract]
    public partial class V1beta1TokenReviewStatus :  IEquatable<V1beta1TokenReviewStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1TokenReviewStatus" /> class.
        /// </summary>
        /// <param name="Authenticated">Authenticated indicates that the token was associated with a known user..</param>
        /// <param name="Error">Error indicates that the token couldn&#39;t be checked.</param>
        /// <param name="User">User is the UserInfo associated with the provided token..</param>
        public V1beta1TokenReviewStatus(bool? Authenticated = default(bool?), string Error = default(string), V1beta1UserInfo User = default(V1beta1UserInfo))
        {
            this.Authenticated = Authenticated;
            this.Error = Error;
            this.User = User;
        }
        
        /// <summary>
        /// Authenticated indicates that the token was associated with a known user.
        /// </summary>
        /// <value>Authenticated indicates that the token was associated with a known user.</value>
        [DataMember(Name="authenticated", EmitDefaultValue=false)]
        public bool? Authenticated { get; set; }
        /// <summary>
        /// Error indicates that the token couldn&#39;t be checked
        /// </summary>
        /// <value>Error indicates that the token couldn&#39;t be checked</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }
        /// <summary>
        /// User is the UserInfo associated with the provided token.
        /// </summary>
        /// <value>User is the UserInfo associated with the provided token.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public V1beta1UserInfo User { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1beta1TokenReviewStatus {\n");
            sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as V1beta1TokenReviewStatus);
        }

        /// <summary>
        /// Returns true if V1beta1TokenReviewStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of V1beta1TokenReviewStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1beta1TokenReviewStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Authenticated == other.Authenticated ||
                    this.Authenticated != null &&
                    this.Authenticated.Equals(other.Authenticated)
                ) && 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.Authenticated != null)
                    hash = hash * 59 + this.Authenticated.GetHashCode();
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
