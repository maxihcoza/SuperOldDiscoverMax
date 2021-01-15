$(document).ready(function () {
    var nav = $('#mobilemenu');

    $('nav li a').each(function () {
        var anchor = $(this);

        var option = $('<option />', {
            value: anchor.attr('href'),
            text: anchor.text()
        });

        nav.append(option);
    });

    nav.change(function () {
        window.location = $(this).find("option:selected").val();
    });
});