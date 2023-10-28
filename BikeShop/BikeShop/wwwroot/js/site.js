// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function addCategory(uri, data) {


    fetch(uri, {
        method: "post",
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: data
        }).then(response => {
            console.info("sucess");
            return response; //console.info(response.status);
        }).catch(error => { console.log("Error");  console.log(error); });

}

function readCategory(uri, data) {


}

function setCategory(uri, data) {


}

