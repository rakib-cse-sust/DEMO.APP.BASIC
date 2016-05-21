var accountApp = angular.module('accountApp', ['ui.router'])
.config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.otherwise('/signin');

    $stateProvider
    .state('signin', {
        url: '/signin',
        templateUrl: '/Modules/Account/angular/partials/partial-signin.html'
    })
    .state('registration', {
        url: "/registration",
        templateUrl: '/Modules/Account/angular/partials/partial-registration.html'
    });
}]);