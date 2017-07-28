import { createComplex } from './module';
import './service';

createComplex.controller('createComplexController', ['$http', '$scope', '$routeParams', 'createComplexService', function($http, $scope, $routeParams, createComplexService) {
    $scope.address = {};
    $scope.complex = {};

    $scope.addComplex = function () {
        createComplexService.postAddress($scope.address, $scope.complex);
    }
}]);