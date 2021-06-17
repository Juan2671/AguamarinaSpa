$(function () {
    var Ingrediente = $('#Ingrediente').html();
    var divContent = $('#formulario');
    var botaoAdicionar = $('a[data-id="1"]');
    var i = 2;

    $(botaoAdicionar).click(function () {

        divContent.append(`<div class="row" id="Ingrediente${i}">
${Ingrediente} 
<input type="button" onclick="eliminar(${i})" class="button border text-gray-700 btn-block btn-danger" value="eliminar">

</div>
`);
        i++;
  });
});

function eliminar(id) {

    $("#Ingrediente" + id).remove();
}