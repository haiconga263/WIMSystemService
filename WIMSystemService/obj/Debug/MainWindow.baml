   M S B A M L   `   `   `  ����D  @XMLViewer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:XMLViewer;assembly=XMLViewer	XMLViewer  5   	    WIMSystemService!   WIMSystemService.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @	viewerxml*clr-namespace:XMLViewer;assembly=XMLViewer     5   	   -   5          � Title$  
MainWindow��5   	   $	��400��6   $
��1000��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5	      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �  5      �� 5      $��* �6#   �� 5      $��80 �6#   .+�5      �� -   5        $��txtFileLoad��5       �� 
IsReadOnly . $��5q�6;   $��0��6F   $��Stretch=�6V   �� 5      -   5        $��5q�5      $��	Browse...��6    $��1��6J   5         XMLViewer.ViewerUC  5   
   -   5        $��
vxmlBefore��5      $��0��6/   $��1��6?   $��5q�6L   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6%   .+�5      �� -   5        $��<>��5      $��40��6(   $��5q�63   6>   �� 5      -   5        $��txtFileSave��5      $��5q�6+   $��Kết quả:��66   $��Center=�6F   $��Center=�6a   5         5!   
   -   5        $��	vxmlAtfer��5!      $��1��6.   $��1��6>   $��5q�6K   5"      5#      