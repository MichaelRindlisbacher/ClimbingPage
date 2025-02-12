// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$("#est").click(function () {
    // Multiply the hours and hourly rate
    $("#price").text("$" + ($("#hrs").val()) * (parseFloat($("#pph").text().substring(1,3))));
});