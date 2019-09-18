// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//TODO: Locate IDs and classes to select the correct ones
$(function () {

    $('#main').on('click', '.paging a', function () {
        var url = $(this).attr('href');

        $('#main').load(url);

        return false;
    })

});