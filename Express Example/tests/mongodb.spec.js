/**
 * Created by oanhnguyen on 16/06/2014.
 */
describe('MongoDB',function(){
    it('is there server running',function(next){
        var mongoClient = require('mongodb').MongoClient;
        mongoClient.connect('mongodb://127.0.0.1:27017/fastdelivery',function(err,db){
            expect(err.toBe(null));
            expect(db).toBeDefined();
            next();
        })
    })
});
