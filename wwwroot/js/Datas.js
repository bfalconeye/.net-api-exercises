function Datas(x, y) {
    var options = {
        chart: {
            type: 'donut'
        },
        series: x,
        labels: y
    }

    var chart = new ApexCharts(document.querySelector("#chart"), options);

    chart.render();
}


