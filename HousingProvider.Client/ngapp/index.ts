import * as ng from 'angular';
import 'angular-route';
import 'adal-angular/lib/adal-angular';
import './home/controller';
import './complex/controller';
import './css/index.css';
import 'file-loader?name=[name].[ext]&outputPath=complex/!./complex/template.html';

var ngHousingProvider = ng.module('ngHousingProvider', ['ngRoute', 'AdalAngular', 'providerHome', 'providerComplex']);

ngHousingProvider.config(['$httpProvider', '$locationProvider', '$routeProvider', 'adalAuthenticationServiceProvider', function ($http, $location, $route, adalAuth) {
  $location.html5Mode(true).hashPrefix('!');

  $route
    .when('/', {
      controller: 'complexController',
      templateUrl: './complex/template.html'
    })
    .when('/complex', {
      controller: 'complexController',
      templateUrl: './complex/template.html',
      // requireADLogin: true
    })
    .otherwise({
      redirectTo: '/'
    });

  adalAuth.init({
    clientId: '97f55e0c-ea66-486b-8c0d-4f195fa0653c'
  }, $http);
}]);

export { ngHousingProvider };
