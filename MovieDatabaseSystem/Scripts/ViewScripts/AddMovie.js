$(document).ready(function () {
    $("#category-select").select2({
        width: '100%',
        minimumResultsForSearch: -1,
        dropdownParent: $("#addMovieModal")
    });

    $("#movieRuntime").hunterTimePicker();
})


$("#cancelAdd").on("click", function () {
    $("#addMovieModal").modal("hide");
})

$("#saveAdd").on("click", function () {
    var title = $("#movieTitle").val();
    var categoryId = $("#category-select").val();
    var category = $("#category-select option:selected").text();
    var runtime = $("#movieRuntime").val();
    var releasedDate = $("#movieReleasedDate").val();
    var director = $("#movieDirector").val();
    var rating = $("#movieRating").val();
    var description = $("#movieDescription").val();

    var movieDetails = {
        Title: title,
        CategoryId: categoryId,
        Category: category,
        Runtime: runtime,
        ReleasedDate: releasedDate,
        Director: director,
        Rating: rating,
        Description: description
    };

    $.ajax({
        type: "POST",
        url: "/Home/SaveMovieRecord",
        contentType: "application/json",
        data: JSON.stringify(movieDetails),
        success: function (result) {
            if (result.IsSuccess) {
                $("#addMovieModal").modal("hide");
                $("#movieTable").DataTable().ajax.reload();
            }
            else {
                alert(result.Message);
            }
        },
        error: function () {
            alert("Error Occured!!");
        }
    })
})