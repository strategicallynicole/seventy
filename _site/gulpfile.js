const gulp    = require("gulp");
const sass    = require("gulp-sass");
const uglify  = require('gulp-uglify');
const concat  = require('gulp-concat');


var del = require('del');

// Task to delete target build folder
gulp.task('del', function() {
  return del(['./src/_includes/css/style.css']);
});


/*
  generate the css with sass
*/
gulp.task('css', function() {
  return gulp.src('src/assets/scss/style.scss')
    .pipe(sass({
      outputStyle: 'compressed'
    })
    .on('error', sass.logError))
    .pipe(gulp.dest('src/_includes/css'));
});


/*
 Uglify our javascript files into one.
 Use pump to expose errors more usefully.
*/

gulp.task('js', function() {
  return gulp.src("./src/_includes/js/**/*.js")
    .pipe(concat('main.js'))
    .pipe(uglify())
    .pipe(gulp.dest('./src/_includes/built'));
});




/*
  Watch folders for changess
*/
gulp.task("watch", function() {
  gulp.watch('./src/assets/scss/**/*.scss', gulp.parallel('css'));
  gulp.watch('./src/_includes/js/**/*.js', gulp.parallel('js'));
});


/*
  Let's build this sucker.
*/
gulp.task('build', gulp.parallel(
    'del',
    'css',
    'js', 
    'watch'
));