const sprawdz = () => {
    let liczbaA = parseInt(document.getElementById('a').value);
    let liczbaB = parseInt(document.getElementById('b').value);

    if(liczbaA > liczbaB){
        let c = (liczbaA - liczbaB);
        alert(`Liczba A: ${liczbaA} jest wieksza od liczby B: ${liczbaB} o ${c}`)
    } else if(liczbaA < liczbaB){
        let c = (liczbaB - liczbaA);
        alert(`Liczba B: ${liczbaB} jest wieksza od liczby A: ${liczbaA} o ${c}`)
    } else {
        alert(`${liczbaA} jest równa ${liczbaB}`)
    }
}
