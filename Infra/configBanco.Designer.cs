﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infra {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class configBanco : global::System.Configuration.ApplicationSettingsBase {
        
        private static configBanco defaultInstance = ((configBanco)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new configBanco())));
        
        public static configBanco Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\v11.0;Initial Catalog=Banco_Final;Integrated Security=True;" +
            "Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=" +
            "ReadWrite;MultiSubnetFailover=False")]
        public string Banco_Final {
            get {
                return ((string)(this["Banco_Final"]));
            }
        }
    }
}
