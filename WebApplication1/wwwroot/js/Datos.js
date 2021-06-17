function Estado(id) {

    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas editar el estado? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {
        if (confirmar) {

            let form = new FormData();

            form.append("id", id);

            $.ajax({
                url: "CambiarEstado",
                method: "post",
                data: form,
                processData: false,
                contentType: false
            }).done(function () {
                location.reload();

            })
        } else {
            swal({
                title: "¡Aviso!",
                text: "Estado no editado",
                icon: "success"
            })
        }
    });

};

function Cancelar() {

    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas cancelar el formulario? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {
        if (confirmar) {
            location.replace('https://localhost:44337/Servi/Servicio/Index');
        } else {
            swal({
                title: "¡Aviso!",
                text: "Cancelación cancelada",
                icon: "success"
            })
        }
    });
};

function CancelarCatego() {

    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas cancelar el formulario? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {
        if (confirmar) {
            location.replace('https://localhost:44337/Catego/Categoria/Index');
        } else {
            swal({
                title: "¡Aviso!",
                text: "Cancelación cancelada",
                icon: "success"
            })
        }
    });
};

function Elimi(id) {

    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas eliminar este registro? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {

        if (confirmar) {

            let form = new FormData();

            form.append("id", id);

            $.ajax({
                url: "Eliminar",
                method: "post",
                data: form,
                processData: false,
                contentType: false
            }).done(function () {
                location.reload();
            })

        } else {
            swal({
                title: "¡Aviso!",
                text: "Registro no eliminado!",
                icon: "success"
            })
        }
    });

};


function CancelarProducto() {

    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas cancelar el formulario? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {
        if (confirmar) {
            location.replace('https://localhost:44337/Productos/Producto/Index');
        } else {
            swal({
                title: "¡Aviso!",
                text: "Cancelación cancelada",
                icon: "success"
            })
        }
    });

};

function CancelarCategoria() {

    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas cancelar el formulario? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {
        if (confirmar) {
            location.replace('https://localhost:44337/Categorias/Categoria/Index');
        } else {
            swal({
                title: "¡Aviso!",
                text: "Cancelación cancelada",
                icon: "success"
            })
        }
    });

};

function CambioEstado(id) {

    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas editar el estado? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {
        if (confirmar) {

            let form = new FormData();

            form.append("id", id);

            $.ajax({

                url: "Estado",
                method: "post",
                data: form,
                processData: false,
                contentType: false

            }).done(function () {

                location.reload();

            })

        } else {
            swal({
                title: "¡Aviso!",
                text: "Estado no editado",
                icon: "success"
            })
        }
    });

};

function CambioEstadoProducto(id) {

    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas editar el estado? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {
        if (confirmar) {

            let form = new FormData();

            form.append("id", id);

            $.ajax({

                url: "CambiarEstado",
                method: "post",
                data: form,
                processData: false,
                contentType: false

            }).done(function () {

                location.reload();

            })

        } else {
            swal({
                title: "¡Aviso!",
                text: "Estado no editado",
                icon: "success"
            })
        }
    });

};

function Eliminar(id) {

    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas eliminar este registro? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {

        if (confirmar) {

            let form = new FormData();

            form.append("id", id);

            $.ajax({
                url: "Eliminar",
                method: "post",
                data: form,
                processData: false,
                contentType: false
            }).done(function () {
                location.reload();
            })

        } else {
            swal({
                title: "¡Aviso!",
                text: "Registro no eliminado!",
                icon: "success"
            })
        }
    });

};

function EliminarProducto(id) {
    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas eliminar este registro? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {
        if (confirmar) {

            let form = new FormData();

            form.append("id", id);

            $.ajax({
                url: "Eliminar",
                method: "post",
                data: form,
                processData: false,
                contentType: false
            }).done(function () {
                location.reload();
            })

        } else {
            swal({
                title: "¡Aviso!",
                text: "Registro no eliminado!",
                icon: "success"
            })
        }
    });

};

function EliminarU(id) {

    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas eliminar este registro? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {
        if (confirmar) {

            let form = new FormData();

            form.append("id", id);

            $.ajax({
                url: "Eliminar",
                method: "post",
                data: form,
                processData: false,
                contentType: false
            }).done(function () {
                location.reload();

            })

        } else {
            swal({
                title: "¡Aviso!",
                text: "Registro no eliminado!",
                icon: "success"
            })
        }
    });

};



function EliminarCategoria(CategoriaProductosId) {

    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas eliminar este registro? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {
        if (confirmar) {

            let form = new FormData();

            form.append("CategoriaProductosId", CategoriaProductosId);

            $.ajax({
                url: "Eliminar",
                method: "post",
                data: form,
                processData: false,
                contentType: false
            }).done(function () {
                location.reload();

            })

        } else {
            swal({
                title: "¡Aviso!",
                text: "Registro no eliminado!",
                icon: "success"
            })
        }
    });

};

$(function () {
    ActualizarCarrito();
})

