import { complexDetail } from './module';
import './service';

complexDetail.controller('complexDetailController', ['$http', '$scope', '$routeParams', 'complexDetailService', function($http, $scope, $routeParams, complexDetailService) {
  complexDetailService.getComplex($scope, $routeParams.guid);
  complexDetailService.getApartments($scope, $routeParams.guid);
}]);