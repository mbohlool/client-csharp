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
    /// NamespaceStatus is information about the current status of a Namespace.
    /// </summary>
    [DataContract]
    public partial class V1NamespaceStatus :  IEquatable<V1NamespaceStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1NamespaceStatus" /> class.
        /// </summary>
        /// <param name="Phase">Phase is the current lifecycle phase of the namespace. More info: http://releases.k8s.io/HEAD/docs/design/namespaces.md#phases.</param>
        public V1NamespaceStatus(string Phase = default(string))
        {
            this.Phase = Phase;
        }
        
        /// <summary>
        /// Phase is the current lifecycle phase of the namespace. More info: http://releases.k8s.io/HEAD/docs/design/namespaces.md#phases
        /// </summary>
        /// <value>Phase is the current lifecycle phase of the namespace. More info: http://releases.k8s.io/HEAD/docs/design/namespaces.md#phases</value>
        [DataMember(Name="phase", EmitDefaultValue=false)]
        public string Phase { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1NamespaceStatus {\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
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
            return this.Equals(obj as V1NamespaceStatus);
        }

        /// <summary>
        /// Returns true if V1NamespaceStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of V1NamespaceStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1NamespaceStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Phase == other.Phase ||
                    this.Phase != null &&
                    this.Phase.Equals(other.Phase)
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
                if (this.Phase != null)
                    hash = hash * 59 + this.Phase.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}