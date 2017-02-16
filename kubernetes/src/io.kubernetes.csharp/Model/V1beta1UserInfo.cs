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
    /// UserInfo holds the information about the user needed to implement the user.Info interface.
    /// </summary>
    [DataContract]
    public partial class V1beta1UserInfo :  IEquatable<V1beta1UserInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1UserInfo" /> class.
        /// </summary>
        /// <param name="Extra">Any additional information provided by the authenticator..</param>
        /// <param name="Groups">The names of groups this user is a part of..</param>
        /// <param name="Uid">A unique value that identifies this user across time. If this user is deleted and another user by the same name is added, they will have different UIDs..</param>
        /// <param name="Username">The name that uniquely identifies this user among all active users..</param>
        public V1beta1UserInfo(Dictionary<string, List<string>> Extra = default(Dictionary<string, List<string>>), List<string> Groups = default(List<string>), string Uid = default(string), string Username = default(string))
        {
            this.Extra = Extra;
            this.Groups = Groups;
            this.Uid = Uid;
            this.Username = Username;
        }
        
        /// <summary>
        /// Any additional information provided by the authenticator.
        /// </summary>
        /// <value>Any additional information provided by the authenticator.</value>
        [DataMember(Name="extra", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> Extra { get; set; }
        /// <summary>
        /// The names of groups this user is a part of.
        /// </summary>
        /// <value>The names of groups this user is a part of.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }
        /// <summary>
        /// A unique value that identifies this user across time. If this user is deleted and another user by the same name is added, they will have different UIDs.
        /// </summary>
        /// <value>A unique value that identifies this user across time. If this user is deleted and another user by the same name is added, they will have different UIDs.</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
        /// <summary>
        /// The name that uniquely identifies this user among all active users.
        /// </summary>
        /// <value>The name that uniquely identifies this user among all active users.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1beta1UserInfo {\n");
            sb.Append("  Extra: ").Append(Extra).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(obj as V1beta1UserInfo);
        }

        /// <summary>
        /// Returns true if V1beta1UserInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of V1beta1UserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1beta1UserInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Extra == other.Extra ||
                    this.Extra != null &&
                    this.Extra.SequenceEqual(other.Extra)
                ) && 
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) && 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
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
                if (this.Extra != null)
                    hash = hash * 59 + this.Extra.GetHashCode();
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
