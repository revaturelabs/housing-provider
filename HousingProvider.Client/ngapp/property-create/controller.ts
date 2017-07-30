import { createProperty } from './module';
import './service';

createProperty.controller('createPropertyController', ['$scope', '$routeParams', 'createPropertyService', function($scope, $routeParams, createPropertyService) {
    $scope.complexName = $routeParams.complexName;
    $scope.address = {};
    $scope.property = {
        complexGuid: $routeParams.guid
    };

    $scope.addProperty = function () {
        createPropertyService.postProperty($scope.address, $scope.property, $routeParams.complexName, $routeParams.guid);
    }
}]);