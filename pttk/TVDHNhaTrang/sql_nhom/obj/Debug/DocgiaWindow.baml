   M S B A M L   `   `   `  ����X  TMoralesLarios.CustomsControls, Version=1.0.0.7, Culture=neutral, PublicKeyToken=nulltRclr-namespace:MoralesLarios.CustomsControls;assembly=MoralesLarios.CustomsControlsMoralesLarios.CustomsControls  5   	   C ?sql_nhom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:sql_nhomsql_nhom 5   	   7 clr-namespace:sql_nhom.Dang_nhapsql_nhom.Dang_nhap 5	   
      sql_nhom.BaoHanhWindow   5   	   fCustomsControlsRclr-namespace:MoralesLarios.CustomsControls;assembly=MoralesLarios.CustomsControls  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:sql_nhom     5   	   /uc clr-namespace:sql_nhom.Dang_nhap     5	   
   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          �Name$  window��5   	      DocgiaVM � DataContext# [  5   	     MaterialDesignBody#���  5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Độc giả��5   	   $	��500��6   $��727.121��6&   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      %  sql_nhom.Dang_nhap.ControlBarUC  
	 � Tag	 6   �� *Title+
 �� ElementName$
 window��6J   5      � 5!   
   $��1��6    5"      �� 5#      $
��auto �6    60   �� 5$      $
��auto �6    60   �� 5%      $
��auto �6    60   �� 5&      6"   .+�5*      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5+      � $��0 0 0 10q�6   .+�5,      �� $��5 5 15 5q�6f   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã độc giả��6x    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *MaDG+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5-      $��5 5 15 5q�6    �� DisplayMemberPath$
 MaDT��61   $ Mã đối tượng��6�    �� 
IsEditable .  & "MaterialDesignFloatingHintComboBox#��[ 6�   ��6J   �� *List1+ �� SelectedItem 6h   �� *
SelectedDT+$ TwoWay=�$ PropertyChanged=�6<  �� 5.      $��5 5 15 5q�6i   $ Họ tên ĐG��6{   #��[ 6�   ��6   �� *	HoTenDG+$ PropertyChanged=�$ TwoWay=�6�   (  "System.Windows.Controls.DatePicker  5/      $��Bottom=�6!   $	��100��6�   $��5 5 15 5q�6�   $ 
Ngày sinh��6�    ( $MaterialDesignFloatingHintDatePicker#��[ 6�      SelectedDate 6<   �� *
NgaySinh+$ TwoWay=� �� StringFormat$ 
dd/MM/yyyy��6�   �� 50      $��5 5 15 5q�6j   $ Giới tính��6|   #��[ 6�   ��6   �� *
GioiTinh+$ PropertyChanged=�$ TwoWay=�6�   �� 51      $��5 5 15 5q�6h   $ Địa chỉ��6z   #��[ 6�   ��6   �� *DiaChi+$ PropertyChanged=�$ TwoWay=�6�   �� 52      $��5 5 15 5q�6f   $ Số điện thoại��6x   #��[ 6�   ��6   �� *SoDT+$ PropertyChanged=�$ TwoWay=�6�   54      55        57      $��1��6"   $��5q�6/   .��58      -   'MoralesLarios.CustomsControls.SearchAll  -   5          Name$ 	searchall��58   ,   59        5;      $��2��6"   $��5q�6/   .��5<      � .+�5=      �� $��Thêm��6<   $��5q�6K   $	��100��6V   ��6   �� *
AddCommand+6d   �� 5>      $��Sửa��6=   $��5q�6L   $	��100��6W   ��6   �� *EditCommand+6e   �� 5?      $��Xóa��6?   $��5q�6N   $	��100��6Y   ��6   �� *DeleteCommand+6g   5B      5C        5E      $��3��6"   $��5q�6/   $��Stretch=�6:   .��5F      �� $
��Auto=�6   .��5G      �� -   5         ��Name$
 list��5G      ��6-   �� *List+ 6J   �� *SelectedItem+$ TwoWay=� �� View 5H      �� 5I      .P�5J   "   �� $��Mã độc giả��61    �� DisplayMemberBinding 6E   �� *MaDG+6m   �� 5K   "   $��Mã đối tượng��61    6G   �� *LoaiDoiTuong.MaDT+6|   �� 5L   "   $��Họ tên ĐG��61    6D   �� *	HoTenDG+6o   �� 5N   "   $��
Ngày sinh��61    6D   �� *
NgaySinh+$ 
dd/MM/yyyy��6�   �� 5O   "   $��Giới tính��61    6D   �� *
GioiTinh+6p   �� 5P   "   $��Địa chỉ��61    6B   �� *DiaChi+6l   �� 5Q   "   $��Số điện thoại��61    6H   �� *SoDT+6p   5S      5U      5V      5W      5X      5Y      5Z      