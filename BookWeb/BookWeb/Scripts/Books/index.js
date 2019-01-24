; (function () {
    "use strict";

    var page = {
        options: {
            urls: {
                getListApi: "/api/Books/getlist"
            }
        },
        events: {
            defaults: {
                initialize: {},
                initializeControl: {},
                loadBooks: {}
            }
        }
    };

    page.events.defaults.initialize = function () {
        page.events.defaults.initializeControl();
    };



    page.events.defaults.initializeControl = function () {
        $.ajax({
            url: page.options.urls.getListApi,
            type: "GET",
            success: function (result) {
                page.events.defaults.loadBooks(result.bookList);
            }

        });
        $("#searchButton").click(function () {
            window.location.href = "/books/Search?searchString=" + $("#SearchString").val();
        });
    };



    page.events.defaults.loadBooks = function (bookList) {
        var table = document.getElementById("booktable");
        for (var i = 0; i < bookList.length; i++) {
            var row = table.insertRow(table.rows.length);
            var c0 = row.insertCell(0);
            c0.innerHTML = bookList[i].Title;
            var c1 = row.insertCell(1);
            c1.innerHTML = bookList[i].Author;
            var c2 = row.insertCell(2);
            c2.innerHTML = bookList[i].Type;
            var c3 = row.insertCell(3);
            c3.innerHTML = bookList[i].Publisher;
            var c4 = row.insertCell(4);
            var date = new Date(bookList[i].PublishTime);
            c4.innerHTML = date.getFullYear() + "/" + date.getMonth()+ "/"+date.getDate();
            var c5 = row.insertCell(5);
            c5.innerHTML = bookList[i].Price;
            var c6 = row.insertCell(6);
            c6.innerHTML = "<a href='edit/" + bookList[i].ID + "'>Edit</a>|<a href='Details/" + bookList[i].ID + "'>Details</a>|<a href='Delete/" + bookList[i].ID +"'>Delete</a>";
        }

    };
    

    $(function () {
            page.events.defaults.initialize();
    });
})();