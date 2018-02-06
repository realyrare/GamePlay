$('.personal_nav li dl dd a').mouseover(function () {
    $(this).prev().html('——');
});
$('.personal_nav li dl dd a').mouseout(function () {
    $(this).prev().html('—');
})
$('.personal_nav li dl dd a').click(function () {
    $('.personal_nav li dl dd').removeClass('active');
    $(this).parent().addClass('active');
})
$('.personal_nav li span').click(function () {
    $(this).parent().find('dl').slideToggle();
})