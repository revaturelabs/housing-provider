import * as ng from 'angular';
import 'angular-route';
import './css/index.css';
import 'file-loader?name=[name].[ext]&outputPath=partials/!./partials/navbar-header.html';
import 'file-loader?name=[name].[ext]&outputPath=partials/!./partials/footer.html';

var ngHousingProvider = ng.module('ngHousingProvider', []);

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

// ngMainProvider.controller('Ctrl', function ($scope, $http) {
//   $scope.showRequest = function () {
//     $http({
//       method: "GET",
//       url: "http://housingproviderbusiness.azurewebsites.net/api/complex" // this should be replaced with project api link when ready
//     }).then(function success(response) {
//       $scope.request = response.data;
//     }, function error(response) {
//       $scope.request = response.statusText;
//     });
//   }
// });




