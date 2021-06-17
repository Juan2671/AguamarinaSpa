$(function () {
    var Ingrediente = $('#Ingrediente').html();
  var divContent = $('#formulario');
  var botaoAdicionar = $('a[data-id="1"]');
  var i = 2;

    console.log(Ingrediente);



  $(botaoAdicionar).click(function () {
    var linha = $('\
            <div class="conteudoIndividual">\
                <div class="form-group col-6">\
                 <label>Ingrediente </label>\
                    <select name=""asp-for="Producto.Nombre" class="input  w-full border mt-2" >\
                       <option value="" disabled selected>Seleccione un Ingredinete</option>\
                        @foreach (Categoria item in Model.Categorias)\
                        {\
                        <option value = "@item.CategoriaId" >@item.NombreCategoria</option >\
                        }\
                    </select>\
                </div>\
                <div class= "form-group col-md-6" >\
                <label>Cantidad #' + i + '</label>\
                <input type="text" placeholder="Ingrese cantidad Ejemplo : 2 Kg,4L,5Ml" class="input w-full border mt-2" maxlength="15"  name="' + i + '" required/>\
              </div>\
               <br> <a class="button w-24 mr-1 mb-2 bg-theme-6 text-white " id="linkRemover">Eliminar</a> <br><br>\
             </div>').appendTo(divContent);
    $('#removehidden').remove();
    i++;
    $('<input type="hidden" name="quantidadeCampos" value="' + i + '" id="removehidden">').appendTo(divContent);
    linha.find("a").on("click", function () {
      $(this).parent(".conteudoIndividual").remove();
    });
  });
});