function Pole(promien){
    return Math.PI * (promien * promien);
}

function obliczPole(){
    var liczba = document.getElementById("input").value;
    var wynik = Pole(liczba);
    alert(wynik);
}