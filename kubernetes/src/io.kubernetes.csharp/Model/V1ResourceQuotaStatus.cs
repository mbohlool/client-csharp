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
    /// ResourceQuotaStatus defines the enforced hard limits and observed use.
    /// </summary>
    [DataContract]
    public partial class V1ResourceQuotaStatus :  IEquatable<V1ResourceQuotaStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ResourceQuotaStatus" /> class.
        /// </summary>
        /// <param name="Hard">Hard is the set of enforced hard limits for each named resource. More info: http://releases.k8s.io/HEAD/docs/design/admission_control_resource_quota.md#admissioncontrol-plugin-resourcequota.</param>
        /// <param name="Used">Used is the current observed total usage of the resource in the namespace..</param>
        public V1ResourceQuotaStatus(Dictionary<string, ResourceQuantity> Hard = default(Dictionary<string, ResourceQuantity>), Dictionary<string, ResourceQuantity> Used = default(Dictionary<string, ResourceQuantity>))
        {
            this.Hard = Hard;
            this.Used = Used;
        }
        
        /// <summary>
        /// Hard is the set of enforced hard limits for each named resource. More info: http://releases.k8s.io/HEAD/docs/design/admission_control_resource_quota.md#admissioncontrol-plugin-resourcequota
        /// </summary>
        /// <value>Hard is the set of enforced hard limits for each named resource. More info: http://releases.k8s.io/HEAD/docs/design/admission_control_resource_quota.md#admissioncontrol-plugin-resourcequota</value>
        [DataMember(Name="hard", EmitDefaultValue=false)]
        public Dictionary<string, ResourceQuantity> Hard { get; set; }
        /// <summary>
        /// Used is the current observed total usage of the resource in the namespace.
        /// </summary>
        /// <value>Used is the current observed total usage of the resource in the namespace.</value>
        [DataMember(Name="used", EmitDefaultValue=false)]
        public Dictionary<string, ResourceQuantity> Used { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1ResourceQuotaStatus {\n");
            sb.Append("  Hard: ").Append(Hard).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
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
            return this.Equals(obj as V1ResourceQuotaStatus);
        }

        /// <summary>
        /// Returns true if V1ResourceQuotaStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of V1ResourceQuotaStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1ResourceQuotaStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Hard == other.Hard ||
                    this.Hard != null &&
                    this.Hard.SequenceEqual(other.Hard)
                ) && 
                (
                    this.Used == other.Used ||
                    this.Used != null &&
                    this.Used.SequenceEqual(other.Used)
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
                if (this.Hard != null)
                    hash = hash * 59 + this.Hard.GetHashCode();
                if (this.Used != null)
                    hash = hash * 59 + this.Used.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}