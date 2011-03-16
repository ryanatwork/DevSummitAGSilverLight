﻿#pragma checksum "C:\github\DevSummitAGSSilverLight\CfALightUp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2F1C3C7A82B9CBDC9B47703EAFA52A24"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ESRI.ArcGIS.SilverlightMapApp;
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


namespace CfALightUp {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal ESRI.ArcGIS.Client.Map Map;
        
        internal ESRI.ArcGIS.SilverlightMapApp.CollapsiblePanel MainManu;
        
        internal System.Windows.Controls.Grid BannerGrid;
        
        internal System.Windows.Controls.TextBlock title;
        
        internal System.Windows.Shapes.Rectangle separatorBar;
        
        internal System.Windows.Controls.TextBlock subtitle;
        
        internal System.Windows.Controls.Button myMenu;
        
        internal System.Windows.Controls.Primitives.ToggleButton btnAbout;
        
        internal System.Windows.Controls.Grid myMenuItems;
        
        internal System.Windows.Controls.Button myMenuItem1;
        
        internal System.Windows.Controls.Button myMenuItem2;
        
        internal System.Windows.Controls.Button myMenuItem3;
        
        internal System.Windows.Controls.Border BaseMapSwitcher;
        
        internal ESRI.ArcGIS.SilverlightMapApp.CollapsiblePanel MainToolbar;
        
        internal System.Windows.Controls.Primitives.ToggleButton btnToggleMapLegend;
        
        internal System.Windows.Controls.Primitives.ToggleButton btnToggleOverviewMap;
        
        internal System.Windows.Controls.Button btnToggleMagnifyingGlass;
        
        internal System.Windows.Controls.TextBox InputAddress;
        
        internal System.Windows.Controls.TextBox City;
        
        internal System.Windows.Controls.TextBox State;
        
        internal System.Windows.Controls.TextBox Zip;
        
        internal System.Windows.Controls.Button FindAddressButton;
        
        internal System.Windows.Controls.Grid CandidatePanelGrid;
        
        internal System.Windows.Controls.ScrollViewer CandidateScrollViewer;
        
        internal System.Windows.Controls.ListBox CandidateListBox;
        
        internal ESRI.ArcGIS.Client.Toolkit.Navigation Navigator;
        
        internal ESRI.ArcGIS.SilverlightMapApp.ScaleBar ScaleBar;
        
        internal ESRI.ArcGIS.SilverlightMapApp.WindowPanel OverviewMapPanel;
        
        internal ESRI.ArcGIS.Client.Toolkit.OverviewMap OVMap;
        
        internal ESRI.ArcGIS.Client.Toolkit.MagnifyingGlass MagnifyingGlass;
        
        internal ESRI.ArcGIS.SilverlightMapApp.WindowPanel MapLegendPanel;
        
        internal ESRI.ArcGIS.Client.Toolkit.Legend Legend;
        
        internal ESRI.ArcGIS.SilverlightMapApp.WindowPanel AboutWindow;
        
        internal ESRI.ArcGIS.Client.Toolkit.MapTip MapTip;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/CfALightUp;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Map = ((ESRI.ArcGIS.Client.Map)(this.FindName("Map")));
            this.MainManu = ((ESRI.ArcGIS.SilverlightMapApp.CollapsiblePanel)(this.FindName("MainManu")));
            this.BannerGrid = ((System.Windows.Controls.Grid)(this.FindName("BannerGrid")));
            this.title = ((System.Windows.Controls.TextBlock)(this.FindName("title")));
            this.separatorBar = ((System.Windows.Shapes.Rectangle)(this.FindName("separatorBar")));
            this.subtitle = ((System.Windows.Controls.TextBlock)(this.FindName("subtitle")));
            this.myMenu = ((System.Windows.Controls.Button)(this.FindName("myMenu")));
            this.btnAbout = ((System.Windows.Controls.Primitives.ToggleButton)(this.FindName("btnAbout")));
            this.myMenuItems = ((System.Windows.Controls.Grid)(this.FindName("myMenuItems")));
            this.myMenuItem1 = ((System.Windows.Controls.Button)(this.FindName("myMenuItem1")));
            this.myMenuItem2 = ((System.Windows.Controls.Button)(this.FindName("myMenuItem2")));
            this.myMenuItem3 = ((System.Windows.Controls.Button)(this.FindName("myMenuItem3")));
            this.BaseMapSwitcher = ((System.Windows.Controls.Border)(this.FindName("BaseMapSwitcher")));
            this.MainToolbar = ((ESRI.ArcGIS.SilverlightMapApp.CollapsiblePanel)(this.FindName("MainToolbar")));
            this.btnToggleMapLegend = ((System.Windows.Controls.Primitives.ToggleButton)(this.FindName("btnToggleMapLegend")));
            this.btnToggleOverviewMap = ((System.Windows.Controls.Primitives.ToggleButton)(this.FindName("btnToggleOverviewMap")));
            this.btnToggleMagnifyingGlass = ((System.Windows.Controls.Button)(this.FindName("btnToggleMagnifyingGlass")));
            this.InputAddress = ((System.Windows.Controls.TextBox)(this.FindName("InputAddress")));
            this.City = ((System.Windows.Controls.TextBox)(this.FindName("City")));
            this.State = ((System.Windows.Controls.TextBox)(this.FindName("State")));
            this.Zip = ((System.Windows.Controls.TextBox)(this.FindName("Zip")));
            this.FindAddressButton = ((System.Windows.Controls.Button)(this.FindName("FindAddressButton")));
            this.CandidatePanelGrid = ((System.Windows.Controls.Grid)(this.FindName("CandidatePanelGrid")));
            this.CandidateScrollViewer = ((System.Windows.Controls.ScrollViewer)(this.FindName("CandidateScrollViewer")));
            this.CandidateListBox = ((System.Windows.Controls.ListBox)(this.FindName("CandidateListBox")));
            this.Navigator = ((ESRI.ArcGIS.Client.Toolkit.Navigation)(this.FindName("Navigator")));
            this.ScaleBar = ((ESRI.ArcGIS.SilverlightMapApp.ScaleBar)(this.FindName("ScaleBar")));
            this.OverviewMapPanel = ((ESRI.ArcGIS.SilverlightMapApp.WindowPanel)(this.FindName("OverviewMapPanel")));
            this.OVMap = ((ESRI.ArcGIS.Client.Toolkit.OverviewMap)(this.FindName("OVMap")));
            this.MagnifyingGlass = ((ESRI.ArcGIS.Client.Toolkit.MagnifyingGlass)(this.FindName("MagnifyingGlass")));
            this.MapLegendPanel = ((ESRI.ArcGIS.SilverlightMapApp.WindowPanel)(this.FindName("MapLegendPanel")));
            this.Legend = ((ESRI.ArcGIS.Client.Toolkit.Legend)(this.FindName("Legend")));
            this.AboutWindow = ((ESRI.ArcGIS.SilverlightMapApp.WindowPanel)(this.FindName("AboutWindow")));
            this.MapTip = ((ESRI.ArcGIS.Client.Toolkit.MapTip)(this.FindName("MapTip")));
        }
    }
}

