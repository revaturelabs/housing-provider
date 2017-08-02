import 'angular-material';
import { complexDetail } from './module';
import './service';

complexDetail.controller('complexDetailController', ['$http', '$scope', '$routeParams', '$mdDialog', 'complexDetailService', function ($http, $scope, $routeParams, $mdDialog, complexDetailService) {
  $scope.waiting = true;
  $scope.apartments = [];
  $scope.guid = $routeParams.guid;
  complexDetailService.getApartments($scope, $routeParams.guid);

  $scope.complexName = $routeParams.complexName;
  $scope.address = {};
  $scope.property = {
    complexGuid: $routeParams.guid
  };

  $scope.addProperty = function () {
    complexDetailService.postProperty($scope.address, $scope.property, $routeParams.complexName, $routeParams.guid, $scope);
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