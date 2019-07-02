
function Email() {

    this.service = 'email';
    this.ctrlActions = new ControlActions();


    this.Send = function () {
        var emailData = {};
        emailData = {

            EmailAddress : $("#exampleInputEmail1").val(),
            Owner: $("#name").val(),
            Content : $("#emailContent").val()

        }
        //Hace el post al create
        this.ctrlActions.PostToAPI(this.service, emailData);


        //$("#buttonSend").click(function () {
        //    console.log("HEllo!")

        //    this.email.Create();
        //});

       
    }



}

$(document).ready(function () {

    var email = new Email();

});





