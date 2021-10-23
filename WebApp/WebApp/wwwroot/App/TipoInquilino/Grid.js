"use strict";
var TipoInquilinoGrid;
(function (TipoInquilinoGrid) {
    if (MensajeApp != "") {
        Toast.fire({
            icon: "success", title: MensajeApp
        });
    }
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar el registro?", "Eliminar", "warning", "#3085d6", "d33")
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "TipoInquilino/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    TipoInquilinoGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(TipoInquilinoGrid || (TipoInquilinoGrid = {}));
//# sourceMappingURL=Grid.js.map