   M S B A M L   `   `   `  ����  Arrival Departure    Arrival_Departure.Main   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$
  Main��5   	   $��388.325��6   $��943.775��6'   .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��5* �6   6*   �� 5	      $��1* �6   6*    � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��5* �6   6,   �� 5      6!   .+�5   
   �� $��0��6   $��0��6   $��Поиск по ФИО��6-   $��10,10q�6D   �� 5   
   -   5         ��Name$ 
NameFilter��5   /   $��0��6   $��1��6   $��10,10q�6C   �� 5   
   -   5         ��Name$ 	FilterBtn��5   .   $��0��6   $��2��6   $��10,10q�6A   $��
Поиск��6P    �� 	IsDefault . 6r   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DG��5   4   $��1��6   $��3��6    $	��Top=�6@   $	��236��6X   $��
10,10,10,0q�5         
IsReadOnly .  �� SelectedItem 6U   �� 	 �� Path$		 usr�5      �� 5   
   -   5        $��2��5      $��0��6   $��10,10q�6.   $��Новый паспорт��6=   6U   5      5      