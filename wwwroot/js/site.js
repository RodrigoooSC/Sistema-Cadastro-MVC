// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Efeito de máquina de escrever
function typeWriter(texto){   
    const textoArray = texto.innerText.split('');   
    
    texto.innerHTML = '';

    textoArray.forEach((letra, i ) => {
        setTimeout(() => 
            texto.innerHTML += letra, 85 * i)        
    });       
}

function efeitoMaquinaEscrever(titulo, texto, callback){
    typeWriter(titulo);
    callback(typeWriter(texto));   
}

const titulo = document.querySelector('.titulo-home');
const texto = document.querySelector('.texto-home');

// document.querySelector('.titulo-home').innerHTML = '';
document.querySelector('.texto-home').innerHTML = '';

efeitoMaquinaEscrever(titulo,texto);











