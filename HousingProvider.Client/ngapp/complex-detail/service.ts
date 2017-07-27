import { complexDetail } from './module';

complexDetail.factory('complexDetailService', ['$http', function($http) {
  return {
    getApartments: function(guid) {
      $http.get('http://housingproviderbusiness.azurewebsites.net/api/property/' + guid).then(function (res) {

      });
    }
  }
}]);