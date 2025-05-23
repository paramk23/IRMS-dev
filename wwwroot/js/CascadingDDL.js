//$(document).ready(function () {
//    $('#category').attr('disabled': true);
//    $('#subCategory').attr('disabled': true);
//    LoadCategories();

//});
//function LoadCategories() {
//    $('#category').empty();

//    $.ajax({
//        url: '/Account/GetCategories',
//        success: function (response) {
//            If (response != null && response != undefined && response.length > 0) {
//                $('#category').attr('disabled': false);
//                $('#category').append('<option>--Select a Category--</option>');
//                $('#subCategory').append(' <option>--Select a Sub Category--</option >');
//                $each(response, function (i, data) {
//                    $('#category').append('<option> ' + data.CategoryName + '</option>')
//                });
//            }
//            else {
//                $('#category').attr('disabled': true);
//                $('#subCategory').attr('disabled': true);
//                $('#category').append('<option>--Categories not available--</option>');
//                $('#subCategory').append('<option>--Sub Categories not available--</option>');
//            }
//        }
//    })
//}