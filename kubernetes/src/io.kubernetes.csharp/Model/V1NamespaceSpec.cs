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
    /// NamespaceSpec describes the attributes on a Namespace.
    /// </summary>
    [DataContract]
    public partial class V1NamespaceSpec :  IEquatable<V1NamespaceSpec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1NamespaceSpec" /> class.
        /// </summary>
        /// <param name="Finalizers">Finalizers is an opaque list of values that must be empty to permanently remove object from storage. More info: http://releases.k8s.io/HEAD/docs/design/namespaces.md#finalizers.</param>
        public V1NamespaceSpec(List<string> Finalizers = default(List<string>))
        {
            this.Finalizers = Finalizers;
        }
        
        /// <summary>
        /// Finalizers is an opaque list of values that must be empty to permanently remove object from storage. More info: http://releases.k8s.io/HEAD/docs/design/namespaces.md#finalizers
        /// </summary>
        /// <value>Finalizers is an opaque list of values that must be empty to permanently remove object from storage. More info: http://releases.k8s.io/HEAD/docs/design/namespaces.md#finalizers</value>
        [DataMember(Name="finalizers", EmitDefaultValue=false)]
        public List<string> Finalizers { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1NamespaceSpec {\n");
            sb.Append("  Finalizers: ").Append(Finalizers).Append("\n");
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
            return this.Equals(obj as V1NamespaceSpec);
        }

        /// <summary>
        /// Returns true if V1NamespaceSpec instances are equal
        /// </summary>
        /// <param name="other">Instance of V1NamespaceSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1NamespaceSpec other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Finalizers == other.Finalizers ||
                    this.Finalizers != null &&
                    this.Finalizers.SequenceEqual(other.Finalizers)
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
                if (this.Finalizers != null)
                    hash = hash * 59 + this.Finalizers.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
