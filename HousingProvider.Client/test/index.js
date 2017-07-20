var includestuff = require('file-loader');
var unitTestSuite3 = require.context(".", true, /\.spec.js$/);
unitTestSuite3.keys().forEach(unitTestSuite3);
