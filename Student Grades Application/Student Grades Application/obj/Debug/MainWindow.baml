   M S B A M L   `   `   `  ����U  QStudent Grades Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Student_Grades_ApplicationStudent_Grades_Application  5   	   +    %Student_Grades_Application.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Student_Grades_Application     5   	     � Title$   Student Grades Application��5   	   $	��419��6,   $	��900��69    � WindowStartupLocation$ CenterScreen=�6E    � 
ResizeMode$ CanMinimize=�6j    � Icon$ /icon_clock.png��6�   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridView��5
         AutoGenerateColumns .  $��334,60,8,15q�6F   $��0,0,0,0q�6[      GridLinesVisibility$
 None=�6�   $��Italic$�6�   
���   ���6u   Z�    	CellStyle 6�   �� *GridLinesVisibility.All+ �� ElementName$ moduleDataGrid��	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Number��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 56 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *[0]+6M     5      $

 Name��6%   $ 49 6K    63   �� *[1]+6K     5      $
 Surname��6%   $ 60 6N    66   �� *[2]+6N     5      $
 Subject��6%   $ 90 6N    66   �� *[3]+6N     5      $
 Ind Assignment��6%   $	 110 6U    6=   �� *[4]+6U     5      $
 Grp Assignment��6%   $	 110 6U    6=   �� *[5]+6U     5      $

 Test��6%   $ * 6X    63   �� *[6]+ �� Mode$ OneWay=�6X   5      �� 5   
   -   5         ��Name$ txtFileName��5      $
��Left=�6'   $��
105,35,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��210��6�   $��19��6�   $��1,0,0,0q�6�   ���	#FF232323 �� SelectionBrush �	#FF008EFF$��Italic$�6�   �� 5   
   $��	File name��6   $
��Left=�6$   $��	31,31,0,0q�6?   $	��Top=�6R   $��29��6j   $��74��6v   $��Right=�6�   $
��Bold"�6�   ���	#FFFF01016�   �� 5   
   $��Subject��6   $
��Left=�6"   $��
26,139,0,0q�6=   $	��Top=�6Q   $��29��6i   $��74��6u   $��Right=�6�   $
��Bold"�6�   �� 5   
   $��
Student No��6   $
��Left=�6%   $��	4,166,0,0q�6@   $	��Top=�6S   $��29��6k   $��96��6w   $��Right=�6�   $
��Bold"�6�   �� 5   
   $
��Name��6   $
��Left=�6   $��
26,190,0,0q�6:   $	��Top=�6N   $��29��6f   $��74��6r   $��Right=�6}   $
��Bold"�6�   �� 5   
   $��Surname��6   $
��Left=�6"   $��
26,216,0,0q�6=   $	��Top=�6Q   $��29��6i   $��74��6u   $��Right=�6�   $
��Bold"�6�   �� 5   
   $��Ind Assignment��6   $
��Left=�6)   $��	0,245,0,0q�6D   $	��Top=�6W   $��29��6o   $	��100��6{   $��Right=�6�   $
��Bold"�6�   �� 5   
   $��Grp Assignment��6   $
��Left=�6)   $��
-5,269,0,0q�6D   $	��Top=�6X   $��29��6p   $	��105��6|   $��Right=�6�   $
��Bold"�6�   �� 5   
   $��Test ��6   $
��Left=�6    $��
26,297,0,0q�6;   $	��Top=�6O   $��29��6g   $��74��6s   $��Right=�6~   $
��Bold"�6�   �� 5   
   -   5        $ SubjectTextBox��5      $
��Left=�6*   $��20��6E   $��105,143,0,0q�6Q   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��210��6�   $��1,0,0,0q�6�   ���	#FF232323 �	#FF008EFF$��Italic$�6�   �� 5    
   -   5        $ StudentNumberTextBox��5       $
��Left=�60   $��21��6K   $��105,169,0,0q�6W   $
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��210��6�   $��1,0,0,0q�6�   ���	#FF232323 �	#FF008EFF$��Italic$�6�   �� 5!   
   -   5        $ StudentNameTextBox��5!      $
��Left=�6.   $��20��6I   $��105,196,0,0q�6U   $
 Wrap=�6j   $�� ��6~   $	��Top=�6�   $	��210��6�   $��1,0,0,0q�6�   ���	#FF232323 �	#FF008EFF$��Italic$�6�   �� 5"   
   -   5        $ SurnameTextBox��5"      $
��Left=�6*   $��21��6E   $��105,222,0,0q�6Q   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��210��6�   $��1,0,0,0q�6�   ���	#FF232323 �	#FF008EFF$��Italic$�6�   �� 5#   
   -   5        $ IndivAssignGradeTextBox��5#      $
��Left=�63   $��21��6N   $��105,250,0,0q�6Z   $
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��210��6�   $��1,0,0,0q�6�   ���	#FF232323 �	#FF008EFF$��Italic$�6�   �� 5$   
   -   5        $ GroupAssignGradeTextBox��5$      $
��Left=�63   $��21��6N   $��105,275,0,0q�6Z   $
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��210��6�   $��1,0,0,0q�6�   ���	#FF232323 �	#FF008EFF$��Italic$�6�   �� 5%   
   -	   5        $ TestGradeTextBox��5%      $
��Left=�6,   $��20��6G   $��105,302,0,0q�6S   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��210��6�   $��1,0,0,0q�6�   ���	#FF232323 �	#FF008EFF$��Italic$�6�   �� 5&   
   -
   5        $��Add to File��5&      $
��Left=�6?   $��20��6Z   $��105,337,0,0q�6f   $	��Top=�6{   $	��210��6�   $��1,0,0,0q�6�   ���	#FF121111���	#FFE6E6E6$
��Bold"�6�   �� 5'   
   -   5        $��Create File��5'      $
��Left=�6@   $��20��6[   $��
105,62,0,0q�6g   $	��Top=�6{   $	��210��6�   $��1,0,0,0q�6�   ���	#FF121111���	#FFE6E6E6$
��Bold"�6�   
���   �6�   �� 5(   
   -   5        $��Display��5(      $
��Left=�69   $��20��6T   $��
332,34,0,0q�6`   $	��Top=�6t   $	��541��6�   $��1,0,0,0q�6�   ���	#FF121111���	#FFE6E6E6$
��Bold"�6�   �� 5)   
   $��Files��6   $
��Left=�6    $��
26,113,0,0q�6;   $	��Top=�6O   $��29��6g   $��74��6s   $��Right=�6~   $
��Bold"�6�   �� 5*   
   -   5         ��Name$ combFileList��5*      $
��Left=�6)   $��105,115,0,0q�6D   $	��Top=�6Y   $	��210��6q   $��21��6}   $��1,0,0,0q�6�   
���   �
�������
���   �$
��Bold"�6�   �� 5+   
   $��/��6   $
��Left=�6   $��
192,81,0,0q�67   $	��Top=�6K   $��29��6c   $��25��6o   $��Right=�6z   $
��Bold"�6�   ���	#FFFF0101$��16(�6�   5-      5.      