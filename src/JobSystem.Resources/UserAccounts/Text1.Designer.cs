﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobSystem.Resources.UserAccounts {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Text {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Text() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JobSystem.Resources.UserAccounts.Text", typeof(Text).Assembly);
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
        ///   Looks up a localized string similar to Strong passwords have at least 13 characters and combine upper &amp; lower case letters, numbers &amp; symbols.
        /// </summary>
        public static string AccPassAuthenticationTooltip {
            get {
                return ResourceManager.GetString("AccPassAuthenticationTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Minimum of 8 characters with 1 number).
        /// </summary>
        public static string MandatoryFieldText {
            get {
                return ResourceManager.GetString("MandatoryFieldText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password Change.
        /// </summary>
        public static string PasswordChange {
            get {
                return ResourceManager.GetString("PasswordChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have logged in using a system generated password.&lt;br /&gt;
        ///You will now need to create a new password to replace the system generated one..
        /// </summary>
        public static string PasswordChangeInfo {
            get {
                return ResourceManager.GetString("PasswordChangeInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password is 8 characters min &amp; 255 max with at least one number.
        /// </summary>
        public static string PasswordRequirementInfo {
            get {
                return ResourceManager.GetString("PasswordRequirementInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Strength Bar.
        /// </summary>
        public static string StrengthBar {
            get {
                return ResourceManager.GetString("StrengthBar", resourceCulture);
            }
        }
    }
}
