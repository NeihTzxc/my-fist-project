   M S B A M L   `   `   `  ���� C  ?CafeMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CafeMVVM.ViewModelsCafeMVVM.ViewModels  !    CafeMVVM.Views.PageDangNhap   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:CafeMVVM.ViewModels     V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     �Name$  	wdangnhap��$	��190��$	��300�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�
������   MaterialDesignFont#���   � DataContext ,   &CafeMVVM.ViewModels.TaiKhoanViewModels  .����  �� CornerRadius$ 15��
����������#b3cce6._��  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto �.+�(  "MaterialDesignThemes.Wpf.ColorZone  
������ 	   Mode$	 Accent=�.���� $ 15��
���2͚�._�� 
 � ColumnDefinitions
 �� �� $
��Auto �.+��� $��Center=�$��35,5,5,5q�$��Segoe UI)�$��15(�$
��Bold"�
�������$��0��$%��Đăng nhập vào hệ thống���� -    ��Name$ lbthoat��
���  ��$��Right=�$��X��$��0,5,5,5q�$��Segoe UI)�$��15(�$
��Bold"�$��1��� $��1�� �� �� .+�� $��0��
 �� $
��Auto ��� .+�'  !MaterialDesignThemes.Wpf.PackIcon  $��5,0,0,0q�$��Center=�$��Center=�$��0���  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=null]]   Kind$ AccountCircle=��� -    ��Name$ txttendangnhap��$��1��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên đăng nhập��$��5,5,10,5q�$��Segoe UI)�$��15(�
���   ����� *TENDANGNHAP+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�� $��1��
 �� $
��Auto ��� .+�  $��5,0,0,0q�$��Center=�$��Center=�$	 Key=�G� -   $��
txtmatkhau�� G� Password$	 123��$ Mật khẩu��$��5,5,10,5q�$��Segoe UI)�$��15(�
���   �$��1���� $��2��.+��� $��Segoe UI)�
���  ������ *	TrangThai+$ TwoWay=�$ PropertyChanged=���  �� 	IsDefault . $��Đăng Nhập��$��Segoe UI)�$��15(�$
��Bold"� " MaterialDesignRaisedDarkButton#��[ $��5,5,5,5q����� *DangNhapCommand+����  �� ElementName$ 
txtmatkhau��