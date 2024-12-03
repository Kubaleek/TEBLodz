

function wylosuj(){
    let a = parseInt(document.getElementById("input").value);
    let min = parseInt(document.getElementById('input2').value);
    let max = parseInt(document.getElementById('input3').value);

    for(let i=0; i < a; i++){
        alert(Math.floor(Math.random() * (min - max) + max));
    }
}