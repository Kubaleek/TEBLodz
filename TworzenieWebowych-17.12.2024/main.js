
const kursy = [3.14, 5.99, 6.88, 3.15];

const Zwieksz = () => {
    const tabWynik = [];
    let liczbaZwiekszenia = parseFloat(document.getElementById('input').value);
    
    for (let i = 0; i < kursy.length; i++) {
      kursy[i] += liczbaZwiekszenia + 10;
      tabWynik.push(kursy[i]);
    }
    
    console.log(tabWynik.join(", ", tabWynik));
};
