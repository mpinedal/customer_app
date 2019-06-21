
function Directions() {

    this.tblDirectionsId = 'tblDirections';
    this.service = 'direction';
    this.ctrlActions = new ControlActions();
    this.columns = "OwnerId,Province,Canton,Distrito,Details,Type";

    this.RetrieveAll = function () {
        this.ctrlActions.FillTable(this.service, this.tblDirectionsId, false);
    }

    this.ReloadTable = function () {
        this.ctrlActions.FillTable(this.service, this.tblDirectionsId, true);
    }

    this.Create = function () {
        var directionData = {};
        directionData = this.ctrlActions.GetDataForm('frmEdition');
        //Hace el post al create
        this.ctrlActions.PostToAPI(this.service, directionData);
        //Refresca la tabla
        this.ReloadTable();
    }

    this.Update = function () {

        var directionData = {};
        directionData = this.ctrlActions.GetDataForm('frmEdition');
        //Hace el post al create
        this.ctrlActions.PutToAPI(this.service, directionData);
        //Refresca la tabla
        this.ReloadTable();

    }

    this.Delete = function () {

        var directionData = {};
        directionData = this.ctrlActions.GetDataForm('frmEdition');
        //Hace el post al create
        this.ctrlActions.DeleteToAPI(this.service, directionData);
        //Refresca la tabla
        this.ReloadTable();

    }

    this.BindFields = function (data) {
        this.ctrlActions.BindFields('frmEdition', data);
    }
}

//ON DOCUMENT READY
$(document).ready(function () {

    var directions = new Directions();
    directions.RetrieveAll();

});

