var bundle = require('../public/js/script.bundle.js');
var mocks = require('angular-mocks');

describe("The complex service", function () {
    var service, httpbackend, scope = {};

    beforeEach(angular.mock.module('providerComplex'));

    beforeEach(inject(function (complexService, _$httpBackend_) {
        service = complexService;
        httpbackend = _$httpBackend_;
    }));

    var httpResponse = [
        { "complexName": "Westerly at WorldGate" },
        { "complexName": "The Townes at Herndon Center" }
    ];

    it('should get complexes', function () {
        httpbackend.expectGET('http://housingproviderbusiness.azurewebsites.net/api/complex').respond(httpResponse);
        service.getComplexes(scope);
        httpbackend.flush();
        expect(scope.complexes.length).toBe(2);
    });
})