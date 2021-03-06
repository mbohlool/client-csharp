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
    /// V1beta1NetworkPolicyPeer
    /// </summary>
    [DataContract]
    public partial class V1beta1NetworkPolicyPeer :  IEquatable<V1beta1NetworkPolicyPeer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1NetworkPolicyPeer" /> class.
        /// </summary>
        /// <param name="NamespaceSelector">Selects Namespaces using cluster scoped-labels.  This matches all pods in all namespaces selected by this label selector. This field follows standard label selector semantics. If omitted, this selector selects no namespaces. If present but empty, this selector selects all namespaces..</param>
        /// <param name="PodSelector">This is a label selector which selects Pods in this namespace. This field follows standard label selector semantics. If not provided, this selector selects no pods. If present but empty, this selector selects all pods in this namespace..</param>
        public V1beta1NetworkPolicyPeer(UnversionedLabelSelector NamespaceSelector = default(UnversionedLabelSelector), UnversionedLabelSelector PodSelector = default(UnversionedLabelSelector))
        {
            this.NamespaceSelector = NamespaceSelector;
            this.PodSelector = PodSelector;
        }
        
        /// <summary>
        /// Selects Namespaces using cluster scoped-labels.  This matches all pods in all namespaces selected by this label selector. This field follows standard label selector semantics. If omitted, this selector selects no namespaces. If present but empty, this selector selects all namespaces.
        /// </summary>
        /// <value>Selects Namespaces using cluster scoped-labels.  This matches all pods in all namespaces selected by this label selector. This field follows standard label selector semantics. If omitted, this selector selects no namespaces. If present but empty, this selector selects all namespaces.</value>
        [DataMember(Name="namespaceSelector", EmitDefaultValue=false)]
        public UnversionedLabelSelector NamespaceSelector { get; set; }
        /// <summary>
        /// This is a label selector which selects Pods in this namespace. This field follows standard label selector semantics. If not provided, this selector selects no pods. If present but empty, this selector selects all pods in this namespace.
        /// </summary>
        /// <value>This is a label selector which selects Pods in this namespace. This field follows standard label selector semantics. If not provided, this selector selects no pods. If present but empty, this selector selects all pods in this namespace.</value>
        [DataMember(Name="podSelector", EmitDefaultValue=false)]
        public UnversionedLabelSelector PodSelector { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1beta1NetworkPolicyPeer {\n");
            sb.Append("  NamespaceSelector: ").Append(NamespaceSelector).Append("\n");
            sb.Append("  PodSelector: ").Append(PodSelector).Append("\n");
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
            return this.Equals(obj as V1beta1NetworkPolicyPeer);
        }

        /// <summary>
        /// Returns true if V1beta1NetworkPolicyPeer instances are equal
        /// </summary>
        /// <param name="other">Instance of V1beta1NetworkPolicyPeer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1beta1NetworkPolicyPeer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NamespaceSelector == other.NamespaceSelector ||
                    this.NamespaceSelector != null &&
                    this.NamespaceSelector.Equals(other.NamespaceSelector)
                ) && 
                (
                    this.PodSelector == other.PodSelector ||
                    this.PodSelector != null &&
                    this.PodSelector.Equals(other.PodSelector)
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
                if (this.NamespaceSelector != null)
                    hash = hash * 59 + this.NamespaceSelector.GetHashCode();
                if (this.PodSelector != null)
                    hash = hash * 59 + this.PodSelector.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
