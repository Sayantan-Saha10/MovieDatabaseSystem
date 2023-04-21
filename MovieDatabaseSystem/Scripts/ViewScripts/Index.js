var movieDatabaseGrid;

$(document).ready(function () {
    loadMovieTable();
});

$("#AddMovieBtn").on("click", function () {
    $("#addMovieModal").modal({
        backdrop: "static"
    });
    $("#addMovieModal").modal("show");
});

function loadMovieTable() {
    movieDatabaseGrid = $("#movieTable").DataTable({
        ajax: {
            url: "/Home/GetMovieGridData",
            type: "GET",
            datatype: "json"
        },
        searching: false,
        paging: false,
        columnDefs: [
            {
                targets: 0,
                orderable: false
            }
        ],
        language: {
            sInfo: "Showing _START_ - _END_ of _TOTAL_",
            infoEmpty: "Showing 0 - 0 of 0",
            zeroRecords: "No Records Found"
        },
        columns: [
            { data: "Id", name: "Id", className: "Movie-Id" },
            { data: "Title", name: "Title", className: "Movie-Title" },
            { data: "Category", name: "Category", className: "Movie-Category" },
            { data: "Runtime", name: "Runtime", className: "Movie-Runtime" },
            { data: "ReleasedDate", name: "Released Date", className: "Movie-ReleasedDate" },
            { data: "Director", name: "Director", className: "Movie-Director" },
            {
                render: function (data, type, row, meta) {
                    return '<span class="description-span" title="' + row.Description + '">' + row.Description + '</span>';
                },
                name: "Description",
                className: "Movie-Description"
            },
            { data: "Rating", name: "Rating", className: "Movie-Rating" }
        ]
    });
}