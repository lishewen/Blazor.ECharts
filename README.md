# Blazor.Charts

## 介绍

**Blazor版本的ECharts图表组件**

[![GitHub license](https://img.shields.io/github/license/caopengfei/BlazorECharts.svg)](https://github.com/caopengfei/BlazorECharts/blob/master/LICENSE)

开源地址：[https://github.com/caopengfei/BlazorECharts](https://github.com/caopengfei/BlazorECharts)

示例地址：[http://101.132.107.140:8123/line/line1](http://101.132.107.140:8123/line/line1)

ECharts配置请参考：

[https://echarts.apache.org/examples/zh/index.html](https://echarts.apache.org/examples/zh/index.html)

## 使用方式
1. 创建Blazor项目。
2. 在NuGet中安装包`Rakor.Blazor.ECharts` [![NuGet](https://img.shields.io/nuget/v/Rakor.Blazor.ECharts.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Rakor.Blazor.ECharts/) ![downloads](https://img.shields.io/nuget/dt/Rakor.Blazor.ECharts.svg)。
3. 在 _Imports.razor 中添加`@using Rakor.Blazor.ECharts.Component`。
4. 在 Pages/_Host.cshtml文件的Body中引入下面两段代码：
```html
<script src="/_content/Rakor.Blazor.ECharts/js/echarts-4.5.min.js"></script>
<script src="/_content/Rakor.Blazor.ECharts/js/core.js"></script>
```
5. 在页面中使用组件（可参考Demo项目）。

**注意：因为没有设置默认的样式，所以需要在组件上设置`Class`或者`Style`来控制宽度和高度**

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
  - [ ] timeline
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
  - [ ] 散点图
  - [x] 地理坐标/地图（部分）
  - [x] K线图（部分）
  - [ ] 雷达图
  - [ ] 盒须图
  - [ ] 热力图
  - [ ] 关系图
  - [ ] 路径图
  - [ ] 树图
  - [ ] 矩形树图
  - [ ] 旭日图
  - [ ] 平行坐标系
  - [ ] 桑基图
  - [ ] 漏斗图
  - [ ] 仪表盘
  - [ ] 象形柱图
  - [ ] 主题河流图
  - [ ] 日历坐标系
