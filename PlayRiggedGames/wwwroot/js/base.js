$(document).ready(function () {
    // Define the number of rows to show per page
    var rowsPerPage = 10;

    // Get the total number of rows in the table
    var totalRows = $('table tbody tr').length;

    // Calculate the total number of pages
    var totalPages = Math.ceil(totalRows / rowsPerPage);

    // Generate the pagination links
    var paginationHTML = '<nav><ul class="pagination justify-content-center">';
    paginationHTML += '<li class="page-item"><a class="page-link" href="#" data-page="prev">&laquo;</a></li>';

    for (var i = 1; i <= totalPages; i++) {
        paginationHTML += '<li class="page-item"><a class="page-link" href="#" data-page="' + i + '">' + i + '</a></li>';
    }

    paginationHTML += '<li class="page-item"><a class="page-link" href="#" data-page="next">&raquo;</a></li>';
    paginationHTML += '</ul></nav>';

    // Append the pagination links to the container
    $('#pagination-container').html(paginationHTML);

    // Show the first page by default
    showPage(1);

    // Handle pagination link click event
    $('#pagination-container').on('click', 'a.page-link', function (e) {
        e.preventDefault();

        var page = $(this).data('page');

        if (page === 'prev') {
            // Show the previous page
            showPage(currentPage - 1);
        } else if (page === 'next') {
            // Show the next page
            showPage(currentPage + 1);
        } else {
            // Show the selected page
            showPage(page);
        }
    });

    // Function to show the specified page
    function showPage(page) {
        // Hide all rows
        $('table tbody tr').hide();

        // Calculate the starting and ending row index
        var startIndex = (page - 1) * rowsPerPage;
        var endIndex = startIndex + rowsPerPage;

        // Show the rows for the current page
        $('table tbody tr').slice(startIndex, endIndex).show();

        // Update the active page link
        $('.page-item').removeClass('active');
        $('.page-item a[data-page="' + page + '"]').parent().addClass('active');

        // Store the current page
        currentPage = page;
    }
});