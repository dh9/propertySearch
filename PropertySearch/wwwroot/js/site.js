// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var imageController = function () {
    var init = function (url) {
        $(document).ready(function () {
            $('.js-property-item').on('click', function () {
                $.ajax(
                   {
                       url: url + '/' + this.id, 
                       success: function(result)
                       {
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

