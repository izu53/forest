   M S B A M L   `   `   `  ????M  IResort_Forest_Park, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Resort_Forest_Park.WindswwResort_Forest_Park.Windsww  5   	   &     Resort_Forest_Park.Windsww.admin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Resort_Forest_Park.Windsww     5   	   -   5          ? Title$  admin??5   	   $	??450??6   $	??800??6$    ? WindowStartupLocation$ CenterScreen=?60   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $	??67* ?6   ?? 5      $
??133* ?6    ? RowDefinitions 5   
   ?? 5      $	??44* ?6   ?? 5      $	??30* ?6   ?? 5      $	??31* ?6   ?? 5      $
??329* ?6   .+?5   
   ?? ???	#FF76E383$??
10,4,10,10q?6+   $??1??6?   $??3??6L   $??2??6]   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	DataGridP??5   *      CanUserAddRows .     AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6Y   $??
32,1,32,28q?6i   $??3??6}   $??2??6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$!	 Id-пользователя??6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6>   ?? *id_employees+6a     5      $	 Имя??6%   
 62   ?? *Employees.Name+6W     5      $	 Фамилия??6%   
 66   ?? *Employees.Surname+6^     5      $	 Очество??6%   
 66   ?? *Employees.Middlename+6a     5      $	 
Логин??6%   
 64   ?? *	Logintype+6T     5      $	 Пароль??6%   
 65   ?? *Employees.Password+6^     5      $	 Дата входа??6%   
 69   ?? *Lastentrance+6\   5      ?? 5    
   -   5        $??t1??5       $??	32,29,3,4q?6   $??1??6/   $??2??6Y   ?? 5!   
   $??
Поиск??6   $??
32,10,98,1q?6!   ???	#FF206328$??1??6L   $??14(?6Y   ?? 5"   
   $??История входа??6   $??
36,2,304,5q?6)   ???	#FF206328$??24(?6T   $??1??6b   ?? 5#   
   -   5        $??l1??5#      $
??0:60??6   $??1??6)   $??	457,3,0,5q?69   $??16(?6L   ???	#FFFF07076Z   ?? 5$   
   -   5         ??Name$ vx??5$      $??
Назад??6   $y?Visible=?6-   ???	#FF36A743$??390,30,32,4q?6Z   ???	#FF36A743???	#FFF1EFEF$??1??6?   $??2??6?   $??1??6?   5%      5&      