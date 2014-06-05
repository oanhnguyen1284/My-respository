/**
 * Created by oanhnguyen on 6/4/2014.
 */

var myApp = angular.module('myApp',[]);


function FilterController(filterFilter){
    this.array =[
        {name: 'Tobias'},
        {name: 'Jeff'},
        {name: 'Brian'},
        {name: 'Igor'},
        {name: 'James'},
        {name: 'Brad'}
    ];
    this.filteredArray = filterFilter(this.array, 'a');
}

myApp.filter('reverse',function(){
       return function(input,uppercase){
           var out = "";
           for(var i=0;i <input.length;i++){
               out = input.charAt(i) + out;
           }

           // conditional based on optional argument
           if(uppercase){
               out = out.toUpperCase();
           }
           return out;
       }
});

function Ctrl($scope){
    $scope.greeting ='Hello';
}

function Cntl2($scope){
    var exprs = $scope.exprs = [];
    $scope.expr = '3*10|currency';
    $scope.addExp = function(expr) {
        exprs.push(expr);
    }

    $scope.removeExp=function(index){
        exprs.splice(index,1);
    }
}