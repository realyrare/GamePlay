$(function () {
    //parent.document.querySelector('.personal_ifm').height = 
    $(window.parent.document).find('.personal_ifm').height($('.manito_recreation').height() + 40);
})
//$('button').not('.recreation_btn').click(function () {
//    $(this).parent('.row_cont').find('input[type="file"]').trigger('click');
//})

//提交按钮激活状态
var isok = {};
//头像
$('.head_btn').click(function () {
    $(this).next().trigger('click');
    if ($('.head_cont img').length != 0) {
        isok.head = 'head';
    } else {
        delete isok.head;
    }
})
$('.head_btn').next().change(function (e) {
    var data = new FormData(e);
    $.ajax({
        url: "",
        type: "POST",
        data: data,
        processData: false,  // 告诉jQuery不要去处理发送的数据
        contentType: false,   // 告诉jQuery不要去设置Content-Type请求头
        success: function (data) {
        }
    });
})
//城市选择
$('.select_city').click(function (e) {
    if (e.target.innerHTML != '选择城市') {
        isok.city = 'city';
    } else {
        delete isok.city;
    }
})
//选择游戏
//游戏名
$('.gama_name').change(function () {
    if ($(this).val() != '选择游戏') {
        isok.gameName = 'gameNmae';
    } else {
        delete isok.gameName;
    }
})
//游戏区服
$('.game_area').change(function () {
    if ($(this).val() != '选择区服') {
        isok.gameArea = 'gameArea';
    } else {
        delete isok.gameArea;
    }
})
//游戏段位
$('.game_value').change(function () {
    if ($(this).val() != '选择段位') {
        isok.gameValue = 'gameValue';
    } else {
        delete isok.gameValue;
    }
})
//段位截图
$('.grade_btn').click(function () {
    $(this).next().trigger('click');
    if ($('.grade_btn img').length != 0) {
        isok.grade = 'grade';
    } else {
        delete isok.grade;
    }
})
$('.grade_btn').next().change(function (e) {
    var data = new FormData(e);
    $.ajax({
        url: "",
        type: "POST",
        data: data,
        processData: false,  // 告诉jQuery不要去处理发送的数据
        contentType: false,   // 告诉jQuery不要去设置Content-Type请求头
        success: function (data) {
        }
    });
})
//线上陪玩价格
$('.online_price').change(function () {
    if ($(this).val() != '线上陪玩') {
        isok.onlinePrice = 'onlinePrice';
    } else {
        delete isok.onlinePrice;
    }
})
//线下陪玩价格
$('.offline_price').change(function () {
    if ($(this).val() != '线下陪玩') {
        isok.offlinePrice = 'offlinePrice';
    } else {
        delete isok.offlinePrice;
    }
})
//陪打标签
$('.select_label').click(function (e) {
    if (e.target.innerHTML != '陪打标签') {
        isok.label = 'label';
    } else {
        delete isok.label;
    }
})
//服务说明
$('.service').blur(function () {
    if ($(this).val()) {
        isok.service = 'service';
    } else {
        delete isok.service;
    }
})
//个人照片
$('.self_btn').click(function () {
    $(this).next().trigger('click');
    if ($('.self_btn img').length != 0) {
        isok.self = 'self';
    } else {
        delete isok.self;
    }
})
$('.self_img i').click(function () {
    $(this).parent('.self_img').remove();
})
$('.self_btn').next().change(function (e) {
    var data = new FormData(e);
    $.ajax({
        url: "",
        type: "POST",
        data: data,
        processData: false,  // 告诉jQuery不要去处理发送的数据
        contentType: false,   // 告诉jQuery不要去设置Content-Type请求头
        success: function (data) {
        }
    });
})
//战绩截图
$('.standings_btn').click(function () {
    $(this).next().trigger('click');
    if ($('.standings_btn img').length != 0) {
        isok.standings = 'standings';
    } else {
        delete isok.standings;
    }
})
$('.standings_btn').next().change(function (e) {
    var data = new FormData(e);
    $.ajax({
        url: "",
        type: "POST",
        data: data,
        processData: false,  // 告诉jQuery不要去处理发送的数据
        contentType: false,   // 告诉jQuery不要去设置Content-Type请求头
        success: function (data) {
        }
    });
})
//城市选择弹框
var allcity = [['安徽', ['阜阳', '宿州', '巢湖', '六安', '豪州', '池州', '宣城', '合肥', '芜湖', '蚌埠', '淮南']], ['福建', ['福州', '厦门', '莆田', '三明', '泉州', '漳州', '南平', '龙岩', '宁德']], ['广东', ['广州', '韶关', '深圳', '珠海', '汕头', '佛山', '江门', '湛江', '茂名', '肇庆', '惠州', '梅州', '汕尾', '河源', '阳江', '清远', '东莞', '中山', '潮州', '揭阳', '云浮']], ['广西', ['南宁', '柳州', '桂林', '梧州', '北海', '防城港', '钦州', '贵港', '玉林', '百色', '贺州', '河池', '来宾', '崇左']], ['贵州', ['贵阳', '六盘水', '遵义市', '安顺', '毕节地', '黔西南布依族苗族自治州', '黔东南苗族侗族自治州', '黔南布依族苗族自治州']], ['甘肃', ['兰州', '嘉峪关', '金昌', '白银', '天水', '武威', '张掖', '平凉', '酒泉', '庆阳', '定西', '陇南', '临夏回族自治州', '甘南藏族自治州']], ['海南', ['海口', '三亚', '五指山', '琼海', '儋州', '文昌', '万宁', '东方', '澄迈县', '定安县', '屯昌县', '临高县', '白沙黎族自治县', '昌江黎族自治县', '乐东黎族自治县', '陵水黎族自治县', '保亭黎族苗族自治县', '琼中黎族苗族自治县']], ['河南', ['鹤壁', '新乡', '焦作', '濮阳', '许昌', '漯河', '三门峡', '南阳', '商丘', '信阳', '周口']], ['黑龙江', ['鸡西', '鹤岗', '双鸭山', '大庆', '伊春', '佳木斯', '七台河', '牡丹江', '黑河', '绥化', '大兴安岭']], ['湖北', ['十堰', '宜昌', '襄阳', '鄂州', '荆门', '孝感', '荆州', '黄冈', '咸宁', '随州', '恩施土家族苗族自治州']], ['湖南', ['衡阳', '邵阳', '岳阳', '常德', '张家界', '益阳', '郴州', '永州', '怀化', '娄底', '湘西土家族苗族自治州']], ['河北', ['石家庄', '唐山', '秦皇岛', '邯郸', '邢台', '保定', '张家口', '承德', '沧州', '廊坊', '衡水']], ['江苏', ['徐州', '常州', '苏州', '南通', '连云港', '淮安', '盐城', '扬州', '镇江', '泰州', '宿迁']], ['江西', ['南昌', '景德镇', '萍乡', '九江', '新余', '鹰潭', '赣州', '吉安', '宜春', '抚州', '上饶']], ['吉林', ['长春', '吉林', '四平', '辽源', '通化', '白山', '松原', '白城', '延边朝鲜族自治州']], ['辽宁', ['铁岭', '朝阳', '葫芦岛', '沈阳', '大连', '鞍山', '抚顺', '本溪', '丹东', '锦州', '营口']], ['宁夏', ['银川', '石嘴山', '吴忠', '固原', '中卫']], ['内蒙古', ['呼和浩特', '包头', '乌海', '赤峰', '通辽', '鄂尔多斯', '呼伦贝尔', '巴彦淖尔', '乌兰察布', '兴安盟', '锡林郭勒盟', '阿拉善盟']], ['青海', ['西宁', '海西', '海北', '果洛', '海东', '黄南', '玉树', '海南']], ['山东', ['济南', '青岛', '淄博', '枣庄', '东营', '烟台', '潍坊', '济宁', '泰安', '威海', '日照', '莱芜', '临沂', '德州', '聊城', '滨州', '菏泽']], ['山西', ['太原', '大同', '阳泉', '长治', '晋城', '朔州', '晋中', '运城', '忻州', '临汾', '吕梁']], ['陕西', ['西安', '铜川', '宝鸡', '咸阳', '渭南', '延安', '汉中', '榆林', '安康', '商洛']], ['四川', ['广安', '达州', '雅安', '巴中', '资阳', '阿坝藏族羌族自治州', '甘孜藏族自治州', '凉山彝族自治州', '成都', '自贡', '攀枝花', '泸州', '德阳', '绵阳', '广元', '遂宁', '内江', '乐山', '南充', '眉山', '宜宾']], ['新疆', ['乌鲁木齐', '克拉玛依', '吐鲁番地区', '哈密地区', '昌吉回族自治州', '博尔塔拉蒙古自治州', '巴音郭楞蒙古自治州', '阿克苏地区', '克孜勒苏柯尔克孜自治州', '喀什地区', '和田地区', '伊犁哈萨克自治州', '塔城地区', '阿勒泰地区']], ['西藏', ['拉萨', '昌都地区', '山南地区', '日客则地区', '那曲地区', '阿里地区', '林芝地区']], ['云南', ['昆明', '曲靖', '玉溪', '保山', '昭通', '丽江', '普洱', '临沧', '楚雄彝族自治州', '红河哈尼彝族自治州', '文山壮族苗族自治州', '西双版纳傣族自治州', '大理白族自治州', '德宏傣族景颇族自治州', '怒江傈僳族自治州', '迪庆藏族自治州']], ['浙江', ['杭州', '宁波', '温州', '嘉兴', '湖州', '绍兴', '金华', '衢州', '舟山', '台州', '丽水']], ['其她', ['北京', '上海', '天津', '重庆', '台湾', '香港', '澳门']]];

//标签选择
var label = {};
$('.label_cont').on('click','em',function () {
    $(this).parent().remove();
    delete label[$(this).next().text()];
    if ($('.label_cont .label_txt').length == 0) {
        $('.label_cont').find('.row_cont_img_txt').show();
    }
})
$('.choose_label').change(function (e) {
    if (remove(label, e.target.value)) {
        $('.label_cont').find('.row_cont_img_txt').hide();
        if ($('.label_cont .label_txt').length < 10) {
            $('.label_cont').append('<div class="label_txt"><em></em><span>' + e.target.value + '</span></div>');
            label[e.target.value] = e.target.value;
        }
    } else {
        return
    }
})
$('.self_label').keyup(function (e) {
    var str = $('.self_label').val();
    if (e.keyCode == 13 && remove(label, str)) {
        $('.label_cont').find('.row_cont_img_txt').hide();
        if ($('.label_cont .label_txt').length < 10) {
            $('.label_cont').append('<div class="label_txt"><em></em><span>' + e.target.value + '</span></div>');
            label[str] = str;
            $('.self_label').val('');
        }
    }
})
function remove(obj,value){
    if(obj[value] == value){
        return false
    }
    return true
}
