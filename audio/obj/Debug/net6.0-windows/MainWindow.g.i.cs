﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FD4197E250AA91B89CF7A896B60CF4BB495B5960"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using System.Windows.Shell;
using audio;


namespace audio {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stop;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button next;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button prev;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mix;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement audio;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox musicList;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider musictime;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button restart;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button open;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock timestart;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock timelast;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock musicname;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/audio;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.stop = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\MainWindow.xaml"
            this.stop.Click += new System.Windows.RoutedEventHandler(this.stop_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.next = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\MainWindow.xaml"
            this.next.Click += new System.Windows.RoutedEventHandler(this.next_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.prev = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\MainWindow.xaml"
            this.prev.Click += new System.Windows.RoutedEventHandler(this.prev_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mix = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\MainWindow.xaml"
            this.mix.Click += new System.Windows.RoutedEventHandler(this.mix_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.audio = ((System.Windows.Controls.MediaElement)(target));
            
            #line 25 "..\..\..\MainWindow.xaml"
            this.audio.MediaOpened += new System.Windows.RoutedEventHandler(this.audio_MediaOpened);
            
            #line default
            #line hidden
            return;
            case 6:
            this.musicList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\..\MainWindow.xaml"
            this.musicList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.musicList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.musictime = ((System.Windows.Controls.Slider)(target));
            
            #line 30 "..\..\..\MainWindow.xaml"
            this.musictime.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Slider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.restart = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\MainWindow.xaml"
            this.restart.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.open = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\MainWindow.xaml"
            this.open.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 10:
            this.timestart = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.timelast = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.musicname = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
