﻿#pragma checksum "D:\Dropbox\workspace\TrivMonkey\TrivMonkey\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "81F623DD01692D59108F9BD0E248B898"
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
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard myStoryboard;
        
        internal System.Windows.Media.Animation.Storyboard pivotStoryboard;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot pivotMain;
        
        internal System.Windows.Controls.TextBlock txtSessionStatus;
        
        internal System.Windows.Controls.TextBlock txtStatus;
        
        internal System.Windows.Controls.Button btn_leaderboard;
        
        internal System.Windows.Controls.ListBox featuredlistbox;
        
        internal System.Windows.Controls.StackPanel loadingFeaturedStack;
        
        internal System.Windows.Controls.ListBox categorieslistbox;
        
        internal System.Windows.Controls.StackPanel loadingCategoriesStack;
        
        internal System.Windows.Controls.TextBlock statlabel;
        
        internal System.Windows.Controls.TextBlock highscorelabel;
        
        internal System.Windows.Controls.TextBlock playtimelabel;
        
        internal System.Windows.Controls.TextBlock timedesig;
        
        internal System.Windows.Controls.TextBlock monkeycoinslabel;
        
        internal System.Windows.Controls.TextBlock gamesplayedlabel;
        
        internal System.Windows.Controls.TextBlock lifetimescorelabel;
        
        internal System.Windows.Controls.TextBlock lifescoredesig;
        
        internal System.Windows.Controls.TextBlock itemsunlockedlabel;
        
        internal System.Windows.Controls.Button creditsbutton;
        
        internal System.Windows.Controls.Button btnrecommend;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Trivia%20Monkey;component/MainPage.xaml", System.UriKind.Relative));
            this.myStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("myStoryboard")));
            this.pivotStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("pivotStoryboard")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.pivotMain = ((Microsoft.Phone.Controls.Pivot)(this.FindName("pivotMain")));
            this.txtSessionStatus = ((System.Windows.Controls.TextBlock)(this.FindName("txtSessionStatus")));
            this.txtStatus = ((System.Windows.Controls.TextBlock)(this.FindName("txtStatus")));
            this.btn_leaderboard = ((System.Windows.Controls.Button)(this.FindName("btn_leaderboard")));
            this.featuredlistbox = ((System.Windows.Controls.ListBox)(this.FindName("featuredlistbox")));
            this.loadingFeaturedStack = ((System.Windows.Controls.StackPanel)(this.FindName("loadingFeaturedStack")));
            this.categorieslistbox = ((System.Windows.Controls.ListBox)(this.FindName("categorieslistbox")));
            this.loadingCategoriesStack = ((System.Windows.Controls.StackPanel)(this.FindName("loadingCategoriesStack")));
            this.statlabel = ((System.Windows.Controls.TextBlock)(this.FindName("statlabel")));
            this.highscorelabel = ((System.Windows.Controls.TextBlock)(this.FindName("highscorelabel")));
            this.playtimelabel = ((System.Windows.Controls.TextBlock)(this.FindName("playtimelabel")));
            this.timedesig = ((System.Windows.Controls.TextBlock)(this.FindName("timedesig")));
            this.monkeycoinslabel = ((System.Windows.Controls.TextBlock)(this.FindName("monkeycoinslabel")));
            this.gamesplayedlabel = ((System.Windows.Controls.TextBlock)(this.FindName("gamesplayedlabel")));
            this.lifetimescorelabel = ((System.Windows.Controls.TextBlock)(this.FindName("lifetimescorelabel")));
            this.lifescoredesig = ((System.Windows.Controls.TextBlock)(this.FindName("lifescoredesig")));
            this.itemsunlockedlabel = ((System.Windows.Controls.TextBlock)(this.FindName("itemsunlockedlabel")));
            this.creditsbutton = ((System.Windows.Controls.Button)(this.FindName("creditsbutton")));
            this.btnrecommend = ((System.Windows.Controls.Button)(this.FindName("btnrecommend")));
        }
    }
}

