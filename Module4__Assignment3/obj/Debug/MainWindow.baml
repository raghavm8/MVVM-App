   M S B A M L   `   `   `  ����O  KModule4__Assignment3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Module4__Assignment3Module4__Assignment3  5   	   Q-clr-namespace:Module4__Assignment3.ViewModelsModule4__Assignment3.ViewModels  5   	   I)clr-namespace:Module4__Assignment3.ModelsModule4__Assignment3.Models  5   	   %    Module4__Assignment3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Module4__Assignment3     5   	   <vm-clr-namespace:Module4__Assignment3.ViewModels     5   	   ;model)clr-namespace:Module4__Assignment3.Models     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��900��6)    � 	Resources 5      7  1Module4__Assignment3.ViewModels.EmployeeViewModel 	  empvm �� 
TargetType 
 txtbox �� Property �� Value �� Triggers P� Property P� Value �� Self	 �� RelativeSource
 �� Path��%�  &	        &	        5   
   6/   �� 5   
   " ��6   .�5      ��  � ��$ 23��6'   �� 5       � ��$	 120��6&   �� 5       � ��$
 Left=�64   �� 5       � ��$	 Top=�62    5      P� 5       �@=�HasError . . �5      ��  � ��
 �  ��64   �� 5       �@�ToolTip 60   �� #	 Z $)
 #(Validation.Errors)[0].ErrorContent�6�   5      5      5      .��5      �  � DataContext 6   ��  �� Source# [  .+�5   
   �� -   5        $
��Name��5      $��
150,62,0,0q�6    �� TextWrapping$
 Wrap=�62   #��[ 6F   ��5       �� $
 emp.Name� �� Mode$ TwoWay=� �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=��� 5"   
   -   5        $	��Age��5"      $��
150,94,0,0q�6   $
 Wrap=�61   #��[ 6E   ��5#      �� $
 emp.Age�$ TwoWay=� . $ PropertyChanged=��� 5%   
   -   5        $��Gender��5%      $��150,134,0,0q�6    $
 Wrap=�65   #��[ 6I   ��5&      �� $
 
emp.Gender�$ TwoWay=� . $ PropertyChanged=��� 5(   
   -   5        $��Address��5(      $��150,176,0,0q�6!   $
 Wrap=�66   #��[ 6J   ��5)      �� $
 emp.Address�$ TwoWay=� . $ PropertyChanged=��� 5,   
   -   5        $��id��5,      $
��Left=�6   $��23��67   $��150,284,0,0q�6C   $
 Wrap=�5-      $	��Top=�6&   $	��120��6>   ��5.      �� $
 EmpId�$ TwoWay=��� 51   
   -   5        $��Lname��51      $
��Name��6   $
��Left=�6,   $��	44,62,0,0q�6G   $	��Top=�52      $��59��6(   �� 53   
   -   5        $
��Lage��53      $	��Age��6   $
��Left=�6*   $��	44,94,0,0q�6E   $	��Top=�54      $��59��6(   �� 55   
   -   5        $��Lgender��55      $��Gender��6   $
��Left=�60   $��
44,134,0,0q�6K   $	��Top=�56      $��59��6(   �� 57   
   -	   5        $��Laddress��57      $��Address��6    $
��Left=�62   $��
44,176,0,0q�6M   $	��Top=�58      $��59��6(   �� 5:   
   -
   5        $��insert��5:   "   $��Insert��6   $
��Left=�60   $��428,333,0,0q�6K   $	��Top=�5;      $��75��6)   $��30��64   ��5<      �� *CreateCommand+�� 5=   
   -   5        $��update��5=   "   $��Update��6   $
��Left=�60   $��528,333,0,0q�6K   $	��Top=�5>      $��75��6)   $��30��64   ��5?      �� *UpdateCommand+�� 5@   
   -   5        $��delete��5@   "   $��Delete��6   $
��Left=�61   $��628,333,0,0q�6L   $	��Top=�5A      $��75��6)   $��30��64   ��5B      �� *DeleteCommand+�� 5C   
   -   5        $
��data��5C       $
��Show��6   $
��Left=�6,   $��728,333,0,0q�6G   $	��Top=�5D      $��75��6)   $��30��64   ��5E      �� *RetrieveCommand+�� 5F   
   -   5        $��employee��5F       $
��Find��6   $
��Left=�60   $��180,330,0,0q�6K   $	��Top=�5G      $��75��6)   $��30��64   ��5H      �� *SearchCommand+&   System.Windows.Controls.DataGrid  5J   
   -   5        $��	data_grid��5J      $
��Left=�6$   $	��245��6?      AutoGenerateColumns .  $	��Top=�5K      $	��463��6+      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 67   $��
356,62,0,0q�6G   ��5L      �� $
 empList�$ TwoWay=�   ColumnHeaderStyle 5M      �� 5N      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5O      ��  � ��$
 Bold"�63   �� 5P       � ��$ 15(�61   5Q         Columns 5S      0  *System.Windows.Controls.DataGridTextColumn  5T      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� $

 Name�  5U      $	 Age��6%    62   �� $	
 Age�  5V      $ Gender��6%    65   �� $
 Gender�  5W      $ Address��6%    66   �� $
 Address�5Y      �� 5\   
   -   5        $	��Lid��5\      $��ID��6   $
��Left=�6(   $��
44,284,0,0q�6C   $	��Top=�6W   $��59��6o   5]      5^      