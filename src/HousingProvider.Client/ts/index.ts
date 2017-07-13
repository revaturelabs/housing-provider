import * as ng from 'angular';
import 'angular-route';

var ngMainProvider = ng.module('ngMainProvider', ['ngRoute']);

var request;

ngMainProvider.controller('Ctrl', function ($scope, $http) {
    $http({
        method: "GET",
        url: "http://pokeapi.co/api/v2/pokemon/1"
    }).then(function success(response) {
        $scope.request = JSON.parse(response.data);
        request = JSON.parse(response.data);
        
    }, function error(response) {
        $scope.request = response.statusText;
    });

    $scope.showRequest = function() {

        console.log("displaying Request...");
        console.log($scope.request);
    }


});


