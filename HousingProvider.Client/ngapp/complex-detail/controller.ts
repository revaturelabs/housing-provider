import 'angular-material';
import { complexDetail } from './module';
import './service';

complexDetail.controller('complexDetailController', ['$http', '$scope', '$routeParams', '$mdDialog', 'complexDetailService', function($http, $scope, $routeParams, $mdDialog, complexDetailService) {
  $scope.complexName = $routeParams.complexName;
  $scope.guid = $routeParams.guid;
  complexDetailService.getApartments($scope, $routeParams.guid);

  $scope.complexName = $routeParams.complexName;
    $scope.address = {};
    $scope.property = {
        complexGuid: $routeParams.guid
    };

    $scope.addProperty = function () {
        complexDetailService.postProperty($scope.address, $scope.property, $routeParams.complexName, $routeParams.guid);
        $mdDialog.hide();
    }

  $scope.showPropDialog = function (ev) {
    $mdDialog.show({
      contentElement: '#addPropDialog',
      parent: document.body,
      targetEvent: ev,
      clickOutsideToClose: true
    })
  };

  $scope.cancelOption = function () {
    $mdDialog.hide();
  }
}]);