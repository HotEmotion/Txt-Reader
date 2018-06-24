系统概述
========

系统名称
--------

>   小说阅读系统

系统需求分析
------------

随着网络的发展，人们开始对电子书越来越喜欢，随之而来出现了许多小说网站，例如起点中文网等。这些网站资源丰富，上网注册登录即可浏览阅读小说，但是对于那些电子小说爱好者，必须登录网站才能看，为了省去打开浏览器搜索进入网站的步骤，我们设计了小说阅读系统。此系统包含了网站的大部分功能，很好地满足了电子小说爱好者的需求，省去了一些步骤，打开登录便可以阅读。

系统功能介绍
------------

此系统包含了大部分需要的功能，为用户提供了图书分类、图书搜索以及排行榜的功能。针对用户的功能：注册、登录、修改密码、开通会员；针对管理员的功能：新增图书、修改图书信息、删除图书。如下图：

![](media/69f3d271782690900bc962a77aae4974.png)

图 小说阅读器功能

数据库设计
==========

1.数据库逻辑结构
----------------

（1）存储图书信息的表：Book ，如下图

![](media/117a999a71295f4142e4edc3e4e1c3c9.png)

图 Book表

（2）存储目录信息的表：Category ，如下图

![](media/549d792be6d5646ecd6060540f14e5f9.png)

图 Category表

（3）存储用户信息的表：Users ，如下图

![](media/9e3e07a8b69c007574b77d79aa170db4.png)

图 Users表

（4）存储用户安全信息的表：UserSecurity ，如下图

![](media/43b1097d78380fd7c980cd049f06a58e.png)

图 UserSecurity表

2.数据库连接与释放
------------------

为了体现面向对象的思想，将数据库的连接、执行命令、释放三步封装成了一个类：SqlHelper。以下是数据库连接和释放的代码。

（1）数据库连接主要是在服务资源管理器添加连接，然后准备连接字符串，创建连接对象，以下是代码。

Private ReadOnly con As String = "Data Source=DESKTOP-71FFAUM;Initial
Catalog=小说阅读器;Integrated Security=True"

Dim SqlCon As SqlConnection = New SqlConnection(con)

（2）数据库连接对象和执行命令对象需要释放，将它们做成一个方法，以下是代码。

Public Sub CloseCmd(ByVal cmd As SqlCommand)

If Not IsNothing(cmd) Then

cmd.Dispose()

cmd = Nothing

End If

End Sub

Public Sub CloseCon(ByVal con As SqlConnection)

If (con.State \<\> ConnectionState.Closed) Then

con.Close()

con = Nothing

End If

End Sub

3.数据库执行命令
----------------

由于Sql语句的不同，定义了以下几个类。

（1）ExecuteNonquery类：用于增删改的操作，参数是在SqlServer中执行的语句，返回的是数据库执行操作后受影响的行数。



（2）ExecuteDataAdapter类：用于查询的操作，参数是在SqlServer中执行的语句，返回的DataTable类。



（3）ExecuteSqlReader类：用于查询的操作，参数是在SqlServer中执行的语句，返回的SqlDataReader类。



系统设计
========

1.把数据库中各个表转化成类，并把表中的属性——VB语言中的字段封装成属性。
----------------------------------------------------------------------------------

（1）Book类

（2）Category类

（3）Users类

2.设计主界面
------------

（1）启动程序后显示主界面，点击主界面的控件会调用其他窗口实现相应的功能，以下是主界面与其他窗口的调用图。

![](media/88a3370a6aaa155c132b16e98306d05a.png)

图 主界面对其他窗口的调用

（2）主界面图

![](media/fe6d01f1bb83c8af060ad3b6f46a9afe.png)

图 主界面

（3）显示在主页面中的排行榜，排行榜图书取所有图书浏览次数前十位，如下图。

![](media/b1dcc5c5feed97692951731be5bddf6f.png)

图 排行榜

3.登录功能介绍
--------------

（1）登录功能流程图如下：

![](media/f5233e0c88048b48c02eadcdb4c5e4ac.png)

图 登录功能流程图

（2）例如以下演示：

打开登录界面，输入用户名及密码；

![](media/5f5e7262ae43d7efc02f085ee3e3ccbe.png)

图 登录功能流程图

登录成功，界面如图所示

![](media/d868200c888cb53af433e4a8427d8f98.png)

图 登录成功界面



4.注册功能介绍
--------------

（1）注册功能流程图如下：

![](media/1fd253b9ff580b9f8420cb37fbfb4478.png)

图 注册功能流程图

（2）如下演示：

打开注册界面，输入用户信息，并勾选用户协议；

![](media/2ca41c3fc454a05baa39b6c452acf06b.png)

图 注册第一步

输入安全问题；

![](media/ad95dffd4b9ffda67b85c899e833e119.png)

图 设置安全问题

