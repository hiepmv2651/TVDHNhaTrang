   M S B A M L   `   `   `  ����X  TMoralesLarios.CustomsControls, Version=1.0.0.7, Culture=neutral, PublicKeyToken=nulltRclr-namespace:MoralesLarios.CustomsControls;assembly=MoralesLarios.CustomsControlsMoralesLarios.CustomsControls  5   	   C ?sql_nhom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:sql_nhomsql_nhom 5   	   7 clr-namespace:sql_nhom.Dang_nhapsql_nhom.Dang_nhap 5	   
      sql_nhom.UnitWindow   5   	   fCustomsControlsRclr-namespace:MoralesLarios.CustomsControls;assembly=MoralesLarios.CustomsControls  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:sql_nhom     5   	   /uc clr-namespace:sql_nhom.Dang_nhap     5	   
   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          �Name$  window��5   	    
  UnitVM � DataContext# [  5   	     MaterialDesignBody#���  5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Sách��5   	   $	��500��6   $	��700��6#   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      %  sql_nhom.Dang_nhap.ControlBarUC  
	 � Tag	 6   �� *Title+
 �� ElementName$
 window��6J   5      � 5!   
   $��1��6    5"      �� 5#      $
��auto �6    60   �� 5$      $
��auto �6    60   �� 5%      $
��auto �6    60   �� 5&      6"   .+�5)      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5*      � $��0 0 0 10q�6   .+�5+      �� $��5 5 15 5q�6h   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Mã sách��6z    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *MaSach+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5-      $��5 5 15 5q�6    �� DisplayMemberPath$ MaNXB��61   $ Mã NXB��6�    �� 
IsEditable .  & "MaterialDesignFloatingHintComboBox#��[ 6�   ��6K   �� *List1+ �� SelectedItem 6i   �� *SelectedNXB+$ TwoWay=�$ PropertyChanged=�68  �� 5.      $��5 5 15 5q�6   $
 MaTL��61   $ Mã thể loại��6�    . #��[ 6�   ��6J   �� *List2+ 6h   �� *
SelectedTL+$ TwoWay=�$ PropertyChanged=�6;  �� 5/      $��5 5 15 5q�6   $
 MaTG��61   $ Mã tác giả��6�    . #��[ 6�   ��6J   �� *List3+ 6h   �� *
SelectedTG+$ TwoWay=�$ PropertyChanged=�6:  �� 50      $��5 5 15 5q�6i   $ 
Tên sách��6{   #��[ 6�   ��6   �� *	TenSach+$ PropertyChanged=�$ TwoWay=�6�   �� 51      $��5 5 15 5q�6k   $ Tình trạng��6}   #��[ 6�   ��6   �� *	TinhTrang+$ PropertyChanged=�$ TwoWay=�6�   �� 52      $��5 5 15 5q�6g   $ Năm xuất bản��6y   #��[ 6�   ��6   �� *NamXB+$ PropertyChanged=�$ TwoWay=�6�   53      54        56      $��1��6"   $��5q�6/   .��57      -   'MoralesLarios.CustomsControls.SearchAll  -   5          Name$ 	searchall��57   ,   58        5:      $��2��6"   $��5q�6/   .��5;      � .+�5<      �� $��Thêm��6<   $��5q�6K   $	��100��6V   ��6   �� *
AddCommand+6d   �� 5=      $��Sửa��6=   $��5q�6L   $	��100��6W   ��6   �� *EditCommand+6e   �� 5>      $��Xóa��6?   $��5q�6N   $	��100��6Y   ��6   �� *DeleteCommand+6g   5@      5A        5C      $��3��6"   $��5q�6/   $��Stretch=�6:   .��5D      �� $
��Auto=�6   .��5E      �� -   5         ��Name$
 list��5E      ��6-   �� *List+ 6J   �� *SelectedItem+$ TwoWay=� �� View 5F      �� 5G      .P�5H   "   �� $��	Mã sách��61    �� DisplayMemberBinding 6B   �� *MaSach+6l   �� 5I   "   $��Mã NXB��61    6A   �� *NhaXuatBan.MaNXB+6u   �� 5J   "   $��Mã thể loại��61    6F   �� *TheLoai.MaTL+6v   �� 5K   "   $��Mã tác giả��61    6E   �� *TacGia.MaTG+6t   �� 5L   "   $��
Tên sách��61    6C   �� *	TenSach+6n   �� 5M   "   $��Tình trạng��61    6E   �� *	TinhTrang+6r   �� 5N   "   $��Năm xuất bản��61    6G   �� *NamXB+6p   5O      5Q      5R      5S      5T      5U      5V      