﻿#pragma checksum "D:\Dropbox\workspace\TrivMonkey\TrivMonkey\LeaderBoardPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B854556A475D909927946C63F3B2D34F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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
    
    
    public partial class LeaderBoardPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard myStoryboard;
        
        internal System.Windows.Media.Animation.Storyboard myStoryboardLT;
        
        internal System.Windows.Media.Animation.Storyboard myStoryboardKP;
        
        internal System.Windows.Media.Animation.Storyboard rankStoryboard;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid gridrank;
        
        internal System.Windows.Controls.TextBlock txt_rankbadge;
        
        internal System.Windows.Controls.TextBlock txt_rank;
        
        internal System.Windows.Controls.TextBlock txt_points;
        
        internal System.Windows.Controls.TextBox txt_displayname;
        
        internal System.Windows.Controls.TextBox txt_email;
        
        internal System.Windows.Controls.TextBox txt_countr;
        
        internal System.Windows.Controls.Button btn_editdetails;
        
        internal System.Windows.Controls.Grid highgrid;
        
        internal System.Windows.Controls.StackPanel btngrid;
        
        internal System.Windows.Controls.Button btnLoadPrev;
        
        internal System.Windows.Controls.Button btnLoadNext;
        
        internal System.Windows.Controls.ListBox lstScores;
        
        internal System.Windows.Controls.StackPanel loadinghighscoreStack;
        
        internal System.Windows.Controls.TextBlock txt_loading;
        
        internal System.Windows.Controls.Button btnreload;
        
        internal System.Windows.Controls.Grid highgridKP;
        
        internal System.Windows.Controls.StackPanel btngridkp;
        
        internal System.Windows.Controls.Button btnLoadPrevKP;
        
        internal System.Windows.Controls.Button btnLoadNextKP;
        
        internal System.Windows.Controls.ListBox lstScoresKP;
        
        internal System.Windows.Controls.StackPanel loadinghighscoreStackKP;
        
        internal System.Windows.Controls.TextBlock txt_loadingkp;
        
        internal System.Windows.Controls.Button btnreloadKP;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Trivia%20Monkey;component/LeaderBoardPage.xaml", System.UriKind.Relative));
            this.myStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("myStoryboard")));
            this.myStoryboardLT = ((System.Windows.Media.Animation.Storyboard)(this.FindName("myStoryboardLT")));
            this.myStoryboardKP = ((System.Windows.Media.Animation.Storyboard)(this.FindName("myStoryboardKP")));
            this.rankStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("rankStoryboard")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.gridrank = ((System.Windows.Controls.Grid)(this.FindName("gridrank")));
            this.txt_rankbadge = ((System.Windows.Controls.TextBlock)(this.FindName("txt_rankbadge")));
            this.txt_rank = ((System.Windows.Controls.TextBlock)(this.FindName("txt_rank")));
            this.txt_points = ((System.Windows.Controls.TextBlock)(this.FindName("txt_points")));
            this.txt_displayname = ((System.Windows.Controls.TextBox)(this.FindName("txt_displayname")));
            this.txt_email = ((System.Windows.Controls.TextBox)(this.FindName("txt_email")));
            this.txt_countr = ((System.Windows.Controls.TextBox)(this.FindName("txt_countr")));
            this.btn_editdetails = ((System.Windows.Controls.Button)(this.FindName("btn_editdetails")));
            this.highgrid = ((System.Windows.Controls.Grid)(this.FindName("highgrid")));
            this.btngrid = ((System.Windows.Controls.StackPanel)(this.FindName("btngrid")));
            this.btnLoadPrev = ((System.Windows.Controls.Button)(this.FindName("btnLoadPrev")));
            this.btnLoadNext = ((System.Windows.Controls.Button)(this.FindName("btnLoadNext")));
            this.lstScores = ((System.Windows.Controls.ListBox)(this.FindName("lstScores")));
            this.loadinghighscoreStack = ((System.Windows.Controls.StackPanel)(this.FindName("loadinghighscoreStack")));
            this.txt_loading = ((System.Windows.Controls.TextBlock)(this.FindName("txt_loading")));
            this.btnreload = ((System.Windows.Controls.Button)(this.FindName("btnreload")));
            this.highgridKP = ((System.Windows.Controls.Grid)(this.FindName("highgridKP")));
            this.btngridkp = ((System.Windows.Controls.StackPanel)(this.FindName("btngridkp")));
            this.btnLoadPrevKP = ((System.Windows.Controls.Button)(this.FindName("btnLoadPrevKP")));
            this.btnLoadNextKP = ((System.Windows.Controls.Button)(this.FindName("btnLoadNextKP")));
            this.lstScoresKP = ((System.Windows.Controls.ListBox)(this.FindName("lstScoresKP")));
            this.loadinghighscoreStackKP = ((System.Windows.Controls.StackPanel)(this.FindName("loadinghighscoreStackKP")));
            this.txt_loadingkp = ((System.Windows.Controls.TextBlock)(this.FindName("txt_loadingkp")));
            this.btnreloadKP = ((System.Windows.Controls.Button)(this.FindName("btnreloadKP")));
        }
    }
}

