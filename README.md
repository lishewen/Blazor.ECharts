# Quick.Blazor.ECharts

## 介绍

**Blazor版本的ECharts图表组件**

### 重新出发

**本项目源自[https://github.com/lishewen/Blazor.ECharts](https://github.com/lishewen/Blazor.ECharts)，由于原作者有好长一段时间没有更新和处理PR，故在此基础上，重新做了这个**

[![GitHub license](https://img.shields.io/github/license/aaasoft/Quick.Blazor.ECharts.svg)](https://github.com/aaasoft/Quick.Blazor.ECharts/blob/master/LICENSE)

开源地址：[https://github.com/aaasoft/Quick.Blazor.ECharts](https://github.com/aaasoft/Quick.Blazor.ECharts)

ECharts配置请参考：

[https://echarts.apache.org/examples/zh/index.html](https://echarts.apache.org/examples/zh/index.html)

## 使用方式
1. 创建Blazor项目。
2. 在NuGet中安装包`Quick.Blazor.ECharts` [![NuGet](https://img.shields.io/nuget/v/Quick.Blazor.ECharts.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Quick.Blazor.ECharts/) ![downloads](https://img.shields.io/nuget/dt/Quick.Blazor.ECharts.svg)。
3. 在`_Imports.razor`中添加`@using Blazor.ECharts.Components`。
4. 在`wwwroot/index.html`文件的`Head`中引入：
```html
<script src="https://lib.baomitu.com/echarts/5.3.3/echarts.min.js"></script>
```
**需要使用地图相关功能的则需要额外添加地图js的引用**
```html
<script type="text/javascript" src="https://api.map.baidu.com/api?v=2.0&ak=[Your Key Here]"></script>
<script type="text/javascript" src="https://cdn.jsdelivr.net/npm/echarts@5/dist/extension/bmap.min.js"></script>
```
5. 在`wwwroot/index.html`文件的`Body`中引入：
```html
<script type="module" src="_content/Quick.Blazor.ECharts/core.js"></script>
```
6. 修改`Program.cs`增加
```csharp
builder.Services.AddECharts();
```
7. 在页面中使用组件（可参考Demo项目）。

**注意：因为没有设置默认的样式，所以需要在组件上设置`Class`或者`Style`来控制宽度和高度**

**Demo中也提供示范样式**
```css
.chart-container {
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    justify-content: flex-start;
    padding-left: 20px;
    padding-bottom: 20px;
    padding-right: 0px;
    padding-top: 0px;
    height: 95%;
    width: 95%;
}

.chart-normal {
    border-radius: 4px;
    height: 300px;
    width: 400px;
    margin-top: 20px;
}

.chart-fill {
    width: 100%;
    height: 720px;
    margin-top: 20px;
    margin-right: 20px;
}
```

## JS function的输出问题
由于function不是json的标准数据类型，所以json数据中若含function，则转换后，function会丢失。此库为解决这个问题通过`JFuncConverter`来实现转译输出。使用时传入一个`JFunc`对象即可。例如：
```csharp
Position = new JFunc()
{
    RAW = """
    function (pt) {
        return [pt[0], '10%'];
    }
    """
}
```
