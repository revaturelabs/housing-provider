import { complexDetail } from './module';

complexDetail.factory('complexDetailService', ['$http', function($http) {
  return {
    getComplex: function(scope, guid) {
      $http.get('http://housingproviderbusiness.azurewebsites.net/api/complex/' + guid).then(function (res) {
        scope.complex = res.data;
      });
    },
    getApartments: function(scope, guid) {
      $http.get('http://housingproviderbusiness.azurewebsites.net/api/property/' + guid).then(function (res) {
        scope.apartments = res.data;
      });
    },
    postProperty: function (adr, property, complexName, guid) {
      $http.post('http://housingproviderbusiness.azurewebsites.net/api/address', adr).then(function (res) {
        property.addressGuid = res.data;
        $http.post('http://housingproviderbusiness.azurewebsites.net/api/property', property).then(function (res) {
        }, function (err) {
          console.log(err);
        });
      }, function (err) {
        console.log(err);
      });
    }
  }
}]);