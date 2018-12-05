// Required packages
var gulp = require('gulp');
var sass = require('gulp-sass');
var bower = require('gulp-bower');
var sourcemaps = require('gulp-sourcemaps');
var concat = require('gulp-concat');
var rename = require('gulp-rename');
var uglify = require('gulp-uglify');
var cssmin = require('gulp-cssmin');
var imagemin = require('gulp-imagemin');
var refresh = require('gulp-refresh');
var livereload = require('gulp-livereload');

// Live-reloading with Browser Sync
var browserSync = require('browser-sync').create();

/**
 * ************************************************************
 * Configuration
 */
var config = {
    sassPath: './Resources/sass',
    jsPath: './Resources/js',
    imgPath: './Resources/img',
    bowerDir: './Resources/lib',
    publicDir: './wwwroot'
};

/**
 * ************************************************************
 * Dependencies
 */

// Ensure that all bower dependencies are downloaded
gulp.task('bower', function() {
    return bower()
        .pipe(gulp.dest(config.bowerDir))
});

/**
 * ************************************************************
 * Compiling + Concatening tasks
 */

// Render font-awesome dependencies
gulp.task('compile-icons', function() {
    return gulp.src(config.bowerDir + '/font-awesome/fonts/**.*')
        .pipe(gulp.dest(config.publicDir + '/fonts'));
});

// Compile all styling dependencies and custom styling
gulp.task('compile-css', function() {
    return gulp.src(config.sassPath + '/site.scss')
        .pipe(sourcemaps.init())
        .pipe(sass.sync({
            outputStyle: 'expanded',
            precision: 10,
            includePaths: ['.']
        }).on('error', sass.logError))
        .pipe(sourcemaps.write('.'))
        .pipe(gulp.dest(config.publicDir + '/css'));
});

// Compile all JavaScript files into a single one
gulp.task('compile-js', function() {

    // Get list of JavaScript source files, in order, in an array.
    var distFiles = [
        'jquery/dist/jquery.js',
        'material-design-lite/material.js',
        'slick-carousel/slick/slick.js',
        'mdl-select-component/src/selectfield/selectfield.js'
    ];

    // Add the full path to the source files
    distFiles.forEach(function(value, index) {
        distFiles[index] = config.bowerDir + '/' + distFiles[index];
    });

    // Add the site.js file
    distFiles.push('./Resources/js/site.js');

    // Put into pipe stream
    return gulp.src(distFiles)
        .pipe(sourcemaps.init())
        .pipe(concat('site.js'))
        .pipe(sourcemaps.write('.'))
        .pipe(gulp.dest(config.publicDir + '/js'));
});

// Minify css + js files
gulp.task('compile', ['compile-icons', 'compile-css', 'compile-js']);

/**
 * ************************************************************
 * Minify/Uglify tasks
 */

// Minify all css files
gulp.task('min-css', ['compile'], function() {
    return gulp.src(config.publicDir + '/css/*.css')
        .pipe(sourcemaps.init())
        .pipe(cssmin())
        .pipe(concat('site.min.css'))
        .pipe(sourcemaps.write('.'))
        .pipe(gulp.dest(config.publicDir + '/css/',{overwrite: true}));
});

// Minify all js file
gulp.task('min-js', ['compile'], function() {
    return gulp.src(config.publicDir + '/js/*.js')
        .pipe(sourcemaps.init())
        .pipe(uglify())
        .pipe(concat('site.min.js'))
        .pipe(sourcemaps.write('.'))
        .pipe(gulp.dest(config.publicDir + '/js/'));
});

// Minify all img files
gulp.task('min-img', function() {
    return gulp.src(config.imgPath + '/*')
        .pipe(imagemin())
        .pipe(gulp.dest(config.publicDir + '/images/'));
});

// Minify css + js files
gulp.task('min', ['min-css', 'min-js', 'min-img']);

/**
 * ************************************************************
 * Command Line Tasks
 */

// Watch for file changes and run tasks when a file changes
gulp.task('watch', function() {
    gulp.watch(config.sassPath + '/**/*.scss');
});

// Gulp Task Runners
gulp.task('build', ['bower', 'compile', 'min']);
gulp.task('render', ['bower', 'compile']);

gulp.task('sass', function() {
    return gulp.src('./Resources/sass/**/*.scss')
        .pipe(sass().on('error', sass.logError))
        .pipe(gulp.dest(config.publicDir + '/css'))
        .pipe(livereload())
        .pipe(browserSync.stream({match: './wwwroot/css/*.css'}));
});

gulp.task('watch', ['browserSync','sass'], function (){
    livereload.listen({ start: true });
    
    gulp.watch('./Resources/sass/**/*.scss', ['sass']);
    // Reloads the browser whenever HTML or JS files change
    gulp.watch('.Views/**/*.cshtml', browserSync.reload);
    gulp.watch('.Resources/js/*.js', browserSync.reload);
    gulp.watch('./wwwroot/css/*.css', browserSync.reload);
    gulp.watch('.Resources/sass/**/*.scss', ['sass']).on('change', browserSync.reload);
});

gulp.task('browserSync', function() {
    browserSync.init({
        server: {
            baseDir: 'WebSecurity',
            open: 'external',
            host: 'project.dev',
            proxy: 'project.dev' // or project.dev/app/
        },
        port: 5000
    })
});

// Default runner
gulp.task('default', ['build']);