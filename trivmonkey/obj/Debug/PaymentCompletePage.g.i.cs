﻿#pragma checksum "C:\Users\Victor\Dropbox\workspace\TrivMonkey\TrivMonkey\PaymentCompletePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4B43D8510D5B7C6E616DCA91E2CEEEA9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace TrivMonkey {
    
    
    public partial class PaymentCompletePage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock txt_title;
        
        internal System.Windows.Controls.TextBlock lbltitle;
        
        internal System.Windows.Controls.TextBlock lblitems;
        
        internal System.Windows.Controls.TextBlock lblfunny;
        
        internal System.Windows.Controls.TextBlock lblmessage;
        
        internal System.Windows.Controls.Button btntryagain;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Trivia%20Monkey;component/PaymentCompletePage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txt_title = ((System.Windows.Controls.TextBlock)(this.FindName("txt_title")));
            this.lbltitle = ((System.Windows.Controls.TextBlock)(this.FindName("lbltitle")));
            this.lblitems = ((System.Windows.Controls.TextBlock)(this.FindName("lblitems")));
            this.lblfunny = ((System.Windows.Controls.TextBlock)(this.FindName("lblfunny")));
            this.lblmessage = ((System.Windows.Controls.TextBlock)(this.FindName("lblmessage")));
            this.btntryagain = ((System.Windows.Controls.Button)(this.FindName("btntryagain")));
        }
    }
}

