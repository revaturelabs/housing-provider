"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var module_1 = require("./module");
require("./service");
var Request = (function () {
    function Request() {
        this.sender = "no one";
        this.address = "404 nobody ln, apt. 404, nowhere, N/A, 50404";
        this.description = "";
        this.dateCreated = Date.now();
        this.urgent = true;
    }
    return Request;
}());
module_1.home.controller('homeController', ['$scope', 'homeFactory', function ($scope, homeFactory) {
    }]);
