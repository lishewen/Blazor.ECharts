// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function showPrompt(message) {
    return prompt(message, 'Type anything here');
}

export class echartsFunctions {
    static liChart = new Array();
    static getChart(id) {
        for (let i = 0; i < this.liChart.length; i++) {
            if (this.liChart[i].Id === id) {
                return this.liChart[i].Chart;
            }
        }
        return null;
    }
    static addChart(id, chart) {
        this.liChart.push({ Id: id, Chart: chart });
    }
    static initChart(id, theme = 'light') {
        let chart = this.getChart(id);
        if (chart === null) {
            chart = echarts.init(document.getElementById(id), theme);
            chart.showLoading();
            this.addChart(id, chart);
        }
        return chart;
    }
    static registerMap(name, svg) {
        echarts.registerMap(name, { svg: svg });
    }
    static setupChart(id, theme, option, notMerge) {
        let opt = eval('(' + option + ')');
        let chart = this.getChart(id);
        if (chart === null) {
            chart = this.initChart(id, theme);
        }
        chart.hideLoading();
        chart.setOption(opt, notMerge);
    }
    static on(id, eventType, dotnetHelper) {
        let chart = this.getChart(id);
        chart.on(eventType, params => {
            let echartsEventArgs = {};
            echartsEventArgs.eventType = eventType;

            if (params) {
                echartsEventArgs.componentType = params.componentType;
                echartsEventArgs.seriesType = params.seriesType;
                echartsEventArgs.seriesIndex = params.seriesIndex;
                echartsEventArgs.seriesName = params.seriesName;
                echartsEventArgs.name = params.name;
                echartsEventArgs.dataIndex = params.dataIndex;
                echartsEventArgs.data = params.data;
                echartsEventArgs.dataType = params.dataType;
                echartsEventArgs.value = params.value;
                echartsEventArgs.color = params.color;
                echartsEventArgs.info = params.info;
                echartsEventArgs.batch = params.batch;
            }

            dotnetHelper.invokeMethodAsync('EventCaller', JSON.stringify(echartsEventArgs));
        });
    }

    static resize(id) {
        let chart = this.getChart(id);
        chart.resize();
    }

    static invokeOnResize(objReference) {
        if (this.debounceResize[objReference._id])
            objReference.invokeMethodAsync("OnResize");
    }
    static debounceResize = new Array();

    static addResizeListener(objReference) {
        this.debounceResize[objReference._id] = () => {
            this.debounce(this.invokeOnResize(objReference), 1000, true);
        }
        window.addEventListener("resize", this.debounceResize[objReference._id]);
    }

    static removeResizeListener(objReference) {
        window.removeEventListener("resize", this.debounceResize[objReference._id]);
        this.debounceResize.splice(objReference._id, 1);
    }

    /**
     * @desc  函数防抖---“立即执行版本” 和 “非立即执行版本” 的组合版本
     * @param  func 需要执行的函数
     * @param  wait 延迟执行时间（毫秒）
     * @param  immediate---true 表立即执行，false 表非立即执行
     **/
    static debounce(func, wait, immediate) {
        let timer;

        return () => {
            let context = this;
            let args = arguments;

            if (timer) clearTimeout(timer);
            if (immediate) {
                var callNow = !timer;
                timer = setTimeout(() => {
                    timer = null;
                }, wait)
                if (callNow) func.apply(context, args)
            } else {
                timer = setTimeout(() => {
                    func.apply(context, args)
                }, wait);
            }
        }
    }
}