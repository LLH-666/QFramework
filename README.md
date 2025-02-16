[TOC]





![](./Documents/Res/QFramework-icon-0.1.0-512x128.png)

[![](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/liangxiegame/QFramework/blob/master/LICENSE)
[![Build Status](https://travis-ci.org/liangxiegame/QFramework.svg?branch=master)](https://travis-ci.org/liangxiegame/QFramework)
[![Coverage Status](https://coveralls.io/repos/github/liangxiegame/QFramework/badge.svg?branch=master)](https://coveralls.io/github/liangxiegame/QFramework?branch=master)

# QFramework 简介 Intro
  [QFramework](https://github.com/liangxiegame/QFramework) 是一套 **渐进式** 的 **快速开发** 框架。目标是作为无框架经验的公司、独立开发者、以及 Unity3D 初学者们的 **第一套框架**。框架内部积累了多个项目的在各个技术方向的解决方案。学习成本低，接入成本低，重构成本低，二次开发成本低，文档内容丰富(提供使用方式以及原理、开发文档)、插件丰富。github:https://github.com/liangxiegame/QFramework



[码云国内镜像仓:https://gitee.com/liangxiegame/QFramework](https://gitee.com/liangxiegame/QFramework)



## 功能列表

| 模块名称  | 包含功能                  | 描述                                                         |
| --------- | ------------------------- | ------------------------------------------------------------ |
| Core      | Architecture              | 一套全栈通用的系统设计架构，QF 的本身是用这套架构设计，同时这套架构可以应用与项目开发，为 QF 的主要提供架构，QF 的文档系统（React）、QF 的插件系统（.Net Core）均用此架构开发。 |
|           | CodeGen                   | 代码生成库，一套链式代码生成模板。                           |
|           | Singleton                 | 一套单例模板工具                                             |
|           | IOC                       | 依赖注入/控制反转容器                                        |
|           | Event                     | 事件机制实现，包含枚举事件 和 类型事件                       |
|           | Pool                      | 各种对象池提供，包含 List、Dictionary 对象池                 |
|           | FSM                       | 一套基于类型的状态机实现                                     |
|           | Disposable                | 销毁模式 和 对应扩展方法实现                                 |
|           | Factory                   | 对象的创建模式封装                                           |
|           | RefCounter                | 引用计数器实现                                               |
|           | CSharpExtensions          | 大量的方便易用的扩展实现                                     |
|           | Table                     | 可以建立索引的表格数据结构实现                               |
|           | EasyIMGUI                 | 方便易用的、面向对象的（组合模式）的 IMGUI（OnGUI）绘制库    |
|           | Utility                   | 各种静态方法封装                                             |
|           | ManagerOfManagers（弃用） | Manager Of Managers 架构的实现                               |
| ActionKit | 之后写                    |                                                              |
| ResKit    | SimulationModel           | 真机和编辑器模拟资源加载双模式，让开发阶段与真机阶段自如切换                 |
|           | ResPathLoad               | 从Resources目录与沙盒目录以及从网络中加载资源                                             |
|           | LoadSprite                | 加载Sprite或精灵图集                                        |
|           | LoadScene                 | 在AssetBundle中同步与异步加载Scene场景                       |
|           | ResAssetManager           | 标记的AssetBunlde资源管理，快速定位                |
|           | LoadASync                 | 异步加载与异步队列加载                                     |
|           | CustomRes                 | Reskit功能自定义拓展                                |
|           | CustomLoadConfig          | AssetBundle自定义配置表生成                                           |
| UIKit     | 之后写                    |                                                              |
| AudioKit  | 之后写                    |                                                              |



### ShowCase（商业案例）
| [鬼山之下](https://store.steampowered.com/app/1517160/_/) | [谐音梗挑战](https://www.taptap.com/app/201075) |
| :-------------------------------------------------------: | :---------------------------------------------: |
|        ![](./Documents/Res/ShowCase/鬼山之下.png)         |  ![](./Documents/Res/ShowCase/谐音梗挑战.png)   |



## Star 趋势（如果项目有帮到您欢迎点赞）

[![Stargazers over time](https://starchart.cc/liangxiegame/QFramework.svg)](https://starchart.cc/liangxiegame/QFramework)





### 正在进行

* ResKit 完善（[h3166179](https://github.com/h3166179)）
* ILRuntime 方案初始版本（[王二 so-sos-so](https://github.com/so-sos-so) ）
* 插件、内置模块整理：跑酷 Demo 更新最新架构（[凉鞋 liangxieq](https://github.com/liangxieq)）



#### 快速图解:

**1.ViewController和Bind的基本使用 自动生成脚本**

![](./Documents/Res/Gif/1.ViewController与Bind模式下脚本和Prefab生成/1.ViewController和Bind的基本使用自动生成脚本.gif) 

自动生成的脚本如下：

![](./Documents/Res/Gif/1.ViewController与Bind模式下脚本和Prefab生成/1.相关脚本.jpg) 

**2.ViewController和ViewController的嵌套使用**

![](./Documents/Res/Gif/1.ViewController与Bind模式下脚本和Prefab生成/2.ViewController和ViewController的嵌套使用.gif) 

自动生成的脚本如下：

![](./Documents/Res/Gif/1.ViewController与Bind模式下脚本和Prefab生成/2.相关脚本.jpg) 

**3.自动生成Prefab**

![](./Documents/Res/Gif/1.ViewController与Bind模式下脚本和Prefab生成/3.自动生成Prefab.gif) 

**4.使用UIKit创建Prefab和脚本**

![](./Documents/Res/Gif/2.UIKit/1.使用UIKit创建Prefab和脚本.gif) 

自动生成的脚本如下：

![](./Documents/Res/Gif/2.UIKit/1.相关脚本.jpg) 

**5.使用UIKit子控件UIElement**

![](./Documents/Res/Gif/2.UIKit/2.使用UIKit子控件UIElement.gif) 

#### 快速开始 QuickStart:

**1.Action Kit**

* chainning style(Driven by MonoBehaviour or Update)

``` csharp
this.Sequence()
	.Delay(1.0f)
	.Event(()=>Log.I("Delayed 1 second"))
	.Until(()=>something is done)
	.Begin();
```

* object oriented style

``` csharp
var sequenceNode = new SequenceNode();
sequenceNode.Append(DelayAction.Allocate(1.0f));
sequenceNode.Append(EventAction.Allocate(()=>Log.I("Delayed 1 second"));
sequenceNode.Append(UntilAction.Allocate(()=>something is true));

this.ExecuteNode(sequenceNode);
```

**2.Res Kit**
``` csharp
// allocate a loader when initialize a panel or a monobehavour
var loader = ResLoader.Allocate();

// load someth in a panel or a monobehaviour
loader.LoadSync<GameObject>("resources://smobj");

loader.LoadSync<Texture2D>("resources://Bg");

// load by asset bundle's assetName
loader.LoadSync<Texture2D>("HomeBg");

// load by asset bundle name and assetName
loader.LoadSync<Texture2D>("home","HomeBg");


// resycle this panel/monobehaivour's loaded res when destroyed 
loader.Recycle2Cache();
loader = null;
```

**3.UI Kit**

``` csharp
// open a panel from assetBundle
UIKit.OpenPanel<UIMainPanel>();

// load a panel from specified Resources
UIKit.OpenPanel<UIMainPanel>(prefabName:"Resources/UIMainPanel");

// load a panel from specield assetName
UIKit.OpenPanel<UIMainPanel>(prefabName:"UIMainPanel1");
```

### 技术支持 Tech Support：
* [文档 Document:http://qf.liangxiegame.com/qf/community](http://qf.liangxiegame.com/qf/community)
* **如在使用中遇到问题请提交 [这里 issue](https://github.com/liangxiegame/QFramework/issues/new)，我们团队会在一天内快速回复并着手解决。**
* **[QQ 群:623597263](http://shang.qq.com/wpa/qunwpa?idkey=706b8eef0fff3fe4be9ce27c8702ad7d8cc1bceabe3b7c0430ec9559b3a9ce66) **：在 QQ 群内提问，会马上得到回复。
* **社区:https://qframework.cn**
* [awesome_qframework](https://github.com/liangxiegame/awesome-qframework)  

#### 下载地址 Download:
* 最新版本:https://github.com/liangxiegame/QFramework/releases
* [Asset Store](http://u3d.as/SJ9)

### 赞助 Donate:
* 如果觉得不错可以在 [这里 Asset Store](http://u3d.as/SJ9) 给个 5 星哦~ give 5 star
* 或者给此仓库一个小小的 Star~ star this repository
* 以上这些都会转化成我们的动力,提供更好的技术服务! 

### 运行环境
* Unity 5.6.x ~ 2021.x

### 可选的包含项目 Include Projects:
* [UniRx](https://github.com/neuecc/UniRx)
* [Json.net](https://github.com/JamesNK/Newtonsoft.Json)

#### 参考 Reference:
* [MultyFramework](https://github.com/OnClick9927/MultyFramework)
* [IFramework_GUICanvas](https://github.com/OnClick9927/IFramework_GUICanvas)
* [IFramework](https://github.com/OnClick9927/IFramework)
* [Loxodon Framework](https://github.com/cocowolf/loxodon-framework)
* [BDFramework](https://github.com/yimengfan/BDFramework.Core)
* [HGFramework: Unity3D客户端框架](https://github.com/zhutaorun/HGFramework)
* [Qarth: Framework For Game Develop With Unity3d](https://github.com/SnowCold/Qarth)
* [GameFramework:A game framework based on Unity 5.3 and later versions](https://github.com/EllanJiang/GameFramework)
* [cocos2d/cocos2d-x](https://github.com/cocos2d/cocos2d-x)
* [ResetCore.Unity](https://github.com/vgvgvvv/ResetCore.Unity)
* [UnityUGUIImageShaderPack](https://github.com/zhangmaker/UnityUGUIImageShaderPack)
* [FishManShaderTutorial](https://github.com/JiepengTan/FishManShaderTutorial)

### 核心成员

* [h3166179](https://github.com/h3166179)
* [王二](https://github.com/so-sos-so) [so-sos-so](https://github.com/so-sos-so)

* [凉鞋 liangxieq](https://github.com/liangxieq)

### 贡献者/感谢 Developer/Contributor:
- [@karsion](https://github.com/karsion)
- [@junyu-tu](https://github.com/junyu-tu)
- [@vin129](https://github.com/vin129)
- [@kevin](https://github.com/KEVIN-ZED)
- [@827922094](https://github.com/827922094)
- [@SilenceT](https://github.com/SilenceT)




### 优秀的 Unity 库、框架
- [ET](https://github.com/egametang/ET)：ET Unity3D Client And C# Server Framework
- [IFramework（OnClick）](https://github.com/OnClick9927/IFramework) Simple Unity Tools
- [JEngine](https://github.com/JasonXuDeveloper/JEngine)  一个基于XAsset&ILRuntime，精简好用的热更框架

### 代码规范完全遵循:
[QCSharpStyleGuide](https://github.com/liangxiegame/QCSharpStyleGuide)
