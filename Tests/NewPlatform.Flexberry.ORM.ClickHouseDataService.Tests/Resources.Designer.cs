﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.ClickHouseDataService.Tests {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NewPlatform.ClickHouseDataService.Tests.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to 
        ///
        ///
        ///
        ///CREATE TABLE &quot;Place2&quot; (
        ///
        /// &quot;primaryKey&quot; UUID,
        ///
        /// &quot;PlaceName&quot; String,
        ///
        /// &quot;TomorrowTeritory_m0&quot; UUID,
        ///
        /// &quot;TomorrowTeritory_m1&quot; UUID,
        ///
        /// &quot;TodayTerritory_m0&quot; UUID,
        ///
        /// &quot;TodayTerritory_m1&quot; UUID
        ///
        ///) ENGINE = MergeTree() ORDER BY (&quot;primaryKey&quot;);
        ///
        ///
        ///CREATE TABLE &quot;SomeMasterClass&quot; (
        ///
        /// &quot;primaryKey&quot; UUID,
        ///
        /// &quot;FieldA&quot; String
        ///
        ///) ENGINE = MergeTree() ORDER BY (&quot;primaryKey&quot;);
        ///
        ///
        ///CREATE TABLE &quot;МастерМ&quot; (
        ///
        /// &quot;primaryKey&quot; UUID
        ///
        ///) ENGINE = MergeTree() ORDER BY (&quot;primaryKey&quot;);
        ///
        ///
        ///CREATE TABLE &quot;FullTypesMaster1&quot; (
        ///
        /// &quot;primaryKey&quot; UUID,
        ///
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ClickHouseDirectGenerator_create {
            get {
                return ResourceManager.GetString("ClickHouseDirectGenerator.create", resourceCulture);
            }
        }
    }
}
