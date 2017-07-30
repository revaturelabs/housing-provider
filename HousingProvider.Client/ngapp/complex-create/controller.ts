import { createComplex } from './module';
import './service';

createComplex.controller('createComplexController', ['$http', '$scope', 'createComplexService', function($http, $scope, createComplexService) {
    $scope.address = {};
    $scope.complex = {};

    $scope.addComplex = function () {
        createComplexService.postComplex($scope.address, $scope.complex);
    }
}]);