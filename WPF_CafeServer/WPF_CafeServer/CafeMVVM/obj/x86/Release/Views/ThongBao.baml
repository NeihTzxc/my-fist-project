   M S B A M L   `   `   `  ���� C  ?CafeMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CafeMVVM.ViewModelsCafeMVVM.ViewModels      CafeMVVM.Views.ThongBao   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:CafeMVVM.ViewModels     V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � WindowStartupLocation$  CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������ $	��150��$	��350��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���   � DataContext +   %CafeMVVM.ViewModels.DanhMucViewModels  .����  �� CornerRadius$ 25��
�������$��0q����#cccc00._��  � RowDefinitions �� $
��Auto ��� �� $
��Auto �.+��� -    ��Name$ hinhanh��$��5,5,5,5q�$��50��$��Center=�$��Center=�$��0���� -   	 ��Name$	 	lbNoidung��$��5,5,5,5q�$��Segoe UI)�$��15(�
���   �$=��7Đây là thông báo nội dung của chường trình��$��Center=�$��1���� $��2��
 �� Orientation$
 
Horizontal=�$��Right=�.+��� -    ��Name$ btnOk��$��Segoe UI)�$��15(�$
��Bold"�$��70�� " MaterialDesignRaisedDarkButton#��[ $��Ok��$��	10,5,15,5q�$��0���� -   $ btnYes��$��Segoe UI)�$��15(�$
��Bold"�$��70��#��[ $	��Yes��$��5,5,15,5q�$��1������ *ThongBaoYes+�� -   $ btnNo��$��Segoe UI)�$��15(�$
��Bold"�$��70��#��[ $��No��$��5,5,15,5q�$��2������ *
ThongBaoNo+