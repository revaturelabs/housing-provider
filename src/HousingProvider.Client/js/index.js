"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var ng = require("angular");
require("angular-route");
var ngMainProvider = ng.module('ngMainProvider', ['ngRoute']);
var request;
ngMainProvider.controller('Ctrl', function ($scope, $http) {
    $http({
        method: "GET",
        url: "http://pokeapi.co/api/v2/pokemon/1"
    }).then(function success(response) {
        $scope.request = response.data;
        request = response.data;
    }, function error(response) {
        $scope.request = response.statusText;
    });
    $scope.showRequest = function () {
        console.log("displaying Request...");
        request = JSON.parse(request);
        console.log(request);
    };
});
