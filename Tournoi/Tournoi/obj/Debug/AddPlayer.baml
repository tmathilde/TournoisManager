   M S B A M L   `   `   `  ����B  >Tournoi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TournoiTournoi  5   	       Tournoi.AddPlayer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Tournoi     5   	     � Title$  	AddPlayer��5   	   $	��450��6   $	��800��6(   .��5	      � -   5        .+�5
   
   �� -   5         ��Name$ namePlayerTextBox��5
      $
��Left=�6-   $��23��6H   $��
98,151,0,0q�6T    �� TextWrapping$
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ namePlayerLabel��5      $��	Last name��6)   $
��Left=�6=   $��121,120,0,0q�6X   $	��Top=�6m   �� 5   
   -   5        $ firstNamePlayerLabel��5      $��
First name��6.   $
��Left=�6C   $��303,120,0,0q�6^   $	��Top=�6s   �� 5   
   -   5        $ lastNamePlayerTextBox��5      $
��Left=�61   $��23��6L   $��274,151,0,0q�6X   $
 Wrap=�6m   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ numberPlayerTextBox��5      $
��Left=�6/   $��23��6J   $��474,151,0,0q�6V   $
 Wrap=�6k   $�� ��6   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $  nationalitiesPlayerTextBox��5      $
��Left=�66   $��23��6Q   $��
98,229,0,0q�6]   $
 Wrap=�6q   $�� ��6�   $	��Top=�6�   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
datePlayer��5      $
��Left=�6)   $��274,229,0,0q�6D   $	��Top=�6Y   $	��120��6q    J� RenderTransformOrigin$ -1.283,0.458&�6}   �� 5   
   $��Number��6   $
��Left=�6!   $��508,120,0,0q�6<   $	��Top=�6Q   �� 5   
   $
��Post��6   $
��Left=�6   $��681,120,0,0q�6:   $	��Top=�6O   $ 17.312,-2.654&�6g   �� 5   
   -	   5         ��Name$ postPlayerComboBox��5      $
��Left=�6/   $��636,152,0,0q�6J   $	��Top=�6_   $	��120��6�   ��6w   �� 6�   �� 5   
   $��Nationalities��6   $
��Left=�6(   $��121,198,0,0q�6C   $	��Top=�6X   �� 5   
   $��
Birth date��6   $
��Left=�6%   $��306,198,0,0q�6@   $	��Top=�6U   �� 5   
   -
   5         ��Name$ 
BackButton��5      $
��Back��6%   $
��Left=�64   $��681,268,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $ addPLayerButton��5      $	��Add��6*   $
��Left=�68   $��681,293,0,0q�6S   $	��Top=�6h   $��75��6�   6�   �� 5   
   -   5        $ nameTeamPlayerComboBox��5      $
��Left=�63   $��474,229,0,0q�6f   $	��Top=�6{   $	��120��6�   ��6N   �� 6�   �� 5   
   $��Name of team��6   $
��Left=�6'   $��489,198,0,0q�6B   $	��Top=�6W   5      5      