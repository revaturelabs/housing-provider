import * as ng from 'angular';

import 'file-loader?name=[name].[ext]&outputPath=complex/!./template.html'

var complex = ng.module('providerComplex', []);

export { complex }; 