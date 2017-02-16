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
    /// ResourceFieldSelector represents container resources (cpu, memory) and their output format
    /// </summary>
    [DataContract]
    public partial class V1ResourceFieldSelector :  IEquatable<V1ResourceFieldSelector>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ResourceFieldSelector" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1ResourceFieldSelector() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ResourceFieldSelector" /> class.
        /// </summary>
        /// <param name="ContainerName">Container name: required for volumes, optional for env vars.</param>
        /// <param name="Divisor">Specifies the output format of the exposed resources, defaults to \&quot;1\&quot;.</param>
        /// <param name="Resource">Required: resource to select (required).</param>
        public V1ResourceFieldSelector(string ContainerName = default(string), ResourceQuantity Divisor = default(ResourceQuantity), string Resource = default(string))
        {
            // to ensure "Resource" is required (not null)
            if (Resource == null)
            {
                throw new InvalidDataException("Resource is a required property for V1ResourceFieldSelector and cannot be null");
            }
            else
            {
                this.Resource = Resource;
            }
            this.ContainerName = ContainerName;
            this.Divisor = Divisor;
        }
        
        /// <summary>
        /// Container name: required for volumes, optional for env vars
        /// </summary>
        /// <value>Container name: required for volumes, optional for env vars</value>
        [DataMember(Name="containerName", EmitDefaultValue=false)]
        public string ContainerName { get; set; }
        /// <summary>
        /// Specifies the output format of the exposed resources, defaults to \&quot;1\&quot;
        /// </summary>
        /// <value>Specifies the output format of the exposed resources, defaults to \&quot;1\&quot;</value>
        [DataMember(Name="divisor", EmitDefaultValue=false)]
        public ResourceQuantity Divisor { get; set; }
        /// <summary>
        /// Required: resource to select
        /// </summary>
        /// <value>Required: resource to select</value>
        [DataMember(Name="resource", EmitDefaultValue=false)]
        public string Resource { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1ResourceFieldSelector {\n");
            sb.Append("  ContainerName: ").Append(ContainerName).Append("\n");
            sb.Append("  Divisor: ").Append(Divisor).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
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
            return this.Equals(obj as V1ResourceFieldSelector);
        }

        /// <summary>
        /// Returns true if V1ResourceFieldSelector instances are equal
        /// </summary>
        /// <param name="other">Instance of V1ResourceFieldSelector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1ResourceFieldSelector other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContainerName == other.ContainerName ||
                    this.ContainerName != null &&
                    this.ContainerName.Equals(other.ContainerName)
                ) && 
                (
                    this.Divisor == other.Divisor ||
                    this.Divisor != null &&
                    this.Divisor.Equals(other.Divisor)
                ) && 
                (
                    this.Resource == other.Resource ||
                    this.Resource != null &&
                    this.Resource.Equals(other.Resource)
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
                if (this.ContainerName != null)
                    hash = hash * 59 + this.ContainerName.GetHashCode();
                if (this.Divisor != null)
                    hash = hash * 59 + this.Divisor.GetHashCode();
                if (this.Resource != null)
                    hash = hash * 59 + this.Resource.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}