数据库信息已录入，注册成功；

![](media/ee23a893fd98d865422dcf7cde82ac9c.png)

图 Users表信息已录入

![](media/f3d93994b615e13c4b946d63a117069a.png)

图 UserSecurity表信息已录入

5.修改密码功能介绍
------------------

（1）修改密码流程图

![](media/ff2826f6f44d64e1449c06327a9a5934.png)

图 修改密码流程图

（2）如下演示：

在登录界面点击忘记密码，进入界面，输入用户名和邮箱；

![](media/3cb8d085f6faa7fe1324131b36549080.png)

图 找回密码第一步

输入信息验证用户；

![](media/f957c09c4f78070460420e46efdf5e19.png)

图 找回密码第二步

输入新密码；

![](media/1c29e5239cdf7e0d416cbe8d7c00f99b.png)

图 找回密码第三步

查看数据库，数据已更新，原来是456789，现在是123456；

![](media/ac0d2d17604d0dcd7c86d8fd8536192c.png)

图 修改密码后数据更新



6.开通VIP功能介绍
-----------------

（1）如下演示：
---------------

显示开通VIP界面；

![](media/f206bac74b4f02b9ff2cd4633a432424.png)

图 开通VIP

点击微信图标，显示二维码；

![](media/8326282fb4f6c81ed759546b35bd1d6e.png)

图 二维码窗口



7.分类功能介绍
--------------

（1）分类界面，点击目录会显示书的相关信息：

![](media/34d7e65f42fb5536b489ff9c5fe4d294.png)

图 分类窗口



8.搜索功能介绍
--------------

点击分类及属性会相应显示相关书籍

![](media/e1bd469acdc91295f69b1038af953abb.png)

图 搜索窗口



9.阅读功能介绍
--------------

（1）点击分类窗口、搜索窗口、排行榜控件中的书本都会触发阅读器窗口（注意：只有VIP才能看VIP书籍），加载阅读器窗口会出现一个进度条窗口（时间比较短，未截图）；

![](media/9491a7618c7389e05971e180125ee63b.png)

图 阅读窗口1

点击上一页、下一页、最后一页、第一页会切换页数，点击字体修改其属性，出现字体对话框；

![](media/8453f1ea6d0a45729e67b834dd4d2888.png)

图 文字对话框

点击确定；

![](media/3f7f2203c31747d7750f24e05b761f46.png)

图 阅读窗口2

点击背景色，出现颜色对话框；

![](media/dc28b626db07f539e75f0f5c525d52d4.png)

图 颜色对话框

点击确定；

![](media/e3f9b11fd3cbdc6417807b3f84dc095b.png)

图 阅读窗口3



10.管理图书功能介绍
-------------------

（1）管理图书界面

![](media/931d1273e11cbd427ec1b4991e814c95.png)

图 管理图书创库界面

（2）新增图书功能流程图

![](media/5c5bdbdc5d346d7060bfaaba2c5679e2.png)

图 新增图书功能流程图

（2）删除图书功能流程图

![](media/9571d4fcd6dd4e6f0f126b6bbd0feeb6.png)

图 删除图书功能流程图

（3）修改图书信息功能介绍

选中书本，更改图书信息，用update语句更新数据库

开发环境
========

Microsoft Visual Studio Community 2017

版本 15.3.5

VisualStudio.15.Release/15.3.5+26730.16

Microsoft .NET Framework

版本 4.7.02556

已安装的版本: Community

Visual Basic 2017 00369-60000-00001-AA656

Microsoft Visual Basic 2017

Microsoft SQL Server Management Studio 11.0.3128.0

Microsoft Analysis Services 客户端工具 11.0.3128.0

Microsoft 数据访问组件 (MDAC) 10.0.16299.15

Microsoft MSXML 3.0 6.0

Microsoft Internet Explorer 9.11.16299.0

Microsoft .NET Framework 4.0.30319.42000

操作系统 6.3.16299

总结
====

通过本次课程设计，使我增加了对ＶＢ课程的了解．
首先了解到ＶＢ的特点，ＶＢ是在原来的Ｂasic语言基础上发展而来的．Ｖisual指的是可视的图形用户界面开发方法.不需编写大量代码去描述界面元素的外观和位置。

VB不仅是可视语言,而且是面向对象的编程语言，其特点是概念多,实践性强,涉及面广。例如类,就是创建对象实例的模板包含了创建的属性描述和行为特征的定义，而此中的对象又是类的一个实例,继承了类的属性,方法,而VB中长用的对象有窗体,控件等。同时对MVC架构稍微了解，本程序的也有了雏形的MVC架构。

参考网站
========

<http://blog.csdn.net/>

<https://www.cnblogs.com/sirrah/articles/2349034.html>

*https://www.cnblogs.com/ly312/archive/2011/02/28/1966881.html*
