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
    /// Represents a Photon Controller persistent disk resource.
    /// </summary>
    [DataContract]
    public partial class V1PhotonPersistentDiskVolumeSource :  IEquatable<V1PhotonPersistentDiskVolumeSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PhotonPersistentDiskVolumeSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1PhotonPersistentDiskVolumeSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PhotonPersistentDiskVolumeSource" /> class.
        /// </summary>
        /// <param name="FsType">Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified..</param>
        /// <param name="PdID">ID that identifies Photon Controller persistent disk (required).</param>
        public V1PhotonPersistentDiskVolumeSource(string FsType = default(string), string PdID = default(string))
        {
            // to ensure "PdID" is required (not null)
            if (PdID == null)
            {
                throw new InvalidDataException("PdID is a required property for V1PhotonPersistentDiskVolumeSource and cannot be null");
            }
            else
            {
                this.PdID = PdID;
            }
            this.FsType = FsType;
        }
        
        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified.
        /// </summary>
        /// <value>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified.</value>
        [DataMember(Name="fsType", EmitDefaultValue=false)]
        public string FsType { get; set; }
        /// <summary>
        /// ID that identifies Photon Controller persistent disk
        /// </summary>
        /// <value>ID that identifies Photon Controller persistent disk</value>
        [DataMember(Name="pdID", EmitDefaultValue=false)]
        public string PdID { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PhotonPersistentDiskVolumeSource {\n");
            sb.Append("  FsType: ").Append(FsType).Append("\n");
            sb.Append("  PdID: ").Append(PdID).Append("\n");
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
            return this.Equals(obj as V1PhotonPersistentDiskVolumeSource);
        }

        /// <summary>
        /// Returns true if V1PhotonPersistentDiskVolumeSource instances are equal
        /// </summary>
        /// <param name="other">Instance of V1PhotonPersistentDiskVolumeSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PhotonPersistentDiskVolumeSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FsType == other.FsType ||
                    this.FsType != null &&
                    this.FsType.Equals(other.FsType)
                ) && 
                (
                    this.PdID == other.PdID ||
                    this.PdID != null &&
                    this.PdID.Equals(other.PdID)
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
                if (this.FsType != null)
                    hash = hash * 59 + this.FsType.GetHashCode();
                if (this.PdID != null)
                    hash = hash * 59 + this.PdID.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}