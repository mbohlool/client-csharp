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
    /// PersistentVolumeClaimStatus is the current status of a persistent volume claim.
    /// </summary>
    [DataContract]
    public partial class V1PersistentVolumeClaimStatus :  IEquatable<V1PersistentVolumeClaimStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PersistentVolumeClaimStatus" /> class.
        /// </summary>
        /// <param name="AccessModes">AccessModes contains the actual access modes the volume backing the PVC has. More info: http://kubernetes.io/docs/user-guide/persistent-volumes#access-modes-1.</param>
        /// <param name="Capacity">Represents the actual resources of the underlying volume..</param>
        /// <param name="Phase">Phase represents the current phase of PersistentVolumeClaim..</param>
        public V1PersistentVolumeClaimStatus(List<string> AccessModes = default(List<string>), Dictionary<string, ResourceQuantity> Capacity = default(Dictionary<string, ResourceQuantity>), string Phase = default(string))
        {
            this.AccessModes = AccessModes;
            this.Capacity = Capacity;
            this.Phase = Phase;
        }
        
        /// <summary>
        /// AccessModes contains the actual access modes the volume backing the PVC has. More info: http://kubernetes.io/docs/user-guide/persistent-volumes#access-modes-1
        /// </summary>
        /// <value>AccessModes contains the actual access modes the volume backing the PVC has. More info: http://kubernetes.io/docs/user-guide/persistent-volumes#access-modes-1</value>
        [DataMember(Name="accessModes", EmitDefaultValue=false)]
        public List<string> AccessModes { get; set; }
        /// <summary>
        /// Represents the actual resources of the underlying volume.
        /// </summary>
        /// <value>Represents the actual resources of the underlying volume.</value>
        [DataMember(Name="capacity", EmitDefaultValue=false)]
        public Dictionary<string, ResourceQuantity> Capacity { get; set; }
        /// <summary>
        /// Phase represents the current phase of PersistentVolumeClaim.
        /// </summary>
        /// <value>Phase represents the current phase of PersistentVolumeClaim.</value>
        [DataMember(Name="phase", EmitDefaultValue=false)]
        public string Phase { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PersistentVolumeClaimStatus {\n");
            sb.Append("  AccessModes: ").Append(AccessModes).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
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
            return this.Equals(obj as V1PersistentVolumeClaimStatus);
        }

        /// <summary>
        /// Returns true if V1PersistentVolumeClaimStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of V1PersistentVolumeClaimStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PersistentVolumeClaimStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessModes == other.AccessModes ||
                    this.AccessModes != null &&
                    this.AccessModes.SequenceEqual(other.AccessModes)
                ) && 
                (
                    this.Capacity == other.Capacity ||
                    this.Capacity != null &&
                    this.Capacity.SequenceEqual(other.Capacity)
                ) && 
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
                if (this.AccessModes != null)
                    hash = hash * 59 + this.AccessModes.GetHashCode();
                if (this.Capacity != null)
                    hash = hash * 59 + this.Capacity.GetHashCode();
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
