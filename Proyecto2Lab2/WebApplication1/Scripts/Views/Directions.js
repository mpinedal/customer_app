
function Directions() {

    this.tblDirectionsId = 'tblDirections';
    this.service = 'direction';
    this.ctrlActions = new ControlActions();
    this.columns = "ID,OwnerId,Province,Canton,Distrito,Details,Type";
    //milton columns to ignore
    this.columnsToIgnore = "OwnerId"; 
    //


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
    HideColumns();
    HideInputs();

});

//Hides columns dynamicly from data table
HideColumns = function () {
    var dt = $('#tblDirections').DataTable();
    //hide the first column
    dt.column(0).visible(false);

  

    //***********To hide multiple columns, columns().visible() can be used:
    //var dt = $('#example').DataTable();
    ////hide the second and third columns
    //dt.columns([1, 2]).visible(false);


}

HideInputs = function () {
    //$("#txtID").hide();
    $('label[for=txtID], input#txtID').hide();
}

