﻿#pragma checksum "..\..\..\..\fenetres\UCReservation.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1BB2010C6D885B93495401F512B0546995145D65"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using DortanApp;
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


namespace DortanApp {
    
    
    /// <summary>
    /// UCReservation
    /// </summary>
    public partial class UCReservation : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\fenetres\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labActivite;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\fenetres\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNom;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\fenetres\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgActivites;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\fenetres\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSupActivite;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\fenetres\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCreationActivite;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\fenetres\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labDate;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\fenetres\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDate;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\fenetres\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labDuree;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\fenetres\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDuree;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\fenetres\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btReserver;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DortanApp;component/fenetres/ucreservation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\fenetres\UCReservation.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.labActivite = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.txtNom = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\..\fenetres\UCReservation.xaml"
            this.txtNom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtNom_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgActivites = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.btSupActivite = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\fenetres\UCReservation.xaml"
            this.btSupActivite.Click += new System.Windows.RoutedEventHandler(this.BtSupActivite_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btCreationActivite = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\fenetres\UCReservation.xaml"
            this.btCreationActivite.Click += new System.Windows.RoutedEventHandler(this.BtCreationActivite_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.labDate = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.dpDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.labDuree = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.tbDuree = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btReserver = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\..\fenetres\UCReservation.xaml"
            this.btReserver.Click += new System.Windows.RoutedEventHandler(this.BtReserver_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

