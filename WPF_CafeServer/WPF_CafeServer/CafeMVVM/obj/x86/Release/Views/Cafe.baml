   M S B A M L   `   `   `  ���� C  ?CafeMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CafeMVVM.ViewModelsCafeMVVM.ViewModels  M IWpfPageTransitions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS<clr-namespace:WpfPageTransitions;assembly=WpfPageTransitionsWpfPageTransitions     CafeMVVM.Views.Cafe   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:CafeMVVM.ViewModels     XpageTransitions<clr-namespace:WpfPageTransitions;assembly=WpfPageTransitions     V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � Title$
  Cafe��$	��640��$
��1200�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���  .��� ���� -   igridnen�� j� Stretch$
 Fill=� � ColumnDefinitions �� $
��Auto ��� .+��� .+��� -    ��Name$ 	btnphucvu��{�.   � ToolTip$' !Dành cho nhân viên phục vụ�� " MaterialDesignRaisedDarkButton#��[ $��5,10,0,5q�$
��Left=�$��60��$	��160��.���� 	 �� Orientation$	 
Horizontal=�.+��� -   
 ��Name$
 
hinhphucvu��$
��Left=�$
��Fill=�$��30��$��30���� $��  PHỤC VỤ��$��Segoe UI)�$��15(�$��Center=�
�������$��0,0,0,0q�$
��Bold"�$��Center=�$��1���� -   $ 	btnkhuvuc��{�.  $ Thêm khu vực cho quán��#��[ $��5,0,0,5q�$
��Left=�$��60��$	��160��.���� $	 
Horizontal=�.+��� -   $
 
hinhkhuvuc��$
��Left=�$
��Fill=�$��30��$��30���� $��   KHU VỰC��$��Segoe UI)�$��15(�$��Center=�
�������$��0,0,0,0q�$
��Bold"�$��Center=�$��1���� -   $ btnban��{�.  $ Thêm bàn cho khu vực��#��[ $��5,0,0,5q�$
��Left=�$��60��$	��160��.���� $	 
Horizontal=�.+��� -   $
 hinhban��$
��Left=�$
��Fill=�$��30��$��30���� $��BÀN            ��$��Segoe UI)�$��15(�$��Center=�
�������$��0,0,0,0q�$
��Bold"�$��Center=�$��1���� -	   $ 
btnthucdon��{�.  $ Thêm danh mục và món��#��[ $��5,0,0,5q�$
��Left=�$��60��$	��160��.���� $	 
Horizontal=�.+��� -
   $
 hinhthucdon��$
��Left=�$
��Fill=�$��30��$��30���� $��THỰC ĐƠN��$��Segoe UI)�$��15(�$��Center=�
�������$��0,0,0,0q�$
��Bold"�$��Center=�$��1���� -   $ 
btngiamgia��{�.  $ GIẢM GIÁ��#��[ $��5,0,0,5q�$
��Left=�$��60��$	��160��.���� $	 
Horizontal=�.+��� -   $
 hinhgiamgia��$
��Left=�$
��Fill=�$��30��$��30���� $��GIẢM GIÁ  ��$��Segoe UI)�$��15(�$��Center=�
�������$��0,0,0,0q�$
��Bold"�$��Center=�$��1���� -   $ 
btnthongke��{�.  $ Thống kê danh thu��#��[ $��5,0,0,5q�$
��Left=�$��60��$	��160��.���� $	 
Horizontal=�.+��� -   $
 hinhthongke��$
��Left=�$
��Fill=�$��30��$��30���� $��THỐNG KÊ��$��Segoe UI)�$��15(�$��Center=�
�������$��0,0,0,0q�$
��Bold"�$��Center=�$��1���� -   $ btntaikhoan��{�.  $ Quản lý tài khoản��#��[ $��5,0,0,5q�$
��Left=�$��60��$	��160��.���� $	 
Horizontal=�.+��� -   $
 hinhtaikhoan��$
��Left=�$
��Fill=�$��30��$��30���� $��TÀI KHOẢN��$��Segoe UI)�$��15(�$��Center=�
�������$��0,0,0,0q�$
��Bold"�$��Center=�$��1���� -   $ btndangxuat��{�.  $ Đăng xuất��#��[ $��5,0,0,5q�$
��Left=�$��60��$	��160��.���� $	 
Horizontal=�.+��� -   $
 hinhdangxuat��$
��Left=�$
��Fill=�$��30��$��30���� $��ĐĂNG XUẤT��$��Segoe UI)�$��15(�$��Center=�
�������$��0,0,0,0q�$
��Bold"�$��Center=�$��1���� -   $ btnthoat��{�.  $ Tắt chương trình��#��[ $��5,0,0,5q�$
��Left=�$��60��$	��160��.���� $	 
Horizontal=�.+��� -   $
 	hinhthoat��$
��Left=�$
��Fill=�$��30��$��30���� $��THOÁT       ��$��Segoe UI)�$��15(�$��Center=�
�������$��0,0,0,0q�$
��Bold"�$��Center=�$��1��� $��1��.+�'  !WpfPageTransitions.PageTransition  -   $��pageTransitionControl��$��15q�   TransitionType$ SlideAndFade=