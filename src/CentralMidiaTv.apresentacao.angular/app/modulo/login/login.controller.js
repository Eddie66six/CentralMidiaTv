(function () {
    'use strict';

    angular.module('app').controller('loginCtrl', loginCtrl);

    loginCtrl.$inject = ['$scope', '$rootScope', '$state'];
    function loginCtrl($scope, $rootScope, $state) {
        $rootScope.isLoginPage = true;
        $rootScope.isLightLoginPage = false;
        $rootScope.isLockscreenPage = false;
        $rootScope.isMainPage = false;

        //funçoes
        $scope.login = function() {
            if (!$scope.formLogin.$valid)
                return;
            $state.go('app.dashboard-variant-1');
        }
    }
})();
