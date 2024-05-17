// script.js dosyası

document.addEventListener('DOMContentLoaded', function () {
    const menuToggle = document.getElementById('menu-toggle');
    const menuIcon = document.querySelector('.menu-icon');
    const menuBar = document.querySelector('.menu-bar');

    menuIcon.addEventListener('click', function () {
        menuToggle.checked = !menuToggle.checked;
    });

    window.addEventListener('click', function (event) {
        if (!menuBar.contains(event.target) && !menuIcon.contains(event.target)) {
            menuToggle.checked = false;
        }
    });
});
