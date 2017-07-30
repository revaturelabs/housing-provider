import { complex } from './module';

complex.factory('complexService', ['$http', '$location', function ($http, $location) {
  return {
    getComplexes: function(scope) {
      $http.get('http://housingproviderbusiness.azurewebsites.net/api/complex').then(function (res) {
        scope.complexes = res.data;
        scope.orderProp = 'complexName';
      });
    },
    postComplex: function (adr, complex) {
      $http.post('http://housingproviderbusiness.azurewebsites.net/api/address', adr).then(function (res) {
        complex.addressGuid = res.data;
        $http.post('http://housingproviderbusiness.azurewebsites.net/api/complex', complex).then(function (res) {
          $location.path('/complex');
        }, function (err) {
          console.log(err);
        });
      }, function (err) {
        console.log(err);
      });
    }
  }
}]);

// export { complexService };