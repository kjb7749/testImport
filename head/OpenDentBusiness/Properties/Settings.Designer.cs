﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenDentBusiness.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/OpenDentalServer/ServiceMain.asmx")]
        public string OpenDentBusiness_OpenDentalServer_ServiceMain {
            get {
                return ((string)(this["OpenDentBusiness_OpenDentalServer_ServiceMain"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/OpenDentalWebServiceHQ/webservicemainhq.asmx")]
        public string OpenDentBusiness_WebServiceMainHQ_WebServiceMainHQ {
            get {
                return ((string)(this["OpenDentBusiness_WebServiceMainHQ_WebServiceMainHQ"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://50.201.161.44:1942/WebServiceCustomerUpdates/Service1.asmx")]
        public string OpenDentBusiness_customerupdates_Service1 {
            get {
                return ((string)(this["OpenDentBusiness_customerupdates_Service1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:3824/Service1.asmx")]
        public string OpenDentBusiness_localhost_Service1 {
            get {
                return ((string)(this["OpenDentBusiness_localhost_Service1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://webservices.dentalxchange.com:443/dws/DwsService")]
        public string OpenDentBusiness_Dentalxchange2016_DwsService {
            get {
                return ((string)(this["OpenDentBusiness_Dentalxchange2016_DwsService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://webservices.dentalxchange.com/dws/services/dciservice.svl")]
        public string OpenDentBusiness_com_dentalxchange_webservices_WebServiceService {
            get {
                return ((string)(this["OpenDentBusiness_com_dentalxchange_webservices_WebServiceService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://its.changehealthcare.com/ITS/ITSWS.asmx")]
        public string OpenDentBusiness_EmdeonITS_ITSWS {
            get {
                return ((string)(this["OpenDentBusiness_EmdeonITS_ITSWS"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://my.dosespot.com/api/12/api.asmx")]
        public string OpenDentBusiness_com_dosespot_staging_my_API {
            get {
                return ((string)(this["OpenDentBusiness_com_dosespot_staging_my_API"]));
            }
        }
    }
}
