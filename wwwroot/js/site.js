function ModalTemporadas(indexCont){
    
   const index = indexCont.innerHTML

    document.getElementById("cartita").innerHTML = ""
$.ajax(
    {
        type: 'GET',
        dataType: 'JSON',
        url: '/Home/ObtenerTemporadas',
        data: {id: index},
        success:
        function(response){
            for(let i = 0; i<response.length; i++){
                document.getElementById("cartita").innerHTML +=  response[i].tituloTemporada +"\n"
            }
            
        }
    }
    
)
}

function ModalActores(indexCont){
 
    const index = indexCont.innerHTML
   
    document.getElementById("cartita").innerHTML = ""
$.ajax(
    {
        type: 'GET',
        dataType: 'JSON',
        url: '/Home/ObtenerActores',
        data: {id: index},
        success:
        function(response){
            for(let i = 0; i<response.length; i++){
                document.getElementById("cartita").innerHTML += response[i].nombre +"\n" 
            }
            
        }
    }
    
)
}

function ModalSeries(index, indexCont, option){
    if(option == 0){
        indexCont.innerHTML = index
    }
    else{
         index = indexCont.innerHTML
    }
    
 
     document.getElementById("cartita").innerHTML = ""
 $.ajax(
     {
         type: 'GET',
         dataType: 'JSON',
         url: '/Home/ObtenerSeries',
         data: {id: index},
         success:
         function(response){
            $("#nombreSerie").html(response.nombre)
            
            document.getElementById("cartita").innerHTML = "Año de inicio: ".bold() + "\n" + response.añoInicio +  "\n" + "Sinopsis: ".bold() + "\n" + response.sinopsis
             
         }
     }
     
 )
 }