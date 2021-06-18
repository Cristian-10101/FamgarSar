

function acosolaborals_search() {
    const search = document.getElementById("txt-search").value;
    const currentURL = window.location.href.substring(
        window.location.href.lastIndexOf("/") + 1
    ).split("?")[0];

    window.location = window.location = `${currentURL}?search=${search}`;
}

const acoso_input_search = document.getElementById("txt-search");

acoso_input_search.addEventListener("keyup", function (event) {
    if (event.keyCode == 13) {
        event.preventDefault();
        acosolaborals_search();
    }
});