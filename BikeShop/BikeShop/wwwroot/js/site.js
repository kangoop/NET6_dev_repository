// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function addCategory(base, uri, data,toastbox) {   

        fetch(uri, {
            method: "post",
            headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: data
        }).then(response => {
            console.info("sucess");

            if (response.status == 200) {

                toastbox.childNodes[3].textContent = "Sucess";

            } else {
                toastbox.childNodes[3].style.backgroundColor = "red";
                toastbox.childNodes[3].textContent = "Faild";

            }

            var toast = new bootstrap.Toast(toastbox)

            toast.show();

        }).catch(error => { console.log("Error");  console.log(error); });

}

function getCategory(uri) {

  

    fetch(uri, {
        method: "GET",
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        //body: data
    }).then(response => {
        console.info("sucess");
        return response; //console.info(response.status);
    }).catch(error => { console.log("Error"); console.log(error); });

}

function updateCategory(uri, data,modal) {

    fetch(uri, {
        method: "put",
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: data

    }).then(response => {
 

        if (response.status == 200) {

            console.info("sucess");

            const modaltag = modal.getElementsByClassName("btn-close")[0];

            modaltag.click();

        } else {

        }

    }).catch(error => { console.log(error); });

}


function updatebrand(uri, data, modal) {

    fetch(uri, {
        method: "put",
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: data

    }).then(response => {
        console.info("sucess");

        if (response.status == 200) {

        } else {

        }

    }).catch(error => { console.log("Error"); });

}


function addbrand(base, uri, data, toastbox) {

    fetch(uri, {
        method: "post",
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: data
    }).then(response => {
        console.info("sucess");

        if (response.status == 200) {

            toastbox.childNodes[3].textContent = "Sucess";

        } else {
            toastbox.childNodes[3].style.backgroundColor = "red";
            toastbox.childNodes[3].textContent = "Faild";

        }

        var toast = new bootstrap.Toast(toastbox)

        toast.show();

    }).catch(error => { console.log("Error"); console.log(error); });

}