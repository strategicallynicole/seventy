@import url("https://fonts.googleapis.com/css?family=Josefin+Sans&display=swap");
@import url("https://fonts.googleapis.com/css?family=Roboto+Slab&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Josefin+Sans:wght@100&family=Josefin+Sans:wght@300&display=swap");
#sidemenu {
  width: 7%;
  height: 80vh;
  position: absolute;
  top: 10%;
  align-items: center;
  left: 5%;
  z-index: 999;
  border-radius: 20px;
  box-shadow: -8px -16px 56px 0 rgba(108, 91, 167, 0.14), 52px 20px 88px 0 rgba(2, 3, 3, 0.5), inset -16px -6px 80px 0 rgba(248, 249, 249, 0.03);
  background: linear-gradient(96.28deg, #353A40 10.44%, #121416 95.94%);
  background-attachment: fixed; }

#menulogo {
  width: 90px;
  height: 80px;
  margin-top: 25px;
  margin-bottom: 75px; }

.menuitem-box {
  width: 62px;
  height: 52px;
  background: linear-gradient(327.43deg, #32383E -77.68%, #17191C 87.35%);
  box-shadow: 4px 4px 18px rgba(0, 0, 0, 0.4), -4px -2px 16px rgba(195, 200, 205, 0.05);
  border-radius: 16px;
  position: absolute;
  display: inline-block;
  top: 7%;
  left: 5.5%;
  z-index: 22;
  opacity: 1;
  transition: all ease-in 1s; }

.menuitem-box:hover {
  width: 62px;
  height: 52px;
  background: linear-gradient(327.43deg, #32383E -77.68%, #17191C 87.35%);
  box-shadow: 4px 4px 18px rgba(0, 0, 0, 0.4), -4px -2px 16px rgba(195, 200, 205, 0.05);
  border-radius: 16px;
  position: absolute;
  display: inline-block;
  top: 7%;
  left: 5.5%;
  z-index: 22;
  opacity: 0;
  transition: all ease-in 1s; }

.menuitem-box::after {
  box-shadow: inset 3px 3px 10px #0D0E0F, inset -3px -3px 10px #40464E !important;
  background: #6C5BA7 !important;
  border-radius: 15px;
  transition: all ease-in 1s;
  z-index: 9999;
  opacity: 0; }

.menuitem-box::after:hover {
  box-shadow: inset 3px 3px 10px #0D0E0F, inset -3px -3px 10px #40464E !important;
  background: #6C5BA7 !important;
  border-radius: 15px;
  transition: all ease-in 1s;
  z-index: 9999;
  opacity: 1; }

.menuitem-base {
  width: 70px;
  height: 60px;
  margin-top: 50px;
  margin-bottom: 50px;
  position: relative;
  display: block;
  /* #6C5BA7 */
  left: 13%;
  background: #6C5BA7;
  border-radius: 15px; }

@font-face {
  font-family: 'SignPainter';
  src: url("../fonts/SignPainter-HouseScript.eot");
  src: url("../fonts/SignPainter-HouseScript.eot?#iefix") format("embedded-opentype"), url("../fonts/SignPainter-HouseScript.woff2") format("woff2"), url("../fonts/SignPainter-HouseScript.woff") format("woff"), url("../fonts/SignPainter-HouseScript.ttf") format("truetype");
  font-weight: 400;
  font-style: normal; }
@font-face {
  font-family: 'Gasalt';
  src: url("../fonts/Gasalt-Black.eot");
  src: url("../fonts/Gasalt-Black.eot?#iefix") format("embedded-opentype"), url("../fonts/Gasalt-Black.woff2") format("woff2"), url("../fonts/Gasalt-Black.woff") format("woff"), url("../fonts/Gasalt-Black.ttf") format("truetype");
  font-weight: 900;
  font-style: normal; }
@font-face {
  font-family: 'Gasalt';
  src: url("../fonts/Gasalt-Regular.eot");
  src: url("../fonts/Gasalt-Regular.eot?#iefix") format("embedded-opentype"), url("../fonts/Gasalt-Regular.woff2") format("woff2"), url("../fonts/Gasalt-Regular.woff") format("woff"), url("../fonts/Gasalt-Regular.ttf") format("truetype");
  font-weight: normal;
  font-style: normal; }
.overflow-hidden {
  overflow: hidden; }

.content-title {
  color: #fff; }

#preloader {
  position: fixed;
  z-index: 999999;
  display: flex;
  background: #121212;
  height: 100vh;
  width: 100vw;
  align-items: center;
  justify-content: center;
  overflow: hidden; }

.preloader-wave {
  position: absolute;
  top: 50%;
  left: 50%;
  width: 60px;
  height: 60px;
  margin: -30px 0 0 -30px; }

.preloader-wave:before, .preloader-wave:after {
  position: absolute;
  display: inline-block;
  width: 60px;
  height: 60px;
  content: '';
  -webkit-animation: preloader-wave 1.6s linear infinite;
  animation: preloader-wave 1.6s linear infinite;
  border-radius: 50%;
  background: #6c5da7; }

.preloader-wave:after {
  -webkit-animation-delay: -0.8s;
  animation-delay: -0.8s; }

@-webkit-keyframes preloader-wave {
  0% {
    -webkit-transform: scale(0, 0);
    transform: scale(0, 0);
    opacity: 0.5; }
  100% {
    -webkit-transform: scale(1, 1);
    transform: scale(1, 1);
    opacity: 0; } }
@keyframes preloader-wave {
  0% {
    -webkit-transform: scale(0, 0);
    transform: scale(0, 0);
    opacity: 0.5; }
  100% {
    -webkit-transform: scale(1, 1);
    transform: scale(1, 1);
    opacity: 0; } }
@font-face {
  font-family: 'AviatorSG';
  src: url("../fonts/");
  src: url("../fonts/?#iefix") format("embedded-opentype"), url("../fonts/AviatorSG-Light.woff2") format("woff2"), url("../fonts/AviatorSG-Light.woff") format("woff"), url("../fonts/AviatorSG-Light.ttf") format("truetype");
  font-weight: 300;
  font-style: normal; }
html {
  height: 100%; }

body {
  font-family: 'Josefin Sans', sans-serif;
  height: 100%;
  background-image: linear-gradient(to top, #212121, #121212);
  background-attachment: fixed; }

a:active, a:focus, input, select, textarea {
  outline: none !important; }

img {
  max-width: 100%; }

a, .container {
  text-decoration: none !important;
  transition: all 0.5s; }

.btn, button {
  -webkit-transition: all 0.5s ease;
  -moz-transition: all 0.5s ease;
  transition: all 0.5s ease; }

a:focus, button:focus {
  outline: 0; }

ul {
  margin: 0;
  padding: 0;
  list-style: none; }

select {
  -moz-appearance: none;
  -webkit-appearance: none;
  -ms-appearance: none;
  appearance: none; }

h1, h2, h3, h4, h5, h6 {
  margin: 0;
  color: #fff;
  line-height: 1.5;
  margin-bottom: 15px;
  font-family: "Playfair Display",serif; }

h1 {
  font-size: 40px; }

h2 {
  font-size: 36px; }

h3 {
  font-size: 30px; }

h4 {
  font-size: 24px; }

h5 {
  font-size: 22px; }

h6 {
  font-size: 18px; }

p {
  margin-bottom: 10px;
  color: #d4d3d3;
  line-height: 1.8;
  font-size: 16px;
  font-family: "Muli",sans-serif; }

a {
  color: #6c5da7; }

a:hover {
  opacity: 0.7;
  color: #6c5da7; }

.go-top {
  display: none; }

.go-top #top {
  background: rgba(255, 255, 255, 0.1);
  height: 60px;
  width: 60px;
  border-radius: 50%;
  display: flex;
  justify-content: center;
  align-items: center;
  color: #fff;
  position: fixed;
  bottom: 30px;
  right: 60px;
  z-index: 911;
  cursor: pointer; }

.go-top #top:hover {
  background-color: #6c5da7; }

@media screen and (max-width: 767px) {
  h1 {
    font-size: 36px; }

  h2 {
    font-size: 30px; }

  h3 {
    font-size: 24px; }

  h4 {
    font-size: 22px; }

  h5 {
    font-size: 20px; }

  h6 {
    font-size: 16px; }

  p {
    font-size: 16px; } }
.m-top-0 {
  margin-top: 0px; }

.m-top-1 {
  margin-top: 5px; }

.m-top-2 {
  margin-top: 10px; }

.m-top-3 {
  margin-top: 15px; }

.m-top-4 {
  margin-top: 20px; }

.m-top-5 {
  margin-top: 25px; }

.m-top-6 {
  margin-top: 30px; }

.m-top-7 {
  margin-top: 35px; }

.m-top-8 {
  margin-top: 40px; }

.m-top-9 {
  margin-top: 45px; }

.m-top-10 {
  margin-top: 50px; }

.m-top-11 {
  margin-top: 55px; }

.m-top-12 {
  margin-top: 60px; }

.m-top-13 {
  margin-top: 65px; }

.m-top-14 {
  margin-top: 70px; }

.m-top-15 {
  margin-top: 75px; }

.m-top-16 {
  margin-top: 80px; }

.m-top-17 {
  margin-top: 85px; }

.m-top-18 {
  margin-top: 90px; }

.m-top-19 {
  margin-top: 95px; }

.m-top-20 {
  margin-top: 100px; }

.m-top-21 {
  margin-top: 105px; }

.m-top-22 {
  margin-top: 110px; }

.m-top-23 {
  margin-top: 115px; }

.m-top-24 {
  margin-top: 120px; }

.m-top-25 {
  margin-top: 125px; }

.m-top-26 {
  margin-top: 130px; }

.m-top-27 {
  margin-top: 135px; }

.m-top-28 {
  margin-top: 140px; }

.m-top-29 {
  margin-top: 145px; }

.m-bot-0 {
  margin-bottom: 0px; }

.m-bot-1 {
  margin-bottom: 5px; }

.m-bot-2 {
  margin-bottom: 10px; }

.m-bot-3 {
  margin-bottom: 15px; }

.m-bot-4 {
  margin-bottom: 20px; }

.m-bot-5 {
  margin-bottom: 25px; }

.m-bot-6 {
  margin-bottom: 30px; }

.m-bot-7 {
  margin-bottom: 35px; }

.m-bot-8 {
  margin-bottom: 40px; }

.m-bot-9 {
  margin-bottom: 45px; }

.m-bot-10 {
  margin-bottom: 50px; }

.m-bot-11 {
  margin-bottom: 55px; }

.m-bot-12 {
  margin-bottom: 60px; }

.m-bot-13 {
  margin-bottom: 65px; }

.m-bot-14 {
  margin-bottom: 70px; }

.m-bot-15 {
  margin-bottom: 75px; }

.m-bot-16 {
  margin-bottom: 80px; }

.m-bot-17 {
  margin-bottom: 85px; }

.m-bot-18 {
  margin-bottom: 90px; }

.m-bot-19 {
  margin-bottom: 95px; }

.m-bot-20 {
  margin-bottom: 100px; }

.m-bot-21 {
  margin-bottom: 105px; }

.m-bot-22 {
  margin-bottom: 110px; }

.m-bot-23 {
  margin-bottom: 115px; }

.m-bot-24 {
  margin-bottom: 120px; }

.m-bot-25 {
  margin-bottom: 125px; }

.m-bot-26 {
  margin-bottom: 130px; }

.m-bot-27 {
  margin-bottom: 135px; }

.m-bot-28 {
  margin-bottom: 140px; }

.m-bot-29 {
  margin-bottom: 145px; }

.m-y-0 {
  margin-bottom: 0px;
  margin-top: 0px; }

.m-y-1 {
  margin-bottom: 5px;
  margin-top: 5px; }

.m-y-2 {
  margin-bottom: 10px;
  margin-top: 10px; }

.m-y-3 {
  margin-bottom: 15px;
  margin-top: 15px; }

.m-y-4 {
  margin-bottom: 20px;
  margin-top: 20px; }

.m-y-5 {
  margin-bottom: 25px;
  margin-top: 25px; }

.m-y-6 {
  margin-bottom: 30px;
  margin-top: 30px; }

.m-y-7 {
  margin-bottom: 35px;
  margin-top: 35px; }

.m-y-8 {
  margin-bottom: 40px;
  margin-top: 40px; }

.m-y-9 {
  margin-bottom: 45px;
  margin-top: 45px; }

.m-y-10 {
  margin-bottom: 50px;
  margin-top: 50px; }

.m-y-11 {
  margin-bottom: 55px;
  margin-top: 55px; }

.m-y-12 {
  margin-bottom: 60px;
  margin-top: 60px; }

.m-y-13 {
  margin-bottom: 65px;
  margin-top: 65px; }

.m-y-14 {
  margin-bottom: 70px;
  margin-top: 70px; }

.m-y-15 {
  margin-bottom: 75px;
  margin-top: 75px; }

.m-y-16 {
  margin-bottom: 80px;
  margin-top: 80px; }

.m-y-17 {
  margin-bottom: 85px;
  margin-top: 85px; }

.m-y-18 {
  margin-bottom: 90px;
  margin-top: 90px; }

.m-y-19 {
  margin-bottom: 95px;
  margin-top: 95px; }

.m-y-20 {
  margin-bottom: 100px;
  margin-top: 100px; }

.m-y-21 {
  margin-bottom: 105px;
  margin-top: 105px; }

.m-y-22 {
  margin-bottom: 110px;
  margin-top: 110px; }

.m-y-23 {
  margin-bottom: 115px;
  margin-top: 115px; }

.m-y-24 {
  margin-bottom: 120px;
  margin-top: 120px; }

.m-y-25 {
  margin-bottom: 125px;
  margin-top: 125px; }

.m-y-26 {
  margin-bottom: 130px;
  margin-top: 130px; }

.m-y-27 {
  margin-bottom: 135px;
  margin-top: 135px; }

.m-y-28 {
  margin-bottom: 140px;
  margin-top: 140px; }

.m-y-29 {
  margin-bottom: 145px;
  margin-top: 145px; }

.m-left-0 {
  margin-left: 0px; }

.m-left-1 {
  margin-left: 5px; }

.m-left-2 {
  margin-left: 10px; }

.m-left-3 {
  margin-left: 15px; }

.m-left-4 {
  margin-left: 20px; }

.m-left-5 {
  margin-left: 25px; }

.m-left-6 {
  margin-left: 30px; }

.m-left-7 {
  margin-left: 35px; }

.m-left-8 {
  margin-left: 40px; }

.m-left-9 {
  margin-left: 45px; }

.m-left-10 {
  margin-left: 50px; }

.m-left-11 {
  margin-left: 55px; }

.m-left-12 {
  margin-left: 60px; }

.m-left-13 {
  margin-left: 65px; }

.m-left-14 {
  margin-left: 70px; }

.m-left-15 {
  margin-left: 75px; }

.m-left-16 {
  margin-left: 80px; }

.m-left-17 {
  margin-left: 85px; }

.m-left-18 {
  margin-left: 90px; }

.m-left-19 {
  margin-left: 95px; }

.m-right-0 {
  margin-right: 0px; }

.m-right-1 {
  margin-right: 5px; }

.m-right-2 {
  margin-right: 10px; }

.m-right-3 {
  margin-right: 15px; }

.m-right-4 {
  margin-right: 20px; }

.m-right-5 {
  margin-right: 25px; }

.m-right-6 {
  margin-right: 30px; }

.m-right-7 {
  margin-right: 35px; }

.m-right-8 {
  margin-right: 40px; }

.m-right-9 {
  margin-right: 45px; }

.m-right-10 {
  margin-right: 50px; }

.m-right-11 {
  margin-right: 55px; }

.m-right-12 {
  margin-right: 60px; }

.m-right-13 {
  margin-right: 65px; }

.m-right-14 {
  margin-right: 70px; }

.m-right-15 {
  margin-right: 75px; }

.m-right-16 {
  margin-right: 80px; }

.m-right-17 {
  margin-right: 85px; }

.m-right-18 {
  margin-right: 90px; }

.m-right-19 {
  margin-right: 95px; }

.m-x-0 {
  margin-left: 0px;
  margin-right: 0px; }

.m-x-1 {
  margin-left: 5px;
  margin-right: 5px; }

.m-x-2 {
  margin-left: 10px;
  margin-right: 10px; }

.m-x-3 {
  margin-left: 15px;
  margin-right: 15px; }

.m-x-4 {
  margin-left: 20px;
  margin-right: 20px; }

.m-x-5 {
  margin-left: 25px;
  margin-right: 25px; }

.m-x-6 {
  margin-left: 30px;
  margin-right: 30px; }

.m-x-7 {
  margin-left: 35px;
  margin-right: 35px; }

.m-x-8 {
  margin-left: 40px;
  margin-right: 40px; }

.m-x-9 {
  margin-left: 45px;
  margin-right: 45px; }

.m-x-10 {
  margin-left: 50px;
  margin-right: 50px; }

.m-x-11 {
  margin-left: 55px;
  margin-right: 55px; }

.m-x-12 {
  margin-left: 60px;
  margin-right: 60px; }

.m-x-13 {
  margin-left: 65px;
  margin-right: 65px; }

.m-x-14 {
  margin-left: 70px;
  margin-right: 70px; }

.m-x-15 {
  margin-left: 75px;
  margin-right: 75px; }

.m-x-16 {
  margin-left: 80px;
  margin-right: 80px; }

.m-x-17 {
  margin-left: 85px;
  margin-right: 85px; }

.m-x-18 {
  margin-left: 90px;
  margin-right: 90px; }

.m-x-19 {
  margin-left: 95px;
  margin-right: 95px; }

.p-left-0 {
  padding-left: 0px; }

.p-left-1 {
  padding-left: 5px; }

.p-left-2 {
  padding-left: 10px; }

.p-left-3 {
  padding-left: 15px; }

.p-left-4 {
  padding-left: 20px; }

.p-left-5 {
  padding-left: 25px; }

.p-left-6 {
  padding-left: 30px; }

.p-left-7 {
  padding-left: 35px; }

.p-left-8 {
  padding-left: 40px; }

.p-left-9 {
  padding-left: 45px; }

.p-left-10 {
  padding-left: 50px; }

.p-left-11 {
  padding-left: 55px; }

.p-left-12 {
  padding-left: 60px; }

.p-left-13 {
  padding-left: 65px; }

.p-left-14 {
  padding-left: 70px; }

.p-left-15 {
  padding-left: 75px; }

.p-left-16 {
  padding-left: 80px; }

.p-left-17 {
  padding-left: 85px; }

.p-left-18 {
  padding-left: 90px; }

.p-left-19 {
  padding-left: 95px; }

.p-right-0 {
  padding-right: 0px; }

.p-right-1 {
  padding-right: 5px; }

.p-right-2 {
  padding-right: 10px; }

.p-right-3 {
  padding-right: 15px; }

.p-right-4 {
  padding-right: 20px; }

.p-right-5 {
  padding-right: 25px; }

.p-right-6 {
  padding-right: 30px; }

.p-right-7 {
  padding-right: 35px; }

.p-right-8 {
  padding-right: 40px; }

.p-right-9 {
  padding-right: 45px; }

.p-right-10 {
  padding-right: 50px; }

.p-right-11 {
  padding-right: 55px; }

.p-right-12 {
  padding-right: 60px; }

.p-right-13 {
  padding-right: 65px; }

.p-right-14 {
  padding-right: 70px; }

.p-right-15 {
  padding-right: 75px; }

.p-right-16 {
  padding-right: 80px; }

.p-right-17 {
  padding-right: 85px; }

.p-right-18 {
  padding-right: 90px; }

.p-right-19 {
  padding-right: 95px; }

.p-x-0 {
  padding-left: 0px;
  padding-right: 0px; }

.p-x-1 {
  padding-left: 5px;
  padding-right: 5px; }

.p-x-2 {
  padding-left: 10px;
  padding-right: 10px; }

.p-x-3 {
  padding-left: 15px;
  padding-right: 15px; }

.p-x-4 {
  padding-left: 20px;
  padding-right: 20px; }

.p-x-5 {
  padding-left: 25px;
  padding-right: 25px; }

.p-x-6 {
  padding-left: 30px;
  padding-right: 30px; }

.p-x-7 {
  padding-left: 35px;
  padding-right: 35px; }

.p-x-8 {
  padding-left: 40px;
  padding-right: 40px; }

.p-x-9 {
  padding-left: 45px;
  padding-right: 45px; }

.p-x-10 {
  padding-left: 50px;
  padding-right: 50px; }

.p-x-11 {
  padding-left: 55px;
  padding-right: 55px; }

.p-x-12 {
  padding-left: 60px;
  padding-right: 60px; }

.p-x-13 {
  padding-left: 65px;
  padding-right: 65px; }

.p-x-14 {
  padding-left: 70px;
  padding-right: 70px; }

.p-x-15 {
  padding-left: 75px;
  padding-right: 75px; }

.p-x-16 {
  padding-left: 80px;
  padding-right: 80px; }

.p-x-17 {
  padding-left: 85px;
  padding-right: 85px; }

.p-x-18 {
  padding-left: 90px;
  padding-right: 90px; }

.p-x-19 {
  padding-left: 95px;
  padding-right: 95px; }

.p-top-0 {
  padding-top: 0px; }

.p-top-1 {
  padding-top: 5px; }

.p-top-2 {
  padding-top: 10px; }

.p-top-3 {
  padding-top: 15px; }

.p-top-4 {
  padding-top: 20px; }

.p-top-5 {
  padding-top: 25px; }

.p-top-6 {
  padding-top: 30px; }

.p-top-7 {
  padding-top: 35px; }

.p-top-8 {
  padding-top: 40px; }

.p-top-9 {
  padding-top: 45px; }

.p-top-10 {
  padding-top: 50px; }

.p-top-11 {
  padding-top: 55px; }

.p-top-12 {
  padding-top: 60px; }

.p-top-13 {
  padding-top: 65px; }

.p-top-14 {
  padding-top: 70px; }

.p-top-15 {
  padding-top: 75px; }

.p-top-16 {
  padding-top: 80px; }

.p-top-17 {
  padding-top: 85px; }

.p-top-18 {
  padding-top: 90px; }

.p-top-19 {
  padding-top: 95px; }

.p-top-20 {
  padding-top: 100px; }

.p-top-21 {
  padding-top: 105px; }

.p-top-22 {
  padding-top: 110px; }

.p-top-23 {
  padding-top: 115px; }

.p-top-24 {
  padding-top: 120px; }

.p-top-25 {
  padding-top: 125px; }

.p-top-26 {
  padding-top: 130px; }

.p-top-27 {
  padding-top: 135px; }

.p-top-28 {
  padding-top: 140px; }

.p-top-29 {
  padding-top: 145px; }

.p-bot-0 {
  padding-bottom: 0px; }

.p-bot-1 {
  padding-bottom: 5px; }

.p-bot-2 {
  padding-bottom: 10px; }

.p-bot-3 {
  padding-bottom: 15px; }

.p-bot-4 {
  padding-bottom: 20px; }

.p-bot-5 {
  padding-bottom: 25px; }

.p-bot-6 {
  padding-bottom: 30px; }

.p-bot-7 {
  padding-bottom: 35px; }

.p-bot-8 {
  padding-bottom: 40px; }

.p-bot-9 {
  padding-bottom: 45px; }

.p-bot-10 {
  padding-bottom: 50px; }

.p-bot-11 {
  padding-bottom: 55px; }

.p-bot-12 {
  padding-bottom: 60px; }

.p-bot-13 {
  padding-bottom: 65px; }

.p-bot-14 {
  padding-bottom: 70px; }

.p-bot-15 {
  padding-bottom: 75px; }

.p-bot-16 {
  padding-bottom: 80px; }

.p-bot-17 {
  padding-bottom: 85px; }

.p-bot-18 {
  padding-bottom: 90px; }

.p-bot-19 {
  padding-bottom: 95px; }

.p-bot-20 {
  padding-bottom: 100px; }

.p-bot-21 {
  padding-bottom: 105px; }

.p-bot-22 {
  padding-bottom: 110px; }

.p-bot-23 {
  padding-bottom: 115px; }

.p-bot-24 {
  padding-bottom: 120px; }

.p-bot-25 {
  padding-bottom: 125px; }

.p-bot-26 {
  padding-bottom: 130px; }

.p-bot-27 {
  padding-bottom: 135px; }

.p-bot-28 {
  padding-bottom: 140px; }

.p-bot-29 {
  padding-bottom: 145px; }

.p-y-0 {
  padding-bottom: 0px;
  padding-top: 0px; }

.p-y-1 {
  padding-bottom: 5px;
  padding-top: 5px; }

.p-y-2 {
  padding-bottom: 10px;
  padding-top: 10px; }

.p-y-3 {
  padding-bottom: 15px;
  padding-top: 15px; }

.p-y-4 {
  padding-bottom: 20px;
  padding-top: 20px; }

.p-y-5 {
  padding-bottom: 25px;
  padding-top: 25px; }

.p-y-6 {
  padding-bottom: 30px;
  padding-top: 30px; }

.p-y-7 {
  padding-bottom: 35px;
  padding-top: 35px; }

.p-y-8 {
  padding-bottom: 40px;
  padding-top: 40px; }

.p-y-9 {
  padding-bottom: 45px;
  padding-top: 45px; }

.p-y-10 {
  padding-bottom: 50px;
  padding-top: 50px; }

.p-y-11 {
  padding-bottom: 55px;
  padding-top: 55px; }

.p-y-12 {
  padding-bottom: 60px;
  padding-top: 60px; }

.p-y-13 {
  padding-bottom: 65px;
  padding-top: 65px; }

.p-y-14 {
  padding-bottom: 70px;
  padding-top: 70px; }

.p-y-15 {
  padding-bottom: 75px;
  padding-top: 75px; }

.p-y-16 {
  padding-bottom: 80px;
  padding-top: 80px; }

.p-y-17 {
  padding-bottom: 85px;
  padding-top: 85px; }

.p-y-18 {
  padding-bottom: 90px;
  padding-top: 90px; }

.p-y-19 {
  padding-bottom: 95px;
  padding-top: 95px; }

.p-y-20 {
  padding-bottom: 100px;
  padding-top: 100px; }

.p-y-21 {
  padding-bottom: 105px;
  padding-top: 105px; }

.p-y-22 {
  padding-bottom: 110px;
  padding-top: 110px; }

.p-y-23 {
  padding-bottom: 115px;
  padding-top: 115px; }

.p-y-24 {
  padding-bottom: 120px;
  padding-top: 120px; }

.p-y-25 {
  padding-bottom: 125px;
  padding-top: 125px; }

.p-y-26 {
  padding-bottom: 130px;
  padding-top: 130px; }

.p-y-27 {
  padding-bottom: 135px;
  padding-top: 135px; }

.p-y-28 {
  padding-bottom: 140px;
  padding-top: 140px; }

.p-y-29 {
  padding-bottom: 145px;
  padding-top: 145px; }

.column-xl-1, .column-lg-1, .column-md-1, .column-sm-1, .column-1 {
  grid-column: span 12; }

.column-xl-2, .column-lg-2, .column-md-2, .column-sm-2, .column-2 {
  grid-column: span 12; }

.column-xl-3, .column-lg-3, .column-md-3, .column-sm-3, .column-3 {
  grid-column: span 12; }

.column-xl-4, .column-lg-4, .column-md-4, .column-sm-4, .column-4 {
  grid-column: span 12; }

.column-xl-5, .column-lg-5, .column-md-5, .column-sm-5, .column-5 {
  grid-column: span 12; }

.column-xl-6, .column-lg-6, .column-md-6, .column-sm-6, .column-6 {
  grid-column: span 12; }

.column-xl-7, .column-lg-7, .column-md-7, .column-sm-7, .column-7 {
  grid-column: span 12; }

.column-xl-8, .column-lg-8, .column-md-8, .column-sm-8, .column-8 {
  grid-column: span 12; }

.column-xl-9, .column-lg-9, .column-md-9, .column-sm-9, .column-9 {
  grid-column: span 12; }

.column-xl-10, .column-lg-10, .column-md-10, .column-sm-10, .column-10 {
  grid-column: span 12; }

.column-xl-11, .column-lg-11, .column-md-11, .column-sm-11, .column-11 {
  grid-column: span 12; }

@media screen and (min-width: 576px) {
  .column-sm-1 {
    grid-column: span 1; }

  .column-sm-2 {
    grid-column: span 2; }

  .column-sm-3 {
    grid-column: span 3; }

  .column-sm-4 {
    grid-column: span 4; }

  .column-sm-5 {
    grid-column: span 5; }

  .column-sm-6 {
    grid-column: span 6; }

  .column-sm-7 {
    grid-column: span 7; }

  .column-sm-8 {
    grid-column: span 8; }

  .column-sm-9 {
    grid-column: span 9; }

  .column-sm-10 {
    grid-column: span 10; }

  .column-sm-11 {
    grid-column: span 11; } }
@media screen and (min-width: 768px) {
  .column-md-1 {
    grid-column: span 1; }

  .column-md-2 {
    grid-column: span 2; }

  .column-md-3 {
    grid-column: span 3; }

  .column-md-4 {
    grid-column: span 4; }

  .column-md-5 {
    grid-column: span 5; }

  .column-md-6 {
    grid-column: span 6; }

  .column-md-7 {
    grid-column: span 7; }

  .column-md-8 {
    grid-column: span 8; }

  .column-md-9 {
    grid-column: span 9; }

  .column-md-10 {
    grid-column: span 10; }

  .column-md-11 {
    grid-column: span 11; } }
@media screen and (min-width: 992px) {
  .column-lg-1 {
    grid-column: span 1; }

  .column-lg-2 {
    grid-column: span 2; }

  .column-lg-3 {
    grid-column: span 3; }

  .column-lg-4 {
    grid-column: span 4; }

  .column-lg-5 {
    grid-column: span 5; }

  .column-lg-6 {
    grid-column: span 6; }

  .column-lg-7 {
    grid-column: span 7; }

  .column-lg-8 {
    grid-column: span 8; }

  .column-lg-9 {
    grid-column: span 9; }

  .column-lg-10 {
    grid-column: span 10; }

  .column-lg-11 {
    grid-column: span 11; } }
@media screen and (min-width: 1200px) {
  .column-xl-1 {
    grid-column: span 1; }

  .column-xl-2 {
    grid-column: span 2; }

  .column-xl-3 {
    grid-column: span 3; }

  .column-xl-4 {
    grid-column: span 4; }

  .column-xl-5 {
    grid-column: span 5; }

  .column-xl-6 {
    grid-column: span 6; }

  .column-xl-7 {
    grid-column: span 7; }

  .column-xl-8 {
    grid-column: span 8; }

  .column-xl-9 {
    grid-column: span 9; }

  .column-xl-10 {
    grid-column: span 10; }

  .column-xl-11 {
    grid-column: span 11; } }
.grid-row-1 {
  grid-row: span 1; }

.grid-row-2 {
  grid-row: span 2; }

@media screen and (min-width: 576px) {
  .grid-row-sm-1 {
    grid-row: span 1; }

  .grid-row-sm-2 {
    grid-row: span 2; } }
@media screen and (min-width: 768px) {
  .grid-row-md-1 {
    grid-row: span 1; }

  .grid-row-md-2 {
    grid-row: span 2; } }
@media screen and (min-width: 992px) {
  .grid-row-lg-1 {
    grid-row: span 1; }

  .grid-row-lg-2 {
    grid-row: span 2; } }
@media screen and (min-width: 1200px) {
  .grid-row-xl-1 {
    grid-row: span 1; }

  .grid-row-xl-2 {
    grid-row: span 2; } }
.maxw-100 {
  max-width: 100px; }

.maxw-200 {
  max-width: 200px; }

.maxw-300 {
  max-width: 300px; }

.maxw-400 {
  max-width: 400px; }

.maxw-500 {
  max-width: 500px; }

.maxw-600 {
  max-width: 600px; }

.maxw-700 {
  max-width: 700px; }

.maxw-800 {
  max-width: 800px; }

.maxw-900 {
  max-width: 900px; }

.btn-primary {
  border-color: #121212; }

.btn-primary.focus, .btn-primary:focus {
  box-shadow: 0 0 0 transparent; }

.btn {
  border-radius: 0;
  padding: 10px 25px; }

.btn:focus {
  box-shadow: none; }

.btn-md {
  border-radius: 0;
  padding: 13px 46px; }

.btn-md:focus {
  box-shadow: none; }

.btn-sm {
  border-radius: 0;
  padding: 10px 25px;
  color: #fff; }

.btn-sm:focus {
  box-shadow: none; }

.btn-xs {
  border-radius: 0;
  padding: 6px 30px; }

.btn-xs:focus {
  box-shadow: none; }

.btn-xxs {
  border-radius: 0;
  padding: 3px 24px; }

.btn-xxs:focus {
  box-shadow: none; }

.max-w750 {
  max-width: 750px; }

.p-tags li {
  display: inline-block; }

.p-tags li a {
  display: block;
  text-transform: uppercase;
  position: relative;
  font-family: 'Lato', sans-serif;
  font-size: 14px;
  color: #fff;
  margin: 2px 20px 2px 0; }

.p-tags li a::before {
  content: '/';
  position: absolute;
  right: -15px;
  color: #fff; }

.p-tags li:last-child a::before {
  content: unset;
  pointer-events: none; }

.rounded-15 {
  border-radius: 15px !important; }

.rounded-12 {
  border-radius: 12px !important; }

.rounded-50 {
  border-radius: 50px !important; }

.section-padding {
  padding-top: 80px;
  padding-bottom: 80px; }

.flex-1 {
  flex: 1 !important; }

.border, .border-top, .border-right, .border-bottom, .border-left {
  border-color: #2b333a !important; }

.header-area {
  position: relative;
  background-color: #1a2024;
  z-index: 99; }

.header-area:before {
  position: absolute;
  left: 0;
  top: 0;
  content: '';
  width: 50%;
  height: 100%;
  z-index: -1; }

.header-area .container-fluid {
  max-width: 100%;
  background-color: #121212; }

.header-area.sticky-menu {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  z-index: 9;
  animation: menu_sticky 0.6s; }

@-webkit-keyframes menu_sticky {
  0% {
    margin-top: -120px;
    opacity: 0; }
  50% {
    margin-top: -64px;
    opacity: 0; }
  100% {
    margin-top: 0;
    opacity: 1; } }
@keyframes menu_sticky {
  0% {
    margin-top: -120px;
    opacity: 0; }
  50% {
    margin-top: -64px;
    opacity: 0; }
  100% {
    margin-top: 0;
    opacity: 1; } }
.header-content {
  display: flex;
  justify-content: space-between; }

.header-left {
  display: flex;
  flex: 1; }

.logo {
  padding-right: 50px;
  position: relative; }

.logo::before {
  position: absolute;
  left: -15px;
  top: 0;
  width: calc(100% + 15px);
  height: 100%;
  content: '';
  background-color: #1a2024; }

.logo * {
  z-index: 1;
  position: relative; }

.logo h1 {
  font-size: 50px;
  color: #fff;
  margin: 0; }

.logo h1 a {
  color: #fff; }

.main-menu {
  display: flex;
  flex: 1; }

.main-menu .menubar {
  background-color: #0f1417;
  display: flex;
  align-items: center;
  position: relative;
  z-index: 2; }

.main-menu .menubar .menubars {
  padding: 15px 20px;
  display: flex;
  flex-direction: column;
  cursor: pointer; }

.main-menu .menubar .menubars span {
  display: block;
  background-color: #fff;
  margin: 3px 0;
  width: 25px;
  height: 1px;
  transition: 0.3s;
  position: relative; }

.main-menu .menubar .menubars span:before {
  position: absolute;
  left: 0;
  top: -7px;
  height: 1px;
  width: 100%;
  content: '';
  background-color: #fff;
  transition: 0.3s; }

.main-menu .menubar .menubars span:after {
  position: absolute;
  left: 0;
  bottom: -7px;
  height: 1px;
  width: 100%;
  content: '';
  background-color: #fff;
  transition: 0.3s; }

.main-menu .menubar .menubars:hover span:after {
  left: 5px; }

.main-menu .menubar .menubars:hover span:before {
  left: -5px; }

.main-menu .mainmenu-list {
  background-color: #2b333a;
  flex: 1;
  display: flex;
  align-items: center;
  margin-right: 15px;
  position: relative;
  opacity: 1;
  left: 0;
  top: 0;
  transition: 0.6s;
  transition-timing-function: cubic-bezier(0.11, 0.68, 0.81, 0.79);
  z-index: 9; }

.main-menu .mainmenu-list.active {
  opacity: 1;
  left: 0; }

.main-menu .mainmenu-list.hide-menu {
  opacity: 0;
  top: -200px; }

.main-menu .mainmenu-list > ul {
  height: 100%; }

.main-menu .mainmenu-list > ul > li {
  height: 100%;
  align-items: center;
  display: flex; }

.main-menu .mainmenu-list ul {
  display: flex;
  width: 100%;
  justify-content: center; }

.main-menu .mainmenu-list ul li {
  line-height: 30px;
  margin: 0 10px;
  position: relative; }

.main-menu .mainmenu-list ul li a {
  color: #fff;
  font-family: Raleway,sans-serif;
  font-weight: 400;
  letter-spacing: 1px; }

.main-menu .mainmenu-list ul li a:hover {
  color: #6c5da7; }

.main-menu .mainmenu-list ul li.active > a {
  color: #6c5da7; }

.main-menu .mainmenu-list ul li:hover > a {
  color: #6c5da7; }

.main-menu .mainmenu-list ul li:hover > ul {
  visibility: visible;
  opacity: 1; }

.main-menu .mainmenu-list ul li ul {
  visibility: hidden;
  position: absolute;
  top: 100%;
  width: 170px;
  background: #121212;
  display: flex;
  flex-direction: column;
  padding: 10px 10px;
  opacity: 0; }

.main-menu .mainmenu-list ul li ul li a {
  font-size: 14px;
  display: flex;
  align-items: center;
  justify-content: space-between; }

.main-menu .mainmenu-list ul li ul li a:hover {
  color: #6c5da7; }

.main-menu .mainmenu-list ul li ul li.active > a {
  color: #6c5da7; }

.main-menu .mainmenu-list ul li ul li ul {
  left: 100%;
  top: 0; }

.main-menu .mainmenu-list .close-menu {
  margin: 0 15px;
  cursor: pointer; }

.header-right {
  position: relative; }

.header-right ul {
  display: flex;
  align-self: center;
  border-left: 1px solid rgba(255, 255, 255, 0.65);
  margin-left: 15px; }

.header-right ul li a {
  color: #fff;
  margin-left: 5px;
  width: 30px;
  height: 30px;
  display: flex;
  align-items: center;
  justify-content: center;
  border-radius: 50%; }

.header-right ul li a:hover {
  background-color: #6c5da7; }

.expanded-search {
  width: 32px;
  position: relative;
  display: flex;
  align-items: center; }

.expanded-search .search-icon {
  border: 1px solid #fff;
  width: 30px;
  height: 30px;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 14px;
  cursor: pointer;
  color: #fff;
  cursor: pointer; }

.expanded-search .search-icon i {
  cursor: pointer; }

.expanded-search .search-icon:hover {
  color: #fff;
  background-color: #6c5da7;
  border-color: #6c5da7; }

.expanded-search.active .search-box {
  opacity: 1;
  visibility: visible;
  width: 100%; }

.expanded-search .search-box {
  position: fixed;
  height: 85px;
  top: 0;
  width: 0;
  right: 0;
  z-index: 9;
  background: #121212;
  opacity: 0;
  visibility: hidden;
  transition-timing-function: cubic-bezier(0.11, 0.68, 0.81, 0.79);
  transition: 0.8s; }

.expanded-search .search-box input {
  height: 100%;
  padding: 10px 50px;
  border: 0; }

.expanded-search .search-box .search-icon {
  position: absolute;
  top: calc(50% - 15px);
  right: 15px;
  background: transparent; }

.expanded-search .search-box .search-icon:hover {
  color: #fff;
  background-color: #6c5da7;
  border-color: #6c5da7; }

.expanded-search .search-box .search-close-trigger {
  position: absolute;
  top: calc(50% - 11px);
  left: 15px;
  cursor: pointer; }

.delas-switcher {
  width: 130px;
  background-color: #fff;
  box-shadow: -5px 0 10px rgba(30, 39, 46, 0.2);
  padding: 20px 15px;
  z-index: 999;
  position: fixed;
  top: 50%;
  right: -130px;
  text-align: center;
  border-radius: 5px 0 0 5px;
  transition: 0.3s ease; }

.delas-switcher.active {
  right: 0; }

.btn-red {
  background-color: #6c5da7;
  color: #fff;
  border-radius: 4px;
  padding: 5px 15px;
  font-size: 14px;
  margin-top: 6px; }

.btn-red:hover {
  color: #fff;
  background-color: #f10c2f; }

.gear-sliders {
  position: absolute;
  left: 0;
  font-size: 30px;
  color: #6c5da7;
  left: -30px;
  cursor: pointer;
  top: 0; }

.onoffswitch {
  position: relative;
  width: 90px;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  margin-left: auto;
  margin-right: auto;
  text-align: left; }

.onoffswitch-checkbox {
  display: none; }

.onoffswitch-label {
  display: block;
  overflow: hidden;
  cursor: pointer;
  border: 2px solid #121212;
  border-radius: 20px; }

.onoffswitch-inner {
  display: block;
  width: 200%;
  margin-left: -100%;
  transition: margin 0.3s ease-in 0s; }

.onoffswitch-inner:before, .onoffswitch-inner:after {
  display: block;
  float: left;
  width: 50%;
  height: 30px;
  padding: 0;
  line-height: 30px;
  font-size: 14px;
  color: white;
  font-weight: bold;
  box-sizing: border-box; }

.onoffswitch-inner:before {
  content: 'Light';
  padding-left: 10px;
  background-color: #ffffff;
  color: #121212; }

.onoffswitch-inner:after {
  content: 'Dark';
  padding-right: 10px;
  background-color: #121212;
  color: #ffffff;
  text-align: right; }

.onoffswitch-switch {
  display: block;
  width: 22px;
  margin: 6px;
  background: #ffffff;
  position: absolute;
  top: 0;
  bottom: 0;
  right: 56px;
  border: 2px solid #121212;
  border-radius: 20px;
  transition: all 0.3s ease-in 0s; }

.onoffswitch-checkbox:checked + .onoffswitch-label .onoffswitch-inner {
  margin-left: 0; }

.onoffswitch-checkbox:checked + .onoffswitch-label .onoffswitch-switch {
  right: 0px; }

body.light-mode {
  background-color: #fff; }

body.light-mode .footer-wrapper .footer-tag.owl-carousel .owl-dots button.owl-dot.active {
  background-color: #1a2024 !important; }

body.light-mode .main-menu .menubar .menubars span, body.light-mode .main-menu .menubar .menubars span:before, body.light-mode .main-menu .menubar .menubars span:after {
  background-color: #fff; }

body.light-mode .main-menu .mainmenu-list {
  background-color: #fff; }

body.light-mode .main-menu .mainmenu-list ul li a {
  color: #1a2024; }

body.light-mode .main-menu .mainmenu-list ul li ul {
  background-color: #fff; }

body.light-mode .header-area, body.light-mode .header-area .container-fluid, body.light-mode .footer-wrapper, body.light-mode .social-share-post .share-post, body.light-mode .footer-wrapper .subscribe-section .subscribe-form .form-group .form-control, body.light-mode .single-post-content ul li::before {
  background-color: #fff; }

body.light-mode .ln-card .card-content, body.light-mode .logo::before, body.light-mode .featured-slider-area:before, body.light-mode .featured-slider:before, body.light-mode .header-area:before, body.light-mode .main-menu .menubar, body.light-mode .tag-banner, body.light-mode .author-card-wrapper .author-card, body.light-mode .author-banner, body.light-mode .author-banner-wrapper.banner-split:after, body.light-mode .single-post-content blockquote:nth-child(3n+3), body.light-mode .single-post-content blockquote:nth-child(3n+2), body.light-mode :not(pre) > code[class*='language-'], body.light-mode pre[class*='language-'], body.light-mode .single-portfolio-wrapper .portfolio-description .project-full-details.content-bg, body.light-mode .pl-banner::before, body.light-mode .banner-before::before, body.light-mode .sb-content-wrap {
  background-color: #718093; }

body.light-mode .blog-sidebar {
  background-color: #7f8fa6; }

body.light-mode .header-right ul li a, body.light-mode .expanded-search .search-icon, body.light-mode .section-title h1, body.light-mode .section-title h2, body.light-mode .section-title h3, body.light-mode .section-title h4, body.light-mode .section-title h5, body.light-mode .section-title h6, body.light-mode .single-top-author h4, body.light-mode .single-top-author h4 a, body.light-mode .social-share-post .share-post li a, body.light-mode .single-top-author h3 a, body.light-mode .top-author-meta span a, body.light-mode .single-post-content blockquote:nth-child(3n+1), body.light-mode .single-post-content ul li, body.light-mode .single-post-content .table th, body.light-mode .single-post-content .table td, body.light-mode .single-post-content figcaption, body.light-mode .single-post-content ul, body.light-mode .single-post-content ol, body.light-mode .single-portfolio-wrapper .portfolio-description .project-full-details ul li, body.light-mode .single-portfolio-wrapper .portfolio-description .project-full-details ul li a, body.light-mode textarea, body.light-mode input:not([type='submit']), body.light-mode h1, body.light-mode h2, body.light-mode h3, body.light-mode h4, body.light-mode h5, body.light-mode h6, body.light-mode p, body.light-mode .gear-sliders {
  color: #1a2024; }

body.light-mode .top-author-meta span, body.light-mode .post-meta p a, body.light-mode .post-meta p, body.light-mode .author-meta a, body.light-mode .author-meta, body.light-mode .ln-card .card-content p, body.light-mode .footer-wrapper .footer-tag .single-tag .tag-name h6, body.light-mode .footer-wrapper .footer-tag .single-tag .tag-name p, body.light-mode .single-slide-content h2, body.light-mode .single-slide-content p, body.light-mode .tag-banner .tag-banner-text h2, body.light-mode .tag-banner .tag-banner-text p, body.light-mode .author-banner .author-banner-text h2, body.light-mode .author-card-wrapper .author-card .about-card-text p, body.light-mode .author-card-wrapper .author-card .card-text p, body.light-mode .author-banner .author-banner-text p, body.light-mode .top-author-meta span a, body.light-mode .single-post-content blockquote:nth-child(3n+3), body.light-mode .single-post-content blockquote:nth-child(3n+2), body.light-mode .single-portfolio-wrapper .portfolio-description .project-full-details.content-bg h4, body.light-mode .single-portfolio-wrapper .portfolio-description .project-full-details.content-bg .project-info h6, body.light-mode .single-portfolio-wrapper .portfolio-description .project-full-details.content-bg .project-info p, body.light-mode .single-portfolio-wrapper .portfolio-description .project-full-details.content-bg ul li, body.light-mode .single-portfolio-wrapper .portfolio-description .project-full-details.content-bg ul li a, body.light-mode .single-blog-sec h1, body.light-mode .sb-content-wrap h2, body.light-mode .sb-content-wrap h3, body.light-mode .sb-content-wrap h4, body.light-mode .sb-content-wrap h5, body.light-mode .sb-content-wrap h6, body.light-mode .sb-content-wrap p, body.light-mode .single-post-content ul li, body.light-mode .sb-author .a-name, body.light-mode .subscribe-block input, body.light-mode .pp-item .pp-date, body.light-mode .about-us .a-desc, body.light-mode .tf-item, body.light-mode .comment-form .form-control, body.light-mode .expanded-search .search-icon:hover i, body.light-mode .footer-wrapper .subscribe-section.has-thumbimage .subscribe-text h2, body.light-mode .footer-wrapper .subscribe-section.has-thumbimage .subscribe-text p {
  color: #fff; }

body.light-mode .expanded-search .search-icon, body.light-mode .header-right ul {
  border-color: #1a2024; }

body.light-mode .footer-wrapper .subscribe-section {
  background: #dcdde1; }

body.light-mode .footer-wrapper .subscribe-section .subscribe-text h2, body.light-mode .footer-wrapper .subscribe-section .subscribe-text p {
  color: #1a2024; }

body.light-mode .latest-news .ln-carousel button img {
  filter: brightness(0); }

body.light-mode .tag-item .tag-item-inner {
  background: linear-gradient(to right, #718093 0%, rgba(104, 110, 115, 0) 100%); }

body.light-mode .tag-banner.banner-overlay:before, body.light-mode .portfolio-card .card-content, body.light-mode .footer-wrapper .subscribe-section.has-thumbimage:before {
  background-color: rgba(113, 128, 147, 0.6); }

body.light-mode .single-slide:before {
  background-color: rgba(113, 128, 147, 0.3); }

body.light-mode .single-post-content blockquote:nth-child(3n+2)::before, body.light-mode .expanded-search .search-icon:hover {
  border-color: #6c5da7; }

body.light-mode .delas-map, body.light-mode textarea:focus, body.light-mode input:not([type='submit']):focus, body.light-mode .pagination-section a i, body.light-mode .expanded-search .search-icon {
  border-color: #718093; }

body.light-mode .pagination-section a {
  color: #718093; }

body.light-mode .pagination-section a i {
  border-color: #718093;
  color: #718093; }

body.light-mode .pagination-section a:hover i {
  background-color: #718093;
  color: #fff; }

body.light-mode .pagination-section a.active {
  color: #6c5da7; }

body.light-mode .comment-lists ul li, body.light-mode .comment-lists ul li ul li:first-child, body.light-mode .comment-form .form-control, body.light-mode .comment-wrap-title h4, body.light-mode .subscribe-block input:not([type='submit']) {
  border-color: #b1b1b1 !important; }

body.light-mode .sb-content-wrap .border, body.light-mode .sb-content-wrap .border-top, body.light-mode .sb-content-wrap .border-right, body.light-mode .sb-content-wrap .border-bottom, body.light-mode .sb-content-wrap .border-left {
  border-color: #b1b1b1 !important; }

body.light-mode .expanded-search .search-box {
  background-color: #fff;
  box-shadow: 0 3px 8px rgba(0, 0, 0, 0.15); }

body.light-mode.medium-zoom--opened .medium-zoom-overlay {
  background-color: #fff !important; }

body.light-mode #preloader {
  background: #fff; }

body.light-mode .preloader-wave:before, body.light-mode .preloader-wave:after {
  background: #718093; }

.footer-wrapper {
  background: #121212;
  width: 100%; }

.footer-wrapper .subscribe-section {
  padding: 50px 0;
  background: #000;
  display: flex;
  flex-direction: column;
  align-items: center;
  position: relative; }

.footer-wrapper .subscribe-section:before {
  width: 100%;
  height: 100%;
  content: '';
  position: absolute;
  left: 0;
  top: 0; }

.footer-wrapper .subscribe-section.has-thumbimage {
  background-size: cover;
  background-repeat: no-repeat;
  background-position: center center; }

.footer-wrapper .subscribe-section.has-thumbimage:before {
  background-color: rgba(26, 32, 36, 0.5); }

.footer-wrapper .subscribe-section.has-thumbimage .subscribe-form .form-group .form-control {
  background-color: #fff;
  color: #1a2024; }

.footer-wrapper .subscribe-section .subscribe-text {
  text-align: center;
  padding: 0 15px; }

.footer-wrapper .subscribe-section .subscribe-text h2 {
  font-family: Raleway,sans-serif;
  font-weight: 700;
  font-size: 48px;
  letter-spacing: 0.96px; }

.footer-wrapper .subscribe-section .subscribe-text p {
  font-family: Muli,sans-serif;
  font-weight: 400;
  font-size: 18px;
  color: #fff; }

.footer-wrapper .subscribe-section .subscribe-form {
  width: 100%;
  max-width: 700px;
  padding: 40px 40px 0; }

.footer-wrapper .subscribe-section .subscribe-form .form-group {
  display: flex; }

.footer-wrapper .subscribe-section .subscribe-form .form-group .form-control {
  display: block;
  width: 100%;
  height: calc(100% - 20px);
  padding: 15px;
  font-size: 18px;
  font-weight: 400;
  line-height: 1.5;
  color: #d4d3d3;
  background-color: #1a2024;
  background-clip: padding-box;
  border: 1px solid #fff;
  border-radius: 0;
  margin-right: 15px; }

.footer-wrapper .subscribe-section .subscribe-form .form-group .form-control:focus {
  box-shadow: 0 0 0 0 rgba(0, 123, 255, 0.25);
  border-color: #6c5da7; }

.footer-wrapper .subscribe-section .subscribe-form .form-group .form-control::placeholder {
  font-family: Muli,sans-serif;
  font-weight: 400;
  font-size: 16px; }

.footer-wrapper .subscribe-section .subscribe-form .form-group button {
  font-family: Raleway,sans-serif;
  font-weight: 400;
  font-size: 18px;
  letter-spacing: 0.36px;
  background: #6c5da7;
  color: #fff;
  border: 0;
  padding: 15px 40px;
  cursor: pointer; }

.footer-wrapper .subscribe-section .subscribe-form .form-group button:hover {
  background: #6c5ba7; }

.footer-wrapper .footer-tag {
  display: flex;
  padding: 50px 0; }

.footer-wrapper .footer-tag a {
  width: 100%; }

.footer-wrapper .footer-tag .single-tag {
  width: 100%;
  height: 200px;
  display: inline-flex;
  justify-content: center;
  align-items: center;
  position: relative;
  z-index: 1;
  background: rgba(57, 68, 77, 0.64); }

.footer-wrapper .footer-tag .single-tag::after {
  content: ' ';
  height: calc(100% - 20px);
  width: calc(100% - 20px);
  left: 10px;
  top: 10px;
  position: absolute;
  border: 1px solid #6c5da7;
  transition: 0.3s;
  z-index: 3; }

.footer-wrapper .footer-tag .single-tag .tag-name {
  position: relative;
  height: 100%;
  width: 100%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  background: rgba(30, 39, 46, 0.64);
  z-index: -1; }

.footer-wrapper .footer-tag .single-tag .tag-name h6 {
  font-family: Raleway,sans-serif;
  font-weight: 400;
  font-size: 18px;
  transition: 0.3s;
  transform: translateY(20px);
  margin-bottom: 5px; }

.footer-wrapper .footer-tag .single-tag .tag-name p {
  font-family: Muli,sans-serif;
  font-weight: 400;
  font-size: 14px;
  visibility: hidden;
  opacity: 0;
  transform: translateY(20px);
  transition: 0.3s; }

.footer-wrapper .footer-tag .single-tag:hover:after {
  width: 100%;
  height: 100%;
  left: 0px;
  top: 0px; }

.footer-wrapper .footer-tag .single-tag:hover .tag-name h6 {
  color: #6c5da7;
  transform: translateY(0); }

.footer-wrapper .footer-tag .single-tag:hover .tag-name p {
  visibility: visible;
  opacity: 1;
  transform: translateY(0); }

.footer-wrapper .footer-tag.owl-carousel .owl-dots {
  position: absolute;
  left: 50%;
  bottom: 10px;
  transform: translateX(-50%); }

.footer-wrapper .footer-tag.owl-carousel .owl-dots button.owl-dot {
  color: inherit;
  border: none;
  padding: 0 !important;
  font: inherit;
  width: 10px;
  height: 10px;
  border-radius: 50%;
  background: #6c5da7;
  margin: 5px; }

.footer-wrapper .footer-tag.owl-carousel .owl-dots button.owl-dot.active {
  background: #fff !important; }

.footer-wrapper .footer-social-section-wrapper {
  padding: 50px 0 30px;
  text-align: center; }

.footer-wrapper .footer-social-section-wrapper .brand h4 {
  text-align: center;
  font-family: SignPainter;
  font-weight: 400;
  font-size: 45px;
  margin-bottom: 10px; }

.footer-wrapper .footer-social-section-wrapper .social-section h4 {
  font-family: Raleway,sans-serif;
  font-weight: 400;
  font-size: 22px; }

.footer-wrapper .footer-social-section-wrapper .social-icons a {
  color: #fff;
  height: 50px;
  width: 50px;
  background: #354048;
  border-radius: 50px;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  margin-right: 15px;
  margin-top: 15px; }

.footer-wrapper .footer-social-section-wrapper .social-icons a:hover {
  background: #6c5da7;
  color: #fff; }

.footer-wrapper .copyright-section {
  padding: 20px 0 30px; }

.footer-wrapper .copyright-section .copyright-text {
  width: 100%;
  text-align: center; }

.featured-slider-area {
  padding-left: calc((100% - 1650px) / 2 + 15px);
  position: relative; }

.featured-slider-area:before {
  position: absolute;
  left: 0;
  top: 0;
  width: 160px;
  height: calc(100% + 18px);
  content: '';
  background-color: #1a2024; }

.featured-slider {
  position: relative;
  padding: 60px 0; }

.featured-slider:before {
  position: absolute;
  left: 0px;
  top: 0;
  width: 140px;
  height: calc(100% + 18px);
  content: '';
  background-color: #1a2024; }

.featured-slider.owl-carousel .owl-nav {
  display: flex;
  position: absolute;
  right: 100px;
  bottom: 100px; }

.featured-slider.owl-carousel .owl-nav button {
  font-size: 30px;
  color: #fff;
  border: 1px solid #fff;
  height: 50px;
  width: 50px;
  display: flex;
  align-items: center;
  justify-content: center;
  border-radius: 50%;
  margin-left: 10px; }

.featured-slider.owl-carousel .owl-nav button:hover {
  color: #6c5da7;
  border-color: #6c5da7; }

.featured-slider.owl-carousel .owl-nav button.disabled {
  border-color: #b1b1b1;
  color: #b1b1b1; }

.featured-slider.owl-carousel .owl-dots {
  position: absolute;
  top: 50%;
  transform: translateY(-50%);
  right: 100px;
  display: flex;
  flex-direction: column-reverse;
  align-items: center; }

.featured-slider.owl-carousel .owl-dots .owl-dot {
  color: #777;
  font-size: 20px;
  font-family: Raleway,sans-serif;
  font-weight: 400;
  border-bottom: 1px solid #777;
  margin: 5px 0; }

.featured-slider.owl-carousel .owl-dots .owl-dot.active {
  color: #6c5da7;
  border-color: #6c5da7; }

.single-slide {
  position: relative;
  padding: 100px 0;
  background-size: cover;
  background-repeat: no-repeat;
  background-position: center center;
  padding-left: 150px;
  padding-right: 150px; }

.single-slide:before {
  position: absolute;
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(25, 28, 30, 0.3);
  content: ''; }

.single-slide:after {
  position: absolute;
  left: 30px;
  top: 50%;
  transform: translateY(-50%) rotate(-90deg);
  content: 'FEATURED';
  text-transform: uppercase;
  color: #fff;
  letter-spacing: 6.13px;
  font-size: 16px;
  font-family: Raleway,sans-serif;
  font-weight: 400;
  z-index: 1; }

.single-slide-content {
  position: relative;
  max-width: 700px; }

.single-slide-content h2 {
  font-size: 50px;
  font-family: Playfair Display,serif;
  font-weight: 700;
  color: #fff;
  line-height: 1.3;
  margin-bottom: 20px; }

.single-slide-content p {
  font-size: 15px; }

.read-more {
  margin-top: 40px; }

.read-more a {
  font-family: Raleway,sans-serif;
  font-weight: 400;
  font-size: 16px;
  color: #fff;
  position: relative;
  padding: 10px 15px;
  display: inline-block; }

.read-more a:before {
  position: absolute;
  left: 0;
  top: 0;
  width: 10px;
  height: 10px;
  content: '';
  border-top: 1px solid #6c5da7;
  border-left: 1px solid #6c5da7;
  padding: 10px;
  display: inline-block;
  transition: 0.3s; }

.read-more a:after {
  position: absolute;
  right: 0;
  bottom: 0;
  width: 10px;
  height: 10px;
  content: '';
  border-bottom: 1px solid #6c5da7;
  border-right: 1px solid #6c5da7;
  padding: 10px;
  display: inline-block;
  transition: 0.3s; }

.read-more a:hover:before, .read-more a:hover:after {
  width: 100%;
  height: 100%; }

.post-meta {
  border-left: 3px solid #6c5da7;
  padding-left: 15px;
  margin-bottom: 30px; }

.post-meta p {
  color: #b1b1b1;
  font-size: 14px;
  font-style: italic;
  margin: 0; }

.post-meta p a {
  color: #b1b1b1; }

.post-meta p a:hover {
  color: #6c5da7; }

.author-meta {
  color: #b1b1b1;
  font-family: Muli,sans-serif;
  font-weight: 400;
  font-size: 14px;
  margin-bottom: 30px; }

.author-meta a {
  color: #b1b1b1; }

.author-meta a:hover {
  color: #6c5da7; }

.section-title {
  margin-bottom: 50px;
  position: relative;
  padding-left: 25px; }

.section-title:before {
  position: absolute;
  left: 0;
  top: 0;
  content: '';
  width: 5px;
  height: 100%;
  background-color: #6c5da7; }

.section-title.text-right {
  padding-left: 0;
  padding-right: 25px; }

.section-title.text-right::before {
  left: auto;
  right: 0; }

.section-title h1, .section-title h2, .section-title h3, .section-title h4, .section-title h5, .section-title h6 {
  color: #fff;
  font-family: Raleway,sans-serif;
  font-weight: 400;
  letter-spacing: 1.04px;
  text-transform: uppercase;
  margin: 0;
  line-height: 1;
  padding: 20px 0; }

.ta-carousel .owl-item.active:nth-last-child(-n+2) .top-author-content {
  float: right;
  text-align: right; }

.ta-carousel .owl-item.active:nth-last-child(-n+2) .social-share-post {
  flex-direction: row-reverse; }

.ta-carousel .owl-item.active:nth-last-child(-n+2) .social-share-post .share-post {
  left: auto;
  right: -100%; }

.ta-carousel .owl-item.active:nth-last-child(-n+2) .social-share-post:hover .share-post {
  left: auto;
  right: 0; }

.ta-carousel .owl-nav {
  position: absolute;
  right: 0;
  top: -100px; }

.ta-carousel .owl-nav button.owl-prev, .ta-carousel .owl-nav button.owl-next {
  padding-left: 15px !important; }

.ta-carousel .owl-nav button.owl-prev.disabled, .ta-carousel .owl-nav button.owl-next.disabled {
  opacity: 0.3; }

.top-authors {
  display: flex;
  flex-wrap: wrap;
  margin: 0 -10px;
  justify-content: center; }

.single-top-author {
  padding: 10px; }

.single-top-author h4 {
  font-size: 18px;
  font-family: Muli,sans-serif;
  font-weight: 400;
  margin-bottom: 15px;
  color: #fff; }

.single-top-author h4 a {
  color: #fff; }

.single-top-author:hover h4 a {
  color: #6c5da7; }

.single-top-author h3 {
  font-size: 22px;
  font-family: Playfair Display,serif;
  font-weight: 700;
  line-height: 1.3;
  margin-bottom: 10px;
  font-size: 17px; }

.single-top-author h3 a {
  color: #fff; }

.single-top-author h3 a:hover, .single-top-author h3 a:focus {
  color: #6c5da7; }

.single-top-author.active .top-author-content {
  opacity: 1;
  visibility: visible; }

.t-author-image {
  width: 135px;
  height: 135px;
  border-radius: 50%;
  overflow: hidden;
  margin-bottom: 20px; }

.top-author-content {
  width: 100vw;
  max-width: 500px;
  opacity: 0;
  visibility: hidden; }

.top-author-meta {
  margin-bottom: 15px;
  font-family: 'Libre Baskerville'; }

.top-author-meta span {
  color: #b1b1b1;
  font-size: 14px;
  font-style: italic; }

.top-author-meta span a {
  color: #b1b1b1; }

.top-author-meta span a:hover {
  color: #6c5da7; }

.social-share-post {
  display: inline-flex;
  align-items: center;
  overflow: hidden; }

.social-share-post .share-icon {
  width: 40px;
  height: 40px;
  border-radius: 50%;
  color: #fff;
  font-size: 20px;
  background-color: #b1b1b1;
  display: flex;
  align-items: center;
  justify-content: center;
  cursor: pointer;
  position: relative;
  z-index: 2; }

.social-share-post .share-icon:hover {
  background-color: #6c5da7; }

.social-share-post .share-icon:hover + .share-post {
  left: 0;
  opacity: 1;
  visibility: visible; }

.social-share-post .share-post {
  display: flex;
  align-items: center;
  justify-content: flex-start;
  background-color: #2b333a;
  padding: 5px 10px 5px 20px;
  margin-left: -10px;
  position: relative;
  left: -100%;
  transition: 0.5s;
  opacity: 0;
  visibility: hidden; }

.social-share-post .share-post li {
  margin-right: 10px; }

.social-share-post .share-post li a {
  color: #fff;
  font-size: 18px; }

.social-share-post .share-post li a:hover {
  color: #6c5da7; }

.social-share-post .share-post li:last-child {
  margin-right: 0; }

.social-share-post .share-post:hover {
  left: 0;
  opacity: 1;
  visibility: visible; }

.social-share-post:hover .share-icon {
  background-color: #6c5da7; }

.ln-card .card-img img {
  width: 100%; }

.ln-card .card-content {
  background: #121212;
  position: relative;
  margin-top: -12%;
  width: 90%;
  padding: 50px 20px 20px;
  -webkit-clip-path: polygon(0 30px, 100% 0, 100% 100%, 0% 100%);
  clip-path: polygon(0 30px, 100% 0, 100% 100%, 0% 100%); }

.ln-card .card-content h1, .ln-card .card-content h2, .ln-card .card-content h3, .ln-card .card-content h4, .ln-card .card-content h5, .ln-card .card-content h6 {
  margin: 0; }

.ln-card .card-content p {
  font-size: 16px; }

.ln-card .top-author-meta {
  position: relative;
  padding-bottom: 10px; }

.ln-card .top-author-meta::before {
  content: "";
  position: absolute;
  left: 0;
  border-bottom: 2px solid #6c5da7;
  width: 40px;
  bottom: 0; }

.ln-card .card-title {
  margin: 0;
  color: #fff; }

.ln-card .card-title:hover {
  color: #6c5da7; }

.ln-card .share-icon {
  background: rgba(255, 255, 255, 0.08); }

.latest-news {
  position: relative; }

.latest-news .owl-nav {
  position: absolute;
  bottom: calc(100% + 43px); }

.latest-news .owl-nav .owl-prev {
  margin-right: 20px; }

.latest-news .owl-nav .disabled {
  opacity: .3; }

.all-news-sec {
  background: inear-gradient(180deg, #1f2a31 0%, #121212 100%); }

.author-banner-wrapper {
  position: relative; }

.author-banner-wrapper.banner-split:before {
  content: '';
  position: absolute;
  width: 50%;
  height: 100%;
  left: 0;
  top: 0;
  background: #1a2024; }

.author-banner-wrapper.banner-split:after {
  content: '';
  position: absolute;
  width: 50%;
  height: 90%;
  left: 50%;
  top: 0;
  background: #1f2a31;
  z-index: -2; }

.author-banner-wrapper.banner-split .author-banner {
  background: transparent; }

.author-banner-wrapper .max-width {
  max-width: 1650px;
  margin-top: 50px; }

.author-banner {
  width: 100%;
  background: #273239;
  padding: 105px 0;
  background-repeat: no-repeat;
  background-position: center center;
  background-size: cover;
  position: relative; }

.author-banner .author-banner-text {
  margin: 0 auto;
  max-width: 800px;
  position: relative; }

.author-banner .author-banner-text h2 {
  font-family: Raleway,sans-serif;
  font-weight: 400;
  font-size: 50px;
  text-align: center;
  text-transform: uppercase; }

.author-banner .author-banner-text h2 i {
  margin-right: 20px; }

.author-banner .author-banner-text p {
  font-family: Muli,sans-serif;
  font-weight: 400;
  font-size: 16px;
  line-height: 32px;
  text-align: center;
  padding-bottom: 15px; }

.author-banner .author-banner-text p span {
  font-family: Raleway,sans-serif;
  font-weight: 400;
  font-size: 16px;
  line-height: 32px;
  letter-spacing: 2px; }

.author-banner.banner-overlay:before {
  content: '';
  position: absolute;
  width: 100%;
  height: 100%;
  left: 0;
  top: 0;
  background: rgba(0, 0, 0, 0.6); }

.author-card-wrapper .card {
  background: transparent !important; }

.author-card-wrapper .single-author-card {
  margin-bottom: 25px; }

.author-card-wrapper .single-author-card .card {
  min-height: 350px; }

.author-card-wrapper .single-author-card .back {
  position: absolute !important; }

.author-card-wrapper .single-author-card .back .author-card {
  height: 100%;
  justify-content: center; }

.author-card-wrapper .author-card {
  background: #39444d;
  padding: 15px;
  display: flex;
  flex-direction: column;
  justify-content: space-between; }

.author-card-wrapper .author-card .card-banner {
  width: 100%;
  height: 150px;
  border-radius: 6px;
  text-align: right;
  background-repeat: no-repeat;
  background-position: center center;
  background-size: cover;
  position: relative;
  z-index: 0; }

.author-card-wrapper .author-card .card-banner::before {
  content: '';
  position: absolute;
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  background: rgba(0, 0, 0, 0.6);
  border-radius: 6px;
  z-index: 3; }

.author-card-wrapper .author-card .card-banner p {
  position: relative;
  font-family: Muli,sans-serif;
  font-weight: 400;
  font-size: 14px;
  line-height: 28px;
  color: #e6e6e6;
  z-index: 6; }

.author-card-wrapper .author-card .author-front-img {
  position: relative;
  width: 100%;
  height: 100%;
  display: inline-flex;
  justify-content: center;
  align-items: center;
  margin-top: -40px; }

.author-card-wrapper .author-card .author-front-img img {
  width: 80px;
  height: 80px;
  border-radius: 50%;
  border: 1px solid #6c5da7; }

.author-card-wrapper .author-card .card-text {
  margin-top: 20px;
  padding-bottom: 10px;
  text-align: center; }

.author-card-wrapper .author-card .card-text a {
  color: #fff;
  font-family: Playfair Display,serif;
  font-weight: 400;
  font-size: 18px;
  line-height: 30px; }

.author-card-wrapper .author-card .card-text a i {
  margin: 5px; }

.author-card-wrapper .author-card .card-text p {
  font-family: Muli,sans-serif;
  font-weight: 400;
  font-size: 15px;
  line-height: 30px; }

.author-card-wrapper .author-card .author-about {
  display: flex;
  align-items: center; }

.author-card-wrapper .author-card .author-about .author-img {
  margin-left: 10px; }

.author-card-wrapper .author-card .author-about .author-img img {
  width: 80px;
  height: 80px;
  border-radius: 50%;
  border: 1px solid #6c5da7; }

.author-card-wrapper .author-card .author-about .author-name {
  margin-left: 16px; }

.author-card-wrapper .author-card .author-about .author-name a {
  font-family: Playfair Display,serif;
  font-weight: 400;
  font-size: 18px;
  line-height: 30px;
  color: #fff; }

.author-card-wrapper .author-card .author-about .author-name a:hover {
  color: #6c5da7; }

.author-card-wrapper .author-card .author-about .author-name p {
  font-family: Muli,sans-serif;
  font-weight: 400;
  font-size: 15px;
  line-height: 30px; }

.author-card-wrapper .author-card .author-about .author-name p i {
  margin-right: 10px; }

.author-card-wrapper .author-card .about-card-text {
  padding: 15px 0 0 20px; }

.author-card-wrapper .author-card .about-card-text p {
  font-family: Muli,sans-serif;
  font-weight: 400;
  font-size: 14px;
  line-height: 28px; }

.pagination-section {
  display: flex;
  justify-content: space-between;
  align-items: center; }

.pagination-section .pagi-number a {
  margin: 0 4px; }

.pagination-section .pagi-number a:hover {
  color: #6c5da7; }

.pagination-section a {
  color: #fff;
  font-family: Raleway,sans-serif;
  font-weight: 400;
  font-size: 20px;
  letter-spacing: 0.4px; }

.pagination-section a i {
  margin: 10px;
  font-size: 26px;
  border: 1px solid #6c5da7;
  padding: 10px; }

.pagination-section a.active {
  color: #6c5da7; }

.pagination-section a:hover i {
  background: #6c5da7;
  transition: 0.6s; }

.tag-banner-wrapper {
  position: relative; }

.tag-banner-wrapper.banner-split:before {
  content: '';
  position: absolute;
  width: 50%;
  height: 100%;
  left: 0;
  top: 0;
  background: #1a2024; }

.tag-banner-wrapper.banner-split:after {
  content: '';
  position: absolute;
  width: 50%;
  height: 90%;
  left: 50%;
  top: 0;
  background: #1f2a31;
  z-index: -2; }

.tag-banner-wrapper.banner-split .tag-banner {
  background: transparent; }

.tag-banner-wrapper .max-width {
  max-width: 1650px;
  margin-top: 50px; }

.tag-banner {
  width: 100%;
  background: #273239;
  padding: 105px 0;
  background-repeat: no-repeat;
  background-position: center center;
  background-size: cover;
  position: relative; }

.tag-banner .tag-banner-text {
  margin: 0 auto;
  max-width: 800px;
  position: relative; }

.tag-banner .tag-banner-text h2 {
  font-family: Raleway,sans-serif;
  font-weight: 400;
  font-size: 50px;
  text-align: center;
  text-transform: uppercase; }

.tag-banner .tag-banner-text h2 i {
  margin-right: 20px; }

.tag-banner .tag-banner-text p {
  font-family: Muli,sans-serif;
  font-weight: 400;
  font-size: 16px;
  line-height: 32px;
  text-align: center;
  padding-bottom: 15px; }

.tag-banner .tag-banner-text p span {
  font-family: Raleway,sans-serif;
  font-weight: 400;
  font-size: 16px;
  line-height: 32px;
  letter-spacing: 2px; }

.tag-banner.banner-overlay:before {
  content: '';
  position: absolute;
  width: 100%;
  height: 100%;
  left: 0;
  top: 0;
  background: rgba(0, 0, 0, 0.6); }

.tag-card-wrapper {
  display: grid;
  grid-template-columns: repeat(12, minmax(0, auto));
  grid-template-rows: auto;
  grid-gap: 15px;
  padding: 20px 0 70px; }

.pagination-section {
  margin-top: 35px;
  display: flex;
  justify-content: space-between;
  align-items: center; }

.pagination-section .pagi-number a {
  margin: 0 4px; }

.pagination-section .pagi-number a:hover {
  color: #6c5da7; }

.pagination-section a {
  color: #fff;
  font-family: Raleway,sans-serif;
  font-weight: 400;
  font-size: 20px;
  letter-spacing: 0.4px; }

.pagination-section a i {
  margin: 10px;
  font-size: 26px;
  border: 1px solid #6c5da7;
  padding: 10px 15px; }

.pagination-section a.active {
  color: #6c5da7; }

.pagination-section a:hover i {
  background: #6c5da7;
  transition: 0.6s; }

.tag-item {
  background-color: #39444d;
  background-repeat: no-repeat;
  background-position: center;
  background-size: cover;
  height: 260px;
  width: 100%;
  padding: 15px 0 15px 15px;
  display: flex;
  align-items: flex-end; }

.tag-item .tag-item-inner {
  background: linear-gradient(to right, #121212 0%, rgba(104, 110, 115, 0) 100%);
  padding: 15px 20px;
  width: 100%; }

.tag-item h3, .tag-item h4, .tag-item h5 {
  line-height: 1;
  font-family: Raleway,sans-serif;
  font-weight: 400;
  text-transform: uppercase;
  margin-bottom: 10px; }

.tag-item h3 a, .tag-item h4 a, .tag-item h5 a {
  color: #fff; }

.tag-item h3 a:hover, .tag-item h4 a:hover, .tag-item h5 a:hover {
  color: #6c5da7; }

.tag-item small {
  color: #e4e4e4;
  font-family: Lora,serif;
  font-weight: 400;
  font-size: 14px; }

.tag-items-wrap .tag-repeater {
  padding: 15px; }

.tag-items-wrap .tag-repeater:nth-child(11n+1) {
  width: 33%; }

.tag-items-wrap .tag-repeater:nth-child(11n+2) {
  width: 42%; }

.tag-items-wrap .tag-repeater:nth-child(11n+3) {
  width: 25%; }

.tag-items-wrap .tag-repeater:nth-child(11n+4) {
  width: 42%; }

.tag-items-wrap .tag-repeater:nth-child(11n+5) {
  width: 58%; }

.tag-items-wrap .tag-repeater:nth-child(11n+6) {
  width: 25%; }

.tag-items-wrap .tag-repeater:nth-child(11n+7) {
  width: 33%; }

.tag-items-wrap .tag-repeater:nth-child(11n+8) {
  width: 42%; }

.tag-items-wrap .tag-repeater:nth-child(11n+9) {
  width: 33.33%; }

.tag-items-wrap .tag-repeater:nth-child(11n+10) {
  width: 33.33%; }

.tag-items-wrap .tag-repeater:nth-child(11n+11) {
  width: 33.33%; }

.portfolio-card {
  position: relative; }

.portfolio-card .card-img {
  display: block; }

.portfolio-card .card-img img {
  width: 100%; }

.portfolio-card .card-content {
  position: absolute;
  top: 0;
  left: 0;
  height: 100%;
  width: 100%;
  display: flex;
  justify-content: flex-end;
  flex-direction: column;
  padding: 20px;
  background: rgba(26, 32, 36, 0.8);
  -webkit-transform: scale(0.5);
  -moz-transform: scale(0.5);
  -ms-transform: scale(0.5);
  -o-transform: scale(0.5);
  transform: scale(0.5);
  -webkit-transition: all .3s ease;
  -moz-transition: all .3s ease;
  -ms-transition: all .3s ease;
  -o-transition: all .3s ease;
  transition: all .3s ease;
  opacity: 0; }

.portfolio-card .card-content h1, .portfolio-card .card-content h2, .portfolio-card .card-content h3, .portfolio-card .card-content h4, .portfolio-card .card-content h5, .portfolio-card .card-content h6 {
  margin: 0; }

.portfolio-card .card-title {
  color: #fff; }

.portfolio-card .card-title:hover {
  color: #6c5da7; }

.portfolio-card:hover .card-content {
  opacity: 1;
  -webkit-transform: scale(1);
  -moz-transform: scale(1);
  -ms-transform: scale(1);
  -o-transform: scale(1);
  transform: scale(1); }

.portfolio-card .top-author-meta {
  position: relative;
  padding-bottom: 10px; }

.portfolio-card .top-author-meta::before {
  content: '';
  position: absolute;
  left: 0;
  border-bottom: 2px solid #6c5da7;
  width: 40px;
  bottom: 0; }

.wrap-portfolio-2 .ln-card {
  position: relative;
  overflow: hidden; }

.wrap-portfolio-2 .ln-card .card-content {
  position: absolute;
  left: 0;
  bottom: -100%;
  -webkit-transition: all .4s ease;
  -moz-transition: all .4s ease;
  -ms-transition: all .4s ease;
  -o-transition: all .4s ease;
  transition: all .4s ease;
  opacity: 0; }

.wrap-portfolio-2 .ln-card:hover .card-content {
  bottom: -2px;
  opacity: 1; }

.half-bg {
  position: relative; }

.half-bg::before {
  content: '';
  position: absolute;
  height: 100%;
  width: 50%;
  top: 0;
  left: 0;
  background: #1a2024; }

.single-portfolio-wrapper {
  padding: 50px 0; }

.single-portfolio-wrapper .single-portfolio-title {
  max-width: 620px;
  margin: 30px auto; }

.single-portfolio-wrapper .single-portfolio-title h2 {
  text-align: center;
  font-size: 35px;
  font-weight: 400;
  line-height: 58px; }

.single-portfolio-wrapper .single-portfolio-slider {
  margin-top: 45px;
  position: relative; }

.single-portfolio-wrapper .single-portfolio-slider .owl-nav {
  color: #6c5da7;
  position: absolute;
  width: calc(100% - 60px);
  display: flex;
  justify-content: space-between;
  left: 30px;
  top: 50%;
  transform: translateY(-50%); }

.single-portfolio-wrapper .single-portfolio-slider .owl-nav .owl-prev i {
  color: #6c5da7;
  font-size: 30px;
  line-height: 38px;
  background: rgba(255, 255, 255, 0.7);
  height: 50px;
  width: 50px;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center; }

.single-portfolio-wrapper .single-portfolio-slider .owl-nav .owl-prev i:hover {
  background: rgba(0, 0, 0, 0.7); }

.single-portfolio-wrapper .single-portfolio-slider .owl-nav .owl-next i {
  color: #6c5da7;
  font-size: 30px;
  line-height: 38px;
  background: rgba(255, 255, 255, 0.7);
  height: 50px;
  width: 50px;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center; }

.single-portfolio-wrapper .single-portfolio-slider .owl-nav .owl-next i:hover {
  background: rgba(0, 0, 0, 0.7); }

.single-portfolio-wrapper .portfolio-description {
  display: flex;
  justify-content: space-between;
  align-items: flex-start;
  padding: 50px 0; }

.single-portfolio-wrapper .portfolio-description .description-text {
  width: 60%;
  padding-right: 30px; }

.single-portfolio-wrapper .portfolio-description .description-text h4 {
  font-size: 24px;
  font-weight: 700;
  line-height: 32px;
  margin-bottom: 30px;
  letter-spacing: 1.5px; }

.single-portfolio-wrapper .portfolio-description .description-text button {
  margin-top: 20px;
  font-family: Raleway;
  font-size: 14px;
  font-weight: 400;
  letter-spacing: 0.28px;
  text-transform: uppercase; }

.single-portfolio-wrapper .portfolio-description .project-full-details {
  width: 40%;
  padding-left: 30px; }

.single-portfolio-wrapper .portfolio-description .project-full-details h4 {
  font-size: 24px;
  font-weight: 700;
  line-height: 32px;
  margin-bottom: 30px;
  letter-spacing: 1.5px; }

.single-portfolio-wrapper .portfolio-description .project-full-details.left-border {
  position: relative; }

.single-portfolio-wrapper .portfolio-description .project-full-details.left-border:before {
  content: '';
  position: absolute;
  left: 0px;
  top: 20px;
  height: 100%;
  border-left: 1px solid #6c5da7; }

.single-portfolio-wrapper .portfolio-description .project-full-details.content-bg {
  background: #2b333a;
  padding: 40px 30px 45px; }

.single-portfolio-wrapper .portfolio-description .project-full-details ul {
  margin-top: 30px; }

.single-portfolio-wrapper .portfolio-description .project-full-details ul li {
  color: #fff; }

.single-portfolio-wrapper .portfolio-description .project-full-details ul li a {
  color: #fff; }

.single-portfolio-wrapper .portfolio-description .project-full-details ul li a:hover {
  color: #6c5da7; }

.single-portfolio-wrapper .portfolio-description .project-full-details ul li:nth-child(n+2) {
  margin-left: 20px; }

.single-portfolio-wrapper .portfolio-description .project-full-details .project-info {
  display: flex; }

.single-portfolio-wrapper .portfolio-description .project-full-details .project-info p {
  font-style: italic; }

.single-portfolio-wrapper .portfolio-description .project-full-details .project-info h6 {
  font-weight: 700;
  letter-spacing: 0.54px;
  line-height: 30px;
  letter-spacing: 1.5px; }

.single-portfolio-wrapper .portfolio-description .project-full-details .project-info .project-info-left {
  margin-right: 100px; }

textarea, input:not([type='submit']) {
  padding: 11px 15px;
  width: 100%;
  border: 1px solid #949494;
  color: #fff;
  background: transparent;
  font-size: 14px;
  font-family: Muli,sans-serif;
  font-weight: 400; }

textarea:focus, input:not([type='submit']):focus {
  border-color: #6c5da7; }

input[type='submit'] {
  font-size: 16px;
  color: #fff;
  background: #6c5da7;
  font-family: Raleway,sans-serif;
  font-weight: 400;
  border: 0;
  padding: 10px 30px;
  cursor: pointer;
  text-transform: uppercase;
  -webkit-transition: all .3s ease;
  -moz-transition: all .3s ease;
  -ms-transition: all .3s ease;
  -o-transition: all .3s ease;
  transition: all .3s ease; }

input[type='submit']:hover {
  background: #6c5ba7; }

.contact-item {
  position: relative;
  padding-left: 30px;
  font-size: 16px;
  line-height: 1.3; }

.contact-item i {
  position: absolute;
  left: 0;
  top: 1px; }

.delas-map {
  border: 8px solid #2b333a; }

.map {
  width: 100%;
  height: 500px; }

.single-blog-inner {
  position: relative;
  margin-top: -60px;
  z-index: 4; }

.single-blog-inner .sb-left {
  margin-top: -100px; }

.banner-before {
  position: relative;
  padding: 60px 0;
  z-index: 3; }

.banner-before::before {
  position: absolute;
  left: 0px;
  top: 0;
  width: 140px;
  height: calc(100% + 18px);
  content: '';
  background-color: #1a2024;
  z-index: -1; }

.pl-banner {
  padding-left: calc((100% - 1650px) / 2 + 15px);
  position: relative; }

.pl-banner::before {
  position: absolute;
  left: 0;
  top: 0;
  width: 160px;
  height: calc(100% + 18px);
  content: '';
  background-color: #1a2024; }

.sb-content-wrap {
  padding: 50px;
  background: #1e262b; }

.single-blog .sb-left {
  width: calc(100% - 270px); }

.single-blog .sb-right {
  width: 270px; }

.single-post-content p {
  font-size: 17px;
  margin: 25px 0; }

.single-post-content p:first-child::first-letter {
  font-size: 70px;
  line-height: 1; }

.single-post-content img {
  width: 100%; }

.single-post-content ul li {
  font-size: 16px;
  font-weight: 400;
  font-family: Muli,sans-serif;
  font-weight: 400;
  color: #d4d3d3;
  position: relative;
  padding: 5px 0 5px 20px; }

.single-post-content ul li::before {
  content: '';
  position: absolute;
  left: 0;
  top: 12px;
  height: 9px;
  width: 9px;
  background: #777;
  border-radius: 50%; }

.sb-author {
  display: flex;
  align-items: center; }

.sb-author .a-img {
  height: 50px;
  width: 50px;
  border-radius: 50%;
  margin-right: 10px;
  display: flex;
  justify-content: center;
  align-items: center;
  background: #000;
  overflow: hidden; }

.sb-author .a-name {
  display: block;
  font-size: 14px;
  color: #949494;
  font-family: Muli,sans-serif;
  font-weight: 400; }

.sb-author .a-name:hover {
  color: #6c5da7; }

.sb-share p {
  font-size: 14px;
  color: #949494;
  margin: 0 10px 0 0; }

.sb-share .social-icon li a {
  color: rgba(255, 255, 255, 0.6); }

.sb-share .social-icon li a:hover {
  color: #6c5da7; }

.sb-tag-list li {
  display: inline-block; }

.sb-tag-list li a {
  border: 1px solid #949494;
  font-size: 14px;
  font-family: Muli,sans-serif;
  font-weight: 400;
  display: inline-block;
  padding: 7px 15px;
  color: rgba(255, 255, 255, 0.7);
  margin: 3px; }

.sb-tag-list li a:hover {
  color: #6c5da7;
  border-color: #6c5da7; }

.single-ap .ap-img {
  height: 100px;
  width: 100px;
  border-radius: 50%;
  overflow: hidden;
  display: block;
  margin-right: 20px; }

.single-ap .ap-img img {
  height: 100%;
  width: 100%;
  object-fit: cover; }

.single-ap h4, .single-ap h5, .single-ap h6 {
  line-height: 1.4; }

.single-ap h4 a, .single-ap h5 a, .single-ap h6 a {
  color: #fff; }

.single-ap h4 a:hover, .single-ap h5 a:hover, .single-ap h6 a:hover {
  color: #6c5da7; }

.ap-carousel .owl-dots {
  margin-top: 14px; }

.sb-head {
  background: url("../img/banner/2.jpg") no-repeat scroll center/cover; }

.blog-single-2 {
  position: relative;
  margin-top: -80px; }

.single-post-comments {
  padding-top: 70px; }

.comment-wrap-title h4 {
  border-bottom: 1px solid #2b333a;
  margin-bottom: 30px;
  padding-bottom: 20px; }

.comment-lists ul li {
  border-top: 1px solid #2b333a;
  padding: 25px 0; }

.comment-lists ul li:first-child {
  border-top: 0; }

.comment-lists ul li ul {
  margin-left: 85px;
  margin-top: 25px; }

.comment-lists ul li ul li:first-child {
  border-top: 1px solid #2b333a; }

.comment-lists ul li ul li:last-child {
  padding-bottom: 0; }

.comment-lists ul li ul li ul {
  margin-left: 0; }

.comment-content {
  display: flex;
  flex-wrap: wrap; }

.comment-content .comment-avater {
  width: 65px;
  height: 65px;
  border-radius: 50%;
  overflow: hidden;
  margin-right: 20px; }

.comment-content .author-comments {
  flex: 1; }

.comment-name {
  display: flex;
  align-items: center;
  margin-bottom: 15px; }

.comment-name h5 {
  margin-bottom: 0; }

.comment-name h5 a {
  color: #fff; }

.comment-name h5 a:hover {
  color: #6c5da7; }

.comment-name span {
  margin-left: 20px;
  color: #b1b1b1;
  font-size: 14px; }

.author-comments p {
  font-size: 15px;
  margin-bottom: 20px; }

.comment-form label {
  color: #fff;
  font-size: 16px; }

.comment-form .form-control {
  border: 1px solid gray;
  background: transparent;
  color: #d4d3d3;
  border-radius: 0;
  margin-bottom: 30px; }

.comment-form .form-control:focus {
  box-shadow: 0 0 0 transparent;
  border-color: #6c5da7; }

.comment-form button.btn:hover {
  color: #fff; }

.medium-zoom--opened .medium-zoom-overlay {
  z-index: 9;
  background-color: #121212 !important; }

.medium-zoom-image--opened {
  z-index: 10; }

.blog-sidebar {
  background: #1f2a31; }

.blog-sidebar aside {
  border-radius: 10px;
  padding: 20px 20px 30px 20px; }

.sidebar-title {
  position: relative;
  display: inline-block;
  margin-bottom: 15px;
  font-family: Raleway,sans-serif;
  font-weight: 400;
  font-size: 18px;
  text-transform: uppercase;
  padding-bottom: 10px;
  letter-spacing: 0.36px; }

.sidebar-title::before {
  content: '';
  position: absolute;
  border-top: 1px solid #6c5da7;
  width: 50px;
  bottom: 0;
  left: calc(50% - 25px); }

.about-us .a-img {
  display: block;
  border-radius: 50%;
  height: 100px;
  width: 100px;
  overflow: hidden;
  margin: auto auto 20px auto; }

.about-us .a-name {
  display: block;
  font-weight: 700;
  font-size: 20px;
  color: #fff;
  font-family: Playfair Display,serif;
  font-weight: 400; }

.about-us .a-desc {
  font-size: 14px;
  line-height: 1.7;
  color: #d4d3d3;
  font-family: Lora,serif;
  font-weight: 400; }

.social-icon li {
  display: inline-block;
  padding: 5px; }

.social-icon li a {
  color: #fff; }

.pp-item {
  padding: 10px 0; }

.pp-item:hover .pp-title {
  color: #6c5da7; }

.pp-item .pp-thumb {
  display: block;
  height: 65px;
  width: 65px;
  min-width: 65px;
  margin-right: 15px; }

.pp-item .pp-title {
  color: #fff;
  font-weight: 700;
  display: block; }

.pp-item .pp-date {
  color: #b1b1b1;
  font-size: 14px;
  font-style: italic; }

.pp-item:first-child {
  padding-top: 0; }

.pp-item:last-child {
  padding-bottom: 0;
  border: 0; }

.pp-item h6 {
  line-height: 22px;
  font-size: 16px; }

.share-social-icon li {
  display: inline-block;
  margin: 5px; }

.share-social-icon li a {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 44px;
  width: 44px;
  border-radius: 50%;
  background: rgba(255, 255, 255, 0.1);
  color: #fff; }

.share-social-icon li a:hover {
  background: #fff;
  color: #1e262b; }

.categories li {
  padding: 8px 0; }

.categories li a {
  display: block;
  color: #f1f1f1;
  font-family: Muli,sans-serif;
  font-weight: 400; }

.categories li a:hover {
  color: #6c5da7; }

.categories li a span {
  float: right;
  display: inline-block;
  padding-left: 5px; }

.categories li:last-child {
  padding-bottom: 0;
  border-bottom: 0; }

.instagram-list {
  display: flex;
  flex-wrap: wrap; }

.instagram-list li {
  padding: 5px;
  width: 33.33%; }

.subscribe-block .sc-title {
  text-transform: uppercase;
  font-size: 18px;
  font-weight: 600;
  margin-bottom: 7px; }

.subscribe-block input:not([type='submit']) {
  border: 1px solid #c1c1c1;
  padding: 12px;
  height: 50px;
  color: #fff;
  font-size: 14px;
  font-family: Lora,serif;
  font-weight: 400;
  width: 100%; }

.subscribe-block input[type='submit'], .subscribe-block button[type='submit'] {
  width: 100%;
  background: #6c5da7;
  color: #fff;
  text-transform: uppercase;
  font-size: 16px;
  font-family: Raleway,sans-serif;
  font-weight: 400;
  border: 0;
  height: 50px;
  margin-top: 20px;
  cursor: pointer; }

.tf-item {
  font-size: 13px;
  font-style: italic;
  font-family: Lora,serif;
  font-weight: 400;
  color: #949494; }

.tf-item time {
  display: block;
  margin-bottom: 10px; }

.tf-item p {
  color: #d4d3d3;
  font-family: Lora,serif;
  font-weight: 400;
  font-size: 14px; }

.tf-item p a {
  color: #f1f1f1; }

.tf-item p a:hover {
  color: #6c5da7; }

.carousel-dots .owl-dots {
  text-align: center; }

.carousel-dots .owl-dots .owl-dot {
  height: 8px;
  width: 8px;
  border-radius: 50%;
  background: rgba(255, 255, 255, 0.5);
  margin: 3px;
  display: inline-block; }

.carousel-dots .owl-dots .owl-dot.active {
  width: 26px;
  background: #6c5da7;
  border-radius: 10px; }

.page-wrapper {
  overflow: hidden; }

.single-post-content blockquote {
  margin: 30px 0; }

.single-post-content blockquote:nth-child(3n+1) {
  font-family: Playfair Display,serif;
  font-weight: 400;
  font-size: 16px;
  color: #fff;
  position: relative;
  padding: 65px 20px 20px 20px;
  text-align: center;
  line-height: 1.8; }

.single-post-content blockquote:nth-child(3n+1)::before {
  content: '\f10d';
  font-family: FontAwesome;
  position: absolute;
  font-size: 30px;
  top: 0;
  left: 50%;
  transform: translate(-50%);
  color: #b1b1b1; }

.single-post-content blockquote:nth-child(3n+2) {
  font-family: Muli,sans-serif;
  font-weight: 400;
  font-size: 16px;
  color: #d4d3d3;
  line-height: 1.8;
  padding: 25px 25px 25px 50px;
  background: #1f2a31;
  position: relative; }

.single-post-content blockquote:nth-child(3n+2)::before {
  content: '';
  border-left: 6px solid #304354;
  position: absolute;
  top: 25px;
  left: 22px;
  height: calc(100% - 50px); }

.single-post-content blockquote:nth-child(3n+3) {
  font-family: Muli,sans-serif;
  font-weight: 400;
  background: #1f2a31;
  color: #d4d3d3;
  text-align: center;
  position: relative;
  padding: 65px 20px 20px 20px; }

.single-post-content blockquote:nth-child(3n+3)::before {
  content: '\f10d';
  font-family: FontAwesome;
  position: absolute;
  font-size: 30px;
  top: 10px;
  left: 50%;
  transform: translate(-50%);
  color: #b1b1b1; }

.single-post-content figcaption {
  color: #fff;
  text-align: center;
  margin: 5px 0;
  font-size: 14px; }

.single-post-content h2 {
  text-align: left; }

.single-post-content ul, .single-post-content ol {
  color: #fff;
  margin-left: 20px;
  margin-bottom: 20px; }

.single-post-content ul li, .single-post-content ol li {
  padding: 5px 20px; }

.single-post-content ol {
  padding-left: 20px; }

.single-post-content .table th {
  border-top: 0; }

.single-post-content .table thead th {
  border-bottom: transparent !important; }

.single-post-content .table th, .single-post-content .table td {
  color: #fff; }

.wide-image {
  width: 70vw;
  margin-left: -35vw;
  left: 50%;
  position: relative;
  right: 50%;
  margin-top: 25px;
  margin-bottom: 25px; }

.full-wide-image {
  width: 100vw;
  margin-left: -50vw;
  left: 50%;
  position: relative;
  right: 50%;
  margin-top: 25px;
  margin-bottom: 25px; }

.about-us-wrapper {
  padding: 110px 0; }

.about-us-wrapper .about-title-section-wrapper {
  display: flex; }

.about-us-wrapper .about-title-section-wrapper .about-page-title .title-text {
  max-width: 800px;
  margin-top: 80px;
  padding-right: 20px; }

.about-us-wrapper .about-title-section-wrapper .about-page-title .title-text h6 {
  color: #6c5da7;
  font-family: Raleway;
  font-size: 18px;
  font-weight: 500;
  letter-spacing: 2.16px;
  text-transform: uppercase;
  margin-bottom: 0; }

.about-us-wrapper .about-title-section-wrapper .about-page-title .title-text h1 {
  font-size: 56px;
  font-weight: 400;
  line-height: 75px; }

.about-us-wrapper .estabilishment-section {
  padding: 150px 0;
  display: flex;
  flex-direction: column;
  max-width: 960px;
  margin: 0 auto; }

.about-us-wrapper .estabilishment-section .estabilishment-text {
  text-align: center; }

.about-us-wrapper .estabilishment-section .estabilishment-text h6 {
  color: #6c5da7;
  font-family: Raleway;
  font-size: 16px;
  font-weight: 400;
  letter-spacing: 1.92px;
  text-transform: uppercase; }

.about-us-wrapper .estabilishment-section .estabilishment-text p {
  font-family: "Playfair Display";
  font-size: 28px;
  font-weight: 400;
  line-height: 47px; }

.about-us-wrapper .estabilishment-section .estabilishment-text button {
  margin-top: 70px;
  font-family: Raleway;
  font-size: 14px;
  font-weight: 400;
  letter-spacing: 0.28px;
  text-transform: uppercase;
  position: relative; }

.about-us-wrapper .estabilishment-section .estabilishment-text button:before {
  content: '';
  position: absolute;
  left: 50%;
  top: -60px;
  height: 40px;
  border-left: 2px solid #6c5da7; }

.about-us-wrapper .target-section-wrapper {
  display: flex; }

.about-us-wrapper .target-section-wrapper .target-image {
  width: 40%; }

.about-us-wrapper .target-section-wrapper .target-section-text-wrapper {
  margin: 50px 0 0 30px;
  width: 60%; }

.about-us-wrapper .target-section-wrapper .target-section-text-wrapper .target-section-text h4 {
  font-size: 24px;
  font-weight: 700;
  letter-spacing: 0.48px; }

.about-us-wrapper .target-section-wrapper .target-section-text-wrapper .target-section-text p {
  font-size: 16px;
  font-weight: 400;
  line-height: 30px; }

.about-us-wrapper .target-section-wrapper .target-section-text-wrapper .target-section-text p small {
  font-family: "SignPainter";
  font-size: 16px;
  font-weight: 400;
  line-height: 30px; }

.about-us-wrapper .success-section-wrapper {
  padding-top: 120px; }

.about-us-wrapper .success-section-wrapper .success-title {
  margin-bottom: 50px;
  text-align: center; }

.about-us-wrapper .success-section-wrapper .success-title h6 {
  color: #6c5da7;
  font-family: Raleway;
  font-size: 16px;
  font-weight: 400;
  letter-spacing: 1.92px;
  text-transform: uppercase; }

.about-us-wrapper .success-section-wrapper .success-title h3 {
  font-size: 35px;
  font-weight: 400; }

.about-us-wrapper .success-section-wrapper .success-items-area {
  display: flex;
  justify-content: center;
  margin-top: 40px; }

.about-us-wrapper .success-section-wrapper .success-items-area .single-success {
  width: 30%;
  text-align: center;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center; }

.about-us-wrapper .success-section-wrapper .success-items-area .single-success h1 {
  font-family: "Libre Baskerville";
  font-size: 45px;
  font-weight: 700;
  line-height: 75px; }

.about-us-wrapper .success-section-wrapper .success-items-area .single-success h6 {
  font-family: Raleway;
  font-size: 16px;
  font-weight: 400;
  letter-spacing: 0.8px;
  text-transform: uppercase; }

.about-us-wrapper .success-section-wrapper .success-items-area .single-success .success-icon {
  width: 60px;
  height: 60px; }

.about-us-wrapper .authors-section-wrapper {
  text-align: center;
  padding-top: 100px; }

.about-us-wrapper .authors-section-wrapper .authors-section-title {
  margin-bottom: 50px; }

.about-us-wrapper .authors-section-wrapper .authors-section-title h6 {
  color: #6c5da7;
  font-family: Raleway;
  font-size: 16px;
  font-weight: 400;
  letter-spacing: 1.92px;
  text-transform: uppercase; }

.about-us-wrapper .authors-section-wrapper .authors-section-title h3 {
  font-size: 35px;
  font-weight: 400; }

.about-us-wrapper .authors-section-wrapper .authors-area {
  position: relative; }

.about-us-wrapper .authors-section-wrapper .authors-area .owl-nav {
  color: #6c5da7;
  position: absolute;
  width: calc(100% + 50px);
  display: flex;
  justify-content: space-between;
  top: 50%;
  left: -25px;
  transform: translateY(-50%); }

.about-us-wrapper .authors-section-wrapper .authors-area .owl-nav .owl-prev i {
  color: #fff;
  font-size: 60px;
  line-height: 78px; }

.about-us-wrapper .authors-section-wrapper .authors-area .owl-nav .owl-prev i:hover {
  color: red; }

.about-us-wrapper .authors-section-wrapper .authors-area .owl-nav .owl-next i {
  color: #fff;
  font-size: 60px;
  line-height: 78px; }

.about-us-wrapper .authors-section-wrapper .authors-area .owl-nav .owl-next i:hover {
  color: red; }

.about-us-wrapper .authors-section-wrapper .authors-area .owl-dots {
  text-align: center;
  position: absolute;
  left: 50%;
  transform: translateX(-50%); }

.about-us-wrapper .authors-section-wrapper .authors-area .owl-dots .owl-dot {
  height: 10px;
  width: 10px;
  padding: 5px;
  border-radius: 50%;
  background: #b1b1b1;
  margin: 0px 5px;
  cursor: pointer; }

.about-us-wrapper .authors-section-wrapper .authors-area .owl-dots .owl-dot.active {
  background-color: #6c5da7;
  width: 30px;
  height: 9px;
  border-radius: 10px; }

.about-us-wrapper .authors-section-wrapper .authors-area .single-author {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center; }

.about-us-wrapper .authors-section-wrapper .authors-area .single-author h6 {
  font-family: "Libre Baskerville";
  font-size: 16px;
  font-weight: 400;
  line-height: 28px; }

.about-us-wrapper .authors-section-wrapper .authors-area .single-author .author-img {
  margin-bottom: 20px; }

.about-us-wrapper .authors-section-wrapper .authors-area .single-author .author-img img {
  width: 133px;
  height: 133px;
  border-radius: 50%; }

@media all and (max-width: 1199px) {
  .author-card-wrapper .single-author-card {
    margin-bottom: 100px; }

  .about-us-wrapper .about-title-section-wrapper {
    display: flex;
    flex-wrap: wrap;
    flex-direction: column-reverse;
    align-items: center;
    text-align: center; }

  .about-us-wrapper .target-section-wrapper {
    display: flex;
    flex-wrap: wrap;
    flex-direction: column;
    align-items: center;
    text-align: center; }

  .about-us-wrapper .target-section-wrapper .target-image {
    width: 100%; }

  .about-us-wrapper .target-section-wrapper .target-section-text-wrapper {
    width: 100%;
    margin: 50px 0 0; } }
@media all and (max-width: 991px) {
  .main-menu .mainmenu-list {
    position: fixed;
    left: -400px;
    top: 0;
    min-height: 100vh;
    max-width: 300px;
    width: 100%;
    z-index: 4;
    align-items: flex-start;
    padding-top: 20px;
    padding-left: 15px;
    max-height: 100%;
    overflow-y: auto; }

  .main-menu .mainmenu-list ul {
    flex-direction: column;
    margin-top: 30px;
    justify-content: flex-start; }

  .main-menu .mainmenu-list ul li {
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    height: auto; }

  .main-menu .mainmenu-list ul li a {
    display: flex;
    justify-content: space-between;
    line-height: 1;
    padding: 10px 0;
    width: 100%; }

  .main-menu .mainmenu-list ul li ul {
    position: relative;
    width: 100%;
    top: 0;
    visibility: visible;
    margin-top: 0;
    padding: 5px 0;
    left: 0 !important;
    background-color: transparent;
    display: none;
    opacity: 1; }

  .main-menu .mainmenu-list ul li ul li {
    margin-right: 0; }

  .main-menu .mainmenu-list ul li ul li a {
    padding: 5px 0; }

  .main-menu .mainmenu-list.hide-menu {
    left: -100%;
    opacity: 0;
    top: 0; }

  .main-menu .mainmenu-list.active {
    left: -20px;
    opacity: 1;
    top: 0; }

  .author-card-wrapper .single-author-card {
    margin-bottom: 80px; }

  .single-top-author .top-author-content {
    width: 100%; }

  .single-top-author:nth-last-child(-n+2) .top-author-content {
    float: none;
    text-align: left; }

  .single-top-author:nth-last-child(-n+2) .social-share-post {
    flex-direction: row; }

  .single-top-author:nth-last-child(-n+2) .social-share-post .share-post {
    left: -100%;
    right: auto; }

  .single-top-author:nth-last-child(-n+2) .social-share-post:hover .share-post {
    left: 0;
    right: auto; }

  .single-blog .sb-right, .single-blog .sb-left {
    width: 100%; }

  .tag-items-wrap .tag-repeater:nth-child(4n+1) {
    width: 58%; }

  .tag-items-wrap .tag-repeater:nth-child(4n+2) {
    width: 42%; }

  .tag-items-wrap .tag-repeater:nth-child(4n+3) {
    width: 42%; }

  .tag-items-wrap .tag-repeater:nth-child(4n+4) {
    width: 58%; }

  .single-portfolio-wrapper .portfolio-description {
    display: block; }

  .single-portfolio-wrapper .portfolio-description .description-text {
    width: 100%;
    padding-right: 0; }

  .single-portfolio-wrapper .portfolio-description .project-full-details {
    width: 100%;
    padding-left: 0;
    margin-top: 50px; }

  .single-portfolio-wrapper .portfolio-description .project-full-details.left-border:before {
    display: none; }

  .wide-image {
    width: 100%;
    margin-left: 0;
    left: auto;
    position: relative;
    right: auto; } }
@media all and (max-width: 767px) {
  .featured-slider .single-slide {
    padding-left: 60px;
    padding-right: 60px; }

  .featured-slider .single-slide:after {
    left: -30px; }

  .featured-slider.owl-carousel .owl-nav {
    right: 30px; }

  .featured-slider.owl-carousel .owl-dots {
    right: 30px; }

  .single-slide-content h2 {
    font-size: 36px; }

  .author-card-wrapper .single-author-card {
    margin-bottom: 50px; }

  .tag-items-wrap .tag-repeater:nth-child(n) {
    width: 100%; }

  .about-us-wrapper .about-title-section-wrapper .about-page-title .title-text h1 {
    font-size: 44px;
    font-weight: 400;
    line-height: 1.4; }

  .about-us-wrapper .estabilishment-section {
    padding: 72px 0; }

  .about-us-wrapper .success-section-wrapper {
    padding-top: 72px; }

  .about-us-wrapper .success-section-wrapper .success-items-area {
    display: flex;
    flex-wrap: wrap;
    flex-direction: column; }

  .about-us-wrapper .success-section-wrapper .success-items-area .single-success {
    width: 100%;
    text-align: center; }

  .about-us-wrapper .success-section-wrapper .success-items-area .single-success:nth-child(n+2) {
    margin-top: 50px;
    text-align: center; }

  .about-us-wrapper .authors-section-wrapper {
    padding-top: 72px; }

  .style-gallery-sec .style-gallery-grid {
    display: grid;
    grid-template-columns: repeat(4, minmax(0, auto));
    grid-template-rows: auto;
    grid-gap: 15px; }

  .style-gallery-sec .style-gallery-grid .style-grid {
    grid-column: span 2; }

  .style-gallery-sec .style-gallery-grid .style-grid img {
    width: 100%;
    height: 100%; }

  .style-gallery-sec .style-gallery-grid .style-grid.style-col-2 {
    grid-column: span 4; }

  .section-padding {
    padding-top: 50px;
    padding-bottom: 50px; } }
@media all and (max-width: 575px) {
  .featured-slider .single-slide {
    padding: 60px 15px 100px; }

  .featured-slider .single-slide:after {
    left: auto;
    right: -20px;
    top: 90px;
    transform: translateY(0) rotate(90deg);
    letter-spacing: 3px; }

  .featured-slider.owl-carousel .owl-nav {
    right: 15px;
    bottom: 80px; }

  .featured-slider.owl-carousel .owl-dots {
    right: auto;
    left: 15px;
    bottom: 70px;
    flex-direction: row;
    top: auto; }

  .featured-slider.owl-carousel .owl-dots .owl-dot {
    margin-right: 10px; }

  .form-group {
    display: flex;
    flex-wrap: wrap;
    justify-content: center; }

  .form-group button {
    margin-top: 20px; }

  .pagination-section .newer-post .hide, .pagination-section .older-post .hide {
    display: none; }

  .sb-content-wrap {
    padding: 20px; }

  .style-gallery-sec .style-gallery-grid {
    display: grid;
    grid-template-columns: repeat(1, minmax(0, auto));
    grid-template-rows: auto;
    grid-gap: 15px; }

  .style-gallery-sec .style-gallery-grid .style-grid {
    grid-column: span 1; }

  .style-gallery-sec .style-gallery-grid .style-grid img {
    width: 100%;
    height: 100%; }

  .style-gallery-sec .style-gallery-grid .style-grid.style-col-2 {
    grid-column: span 1; }

  .ta-carousel {
    text-align: center; }

  .ta-carousel .owl-item.active:nth-last-child(-n+2) .social-share-post {
    flex-direction: row; }

  .ta-carousel .owl-item.active:nth-last-child(-n+2) .social-share-post .share-post {
    left: -100%;
    right: auto; }

  .ta-carousel .owl-item.active:nth-last-child(-n+2) .social-share-post:hover .share-post {
    left: 0;
    right: 0; }

  .ta-carousel .single-top-author {
    text-align: center;
    display: flex;
    flex-direction: column;
    align-items: center; }

  .ta-carousel .single-top-author .top-author-content {
    visibility: visible;
    opacity: 1;
    text-align: center !important; }

  .ta-carousel .single-top-author .top-author-content .social-share-post {
    display: flex;
    overflow: hidden;
    justify-content: center; }

  .tag-banner .tag-banner-text h2 {
    font-size: 40px; }

  .author-banner .author-banner-text h2 {
    font-size: 40px; }

  .footer-wrapper .subscribe-section .subscribe-text h2 {
    font-size: 40px; }

  .footer-wrapper .subscribe-section .subscribe-text p {
    font-size: 24px; }

  .section-title {
    padding-right: 80px; }

  .section-title h4 {
    line-height: 1.3; }

  .ta-carousel .owl-nav {
    width: 80px;
    display: flex; }

  .single-blog-inner .sb-left {
    margin-top: 0; }

  .footer-wrapper .subscribe-section .subscribe-form .form-group .form-control {
    margin-right: 0; }

  .single-portfolio-wrapper .single-portfolio-slider .owl-nav {
    width: calc(100% - 30px);
    left: 15px; }

  .go-top {
    right: 10px; } }
@media all and (max-width: 400px) {
  .logo {
    padding-right: 15px; }

  .single-portfolio-wrapper .project-full-details .project-info {
    display: flex;
    flex-wrap: wrap;
    flex-direction: column; }

  .expanded-search .search-box input {
    padding: 10px 20px 10px 60px; }

  .expanded-search .search-box {
    position: fixed;
    top: 0;
    height: auto;
    width: 100vw;
    height: 70px; }

  .expanded-search .search-box .search-close-trigger {
    position: absolute;
    top: calc(50% - 11px);
    left: 32px;
    cursor: pointer; }

  .expanded-search.active .search-box {
    width: 100vw; }

  .ln-card .card-content {
    padding-top: 40px; } }
.iconbox:hover, .iconbox:focus {
  box-shadow: none !important; }

.fancy-box-travel .fancy-box-time {
  font-weight: 300; }

.bordered-text {
  padding-left: 30px;
  border-radius: 50em;
  padding-right: 60px; }

.bordered-text .white {
  border: 1px solid #ffffff; }

.bordered-text .purple {
  border: 1px solid #6c5ba7; }

.bg-dark, .bg-dark-too {
  background: -webkit-linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  background: -moz-linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  background: -ms-linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  background: -o-linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  background: linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
  background-repeat: no-repeat !important;
  background-attachment: fixed !important;
  color: #fff;
  font-family: 'Raleway';
  font-weight: 100; }

::selection {
  color: #6c5ba7;
  background: #212121; }

body {
  min-height: 100%;
  background: -webkit-linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  background: -moz-linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  background: -ms-linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  background: -o-linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  background: linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
  background-repeat: no-repeat;
  background-attachment: fixed;
  color: #fff;
  font-family: 'Raleway';
  font-weight: 100; }

strong {
  font-weight: 300; }

h1, h2, h3, h4, h5, h6 {
  font-weight: 100;
  text-transform: uppercase;
  font-family: 'Josefin Sans'; }

.greedy-nav {
  background-color: transparent; }

.mb-120 {
  margin-bottom: 120px; }

.gimme-some-20 {
  margin-top: 20px;
  margin-bottom: 20px; }

.gimme-some-20h {
  margin-left: 20px;
  margin-right: 20px; }

.neu-dark-bg {
  min-height: 100%;
  background: -webkit-linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  background: -moz-linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  background: -ms-linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  background: -o-linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  background: linear-gradient(333.76deg, #26272B 22.72%, #34393F 89.31%) !important;
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
  background-repeat: no-repeat;
  background-attachment: fixed;
  color: #fff;
  font-family: 'Raleway';
  font-weight: 100; }

.neubutton, .btn {
  background: linear-gradient(165.64deg, #26272B 9.53%, #34393F 95.92%);
  box-shadow: 10px 10px 40px #0D0E0F, -10px -10px 40px #40464E;
  border-radius: 40px;
  width: fit-content;
  color: #fff !important;
  margin: 10px;
  padding-left: 20px;
  padding-right: 20px;
  padding-top: 15px;
  padding-bottom: 15px;
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1); }

.neubutton::after, .btn::after {
  content: "";
  position: absolute;
  left: 0%;
  right: 0%;
  top: 0%;
  bottom: 0%;
  background: linear-gradient(165.64deg, #26272B 9.53%, #34393F 95.92%);
  box-shadow: inset 3px 3px 10px #0D0E0F, inset -3px -3px 10px #40464E;
  border-radius: 40px;
  opacity: 0;
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1); }

.btn:hover, .btn:focus, .btn:active, .neubutton:hover, button:focus, .neubutton:focus {
  -webkit-transform: scale(1, 1);
  transform: scale(1, 1); }

.btn:hover::after, .btn:active::after, .btn:focus::after, .neubutton:hover::after, .neubutton:active::after, .neubutton:focus::after {
  opacity: 1; }

.neubutton.alt::after {
  content: "";
  border-radius: 20px;
  color: #fff;
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  box-shadow: inset 3px 3px 10px #0D0E0F, inset -3px -3px 10px #40464E;
  opacity: 0;
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  background: linear-gradient(130.46deg, #2E1A47 12.58%, #6c5ba7 89.78%); }

.neuicon i {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  color: rgba(255, 255, 255, 0.5) !important; }

.text-chosen {
  color: #6c5ba7;
  font-weight: 300; }

.neuicon-holder-small {
  width: 35px;
  height: 35px; }

.neuicon-holder-medium {
  width: 50px;
  height: 50px; }

.neuicon-holder-large {
  width: 75px;
  height: 75px; }

.neuicon {
  text-align: center;
  opacity: 1;
  position: relative;
  width: 100%;
  height: 100%;
  display: inline-block;
  border-radius: 20px;
  box-shadow: 1px 1px 5px #0D0E0F, -3px -3px 9px #353B42, inset 1px 1px 9px #2D2E35;
  background: linear-gradient(128.11deg, #26272B 6.67%, #34393F 97.78%);
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1); }

.neuicon::after {
  content: "";
  border-radius: 20px;
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  box-shadow: inset 3px 3px 10px #0D0E0F, inset -3px -3px 10px #40464E;
  opacity: 0;
  background: linear-gradient(137.63deg, #26272B 9.53%, #34393F 95.92%);
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1); }

.neuicon.alt::after {
  content: "";
  border-radius: 20px;
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  box-shadow: inset 3px 3px 10px #0D0E0F, inset -3px -3px 10px #40464E;
  opacity: 0;
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  background: linear-gradient(130.46deg, #2E1A47 12.58%, #6c5ba7 89.78%); }

.neuicon.altalt::after {
  content: "";
  border-radius: 20px;
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  opacity: 0;
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  background: linear-gradient(130.46deg, #564887 12.58%, #6c5ba7 89.78%);
  box-shadow: 4px 3px 19px #0D0F0F, -5px -5px 20px #404E4A, inset 1px 1px 7px #6c5ba7; }

.neuicon:hover::after {
  opacity: 1; }

.neuicon:hover {
  -webkit-transform: scale(1, 1);
  transform: scale(1, 1); }

.neuicon:hover::after {
  opacity: 1; }

.neubutton {
  text-align: center;
  opacity: 1;
  position: relative;
  box-shadow: 1px 1px 5px #0D0E0F, -3px -3px 9px #353B42, inset 1px 1px 9px #2D2E35;
  background: linear-gradient(128.11deg, #26272B 6.67%, #34393F 97.78%);
  border-radius: 40px;
  width: fit-content;
  padding-left: 20px;
  padding-right: 20px;
  padding-top: 5px;
  padding-bottom: 5px;
  display: inline-block;
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1); }

.neubutton::after {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  opacity: 0;
  background: linear-gradient(165.64deg, #26272B 9.53%, #34393F 95.92%);
  box-shadow: inset 3px 3px 10px #0D0E0F, inset -3px -3px 10px #40464E;
  border-radius: 40px;
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1); }

.neubutton.alt::after {
  content: "";
  border-radius: 40px;
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  opacity: 0;
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  box-sizing: border-box;
  box-shadow: inset 3px 3px 10px #0D0E0F, inset -3px -3px 10px #40464E;
  background: linear-gradient(130.46deg, #2E1A47 12.58%, #6c5ba7 89.78%); }

textarea, input {
  font-weight: 100;
  border: 0;
  border-radius: 40px;
  width: 100%;
  color: #fff;
  padding: 15px;
  background: linear-gradient(149.55deg, #26272B 9.53%, #34393F 95.92%);
  box-shadow: inset 3px 3px 10px #0D0E0F, inset -3px -3px 10px #40464E; }

.neubutton:hover::after {
  opacity: 1; }

.neubutton:hover {
  -webkit-transform: scale(1, 1);
  transform: scale(1, 1); }

.neubutton:hover::after {
  opacity: 1; }

.neumorphic {
  margin: 20px;
  position: relative;
  display: inline-block;
  padding: 25px;
  width: 100%;
  height: 100%;
  border-radius: 40px;
  box-shadow: 1px 1px 5px #0D0E0F, -3px -3px 9px #353B42, inset 1px 1px 9px #2D2E35;
  background: linear-gradient(128.11deg, #26272B 6.67%, #34393F 97.78%);
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1); }

.fancy-box-image:hover {
  backdrop-filter: grayscale(0.5) opacity(0.8); }

.neumorphic::after {
  content: "";
  border-radius: 40px;
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  opacity: 0;
  background: linear-gradient(165.64deg, #26272B 9.53%, #34393F 95.92%);
  box-shadow: inset 3px 3px 10px #0D0E0F, inset -3px -3px 10px #40464E;
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1); }

.neumorphic:hover {
  -webkit-transform: scale(1, 1);
  transform: scale(1, 1); }

.neumorphic:hover::after {
  opacity: 1; }

.neuradius {
  border-radius: 40px !important; }

.neustyle {
  border-radius: 40px !important;
  box-shadow: 1px 1px 5px #0D0E0F, -3px -3px 9px #353B42, inset 1px 1px 9px #2D2E35;
  background: linear-gradient(128.11deg, #26272B 6.67%, #34393F 97.78%);
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1); }

.neustyle::after {
  content: "";
  border-radius: 40px;
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background: linear-gradient(165.64deg, #26272B 9.53%, #34393F 95.92%);
  box-shadow: inset 3px 3px 10px #0D0E0F, inset -3px -3px 10px #40464E;
  opacity: 0;
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1); }

.neustyle:hover {
  -webkit-transform: scale(1, 1);
  transform: scale(1, 1); }

.neustyle:hover::after {
  opacity: 1; }

.liquid-lp-category a {
  border: none !important; }

.fancy-box {
  position: relative;
  margin-bottom: 30px; }

.fancy-box figure {
  background-size: cover; }

.fancy-box h3 {
  font-size: em(24);
  line-height: 1.5em;
  letter-spacing: 0;
  margin: 0; }

.fancy-box p {
  margin: 0; }

.fancy-box img {
  width: 100%; }

.fancy-box .cb-img-container,
.fancy-box .fancy-box-image {
  position: relative; }

.fancy-box .cb-img-container {
  overflow: hidden; }

.fancy-box .blur-main-image,
.fancy-box .blur-image-canvas,
.fancy-box .blur-image-inner,
.fancy-box .blur-image-container {
  position: absolute;
  top: 0;
  left: 0; }

.fancy-box .blur-image-container,
.fancy-box .blur-image-inner {
  width: 100%;
  height: 100%; }

.fancy-box .blur-image-container {
  transform: translateZ(0); }

.fancy-box .blur-image-canvas {
  width: 100% !important;
  height: 100% !important;
  object-fit: cover; }

.fancy-box .cb-img-overlay {
  width: 100%;
  height: 100%;
  position: absolute;
  top: 0;
  left: 0;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.3s, visibility 0.3s;
  background-size: cover;
  background-position: center; }

.fancy-box .fancy-box-footer {
  position: relative;
  z-index: 2; }

.fancy-box:hover .cb-img-overlay {
  opacity: 1;
  visibility: visible; }

.fancy-box:hover .cb-img-btn {
  opacity: 1;
  visibility: visible; }

.fancy-box:hover .cb-img-btn-inner {
  transform: scale3d(1, 1, 1);
  transition-delay: 0.05s; }

.fancy-box:hover .cb-img-btn-inner .btn {
  opacity: 1;
  transform: scale3d(1, 1, 1);
  transition-delay: 0.18s; }

.cb-subtitle {
  display: inline-block;
  padding: 3px 10px;
  margin-bottom: 10px;
  background-color: var(--color-primary);
  font-size: 12px; }

.cb-img-btn-bg,
.cb-img-btn {
  width: 100%;
  height: 100%;
  position: absolute;
  top: 0;
  left: 0; }

.cb-img-btn-inner {
  display: flex;
  padding: 15px;
  border: 2px solid #fff;
  position: absolute;
  top: 15px;
  left: 15px;
  bottom: 15px;
  right: 15px;
  align-items: center;
  justify-content: center;
  transform: scale3d(1.1, 1.1, 0);
  transition: transform 0.8s cubic-bezier(0.17, 0.67, 0.2, 1); }

.cb-img-btn {
  background-color: rgba(0, 0, 0, 0.35);
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.3s, visibility 0.3s; }

.cb-img-btn .liquid-overlay-link {
  z-index: 2; }

.cb-img-btn .btn {
  opacity: 0;
  transform: scale3d(1.1, 1.1, 0); }

.cb-img-btn .btn-naked {
  color: #fff; }

/* Content box styles */
.fancy-box-booking .fancy-box-contents {
  padding: em(50) em(30); }

.fancy-box-booking .fancy-box-info {
  width: 75%;
  margin: em(45) em(30);
  position: relative; }

.fancy-box-booking .fancy-box-info:before {
  content: '';
  display: inline-block;
  width: em(30);
  height: 1px;
  position: absolute;
  top: 0.5em;
  left: -60px;
  background-color: var(--color-primary); }

.fancy-box-booking .fancy-box-header {
  display: inline-block;
  padding: em(10) em(30) em(20);
  position: absolute;
  bottom: 0;
  left: em(30);
  transform: translateY(50%);
  background-color: #fff;
  box-shadow: 0 7px 50px rgba(0, 0, 0, 0.1); }

.fancy-box-booking .fancy-box-details {
  font-size: 12px;
  text-transform: uppercase;
  letter-spacing: 0.1em;
  color: var(--color-primary); }

.fancy-box-booking .fancy-box-details > span:after {
  content: '\2758';
  margin-left: 1em;
  margin-right: 0.83em; }

.fancy-box-booking .fancy-box-details > span:last-child:after {
  content: none; }

.fancy-box-booking .btn {
  box-shadow: 0 10px 40px rgba(0, 0, 0, 0.075); }

.fancy-box-classes {
  background-color: #fff;
  box-shadow: 0 0 0 rgba(0, 0, 0, 0.15);
  transition: box-shadow 0.45s cubic-bezier(0.32, 0.98, 0.37, 1); }

.fancy-box-classes .fancy-box-contents {
  padding: em(16) 25px; }

.fancy-box-classes h3 {
  margin-bottom: em(7); }

.fancy-box-classes .fancy-box-label {
  display: inline-block;
  padding: 4px 10px;
  position: absolute;
  top: 30px;
  left: 0;
  font-size: 12px;
  font-weight: 600;
  letter-spacing: 0.025em;
  color: #fff;
  background: linear-gradient(to right, var(--color-gradient-start) 0%, var(--color-gradient-stop) 100%); }

.fancy-box-classes .trainer {
  font-size: em(13);
  color: #828593; }

.fancy-box-classes .trainer i {
  display: inline-block;
  margin-right: 5px; }

.backgroundcliptext .fancy-box-classes .trainer i {
  padding-top: 1px;
  background: linear-gradient(to right, var(--color-gradient-start) 0%, var(--color-gradient-stop) 100%);
  background-clip: text !important;
  -webkit-background-clip: text !important;
  text-fill-color: transparent !important;
  -webkit-text-fill-color: transparent !important; }

.fancy-box-classes:hover {
  box-shadow: 0 30px 50px rgba(0, 0, 0, 0.07); }

.flickity-slider .fancy-box-classes {
  margin-bottom: 50px; }

.fancy-box-travel {
  padding-bottom: 64.5%;
  overflow: hidden;
  color: #fff; }

.fancy-box-travel h3 {
  margin: em(7) 0;
  text-transform: uppercase;
  font-weight: 700;
  letter-spacing: 0;
  color: #fff; }

.fancy-box-travel .fancy-box-image,
.fancy-box-travel .fancy-box-contents {
  position: absolute;
  bottom: 0;
  left: 0;
  right: 0; }

.fancy-box-travel .fancy-box-image {
  width: 100%;
  height: 100%;
  background-size: cover;
  background-position: center;
  z-index: 0;
  transition: transform 0.5s cubic-bezier(0.86, 0, 0.07, 1), filter 0.5s cubic-bezier(0.86, 0, 0.07, 1); }

.fancy-box-travel .fancy-box-image img {
  visibility: hidden; }

.fancy-box-travel .fancy-box-contents {
  margin: 30px;
  z-index: 2; }

.fancy-box-travel .fancy-box-time {
  display: inline-block;
  padding: em(4) em(10);
  background-color: var(--color-primary);
  font-size: em(12);
  letter-spacing: 0.05em; }

.fancy-box-travel .fancy-box-footer {
  margin-top: em(30); }

.fancy-box-travel .btn {
  font-size: em(14);
  font-weight: 700; }

.fancy-box-travel.fancy-box-big .fancy-box-contents {
  right: 30%; }

.fancy-box-travel.fancy-box-tall {
  padding-bottom: 134.375%; }

.fancy-box-travel.fancy-box-small {
  padding-bottom: 69.5%; }

.fancy-box-travel.fancy-box-wide {
  padding-bottom: 33.36%; }

.fancy-box-travel.fancy-box-square {
  padding-bottom: 100%; }

.fancy-box-travel.hide-target .fancy-box-info p,
.fancy-box-travel.hide-target .fancy-box-info .fancy-box-footer {
  opacity: 0; }

.fancy-box-travel:hover:after {
  transform: translateY(0); }

.fancy-box-travel:hover .fancy-box-image {
  transform: scale(1.15); }

.fancy-box-tour {
  background-color: #fff;
  box-shadow: 0 0 0 rgba(0, 0, 0, 0.15);
  transition: box-shadow 0.45s cubic-bezier(0.32, 0.98, 0.37, 1); }

.fancy-box-tour .fancy-box-contents,
.fancy-box-tour .fancy-box-footer {
  border: 1px solid #e7e9ef;
  border-top: none; }

.fancy-box-tour .fancy-box-contents {
  padding: em(20) 20px em(25); }

.fancy-box-tour .fancy-box-info {
  font-size: em(13); }

.fancy-box-tour .rating {
  font-size: 12px;
  margin: 0.45em 0;
  color: #a7a9b8; }

.fancy-box-tour .star-rating {
  display: inline-block;
  font-size: 1em;
  color: var(--color-primary); }

.fancy-box-tour .fancy-box-footer {
  display: flex;
  flex-flow: row wrap;
  align-items: center;
  justify-content: space-between;
  padding: em(17) 20px; }

.fancy-box-tour .fancy-box-footer h6 {
  margin: 0;
  font-size: 1em;
  color: #181b31; }

.fancy-box-tour .fancy-box-footer h6 strong {
  font-weight: bold;
  font-size: 1.5em;
  color: var(--color-primary); }

.fancy-box-tour .fancy-box-icon {
  display: inline-block;
  transform: translateX(-5px);
  opacity: 0;
  color: var(--color-primary);
  transition: transform 0.3s, opacity 0.3s; }

.fancy-box-tour .fancy-box-icon i {
  display: inline-block; }

.fancy-box-tour:hover {
  box-shadow: 0 20px 50px rgba(0, 0, 0, 0.07); }

.fancy-box-tour:hover .fancy-box-icon {
  transform: translateX(0);
  opacity: 1; }

.flickity-slider .fancy-box-tour {
  margin-bottom: 50px; }

.fancy-box-offer {
  display: flex;
  padding-bottom: 30px;
  align-items: center;
  justify-content: space-between;
  border-bottom: 1px solid #e5e7ed; }

.fancy-box-offer .fancy-box-cell {
  display: flex;
  flex-direction: column;
  flex-basis: 16.666666666666667%;
  flex: 1 0; }

.fancy-box-offer .fancy-box-header {
  display: flex;
  flex-flow: row wrap;
  align-items: center;
  flex-basis: 20%; }

.fancy-box-offer .fancy-box-image {
  margin-right: 18px;
  flex: 0 auto; }

.fancy-box-offer small {
  display: block;
  font-size: 13px;
  letter-spacing: 0.05em;
  color: #808291;
  font-weight: 400; }

.fancy-box-offer h3 {
  line-height: 1.5em;
  font-weight: 600; }

.fancy-box-offer h5 {
  margin: 0;
  font-size: em(18);
  line-height: 1.5em;
  font-weight: 600; }

.fancy-box-offer img {
  max-width: 120px; }

.fancy-box-offer p span {
  display: inline-block; }

.fancy-box-offer .btn {
  font-size: 14px;
  justify-content: center; }

.fancy-box-offer .btn-md > span {
  padding-top: 1em;
  padding-bottom: 1em; }

.fancy-box-offer:last-child {
  border-bottom: none; }

.fancy-box-offer-header {
  padding-bottom: 15px; }

.fancy-box-offer-header h3 {
  font-size: 36px;
  text-transform: uppercase;
  font-weight: 700;
  letter-spacing: -0.01em; }

.fancy-box-offer-header p,
.fancy-box-cell:before {
  font-size: em(14);
  text-transform: uppercase;
  letter-spacing: 0.1em;
  color: #a7a9b8; }

.fancy-box-case-study {
  perspective: 1200px;
  height: 400px;
  transition: transform 0.6s cubic-bezier(0.23, 1, 0.32, 1); }

.fancy-box-case-study h3 {
  font-size: 27px; }

.fancy-box-case-study figure {
  width: 100%;
  height: 100%;
  background-size: cover;
  background-position: center;
  transform: scale(1.075);
  transition: transform 0.6s cubic-bezier(0.23, 1, 0.32, 1); }

.fancy-box-case-study figure:after {
  content: '';
  display: inline-block;
  width: 100%;
  height: 100%;
  border-radius: 40px;
  position: absolute;
  top: 0;
  left: 0;
  background: rgba(13, 15, 30, 0.35); }

.fancy-box-case-study .cb-img-container {
  width: 100%;
  height: 100%;
  position: absolute;
  top: 0;
  left: 0;
  overflow: hidden; }

.fancy-box-case-study .fancy-box-contents {
  width: 100%;
  height: 100%;
  position: absolute;
  top: 0;
  left: 0;
  transform-style: preserve-3d;
  perspective: inherit;
  box-shadow: 0 0 0 rgba(0, 0, 0, 0);
  transition: box-shadow 0.6s cubic-bezier(0.23, 1, 0.32, 1); }

.fancy-box-case-study .fancy-box-header {
  position: absolute;
  bottom: 40px;
  left: 35px;
  right: 35px;
  transform: translateZ(35px) scale(0.942);
  color: #fff; }

.fancy-box-case-study .ld-cb-icon {
  display: block;
  font-size: 44px;
  line-height: 1;
  opacity: 0;
  transition-property: opacity, transform;
  transition-duration: 0.6s;
  transition-timing-function: cubic-bezier(0.23, 1, 0.32, 1);
  transform: scale(0.95); }

.fancy-box-case-study .ld-cb-cat {
  font-size: 13px;
  opacity: 0.6; }

.fancy-box-case-study.scheme-light .fancy-box-header {
  color: #fff; }

.fancy-box-case-study.scheme-light .fancy-box-header h3 {
  color: inherit; }

.fancy-box-case-study:hover {
  transform: scale(1.075); }

.fancy-box-case-study:hover figure {
  transform: scale(1); }

.fancy-box-case-study:hover .fancy-box-contents {
  box-shadow: 0 60px 110px rgba(0, 0, 0, 0.23); }

.fancy-box-case-study:hover .ld-cb-icon {
  opacity: 1;
  transform: scale(1); }

.fancy-box-overlay {
  padding-bottom: 53.335%;
  overflow: hidden;
  color: rgba(0, 0, 0, 0.7);
  box-shadow: 0 0 0 rgba(0, 0, 0, 0);
  transition: box-shadow 0.3s; }

.fancy-box-overlay .cb-img-container,
.fancy-box-overlay .fancy-box-contents {
  position: absolute;
  top: 0;
  left: 0; }

.fancy-box-overlay .fancy-box-image,
.fancy-box-overlay .cb-img-container,
.fancy-box-overlay .fancy-box-contents {
  width: 100%;
  height: 100%; }

.fancy-box-overlay .cb-img-container {
  width: 102%;
  height: 102%;
  left: -1%;
  top: -1%; }

.fancy-box-overlay .fancy-box-image {
  background-position: center; }

.fancy-box-overlay .blur-image-container {
  opacity: 0;
  transition: opacity 0.3s cubic-bezier(0.39, 0.575, 0.565, 1); }

.fancy-box-overlay .cb-overlay {
  display: inline-block;
  width: 100%;
  height: 100%;
  position: absolute;
  top: 0;
  left: 0;
  background-color: rgba(255, 255, 255, 0.4);
  transition: opacity 0.3s; }

.fancy-box-overlay .fancy-box-contents {
  width: 85%;
  padding: 35px;
  display: flex;
  flex-direction: column;
  justify-content: flex-end; }

.fancy-box-overlay .fancy-box-footer {
  margin-top: auto;
  z-index: 2; }

.fancy-box-overlay h3 {
  font-size: 24px;
  margin-bottom: 1.5rem; }

.fancy-box-overlay.shadowed {
  box-shadow: 0 20px 40px rgba(0, 0, 0, 0.18); }

.fancy-box-overlay.tall {
  padding-bottom: 133.335%; }

.fancy-box-overlay.tall .fancy-box-contents {
  width: 100%;
  padding-left: 30px;
  padding-right: 30px; }

.fancy-box-overlay.tall h3 {
  margin-bottom: 0.5rem; }

.fancy-box-overlay.scheme-light {
  color: rgba(255, 255, 255, 0.75); }

.fancy-box-overlay.scheme-light h3 {
  color: #fff; }

.fancy-box-overlay.scheme-light .cb-overlay {
  background-color: rgba(0, 0, 0, 0.4); }

.fancy-box-overlay.fancy-box-overlay-alt {
  padding-left: 30px;
  padding-right: 30px; }

.fancy-box-overlay.fancy-box-overlay-alt .fancy-box-contents {
  width: 100%; }

.fancy-box-overlay.fancy-box-overlay-alt .fancy-box-footer {
  margin-top: 1.5rem; }

.fancy-box-overlay:hover {
  box-shadow: 0 20px 40px rgba(0, 0, 0, 0.18); }

.fancy-box-overlay:hover .cb-overlay {
  opacity: 0.9; }

.fancy-box-overlay:hover .blur-image-container {
  opacity: 1; }

.fancy-box-classic h3 {
  margin-bottom: 0.5rem; }

.fancy-box-classic.text-center h3 {
  margin-bottom: 1.25rem; }

.fancy-box-custom-height {
  padding-bottom: 0 !important; }

.fancy-box-heading-lg h3 {
  font-size: 36px; }

.fancy-box-heading-sm h3 {
  font-size: 18px; }

.accordion-title-bordered .accordion-title a {
  color: #ffffff; }

.accordion-title-bordered .accordion-title .active a {
  color: #6c5ba7; }

.superlg {
  font-size: 3rem; }

.verylg {
  font-size: 2rem; }

.neustyle {
  border-radius: 40px !important;
  box-shadow: 1px 1px 5px #0D0E0F, -3px -3px 9px #353B42, inset 1px 1px 9px #2D2E35;
  background: linear-gradient(128.11deg, #26272B 6.67%, #34393F 97.78%);
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1); }

.neustyle::after {
  content: "";
  border-radius: 40px;
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background: linear-gradient(165.64deg, #26272B 9.53%, #34393F 95.92%);
  box-shadow: inset 3px 3px 10px #0D0E0F, inset -3px -3px 10px #40464E;
  opacity: 0;
  -moz-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  -webkit-transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1);
  transition: all 1s cubic-bezier(0.165, 0.84, 0.44, 1); }

.neustyle:hover {
  -webkit-transform: scale(1, 1);
  transform: scale(1, 1); }

.neustyle:hover::after {
  opacity: 1; }

.fancy-box-tags-container {
  float: right;
  color: #fff; }

.fancy-box-tags-container a {
  float: right;
  color: #fff; }

.fancypostexcerpt {
  margin-left: 40px;
  margin-right: 20px; }

.fancy-box-time-container {
  float: left;
  color: #fff; }

.fancybody {
  padding-top: 20px; }

.smallerbtn {
  line-height: .5pt;
  font-size: 16px; }

.fancy-box-header {
  margin-left: 40px;
  margin-top: 30px;
  margin-right: 20px; }

.neucardcontainer {
  background: linear-gradient(124.09deg, #26272B 12.58%, #34393F 93.19%) !important;
  mix-blend-mode: normal;
  box-shadow: 4px 3px 19px #0D0E0F, -5px -5px 20px #40464E !important;
  border-radius: 40px;
  width: 100%;
  min-height: 30vh; }

.neucardimage {
  position: absolute;
  left: 0%;
  top: 0%;
  width: 100%;
  height: 200px;
  object-fit: cover;
  z-index: 99;
  position: relative;
  /* Primary / Primary 3 */
  background: #6C5DA7;
  border-radius: 40px 40px 0px 0px; }

/*# sourceMappingURL=style.css.map */
.ln-card .card-content {
  background: #121212;
  position: relative;
  margin-top: -12%;
  width: 90%;
  padding: 50px 20px 20px;
  -webkit-clip-path: polygon(0 30px, 100% 0, 100% 100%, 0% 100%);
  clip-path: polygon(0 30px, 100% 0, 100% 100%, 0% 100%); }

/*# sourceMappingURL=styles.scss.map */

/*# sourceMappingURL=main.cs.map */