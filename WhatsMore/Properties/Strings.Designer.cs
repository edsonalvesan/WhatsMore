﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WhatsMore.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WhatsMore.Properties.Strings", typeof(Strings).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A connection to the Internet was not detected..
        /// </summary>
        internal static string Alert_NoInternetConnection {
            get {
                return ResourceManager.GetString("Alert_NoInternetConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WhatsApp web session for &apos;{0}&apos; is not connected with waboxapp in Google Chrome..
        /// </summary>
        internal static string Alert_WhatsAppNotConnected {
            get {
                return ResourceManager.GetString("Alert_WhatsAppNotConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid API key. No API key was provided..
        /// </summary>
        internal static string ArgEx_InvalidAPIKey {
            get {
                return ResourceManager.GetString("ArgEx_InvalidAPIKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid phone number for sender. No phone number was provided..
        /// </summary>
        internal static string ArgEx_InvalidSenderPhone {
            get {
                return ResourceManager.GetString("ArgEx_InvalidSenderPhone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancel.
        /// </summary>
        internal static string Cancel {
            get {
                return ResourceManager.GetString("Cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: The configuration is corrupt. Please reconfigure the program to send messages..
        /// </summary>
        internal static string Error_ConfigCorrupt {
            get {
                return ResourceManager.GetString("Error_ConfigCorrupt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Get request failed. Please check your connection..
        /// </summary>
        internal static string Error_GetRequestFailed {
            get {
                return ResourceManager.GetString("Error_GetRequestFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: The &apos;Newtonsoft.Json.dll&apos; file is missing. The program will now exit..
        /// </summary>
        internal static string Error_MissingJsonDllExit {
            get {
                return ResourceManager.GetString("Error_MissingJsonDllExit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: The number &apos;{0}&apos; is not authorized to send messages..
        /// </summary>
        internal static string Error_UnauthorizedSender {
            get {
                return ResourceManager.GetString("Error_UnauthorizedSender", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text Documents (*.txt)|*.txt.
        /// </summary>
        internal static string Filter_TextDocuments {
            get {
                return ResourceManager.GetString("Filter_TextDocuments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It looks like this is your first time using WhatsMore.
        ///Please configure the program to send messages..
        /// </summary>
        internal static string Info_FirstTimeConfig {
            get {
                return ResourceManager.GetString("Info_FirstTimeConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sent {0} of {1} messages successfully..
        /// </summary>
        internal static string Info_SentSuccessful {
            get {
                return ResourceManager.GetString("Info_SentSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Send.
        /// </summary>
        internal static string Send {
            get {
                return ResourceManager.GetString("Send", resourceCulture);
            }
        }
    }
}
