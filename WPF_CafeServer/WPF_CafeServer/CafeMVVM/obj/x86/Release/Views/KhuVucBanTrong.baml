   M S B A M L   `   `   `  ���� C  ?CafeMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CafeMVVM.ViewModelsCafeMVVM.ViewModels  #    CafeMVVM.Views.KhuVucBanTrong   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:CafeMVVM.ViewModels     V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     �Name$  	wbantrong�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���   � Triggers :�  :� RoutedEvent$ Window.Loaded��[��� .����  g� 	BeginTime$ 0X�	 g� Duration$	 ForeverD�.��W� -   
 �� 
TargetName$
 	wbantrong��$	 00:00:01D� �� TargetProperty$ Opacity� W� From$ 0X�	 W� To$ 1X� � DataContext -   'CafeMVVM.ViewModels.KhuVucBanViewModels  .���  � RowDefinitions �� $
��Auto ��� �� $
��Auto �.+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Accent=�.���� $��20��&   System.Windows.Controls.DataGrid  $��1��   AutoGenerateColumns .     
IsReadOnly . $��5q����� *DanhSachBanTrong+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� � 	Resources *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%R   '        �� "   P�  �@ 
IsSelected . . ���  � ��
 � ���   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 	Tên bàn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    HeaderStyle �� =	  7System.Windows.Controls.Primitives.DataGridColumnHeader" 	 .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  �    CellTemplate  �� .R��� $��Center=�$��Segoe UI)�$��15(�
���   ����� *TENBAN+  $ Tên khu vực��$ *  �� " 	 .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  �  �� .R��� $��Center=�$��Segoe UI)�$��15(�
���   ����� *	TENKHUVUC+  $ Trạng thái��$ *  �� " 	 .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  �  �� .R��� $��Center=�$��Segoe UI)�$��15(�
���   ����� *	TRANGTHAI+�� -   ! ��Name$! btnthoat��$��Segoe UI)�$��15(�$
��Bold"�
�������$��Thoát�� " MaterialDesignRaisedDarkButton#��[ $��5,5,5,5q�$��2��