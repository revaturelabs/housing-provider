import { complex } from './module';

complex.factory('complexService', ['$http', function ($http) {
  return {
    getComplexes: function(scope) {
      $http.get('http://housingproviderbusiness.azurewebsites.net/api/complex').then(function (res) {
        scope.complexes = res.data;
        scope.orderProp = 'complexName';
      });
    }
  }
}]);

// export { complexService };