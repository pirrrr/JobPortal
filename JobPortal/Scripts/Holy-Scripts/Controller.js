app.controller("JobPortalController", function ($scope, JobPortalService) {

    $scope.AlertFunc = function () {
        swal("Good job!", "You clicked the button!", "success");
    }

});