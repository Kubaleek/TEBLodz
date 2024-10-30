function Average() {
  let a = parseInt(document.getElementById("NumberA").value);
  let b = parseInt(document.getElementById("NumberB").value);
  let s = (a + b) / 2;
  alert(`Średnia: ${s}`);
}

// z uzyciem consta
// const Average = () =>{ 
//   let a = parseInt(document.getElementById("NumberA").value);
//   let b = parseInt(document.getElementById("NumberB").value);
//   let s = (a + b) / 2;
//   alert(`Średnia: ${s}`);
// }

function Sum() {
  let a = parseInt(document.getElementById("NumberA").value);
  let b = parseInt(document.getElementById("NumberB").value);
  let s = a + b;
  alert(`Suma: ${s}`);
}

// z uzyciem consta
// const Sum = () =>{ 
// let a = parseInt(document.getElementById("NumberA").value);
// let b = parseInt(document.getElementById("NumberB").value);
// let s = a + b;
// alert(`Suma: ${s}`)
// }