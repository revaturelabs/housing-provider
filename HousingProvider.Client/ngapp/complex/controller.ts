import { complex } from './module';
import 'file-loader?name=[name].[ext]&outputPath=complex/!./template.html'

complex.controller('complexController', ['$scope', '$http', function ($scope, $http) {
  $http.get('http://housingproviderbusiness.azurewebsites.net/api/complex').then(function (res) {
    $scope.complexes = res.data;
    $scope.orderProp = 'complexName';

    // var count = 1;
    // $scope.complexes.forEach(function(element) {
    //   element.counter = count++;
    // });
  });
}]);