// ANGULAR
import * as ng from 'angular';
import 'angular-route';
import 'adal-angular/lib/adal-angular';

// CONTROLLERS
import './home/controller';
import './complex/controller';
import './complex-detail/controller';
import './complex-create/controller';
import './property-create/controller';

// CSS
import './css/revature.css';
import './css/index.css';

// TEMPLATES
import 'file-loader?name=[name].[ext]&outputPath=home/!./home/template.html';
import 'file-loader?name=[name].[ext]&outputPath=complex/!./complex/template.html';
import 'file-loader?name=[name].[ext]&outputPath=complex-detail/!./complex-detail/template.html';
import 'file-loader?name=[name].[ext]&outputPath=complex-create/!./complex-create/template.html';
import 'file-loader?name=[name].[ext]&outputPath=property-create/!./property-create/template.html';

var ngHousingProvider = ng.module('ngHousingProvider', ['ngRoute', 'AdalAngular', 'providerHome', 'providerComplex', 'providerComplexDetail', 'providerCreateComplex', 'providerCreateProperty']);

ngHousingProvider.config(['$httpProvider', '$locationProvider', '$routeProvider', 'adalAuthenticationServiceProvider', function ($http, $location, $route, adalAuth) {
  $location.html5Mode(true).hashPrefix('!');

  $route
    .when('/', {
      controller: 'homeController',
      templateUrl: './home/template.html'
    })
    .when('/complex', {
      controller: 'complexController',
      templateUrl: './complex/template.html',
      requireADLogin: true
    })
    .when('/complexdetail/:complexName/:guid', {
      controller: 'complexDetailController',
      templateUrl: './complex-detail/template.html',
      requireADLogin: true
    })
    .when('/createproperty/:complexName/:guid', {
      controller: 'createPropertyController',
      templateUrl: './property-create/template.html',
      requireADLogin: true
    })
    .when('/createcomplex', {
      controller: 'createComplexController',
      templateUrl: './complex-create/template.html',
      requireADLogin: true
    })
    .otherwise({
      redirectTo: '/'
    });

  adalAuth.init({
    tenant: 'fredbelotterevature.onmicrosoft.com',
    clientId: '97f55e0c-ea66-486b-8c0d-4f195fa0653c'
  }, $http);
}]);

export { ngHousingProvider };
