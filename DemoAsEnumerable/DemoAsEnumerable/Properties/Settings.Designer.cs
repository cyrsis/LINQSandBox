//------------------------------------------------------------------------------
// <auto-generated>
//     此程式碼由工具生成。
//     執行時版本:2.0.50727.3053
//
//     對此檔案的更改可能會導致不正確的行為，並且如果
//     重新生成程式碼，這些更改將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoAsEnumerable.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\DbAddressBook.mdf;Integ" +
            "rated Security=True;User Instance=True")]
        public string DbAddressBookConnectionString {
            get {
                return ((string)(this["DbAddressBookConnectionString"]));
            }
        }
    }
}
