jQuery.extend({
    Myalert: function (msg) {
        var div = $('<div>' + msg + '</div>');
        div.css({
            "position": "fixed", "width": "340", "height": "60px", "background": "rgba(0,0,0,.6)", "color": "#ffc907", "left": "0", "right": "0", "top": "30%", "display": "none"
         , "line-height": "60px", "font-size": "16px", "borderRadius": "4px","border":"1px solid #ffc907","textAlign":"center","margin":"0 auto",
        });
        $('html').append(div);
        div.fadeIn(1000);
        setTimeout(function (
         ) {
            div.fadeOut(1000);
            div.remove();
        }, 2000)
        
    },


})