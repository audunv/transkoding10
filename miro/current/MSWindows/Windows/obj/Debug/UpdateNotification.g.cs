﻿#pragma checksum "..\..\UpdateNotification.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7B25B66DF42B3561C8CC6CD6C13F6491"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Mirosubs.Converter.Windows {
    
    
    /// <summary>
    /// UpdateNotification
    /// </summary>
    public partial class UpdateNotification : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\UpdateNotification.xaml"
        internal System.Windows.Controls.TextBlock textBlock1;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\UpdateNotification.xaml"
        internal System.Windows.Controls.Button getNewVersion;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\UpdateNotification.xaml"
        internal System.Windows.Controls.Button notNow;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MiroConverter;component/updatenotification.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UpdateNotification.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.getNewVersion = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\UpdateNotification.xaml"
            this.getNewVersion.Click += new System.Windows.RoutedEventHandler(this.GetNewVersionClicked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.notNow = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\UpdateNotification.xaml"
            this.notNow.Click += new System.Windows.RoutedEventHandler(this.NotNowClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
