$(document).ready(function () {
    window.onload = updateCart;
    function updateCart() {
        var sum = 0;
        $('.contain_product_cart').find('tr').each(function () {
            var cost = $(this).find('.cost_pro').text();
            var sl = $(this).find('.soluong').val();
            var tolcost = $(this).find('.toal_Cost');
            tolcost.text((parseInt(cost) * parseInt(sl)).toString());
            sum = sum + (parseInt(tolcost.text()));
        });
        $('.cart_tol').text(sum.toString());
    }

    $('#Update_cart_btn').click(function (e) {
        e.preventDefault();
        //var VIEW_detailCarts = [{
        //    maDD: "",
        //    tenDD: "",
        //    pic: "",
        //    cost: "",
        //    sl: ""
        //}];
        var VIEW_detailCarts = [];
  
        $('.contain_product_cart').find('tr').each(function () {
            VIEW_detailCarts.push({
                cartID: $('.IDcart').text(),
                maDD: $(this).find('.ID_Tour').text(),
                tenDD: $(this).find('.tenDD').text(),
                //pic: $(this).find('.img_s').attr('src'),
                cost: $(this).find('.cost_pro').text(),
                sl: $(this).find('.soluong').val()
            });
        });
        VIEW_detailCarts = JSON.stringify({ 'VIEW_detailCarts': VIEW_detailCarts });
        $.ajax({
            url: '/Cart/UpdateCart',
            contentType: 'application/json;charset=utf-8',
            data: VIEW_detailCarts,
            type: 'post',
            dataType: 'Json',
            success: function () {
                alert("Update Cart Success!")
            }
        });
    });

    $('.acc_payment_btn').click(function (e) {
        e.preventDefault();
        var Data = [];
        $('.contain_product_cart').find('tr').each(function () {
            Data.push({
                cartID: $('.IDcart').text(),
                maDD: $(this).find('.ID_Tour').text(),
            });
        });

        Data = JSON.stringify({ 'Data': Data });
        $.ajax({
            url: '/Cart/AcceptPayment',
            contentType: 'application/json;charset=utf-8',
            data: Data,
            type: 'post',
            dataType: 'Json',
            success: function () {
                alert("Playment Success!");
            }
        });
        window.location.href = "/Home/Cart";
    });
 
    $('.payment_btn').click(function (e) {
        e.preventDefault();
        var detailCarts = [];
        $('.contain_product_cart').find('tr').each(function () {
            detailCarts.push({
                cartID: $('.IDcart').text(),
                maDD: $(this).find('.ID_Tour').text(),
                tenDD: $(this).find('.tenDD').text(),
                pic: $(this).find('.img_s').attr('src'),
                cost: $(this).find('.cost_pro').text(),
                sl: $(this).find('.soluong').val()
            });
        });
        detailCarts = JSON.stringify({ 'detailCarts': detailCarts });
        var myModal = $('#myModal_payment');
        $.ajax({
            url: '/Cart/PaymentShow',
            contentType: 'application/html;charset=utf-8',
            type: 'Post',
            dataType: 'html',
            success: function (re) {
                myModal.empty().append(re);
                myModal.modal();
            }
        });
        $('#appendTabel').empty();
        var txt = "";
        $.ajax({
            url: '/Cart/Payment',
            contentType: 'application/Json;charset=utf-8',
            data: detailCarts,
            type: 'Post',
            dataType: 'Json',
            success: function (data) {
                var len = data.length;
                for (var i = 0; i < len; i++) {
                    txt +=
                        '<td hidden class="ID_Tour">' + data.maDD + '</td>' +
                        '<tr><td class="cart-pic first-row">' + '<img class="img_s" src="' + data[i].pic + '"/>' + "</td>" +
                        '<td class="cart-title first-row">' + data[i].tenDD + "</td>"+
                        '<td class="p-price first-row cost_pro">' + data[i].Cost + "</td>" +
                        '<td class="qua-col first-row soluong">' + data[i].sl + "</td>" +
                        '<td class="total-price first-row toal_Cost">' + parseInt(data[i].sl) * parseInt(data[i].Cost) + "</td></tr>";
                }
                if (txt != "") {
                    $('#appendTabel').append(txt);
                }
                updateCart();
            }
        });
        //data = detailCarts;
        
    });
});