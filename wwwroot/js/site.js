// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Efeito de máquina de escrever
function efeitoMaquinaEscrever(texto){       
    const textoArray = texto.innerText.split('');
            
    texto.innerHTML = '';
    
    textoArray.forEach((letra, i ) => {
        setTimeout(() => 
            texto.innerHTML += letra, 50 * i)            
    });    
}

const titulo = document.querySelector('.titulo-home');
const texto = document.querySelector('.texto-home');

//efeitoMaquinaEscrever(titulo);
efeitoMaquinaEscrever(texto);

//document.querySelector('.titulo-home').innerHTML = '';
//document.querySelector('.texto-home').innerHTML = '';



