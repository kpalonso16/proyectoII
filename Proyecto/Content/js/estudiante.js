 
$(document).ready(function () {
             reloadEstudiantes();
    });


function reloadEstudiantes() {

    $.ajax({
        url: 'Principal.aspx/fillTable',
        type: "POST",
        contentType: false,
        processData: false,
        async: false,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (datos) {

            if (datos) {
                var resultAsJson = datos.d // your return result is JS array
                 //botones = botones + "<button type = 'button' class= 'btn btn-primary  px-3' id = '" + producto.ID + "' data - toggle='modal' data - target='#editarProyectos' onClick = 'editarPRODUCTO(this.id)'><i class='fab fa fa-pencil-square-o' aria-hidden='true'></i></button>";
                    //botones = botones + "<button type='button' class='btn btn-danger px-3' id='" + producto.ID + "' onClick='deleteProducto(this.id)' ><i class='fas fa fa-trash-o' aria-hidden='true'></i></button>";

                for (var i in resultAsJson) {
                    var user = resultAsJson[i]
                    $("#estudianteTabla tbody").append("<tr role='row' class='odd'><td>" + user.id + "</td><td>" + user.nombre + "</td><td>"
                        + user.apellidos + "</td><td>" + user.edad + "</td><td>" + user.direccion + "</td> ");
                }
                
 

            }

        },
        error: function (xhr, ajaxOptions, thrownError) { }

    });
}