   M S B A M L   `   `   `  ���� C  ?CafeMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CafeMVVM.ViewModelsCafeMVVM.ViewModels  "    CafeMVVM.Views.PageChuyenBan   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:CafeMVVM.ViewModels     V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     �Name$  
WChuyenBan��$	��130��$	��500�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���   � DataContext -   'CafeMVVM.ViewModels.KhuVucBanViewModels  .��� ���#b8b894 � RowDefinitions �� $
��Auto ��� $
��Auto �.+�� $��0�� � ColumnDefinitions �� �� .+�� $��5,5,5,5q�$��0�� �� $
��Auto ��� $
��Auto �.+��� $��Center=�$��Segoe UI)�$��15(�$
��Bold"�
����  �$ ��Chọn bàn cần chuyển���� 	 �� DisplayMemberPath$	 TENBAN��$��1��)  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Chọn bàn������ *
BanCoNguoi+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem �� *SelectedBanCoNguoi+$ OneWayToSource=�� $��5,5,5,5q�$��1�� �� $
��Auto ��� $
��Auto �.+��� $��Center=�$��Segoe UI)�$��15(�$
��Bold"�
����  �$��Bàn còn trống���� $	 TENBAN��$��1��$
 Chọn bàn������ *
BanTrong+$ TwoWay=�$ PropertyChanged=� �� *SelectedBanTrong+$ OneWayToSource=�� $��1�� �� �� .+��� $��Segoe UI)�$��15(�$
��Bold"�
���   �$��Chuyển�� $  MaterialDesignRaisedAccentButton#��[ $��5,5,5,5q�$��0������ *XacNhanChuyenBanIcommand+����  �� ElementName$ 
WChuyenBan���� -    ��Name$ btnthoat��$��Segoe UI)�$��15(�$
��Bold"�
���   �$��Thoát��#��[ $��5,5,5,5q�$��1��