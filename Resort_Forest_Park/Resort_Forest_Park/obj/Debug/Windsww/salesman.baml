   M S B A M L   `   `   `  ????M  IResort_Forest_Park, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Resort_Forest_Park.WindswwResort_Forest_Park.Windsww  5   	   )    #Resort_Forest_Park.Windsww.salesman   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Resort_Forest_Park.Windsww     5   	   -   5          ? Title$  salesman??5   	   $	??450??6    ? WindowStartupLocation$ CenterScreen=?6'   $	??800??6L   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $	??67* ?6   ?? 5      $
??133* ?6    ? RowDefinitions 5   
   ?? 5      $	??44* ?6   ?? 5      $	??30* ?6   ?? 5      $	??31* ?6   ?? 5      $
??329* ?6   .+?5   
   ?? ???	#FF76E383$??
10,4,10,10q?6+   $??1??6?   $??3??6L   $??2??6]   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	DataGridP??5   *      CanUserAddRows .     AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6Y   $??32,10,32,28q?6i   $??2??6~   $??2??6?   $??2??6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Код заказа??6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 69   ?? *orderr.Thecode+6^     5      $	 Дата создания??6%   
 6<   ?? *orderr.DateofCreation+6h     5      $	 Время заказа??6%   
 6;   ?? *orderr.OrderTime+6b     5      $	 Код клиента??6%   
 6:   ?? *orderr.id_client+6a     5      $#	 Название услуги??6%   
 6>   ?? *Service.Name+6a     5      $	 Статус??6%   
 65   ?? *orderr.Status+6Y     5      $	 Дата закрытия??6%   
 6<   ?? *orderr.Closingdate+6e     5      $	 Время проката??6%   
 6<   ?? *orderr.Rentaltime+6d   5       ?? 5"   
   $'??!Просмотор заказов??6   $??
36,2,261,5q?6-   ???	#FF206328$??24(?6X   $??1??6f   ?? 5#   
   -   5        $??l1??5#      $
??0:60??6   $??1??6)   $??	457,3,0,5q?69   $??16(?6L   ???	#FFFF07076Z   ?? 5$   
   -   5         ??Name$ vx??5$      $??
Назад??6   $y?Visible=?6-   ???	#FF36A743$??390,10,32,26q?6Z   ???	#FF36A743???	#FFF1EFEF$??1??6?   $??2??6?   $??1??6?   5%      5'      