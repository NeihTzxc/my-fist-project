   M S B A M L   `   `   `  ���� C  ?CafeMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CafeMVVM.ViewModelsCafeMVVM.ViewModels  &     CafeMVVM.Views.PageChiTietHoaDon   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:CafeMVVM.ViewModels     V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     �Name$  
wchitiethd�� � Title$ PageChiTietHoaDon��$	��400��$	��500�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���   � Triggers :�  :� RoutedEvent$ Window.Loaded��[��� .���� 	 g� 	BeginTime$	 0X�
 g� Duration$
 ForeverD�.��W� -    �� 
TargetName$ 
wchitiethd��$
 00:00:01D� �� TargetProperty$ Opacity� W� From$ 0X�	 W� To$ 1X� � DataContext +   %CafeMVVM.ViewModels.ThongKeViewModels  .���  � RowDefinitions �� $
��Auto ��� �� $
��Auto �.+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Accent=�.���� $��20��&   System.Windows.Controls.DataGrid  $��5q�   AutoGenerateColumns .     
IsReadOnly . $��1������ *ChiTietHoaDon+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Món��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    HeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  �� Property � �� �� Value$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  �   CellTemplate �� .R��� $��Segoe UI)�$��15(�
���   �$��Center=����� *
TENTHUCDON+  $ 
Đơn giá��$ *  �� "  .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  � �� .R��� $��Segoe UI)�$��15(�
���   �$��Center=����� *DONGIA+  $ Số lượng��$ *  �� "  .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  � �� .R��� $��Segoe UI)�$��15(�
���   �$��Center=����� *	SOLUONG+  $ Giảm giá (%)��$ *  �� "  .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  � �� .R��� $��Segoe UI)�$��15(�
���   �$��Center=����� *	GIAMGIA+�� -    ��Name$ btnthoat��$��Thoát��$��Segoe UI)�$��15(�$
��Bold"�$��5q�$��2��