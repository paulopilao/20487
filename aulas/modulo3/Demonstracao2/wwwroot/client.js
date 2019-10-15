const uri = 'api/pessoa';

function getData(){
    //fetch api default method is GET  
    fetch(uri)
    .then(response => response.json())
    .then(function(data){
        data.forEach(value => {
            document.getElementById('pessoas').innerHTML += '<li id="' + value.id + '">' + value.id + ': ' + value.nome + ' - ' + value.cpf + '</li>';
        });
    })
}