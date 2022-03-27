﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TodoTemplate.Shared.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ErrorStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TodoTemplate.Shared.Resources.ErrorStrings", typeof(ErrorStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid request.
        /// </summary>
        public static string BadRequestException {
            get {
                return ResourceManager.GetString("BadRequestException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optimistic concurrency failure, object has been modified..
        /// </summary>
        public static string ConcurrencyFailure {
            get {
                return ResourceManager.GetString("ConcurrencyFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request could not be processed because of conflict in the request.
        /// </summary>
        public static string ConflicException {
            get {
                return ResourceManager.GetString("ConflicException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email &apos;{0}&apos; is already taken..
        /// </summary>
        public static string DuplicateEmail {
            get {
                return ResourceManager.GetString("DuplicateEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Role name &apos;{0}&apos; is already taken..
        /// </summary>
        public static string DuplicateRoleName {
            get {
                return ResourceManager.GetString("DuplicateRoleName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username &apos;{0}&apos; is already taken..
        /// </summary>
        public static string DuplicateUserName {
            get {
                return ResourceManager.GetString("DuplicateUserName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email &apos;{0}&apos; is not confirmed..
        /// </summary>
        public static string EmailNotConfirmed {
            get {
                return ResourceManager.GetString("EmailNotConfirmed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while removing file.
        /// </summary>
        public static string FileRemoveFailed {
            get {
                return ResourceManager.GetString("FileRemoveFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while uploading file.
        /// </summary>
        public static string FileUploadFailed {
            get {
                return ResourceManager.GetString("FileUploadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access to the requested resource is forbidden.
        /// </summary>
        public static string ForbiddenException {
            get {
                return ResourceManager.GetString("ForbiddenException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email &apos;{0}&apos; is invalid..
        /// </summary>
        public static string InvalidEmail {
            get {
                return ResourceManager.GetString("InvalidEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Role name &apos;{0}&apos; is invalid..
        /// </summary>
        public static string InvalidRoleName {
            get {
                return ResourceManager.GetString("InvalidRoleName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid token..
        /// </summary>
        public static string InvalidToken {
            get {
                return ResourceManager.GetString("InvalidToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username &apos;{0}&apos; is invalid, can only contain letters or digits..
        /// </summary>
        public static string InvalidUserName {
            get {
                return ResourceManager.GetString("InvalidUserName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A user with this login already exists..
        /// </summary>
        public static string LoginAlreadyAssociated {
            get {
                return ResourceManager.GetString("LoginAlreadyAssociated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect password..
        /// </summary>
        public static string PasswordMismatch {
            get {
                return ResourceManager.GetString("PasswordMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passwords must have at least one digit (&apos;0&apos;-&apos;9&apos;)..
        /// </summary>
        public static string PasswordRequiresDigit {
            get {
                return ResourceManager.GetString("PasswordRequiresDigit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passwords must have at least one lowercase (&apos;a&apos;-&apos;z&apos;)..
        /// </summary>
        public static string PasswordRequiresLower {
            get {
                return ResourceManager.GetString("PasswordRequiresLower", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passwords must have at least one non alphanumeric character..
        /// </summary>
        public static string PasswordRequiresNonAlphanumeric {
            get {
                return ResourceManager.GetString("PasswordRequiresNonAlphanumeric", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passwords must use at least {0} different characters..
        /// </summary>
        public static string PasswordRequiresUniqueChars {
            get {
                return ResourceManager.GetString("PasswordRequiresUniqueChars", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passwords must have at least one uppercase (&apos;A&apos;-&apos;Z&apos;)..
        /// </summary>
        public static string PasswordRequiresUpper {
            get {
                return ResourceManager.GetString("PasswordRequiresUpper", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passwords must be at least {0} characters..
        /// </summary>
        public static string PasswordTooShort {
            get {
                return ResourceManager.GetString("PasswordTooShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recovery code redemption failed..
        /// </summary>
        public static string RecoveryCodeRedemptionFailed {
            get {
                return ResourceManager.GetString("RecoveryCodeRedemptionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request data is not valid.
        /// </summary>
        public static string ResourceValidationException {
            get {
                return ResourceManager.GetString("ResourceValidationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while communicating with server.
        /// </summary>
        public static string RestException {
            get {
                return ResourceManager.GetString("RestException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Role {0} does not exist..
        /// </summary>
        public static string RoleNotFound {
            get {
                return ResourceManager.GetString("RoleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To Do item could not be found.
        /// </summary>
        public static string ToDoItemCouldNotBeFound {
            get {
                return ResourceManager.GetString("ToDoItemCouldNotBeFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your request lacks valid authentication credentials.
        /// </summary>
        public static string UnauthorizedException {
            get {
                return ResourceManager.GetString("UnauthorizedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error has occurred.
        /// </summary>
        public static string UnknownException {
            get {
                return ResourceManager.GetString("UnknownException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User already has a password set..
        /// </summary>
        public static string UserAlreadyHasPassword {
            get {
                return ResourceManager.GetString("UserAlreadyHasPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User already in role &apos;{0}&apos;..
        /// </summary>
        public static string UserAlreadyInRole {
            get {
                return ResourceManager.GetString("UserAlreadyInRole", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User image could not be found.
        /// </summary>
        public static string UserImageCouldNotBeFound {
            get {
                return ResourceManager.GetString("UserImageCouldNotBeFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User is locked out..
        /// </summary>
        public static string UserLockedOut {
            get {
                return ResourceManager.GetString("UserLockedOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User {0} does not exist..
        /// </summary>
        public static string UserNameNotFound {
            get {
                return ResourceManager.GetString("UserNameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User is not in role &apos;{0}&apos;..
        /// </summary>
        public static string UserNotInRole {
            get {
                return ResourceManager.GetString("UserNotInRole", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have already requested for the confirmation email for &apos;{0}&apos;. Try again later..
        /// </summary>
        public static string WaitForConfirmationEmailResendDelay {
            get {
                return ResourceManager.GetString("WaitForConfirmationEmailResendDelay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have already requested for the reset password email for &apos;{0}&apos;. Try again later..
        /// </summary>
        public static string WaitForResetPasswordEmailResendDelay {
            get {
                return ResourceManager.GetString("WaitForResetPasswordEmailResendDelay", resourceCulture);
            }
        }
    }
}
