function Modal(index,nombre){
$.ajax(
    {
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/ObtenerTemporadas',
        data: {id: index},
        success:
        function(response){
            $("#nombreSerie").html(response.TituloTemporada)
        }
    }
)
}