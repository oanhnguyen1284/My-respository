/**
 * Created by oanhnguyen on 6/9/2014.
 */
var rout = angular.module("routing",[]);

rout.controller("LocationController", function($scope,$location){
    $scope.$watch('locationPath', function(path) {
        $location.path(path);
    });
    $scope.$watch(function() {
        return $location.path();
    }, function(path) {
        $scope.locationPath = path;
    });
});