import * as ng from 'angular';
import 'angular-route';

var ngMainProvider = ng.module('ngMainProvider', ['ngRoute']);

var request;
var showMe = false;
ngMainProvider.controller('Ctrl', function ($scope, $http) {
    $scope.showMe = false;
    $http({
        method: "GET",
        url: "http://pokeapi.co/api/v2/pokemon/1" 
    }).then(function success(response) {
        $scope.request = response.data;
        request = response.data;
        
        
    }, function error(response) {
        $scope.request = response.statusText;
    });

    $scope.showRequest = function() {
        console.log(showMe);
        console.log("displaying Request...");
        // if(typeof(request) != undefined)
        //     {
        //         console.log("passed if statement");
        //         request = JSON.parse(request);
        //     }
            
        console.log(request);
        
        $scope.showMe = true;
        
    }


});


