   M S B A M L   `   `   `  ����X  TMoralesLarios.CustomsControls, Version=1.0.0.7, Culture=neutral, PublicKeyToken=nulltRclr-namespace:MoralesLarios.CustomsControls;assembly=MoralesLarios.CustomsControlsMoralesLarios.CustomsControls  5   	   C ?sql_nhom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:sql_nhomsql_nhom 5   	   7 clr-namespace:sql_nhom.Dang_nhapsql_nhom.Dang_nhap 5	   
      sql_nhom.InputWindow   5   	   fCustomsControlsRclr-namespace:MoralesLarios.CustomsControls;assembly=MoralesLarios.CustomsControls  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:sql_nhom     5   	   /uc clr-namespace:sql_nhom.Dang_nhap     5	   
   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          �Name$  window��5   	      InVM � DataContext# [  5   	     MaterialDesignBody#���  5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Phiếu mượn��5   	   $	��500��6   $	��700��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      %  sql_nhom.Dang_nhap.ControlBarUC  
	 � Tag	 6   �� *Title+
 �� ElementName$
 window��6J   5      � 5!   
   $��1��6    5"      �� 5#      $
��auto �6    60   �� 5$      $
��auto �6    60   �� 5%      $
��auto �6    60   �� 5&      6"   .+�5*      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5+      � $��0 0 0 10q�6   .+�5,      �� $��5 5 15 5q�6f   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã phiếu mượn��6x    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *MaPM+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5-      $��5 5 15 5q�6    �� DisplayMemberPath$
 MaNV��61   $ Mã nhân viên��6�    �� 
IsEditable .  & "MaterialDesignFloatingHintComboBox#��[ 6�   ��6J   �� *List1+ �� SelectedItem 6h   �� *
SelectedNV+$ PropertyChanged=�$ TwoWay=�6<  �� 5.      $��5 5 15 5q�6   $ MaThe��61   $ 	Mã thẻ��6�    . #��[ 6�   ��6K   �� *List2+ 6i   �� *SelectedTTV+$ PropertyChanged=�$ TwoWay=�68  (  "System.Windows.Controls.DatePicker  51      $��Bottom=�6!   $	��100��6�   $��5 5 15 5q�6�   $ Ngày mượn��6�    ( $MaterialDesignFloatingHintDatePicker#��[ 6�      SelectedDate 6<   �� *
NgayMuon+$ TwoWay=� �� StringFormat$ 
dd/MM/yyyy��6�   �� 52      $��5 5 15 5q�6l   $ Số ngày mượn��6~   #��[ 6�   ��6   �� *
SoNgayMuon+$ PropertyChanged=�$ TwoWay=�6�   53      54        56      $��1��6"   $��5q�6/   .��57      -   'MoralesLarios.CustomsControls.SearchAll  -   5          Name$ 	searchall��57   ,   58        5:      $��2��6"   $��5q�6/   .��5;      � .+�5<      �� $��Thêm��6<   $��5q�6K   $	��100��6V   ��6   �� *
AddCommand+6d   �� 5=      $��Sửa��6=   $��5q�6L   $	��100��6W   ��6   �� *EditCommand+6e   �� 5>      $��Xóa��6?   $��5q�6N   $	��100��6Y   ��6   �� *DeleteCommand+6g   5@      5A        5E      $��3��6"   $��5q�6/   $��Stretch=�6:   .��5F      �� $
��Auto=�6   .��5G      �� -   5         ��Name$
 list��5G      ��6-   �� *List+ 6J   �� *SelectedItem+$ TwoWay=� �� View 5H      �� 5I      .P�5J   "   �� $��Mã phiếu mượn��61    �� DisplayMemberBinding 6H   �� *MaPM+6p   �� 5K   "   $��Mã nhân viên��61    6G   �� *NhanVien.MaNV+6x   �� 5L   "   $��	Mã thẻ��61    6A   �� *TheThuVien.MaThe+6u   �� 5M   "   $��Ngày mượn��61    6D   �� *
NgayMuon+$ 
dd/MM/yyyy��6�   �� 5N   "   $��Số ngày mượn��61    6G   �� *
SoNgayMuon+6u   5O      5Q      5R      5S      5T      5U      5V      