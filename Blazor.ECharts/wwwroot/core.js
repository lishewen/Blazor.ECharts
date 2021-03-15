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
    static setupChart(id, option) {
        console.log('参数：');
        console.log(option);
        let opt = eval('(' + option + ')');
        console.log(opt);
        let chart = this.getChart(id);
        if (chart === null) {
            chart = this.initChart(id);
        }
        chart.hideLoading();
        chart.setOption(opt);
    }
}