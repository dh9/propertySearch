﻿//class for retrieving images from api
var imageController = function () {
    var init = function (url) {
        $(document).ready(function () {
            $('.js-property-item').on('click', function () {
                $.ajax(
                   {
                       url: url + '/' + this.id, 
                       success: function(result)
                       {
                           //set source to api call result
                           document.getElementById("js-property-image").src = result;
                       }
                  });
           });
       });
    };

    return {
        init: init
    };
}();

