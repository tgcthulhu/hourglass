﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hourglass.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Hourglass.Serialization.TimerOptionsInfo MostRecentOptionsInfo {
            get {
                return ((global::Hourglass.Serialization.TimerOptionsInfo)(this["MostRecentOptionsInfo"]));
            }
            set {
                this["MostRecentOptionsInfo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowInNotificationArea {
            get {
                return ((bool)(this["ShowInNotificationArea"]));
            }
            set {
                this["ShowInNotificationArea"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Hourglass.Serialization.TimerInfoList TimerInfos {
            get {
                return ((global::Hourglass.Serialization.TimerInfoList)(this["TimerInfos"]));
            }
            set {
                this["TimerInfos"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Hourglass.Serialization.TimerStartInfoList TimerStartInfos {
            get {
                return ((global::Hourglass.Serialization.TimerStartInfoList)(this["TimerStartInfos"]));
            }
            set {
                this["TimerStartInfos"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection UserProvidedColorIdentifiers {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["UserProvidedColorIdentifiers"]));
            }
            set {
                this["UserProvidedColorIdentifiers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Hourglass.Serialization.WindowSizeInfo WindowSizeInfo {
            get {
                return ((global::Hourglass.Serialization.WindowSizeInfo)(this["WindowSizeInfo"]));
            }
            set {
                this["WindowSizeInfo"] = value;
            }
        }
    }
}
