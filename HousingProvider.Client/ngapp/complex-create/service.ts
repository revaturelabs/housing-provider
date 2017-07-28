import { createComplex } from './module';

createComplex.factory('createComplexService', ['$http', function($http) {
  return {
    postAddress: function (adr, complex) {
      $http.post('http://housingproviderbusiness.azurewebsites.net/api/address', adr).then(function (res) {
        complex.addressGuid = res.data;
        $http.post('http://housingproviderbusiness.azurewebsites.net/api/complex', complex).then(function (res) {
          console.log(res);
        }, function (err) {
          console.log(err);
        });
      }, function (err) {
        console.log(err);
      });
    }
  };
}]);