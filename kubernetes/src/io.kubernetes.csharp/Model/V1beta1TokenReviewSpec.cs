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
    /// TokenReviewSpec is a description of the token authentication request.
    /// </summary>
    [DataContract]
    public partial class V1beta1TokenReviewSpec :  IEquatable<V1beta1TokenReviewSpec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1TokenReviewSpec" /> class.
        /// </summary>
        /// <param name="Token">Token is the opaque bearer token..</param>
        public V1beta1TokenReviewSpec(string Token = default(string))
        {
            this.Token = Token;
        }
        
        /// <summary>
        /// Token is the opaque bearer token.
        /// </summary>
        /// <value>Token is the opaque bearer token.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1beta1TokenReviewSpec {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(obj as V1beta1TokenReviewSpec);
        }

        /// <summary>
        /// Returns true if V1beta1TokenReviewSpec instances are equal
        /// </summary>
        /// <param name="other">Instance of V1beta1TokenReviewSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1beta1TokenReviewSpec other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
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
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
