# Blazor.ECharts

## 介绍

**Blazor版本的ECharts图表组件**

### 重新出发

**本项目源自[https://github.com/caopengfei/BlazorECharts](https://github.com/caopengfei/BlazorECharts)，由于原作者有好长一段时间没有更新和处理PR，故在此基础上，重新做了这个**

[![GitHub license](https://img.shields.io/github/license/lishewen/Blazor.ECharts.svg)](https://github.com/lishewen/Blazor.ECharts/blob/master/LICENSE)

开源地址：[https://github.com/lishewen/Blazor.ECharts](https://github.com/lishewen/Blazor.ECharts)

ECharts配置请参考：

[https://echarts.apache.org/examples/zh/index.html](https://echarts.apache.org/examples/zh/index.html)

## 使用方式
1. 创建Blazor项目。
2. 在NuGet中安装包`Blazor.ECharts` [![NuGet](https://img.shields.io/nuget/v/Blazor.ECharts.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Blazor.ECharts/) ![downloads](https://img.shields.io/nuget/dt/Blazor.ECharts.svg)。
3. 在`_Imports.razor`中添加`@using Blazor.ECharts.Component`。
4. 在`wwwroot/index.html`文件的`Head`中引入：
```html
<script crossorigin="anonymous" integrity="sha512-t9GZbGKCH5MuYUFsq5AdrhllT0kdnc2fNMizKDgLXBBXgHP2dXxjRPOzYJauAXW9OXLlSYELUqWD30k7cb0Mkg==" src="https://lib.baomitu.com/echarts/5.0.2/echarts.min.js"></script>
```
5. 在`wwwroot/index.html`文件的`Body`中引入：
```html
<script type="module" src="_content/Blazor.ECharts/core.js"></script>
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

## 功能实现进度
- [ ] **公共配置**
  - [x] title
  - [x] legend
  - [x] grid（部分）
  - [x] xAxis（部分）
  - [x] yAxis（部分）
  - [x] polar（部分）
  - [x] radiusAxis（部分）
  - [x] angleAxis（部分）
  - [x] radar（部分）
  - [x] dataZoom
  - [x] visualMap（部分）
  - [x] tooltip（部分）
  - [x] axisPointer（部分）
  - [x] toolbox（部分）
  - [ ] brush
  - [ ] geo
  - [ ] parallel
  - [ ] parallelAxis
  - [ ] singleAxis
  - [x] timeline
  - [ ] graphic
  - [ ] calendar
  - [ ] dataset
  - [ ] aria
  - [x] series（部分）
  - [x] color
  - [x] backgroundColor
  - [x] textStyle
  - [x] animation
  - [x] animationThreshold
  - [x] animationDuration
  - [x] animationEasing
  - [x] animationDelay
  - [x] animationDurationUpdate
  - [x] animationEasingUpdate
  - [x] animationDelayUpdate
  - [x] blendMode
  - [x] hoverLayerThreshold
  - [x] useUTC
- [ ] **图表**
  - [x] 折线图（部分）
  - [x] 柱状图（部分）
  - [x] 饼图（部分）
  - [x] 散点图（部分）
  - [x] 地理坐标/地图（部分）
  - [x] K线图（部分）
  - [x] 雷达图（部分）
  - [ ] 盒须图
  - [ ] 热力图
  - [ ] 关系图
  - [ ] 路径图
  - [ ] 树图
  - [ ] 矩形树图
  - [ ] 旭日图
  - [ ] 平行坐标系
  - [ ] 桑基图
  - [x] 漏斗图（部分）
  - [ ] 仪表盘
  - [ ] 象形柱图
  - [ ] 主题河流图
  - [ ] 日历坐标系
