import { createProperty } from './module';

createProperty.factory('createPropertyService', ['$http', '$location', function($http, $location) {
  return {
    postProperty: function (adr, property, complexName, guid) {
      $http.post('http://housingproviderbusiness.azurewebsites.net/api/address', adr).then(function (res) {
        property.addressGuid = res.data;
        $http.post('http://housingproviderbusiness.azurewebsites.net/api/property', property).then(function (res) {
          $location.path('/complexdetail/' + complexName + '/' + guid);
        }, function (err) {
          console.log(err);
        });
      }, function (err) {
        console.log(err);
      });
    }
  };
}]);