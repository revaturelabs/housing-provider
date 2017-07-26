import { home } from './module';
import 'file-loader?name=[name].[ext]&outputPath=home/!./template.html'

home.controller('homeController', ['$scope', function ($scope) {
  $scope.signin = function () {

  };

  $scope.signout = function () {

  };
}]);
