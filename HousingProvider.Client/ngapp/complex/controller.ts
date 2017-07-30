import 'angular-material';
import { complex } from './module';
import './service';

complex.controller('complexController', ['$scope', '$http', 'complexService', '$mdDialog', function ($scope, $http, complexService, $mdDialog) {
  complexService.getComplexes($scope);

  $scope.status = '  ';
  $scope.customFullscreen = false;

  $scope.showAdvanced = function (ev) {
    $mdDialog.show({
      contentElement: '#myDialog',
      parent: document.body,
      targetEvent: ev,
      clickOutsideToClose: true
    })
  };

  $scope.address = {};
  $scope.complex = {};

  $scope.addComplex = function () {
    console.log("TEST");
    console.log($scope.complex.complexName);
    complexService.postComplex($scope.address, $scope.complex);
    $mdDialog.hide();
  }

  $scope.cancelOption = function () {
    $mdDialog.hide();
  }
}]);