﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace skypeRobotController.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Magabot didn\'t hear you... \r\nIt isn\'t connected yet.")]
        public string failedToSendMessage {
            get {
                return ((string)(this["failedToSendMessage"]));
            }
            set {
                this["failedToSendMessage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Hello!  \r\nPlease wait until we give you the control of the robot.")]
        public string welcomeMessage {
            get {
                return ((string)(this["welcomeMessage"]));
            }
            set {
                this["welcomeMessage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("You\'re not controlling Magabot yet. \r\nWait for you turn...")]
        public string waitMessage {
            get {
                return ((string)(this["waitMessage"]));
            }
            set {
                this["waitMessage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Hurray!!! \r\nMagabot is now under your command. \r\nRemember: \r\n- \'1\' to Assisted Na" +
            "vigation    \r\n  - \'w\' to go forward \r\n  - \'s\' to go backward\r\n  - \'a\' to go left" +
            "\r\n  - \'d\' to go right\r\n  - \'p\' to stop\r\n- \'2\' to Obstacle Avoidance")]
        public string controllerMessage {
            get {
                return ((string)(this["controllerMessage"]));
            }
            set {
                this["controllerMessage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Please don\'t hurt me!!\r\n - I\'ve bumped against something.")]
        public string bumperMessage {
            get {
                return ((string)(this["bumperMessage"]));
            }
            set {
                this["bumperMessage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Please don\'t hurt me!!\r\n - I\'ve just detected a hole in the ground.")]
        public string holeMessage {
            get {
                return ((string)(this["holeMessage"]));
            }
            set {
                this["holeMessage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string password {
            get {
                return ((string)(this["password"]));
            }
            set {
                this["password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string email {
            get {
                return ((string)(this["email"]));
            }
            set {
                this["email"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string serialPort {
            get {
                return ((string)(this["serialPort"]));
            }
            set {
                this["serialPort"] = value;
            }
        }
    }
}
