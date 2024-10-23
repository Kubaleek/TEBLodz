let wyniki;
let binarny;


function obliczpole(){
    var promien = document.getElementById("input").value;
    wyniki = Math.PI * (promien * promien);
    console.log(wyniki);
}

function obliczobwod(){
    var promien = document.getElementById("input").value;
    wyniki = 2 * Math.PI *  promien;
    console.log(wyniki);
}


function convertbinarne(){
    var numberinput = parseInt(document.getElementById("number").value);
    let bin = ''; // pomocnicza zmienna
    while(numberinput > 0){
        bin = (numberinput % 2) + bin; // ustawiamy zmienna pomocnicza reszte z numberinput
        numberinput = Math.floor(numberinput / 2);
    }
    alert(bin);
}
