﻿#pragma checksum "C:\Users\henri\Downloads\8º Período\DAI\WindonsServo\WindonsServo\View\Menu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "42FE98B7834978D34E0E8362897F7F7B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindonsServo.View
{
    partial class Menu : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // View\Menu.xaml line 20
                {
                    this.myslitview = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // View\Menu.xaml line 73
                {
                    this.teste = (global::Windows.UI.Xaml.Controls.SearchBox)(target);
                }
                break;
            case 4: // View\Menu.xaml line 22
                {
                    this.IconListBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.IconListBox).SelectionChanged += this.IconListBox_SelectionChanged;
                }
                break;
            case 5: // View\Menu.xaml line 23
                {
                    this.HomeListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 6: // View\Menu.xaml line 29
                {
                    this.ProfileListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 7: // View\Menu.xaml line 35
                {
                    this.CategoryListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 8: // View\Menu.xaml line 41
                {
                    this.ProductListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 9: // View\Menu.xaml line 47
                {
                    this.UsersListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 10: // View\Menu.xaml line 53
                {
                    this.AboutListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 11: // View\Menu.xaml line 59
                {
                    this.ExitListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 12: // View\Menu.xaml line 70
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 13: // View\Menu.xaml line 18
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.HamburgerButton_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

