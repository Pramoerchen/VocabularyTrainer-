   M S B A M L   `   `   `  ����I  EVokabeltrainer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VokabeltrainerVokabeltrainer  5   	   /    )Vokabeltrainer.abfrage_richtung_aussuchen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Vokabeltrainer     5   	     � Title$   abfrage_richtung_aussuchen��5   	   $	��450��6,   $	��800��69   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��53* �6   �� 5      $��9* �6    � ColumnDefinitions 5   
   �� 5      $	��83* �6   �� 5      $
��717* �6   .+�5   
   	� -   5         	�Name$ rdobtn_EngZuDeu��5   �   $��Deutsch <- Englisch��6   $��1��67   $
��Left=�6G   $��207,292,0,0q�6b   $	��Top=�6w   6�   	� 5   
   -   5        $ rdobtn_DeuRndEng��5   �   $��Deutsch <-> Englisch��6   $��1��6;   $
��Left=�6K   $��207,331,0,0q�6f   $	��Top=�6{   6�   	� 5   
   -   5        $ rdobtn_DeuZuEng��5   �   $��Deutsch -> Englisch��6   $��1��67   $
��Left=�6G   $��207,257,0,0q�6b   $	��Top=�6w   6�   �� 5   
   -   5         ��Name$ 
btn_Abrage��5   �   $��Abfragen��6   $��1��6$   $
��Left=�64   $��177,360,0,0q�6O   $	��Top=�6d   $��34��6|   $��92��6�   $��2��6�   �� 5   
   -   5         ��Name$ sprache_1_selector��5      $��0,104,545,64q�6/   $��1��6|    �� View 5      �� 5      .P�5      �� 5      5      �� 5   
   -   5        $ sprache_2_selector��5      $��462,104,83,64q�6/   $��1��6F    5      �� 5      .P�5       �� 5!      5#      �� 5$   
   -   5         ��Name$ warnings_lbl��5$      $7��1Gebe für diese Abfrage bitte min. 2 Vokabeln ein��6&   $��1��6a   $
��Left=�6q   $��177,217,0,0q�6�   $	��Top=�6�   $	��280��6�   $y�Hidden=�6�   
���  ��6�   �� 5%   
   -   5        $ exit_btn��5%      $��	Verlassen��6:   $��1��6N   $
��Left=�6^   $��330,360,0,0q�6y   $	��Top=�6�   $��34��6�   $��77��6�   $��2��6�   5'      5(      