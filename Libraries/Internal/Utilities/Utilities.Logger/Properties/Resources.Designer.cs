﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Utilities.Logger.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Utilities.Logger.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to [ ERR ].
        /// </summary>
        internal static string ErrorPrefix {
            get {
                return ResourceManager.GetString("ErrorPrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to *** FATAL ERROR ***.
        /// </summary>
        internal static string FatalErrorPrefix {
            get {
                return ResourceManager.GetString("FatalErrorPrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [ INF ].
        /// </summary>
        internal static string InformationPrefix {
            get {
                return ResourceManager.GetString("InformationPrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [ OKI ].
        /// </summary>
        internal static string OkPrefix {
            get {
                return ResourceManager.GetString("OkPrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [ WRN ].
        /// </summary>
        internal static string WarningPrefix {
            get {
                return ResourceManager.GetString("WarningPrefix", resourceCulture);
            }
        }
    }
}
