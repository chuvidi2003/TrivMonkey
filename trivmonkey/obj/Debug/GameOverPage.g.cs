﻿#pragma checksum "D:\Dropbox\workspace\TrivMonkey\TrivMonkey\GameOverPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F4E463AF639B4F1A66EC33C3E42561B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
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
    
    
    public partial class GameOverPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Image img_thumb3;
        
        internal System.Windows.Controls.TextBlock txt_title;
        
        internal System.Windows.Controls.TextBlock lbl_score;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock lblquestiontitle;
        
        internal System.Windows.Controls.TextBlock gameoverdesc;
        
        internal System.Windows.Controls.Button btnplayagain;
        
        internal System.Windows.Controls.Button sharebtn;
        
        internal System.Windows.Controls.Button backbtn;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Trivia%20Monkey;component/GameOverPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.img_thumb3 = ((System.Windows.Controls.Image)(this.FindName("img_thumb3")));
            this.txt_title = ((System.Windows.Controls.TextBlock)(this.FindName("txt_title")));
            this.lbl_score = ((System.Windows.Controls.TextBlock)(this.FindName("lbl_score")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.lblquestiontitle = ((System.Windows.Controls.TextBlock)(this.FindName("lblquestiontitle")));
            this.gameoverdesc = ((System.Windows.Controls.TextBlock)(this.FindName("gameoverdesc")));
            this.btnplayagain = ((System.Windows.Controls.Button)(this.FindName("btnplayagain")));
            this.sharebtn = ((System.Windows.Controls.Button)(this.FindName("sharebtn")));
            this.backbtn = ((System.Windows.Controls.Button)(this.FindName("backbtn")));
        }
    }
}

