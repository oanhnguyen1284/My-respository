/**
 * Created by oanhnguyen on 6/16/2014.
 */
module.exports =function(respone,template){
    this.repsone = respone;
    this.template = template;
};
module.exports.prototype= {
    extend:function(properties){
        var Child = module.exports;
        Child.prototype = module.exports.prototype;
        for(var key in properties){
            Child.prototype[key]=properties[key];
        }
        return Child;
    },
    render:function(data){
        if(this.response && this.template){
            this.repsone.render(this.template,data);
        }
    }
}