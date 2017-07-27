import { complex } from './module';
import './service';

complex.controller('complexController', ['$scope', '$http', 'complexService', function ($scope, $http, complexService) {
  complexService.getComplexes($scope);
}]);