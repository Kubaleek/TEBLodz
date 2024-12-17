const DodajKomunikat = () => {
    let imie = document.getElementById('imie').value;
    let nazwisko = document.getElementById('nazwisko').value;
    let email = document.getElementById('email').value;
    let zgloszenia = document.getElementById('zgloszenia').value;
    let wynik = document.getElementById('wynik');

    wynik.innerHTML = `${imie} ${nazwisko}</br> ${email} </br> Usługa: ${zgloszenia} </br>`;
}