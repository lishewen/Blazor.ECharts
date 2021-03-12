// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function showPrompt(message) {
    return prompt(message, 'Type anything here');
}
export class echartsFunctions {
    static initChart(id) {
        var chart = echarts.init(document.getElementById(id));
        return chart;
    }
}