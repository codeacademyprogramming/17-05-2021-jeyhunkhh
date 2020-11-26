$("#cities").submit(function(e){
    e.preventDefault()

    let city = $("#city").val()

    $("#weather").empty()

    $.get(`http://api.openweathermap.org/data/2.5/weather?q=${city},az&units=metric&APPID=ce23662a1bf367a5e11eda8683341351`, function(data, status){

        let li = ` <li class="list-group-item">Havanin Temperaturu - ${data.main.temp}°C</li>
        <li class="list-group-item">Nisbi rütubətlik - ${data.main.humidity}%</li>
        <li class="list-group-item">Küləyin istiqaməti - ${data.wind.deg}°</li>
        <li class="list-group-item">Küləyin sürəti - ${data.wind.speed}m/s</li>
        <li class="list-group-item">Atmosfer təziqi - ${data.main.pressure}hPa</li>`

        $("#weather").append(li)
    })
})