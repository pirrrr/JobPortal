app.controller("JobPortalController", function ($scope, $window, JobPortalService) {

    $scope.Login = function () {
        swal("Good job!", "You clicked the button!", "success")
        .then(function () {
            $window.location.href = '/JobPortal/HomePage';
        });
    };

    $scope.Register = function () {
        $window.location.href = '/JobPortal/Register';
    };

    $scope.selectedRole = 'Student';
    

});