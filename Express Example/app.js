var express = require('express');
var http = require('http');
var path = require('path');
var favicon = require('static-favicon');
var logger = require('morgan');
var cookieParser = require('cookie-parser');
var bodyParser = require('body-parser');
var fs = require('fs');
var routes = require('./routes');
var users = require('./routes/user');
var config = require('./config')(),
    MongoClient = require('mongodb').MongoClient,
    Admin = require('./controllers/Admin'),
    Home = require('./controllers/Home'),
    Blog = require('./controllers/Blog'),
    Page = require('./controllers/Page');

var app = express();


// view engine setup
app.set('port',process.env.PORT ||3000);
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'jade');

app.use(favicon());
app.use(logger('dev'));
app.use(bodyParser.json());
app.use(bodyParser.urlencoded());
app.use(cookieParser());
app.use(express.static(path.join(__dirname, 'public')));
app.use(app.router);
app.use(express.cookieParser('fast-delivery-site'));

// development only
if ('development' == app.get('env')) {
    app.use(express.errorHandler());
}
//app.get('/', routes.index);
//app.get('/users', users.list);
//users.init();

MongoClient.connect('mongodb://' + config.mongo.host + ':' + config.mongo.port + '/fastdelivery', function(err, db) {

if(err) {
        console.log('Sorry, there is no mongo db server running.');
    } else {
        var attachDB = function (req,res,next) {
            req.db= db;
            next();
        }

        http.createServer(app).listen(config.port, function() {
            console.log(
                    'Successfully connected to mongodb://' + config.mongo.host + ':' + config.mongo.port,
                    '\nExpress server listening on port ' + config.port
            );
        });
    }
})
http.createServer(app).listen(app.get('port'),function(){
     console.log('Express server listening on port '+ app.get('port'));

});


/// catch 404 and forwarding to error handler
app.use(function(req, res, next) {
    var err = new Error('Not Found');
    err.status = 404;
    next(err);
});

/// error handlers

// development error handler
// will print stacktrace
if (app.get('env') === 'development') {
    app.use(function(err, req, res, next) {
        res.render('error', {
            message: err.message,
            error: err
        });
    });
}

// production error handler
// no stacktraces leaked to user
app.use(function(err, req, res, next) {
    res.render('error', {
        message: err.message,
        error: {}
    });
});


module.exports = app;
