import { home } from './module';

home.controller('homeController', ['$scope', 'adalAuthenticationService', function ($scope, adalAuthenticationService) {
  $scope.signin = function () {
    adalAuthenticationService.login();
  };

  $scope.signout = function () {
    adalAuthenticationService.logOut();
  };
}]);
