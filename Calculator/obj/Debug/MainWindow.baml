   M S B A M L   `   `   `  ����E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator  5   	       Calculator.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Calculator     5   	     � 
ResizeMode$  NoResize=�5       � Title$ 
Calculator��5   	   $��445.833��6   $��247.5��6-   $��15(�5	   	   $
��Bold"�6    � Icon$ Properties/calculator.ico��5
   	   .��5      � $��
-95,0,-7,4q�6   $
��Left=�6   $	��532��6:   .+�5   
   �� -   5         ��Name$ dotBtn��5      
����p��$��,��6<   $
��Left=�6H   $��163,290,0,0q�6c   $	��Top=�6x   $��48��6�   $��50��6�   6�   �� 5   
   -   5        $ numberZeroBtn��5      
����p��$��0��6C   $
��Left=�6O   $��110,290,0,0q�6j   $	��Top=�6   $��48��6�   $��50��6�   6�   �� 5   
   -   5        $ numberOneBtn��5      
��� ���$��1��6;   $
��Left=�6G   $��110,235,0,0q�6b   $	��Top=�6w   $��48��6�   $��50��6�   6�   �� 5   
   -   5        $ numberTwoBtn��5      
��� ���$��2��6;   $
��Left=�6G   $��163,235,0,0q�6b   $	��Top=�6w   $��48��6�   $��50��6�   6�   �� 5   
   -   5        $ numberThreeBtn��5      
��� ���$��3��6=   $
��Left=�6I   $��216,235,0,0q�6d   $	��Top=�6y   $��48��6�   $��50��6�   6�   �� 5   
   -   5        $ numberFourBtn��5      
���/���$��4��6A   $
��Left=�6M   $��110,180,0,0q�6h   $	��Top=�6}   $��48��6�   $��50��6�   6�   �� 5   
   -   5        $ numberFiveBtn��5      
���/���$��5��6A   $
��Left=�6M   $��163,180,0,0q�6h   $	��Top=�6}   $��48��6�   $��50��6�   6�   �� 5   
   -   5        $ numberSixBtn��5      
���/���$��6��6@   $
��Left=�6L   $��216,180,0,0q�6g   $	��Top=�6|   $��48��6�   $��50��6�   6�   �� 5   
   -	   5        $ numberSevenBtn��5      
����� �$��7��6;   $
��Left=�6G   $��110,125,0,0q�6b   $	��Top=�6w   $��48��6�   $��50��6�   6�   �� 5   
   -
   5        $ numberEightBtn��5      
����� �$��8��6;   $
��Left=�6G   $��163,125,0,0q�6b   $	��Top=�6w   $��48��6�   $��50��6�   6�   �� 5   
   -   5        $ numberNineBtn��5      
����� �$��9��6:   $
��Left=�6F   $��216,125,0,0q�6a   $	��Top=�6v   $��48��6�   $��50��6�   6�   �� 5   
   -   5        $ additionBtn��5      
�����_�$��+��6=   $
��Left=�6I   $��269,345,0,0q�6d   $	��Top=�6y   $��48��6�   $��50��6�   6�   �� 5   
   -   5        $ subtractionBtn��5      
�����_�$��-��6@   $
��Left=�6L   $��269,290,0,0q�6g   $	��Top=�6|   $��48��6�   $��50��6�   6�   �� 5   
   -   5        $ multiplicationBtn��5      
�����_�$��*��6C   $
��Left=�6O   $��269,235,0,0q�6j   $	��Top=�6   $��48��6�   $��50��6�   6�   �� 5   
   -   5        $ divisionBtn��5      
�����_�$��/��6=   $
��Left=�6I   $��269,180,0,0q�6d   $	��Top=�6y   $��48��6�   $��50��6�   6�   �� 5   
   -   5        $ 	moduloBtn��5      
�����_�$��%��6;   $
��Left=�6G   $��269,125,0,0q�6b   $	��Top=�6w   $��48��6�   $��50��6�   6�   �� 5!   
   -   5        $ deleteAllBtn��5!      
�������$��C��6:   $
��Left=�6F   $��216,345,0,0q�6a   $	��Top=�6v   $��48��6�   $��50��6�   6�   �� 5"   
   -   5        $ 	deleteBtn��5"      
����p��$	��←��6?   $
��Left=�6K   $��216,290,0,0q�6f   $	��Top=�6{   $��48��6�   $��50��6�   6�   �� 5#   
   -   5        $ 	equalsBtn��5#      
�������$��=��67   $
��Left=�6C   $��110,345,0,0q�6^   $	��Top=�6s   $	��101��6�   $��50��6�   6�   �� 5&   
   -   5         ��Name$ resultTextBox��5&       �� 
IsReadOnly . $
��Left=�6;   $��25��6V   $��
110,85,0,0q�6b    �� TextWrapping$
 Wrap=�6v   $��0��6�   $	��Top=�6�   $	��207��6�   �� 5'   
   -   5        $ allCalculationsTextBox��5'       . $
��Left=�6D   $��70��6_   $��
110,10,0,0q�6k   $
 Wrap=�6   $��0��6�   $	��Top=�6�   $	��207��6�   ��. " �� VerticalScrollBarVisibility$
 Auto=�6�   5(      5)      