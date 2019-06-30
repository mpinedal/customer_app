
function ContactMethod() {

    this.tblContactMethodId = 'tblContactMethod';
    this.service = 'contactMethod';
    this.ctrlActions = new ControlActions();
    this.columns = "OwnerId,Type,Value,Description,INDPublicidad";

    this.RetrieveAll = function () {
        this.ctrlActions.FillTable(this.service, this.tblContactMethodId, false);
    }

    this.ReloadTable = function () {
        this.ctrlActions.FillTable(this.service, this.tblContactMethodId, true);
    }

    this.Create = function () {
        var contactMethodData = {};
        contactMethodData = this.ctrlActions.GetDataForm('frmEdition');
        //Hace el post al create
        this.ctrlActions.PostToAPI(this.service, contactMethodData);
        //Refresca la tabla
        this.ReloadTable();
    }

    this.Update = function () {

        var contactMethodData = {};
        contactMethodData = this.ctrlActions.GetDataForm('frmEdition');
        //Hace el post al create
        this.ctrlActions.PutToAPI(this.service, contactMethodData);
        //Refresca la tabla
        this.ReloadTable();

    }

    this.Delete = function () {

        var contactMethodData = {};
        contactMethodData = this.ctrlActions.GetDataForm('frmEdition');
        //Hace el post al create
        this.ctrlActions.DeleteToAPI(this.service, contactMethodData);
        //Refresca la tabla
        this.ReloadTable();

    }

    this.BindFields = function (data) {
        this.ctrlActions.BindFields('frmEdition', data);
    }
}

//ON DOCUMENT READY
$(document).ready(function () {

    var contactMethod = new ContactMethod();
    contactMethod.RetrieveAll();
    HideColumns();
    HideInputs();

});

//Hides columns dynamicly from data table
HideColumns = function () {
    var dt = $('#tblContactMethod').DataTable();
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

