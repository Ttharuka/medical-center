// Call the dataTables jQuery plugin
$(document).ready(function() {
    $('table.table').DataTable({
        responsive: true,
        dom: 'Bfrtip',
        lengthChange: false,
        buttons: [

            { extend: 'print', className: 'btn btn-info m-1 p-1' },
            {
                extend: 'excelHtml5', className: 'btn btn-info m-1 p-1'
            },
            {
                extend: 'pdfHtml5',
                orientation: 'landscape',
                pageSize: 'A3', className: 'btn btn-info m-1 p-1'
            },
            { extend: 'colvis', className: 'btn btn-info m-1 p-1' },
        ]
    });

    $('select.form-control').select2();

    var ele = $('input.form-control[type="datetime-local"]');
    ele.attr("type", "text");
    ele.datetimepicker({
        format: "Y/m/d H:i",
        step: 1
    });
    
});