function ActualizarCarrito() {
    if (localStorage.getItem("ListaProductos") != null) {

        var ListaProductos = JSON.parse(localStorage.getItem("ListaProductos"));

        $("#TablaProductos").html("");
        $("#total").html("");

        var Total = 0;

        for (let p = 0; p < ListaProductos.length; p++) {


            Subtotal = ListaProductos[p].Precio * ListaProductos[p].Cantidad;
            Total += Subtotal;
            $("#TablaProductos").append(`
                                <tr>
                                    <td ><input class="IdProduc w-4" readonly value="${ListaProductos[p].IdProducto}" /></td>
                                    <td ><input class="NombreP" readonly value="${ListaProductos[p].Nombre}" /></td>
                                    <td ><input class="PrecioP" readonly value="${ListaProductos[p].Precio}"/></td>
                                    <td ><input readonly value="${Subtotal}"/></td>
                                    <td><input disabled class="cantidad" id="cantidad_${ListaProductos[p].IdProducto}" onkeyup="ActualizarCantidad(${ListaProductos[p].IdProducto})" type="number" value="${ListaProductos[p].Cantidad}"/></td>
                                    <td><button class="flex items-center text-theme-6" data-toggle="modal" data-target="#delete-confirmation-modal"
                                    onclick="EliminarCarrito(${ListaProductos[p].IdProducto})"> <i data-feather="trash-2" class="w-4 h-4 mr-1"></i> Eliminar </button></td>
                                </tr>
                                `);

        }
        $("#total").append("Total: $" + Total);
        $("#TotalCompra").val(Total);

    }
}

if (localStorage.getItem("ListaProductos") != null) {
    var ListaProductos = JSON.parse(localStorage.getItem("ListaProductos"));
} else {
    var ListaProductos = [];
}

function guardar() {

    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas guardar este pedido? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {
        if (confirmar) {
            let cantidad = $(".cantidad");
            let IdProducto = $(".IdProduc");
            let NombreProducto = $(".NombreP");
            let Precio = $(".PrecioP");
            let Total = $("#TotalCompra");

            if (NombreProducto == null) {
                swal({
                    title: " ¡Aviso! ",
                    text: "¡ No hay productos ! ",
                    icon: "error",
                    buttons: false
                })
            } else {
                
                let form = new FormData();

                IdProducto.each(function (i, e) {
                    form.append("id", e.value);
                })

                cantidad.each(function (a, o) {
                    form.append("cantidad", o.value);
                });

                NombreProducto.each(function (u, i) {
                    form.append("Nombre", i.value);
                })

                Precio.each(function (z, p) {
                    form.append("Precio", p.value);
                })

                form.append("Total", Total.val());

                $.ajax({
                    url: "Guardar",
                    data: form,
                    method: "post",
                    processData: false,
                    contentType: false
                }).done(function () {
                    localStorage.removeItem("ListaProductos");

                    location.replace('Index');
                });
            }
            } else {
                swal({
                    title: " ¡Aviso! ",
                    text: "¡ Compra no realizada ! ",
                    icon: "warning",
                    buttons: true
                })
            }
        });
}

function ActualizarCantidad(id) {
    let list = JSON.parse(localStorage.getItem("ListaProductos"));


    for (let e = 0; e < list.length; e++) {
        if (id == list[e].IdProducto) {
            list.push({
                "IdProducto": list[e].IdProducto,
                "Nombre": list[e].Nombre,
                "Precio": list[e].Precio,
                "Cantidad": $("#cantidad_" + id).val()
            });

            list.splice(e, 1);

        }
    }

    localStorage.setItem("ListaProductos", JSON.stringify(list));

    ActualizarCarrito();

    $(".cantidad").attr("disabled", false);
}

function agregar(id, Nombre, Precio) {

    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas guardar este producto? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {
        if (confirmar) {

            if (localStorage.getItem("ListaProductos") == null) {
                ListaProductos = [];
            } else {
                ListaProductos = JSON.parse(localStorage.getItem("ListaProductos"));
            }

            let ids = [];
            ids.push(-1);

            for (let j = 0; j < ListaProductos.length; j++) {
                ids.push(ListaProductos[j].IdProducto);
            }

            let vali = false;

            for (let i = 0; i < ids.length; i++) {

                if (id == ids[i]) {
                    swal({
                        title: "¡Aviso!",
                        text: "Producto existente",
                        icon: "warning"
                    });

                    vali = false;
                    break;

                } else {
                    vali = true;
                    swal({
                        title: "¡Aviso!",
                        text: "Producto Agregado",
                        icon: "success"
                    })
                }
            }
            if (vali) {
                ListaProductos.push({
                    "IdProducto": id,
                    "Nombre": Nombre,
                    "Precio": Precio,
                    "Cantidad": 1
                });

                localStorage.setItem("ListaProductos", JSON.stringify(ListaProductos));

                ActualizarCarrito();
            }
        } else {
            swal({
                title: "¡Aviso!",
                text: "Producto no guardado",
                icon: "success"
            })
        }
    });

};

function EliminarCarrito(id) {
    swal({
        title: " ¿Estás seguro? ",
        text: "¡ ¿Deseas guardar este producto? ! ",
        icon: "warning",
        buttons: true
    }).then((confirmar) => {
        if (confirmar) {

            var L = JSON.parse(localStorage.getItem("ListaProductos"))

            let Identificacion = [];
            Identificacion.push(-1);

            for (let j = 0; j < L.length; j++) {
                Identificacion.push(L[j].IdProducto);
            }

            for (let a = 0; a < Identificacion.length; a++) {

                if (id == Identificacion[a]) {

                    L.splice((a - 1), 1);

                    localStorage.setItem("ListaProductos", JSON.stringify(L));

                    ActualizarCarrito();

                    swal({
                        title: "¡Aviso!",
                        text: "Producto eliminado",
                        icon: "success"
                    })
                    break;
                }
            }
        } else {
            swal({
                title: "¡Aviso!",
                text: "Producto no eliminado",
                icon: "error"
            })
        }
    });
}