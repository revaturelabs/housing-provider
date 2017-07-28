import { complex } from './module';
import './service';

complex.controller('complexController', ['$scope', '$http', 'complexService', '$location', function ($scope, $http, complexService, $location) {
  complexService.getComplexes($scope);
}]);