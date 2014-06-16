/* GET home page. */
exports.index = function(req, res){
   // res.render('index', { title: 'Express' });
    res.writeHead(200, {"Content-Type": "text/plain"});
    res.write("Hello World");
    res.end();

};
