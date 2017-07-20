var fn = require('../jsbin/index.js');
// var ng1 = require('angular');
var ng2 = require('angular-mocks');

describe('the test controller', function () {
  var controller, httpbackend, scope = {};

  beforeEach(angular.mock.module('ngApp'));

  beforeEach(inject(function (_$controller_, _$httpBackend_) {
    controller = _$controller_('TestController', { $scope: scope });
    httpbackend = _$httpBackend_;
  }));

  it('should have something', function () {
    expect(scope.something).toEqual('hello mock');
  });

  it('should sum 2 numbers', function () {
    expect(scope.addNumbers(1,2)).toEqual(3);
  });

  it('should do ajax', function () {
    httpbackend.expectGET('/someurl').respond('booyeah!');
    scope.seeYouLater();
    httpbackend.flush();
    expect(scope.success.data).toBe('booyeah!');
  });
});