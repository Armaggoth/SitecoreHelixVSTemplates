var os = require('os');
var hostname = os.hostname();

//Checks if it's a local environment
// otherwise zip file task won't be executed
if(hostname.indexOf('local') == -1) {
  console.log('we are not in local environment. hostname: ' + hostname);
}

console.log('building node modules zip file...');

var fs = require('fs');
var archiver = require('archiver');

var output = fs.createWriteStream(__dirname + '/../../lib/node_modules.zip');
var archive = archiver('zip');

output.on('close', function() {
  console.log(archive.pointer() + ' total bytes');
  console.log('zip file generated.');
});

archive.on('error', function(err) {
  throw err;
});

archive.pipe(output);

// append files from a directory
archive.directory('node_modules/');

archive.finalize();
