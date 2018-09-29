var app = angular.module('mvcSpaAngularApp', [
	'ui.bootstrap',
	'ui.router'
]);

app.config(['$stateProvider', '$urlRouterProvider', '$locationProvider', function ($stateProvider, $urlRouterProvider, $locationProvider) {
	$locationProvider.html5Mode(true);
	$urlRouterProvider.otherwise('/');

	$stateProvider
		//.state('home', {
		//	url: '/',
		//	views: {
		//		'header': {
		//			templateUrl: '/templates/partials/header.html'
		//		},
		//		'content': {
		//			templateUrl: '/templates/partials/content.html'
		//		},
		//		'footer': {
		//			templateUrl: '/templates/partials/footer.html'
		//		}
		//	}
		//})
		.state('home', {
			url: '/',
			templateUrl: 'app/pages/home.html',
			controller: 'homeController'
		})
		.state('login', {
			url: '/account/login',
			templateUrl: 'app/pages/account/login.html',
			controller: 'loginController'
		});

}]);