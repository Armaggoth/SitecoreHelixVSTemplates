const testFolder = './app/partials/';
const fs = require('fs');
const path = require('path');

let exec = require('child_process').exec,
child;

const PARTIAL_EXTENSION = 'html';
const MARKUP_DESTINATION = 'markup/';
const HTML_PARTIAL_COMMAND = './node_modules/.bin/html-partials-compiler ';

function errorExec(error, stdout, stderr) {
  if (error !== null) {
    console.log('exec error: ' + error);
  }
}

function getExtension(filename) {
  let ext = path.extname(filename||'').split('.');
  return ext[ext.length - 1];
}

fs.readdir(testFolder, (err, files) => {
  files.forEach(file => {
    let extension = getExtension(file);
    if(extension && extension === PARTIAL_EXTENSION){
      child = exec(HTML_PARTIAL_COMMAND + testFolder + file + ' > ' + MARKUP_DESTINATION + file, errorExec);
    }
  });
});
