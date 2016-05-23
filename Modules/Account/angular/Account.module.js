var accountApp = angular.module('accountApp', ['ui.router'])
.config(['$stateProvider', '$urlRouterProvider', '$locationProvider', function ($stateProvider, $urlRouterProvider, $locationProvider) {

    $locationProvider.html5Mode(true);
    $urlRouterProvider.otherwise('/signin');

    $stateProvider
    .state('signin', {  
        url: '/', //url: '/signin',
        templateUrl: 'Modules/Account/angular/partials/partial-signin.html'
    })
    .state('registration', {
        url: "/registration",
        templateUrl: 'Modules/Account/angular/partials/partial-registration.html'
    });
}]);