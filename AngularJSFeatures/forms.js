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

function Wraps($scope){
    $scope.name = 'Tobias';
    $scope.hideDialog=function(){
        $scope.dialogIsHidden = true;
        $timeout(function(){
            $scope.dialogIsHidden = false;
        }, 2000);
    }
}
myApp.directive("myDialog",function(){
    return {
        restrict:'E',
        transclude:true,
        scope:{
            'close': '&onClose'
        },
        templateUrl:'my-dialog.html'
    }
})

myApp.directive("myTabs", function () {
    return {
        restrict: 'E',
        transclude: true,
        scope: {},
        controller: function($scope) {
            var panes = $scope.panes = [];

            $scope.select = function(pane) {
                angular.forEach(panes, function(pane) {
                    pane.selected = false;
                });
                pane.selected = true;
            };

            this.addPane = function(pane) {
                if (panes.length === 0) {
                    $scope.select(pane);
                }
                panes.push(pane);
            };
        },
        templateUrl: 'my-tabs.html'
    };
});

myApp.directive("myPane",function(){
    return {
        require: '^myTabs',
        restrict: 'E',
        transclude: true,
        scope: {
            title: '@'
        },
        link: function(scope, element, attrs, tabsCtrl) {
            tabsCtrl.addPane(scope);
        },
        templateUrl: 'my-panel.html'
    };
});

function EventController ($scope) {
    $scope.count =0;
    $scope.$on('MyEvent',function(){
        $scope.count++;
    })
}