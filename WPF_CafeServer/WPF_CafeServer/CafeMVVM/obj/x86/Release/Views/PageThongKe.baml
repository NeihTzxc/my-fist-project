   M S B A M L   `   `   `  ���� C  ?CafeMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CafeMVVM.ViewModelsCafeMVVM.ViewModels       CafeMVVM.Views.PageThongKe   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:CafeMVVM.ViewModels     V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���   � DataContext +   %CafeMVVM.ViewModels.ThongKeViewModels  .���  � RowDefinitions �� $
��Auto ��� .+�(  "MaterialDesignThemes.Wpf.ColorZone  $��0��   Mode$ Accent=�.���� $��20��� $��1�� � ColumnDefinitions �� $
��Auto ��� .+�� $��0�� �� $
��Auto ��� $
��Auto �.+�� $��0�� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+�  $ PrimaryDark=�$��0,0,5,0q�.���� $��Segoe UI)�$��15(�$
��Bold"�
�������$��Center=�$��Thống kê theo Món��$��30���� $��1��.+��� -    ��Name$ 
cbngay_mon��$��Center=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Chọn ngày��
���   �$��Segoe UI)�$��5q� �� Text �� *
CbNgay_Mon+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=��� -   $ cbthang_mon��$��Center=�$ Chọn tháng��
���   �$��5q� �� *CbThang_Mon+$	 TwoWay=�$
 PropertyChanged=�(  "System.Windows.Controls.DatePicker  -     Name$ date_mon��$��Center=�$ Chọn ngày cụ thể��
���   �$��5q�   Text �� *Date_tuchon_Mon+$	 TwoWay=�$
 PropertyChanged=�� $��2�� �� �� �� .+�	� -    	�Name$ 	rdngaymon��$��5q�$��Center=�$��Segoe UI)�
���   �$��
Theo Ngày��$��0������ *rdNgayCommand+	� -   $ 
rdthangmon��$��5q�$��Center=�$��Segoe UI)�
���   �$��Theo Tháng��$��1������ *rdThangComand+	� -   $ rdtuchonmon��$��5q�$��Center=�$��Segoe UI)�
���   �$��Ngày cụ thể��$��2������ *rdTuchonComand+�� -    ��Name$ btnmon��$��5q�$��Segoe UI)�$��15(�$
��Bold"�$	��Xem��
���   � $  MaterialDesignRaisedAccentButton#��[ $��3������ *TkMonCommand+� $��1�� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+�  $ PrimaryDark=�$��0,0,5,0q�.���� $��Segoe UI)�$��15(�$
��Bold"�
�������$��Center=�$��Thống kê Doanh Thu��$��30���� $��1��.+��� -   $ cbngaydoanhthu��$��Center=�$ Chọn ngày��
���   �$��5q� �� *CbNgay_DoanhThu+$	 TwoWay=�$
 PropertyChanged=��� -	   $ cbthangdoanhthu��$��Center=�$ Chọn tháng��
���   �$��5q� �� *CbThang_DoanhThu+$	 TwoWay=�$
 PropertyChanged=�  -
   $ date_doanhthu��$��Center=�$ Chọn ngày cụ thể��
���   �$��5q� �� *Date_tuchonDoanhThu+$	 TwoWay=�$
 PropertyChanged=�� $��2�� �� �� �� .+�	� -   $ rdngay_doanhthu��$��5q�$��Center=�$��Segoe UI)�
���   �$��
Theo Ngày��$��0������ *rdNgayCommand_dt+	� -   $ rdthang_doanhthu��$��5q�$��Center=�$��Segoe UI)�
���   �$��Theo Tháng��$��1������ *rdThangComand_dt+	� -   $ rdchonngay_doanhthu��$��5q�$��Center=�$��Segoe UI)�
���   �$��Ngày cụ thể��$��2������ *rdTuchonComand_dt+�� -   $ btndoanhthu��$��5q�$��Segoe UI)�$��15(�$
��Bold"�$	��Xem��
���   �#��[ $��3������ *TkDtCommand+� $��1�� �� �� $
��Auto �.+�&   System.Windows.Controls.DataGrid  -     Name$ 
dg_macdinh��   
IsReadOnly .    AutoGenerateColumns .  ���� *DanhSachMacDinh+$	 TwoWay=�$
 PropertyChanged=� �� SelectedItem �� *SelectedDoanhThuMacDinh+$	 TwoWay=�$
 PropertyChanged=� � 	Resources *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%R   '        �� "   P�  �@ 
IsSelected . . ���  � ��
 � ���   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,	  &System.Windows.Controls.DataGridColumn 	  Header$ 	Khu vực�� 	  Width5
  /System.Windows.Controls.DataGridLengthConverter$ *
  	  HeaderStyle �� =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  �   CellTemplate �� .R��� $��15(�$��Segoe UI)�
���   �$��Center=����� *	TENKHUVUC+  $
 Bàn��$ *
  �� "  .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  � �� .R��� $��15(�$��Segoe UI)�
���   �$��Center=����� *TENBAN+  $ Tổng tiền��$ *
  �� "  .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  � �� .R��� $��15(�$��Segoe UI)�
���   �$��Center=����� *
TONGTIEN+  $ Ngày��$ *
  �� "  .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  � �� .R��� $��15(�$��Segoe UI)�
���   �$��Center=����� *	NGAYLAP+  $ Giờ��$ *
  �� "  .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��$
 Bold"���  � ��
 ��  � �� .R��� $��15(�$��Segoe UI)�
���   �$��Center=����� *GIOLAP+  -   $ dg_mon�� .  .  $y�	Collapsed=����� *DanhSachThongKeMon+$	 TwoWay=�$
 PropertyChanged=� ��%R   '        �� "   P�  �@ 
IsSelected . . ���  � ��
 � ���   $
 Món��$ *
  �� "  .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��
 ��  � �� .R��� $��Center=�$��Segoe UI)�$��15(�
���   ����� *
TENTHUCDON+  $ Số lượng��$ *
  �� "  .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��
 ��  � �� .R��� $��Center=�$��Segoe UI)�$��15(�
���   ����� *	SOLUONG+  $ Tổng tiền��$ *
  �� "  .���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$ 15(���  � ��
 ��  � �� .R��� $��Center=�$��Segoe UI)�$��15(�
���   ����� *
TONGTIEN+� $��1�� �� �� .+��� $��5q�$
��Left=�$��15(�$
��Bold"�
���  ��$��Segoe UI)�$��0������ *SOLUONGHOADON+$	 TwoWay=�$
 PropertyChanged=��� $��5q�$��Right=�$��15(�$
��Bold"�
���  ��$��Segoe UI)�$��1������ *TONGTIENHOADON+$	 TwoWay=�$
 PropertyChanged=