   M S B A M L   `   `   `  ���� C  ?CafeMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CafeMVVM.ViewModelsCafeMVVM.ViewModels       CafeMVVM.Views.PageGiamGia   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:CafeMVVM.ViewModels     V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���   � DataContext -   'CafeMVVM.ViewModels.KhuVucBanViewModels  .���  � RowDefinitions �� $
��Auto ��� .+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Accent=�.���� $��20��� $��1�� �� $
��Auto ��� �� $
��Auto ��� $
��Auto �.+���  �� DisplayMemberPath$ TENDM��$��Segoe UI)�$��15(�
���   �$
��Bold"�$��Center=�$��5,5,5,5q�$��0��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$6 0Chọn danh mục thực đơn cần giảm giá������ *DanhMucThucDon+ �� SelectedItem �� *SelectedItemDMThucDonGiamGia+ �� Mode$ OneWayToSource=�&   System.Windows.Controls.DataGrid  	   
IsReadOnly	 . 
   AutoGenerateColumns
 .  $��5,5,5,5q�$��1������ *	ThucDon+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� *ChonThucDonBanGiamGia+$ TwoWay=�$ PropertyChanged=� � 	Resources *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%R   '        �� "   P�  �@ 
IsSelected . . ���  � ��
 � ���   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 	Tên món��   Width5	  /System.Windows.Controls.DataGridLengthConverter$ *	    HeaderStyle �� =
  7System.Windows.Controls.Primitives.DataGridColumnHeader" 
 .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  �   CellTemplate �� .R��� $��Segoe UI)�$��15(�
���   �$��Center=����� *
TENTHUCDON+  $ 
Đơn giá��$ *	  �� " 
 .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  � �� .R��� $��Segoe UI)�$��15(�
���   �$��Center=����� *DONGIA+  $ Giảm giá (%)��$ *	  �� " 
 .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  � �� .R��� $��Segoe UI)�$��15(�
���   �$��Center=����� *	GIAMGIA+� $��5,5,5,5q�$��2�� � ColumnDefinitions �� $
��Auto ��� .+��� $��Segoe UI)�$��15(�
���   �$!��Nhập số % cần giảm:���� -   $��Center=�$��Segoe UI)�$��15(�
���   �$��1������ *PhanTramGiamGia+$ TwoWay=�$ PropertyChanged=�� $��3�� �� �� .+���  $  MaterialDesignRaisedAccentButton#��[ $��Segoe UI)�$��15(�
���   �$
��Bold"�$��Cập nhật��$��5,5,5,5q�$��0������ *ThemGiamGia+�� #��[ $��Segoe UI)�$��15(�
���   �$
��Bold"�$��	Gỡ bỏ��$��5,5,5,5q�$��1������ *	GoGiamGia+