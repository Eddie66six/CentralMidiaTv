(function () {
    'use strict';

    angular.module('app', [
        'ngMessages',
        'ngCookies',
	    'ui.router',
	    'ui.bootstrap',
	    'oc.lazyLoad',
	    'xenon.controllers',
	    'xenon.directives',
	    'xenon.factory',
	    'xenon.services',

	    // Added in v1.3
	    'FBAngular'
    ]);
})();