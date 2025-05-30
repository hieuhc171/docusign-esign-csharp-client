/* 
 * Docusign eSignature REST API
 *
 * The Docusign eSignature REST API provides you with a powerful, convenient, and simple Web services API for interacting with Docusign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// Object representing a new user.
    /// </summary>
    [DataContract]
    public partial class NewUser :  IEquatable<NewUser>, IValidatableObject
    {
        public NewUser()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewUser" /> class.
        /// </summary>
        /// <param name="ApiPassword">Contains a token that can be used for authentication in API calls instead of using the user name and password..</param>
        /// <param name="CreatedDateTime">Indicates the date and time the item was created..</param>
        /// <param name="Email">Email.</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="LicenseStatus">LicenseStatus.</param>
        /// <param name="LicenseType">LicenseType.</param>
        /// <param name="MembershipId">MembershipId.</param>
        /// <param name="PermissionProfileId">PermissionProfileId.</param>
        /// <param name="PermissionProfileName">PermissionProfileName.</param>
        /// <param name="Uri">Uri.</param>
        /// <param name="UserId">Specifies the user ID for the new user..</param>
        /// <param name="UserName">UserName.</param>
        /// <param name="UserStatus">UserStatus.</param>
        public NewUser(string ApiPassword = default(string), string CreatedDateTime = default(string), string Email = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string LicenseStatus = default(string), string LicenseType = default(string), string MembershipId = default(string), string PermissionProfileId = default(string), string PermissionProfileName = default(string), string Uri = default(string), string UserId = default(string), string UserName = default(string), string UserStatus = default(string))
        {
            this.ApiPassword = ApiPassword;
            this.CreatedDateTime = CreatedDateTime;
            this.Email = Email;
            this.ErrorDetails = ErrorDetails;
            this.LicenseStatus = LicenseStatus;
            this.LicenseType = LicenseType;
            this.MembershipId = MembershipId;
            this.PermissionProfileId = PermissionProfileId;
            this.PermissionProfileName = PermissionProfileName;
            this.Uri = Uri;
            this.UserId = UserId;
            this.UserName = UserName;
            this.UserStatus = UserStatus;
        }
        
        /// <summary>
        /// Contains a token that can be used for authentication in API calls instead of using the user name and password.
        /// </summary>
        /// <value>Contains a token that can be used for authentication in API calls instead of using the user name and password.</value>
        [DataMember(Name="apiPassword", EmitDefaultValue=false)]
        public string ApiPassword { get; set; }
        /// <summary>
        /// Indicates the date and time the item was created.
        /// </summary>
        /// <value>Indicates the date and time the item was created.</value>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public string CreatedDateTime { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets LicenseStatus
        /// </summary>
        [DataMember(Name="licenseStatus", EmitDefaultValue=false)]
        public string LicenseStatus { get; set; }
        /// <summary>
        /// Gets or Sets LicenseType
        /// </summary>
        [DataMember(Name="licenseType", EmitDefaultValue=false)]
        public string LicenseType { get; set; }
        /// <summary>
        /// Gets or Sets MembershipId
        /// </summary>
        [DataMember(Name="membershipId", EmitDefaultValue=false)]
        public string MembershipId { get; set; }
        /// <summary>
        /// Gets or Sets PermissionProfileId
        /// </summary>
        [DataMember(Name="permissionProfileId", EmitDefaultValue=false)]
        public string PermissionProfileId { get; set; }
        /// <summary>
        /// Gets or Sets PermissionProfileName
        /// </summary>
        [DataMember(Name="permissionProfileName", EmitDefaultValue=false)]
        public string PermissionProfileName { get; set; }
        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
        /// <summary>
        /// Specifies the user ID for the new user.
        /// </summary>
        /// <value>Specifies the user ID for the new user.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
        /// <summary>
        /// Gets or Sets UserStatus
        /// </summary>
        [DataMember(Name="userStatus", EmitDefaultValue=false)]
        public string UserStatus { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewUser {\n");
            sb.Append("  ApiPassword: ").Append(ApiPassword).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  LicenseStatus: ").Append(LicenseStatus).Append("\n");
            sb.Append("  LicenseType: ").Append(LicenseType).Append("\n");
            sb.Append("  MembershipId: ").Append(MembershipId).Append("\n");
            sb.Append("  PermissionProfileId: ").Append(PermissionProfileId).Append("\n");
            sb.Append("  PermissionProfileName: ").Append(PermissionProfileName).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
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
            return this.Equals(obj as NewUser);
        }

        /// <summary>
        /// Returns true if NewUser instances are equal
        /// </summary>
        /// <param name="other">Instance of NewUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewUser other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiPassword == other.ApiPassword ||
                    this.ApiPassword != null &&
                    this.ApiPassword.Equals(other.ApiPassword)
                ) && 
                (
                    this.CreatedDateTime == other.CreatedDateTime ||
                    this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(other.CreatedDateTime)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.LicenseStatus == other.LicenseStatus ||
                    this.LicenseStatus != null &&
                    this.LicenseStatus.Equals(other.LicenseStatus)
                ) && 
                (
                    this.LicenseType == other.LicenseType ||
                    this.LicenseType != null &&
                    this.LicenseType.Equals(other.LicenseType)
                ) && 
                (
                    this.MembershipId == other.MembershipId ||
                    this.MembershipId != null &&
                    this.MembershipId.Equals(other.MembershipId)
                ) && 
                (
                    this.PermissionProfileId == other.PermissionProfileId ||
                    this.PermissionProfileId != null &&
                    this.PermissionProfileId.Equals(other.PermissionProfileId)
                ) && 
                (
                    this.PermissionProfileName == other.PermissionProfileName ||
                    this.PermissionProfileName != null &&
                    this.PermissionProfileName.Equals(other.PermissionProfileName)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.UserStatus == other.UserStatus ||
                    this.UserStatus != null &&
                    this.UserStatus.Equals(other.UserStatus)
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
                if (this.ApiPassword != null)
                    hash = hash * 59 + this.ApiPassword.GetHashCode();
                if (this.CreatedDateTime != null)
                    hash = hash * 59 + this.CreatedDateTime.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.LicenseStatus != null)
                    hash = hash * 59 + this.LicenseStatus.GetHashCode();
                if (this.LicenseType != null)
                    hash = hash * 59 + this.LicenseType.GetHashCode();
                if (this.MembershipId != null)
                    hash = hash * 59 + this.MembershipId.GetHashCode();
                if (this.PermissionProfileId != null)
                    hash = hash * 59 + this.PermissionProfileId.GetHashCode();
                if (this.PermissionProfileName != null)
                    hash = hash * 59 + this.PermissionProfileName.GetHashCode();
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.UserStatus != null)
                    hash = hash * 59 + this.UserStatus.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
