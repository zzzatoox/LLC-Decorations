﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace llc_decorations.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-R8EPTUG\\SQLEXPRESS;Initial Catalog=DecorationsLazarev;Integra" +
            "ted Security=True;")]
        public string connectionString1 {
            get {
                return ((string)(this["connectionString1"]));
            }
            set {
                this["connectionString1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-R8EPTUG\\SQLEXPRESS;Initial Catalog=DecorationsLazarev;Integra" +
            "ted Security=True;")]
        public string connectionString {
            get {
                return ((string)(this["connectionString"]));
            }
            set {
                this["connectionString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DecorationsL" +
            "azarev;Data Source=MEPHI3-MSSQL")]
        public string Параметр {
            get {
                return ((string)(this["Параметр"]));
            }
            set {
                this["Параметр"] = value;
            }
        }
    }
}
