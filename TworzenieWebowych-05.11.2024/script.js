function Pole(promien){
    return Math.PI * (promien * promien);
}

function obliczPole(){
    let liczba = document.getElementById("input").value;
    let wynik = Pole(liczba);
    alert(wynik);
}