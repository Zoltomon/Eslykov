﻿#pragma checksum "..\..\..\Views\ModelsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "425BBA6ED8F3B6DC69FD95B111913CAE44E8F3D1B23C3A47211650E0B07B8D5B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CommercialFirm.Views;
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
using System.Windows.Shell;


namespace CommercialFirm.Views {
    
    
    /// <summary>
    /// ModelsPage
    /// </summary>
    public partial class ModelsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Views\ModelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridListModels;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Views\ModelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddModel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\ModelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbSearch;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\ModelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDelete;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CommercialFirm;component/views/modelspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ModelsPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\Views\ModelsPage.xaml"
            ((CommercialFirm.Views.ModelsPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GridListModels = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.AddModel = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Views\ModelsPage.xaml"
            this.AddModel.Click += new System.Windows.RoutedEventHandler(this.AddModel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TxbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\..\Views\ModelsPage.xaml"
            this.TxbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Views\ModelsPage.xaml"
            this.BtnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

