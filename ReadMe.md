# Pro Asp.Net Mvc 5

- SportsStore

## SportsStore
- CH7-1 创建新项目
	0. 创建空解决方案
	0. 创建WebUI项目
	0. 创建Domain项目
	0. 创建单元测试项目
	0. 设置启动项目和启动页
	0. 设置依赖
		0. Nuget: Ninject -> WebUI
		0. Nuget: Ninject.Web.Common -> WebUI
		0. Nuget: Ninject.MVC5 -> WebUI
		0. Nuget: Moq -> WebUI
		0. Nuget: Microsoft.AspNet.Mvc -> Domain
		0. Nuget: Ninject -> UnitTests
		0. Nuget: Ninject.Web.Common -> UnitTests
		0. Nuget: Ninject.MVC5 -> UnitTests
		0. Nuget: Moq -> UnitTests
		0. Nuget: Microsoft.AspNet.Mvc -> UnitTests
		0. Domain --> DataAnnotations
		0. WebUI --> Domain
		0. UnitTests --> Domain
		0. UnitTests --> WebUI
		0. UnitTests --> System.Web
		0. UnitTests --> Micrsoft.CSharp
	0. 设置DI容器(WebUI)
- CH7-2 从Domain开始
	0. Products.cs
	0. IProductRepository.cs
	0. Mock IProductRepository.cs(WebUI)
- CH7-3 Controller
	0. ProductController
	0. ProductController/List
	0. Product View(Use Layout)
	0. Modify Layout
	0. Modify View
	0. Route
- CH7-4 Database
	0. 

