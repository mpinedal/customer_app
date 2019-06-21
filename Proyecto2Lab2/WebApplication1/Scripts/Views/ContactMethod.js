
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

});

