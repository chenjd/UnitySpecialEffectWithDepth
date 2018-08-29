# UnitySpecialEffectWithDepth
----
#### 描述：
利用深度信息实现扫描效果、x光效果以及护盾能量场效果。
#### 版本：
Unity5.6+ （从5.5开始unity已经开始使用 reversed-z）

---
#### 内容：
##### 获取深度信息
Assets\RenderDepthMap

![QQ截图20170619232147.png](http://upload-images.jianshu.io/upload_images/1372105-b363fd1dda57bd65.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/800)

##### 扫描网效果（ScannerEffect）
Assets\ScannerEffect

![12.gif](http://upload-images.jianshu.io/upload_images/1372105-87b78f0878452e6c.gif?imageMogr2/auto-orient/strip)


按C键触发/Press 'C'

##### 穿墙透视效果（XrayEffect）
Assets\SeeThroughWall


![123.gif](http://upload-images.jianshu.io/upload_images/1372105-b25acf121d88a1da.gif?imageMogr2/auto-orient/strip)


##### 能量场效果（ForceFieldEffect）
Assets\ForceField
![seethewall4erddw33.gif](http://upload-images.jianshu.io/upload_images/1372105-8a382a96b79895c6.gif?imageMogr2/auto-orient/strip)

##### ref：

【1】Siggraph2011_SpecialEffectsWithDepth_WithNotes。“Special Effects with Depth” talk at SIGGRAPH – Unity Blog

【2】Unity Shaders - Depth and Normal Textures (Part 2)

【3】Using Depth Textures Unity手册

【4】Unity - Get Unity - Download Archive Unity内置shader 

【5】Makin' Stuff Look Good
