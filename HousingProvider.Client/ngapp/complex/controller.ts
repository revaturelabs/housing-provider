import { ngHousingProvider } from '../index';

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