import { complex } from './module';

complex.factory('complexService', ['$http', '$location', function ($http, $location) {
  return {
    getComplexes: function(scope) {
      $http.get('http://housingproviderbusiness.azurewebsites.net/api/complex').then(function (res) {
        scope.complexes = res.data;
        scope.orderProp = 'complexName';
      });
    },
    postComplex: function (adr, complex, scope) {
      $http.post('http://housingproviderbusiness.azurewebsites.net/api/address', adr)
      .then(function (res) {
        complex.addressGuid = res.data;
        $http.post('http://housingproviderbusiness.azurewebsites.net/api/complex', complex)
        .then(function (res) {
          complex.guid = res.data;
          complex.address = adr;
          scope.complexes.push(complex);
          scope.cancelOption();
          scope.complex = {};
          scope.address = {};
        }, function (err) {
          console.log(err);
        });
      }, function (err) {
        console.log(err);
      });
    }
  }
}]);
