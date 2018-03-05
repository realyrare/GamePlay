$(function () {
   
    //注册验证
    var uname = $('.register_name'), pass = $('.register_password'), pass1 = $('.register_password_check'), phone = $('.phone'), code = $('.register_code'), agree = $('.accept'), qq = $('.qq'), phoneCode = $('.register_phone_code');
    var register = {};
    //用户名
    $('.register_name').blur(function () {
        if (uname.val().trim() == "") {
            uname.parent("div").find(".input_msg").removeClass("ok").addClass("err").html("请输入用户名");
            delete register.name;
            doregister();
            return;
        }
        if (uname.val().trim().length < 2 || uname.val().trim().length > 14) {
            uname.parent("div").find(".input_msg").removeClass("ok").addClass("err").html("2-14位，字母/数字/中文/下划线");
            delete register.name;
            doregister();
            return;
        }
        $.ajax({
            type: "Post",
            url: '/UserManage/Regeister/IsUserWhere',
            data: { where: uname.val().trim() },
            success: function (data) {
                if (data == "exist") {
                    uname.parent("div").find(".input_msg").removeClass("ok").addClass("err").html("该用户名已存在");
                    delete register.name;
                    doregister();
                    return;
                }
                else {
                    uname.parent("div").find(".input_msg").html("").addClass("ok").removeClass("err");
                    register.name = 'name';
                    doregister();
                }
            }
        });
    });

    //----------------/UserManage/Regeister/SendVcode

    //密码  、-=\[];',./~!@#$%^&*()_+|?><":{}
    $('.register_password').blur(function () {
        if (pass.val().trim() == "") {
            pass.parent("div").find(".input_msg").removeClass("ok").addClass("err").html("密码不能为空");
            delete register.pass;
            doregister();
            return;
        }
        if (pass.val().trim().length < 6 || pass.val().trim().length > 20 || !/^((?=.*?\d)(?=.*?[A-Za-z])|(?=.*?\d)(?=.*?[~!@#$%^&*?])|(?=.*?[A-Za-z])(?=.*?[~!@#$%^&*?]))[\dA-Za-z~!@#$%^&*?]+$/.test(pass.val().trim())) {
            pass.parent("div").find(".input_msg").removeClass("ok").addClass("err").html("6-20位，字母/数字/中文/下划线");
            delete register.pass;
            doregister();
            return;
        }
        pass.parent("div").find(".input_msg").html("").addClass("ok").removeClass("err");
        register.pass = 'pass';
        doregister();

    });
    //确认密码
    $('.register_password_check').blur(function () {
        if (pass1.val().trim() == "") {
            pass1.parent("div").find(".input_msg").removeClass("ok").addClass("err").html("请再次输入密码");
            delete register.passone;
            doregister();
            return;
        }
        if (pass1.val().trim() != pass.val().trim()) {
            pass1.parent("div").find(".input_msg").removeClass("ok").addClass("err").html("两次输入的密码不一致");
            delete register.passone;
            doregister();
            return;
        }
        pass1.parent("div").find(".input_msg").html("").addClass("ok").removeClass("err");
        register.passone = 'passone';
        doregister();

    });
    //验证码
    $('.register_code').blur(function () {
        if (code.val().trim() == "") {
            code.parent("div").find(".input_msg").removeClass("ok").addClass("err").html("请输入验证码");
            delete register.code;
            doregister();
            return;
        } else {
            code.parent("div").find(".input_msg").html("").addClass("ok").removeClass("err");
            register.code = 'code';
            doregister();
        }
    });
    //验证手机号
    $('.phone').blur(function () {
        if (phone.val().trim() == "") {
            phone.parent("div").find(".input_msg").removeClass("ok").addClass("err").html("请输入手机号");
            $('.get_code').css({ 'background-color': '#e5e5e5', 'pointer-events': 'none' });
            delete register.phone;
            doregister();
            return;
        }
        if (!/(^1[3|4|5|7|8]\d{9}$)|(^09\d{8}$)/.test(phone.val().trim())) {
            phone.parent("div").find(".input_msg").removeClass("ok").addClass("err").html("请输入正确的手机号");
            $('.get_code').css({ 'background-color': '#e5e5e5', 'pointer-events': 'none' });
            delete register.phone;
            doregister();
            return;
        }
        $.ajax({
            type: "Post",
            url: '/UserManage/Regeister/IsUserWhere',
            data: { where: phone.val().trim() },
            success: function (data) {
                if (data == "exist") {
                    phone.parent("div").find(".input_msg").removeClass("ok").addClass("err").html("该手机号已经被注册");
                    delete register.phone;
                    doregister();
                    return;
                }
                else {
                    phone.parent("div").find(".input_msg").html("").addClass("ok").removeClass("err");
                    register.phone = 'phone';
                    doregister();
                    $('.get_code').css({ 'background-color': '#2e9df7', 'pointer-events': 'auto' });
                }
            }
        });
    });
    //获取验证码
    $('.get_code').click(function () {
        $.ajax({
            type: "Post",
            url: '/UserManage/Regeister/SendVcode',
            data: { phone: phone.val().trim(), vcode: code.val().trim() },

            success: function (data) {
                var msgData = data.split(',');
                if (msgData[0] == "ok") {
                    $('.get_code').css('background-color', '#e5e5e5').text('15分钟内有效');
                    // $.Myalert("验证码已发送，30分钟内输入有效");
                } else if (msgData[0] == "no") {
                    $.Myalert(msgData[1]);
                } else {
                    $.Myalert(data);
                }
            }
        })
    })
    //短信验证
    $('.register_phone_code').blur(function () {
        if (phoneCode.val().trim() == "") {
            phoneCode.parent("div").find(".input_msg").removeClass("ok").addClass("err").html("请输入短信验证码");
            delete register.phoneCode;
            doregister();
            return;
        }
        $.ajax({
            type: "Post",
            url: '/UserManage/Regeister/CheckMobileCode',
            data: {
                mobile: phone.val().trim(), code: $('.register_phone_code').val().trim()
            },
            success: (function (data) {
                if (data == "ok") {
                    phoneCode.parent("div").find(".input_msg").html("").addClass("ok").removeClass("err");
                    register.phonecode = 'phonecode';
                    doregister();
                } else {
                    phoneCode.parent("div").find(".input_msg").removeClass("ok").addClass("err").html("验证错误");
                    delete register.phoneCode;
                    doregister();
                }
            })
        });
        
    });
    //QQ验证
    $('.qq').blur(function () {
        if (qq.val().trim() == "") {
            qq.parent("div").find(".input_msg").removeClass("ok").addClass("err").html("请输入QQ账号");
            delete register.qq;
            doregister();
            return;
        }
        qq.parent("div").find(".input_msg").html("").addClass("ok").removeClass("err");
        register.qq = 'qq';
        doregister();
    });
    //用户协议
    $('.accept').click(function () {
        if ($(this).is(":checked")) {
            register.checked = 'checked';
            doregister();
        } else {
            delete register.checked;
            doregister();
        }
    })
    //全部字段非空
    function doregister() {
        if (register.name && register.pass && register.passone && register.code && register.phone && register.phonecode && register.qq && register.checked) {
            $('.register_btn').css({ 'backgroundColor': '#ffc907', 'color': '#fff' });
            $('.register_btn').css('pointerEvents', 'auto');
        } else {
            $('.register_btn').css({ 'backgroundColor': '#f0f0f0', 'color': '#999' });
        }
    }
    $('.register_btn').mouseover(function () {
        if (register.name && register.pass && register.passone && register.code && register.phone && register.phonecode && register.qq && register.checked) {
            $('.register_btn').css('pointerEvents', 'auto');
        } else {
            $('.register_btn').css('pointerEvents', 'none');
        }
    })
    $('.register_btn').click(function () {
        $.ajax({
            type: "Post",
            url: '/UserManage/Regeister/UserReg',
            data: {
                uname: uname.val().trim(),
                phone: phone.val().trim(),
                pwd: pass.val().trim(),
                qq: qq.val().trim()
            },
            success: function (data) {
                var msgData = data.split(',');
                if (msgData[0] == "ok") {
                   // $.Myalert(msgData[1]);
                    $.ajax({
                        type: "Post",
                        url: '/UserManage/Login/UserLogin',
                        data: {
                            str: uname.val().trim(),
                            pwd: pass.val().trim(),
                            vcode: code.val().trim()
                        },
                        success: function (data) {
                            var msg = data.split(',');
                            if (msg[0] == 'ok') {
                              //  $.Myalert(msg[1]);
                                setTimeout(function () {
                                    window.location.href = '/UserManage/User/Index';
                                }, 1200);

                            } else if (msg[0] == 'no') {
                                $.Myalert(msg[1])
                            } else {
                                $.Myalert(data)
                            }
                        }
                    })
                } else {
                    $.Myalert(msgData[1]);
                }
            }
        })
    });
})
