/**
 * Created by oanhnguyen on 16/06/2014.
 */
var _ = require('C:/Users/oanhnguyen/AppData/Roaming/npm/node_modules/underscore');
module.exports={
    name:"base",
    extend: function (child) {
        return _.extend({},this,child); //copy properties of child
    },
    run:function(req,res, next){

    }
};