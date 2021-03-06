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
    /// IngressBackend describes all endpoints for a given service and port.
    /// </summary>
    [DataContract]
    public partial class V1beta1IngressBackend :  IEquatable<V1beta1IngressBackend>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1IngressBackend" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1beta1IngressBackend() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1IngressBackend" /> class.
        /// </summary>
        /// <param name="ServiceName">Specifies the name of the referenced service. (required).</param>
        /// <param name="ServicePort">Specifies the port of the referenced service. (required).</param>
        public V1beta1IngressBackend(string ServiceName = default(string), IntstrIntOrString ServicePort = default(IntstrIntOrString))
        {
            // to ensure "ServiceName" is required (not null)
            if (ServiceName == null)
            {
                throw new InvalidDataException("ServiceName is a required property for V1beta1IngressBackend and cannot be null");
            }
            else
            {
                this.ServiceName = ServiceName;
            }
            // to ensure "ServicePort" is required (not null)
            if (ServicePort == null)
            {
                throw new InvalidDataException("ServicePort is a required property for V1beta1IngressBackend and cannot be null");
            }
            else
            {
                this.ServicePort = ServicePort;
            }
        }
        
        /// <summary>
        /// Specifies the name of the referenced service.
        /// </summary>
        /// <value>Specifies the name of the referenced service.</value>
        [DataMember(Name="serviceName", EmitDefaultValue=false)]
        public string ServiceName { get; set; }
        /// <summary>
        /// Specifies the port of the referenced service.
        /// </summary>
        /// <value>Specifies the port of the referenced service.</value>
        [DataMember(Name="servicePort", EmitDefaultValue=false)]
        public IntstrIntOrString ServicePort { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1beta1IngressBackend {\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  ServicePort: ").Append(ServicePort).Append("\n");
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
            return this.Equals(obj as V1beta1IngressBackend);
        }

        /// <summary>
        /// Returns true if V1beta1IngressBackend instances are equal
        /// </summary>
        /// <param name="other">Instance of V1beta1IngressBackend to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1beta1IngressBackend other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ServiceName == other.ServiceName ||
                    this.ServiceName != null &&
                    this.ServiceName.Equals(other.ServiceName)
                ) && 
                (
                    this.ServicePort == other.ServicePort ||
                    this.ServicePort != null &&
                    this.ServicePort.Equals(other.ServicePort)
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
                if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();
                if (this.ServicePort != null)
                    hash = hash * 59 + this.ServicePort.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
