   M S B A M L   `   `   `  ����C  ?CafeMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CafeMVVM.ViewModelsCafeMVVM.ViewModels  5          CafeMVVM.Views.PageBan   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:CafeMVVM.ViewModels     5      V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � DataContext 5      '   !CafeMVVM.ViewModels.BanViewModels  5   
   6    .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   �� 5      $
��Auto �6   6-   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Accent=�6#   .��5      �� $��20��6   6"   5      &   System.Windows.Controls.DataGrid  5   
   $��5,5,5,5q�6   $��1��6$      
IsReadOnly .    AutoGenerateColumns .  ��6D   �� *
BanDanhMuc+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�	 �� SelectedItem	 6�   �� *SelectedBan+$ OneWayToSource=�
 � 	Resources
 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 5      "  6    5       P� 5!       �@ 
IsSelected . . �5"      ��  � ��
 � ���6;   5#      5%      5&         Columns 5'      4  .System.Windows.Controls.DataGridTemplateColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Tên bàn��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6:      HeaderStyle 5)      �� 5*      =	  7System.Windows.Controls.Primitives.DataGridColumnHeader" 	 6    .�5+      ��  � ��$ Center=�6K   6\   �� 5,       � ��$ Segoe UI)�6;   6N   �� 5-       � ��$ 15(�69   6F   �� 5.       � ��$
 Bold"�6;   6J   �� 5/       � ��
 ��  �6J   50         CellTemplate 52      �� 53      .R�54      �� $��Center=�6$   $��15(�6H   $��Segoe UI)�6V   
���   ���6�   �� *TENBAN+6�   55      57      59      � 5:   
   $��2��6    5;      �� 5<      6"   �� 5=      $
��Auto �6    60   .+�5?      � $��0��6    5@      �� 5A      6&   �� 5B      6'   .+�5D      �� $��5,5,5,5q�6    �� DisplayMemberPath$ 	TENKHUVUC��6K   $��15(�6�   $��Segoe UI)�6�   $
��Bold"�6�   $��Bottom=�6�   )
  #MaterialDesignThemes.Wpf.HintAssist 
  Hint$* $Chọn khục vực để thêm bàn��6  $��0��6U  ��6,   �� *KhuVuc+	 6i   �� *SelectedKhuVuc+$ OneWayToSource=�$ PropertyChanged=�6d  �� 5E      -   5        $��5,5,5,5q�5E      $��15(�6�   $��Segoe UI)�6�   $
��Bold"�6�   $��Bottom=�6�   $+ %Nhập số lượng bàn cần thêm��6�   $��1��62  ��6,   �� *
SOLUONGBAN+$ TwoWay=�$ PropertyChanged=�6A  5F      � 5G      $��1��6    � ColumnDefinitions 5H      �� 5I      6)   �� 5J      6)   �� 5K      6)   .+�5M      �� $��15(�6;   $��Segoe UI)�6I   $
��Bold"�6_   
���   �$��Thêm��6�    $  MaterialDesignRaisedAccentButton#��[ 6�   $��5,5,5,5q�6�   $��0��6�   ��6   �� *ThemBanComand+6�   �� 5N      $��15(�6;   $��Segoe UI)�6I   $
��Bold"�6_   
���   �$��Sửa��6�   #��[ 6�   $��5,5,5,5q�6�   $��1��6�   ��6   �� *SuaBanComand+6�   �� 5O      $��15(�6:   $��Segoe UI)�6H   $
��Bold"�6^   
���   �$
��Xóa��6�   #��[ 6�   $��5,5,5,5q�6�   $��2��6�   ��6   �� *XoaBanComand+6�   5P      5Q      5R      5S      