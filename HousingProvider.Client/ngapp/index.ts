import 'file-loader?name=[name].[ext]&outputPath=ngapp/home/!./home/template.html';
// import './home/template.html';
import './css/index.css';

// export function addNumbers(n1: number, n2: number) {
//   return n1 + n2;
// }

import * as ng from 'angular';

var ngApp = ng.module('ngApp', []);

ngApp.controller('TestController', ['$scope', '$http', function ($scope, $http) {
  $scope.something = 'hello mock';

  $scope.addNumbers = function(n1, n2) {
    return n1 + n2;
  };

  $scope.seeYouLater = function () {
    $http.get('/someurl').then(function (res) {
      $scope.success = res;
    });
  };
}]);
