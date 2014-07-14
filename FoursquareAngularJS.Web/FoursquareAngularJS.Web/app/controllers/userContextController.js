'use strict';
app.controller('userContextController', function ($scope, $modelInstance, placesDataService, venue) {
    $scope.venue = venue;
    $scope.user = { username: '' };

    $scope.close = function () {
        $modelInstance.dismiss('cancel');
    };

    $scope.saveUser = function () {
        placesDataService.setUserInContext($scope.user.username);
        placesDataService.savePlace(venue).then(function () {
            $scope.close();
        }, function () {
            alert("Error occured");
        });
    }
});