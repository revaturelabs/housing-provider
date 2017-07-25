import * as ng from 'angular';
import 'angular-route';
import 'adal-angular/lib/adal';
import 'adal-angular/lib/adal-angular';
import './css/index.css';
import 'file-loader?name=[name].[ext]&outputPath=partials/!./partials/navbar-header.html';
import 'file-loader?name=[name].[ext]&outputPath=partials/!./partials/footer.html';
import 'file-loader?name=[name].[ext]&outputPath=html/!./home/home-template.html';
import 'file-loader?name=[name].[ext]&outputPath=html/!./complex/complex-template.html';

var ngHousingProvider = ng.module('ngHousingProvider', ['ngRoute', 'AdalAngular']);

ngHousingProvider.config(['$httpProvider', '$locationProvider', '$routeProvider', 'adalAuthenticationServiceProvider', function ($http, $location, $route, auth) {
  $location.html5Mode(true).hashPrefix('!');

  $route
    .when('/', {
      controller: 'homeController',
      templateUrl: './html/home-template.html'
    })
    .when('/complex', {
      controller: 'complexController',
      templateUrl: './html/complex-template.html',
      requireADLogin: true
    })
    .otherwise({
      redirectTo: '/'
    });

  auth.init({
    clientId: 'fredbelotterevature.onmicrosoft.com',
    tenant: '7729d52b-dc10-40e5-a605-f77b0b77faaa'
  }, $http);
}]);

ngHousingProvider.controller('complexController', ['$scope', '$http', function($scope, $http) {
  $scope.getComplexes = function () {
    $http.get('http://housingproviderbusiness.azurewebsites.net/api/complex').then(function (res) {
      $scope.complexes = res.data;

      var count = 1;
      $scope.complexes.forEach(function(element) {
        element.counter = count++;
      });
    });
  };
}]);

ngHousingProvider.controller('homeController', ['$scope', 'adalAuthenticationService', function($scope, auth) {
  $scope.signIn = function () {
    auth.login();
  };

  $scope.signOut = function () {
    auth.logOut();
  }
}]);
