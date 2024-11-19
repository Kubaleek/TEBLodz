const poleKoła = (promien) => Math.PI * (promien * promien);

const pokazWynik = (WynikPola) => {
    if(confirm("Czy dane są prawidłowe?")){
        alert(`Pole koła wynosi: ${poleKoła(WynikPola)}`);
    } else {
        alert("Wprowadź poprawne dane i przelicz ponownie?")
    }
}

const Przycisk = () => {
    let promien = parseInt(document.getElementById("input").value);
    pokazWynik(promien);
}

const Okno = () =>{
    let promien = prompt("Podaj promień koła:");
    pokazWynik(promien);
}





