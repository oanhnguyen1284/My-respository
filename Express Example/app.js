var express = require('express'),
    http = require('http'),
    path = require('path'),
    config = require('./config')(),
    app = express();
//    MongoClient = require('mongodb').MongoClient,
//    Admin = require('./controllers/Admin'),
//    Home = require('./controllers/Home'),
//    Blog = require('./controllers/Blog'),
//    Page = require('./controllers/Page');
var routes = require('./routes');
var users = require('./routes/user');
var EmployeeProvider = require('./employeeprovider').EmployeeProvider;

// all environments
// app.set('port', process.env.PORT || 3000);
app.set('views', __dirname + '/views');
app.set('view engine', 'jade');
app.use(express.favicon());
app.use(express.logger('dev'));
app.use(express.bodyParser());
app.use(express.methodOverride());
app.use(express.cookieParser('fast-delivery-site'));
app.use(express.session());
app.use(app.router);
//app.use(require('stylus').middleware(__dirname + '/public'));
app.use(express.static(path.join(__dirname, 'public')));

// development only
if ('development' == app.get('env')) {
    app.use(express.errorHandler());
}

var employeeProvider = new EmployeeProvider('localhost',27017);

//routes

app.get('/',function(req,res){
    employeeProvider.findAll(function(error,emps){
        res.render('index',{
            title:"Employees",
            employees:emps
        });
    })
});

app.get('/employee/new', function (req,res) {
    res.render('employee_new',{
        title:"New Employee"
    });
});

app.post('/employee/new', function (req,res){
    employeeProvider.save({
        title:req.param("title"),
        name:req.param("name")
    },function(error,docs){
        res.redirect("/");
    });

});


app.listen(3000);
//MongoClient.connect('mongodb://' + config.mongo.host + ':' + config.mongo.port + '/fastdelivery', function(err, db) {
//    if(err) {
//        console.log('Sorry, there is no mongo db server running.');
//    } else {
//        var attachDB = function(req, res, next) {
//            req.db = db;
//            next();
//        };
//        app.all('/admin*', attachDB, function(req, res, next) {
//            Admin.run(req, res, next);
//        });
//        app.all('/blog/:id', attachDB, function(req, res, next) {
//            Blog.runArticle(req, res, next);
//        });
//        app.all('/blog', attachDB, function(req, res, next) {
//            Blog.run(req, res, next);
//        });
//        app.all('/services', attachDB, function(req, res, next) {
//            Page.run('services', req, res, next);
//        });
//        app.all('/careers', attachDB, function(req, res, next) {
//            Page.run('careers', req, res, next);
//        });
//        app.all('/contacts', attachDB, function(req, res, next) {
//            Page.run('contacts', req, res, next);
//        });
//        app.all('/', attachDB, function(req, res, next) {
//            Home.run(req, res, next);
//        });
//        http.createServer(app).listen(config.port, function() {
//            console.log(
//                    'Successfully connected to mongodb://' + config.mongo.host + ':' + config.mongo.port,
//                    '\nExpress server listening on port ' + config.port
//            );
//        });
//    }
//});