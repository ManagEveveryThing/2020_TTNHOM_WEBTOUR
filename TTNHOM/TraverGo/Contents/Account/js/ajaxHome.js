
$(document).ready(function () {

    $("#btn_login_ajax").click(function (e) {
        e.preventDefault();
        //var thisForm = this;
        var data = {
            "user": $("#username_login").val(),
            "pass": $("#pass_login").val()
        };
        var inputLogin = $(".fied_user");
        var inputPass = $(".fied_pass");
        $.ajax({
            url: '/Account/CheckAccount',
            contentType: 'application/json;charset=utf-8',
            data: JSON.stringify(data),
            type: 'Post',
            dataType: 'Json',
            success: function (result) {
                if (result.mes == 1) {
                    window.location.href = "/Home/Index/"+data.user;
                }
                else {
                    if (result.mes == 2) {
                        inputPass.empty().append(' <label> Incorect Pass </label>');
                    }
                    else {
                        if (result.mes == 4) {
                            //window.location.href = "/Admin/HomeAdmin/Table";
                            window.location.href = "/Admin/HomeAdmin/Index?username=" + data.user;
                        }
                        else {
                            inputLogin.empty().append('<label> Not exties username </label>');
                        }
                        
                    }
                }   
            }
        });
    });

    $("#btn_re_ajax").click(function (e) {
        e.preventDefault();
        //var thisForm = this;
        var customer = {
            "username": $("#username").val(),
            "pass": $("#pass").val(),
            "tenKH": $("#name_re").val(),
            "hoKH": $("#sureName_re").val(),
            "email": $("#email_re").val(),
            "phoneNum": $("#phone_re").val(),
            "job": $("#job_re").val()
        };
        var com_pass = $("#con-pass").val();

        if (customer.username != "" && customer.pass != "" && com_pass == customer.pass
            && customer.email != "" && customer.tenKH != "" && customer.phoneNum != "") {
            $.ajax({
                url: '/Account/RegisAccount',
                contentType: 'application/json;charset=utf-8',
                data: JSON.stringify(customer),
                type: 'Post',
                dataType: 'Json',
                success: function (result) {
                    if (result.Success) {
                        window.location.href = "/Account/Login";
                    }
                    else {
                        window.location.href = "/Account/Register";
                    }
                }
            });
        }
        else {
            $('.fied_btn').empty().append(' <lable style="color: red" > Need complete (*) </lable> ')
        }
    });

    $("#con-pass").on('input',function (e) {
        e.preventDefault();
        var pas = $("#pass").val();
        var com_pas = $(this).val();
        var dataModel = $(".fied_repass_re");
        if (pas == com_pas) {
            dataModel.empty().append(' <lable style="color: green" > Vadlid </lable> ')
        }
        else {
            dataModel.empty().append(' <lable style="color: red" > Invadlid </lable> ')
        }
    });

});