function searchEmployee() {
    var search = $("#searchString").val();

    $.ajax({
        url: "Search",
        data: { searchString: search }
    }).done(function(data) {
        $("#firstName").val(data.FirstName);
        $("#middleName").val(data.MiddleName);
        $("#lastName").val(data.LastName);
        var bd = new Date(parseInt(data.BirthDateString));
        console.log(bd);
        $("#birthDate").val(bd.toISOString().substr(0, 10));
        console.log(data.BirthDateString);
        var hd = new Date(parseInt(data.HireDateString));
        console.log(hd);
        $("#hireDate").val(hd.toISOString().substr(0, 10));
        console.log(data.HireDateString);
        $("#department").val(data.Department);
        $("#jobTitle").val(data.JobTitle);
        $("#salary").val(data.Salary);
        $("#salaryType").val(data.SalaryTypeString);
        $("#employeeId").val(data.EmployeeId);
        $("#availableHours").val(data.AvailableHours);
        });
}

function updateEmployee() {

    var firstName = $("#firstName").val();
    var middleName = $("#middleName").val();
    var lastName = $("#lastName").val();
    var birthDate = $("#birthDate").val();
    var hireDate = $("#hireDate").val();
    var department = $("#department").val();
    var jobTitle = $("#jobTitle").val();
    var salary = $("#salary").val();
    var salaryType = $("#salaryType").val();
    var employeeId = $("#employeeId").val();
    var availableHours = $("#availableHours").val();

    $.ajax({
        url: "UpdateEmployee",
        dataType: "json",
        data: {
            FirstName: firstName,
            MiddleName: middleName,
            LastName: lastName,
            BirthDate: birthDate,
            HireDate: hireDate,
            Department: department,
            JobTitle: jobTitle,
            Salary: salary,
            SalaryType: salaryType,
            EmployeeId: employeeId,
            AvailableHours: availableHours

        }
    }).done(function (data) {
        if (data) {
            $("#successMessage").removeClass("hidden")
                .addClass("visible");
        } else {
            $("#errorMessage").removeClass("hidden")
                .addClass("visible");
        }
    });
}

function unixToReadable(dateIn) {
    var thisDate = new Date(parseInt(dateIn));
    console.log("unix to readable function: ", thisDate);
    //var formattedDate = (("0" + date.getDate()).slice(-2) + "/"
    // + ("0" + (date.getMonth() + 1)).slice(-2) + "/"
    // + date.getFullYear());
    return thisDate.toISOString().substr(0, 10);
}