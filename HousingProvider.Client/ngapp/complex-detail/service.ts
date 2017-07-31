import { complexDetail } from './module';

complexDetail.factory('complexDetailService', ['$http', function ($http) {
  return {
    getApartments: function (scope, guid) {
      $http.get('http://housingproviderbusiness.azurewebsites.net/api/property/' + guid).then(function (res) {
        scope.apartments = res.data;
      });
    },
    postProperty: function (adr, property, complexName, guid, scope) {
      $http.post('http://housingproviderbusiness.azurewebsites.net/api/address', adr)
        .then(function (res) {
          property.addressGuid = res.data;
          $http.post('http://housingproviderbusiness.azurewebsites.net/api/property', property)
            .then(function (res) {
              property.address = adr;
              scope.apartments.push(property);
              scope.cancelOption();
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