   M S B A M L   `   `   `  ���� C  ?CafeMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CafeMVVM.ViewModelsCafeMVVM.ViewModels  '    !CafeMVVM.Views.PageQuanLyTaiKhoan   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:CafeMVVM.ViewModels     V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���   � DataContext ,   &CafeMVVM.ViewModels.TaiKhoanViewModels  .���  � RowDefinitions �� $
��Auto ��� .+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Accent=�.���� $��20��� $��1�� �� �� $
��Auto �.+�&   System.Windows.Controls.DataGrid  $��5q�   
IsReadOnly .    AutoGenerateColumns .  $��0������ *DanhSachTaiKhoan+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�	 �� SelectedItem	 �� *SelectedTaiKhoan+$ OneWayToSource=�
 � 	Resources
 *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%R   '        �� "   P�  �@ 
IsSelected . . ���  � ��
 � ���   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Tên tài khoản��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    HeaderStyle �� =	  7System.Windows.Controls.Primitives.DataGridColumnHeader" 	 .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  �   CellTemplate �� .R��� $��Center=�$��Segoe UI)�$��15(�
���   ����� *TENDANGNHAP+  $ 	Họ tên��$ *  �� " 	 .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  � �� .R��� $��Center=�$��Segoe UI)�$��15(�
���   ����� *HOTEN+  $ Mật khẩu��$ *  �� " 	 .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  � �� .R��� $��Center=�$��Segoe UI)�$��15(�
���   ����� *	MATKHAU+  $ Quyền sử dụng��$ *  �� " 	 .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  � �� .R��� $��Center=�$��Segoe UI)�$��15(�
���   ����� *QUYEN+� $��1�� �� �� �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��5,5,5,5q�$��Center=�$��Segoe UI)�$��15(�
���   �)
  #MaterialDesignThemes.Wpf.HintAssist 
  Hint$ 	Họ Tên��$��0������ *TEN+$ TwoWay=�$ PropertyChanged=��� $��5,5,5,5q�$��Center=�$��Segoe UI)�$��15(�
���   �$ Tên đăng nhập��$��1������ *TENDANGNHAP+$ TwoWay=�$ PropertyChanged=�G� -   $��
txtmatkhau��$��5,5,5,5q�$��Center=�$��Segoe UI)�$��15(�
���   �$ Mật khẩu��$��2��� $��3�� � ColumnDefinitions �� �� .+�	� -    	�Name$ 	rdadminbt��$��5,5,5,5q�  MaterialDesignRadioButton#��[ $��Segoe UI)�$��15(�
���   �$��Center=�$��Admin������ *	rdAdmin+����  �� ElementName$ 	rdadminbt��	� -   $ rduser��$��5,5,5,5q�#��[ $��Segoe UI)�$��15(�
���   �$��Center=�$��1��$
��User������ *rdUser+���� $ rduser��� $��4�� �� �� �� .+��� $��Tạo��$��Segoe UI)�$��15(�
���   � $  MaterialDesignRaisedAccentButton#��[ $��5,5,5,5q����� *TaoTaiKhoanComand+���� $ 
txtmatkhau���� $��Reset mật khẩu��$��Segoe UI)�$��15(�
���   �#��[ $��5,5,5,5q�$��1������ *ResetPassComand+�� $
��Xóa��$��Segoe UI)�$��15(�
���   �#��[ $��5,5,5,5q�$��2������ *XoaTaiKhoanComand+