$('.manitohome_type').on('click', 'span', function () {
    $(this).addClass('active').siblings().removeClass('active');
})
$('.manitohome_game_cont').on('click', '.game_name_tab span', function () {
    $(this).addClass('active').siblings().removeClass('active');
})
$(function () {
    $('.manitohome_type .manitohome_type_manito').click();
})