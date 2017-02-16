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
    /// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference, or a value for non-objects such as user and group names.
    /// </summary>
    [DataContract]
    public partial class V1alpha1Subject :  IEquatable<V1alpha1Subject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1alpha1Subject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1alpha1Subject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1alpha1Subject" /> class.
        /// </summary>
        /// <param name="ApiVersion">APIVersion holds the API group and version of the referenced object..</param>
        /// <param name="Kind">Kind of object being referenced. Values defined by this API group are \&quot;User\&quot;, \&quot;Group\&quot;, and \&quot;ServiceAccount\&quot;. If the Authorizer does not recognized the kind value, the Authorizer should report an error. (required).</param>
        /// <param name="Name">Name of the object being referenced. (required).</param>
        /// <param name="_Namespace">Namespace of the referenced object.  If the object kind is non-namespace, such as \&quot;User\&quot; or \&quot;Group\&quot;, and this value is not empty the Authorizer should report an error..</param>
        public V1alpha1Subject(string ApiVersion = default(string), string Kind = default(string), string Name = default(string), string _Namespace = default(string))
        {
            // to ensure "Kind" is required (not null)
            if (Kind == null)
            {
                throw new InvalidDataException("Kind is a required property for V1alpha1Subject and cannot be null");
            }
            else
            {
                this.Kind = Kind;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for V1alpha1Subject and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.ApiVersion = ApiVersion;
            this._Namespace = _Namespace;
        }
        
        /// <summary>
        /// APIVersion holds the API group and version of the referenced object.
        /// </summary>
        /// <value>APIVersion holds the API group and version of the referenced object.</value>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }
        /// <summary>
        /// Kind of object being referenced. Values defined by this API group are \&quot;User\&quot;, \&quot;Group\&quot;, and \&quot;ServiceAccount\&quot;. If the Authorizer does not recognized the kind value, the Authorizer should report an error.
        /// </summary>
        /// <value>Kind of object being referenced. Values defined by this API group are \&quot;User\&quot;, \&quot;Group\&quot;, and \&quot;ServiceAccount\&quot;. If the Authorizer does not recognized the kind value, the Authorizer should report an error.</value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public string Kind { get; set; }
        /// <summary>
        /// Name of the object being referenced.
        /// </summary>
        /// <value>Name of the object being referenced.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Namespace of the referenced object.  If the object kind is non-namespace, such as \&quot;User\&quot; or \&quot;Group\&quot;, and this value is not empty the Authorizer should report an error.
        /// </summary>
        /// <value>Namespace of the referenced object.  If the object kind is non-namespace, such as \&quot;User\&quot; or \&quot;Group\&quot;, and this value is not empty the Authorizer should report an error.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string _Namespace { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1alpha1Subject {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
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
            return this.Equals(obj as V1alpha1Subject);
        }

        /// <summary>
        /// Returns true if V1alpha1Subject instances are equal
        /// </summary>
        /// <param name="other">Instance of V1alpha1Subject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1alpha1Subject other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiVersion == other.ApiVersion ||
                    this.ApiVersion != null &&
                    this.ApiVersion.Equals(other.ApiVersion)
                ) && 
                (
                    this.Kind == other.Kind ||
                    this.Kind != null &&
                    this.Kind.Equals(other.Kind)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this._Namespace == other._Namespace ||
                    this._Namespace != null &&
                    this._Namespace.Equals(other._Namespace)
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
                if (this.ApiVersion != null)
                    hash = hash * 59 + this.ApiVersion.GetHashCode();
                if (this.Kind != null)
                    hash = hash * 59 + this.Kind.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this._Namespace != null)
                    hash = hash * 59 + this._Namespace.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}