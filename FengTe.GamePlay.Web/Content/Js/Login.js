$(function () {
    //登录模块
    var hover = false;
    $('.password,.name,.login_code_input').keyup(function () {
        if ($('.name').val() && $('.password').val() && $('.login_code_input').val()) {
            $('.login_btn').css({ 'backgroundColor': '#ffc907', 'color': '#fff' });
            $('.login_btn').css('pointerEvents', 'auto');
            hover = true;
        } else {
            $('.login_btn').css({ 'backgroundColor': '#f0f0f0', 'color': '#999' });
            hover = false;
        }
    })
    $('.login_btn').mouseover(function () {
        if (hover) {
            $('.login_btn').css('pointerEvents', 'auto');
        } else {
            $('.login_btn').css('pointerEvents', 'none');
        }
    })
    $('.login_way_btn_txt').click(function () {
        $('.login_txt').removeClass('display');
        $('.login_code').addClass('display');
    })
    $('.login_way_btn_code').click(function () {
        $('.login_txt').addClass('display');
        $('.login_code').removeClass('display');
    })
    $('.pwd_login').click(function (event) {
        event.preventDefault();
        $('.login_way_btn_txt').trigger('click');
    })    
})
