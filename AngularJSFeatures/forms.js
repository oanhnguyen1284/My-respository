/**
 * Created by oanhnguyen on 6/5/2014.
 */
var myApp = angular.module('myApp',[]);


/*function Controller($scope){
    $scope.master={};
    
    $scope.update= function (user) {
        $scope.master = angular.copy(user);
    }

    $scope.reset=function(){
        $scope.user = angular.copy($scope.master);
    }

    $scope.isUnchanged= function (user) {
        return angular.equals(user, $scope.master)
    }
    $scope.reset();
}*/

var INTEGER_REGEXP = /^\-?\d+$/;

myApp.directive('integer', function() {
    return {
        require: 'ngModel',
        link: function(scope, elm, attrs, ctrl) {
            ctrl.$parsers.unshift(function(viewValue) {
                if (INTEGER_REGEXP.test(viewValue)) {
// it is valid
                    ctrl.$setValidity('integer', true);
                    return viewValue;
                } else {
// it is invalid, return undefined (no model update)
                    ctrl.$setValidity('integer', false);
                    return undefined;
                }
            });
        }
    };
});

var FLOAT_REGEXP = /^\-?\d+((\.|\,)\d+)?$/;

myApp.directive('smartFloat',function(){
    return{
        require:'ngModel',
        link:function(scope,elm,attrs,ctrl){
            ctrl.$parsers.unshift(function(viewValue){
                if(FLOAT_REGEXP.test(viewValue)){
                    ctrl.$setValidity('float',true);
                    return parseFloat(viewValue.replace(',', '.'));
                }else{
                    ctrl.$setValidity('float',false);
                    return undefined;
                }
            })
        }
    };
});

myApp.directive('contentEditable',function(){
    return {
        require:'ngModel',
        link:function(scope, elm, attrs, ctrl){
            // view -> model
            elm.on('blur',function(){
                scope.$apply(function(){
                    ctrl.$setValidity(elm.html());
                });
            });
            // model -> view
            ctrl.$render=function(){
                    elm.html(ctrl.$viewValue);
            };
            // load init value from DOM
            ctrl.$setViewValue(elm.html());
        }
    };
});


function Controller($scope){
    $scope.naomi = { name: 'Naomi', address: '1600 Amphitheatre' };
    $scope.igor = { name: 'Igor', address: '123 Somewhere' };
}

myApp.directive('myCustomer', function() {
    return {
        restrict: 'E',
        scope:{
            customerInfo: '=info'
        },
        templateUrl: 'my-customer-template.html'
    };
});

function DateTimeController($scope){
    $scope.format='M/d/yy h:mm:ss a';
}

myApp.directive("myCurrentTime",function($interval, dateFilter){
    function link (scope, element, attrs) {
        var format, timeoutId;
        function updateTime(){
            element.text(dateFilter(new Date(), format));
        }

        scope.$watch(attrs.myCurrentTime,function(value){
            format = value;
            updateTime();
        })

        element.on('$destroy', function() {
            $interval.cancel(timeoutId);
        });

        // start the UI update process; save the timeoutId for canceling
        timeoutId = $interval(function() {
            updateTime(); // update DOM
        }, 1000);
    }
    return {
        link: link
    };
});

myApp.directive("enter", function(){
    return function(scope, element, attrs) {
        element.bind("mouseenter", function(){
            element.addClass(attrs.enter);
        })
    }
});

myApp.directive("leave", function(){
    return function(scope, element, attrs) {
        element.bind("mouseleave", function(){
            element.removeClass(attrs.enter);
        })
    }
});