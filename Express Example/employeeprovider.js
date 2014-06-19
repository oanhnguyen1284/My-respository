/**
 * Created by oanhnguyen on 6/19/2014.
 */
var Db = require('mongodb').Db;
var Connection  = require('mongodb').Connection;
var Server = require('mongodb').Server;
var BSON = require('mongodb').BSON;
var ObjectID = require('mongodb').ObjectID;

EmployeeProvider =function(host,port){
    this.db= new Db('node-mongo-employee', new Server(host, port, {safe: false}, {auto_reconnect: true}, {}));
    this.db.open(function(){});
}

EmployeeProvider.prototype.getCollection=function(callback){
    this.db.collection("employees", function (error, employee_collection) {
        if(error) callback(error);
        else callback(null,employee_collection);
    })
};

EmployeeProvider.prototype.findAll=function(callback){
    this.getCollection(function (error, employee_collection) {
        if(error) callback(error);
        else{
            employee_collection.find().toArray(function(error, results) {
                if (error) callback(error);
                else callback(null, results);
            });
        }
        });

};

EmployeeProvider.prototype.findById=function(id,callback){
    this.getCollection(function(error, employee_collection){
        if(error) callback(error)
        else {
            employee_collection.findOne({_id:employee_collection.db.bson_serializer.ObjectID.createFromHexString(id)},function(error,results){
                if(error) callback(error);
                else callback(null,results);
            })
        }
    });
}

EmployeeProvider.prototype.save = function(employees,callback){
   this.getCollection(function(error,employee_collection){
       if(error) callback(error);
       else{
           if(typeof(employees.length)=="undefined")
               employees = [employees];
           for( var i =0;i< employees.length;i++ ) {
               employee = employees[i];
               employee.created_at = new Date();
           }
       }
   })
}

