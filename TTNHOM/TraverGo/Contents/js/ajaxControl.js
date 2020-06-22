$(document).ready(function () {
    //// paging product
    $(".numb_page").click(function (e) {
        e.preventDefault();
        var thisPage = $(this);
        var page = $(this).text();
        var dataModel = $('#contain_9product');
        $(".pading_contain").find('li').each(function () {
            $(this).removeClass('active');
        });
        $.ajax({
            url: '/Destiantion/Get9product',
            contentType: 'application/html ; charset:utf-8',
            data: { page:page },
            type: 'Get',
            dataType: 'html',
            success: function (result) {
                dataModel.empty().append(result);
                thisPage.addClass('active');
            }
        });
    });

    $(".pre_page").click(function (e) {
        e.preventDefault();
        var thisPage = $(".pading_contain").find('li.active');
        var page = thisPage.text();
        if (page != "1") {
            page = (parseInt(page) - 1).toString();
            var dataModel = $('#contain_9product');
            $(".pading_contain").find('li').each(function () {
                $(this).removeClass('active');
            });
            var activePage = $('#' + page)
            $.ajax({
                url: '/Destiantion/Get9product',
                contentType: 'application/html ; charset:utf-8',
                data: { page: page },
                type: 'Get',
                dataType: 'html',
                success: function (result) {
                    dataModel.empty().append(result);
                    activePage.addClass('active');
                }
            });
        }
    });

    $(".next_page").click(function (e) {
        e.preventDefault();
        var thisPage = $(".pading_contain").find('li.active');
        var page = thisPage.text();
        var sumpage = $('.sun_page').text();
        if (page != sumpage) {
            page = (parseInt(page) + 1).toString();
            var dataModel = $('#contain_9product');
            $(".pading_contain").find('li').each(function () {
                $(this).removeClass('active');
            });
            var activePage = $('#' + page)
            $.ajax({
                url: '/Destiantion/Get9product',
                contentType: 'application/html ; charset:utf-8',
                data: { page: page },
                type: 'Get',
                dataType: 'html',
                success: function (result) {
                    dataModel.empty().append(result);
                    activePage.addClass('active');
                }
            });
        }
    });
    //// cart 
    $('.add_toCart').click(function (e) {
        e.preventDefault();
        var id_cart = $('.ID_Cart').text();
        // nếu chưa đăng nhập thì yêu cầu đăng nhập
        if (id_cart == null || id_cart == "") {
            window.location.href = "/Account/Login";
        }
        else {
            var id_dd = $(this).closest('.project-wrap').find('.ID_Tour').text();
            $.ajax({
                url: '/Cart/AddItemToCast',
                contentType: 'application/html ; charset:utf-8',
                data: { idDT: id_dd, idCart: id_cart },
                type: 'Get',
                dataType: 'html',
                success: function () {
                    alert("add thanh cong");
                }
            });
        }
    });

    $('.x_deleteOnCart').click(function (e) {
        e.preventDefault();
        var id_cart = $('.IDcart').text();
        // nếu chưa đăng nhập thì yêu cầu đăng nhập
        if (id_cart == null || id_cart == "") {
            window.location.href = "/Account/Login";
        }
        else {
            var dataModel = $('.contain_product_cart');
            var id_dd = $(this).closest('tr').find('.ID_Tour').text();
            $.ajax({
                url: '/Cart/RemoveOneProduct',
                contentType: 'application/html ; charset:utf-8',
                data: { idDT: id_dd, idCart: id_cart },
                type: 'Get',
                dataType: 'html',
                success: function (re) {
                    dataModel.empty().append(re);
                }
            });
        }
    });

    $('.x_deleteAllCart').click(function (e) {
        e.preventDefault();
        var id_cart = $('.IDcart').text();
        // nếu chưa đăng nhập thì yêu cầu đăng nhập
        if (id_cart == null || id_cart == "") {
            window.location.href = "/Account/Login";
        }
        else {
            var dataModel =$('.contain_product_cart');
            $.ajax({
                url: '/Cart/RemoveAllProduct',
                contentType: 'application/html ; charset:utf-8',
                data: {idCart: id_cart },
                type: 'Get',
                dataType: 'html',
                success: function (re) {
                    dataModel.empty().append(re);
                }
            });
        }
    });
    //detail product
    $('.product_contain').click(function (e) {
        e.preventDefault();
        var id = $(this).find('.ID_Tour').text();
        var dataModal = $('#myModal');
        $.ajax({
            url: '/Destiantion/DetailProduct',
            contentType: 'application/html ; charset:utf-8',
            data: { id:id  },
            type: 'GET',
            dataType: 'html',
            success: function (result) { dataModal.empty().append(result); dataModal.modal(); }
        });
    });
    // search product
    $(".search_destination").click(function (e) {
        e.preventDefault();
        var key1 = $('.key1').val();
        var key2 = $('.key2').val();
        var key3 = $('.key3').val();
        var dataModel = $('.result_Find');
        $.ajax({
            url: '/Destiantion/SearchProduct',
            contentType: 'application/html ; charset:utf-8',
            data: { key1: key1,key2: key2,key3: key3 },
            type: 'Get',
            dataType: 'html',
            success: function (result) {
                dataModel.empty().append(result);
            }
        });
    });
});