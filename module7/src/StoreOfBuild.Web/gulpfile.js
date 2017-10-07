
var gulp = require('gulp'); // yearn add gulp
var concat = require('gulp-concat');// yearn add gulp-concat
var cssmin = require('gulp-cssmin');// yearn add gulp-cssmin
var uncss = require('gulp-uncss'); //  year add gulp-uncss
var browserSync = require('browser-sync').create(); //  browser sync - utilzado para nao dar refessh na tela 

gulp.task('browser-sync', function(){
    browserSync.init({
        proxy: 'localhost:5000'
    });
    gulp.watch('./Styles/*.css', ['css'])
    gulp.watch('./js/*.js', ['js'])
    
    
});


    //adiciona os scripts na pasta js

gulp.task('js', function(){

    return gulp.src( [
        './node_modules/bootstrap/dist/js/bootstrap.min.js',
        './node_modules/jquery/dist/jquery.min.js',
        './node_modules/jquery-validation/dist/jquery.min.js',
        './node_modules/jquery.validate.unobtrusive/jquery.validate.unobtrusive.js',
        './js/site.js'
        ])
        .pipe(gulp.dest('wwwroot/js/'))
       .pipe(browserSync.stream()); //liga o browser sync
    
});
//task css responsável por  adicionar os css na pasta css
//concatenar todas as css
//e remover os css náo usados
gulp.task('css', function(){

    return gulp.src( [
        './Styles/site.css',
        './node_modules/bootstrap/dist/css/bootstrap.css'
    ])
    .pipe(concat('site.min.css')) //concatena
    .pipe(cssmin())//reduz
    .pipe(uncss({html: ['Views/**/*.cshtml']}))//retira css nao usado
    .pipe(gulp.dest('wwwroot/css/'))//copia para a psta css
    .pipe(browserSync.stream()); //liga o browser sync

});


//Adiciona a task watch 
gulp.task('watch-css', function(){
    //toda vez que a pasta sofrer alguma alteraçao nos arquivos css 
    //adiciona chama a task css
    gulp.watch('./Styles/**/*.css', ['css'])
});