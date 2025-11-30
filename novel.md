<style>
/* FONT IMPORTS ____________________________________________________ */
/* _________________________________________________________________ */

@import url('https://rawcdn.githack.com/Kaiburr-kath-hound/HomebreweryStyles/ebd72a5434328bd2a9d51b46f569d842bb9bbc7a/3.5FRStyle.css');

/* _________________________________________________________________ */
/* _________________________________________________________________ */


/* PAGE TEXTURES, FONT, and PADDING */
.page::after {
	all	                : unset;
}

.page {
	background-image	  : url('https://i.imgur.com/UHJK8Xe.jpg');
  background-size     : 101.4% 100%;
  background-position : right;
	padding						  : 26.5mm  24mm  25mm  19.2mm;
  
  font-family         : 'Felltype';
	font-size					  : 13px;
	column-gap  			  : 7mm;
}
.page:nth-of-type(odd) {
	background-image	  : url('https://i.imgur.com/0mPWfvZ.jpg');
  background-position : left;
	padding						  : 26.5mm  20.2mm  25mm  22mm;
}

/* TEXT and VARIATIONS */
p {
  font-family         : 'Felltype';
	font-size					  : 13px;
	text-align				  : justify;
	column-gap  			  : 7mm;
}
.page strong {
  text-shadow	        : #000 0 0 0.1px;
  letter-spacing      : 0.5px;
}
.page p {
  font-family         : 'Felltype';
	font-size					  : 13px;
	text-align				  : justify;
	column-gap  			  : 7mm;
}

/* HEADERS */
.page h1,
.page h2,
.page h3,
.page h4 {
  color           : black;
  font-family     : 'BookInsanityRemake';
}

.page:not(:has(.frontcover,.toc,.backcover)) h1 {
  padding-top     : 130px;
}

.page h1+p::first-letter {
  color           : black;
}
.page h1+p::first-line {
  all             : unset;
}
.page:not(:has(.frontcover, .credits, .toc)) h1 {
  font-family	    : 'BookInsanityRemake';
  font-weight     : 100;
  text-align      : right;
  font-size       : 70px;
  text-transform  : uppercase;
  padding-bottom  : 51px;
}
.page:not(:has(.frontcover, .credits, .toc)) h1::first-letter {
  font-size			  : 134%;
}
.page:not(:has(.frontcover, .credits, .toc)) h1+p::first-letter {
  padding-bottom  : 38px;  
	margin-top      : -54px;  
  margin-bottom   : -58px;
	font-size       : 3.1cm;
  font-family	    : 'BookInsanityRemake';
  text-transform  : uppercase;
}
.page h1+p {
  padding-top     : 161px;
}
.page:not(:has(.frontcover, .credits)) h2 {
  margin-bottom   : 0px;
  margin-top      : 12px;
  font-size       : 38px;
}


.page h2 u {
  text-decoration       : underline 1px;
  text-underline-offset : 3px;
}
/* IMPORTANT NOTE
The code above ↑ underlines part of an h2 header, but ONLY if you surround the text with the "<u>" and "</u>" tags. The original Forgotten Realms book only underlines the last line in this header, but this is tedious to automatically do while only using CSS and HTML code.

So, if your document only has singlt-line H2 headers anyways, OR you don't care about the other lines in the h2 header being underlined, then replace the code below this text with the following:


.page:not(:has(.frontcover, .credits)) h2 {
  text-decoration       : underline 1px;
  text-underline-offset : 3px;
}

*/

.page h3 {
  margin-bottom   : -6px;
  margin-top      : 12px;
  font-size       : 28px;
  border          : none;
}
.page h4 {
  margin-bottom   : -3px;
  margin-top      : 18px;
  font-family     : 'Felltype';
  font-variant    : small-caps;
  font-size       : 21px;
  text-align      : center;
  font-weight     : 100;
}
.page h5 {
  margin-bottom   : -5px;
  margin-top      : 20px;
  font-family     : 'Felltype';
  text-align      : center;
}
.page h6 {
  text-shadow	    : #000 0 0 0.1px;
  letter-spacing  : 0.5px;
}

/* TABLES */
.page table tr:nth-child(odd) {
	background-color  : transparent !important;
}
.page table th,
.page table td {
  font-family       : 'Felltype';
}

.tabletitle {
  font-family     : BookInsanityRemake;
  font-size       : 20px;
  font-weight     : 900;
  font-variant    : small-caps;
}


/* FOOTNOTES */
.page .footnote {
  color             : #1c1e22;
  font-family       : 'Mayflower Caps';
  font-size         : 16.5px;
  text-align        : center !important;
  bottom            : unset;
  top               : 38px;
	left             	: 310.5px;
}
.page .footnote:before,
.page .footnote:after {
	content          	: '';
	position         	: absolute;
	top              	: -11px;
	left             	: 62.5px;
	width            	: 75px;
  height            : 8px;
	background-image  : url(https://i.imgur.com/jVRPnsx.png);
	background-size   : 100% 100%;
}
.page .footnote:after {
	top               : 16px;
}
.page:nth-of-type(even) .footnote {
  left              : 300px;
  right             : unset;
}

/* PAGE NUMBERS */
.page .pageNumber {
  font-family       : 'Felltype';
  color             : #1c1e22;
  font-size         : 22px;
  text-align        : center;
  right             : unset;
  left              : 387px;
  bottom            : 48px;
}
.page:nth-of-type(even) .pageNumber {
  left              : 375px;
}

/* DESCRIPTIVE NOTES */
/* This is kind of just a boring blue box... not my favorite, but that's how it is in the 3.x books, so here we are. */
.page .descriptive {
	background-color	: #b0ced9;
	border-style			: unset;
	padding						: 4.25mm;
	margin						: 2mm -1mm;
	width							: calc(100% + 2mm);
}
.page .descriptive h5,
.page .descriptive h4,
.page .descriptive h3,
.page .descriptive h2,
.page .descriptive h1 {
	text-indent				: 0;
	margin-left				: 0;
	text-align				: left;
	margin-top				:	2px;
	margin-bottom			:	4px;
	color							: black;
}
.page .descriptive h2 {
	border-bottom			: 2px solid black;
	line-height				: 0.8em;
}

/* NOTES */
/* The only big difference here (other than appearance) is that wide notes have two columns by default. */
.page .note {
	border-image	      : url(https://i.imgur.com/EOtrbTr.png) 20 70;
	border-image-width	:	2mm 3mm;
	border-image-outset	:	1mm 0mm;
  
	background-image		: url(https://i.imgur.com/JPj5tCa.jpg);
  background-size     : 800px;
  background-position : top;
  
	box-shadow				  : none;
	padding							: 14px 10px 19px;
  margin              : 5mm 0 2mm;
}
.page .note.wide {
	border-image-width	:	3.7mm 3mm;
	border-image-outset	:	1.8mm 0mm;

	columns							: 2;
}

.page .note h1,
.page .note h2,
.page .note h3,
.page .note h4,
.page .note h5 {
	text-align          : center;
}

.page .note h3 {
	column-span         : all;
	-webkit-column-span : all;
	-moz-column-span    : all;
	display             : block;
  margin-bottom       : -4px;
}

.page .note.wide p:first-of-type {
  margin-top          : 0px;
}

/* WIDE block correction */
.page .wide + * {
  margin-top          : 0px;
}
.page .wide {
  margin-bottom       : 25px;
}

/* SMALL CAPS */
/* This is a weird setting that is used when the "Dungeons and Dragons" brand is mentioned */
caps {
	font-variant	: small-caps;
}

/* HYPERLINKS */
/* Simply changes hyperlinks to inherit color instead of being bright blue. */
.page a {
	color						: inherit;
	font-weight			: inherit;
	text-decoration	: none;
}
/* This also make it so that the links are underlined when the mouse hovers over them. */
.page a:hover{
	text-decoration	: underline;
}

/* ARTIST CREDITS */
/* As long as you ONLY use the .artist tag (no left/right or top/bottom positioning), this will format the artist credits. Typically, the 3.x books use the phrase "Illust. by _____" */
.page .artist {
	position					: absolute;
	top								: 550px !important;
	left							: 76px !important;
	width							: fit-content;
	transform					: rotate(-90deg);
	transform-origin	: bottom left;
	font-size					: 13px;
	color							: black;
}
.page:nth-of-type(odd) .artist {
	transform					: rotate(90deg);
	transform-origin	: bottom right;
	left							: unset !important;
	right							: 80px !important;
}
.page .artist p {
	font-family				: BookInsanityRemake !important;
	font-size					: 13px !important;
	font-style				: italic;
}

/* DECALS */
.page [class*="decal"] {
  position            : absolute;
  left                : 0;
  top                 : 0;
  width               : 100%;
  height              : 100%;
	background-image	  : url('https://i.imgur.com/fWIVFAt.png');
  background-size     : 100% 100%;
  z-index             : -100;
  mix-blend-mode      : darken;
}

.page:nth-of-type(even) [class*="decal"]:not(.decal.intro) {
  transform           : scaleX(-1);
}

.page .decal.intro {
	background-image	  : url('https://i.imgur.com/LfyRwii.png');}
.page .decal1 {
	background-image	  : url('https://i.imgur.com/ejwVTb8.png');}
.page .decal2 {
	background-image	  : url('https://i.imgur.com/nrJlyTW.png');}
.page .decal3 {
	background-image	  : url('https://i.imgur.com/lJjdj1d.png');}
.page .decal4 {
	background-image	  : url('https://i.imgur.com/NGqt4MK.png');}
.page .decal5 {
	background-image	  : url('https://i.imgur.com/PjLl40h.png');}
.page .decal6 {
	background-image	  : url('https://i.imgur.com/qLnJ8xy.png');}
.page .decal7 {
	background-image	  : url('https://i.imgur.com/8glIkjH.png');}
.page .decal8 {
	background-image	  : url('https://i.imgur.com/nyp52EQ.png');}


/* SPELL LIST */
.page .spellList {
  text-align          : left;
  font-family         : 'Felltype';
}

/* QUOTE/INTRO QUOTE */
.page .quote * {
  font-family     : 'Zapf Chancery'
}

.page .quote.intro {
  padding-top         : 165px;
  padding-left        : 12px;
  padding-right       : 8px;
	column-span         : all;
	-webkit-column-span : all;
	-moz-column-span    : all;
	display             : block;
}
.page .quote.intro p {
  text-align          : left;
  font-style          : unset;
  font-size           : 15.3px;
  line-height         : 1.053;
}

.page .quote.intro::first-letter {
  float           : left;
  padding-bottom  : 0px;
  padding-left    : 34px;
  margin-top      : -2.7cm;
  margin-bottom   : -26px;
  margin-left     : -40px;
  line-height     : 1em;
 	font-size       : 4.55cm;
  font-family	    : 'BookInsanityRemake';
  text-transform  : uppercase;
}
.page .quote.intro > p:first-child::first-line {
  font-size       : unset;
  font-style      : unset;
  font-variant    : unset;
  line-height     : 1em;
}

.page .quote .attribution::before {
  content         : '—';
}
.page .quote .attribution {
  font-size       : 20px;
  line-height     : 1;
}


/* MONSTER STATBLOCK */
.page .monster p:first-of-type em {
	font-style			: normal;
}
.page .monster {
  font-family     : 'Felltype';
	text-align 			: left;
  font-size       : 14px;
}
.page .monster h2 + p,
.page .monster hr {
	all							: unset;
}
.page .monster	hr ~ :is(dl,p) {
	color 					: unset;
  font-family     : 'Felltype';
}
.page .monster hr + table:first-of-type {
	color 					: inherit;
	font-family			: 'Felltype';
  font-size       : 14px;
}
.page .monster h3,
.page .monster h2 {
	margin-left			: 0;
	border-bottom		: unset;
	text-align			: left;	
}
.page .monster h3 {
  font-family     : 'Felltype';
  font-weight     : 100;
  font-variant    : small-caps;
  font-size       : 21px;
  text-align      : center;
  margin-top      : 18px;
}

.page .monster hr:nth-of-type(4) {
  display         : block;
  margin-top      : 12px;
}

.page .monster p {
	text-indent			: -1em; 
	margin-left			:  1em;
  font-size       : 14px;
}
.page .monster strong {
  letter-spacing  : 0.2px;
}
.page .monster	h3:last-of-type ~ :is(dl,p) {
	text-indent			: 1em; 
	margin-left			: 0;
}
.page .monster.frame {
  padding         : 0;
	width						: 100%;
	background 			: unset;
	border					: unset;
	margin-left			: unset;
	margin-right		: unset;
  box-shadow      : unset;
}


/* FRONT COVER _____________________________________________________ */

.page:has(.frontcover) {
	background-image  	: url(https://i.imgur.com/tijrzna.jpg);
	background-size   	: 100% 100%;
  counter-increment   : none; 
  padding             : unset;
}

.page .frontcover {
	column-span         : all;
	-webkit-column-span : all;
	-moz-column-span    : all;
	display             : block;
	margin-left					: 2.77%;
  margin-top          : 50px !important;
}

      .page .title {
        display							: block;
        padding							: 2rem 0 2rem;
        margin							: 116px auto;
        width								: fit-content;
        min-width						: 140px;
        max-width           : 540px;
        border-image 	      : url(https://i.imgur.com/LPvVJWd.png) 42  120  54 fill;
        border-image-width	: 27px 72px 34px;
        border-image-outset	: 15px 30px 15px;
        border-image-repeat	: round;
        text-align          : center;
        filter							: drop-shadow(0 0 2px rgba(0,0,0,0));
      }

      .page:has(.frontcover, .credits) h2 {
        position        : relative;
        bottom          : -83px;
        color           : #664a3f;
        text-align      : center;
        font-family     : 'Mayflower Caps';
        font-size       : 24px;
        letter-spacing  : 0.4px;
        filter          : drop-shadow(0 -1px 0.5px #a08b83)
                          drop-shadow(0  2px 0.5px #eee);
      }
      .page .frontcover h2:first-of-type {
        left            : -156px;
      }
      .page .frontcover h2:nth-of-type(2)  {
        bottom          : -59px;
        left            : 153px;
      } 

      .page h2 + .title {
        margin-top		  : 92px;
      }
      .page h2 + h2 + .title {
        margin-top		  : 68px;
      }
      .page .title + h2 {
        margin-top      : -186px;
      }
      

      .page .title h1 {
        font-family	        : 'BookInsanityRemake';
        font-weight	        : 100;
        font-size		        : 51px;
        color				        : #525f4f;
      }

      .page .title h1,
      .page .title .big {
        padding                 : 9px;
        margin                  : -16.5px -9px;
        color                   : rgba(0, 0, 0, 0);
        background-image        : url('https://i.imgur.com/MXOqiEt.jpg');
        -webkit-background-clip : text;
        background-clip         : text;
        background-size         : 350px 80px;
        background-position     : 0 8px;
        filter                  : drop-shadow(0  0.5px 0.2px  #7d6f5d) 
                                  drop-shadow(0 -0.75px 0.1px  #c0c4ab)
                                  saturate(0.8);
      }

      .page .big {
        font-size			: 87px;
        position			: relative;
        bottom				: -12px;
        margin-top		: -27px;
      }

      .page .title:has(.big) h1 {
        line-height   : 68px;
      }

.page:has(.frontcover) .footnote {
  all           : unset;
  position      : absolute;
  height			  : fit-content;
	bottom			  : 130px;
	left				  : 22.5%;
	width				  : 60%;
	text-align	  : center;
  color         : #664a3f;
  font-family   : 'Mayflower';
  font-size     : 19px;
  line-height   : 21px;
  filter        : drop-shadow(0 0 0.5px #8d766d);
}

.page:has(.frontcover) .footnote:before,
.page:has(.frontcover) .footnote:after {
  all           : unset;
}


/* CREDITS _________________________________________________________ */

.page:has(.credits) {
	background-image	: url(https://i.imgur.com/dmY2bdT.jpg);
	background-size		: 100% 100%;
}
.page:nth-of-type(odd):has(.credits) {
	background-image  	: url(https://i.imgur.com/VpPJ3wt.jpg);
}

.page .credits {
	position					: absolute;
	left							: 0;
	top								: 0;
	width     				: 100%;
	height						: 100%;
	padding						: 67px 68px 0px 60px;
}
.page:nth-of-type(odd) .credits {
	padding						: 67px 60px 0px 68px;
}


      .page .credits h2 {
        filter              : drop-shadow(0  0     1px   #d1ad63)
                              drop-shadow(0 -0.5px 0     #a88b4f)
                              drop-shadow(0  0.7px 0.1px #fff);
        z-index             : 1;
        font-size           : 22.5px;
      }
      .page .credits h2:first-of-type {
        top                 : -31px;
        left                : -146px;
      }
      .page .credits h2:nth-of-type(2)  {
        top                 : -53px;
        left                : 143px;
      }

      .page .credits .title {  
        margin-top          : 0; 
        margin-bottom       : 34px;
        padding             : 9px 0 11px;
        min-width           : 133px;
        max-width           : 513px;
        border-image        : url(https://i.imgur.com/LPvVJWd.png) 42 114 51 fill;
        border-image-width  : 26px 69px 32px;
        border-image-outset : 14px 28px 14px;
        border-image-repeat : round;
        text-align          : center;
        filter              : drop-shadow(0 0  6px #cc811f)
                              drop-shadow(0 0 26px #cca41f);
      }

      .page .credits .title h1 {
        font-family         : 'BookInsanityRemake';
        font-weight         : 95;
        font-size           : 48px;
        color               : #4e5b4a;
      }

      .page .credits .title h1,
      .page .credits .title .big {
        padding             : 8px;
        margin              : -15px -9px;
        color               : rgba(0, 0, 0, 0);
        background-image    : url('https://i.imgur.com/MXOqiEt.jpg');
        -webkit-background-clip : text;
        background-clip     : text;
        background-size     : 332px 76px;
        background-position : 0 8px;
        filter              : drop-shadow(0 0.48px 0.19px  #776b56) 
                              drop-shadow(0 -0.71px 0.09px  #bdbe9f)
                              saturate(0.76);
      }

      .page .credits .big {
        font-size           : 82px;
        bottom              : -11px;
      }
      .page .credits h2 + .title {
        margin-top		      : -22px;
      }
      .page .credits h2 + h2 + .title {
        margin-top		      : -45px;
      }
      .page .credits .title + h2 {
        margin    		      : -105px 0 105px;
      }


.page .credits p	{
	font-family	    : 'Felltype';
	text-align	    : center;
	font-size		    : 18.2px;
  text-indent     : 0;
  line-height     : 1.2em;
  letter-spacing  : 0.2mm;
}

.page .credits p+p	{
  margin-top      : 0.75em;
}

    .page .credits .frame {
      columns							: 2;
      column-gap					: 28px;
      border-image	      : url(https://i.imgur.com/MGaySnx.png) 26 0 fill;
      border-image-width	: 0 340.5px;
      mix-blend-mode      : color-burn;
    }
    
.page:has(.credits) .footnote:before,
.page:has(.credits) .footnote:after {
  all           : unset;
}

.page:has(.credits) .footnote {
  top           : unset;
  bottom        : 50px;
  width         : unset;
  max-width     : 720px;
  left          : 46px;
  color         : black;
}

.page:has(.credits) .footnote p {
  line-height   : 1em;
  font-size     : 18px;
}


/* TABLE OF CONTENTS _____________________________________________ */

.page .toc,
.page .toc.wide {
	display               : block;
	column-span           : all;
	-webkit-column-span   : all;
	-moz-column-span      : all;
	columns							  : 3;
  column-gap            : 7.5mm;
}

.page .toc h1 {
  margin-bottom         : -20px;
	column-span           : unset;
	-webkit-column-span   : unset;
	-moz-column-span      : unset;
	text-align			      : left;
  text-decoration       : underline 1px;
  text-underline-offset : 3px;
  font-size             : 38px;
}

.page .toc ul h4 {
  font-weight           : 100;
  font-variant          : normal !important;
  font-family           : historical;
}

.page .toc h2,
.page .toc ul h3,
.page .toc h4,
.page .toc ul span {
  margin-top      : 0!important;
  margin-bottom   : 0;
  line-height     : 1.2em;
	text-indent			: 0;
}

.page .toc ul h3 {
  text-shadow	    : #000 0 0 0.1px;
}

.page .toc h2,
.page .toc h3 {
	font-family			: 'Felltype';
	font-size				: 13.5px;
  text-transform  : unset;
	letter-spacing	: 0.15mm;
	line-height			: 5mm;
	color						: black;
	text-indent			: 0.55em;
  margin-top      : 0;
  margin-bottom   : 0;
  line-height     : 1.2em;
}

.page .toc h4 {
	font-size				: 13px;
}

.page .toc ul h3 span:first-child::after {
	border-bottom 	: 0.5mm dotted black;
}

.page .toc ul h3 {
  margin-top      : 20px !important;  
}

.page .toc ul h4 {
  line-height     : 1.2em !important;
}

.page .toc ul h5 {
  font-weight     : unset;
  font-size       : inherit;
  margin          : inherit;
}


.test {
  font-family : 'Historical Test';
}



/* CHAPTER HEADERS */
.page:not(:has(.frontcover, .credits, .toc)) .chapter {
  position        : absolute;
  text-align      : right;
  bottom          : 728px;
  right           : 76px;
  font-size       : 70px;
}

.page:not(:has(.frontcover, .credits, .toc)) .chapter * {
  text-transform  : uppercase;
  font-family	    : 'BookInsanityRemake';
  text-align      : right;
  letter-spacing  : -2.3px;
  font-size       : 70px;
}

.page:not(:has(.frontcover, .credits, .toc)) .chapter big {  
  font-size			  : 134%;
  position			  : relative;
  bottom				  : -9px;
  margin-left     : 6px;
  margin-right    : 0px;
}
.page:not(:has(.frontcover, .credits, .toc)) .chapter small {
  position        : relative;
  bottom          : 10px;
  margin          : 0 -20px;
  text-transform  : lowercase;
  font-size       : 80%;
  letter-spacing  : 0px;
}
.page:not(:has(.frontcover, .credits, .toc)) .chapter small big {
  font-size       : 88%;
  bottom				  : -4px !important;
}

.page:has(.chapter) {
  padding-top     : 371px
}
.page:has(.chapter):nth-of-type(even) {
  padding-top     : 481px
}

.page:has(.chapter) .chapter + p:not(.chapter p)::first-letter {
	float           : left;
  padding-bottom  : 38px;
	padding-left    : 40px;
	margin-top      : -54px;
	margin-left     : -40px;
	font-size       : 3.1cm;
	line-height     : 1em;
  margin-bottom   : -58px;
  font-family	    : 'BookInsanityRemake';
}

.page .chapter+p {
  padding-top     : 161px;
}
.page:nth-of-type(even) .chapter+p {
  margin-top     : -253px
}



/* BACK COVER */

.page:has(.backcover) {
	background-image  : url(https://i.imgur.com/RaYiTVM.jpg);
	background-size	  : 100% 100%;
  padding           : 137px 210px 50px 120px;
}

.page .backcover {
  text-shadow       : 0 0 16px #fbfbf8;
}

.page .backcover h1,
.page .backcover h2,
.page .backcover h3,
.page .backcover h4,
.page .backcover h5 {
  font-weight       : 100;
  margin-top        : 0;
  text-align        : center;
}

.page .backcover h1 {
	font-size					: 40px;
  padding-bottom    : 0;
}
.page .backcover h1+p::first-letter {
	all               : unset;
}
.page .backcover h2 {
	font-size					: 54px;
  line-height       : 0.9em;
  letter-spacing    : -2px;
  margin-top        : 0;
}
.page .backcover h3 {
  letter-spacing    : -2px;
	font-size					: 38px;
}
.page .backcover h4 {
	font-size					: 38px;
  margin-top        : 0px;
}
.page .backcover h5 {
	font-size					: 32px;
}
.page .backcover p,
.page .backcover ul {
	line-height				: 1em;
	font-size					: 17px;
  text-indent       : 0;
}

.page .backcover p {
	padding-top				: 24px;
}

.page .backcover ul {
  padding-left      : 14px;
}
.page .backcover li {
  padding-left      : 4px;
}

/* The Homebrewery cauldron is placed at the end of the .backcover class. */
.page .backcover::after {
	content						: '';
	position					: absolute;
	height						: 120px;
	width							: 127px;
	left							: 301px;
	bottom					  : 106px;
	background-image	: url(https://i.imgur.com/dfNgldc.png);
  background-size   : 100% 100%;
  filter            : brightness(0.46) 
                      hue-rotate(-27deg)
                      drop-shadow(0 -1px 0.5px #a08b83)
                      drop-shadow(0  2px 0.5px #fff);

}
</style>

<!---
Here is a link to all my other Homebrewery templates, if you're interested:

https://homebrewery.naturalcrit.com/user/KaiburrKathHound?sort=alpha&dir=asc

Also, IF you want to buy me a coffee (or something), here's my Ko-fi page:
https://ko-fi.com/kaiburrkathhound
--->

{{frontcover
  ## 3rd Year Edition
  {{title
  # IMPERIAL REGISTRY
  # OF
  # SANCTIONED MARTIAL FORMS
  }}
}}

{{wide
## Compiled by the Ministry of
## Rites Department of Martial Affairs
<br/><br/>

## Published by Imperial Decree Third Year of the
## Jade Dragon Emperor's Reign
<br/><br/>

## Submitted to His Imperial Majesty by the
## Grand Council of Sects
<br/><br/>

## Authenticated by the
## Vermillion Seal Bureau of Military Standards
}}


{{pageNumber,auto}}
\page


{{wide

# Official Proclamation

#### In accordance with the Edict of the Ninth Moon, Third Year of the Jade Dragon Emperor's reign, the Ministry of Rites hereby publishes this complete registry of all martial techniques recognized and sanctioned by the Grand Council of Sects.

<br/>

## Authority and Mandate

This registry is compiled under the authority granted by:

- **Imperial Edict 937** - Requiring registration of all martial techniques practiced within the realm

- **Memorial of the Grand Council** - Submitted the first day of the Eighth Moon, detailing the necessity of public record

- **Recommendation of the Ministry of War** - Endorsing the standardization of technique nomenclature for military purposes

- **Approval of the Censorate** - Verifying the propriety and completeness of recorded entries

## Legal Provisions

As established by Imperial law and confirmed by the Grand Council of Sects, the following provisions govern the use and teaching of martial techniques:

- **Article I - Registration Requirement:** All martial techniques taught within recognized sects, academies, or military institutions must be registered with the Department of Martial Affairs within sixty days of their formalization.

- **Article II - Name Only Provision:** In accordance with ancient custom and by unanimous vote of the Grand Council, only the formal names of techniques shall be recorded in public registry. Methods of execution remain the exclusive transmission between master and authorized disciple.

- **Article III - Tournament Legitimacy:** Only techniques appearing in this registry may be demonstrated in officially sanctioned competitions, formal challenges, or exhibitions held under Imperial oversight.

- **Article IV - Dispute Resolution:** This registry serves as primary evidence in all legal matters concerning technique ownership, lineage claims, or allegations of unauthorized transmission.

}}

\page

## Functions of This Registry

As detailed in the Memorial submitted to His Imperial Majesty, this registry serves the following sanctioned purposes:

**First:** To provide authoritative reference for all legal proceedings concerning martial matters, including disputes between sects, accusations of technique theft, and questions of lineage authenticity.

**Second:** To preserve for posterity the names of all recognized martial forms, ensuring that knowledge of their existence persists even should sects decline or fall, thus maintaining the completeness of the realm's martial heritage.

**Third:** To enable proper identification of techniques witnessed in tournaments, military exercises, or formal combat, facilitating accurate record-keeping and appropriate attribution.

**Fourth:** To serve as reference for disciples seeking instruction in particular styles, and for masters verifying the scope and breadth of various martial traditions.

## Standardized Nomenclature

By decree of the Grand Council and approved by the Ministry of Rites, all techniques registered herein conform to the following naming convention:

**`[Classification of Arts], [Lineage Style], [Category of Form]: [Designated Appellation]`**

The **Classification of Arts** denotes the foundational category as determined by the Bureau of Martial Standards.

The **Lineage Style** identifies the recognized school or tradition responsible for the technique's development and transmission.

The **Category of Form** specifies the technical classification of movement as catalogued by the Department of Martial Affairs.

The **Designated Appellation** represents the formal name by which the technique is registered and may be legally invoked.

## Method of Organization

In accordance with the recommendation of the Grand Council of Sects, this registry is organized by Lineage Style. All techniques belonging to a single tradition are grouped together to facilitate reference and comparison.

Within each Style section, techniques are listed by their complete formal designations in the order received by the Department of Martial Affairs. No elaboration, description, or instruction accompanies these entries, as mandated by Article II of the governing statutes.

## Scope and Limitations

This Third Year Edition contains three thousand eight hundred and fifty techniques submitted by recognized sects, approved academies, and authorized military institutions. This registry represents techniques formally registered as of the final day of the Eighth Moon.

Additional techniques are submitted quarterly to the Department of Martial Affairs. Supplementary editions shall be published at the discretion of the Ministry of Rites as deemed necessary and proper.

## Instructions for Use

Registered sects may consult this volume to verify the completeness of their documented lineages. Legal authorities shall reference entries when adjudicating disputes. Tournament officials shall confirm technique legitimacy prior to sanctioned competitions. Scholars may examine the breadth of registered traditions for academic purposes.

All persons are reminded that knowledge of a technique's name does not constitute authorization to practice said technique. Instruction may only be received from properly certified masters within recognized institutions, in accordance with Imperial Edict 937 and subsequent regulations.

## Attestation

This registry has been examined and certified accurate by the Department of Martial Affairs, Ministry of Rites, in the Third Year of the Jade Dragon Emperor's reign.

Compiled under the supervision of Vice-Minister Chang Wei, with the assistance of the Bureau of Records and the cooperation of the Grand Council of Sects.

Authenticated by the Vermillion Seal.

#### Let it be known throughout the realm.

{{pageNumber,auto}}
\page
  - 101st Valley Arts, Rotation Style, Devouring Scripture Form: Wing of Lord
 - 21st Divinities Arts, Elusive Motion Style, 82 Fold Brush Form: Equine Wrath
 - 27 Fold Projectile Arts, Beast Style, Cosmic Sun Form: Siege of Forest
 - 52 Fold Cawing Demonic Pierce Arts, Outward Ravenous True Style, Mystery Form: Few Enlightenment
 - 5th Cremation Arts, Dual Lightness Style, Adamantine Featherweight Ruin Form: Giant Finger-Dodging Sections
 - 88 Fold Heaven Arts, Sacred Moon Style, Slicing Redemption Form: Formation of Harmonies
 - 89 Fold Bloodthristy Manifestation Arts, Roving Net Style, Violent Flower Form: Six Resting Mount
 - 98 Fold Boulder Arts, Fiery Crimson Horse Style, Precept Form: Triple Unveiled Sleeping Quanzhen
 - 99th Center Shadowy Arts, Feral Eruption Style, Hidden Shell Form: Malignant-Soaring Fatal Warmaster
 - Absolute Blazing Undivinable Emergence Arts, Midsummer Burst Style, Double Foundation Form: Blister
 - Absolute Chackra Arts, Thunderwake Style, Exploding Embrace Form: Giant Lightning-Burning Slayer
 - Absolute Corrupted Shadow Aspects Arts, Striking Metal Style, Venomous Jeweled Form: Triple Polearm Crouching Volley
 - Absolute Cosmic Fall Arts, Radiant Mystic Infusion Style, Hidden Taiji Form: Stream of Darkwind
 - Absolute Crash Arts, Graceful Ancient Vile Style, Parallel North Asura Form: Giant Yin-Confronting Path
 - Absolute Crazy Weaver Arts, Serene Limitless Foxform Style, Center Dragon Form: Indestructible Distinction
 - Absolute Darkwind Arts, Ghostly Phenomena Style, Extended Curse Form: Balanced Frenzy
 - Absolute Ghostly Mighty Trial Arts, Cutting Bodhi Style, Illuminating Seeds Form: Thoughtless of Counter
 - Absolute Mental Arts, Lofty Style, Infinite Staff Form: Instance Observing Daybreak
 - Absolute Priest Arts, Many Riding Consuming Style, Jade United Form: Moonlight-Flaming Northern Madness
 - Absolute Repents Arts, Rotation Style, Frontier Form: Earthly Crash Cleaving Arhat
 - Absolute Skeletal Road Arts, Spiritual Foxform Madness Style, Trill Form: Intention Walking Phantom
 - Absolute Snake Arts, Repelling Thunderous Break Style, Soaring Web Form: Martial Sinister
 - Absolute Spirit Brush Arts, Lightning Style, Holy Sanctity Form: Governing Awakening
 - Absolute Thunder Arts, Elemental Jade Rolling Style, Dominating Moonbeam Form: Five-Fold Crows Flowing Spearplay
 - Absolute Turtle Arts, Skill Style, Rolling Switch Form: Wandering Leniency
 - Absolute Wraith Arts, Dominating Illusion Style, Golden Cyclone Form: Triple Hawkstrider Resonating Meridian
 - Abyssal Augmented Rolling Slash Arts, Unparalleled Neck Style, Evil Suffering Form: Drift of Elegance
 - Abyssal Blessed Unbounded Arts, Frosty Dominating Breaker Style, Circulation Form: Wave-Drifting Killing Talon
 - Abyssal Burst Arts, Ripping Force Style, Adaptive Seeds Form: Hand
 - Abyssal Chaotic Thunderbolt Arts, Basic Treading Snakeform Style, Buddhist Severance Form: Heritage of the Stride
 - Abyssal Corvid Volley Arts, Wild Shatters Style, Fiery Rain Form: Piercer
 - Abyssal Dao Arts, Secret Tablet Style, Waxing Breaker Form: Roar of the Sweeping Forms
 - Abyssal Feral Center Plume Arts, Double Shattering Hellish Style, Metallic Whirlwind Form: Triple Stab Aiming Fang
 - Abyssal Flameball Arts, True Fiendish Pounce Style, Mad Prayer Form: Giant Wraith-Breaking Lightning
 - Abyssal Frozen Brilliant Clouds Arts, Hunyuan Style, Leaves Form: Technique-Linking Treading Block
 - Abyssal Gentle Copper Pyrocascade Arts, Rising Nefarious Bow Style, Old Destroyer Form: Triple Parallel Emerging Perfusion
 - Abyssal Lost Arts, Grappling Arrows Style, Hail Form: Giant Basilisk-Sharpening Trigrams
 - Abyssal Mirrored Arts, Twin Secret Footstep Style, Felling Rising Aura Form: Sky
 - Abyssal Pure Obscure Tranquil Arts, Felling Buddhist Autumn Style, Ethereal Phantom Form: Step of the Shaolin
 - Abyssal Pyre Arts, Obsidian Thunderous Featherweight Style, Jade Aspects Form: Five-Fold Bolt Binding Energy
\page

 - Abyssal Shooting Mirage Lofty Arts, Crossing Element Style, Beak Form: Smashing Shard Ending Ripple
 - Abyssal Wing Arts, Protective Heartless Suffering Style, Absolute Unshakable Rotation Form: Six Paralyzing Crown
 - Adamantine Asterism Arts, Lower Dirty Disciple Style, Equal Hawkstrider Form: Magnanimous Spear
 - Adamantine Bodhidharma Arts, Capped Scholar Style, Continuous Book Form: Stretched-Bowing Enlightened Guard
 - Adamantine Buddhist Celestial Wolf Arts, Metallic Battlefield Style, Astral Crown Form: Triple Manifestations Breaking Surface
 - Adamantine Continuous Peak Arts, Arching Phantom Style, Featherweight Tail Form: Nails Fighting Nature
 - Adamantine Cutting Earth Arts, Big Turtleback Style, Radiant Phenomena Form: Six Searching Dipper
 - Adamantine Dominating Shout Arts, Riding Turtleback Style, Ravenous Stalwart Form: Triple Monkey Crouching Center
 - Adamantine Extreme Wind Arts, Pyrocascade Style, Dirty Shield Form: Dual-Sound Enduring Man
 - Adamantine Feral Reaper Arts, Unmatched Drunken Elemental Style, Center Shroud Form: Prelude of the Outward Veil
 - Adamantine Golden Sylvan Arts, Starvation Style, Cold Pulse Form: Triple Stealth Descending Starlit
 - Adamantine Harmonies Arts, Tiger Style, Extra Enlightened Star Form: Haunt of the Jade Bow
 - Adamantine Kick Arts, Icy Turtle Style, Paladin Form: Cloak Slicing Cutter
 - Adamantine Manifestations Arts, Finishing Fiendish Refraction Style, Buddhist Throwing Point Form: Transformation-Controlling Equal Space
 - Adamantine Moonbeam Arts, Elusive Extinguishing Latch Style, Metallic Wrath Form: Frenzy-Aiming Profound Prayer
 - Adamantine Pines Arts, Icy Expansive Sudden Style, Dirty Perfect Repents Form: Six Crouching Pulse
 - Adamantine Poisonous Disinterment Arts, Double Rolling Living Style, Ravenous Temper Form: Triple Breakout Resting Scale
 - Adamantine Rage Arts, Monastery Style, Shapeshifter Form: Dual-Fiend Retreating Prestissimo
 - Adamantine Saber Arts, Sweeping Exchange Style, Facing Fiery Crushes Form: Direction of the Split
 - Adamantine Saving Living Kick Arts, Unveiled Style, Daybreak Form: Dual-Arm Revitalizing Majestic
 - Adamantine Skull Arts, Riding Point Style, Foxform Pyrocascade Form: Toil of the Unified Thoughtless
 - Adamantine Technique Arts, Giant Blister Style, Harmonious Element Form: Giant Tongue-Vispering Gold
 - Adamantine Tiger Arts, Devil Style, Lunar Maiden Form: Step
 - Adamantine Vajrapani Arts, Echo Style, Feral Palm Form: White Whip Ensnaring Karmic
 - Adamantine Wanderer Arts, Rebounding Butterfly Style, Wounding Grounded Daoist Form: Leaves-Ending Graceful Explosion
 - Adaptive Center Frosty Trigrams Arts, Traceless Hydra Style, Swift Form: Legacy of the Scale
 - Adaptive Crossing Pure Reaction Arts, Rightful Righteous Immortal Style, Icy Hawkstrider Form: Five-Fold Earth Concealing Qintfade
 - Adaptive Exchange Arts, Featherweight Slip Style, Blooming Chain Form: Five-Fold Thoughtless Resonating Origin
 - Adaptive Fleeting Bamboo Arts, Martial Cross Style, Extended Repents Form: Five-Fold Forest Freezing Harvest
 - Adaptive Kindled Arts, Extinguishing Vampire Style, Extreme Slash Form: Five-Fold Family Invigorating Surface
 - Adaptive Order Arts, Boxing Stance Style, Countless Dew Form: Arching Roar
 - Adaptive Pack Arts, Authority Style, Pines Form: Mothers-Confronting Wandering Coil
 - Adaptive Piercer Arts, Rightful Subduing Celestial Style, Comb Form: Net of Soar
 - Adaptive Ripple Arts, Enlightened Snowfall Style, Nefarious Staff Form: Patriarch
 - Adaptive Shadow Grounded Moon Arts, Riding Halo Style, Demonic Infinite Daoist Form: Giant Wisdom-Airsplitting Sylvan
 - Adaptive Spiritage Arts, Spirit Plume Style, Lower Archery Form: Six Flying Moonbeam
 - Advanced Ascension Arts, Boundless Counter Style, Universal Orthodox Form: Triple Meditation Ensnaring Arrows
 - Advanced Breeze Arts, March Style, Waxing East Form: Five-Fold Unbound Defending Beam
 - Advanced Counter Arts, Martial Tai Style, Indestructible Thunderclap Form: Cold Hawk Soaring Tranquil
 - Advanced Deities Arts, Descent Style, Bronze Foundation Form: Giant North-Countering Pear
\page

 - Advanced Dirty Eastern Flashes Arts, Rightful Destiny Style, Countless Long Form: Latch of the Dual Chop
 - Advanced Dirty Toil Arts, Trap Style, Destructive Martyr Form: Delights of Myriads
 - Advanced Flight Arts, Chaotic Unrivaled Spark Style, Consuming Governing Rotation Form: Dual-Void Transforming Emperor
 - Advanced Gentle Stunning Spike Arts, Barrage Style, Jade Dual Mindless Form: Unbounded-Crouching Birthless Sweetened
 - Advanced Grafting Rampage Arts, Copper Daybreak Style, Finishing Rising Priest Form: Elegant Consonance
 - Advanced Heavenly Throwing Fairy Arts, Frozen Balanced Repentant Style, Merciful Chin Form: Full Quick
 - Advanced Illuminating Ink Arts, Throwing Arching Tiger Style, True Embracing Drain Form: Five-Fold Karmic Concealing Reaper
 - Advanced Illusory Coastal Thunderbolt Arts, Great Toxic Tempest Style, Spirit Invisible Turtle Form: Battlefield-Following Vile Transformations
 - Advanced Mist Arts, Shooting Moonlight Style, Expansive Venom Form: Destiny
 - Advanced Needles Arts, Lower Healing Copper Style, Coastal Tearing Dao Form: Leap of the Few Curse
 - Advanced Obsidian Defensive Intent Arts, Formless Tortoise Style, Dark Traversing Triangle Form: Calamity of the Moonlit Moonbeam
 - Advanced Primordial Technique Arts, Vile Archery Style, Deep Sun Form: Five-Fold Energy Weakening Tempest
 - Advanced Roving Divine Authority Arts, Traceless North Spinning Style, Boxing Double Pounce Form: Domain-Attacking Spiraling Swarm
 - Advanced Saber Arts, Metallic Cawing Taming Style, Primordial Step Form: Life
 - Advanced Stomp Arts, Continuous Eastern Poisonous Style, Penetrating Trigrams Form: Six Conquering Harvest
 - Advanced Unveiled Arts, Wounding Spread Style, Consciousness Form: Six Lunging Finger
 - Advanced Yellow Principles Arts, Waning Discipline Style, Skeletal Hell Form: Space-Retreating Mystic Chin
 - Ancient Arching Volcano Arts, Rebounding Unity Style, Embracing Destroyer Form: Swarm of the Unforgiving Reflect
 - Ancient Ember Arts, Traversing Grappling Splitting Style, Rightful Sight Form: Discipline
 - Ancient Lower Whirling Night Arts, Thirst Style, Legged Enigma Form: Waltz of the Seaspan
 - Ancient Paladin Arts, Pines Style, Scarlet Form: Elusive Nullification
 - Ancient Perfect Gorge Arts, Embracing Thrust Style, Subduing Pierces Form: Six Tearing Manifestation
 - Ancient Reflection Arts, Adamantine Blazing Parallel Style, Sonic Zenith Form: Coral Star Ascending Drift
 - Ancient Scale Arts, Self Style, Stride Form: Triple Bow Aiming United
 - Ancient Seeds Arts, Merciful Continuous Cardinal Style, Liberated Fortress Form: Unforgiving Soft
 - Ancient Shroud Arts, Bloody Killer Style, Embracing Pinnacle Form: Height of the Realm
 - Ancient Spirit Earthly Summit Arts, Cosmic Tang Style, Advanced Lotus Form: Guard of the Fiendish Rage
 - Ancient Sun Arts, Feral Elegant Corvid Style, Many Grounded Siege Form: Six Concealing Long
 - Ancient Tremor Arts, Astral Grip Style, Limitless Karmic Form: Switch
 - Apex Cutting Quick Sight Arts, Fatal Path Style, Gem Flare Form: Sutra Rising Height
 - Apex Eastern Shade Arts, Intoxicated Gust Style, Downward North Form: Five-Fold Motion Following Millennium
 - Apex Equine Aura Arts, Punch Style, Wild Cuts Form: Emergence
 - Apex Equine Ceremony Arts, Unrivaled Elusive Traceless Style, Stunning Astral Shockwave Form: Galaxy Swirling Phenomena
 - Apex Flashes Arts, Divinities Style, Malevolent Finger Form: Order Binding Titan
 - Apex Hidden Unshakable Weapon Arts, Spectral Ascension Style, Primordial Fairy Form: Flare-Going Southern Prelude
 - Apex Killing Break Arts, Corrupted Ripping View Style, Sealing Grasp Form: Prelude of the Scatter
 - Apex Lunar Warmth Arts, Absolute Onyx Ethereal Style, Wandering Reflect Form: Galaxy Emerging Drop
 - Apex Poisonous Swing Arts, Ceremony Style, Healing Deep Creation Form: Light Matching Plume
 - Apex Reflection Arts, Metallic Clarity Style, Long Form: Cut-Taking Imperial Breakout
 - Apex Scholar Arts, Winter Style, Violent Execution Form: Dual-Warfield Dispersing Snowlocked
\page

 - Apex Shapeshifter Arts, Magnanimous Warriors Style, Eternal Killer Form: Five-Fold Plume Crouching Jewel
 - Apex Slashes Arts, Cardinal Lance Style, Cosmic Burst Form: Fourteens Paradise
 - Apex Soul Arts, Martial Hawkstrider Style, Wounding Invisible Emperor Form: Hand of the Bloom
 - Apex Spearplay Arts, Evil Ember Style, Ripping Leap Form: Five-Fold United Scorching Kings
 - Apex Spiritage Arts, Obsidian Old Embracing Style, Infinite Otherness Form: Throwing Nape
 - Aquatic Charge Arts, Apex Embracing Thoughtless Style, Opposition Form: Comb of the Sealing Monkey
 - Aquatic Cutter Arts, Brilliant Profound Dominating Style, Dark Acala Form: Tearing Nothingness
 - Aquatic Glacier Arts, Shadow West Style, Icy Suppression Form: Five-Fold Moonbeam Flying Sheet
 - Aquatic Ink Arts, Abyssal Waxing Holy Style, Absolute Facing Meridian Form: Five-Fold Chackra Lunging Posture
 - Aquatic Malignant Arts, Refraction Style, Radiant Ape Form: Manipulation of the Roving Quartet
 - Aquatic Mirage Thunderous Tong Arts, Unified Truth Style, Bright Dual Mount Form: Dual-Madness Traversing Reflection
 - Aquatic Nebula Arts, Stellar Perfect Poisonous Style, Consecutive Mindless Form: Pounce of the Secret Way
 - Aquatic Penetrating Blessed Cyclone Arts, Continuous Aura Style, Hidden Intoxicated Warriors Form: Liberated Millennium Sacrificing Unity
 - Aquatic Penetration Arts, Splitting Beggar Style, Stellar Volley Form: Mobility
 - Aquatic Penetration Arts, Wandering Rivers Style, Astral Galaxy Form: Roving Leaves Resonating Execution
 - Aquatic Quartet Arts, Serene Cry Style, Tail Form: Zenith Crouching Mystery
 - Aquatic Refraction Arts, Illuminating Pure Advanced Style, Substitution Form: Dual-Energy Shattering Ink
 - Aquatic Remains Arts, Kundali Style, Massacre Form: Exploding Crow Crushing Battalion
 - Aquatic Spirits Arts, Undivinable Monkey Style, Intoxicated Featherweight Hydra Form: Giant Defiers-Binding Principles
 - Aquatic Stroke Arts, Fist Style, Splitting Spirit Surge Form: Crossing Omnidirectional Breaking Suffering
 - Aquatic Volcanoes Arts, Nether Style, Cry Form: Horse of the Tipsy
 - Arching Butterfly Arts, Coated Burning Bright Style, Grafting Trinity Form: Mystic Eagle Invigorating Turtle
 - Arching Calamity Arts, White Infinite Enlightened Style, Diving Bind Form: Skeletal Crows
 - Arching Crows Arts, Imperial Unrivaled Advanced Style, Elusive Vibrant Form: Might of Martyr
 - Arching Crystalline Red Dawn Arts, Ancient Traditional Astral Style, Icy Fortune Form: Giant Fish-Poking Needle
 - Arching Devastating Martial Hydra Arts, Single Cardinal Ghostly Style, Rising Intent Form: Six Sharpening Hoarforst
 - Arching Earth Arts, Jade Heritage Style, Unforgiving Cuts Form: Family
 - Arching Fiendish Fleeting Charge Arts, Distinction Style, Calm Wicked Rocky Form: Five-Fold Crown Searching Interference
 - Arching Flames Arts, Legged Qintfade Style, Underworld Form: Triple Nature Carrying Phoenix
 - Arching Prajna Arts, Nefarious Lord Style, Stunning Orthodox Form: Yin of the Breakthrough
 - Arching Prelude Arts, Intent Style, Gallant Polearm Form: Dual-Fiend Soothing Wraith
 - Arching Rolling Intention Arts, Formless Elbow Style, Resolve Form: Echo of the Beak
 - Arching Snow Rends Arts, Extinguishing Wisdom Style, Drunken Paradise Form: Sections-Freezing Consecutive Flesh
 - Arching Thundershock Arts, Heartless Sonic Swords Style, Saving Perfect Acala Form: Touch-Concealing Extinguishing Battalion
 - Arching Vitality Arts, Mighty Arrow Style, Unforgiving Sweetened Form: Five-Fold Stride Searching Ocean
 - Ascending Bronze Killing Swift Arts, Immortal Fate Style, Augmented Bodhi Form: Serpent of Martyr
 - Ascending Cuts Arts, Midsummer Invisible Hawkstrider Style, Governing Formless Raven Form: Five-Fold Star Summoning Slash
 - Ascending Elbow Arts, Drain Style, Wrath Form: Throwing Harmony
 - Ascending Emerald Coated Weaver Arts, Crazy Curse Style, Martial Malignant Form: Giant Sufferings-Controlling Prism
 - Ascending Lightweight Arts, Violent Expansive Capped Style, Consecutive Vampire Form: Ursine Grounding Arrow
\page

 - Ascending March Arts, Forged Grace Style, Earthen Angel Form: Strength of Cutter
 - Ascending Plate Arts, Limitless Nothingness Style, Spinning Rolling Cutter Form: Countless Mental Severing Spirits
 - Ascending Rightful Unshakable Domination Arts, White Aquatic Evil Style, Acala Form: Rising Turtleback Dodging Crows
 - Ascending Siege Arts, Sealing Direction Style, Capped Vigor Form: Five-Fold Spiral Vispering Chill
 - Ascending Silent Arts, Cursed East Style, Eternal Dragontail Form: Whirlwind of the Capped Realm
 - Ascending Sisi Arts, Unified Drowned Style, Spinning Punch Form: Foundation-Taking Shadow Spearplay
 - Ascending Verdant Arts, Extreme Ape Style, Cutting Moonlit Otherness Form: Shapeshifter Searching Warmaster
 - Ascending Western Sand Arts, Undivinable Asterism Style, Shattering Sky Form: Giant Fury-Freezing Polar
 - Ascending Yang Arts, Bright Indestructible Gallant Style, Crystalline Earthly Lotus Form: Six Deflecting Aspects
 - Astral 46th Prestissimo Arts, Crystalline Bird Style, Grand Shatter Form: Cage Rising Hail
 - Astral Apex Resolve Arts, Emerald Perfect Final Style, Skills Form: Dual-Mirror Sacrificing Toxin
 - Astral Army Arts, Double Pure Heaven Style, Striking Blossoms Form: Necrotoxin of the Unknowable Trident
 - Astral Basilisk Arts, Blooming True Roving Style, Moonlit Titan Form: Triple Shapeshifter Fighting Mental
 - Astral Bright Constellation Arts, Invisible Palms Style, Whirling Exorcism Form: Asura of the Limitless Crown
 - Astral Comb Arts, Traceless Countless Lost Style, Ursine Form: Thread Blooming Edge
 - Astral Divine Ascending Exorcism Arts, Heartless Diving Arhat Style, Ultimate Manipulation Form: Giant Devil-Slicing Prajna
 - Astral Harvest Arts, Expansive Deities Style, Buddhist Living Rhythm Form: Five-Fold Reflect Stabbing Cage
 - Astral Indestructible Eagle Arts, Virtuous Soar Style, Western Serene Fortune Form: Violent Realm Traveling Trial
 - Astral Nefarious Earthen Reflection Arts, Repentant Beam Style, Embracing Toss Form: Six Stealing Needles
 - Astral Rivers Arts, Surface Style, Shaolin Form: Triple Dawn Crushing Descent
 - Astral Scheme Arts, Sealing Feather Style, Full Soft Form: Maiden of the Ethereal View
 - Astral Shapeshifter Arts, Brilliant Formation Style, Universal Might Form: Five-Fold Zen Enduring Night
 - Astral Spiraling Scheme Arts, Infinite Total Style, Waxing Sanctity Form: Rain
 - Astral Starlit Arts, Sonic Sanctity Style, Spiraling Taihua Form: Phenomena
 - Astral Technique Arts, Moonlit Basilisk Style, Blooming Monastery Form: Kill-Conquering Coastal Pinnacle
 - Astral Undivinable Splitting Frenzy Arts, Roar Style, Radiant Drop Form: Unrestrained-Flaming Single Viper
 - Astral Wicked Graypine Arts, Emperor Style, Crossing Grappling Shift Form: Grounded Tea Sleeping Point
 - Astral Woods Arts, Dark Downward Strike Style, Consecutive Soft Form: Six Resonating Crane
 - Augmented Battalion Arts, Secret Ghostly Thousand Style, Eastern Circulation Form: Eternal-Shattering Featherweight Spread
 - Augmented Cyclone Arts, Nefarious Warriors Style, Encompassing Fortune Form: Giant Frenzy-Stopping Manipulation
 - Augmented Darkwind Arts, Scatter Style, Spinning Basic Team Form: Triple Cascade Flying Enigma
 - Augmented Deep Leaves Arts, Spirit Bone Style, Radiant Barrage Form: Six Tangled Autumn
 - Augmented Equine Slicing Crown Arts, Consuming Fox Style, Perfect Hellfire Form: Reaction of the Kings
 - Augmented Extended Otherness Arts, Transparency Style, Unshakable Yang Form: Giant Spark-Deflecting Waltz
 - Augmented Hydra Arts, Feral Script Style, Waterfall Form: Bloody Condor
 - Augmented Killing Frenzy Arts, Endless Crows Style,  Ash Form: Giant Eagle-Biting Saint
 - Augmented Pounce Arts, Pure Point Style, Soaring Palm Form: Five-Fold Lightweight Unwavering Heavenhold
 - Augmented Riding Guardian Arts, Transformation Style, Enlightenment Form: Cyclone of Protector
 - Augmented Rolling Center Unbound Arts, Toxic Tremor Style, Fiery Charge Form: Command of the Road
 - Augmented Strikes Arts, Destructive Quick Style, Traceless Orthodox Form: Song
\page

 - Augmented Unparalleled Drunken Emptiness Arts, Lunar Dance Style, Infernal Song Form: Dual-Root Rises Trial
 - Augmented Winter Arts, Repelling Obsidian Empty Style, Penetrating Void Beam Form: Song of Protector
 - Aureate Angel Arts, Red Soar Style, Charging Chaotic Wanderer Form: Sonic Rectitude
 - Aureate Bear Arts, Blessed Wounding Karmic Style, Equine Chariot Form: Dual-Stroke Gathering Blossom
 - Aureate Butterfly Arts, Devouring Daoist Style, Pyrocascade Form: Ruin of Coil
 - Aureate Elements Arts, Gallant Fiery Comb Style, Tremor Form: Triple Kings Deflecting Monastery
 - Aureate Exorcism Arts, Midsummer Waxing Spiritage Style, Twin Silent Form: Triple Bodhidharma Bowing Beasts
 - Aureate Forged Devil Arts, Universal Crazy Fertile Style, Sudden Beak Form: Sinister of the Old Lotus
 - Aureate Grafting Penetrating Assimilation Arts, Sacred Drunken Ascending Style, Dancing Slash Form: Possession of Thousands
 - Aureate Grounded Blazing Eternal Arts, Holy Sweeping  Style, Spiritual Trident Form: Triple Edge Controlling Scholar
 - Aureate Infusion Arts, Advanced Dust Style, Downward Web Form: Hand of the Destruction
 - Aureate Mirage Shade Arts, Invisible Martyr Style, Bloody Raven Form: Grove of Steel
 - Aureate Quick Sect Arts, Smashing Motion Style, Deep Authority Form: Heritage
 - Aureate Road Arts, Coastal Center Blossoms Style, Equal Dao Form: Brilliant Forest
 - Aureate Slicing Subduing Comb Arts, Skeletal Palm Style, Enlightened Killer Form: Thread Severing Rocky
 - Aureate Surge Arts, Poisonous Wild Chin Style, Unknowable Drain Form: Giant Opposition-Ascending Deities
 - Aureate Taming Arts, Fiendish Bloodstained Meridian Style, Fatal Goldenring Form: Six Countering Galaxy
 - Aureate Treading Great Steel Arts, Moon Style, Dirty Parallel Form: Moonlit Sound
 - Aureate Waterfall Arts, Center Cawing Rising Style, Fleeting Protector Form: Crows Going Moonbeam
 - Azure Absolute Aura Arts, Buddhist Variation Style, Lunar Condor Form: Giant Guardian-Transforming Bow
 - Azure Big Exorcism Arts, Foundational Daybreak Style, Old Drain Form: Giant Punch-Gathering Quartet
 - Azure Blooming Total Arts, Gallant Breaker Style, Grace Form: Blossom Rising Millennium
 - Azure Consciousness Arts, Bloodthristy Things Style, Defensive Tea Form: Interference-Resisting Living Space
 - Azure Dividing Stab Arts, Radiant Breakout Style, Skills Form: Defiers of the Whirling Cosmos
 - Azure Equine Erupting Volcano Arts, Unparalleled Leaves Style, Tearing Pattern Form: Dual-Specter Transforming Punch
 - Azure Explosion Arts, Graceful Archery Style, Corrupted Light Form: Indestructible Eternal Breaking Dragon
 - Azure Monk Arts, Salvation Style, Hidden Buddhist Arrow Form: Eagle of Interference
 - Azure Nature Arts, Royal Style, Serene Skull Form: Soar-Swirling Ancient Origin
 - Azure Profound Southern Kings Arts, Vibrant Style, Extinguishing Scale Form: Decree
 - Azure Rebounding Repentant Wrath Arts, Merciful Apex Condor Style, Unforgiving Penetrating Flight Form: Sharpened of the Life
 - Azure Slayer Arts, Soaring Chaos Style, Void Pearlflower Form: South Resonating Scheme
 - Azure Spiritage Arts, Arrows Style, Bloody Tipsy Form: Six Weakening Trio
 - Azure Thunderous Cosmic Poison Arts, Ink Style, Chariot Form: Crown of the Ursine
 - Azure Thunderous Tail Arts, Beasts Style, Spiritual Punch Form: Triple Devastation Poking Transformation
 - Azure Variation Arts, Double Fang Style, Traditional Hawkstrider Form: Breakthrough of Cross
 - Azure Venomous Mad Bloom Arts, Exploding Petal Frontier Style, Spanning Unbound Form: Nails
 - Azure Vile Mysterious Cry Arts, Mind Style, Manifestation Form: Six Breaking Crushes
 - Balanced Aegis Arts, Whirling Wolf Style, Dual Triple Form: Dual-Tipsy Paralizing Flow
 - Balanced Blessed Heavenly Explosion Arts, Spanning Elemental Massacre Style, Skeletal Night Form: Six Transforming Phenomena
 - Balanced Block Arts, Featherweight Variation Style, Cold Fiendish Taming Form: Dual-Vedas Steeled Emergence
\page

 - Balanced Corvid Embracing Master Arts, United Style, Grounded Governing Sky Form: Unforgiving Nether Concealing Net
 - Balanced Extra Gentle Pearl Arts, Mirage Bloodthristy Eternal Style, Drunken Chackra Form: Dual-Autumn Grounding Energy
 - Balanced Flames Arts, Dominating Cremation Style, Lightness Form: Dual-Devil Lunging Path
 - Balanced Inferno Arts, Nomad Style, Hawk Form: Hellish Awakening
 - Balanced Interference Arts, Endless Brush Style, Blessed Army Form: Karmic Dodging Mindless
 - Balanced Killing Drunken Mobility Arts, Wounding Rising Destroyer Style, Capped Skills Form: Shaolin of the Absolute Raptor
 - Balanced Leniency Arts, Nefarious Elegance Style, Wild Slayer Form: Fortune-Biting Bloodstained Chill
 - Balanced Midsummer Stroke Arts, Harmonious Turtle Style, Gentle Veil Form: Giant Punch-Summoning Disruption
 - Balanced Mirage Fate Arts, Wild Evil Shout Style, Demonic Stealth Form: Consciousness-Crouching Copper Illuminated
 - Balanced Prajna Arts, Perfect Variation Style, Imperial Endless Annihilation Form: Six Counterattacking Wrath
 - Balanced Scripture Arts, Mighty Trill Style, Unrivaled Indestructible Triple Form: Six Reflecting Cry
 - Balanced Unshakable Heart Arts, Infernal Ascending Cut Style, Basilisk Form: Dual-Wraith Binding Rapid
 - Balanced Western Unrivaled Calamity Arts, Stomp Style, Governing Sharpened Form: Six Steeled Method
 - Balanced Woodland Arts, Rolling Karma Style, Severance Form: Unshakable Wisdom
 - Basic Barrier Arts, Mothers Style, Enlightened Peak Form: Priest
 - Basic Current Double Grasp Arts, Giant Undivinable Fog Style, Feral Roar Form: Triple Thousands Confronting Skull
 - Basic Moonlight Arts, Great Rightful Steel Style, Heartless Stance Form: Giant Sound-Tangled Frenzy
 - Basic Penetrating Distinction Arts, Archery Style, Elegant Final Smoke Form: Thunderwake of the Cosmos
 - Basic Realm Arts, Constellation Style, Ridge Form: Consecutive Sweep Emerging God
 - Basic Repentant Shadowless Arts, Plate Style, Spiritual Tang Form: Giant Traceless-Aiming Sweep
 - Basic Road Arts, Unknowable Stone Style, Riding Formless Sufferings Form: Rising Meridian Twisting Coil
 - Basic Traversing Ruin Arts, Graceful Rain Style, Adaptive Intention Form: Crazy Breaker
 - Big Cinder Arts, Subduing Quick Monkey Style, Sun Form: Barrage of the Manifestations
 - Big Crow Arts, Arching Corrupted Treading Style, Unified Spike Form: Venomous Pear Going Polarm
 - Big Crow Arts, Formless Cutter Style, Augmented Prestissimo Form: Dual-Thread Traveling Butterfly
 - Big Descent Arts, Quick Wildfire Style, Radiant Grip Form: Sacred Paladin
 - Big Dragon Arts, Corvid Merciful Pack Style, Blessed Woods Form: Tea Stabbing Barrage
 - Big Few Lightweight Arts, Traceless Birthless Northern Style, Binder Form: Giant Starlit-Piercing Vedas
 - Big Merciful Infinite Tongue Arts, Avatar Style, Drunken Mothers Form: Earthen Mirrored Feinting Clarity
 - Big Myriads Arts, Emerald Ancient Barrage Style, Formless Exorcism Form: Expansive Height
 - Big Parallel Western Strength Arts, Few Defense Style, Ravenous Cursed Gateways Form: Giant Reguard-Controlling Sufferings
 - Big Pillar Arts, Splitting Void Interference Style, Full Flash Form: Enigma Drifting Change
 - Big Return Arts, Hellish Moonlit Blood Style, Shout Form: Undivinable Thunderbolts
 - Big Unshakable Point Arts, Bloody Deities Style, Crimson River Form: Dual-Vedas Dispersing Soft
 - Big Venomous Red Fleche Arts, Luminous Illusory Possession Style, Center Thunderclap Form: Triple Warriors Shifting Hand
 - Birthless Capped Neck Arts, Mysterious Basilisk Style, Ravenous Tail Form: Old Swift
 - Birthless Extra Eternal Vitality Arts, Burning Rising Meridian Style, Forged Exchange Form: Five-Fold Temple Soothing Snakeform
 - Birthless Manifestation Arts, Living Seaspan Style, Stellar Weaver Form: Six Bowing Shroud
 - Birthless Pierce Arts, Diving Extinguishing Constellation Style, Coastal Skill Form: Giant Stomp-Confronting Swarm
 - Birthless Sudden Bloodstained Taebaek Arts, Unparalleled Assault Style, Cardinal Maiden Form: Bloodthristy Siege Traversing Explosion
\page

 - Birthless Sun Arts, Finishing Battalion Style, Summit Form: Tongue of the Circle
 - Birthless Vigor Arts, Range Style, Gentle Grafting Perfusion Form: Unbounded Transforming Massacre
 - Birthless Warrior Arts, Fleeting Universal Mysterious Style, Radiant Paladin Form: Elegant Reflection
 - Black Consuming Circulation Arts, Bloodthristy Exchange Style, Elegant Primordial Suppression Form: Rapid of the North Tipsy
 - Black Few Burning Annihilation Arts, Spinning Lofty Style, Prelude Form: Triple Slayer Going Pear
 - Black Full Extra Technique Arts, Cutting Righteous Strike Style, Felling Ceremony Form: Projectile-Crouching Hidden Viper
 - Black Ice Arts, Expansive Parallel Style, Center Trial Form: Tearing Range
 - Black Icy Cold Sage Arts, Grounded Brook Style, Taming Form: Dual-Center Covering Illuminated
 - Black Limitless Warrior Arts, Gentle Elegance Style, Hellish Authority Form: Six Defending Absorption
 - Black Magnanimous Fire Arts, Holy Space Style, Rolling Domination Form: Deep Bite Feinting Spiral
 - Black Royal Arts, Indestructible Heartless Crazy Style, Nail Form: Six Controlling View
 - Black Silver Responsive Trident Arts, Extinguishing Flying Disciple Style, Grappling Polearm Form: Five-Fold North Resting Sonata
 - Black Switch Arts, Gateways Style, Cawing Kaleidoscope Form: Nefarious Nature
 - Black Unrivaled Intention Arts, Obscure Quell Style, Adaptive Sonic Space Form: Five-Fold Depth Weakening Breakout
 - Blazing Breakthrough Arts, Penetrating Disciple Style, Origin Form: Extended Flameball
 - Blazing Cold Great Pyre Arts, Facing Toxic Slicing Style, Liberated Throwing Specter Form: Silent-Flowing Dividing Madness
 - Blazing Eternal Arts, Coastal Star Style, Flying Demonic Mastery Form: Six Taking Path
 - Blazing Imperial Clarity Arts, Outward Sacred Limitless Style, Equal Ancient Spearplay Form: Sage-Shaking Extreme Warrior
 - Blazing Intent Arts, Awakening Style, Icy Thousand Form: Giant Eagle-Searching Rectitude
 - Blazing Onyx Moonlit Archery Arts, Sonic Coral Destroyer Style, Enlightened Raven Form: Giant Scripture-Rises Snake
 - Blazing Sanctum Arts, Treading Red Repentant Style, Center Circulation Form: Volcano-Swaying Spectral South
 - Blazing Shockwave Arts, Mighty Basilisk Style, Striking Bodhi Form: Eclipse of the Extreme Shadowless
 - Blazing Twin Ultimate Woods Arts, Enlightened Riding Bloody Style, Obscure Chariot Form: Venomous Curse Descending Slip
 - Blessed Cold Devouring Omnidirectional Arts, Living Slayer Style, Many Daybreak Form: Chop of the Gem Exchange
 - Blessed Curse Arts, Soaring Sword Style, Army Form: Devastation-Commanding Mysterious Defiers
 - Blessed Equine Cave Arts, Adaptive Consecutive Crazy Style, Slicing Echo Form: Astral Method Shaking Tundra
 - Blessed Fiery Unparalleled Infiltration Arts, Poison Style, Continuous Kings Form: Cloak
 - Blessed Instance Arts, Celestial Space Style, Smashing Stride Form: Violent Spear Paralyzing Origin
 - Blessed Karmic Arts, Imperial Principles Style, Thunderous Acala Form: Giant Move-Swirling Edge
 - Blessed Long Arts, Charging Rends Style, Infiltration Form: Giant Jewel-Soothing Beak
 - Blessed Mindscape Arts, Boxing Essence Style, Fiery Calamity Form: Triple Pillar Fighting Pearl
 - Blessed Monastery Arts, Shooting Flying Harvest Style, Harmonious Spectral South Form: Fall of Frenzy
 - Blessed Noble Arts, Calm Hellish Dividing Style, Cosmic Sheet Form: Responsive Motion Invigorating Priest
 - Blessed Obsidian Golden Pattern Arts, Fading Forged Outward Style, Hands Form: Moonlight-Sacrificing Rolling Ghost
 - Blessed Repents Arts, Coated Toss Style, Unknowable Extinguishing Quartet Form: Dual-Lightning Sacrificing Coil
 - Blessed Rising Unity Arts, Absolute Metallic Snow Style, Saving Blister Form: Giant Barrier-Revitalizing Web
 - Blessed Shattering Iron Shift Arts, Cobra Style, Absolute Skill Form: Ursine of Leaves
 - Blessed Triadic Arts, Parallel Slip Style, Flying Emptiness Form: Six Matching Firebrand
 - Bloodstained Awakening Arts, Erupting Elegant True Style, Venomous Coated Radiance Form: Giant Assault-Observing Waltz
 - Bloodstained Black Ancient Tempest Arts, Manifestations Style, Infinite Trap Form: Triple Stride Rising Barrier
\page

 - Bloodstained Coastal Monkey Arts, Empty Ascending Crown Style, Chaotic Twin Leniency Form: Return of Legs
 - Bloodstained Fleche Arts, Serpent Style, Guardian Form: Monkey-Emerging Eastern Mothers
 - Bloodstained Manifestation Arts, Snow Fatal Domain Style, Radiant Unified Fortress Form: Rivers of the Shattering Fox
 - Bloodstained Pierces Arts, Stalwart Style, Sonic Temper Form: Sutra of Exorcism
 - Bloodstained Polarm Arts, Illuminating Calm Blaze Style, Wandering Intent Form: Giant Emptiness-Attacking Gateways
 - Bloodstained Reflection Arts, Crimson Sword Style, Mad Ghost Form: Duck of the Illuminated
 - Bloodstained Rising Gentle Grove Arts, Traditional Scale Style, Augmented Trigrams Form: Proud of the Phenomena
 - Bloodstained Shell Arts, Deep Myriads Style, Facing Change Form: Coated Battlefield
 - Bloodstained Stride Arts, Mindscape Style, Illuminating Grand Mirrored Form: Five-Fold Otherness Severing Grasp
 - Bloodstained Thoughtless Arts, Repentant Wolf Style, Madness Form: Shatters of the Enigma
 - Bloodstained Thousand Arts, Limitless Merciful Nullification Style, Eastern Chaotic Fist Form: Wood of the Cardinal Barrier
 - Bloodstained Traversing Seaspan Arts, Flying Mount Style, Quanzhen Form: Pearl
 - Bloodthristy Bite Arts, Living North Style, Dividing Formation Form: Magnanimous Exchange
 - Bloodthristy Blessing Arts, Extended Fleeting Mystic Style, Cold Proud Form: Movement of the Many Script
 - Bloodthristy Continuous Sword Arts, Meditation Style, Gallant Ascension Form: Nail of Exchange
 - Bloodthristy Copper Adaptive Rain Arts, Nebula Style, Manifestations Form: Essence
 - Bloodthristy Dual Path Arts, Feral Solar Mindless Style, Eternal Fish Form: Pierces of the Awakening
 - Bloodthristy Fiendish Rolling Net Arts, Thaw Style, Center Rectitude Form: Universal Scheme
 - Bloodthristy Invisible Cosmic Weaver Arts, Kaleidoscope Style, Encompassing Pulse Form: Asterism of Sui
 - Bloodthristy Liberated Eclipse Arts, Infernal Glacier Style, Big Delights Form: Unified Emergence Falling Skills
 - Bloodthristy Manipulation Arts, Undivinable Ripping Crush Style, Foundation Form: Onyx Beggar Emerging Formation
 - Bloodthristy Omnidirectional Arts, Water Style, Charging Thousand Form: Six Gathering Stream
 - Bloodthristy Perfect Lofty Arts, Devastating Ruin Style, Spiral Form: Comb of the Earth
 - Bloodthristy Rivers Arts, Fiendish Perfect Black Style, Facing Meditation Form: Cutting Center Airsplitting Assaliants
 - Bloodthristy Single Vajrapani Arts, Rolling Absorption Style, Darkwind Form: Invisible Gust
 - Bloodthristy Smoke Arts, Spiritual Infernal Kaleidoscope Style, Mysterious Elements Form: Fox-Flowing Hellish Kings
 - Bloodthristy Split Arts, Sealing Direction Style, Mirage Mothers Form: Roving Triadic
 - Bloodthristy Thousand Arts, Corrupted Obsidian Disinterment Style, Abyssal Nebula Form: Dual-Gorge Vispering River
 - Bloodthristy Treading Snow Dragon Arts, Radiant True Mirror Style, Outward Omnidirectional Form: Five-Fold Path Vispering Enigma
 - Bloodthristy Viper Arts, Retribution Style, Gallant Wheel Form: North Thousands
 - Bloodthristy Warmth Arts, Striking Mirage Waxing Style, Exchange Form: Six Reflecting Arhat
 - Bloody Absorption Arts, North Ethereal Beasts Style, Assimilation Form: Six Enduring Vapor
 - Bloody Adaptive Sanctum Arts, Parallel Resonance Style, Invisible Enigma Form: Ravenous Sufferings
 - Bloody Aegis Arts, Mad Tortoise Style, Eternal Soul Form: Giant Taiji-Linking Hell
 - Bloody Buddhist Lightning Arts, Chaotic Unmatched Dirty Style, Fate Form: Refraction
 - Bloody Chaotic Possession Arts, Spiraling Fist Style, Hunyuan Form: Six Biting Plague
 - Bloody Formless Mirage Spin Arts, Sudden Nails Style, Aureate Fox Form: Primordial Cuts Aiming Reflection
 - Bloody Jeweled Arts, Legged Storms Style, Outward Resonance Form: Five-Fold Necrotoxin Burning Chackra
 - Bloody Liberated Drunken God Arts, Sealing Big Lower Style, Advanced Ascension Form: Triple Vibrant Coiling Proud
 - Bloody Protective Turtleback Arts, Sealing Vapor Style, Saving Veiled Form: Acala of the Current Trio
\page

 - Bloody Spinning Form Arts, Transparency Style, Destructive Night Form: Dual-Elder Emerging Forest
 - Bloody Vermillion Weapon Arts, Unbounded Style, Gentle Walk Form: Soaring Daybreak Cutting Asterism
 - Bloody Volcano Arts, Foundational Phoenix Style, Warrior Form: Triple Firebrand Counterattacking Needles
 - Bloody Wounding Sonata Arts, Evil Long Style, Frosty Coil Form: Six Matching Raven
 - Blooming Bodhi Arts, Secret Sect Style, Elemental Prayer Form: Dual-Momentum Chopping Legacy
 - Blooming Book Arts, Bound Style, Unified Dark Barrage Form: Mystic Truth
 - Blooming Brush Arts, Blister Style, Killing Prelude Form: Change Leaping Neck
 - Blooming Change Arts, Fading Wicked Grove Style, Nefarious Beak Form: Five-Fold Bird Swirling Fate
 - Blooming Defensive Hidden Star Arts, Martial Bloodstained Expansive Style, Unshakable Lower Mind Form: Bodhidharma Following Disinterment
 - Blooming Devastating Righteous Technique Arts, Coastal Precept Style, Traditional Spiraling Heart Form: Wing Going Circulation
 - Blooming Elemental Mirror Arts, Elegant Hands Style, Dual Center Form: Taihua Tearing Leap
 - Blooming Exchange Arts, Liberated Bright Equal Style, Repentant Ink Form: Mirage Cyclone Rising Nullification
 - Blooming Golden Vile Malignant Arts, Downward Spectral Rage Style, Tearing Swords Form: Darkwind of the Spirits
 - Blooming Grip Arts, Augmented Crushes Style, Holy Grappling Nebula Form: Five-Fold Vampire Weakening Tempo
 - Blooming Ladder Arts, Enemies Style, Rolling Giant Chackra Form: Five-Fold Martyr Shifting Illuminated
 - Blooming Martyr Arts, Quick Dominating Beak Style, Repelling Total Form: Five-Fold Fish Soothing Grip
 - Blooming Quanzhen Arts, Vile Evil Unforgiving Style, Shattering Footstep Form: Staff-Taking Fiendish Prayer
 - Blooming Quell Arts, Parallel Repents Style, Cutter Form: Six Paralizing Verdant
 - Blooming Serene Fertile Trinity Arts, Waning Shattering Intent Style, Repelling Thread Form: Daoist-Swirling Consuming Repents
 - Blooming Strength Arts, Battalion Style, Ultimate Omnidirectional Form: Gallant Harmony Tangled Fiend
 - Blooming Thunderbolt Arts, Formless Dirty Brilliant Style, Ultimate Raven Form: Dual-Breaker Commanding Stalwart
 - Blooming Thunderclap Arts, Ghostly Taiji Style, Stellar Stalwart Form: Giant Team-Going Spearplay
 - Blooming Treading Devastating Clouds Arts, Infiltration Style, Ancient Grappling Path Form: Giant Circle-Taking Remains
 - Blooming Treading Distinction Arts, Boxing Mind Style, Reaper Form: Veil Resonating Deity
 - Boundless Aureate Drunken Realm Arts, Blaze Style, Defense Form: Disinterment
 - Boundless Book Arts, Consecutive Big Infinite Style, Chariot Form: Triple March Ensnaring Goldenring
 - Boundless Bright Holy Vigor Arts, Cardinal Sutra Style, Warrior Form: Quick of the Healing Sweetened
 - Boundless Charge Arts, Snow Cage Style, Shapeshifter Form: Killing Haunt
 - Boundless Dew Arts, Calm Ape Style, Protective South Form: Infernal Awakening
 - Boundless Downward Zenith Arts, Saving Curse Style, Eastern Windswept Form: Dual-Turtle Cleaving Dragontail
 - Boundless Gem Boxing Goldenring Arts, Endless Abyssal Crimson Style, Transparency Form: Devil
 - Boundless Gust Arts, Void Prestissimo Style, Featherweight Change Form: Beast of the Lotus
 - Boundless Intent Arts, Nefarious Wolf Style, Basic Pillar Form: Five-Fold Blister Transforming Karmic
 - Boundless Lattice Arts, Encompassing Merciful Echo Style, Unknowable Mirage Snake Form: Windrider of Deflection
 - Boundless Lotus Arts, Snow Luminous Eclipse Style, Family Form: Dual-Orthodox Biting Arrows
 - Boundless Monastery Arts, Sky Style, Current Smashing Vajrayana Form: Swing
 - Boundless Thunderbolts Arts, Crusher Style, Vibrant Form: Giant Roars-Sharpening Slayer
 - Boundless West Arts, Single Marquis Style, Invisible Shapeshifter Form: Dividing Shade
 - Boxing Bird Arts, Extended Cosmic Descending Style, Formless Commander Form: Five-Fold Destroyer Crouching Devastation
 - Boxing Buddhist Graceful Immovable Arts, Roar Style, Move Form: Triple Shatters Unwavering Zen
\page

 - Boxing Calm Continuous Lost Arts, Protective Toxic Foundational Style, Toxin Form: Five-Fold Pack Lunging Horse
 - Boxing Command Arts, Righteous Aspects Style, Augmented Hail Form: Ripping Shaolin Counterattacking Edge
 - Boxing Extra Royal Arts, Single Movement Style, Vermillion Center Form: Lord Grounding Redemption
 - Boxing Gem Pounce Arts, Living Pierces Style, Obsidian Kundali Form: Stretched of Glacier
 - Boxing Harmonies Arts, Cosmic Rolling Pearl Style, Coastal Battlefield Form: Five-Fold Swan Dodging Triadic
 - Boxing Illuminating Dipper Arts, Fang Style, Cursed Advent Form: Giant Polearm-Resisting Leech
 - Boxing Illusory Range Arts, Iron View Style, Elements Form: Five-Fold Palm Going Fall
 - Boxing Lofty Arts, Stunning Nature Style, Quick Form: Body of the Unknowable Reaper
 - Boxing Midsummer Rightful Trial Arts, Warmaster Style, Forged Taebaek Form: Warfield
 - Boxing North Arts, Extreme Stunning Infernal Style, Waxing Verdant Form: Cursed Rotation Enduring Scholar
 - Boxing Petal Celestial Variation Arts, Subduing Raven Style, Ancient Foundational Rhythm Form: Five-Fold Unbound Slicing Palms
 - Boxing Piercer Arts, Equal Whirling Dive Style, Extinguishing Corrupted Deity Form: Giant Cage-Severing Flower
 - Boxing Shadow Guard Arts, Mystic Heart Style, Abyssal Style Form: Martyr
 - Boxing Stomp Arts,  Blossoms Style, Fiery Variation Form: Nature Fighting Monastery
 - Boxing Taihua Arts, Adamantine Omnidirectional Style, Illuminating Whip Form: Pounce of the Direction
 - Boxing Wave Arts, Feral Zenith Style, Double Yin Form: Vajrapani
 - Boxing Wraith Arts, Intoxicated Finishing Throwing Style, Cobra Form: Triple Bat Following Killer
 - Bright Burst Arts, Absolute Unrivaled Deep Style, Yellow Mothers Form: West of the Secret Viper
 - Bright Enemies Arts, Snow Emergence Style, Killing Exorcism Form: Giant Discipline-Rises Priest
 - Bright Expansive Haunt Arts, Indestructible Emerald Undivinable Style, Palm Form: Weaver-Concealing Gallant Fortune
 - Bright Fertile Binder Arts, Expansive Enigma Style, Heavenly Scale Form: Giant Contemplate-Dispersing Salvation
 - Bright Flower Arts, Onyx Mighty Azure Style, Radiant Dive Form: Feral Aspects
 - Bright Force Arts, Solar Saving Continuous Style, Beam Form: Five-Fold Sylvan Crouching Kill
 - Bright Galaxy Arts, 53rd Grasp Style, Devastating Encompassing Authority Form: Body Paralyzing Sisi
 - Bright Perfect Few Orthodox Arts, Gale Style, Pack Form: Six Ending Emptiness
 - Bright Petal Switch Arts, Infinite Obscure Cuts Style, Boundless Onyx Latch Form: Six Tearing Spear
 - Bright Reguard Arts, Big Infusion Style, Imperial Scatter Form: Six Revitalizing Hail
 - Bright Toxin Arts, Downward Crush Style, Endless Limitless Things Form: Constellation of Heat
 - Bright Viper Arts, Hoarforst Style, Dominating Instance Form: Triple Lotus Observing Sonata
 - Bright Wing Arts, Gentle Fang Style, Expansive Intent Form: Tea
 - Brilliant Canyon Arts, Demonic Circle Style, Lunar Grafting Bodhi Form: Road-Feinting Dancing Palms
 - Brilliant Glacial Star Arts, Onyx Sonic Prestissimo Style, Basilisk Form: Authority of the Bright Acala
 - Brilliant Heavenly Evil Nomad Arts, Forged Slashes Style, Crossing Flame Form: Destiny of Quartet
 - Brilliant Jade Prayer Arts, Drunken Snowfield Style, Dominating Center Army Form: Six Rises Eclipse
 - Brilliant Jade Wicked Enemies Arts, Blooming Discipline Style, Traceless Calm Spread Form: Dual-Consciousness Fighting Piercer
 - Brilliant King Arts, Infernal Needle Style, Glow Form: Six Shattering Strike
 - Brilliant Kings Arts, Treading Boundless Kill Style, Ravenous Fate Form: Windrider of the Absolute Asura
 - Brilliant Limitless Secret Tide Arts, Vile Sutra Style, Facing Siege Form: Nomad of Arrows
 - Brilliant Opposition Arts, Deep Spectral Unshakable Style, Universal Swift Form: Five-Fold Shadowy Countering Rectitude
 - Brilliant Paradise Arts, Granite Style, Shattering Extra Transparency Form: Dual-Star Emerging Pattern
\page

 - Brilliant Poisonous Daoist Arts, Many Blossoms Style, Repentant Dive Form: Foxform Turtleback
 - Brilliant Roars Arts, Tidal Plume Style, Gallant Strikes Form: Spearplay of the Grounded Master
 - Brilliant Touch Arts, Warmaster Style, Rivers Form: Dual-Serpent Stopping Step
 - Brilliant Trigrams Arts, Full Malevolent Spiritage Style, Cawing Saving Taiji Form: Six Dispersing Book
 - Brilliant Unknowable Dirty Phantom Arts, Many Script Style, Unmatched Dividing Majestic Form: Five-Fold Exchange Resonating Weaver
 - Bronze Barrier Arts, Aureate Brush Style, Brilliant Might Form: Five-Fold Prajna Ascending Staff
 - Bronze Break Arts, Spearplay Style, Soaring Forged Proud Form: Vigor of the Grand Reaper
 - Bronze Empty Divine Flesh Arts, Giant Palms Style, Penetrating Deep Destruction Form: Undivinable Eternal Flowing Plume
 - Bronze Facing Quake Arts, Formless Bird Style, Encompassing Wandering Chaos Form: Mirror Shattering Instance
 - Bronze Fury Arts, Spirit Big Reaction Style, Hands Form: Assaliants of the Deep Stance
 - Bronze Metallic Azure Echo Arts, Ancient Fortress Style, Saving Moonlight Form: Astral Exorcism
 - Bronze Mist Arts, Unveiled Style, Devouring Subduing Dance Form: Triple Illusion Dispersing Cry
 - Bronze Throwing Tiger Arts, Diving Rapid Style, Heritage Form: Triple Judgment Swirling Drift
 - Buddhist Augmented Starvation Arts, Featherweight Fleche Style, Unveiled Form: Balanced Crash Weakening Sweetened
 - Buddhist Devastating Sect Arts, Azure Point Style, Birthless Downward Cosmos Form: Piercer of Cleave
 - Buddhist Full Scatter Arts, Breakthrough Style, Extinguishing Mobility Form: Six Tangled Possession
 - Buddhist Heat Arts, Giant Family Style, Burning Priest Form: Repelling Roars Ascending Transparency
 - Buddhist Incineration Arts, Dominating Legs Style, Turtle Form: Family of Sun
 - Buddhist Luminous Subduing Demon Arts, Liberated Moonlight Style, Ancient Cascade Form: Five-Fold Web Shattering Torment
 - Buddhist Lunar Bronze Hand Arts, Heavenly Blade Style, Dividing Forms Form: Assault of the Piercer
 - Buddhist Mirage Unmatched Waters Arts, Roving Mobility Style, Sealing Swift Form: Giant Drowned-Transforming Cloak
 - Buddhist Move Arts, Treading Pure Undivinable Style, Chariot Form: Five-Fold Wolf Dispersing Seaspan
 - Buddhist Quick Merciful Flameball Arts, Celestial Master Style, Encompassing Otherness Form: Windrider of the Void Army
 - Buddhist Rapid Arts, Cutting Thousand Style, Descending Quake Form: Paladin of Devil
 - Buddhist Redemption Arts, Warrior Style, Soar Form: Torment
 - Buddhist Severance Arts, Mystic Shadowless Style, Swords Form: Bamboo Fighting Rhythm
 - Buddhist Vigor Arts, Augmented Pinnacle Style, Virtuous Boulder Form: Sky of the Scarlet
 - Burning 56th Indestructible Snowfall Arts, Ancient Limitless Breaker Style, Bloodstained Pattern Form: Six Searching Buddha
 - Burning Azure Rampage Arts, Augmented Dao Style, Pierce Form: Six Going Illusion
 - Burning Bronze Throwing Thaw Arts, Sonic Wolf Style, Spinning Obscure Waltz Form: Poison Draining Statue
 - Burning Defensive Paradise Arts, Ruin Style, Luminous Few Spiral Form: Triple Night Resting Pinnacle
 - Burning Iron Exorcism Arts, Mount Style, Elegance Form: Single Pattern Cleaving Marquis
 - Burning Martyr Arts, Hand Style, Heavenly Graceful Cloak Form: Delights of the Wildfire
 - Burning Monk Arts, Protective Beam Style, Cawing Drift Form: Center Covering Battle
 - Burning Ocean Arts, Infernal Grand Mystic Style, Elusive Demonic Vajrayana Form: Giant Cross-Drifting Sound
 - Burning Ridge Arts, Exploding Severance Style, Wandering Governing Shout Form: Toss-Swirling Serene Arm
 - Burning Sheet Arts, True Foundation Style, Encompassing Discipline Form: Bear of the Mystic Thunder
 - Burning Sugar Arts, Crazy Foxform Parallel Style, Fleche Form: Dual-Flames Following Opening
 - Burning Truth Arts, Righteous Descent Style, Rolling Primordial Sanctum Form: Rampage
 - Burning Truth Arts, Single Shatter Style, Invisible Hell Form: Opening Dispersing Flames
\page

 - Calm  Tipsy Arts, Bloodstained Imperial Unparalleled Style, Demonic Western Heart Form: Beggar
 - Calm Birthless Balanced Fist Arts, Governing Depth Style, Tundra Form: Crown
 - Calm Coastal Mighty Tongue Arts, Illuminating Bind Style, Roving Cry Form: Manifestation of the Cursed Drowned
 - Calm Destructive Virtuous Domain Arts, Glacial Quartet Style, Apex East Form: Six Going Assault
 - Calm Grappling Infinite Burst Arts, Intoxicated Glow Style, Stance Form: Six Paralizing Eruption
 - Calm Healing Throwing Tigers Arts, Solar Total Style, Charging Leaves Form: Triple Taihua Crouching Pounce
 - Calm Liberated Sudden Man Arts, Shadow Fertile Encompassing Style, Venomous Eagle Form: Thousand of the Repentant Jeweled
 - Calm Misty Arts, Lunar Healing Fate Style, Bloody Sun Form: Triple Vigor Unwavering United
 - Calm Profound Transformation Arts, Birthless Unshakable Sanctity Style, Ancient Defiers Form: Phoenix of the Angel
 - Calm Shadow Prism Arts, Dirty Elusive Thousands Style, North Road Form: Triple Tempo Lunging Tail
 - Calm Staff Arts, Legged Echo Style, Pounce Form: Stab of the Birthless Torment
 - Calm Steps Arts, Adaptive Eternal Corvid Style, Toxic Jade Harmonies Form: Chaos of the Righteous Triadic
 - Calm Trinity Arts, Repentant Haunt Style, Traversing Piercer Form: Strikes of the Stunning Ghost
 - Capped Breakthrough Arts, Infinite Circle Style, Burning Nail Form: Principles of Drain
 - Capped Butterfly Arts, Illuminating West Style, Devouring Taiji Form: Asterism of Wolf
 - Capped Decree Arts, Mighty Vigor Style, Life Form: Toss Observing Vairocana
 - Capped Dew Arts, Facing Self Style, Shade Form: Six Revitalizing Plague
 - Capped Earth Arts, Intoxicated Rotation Style, Spearplay Form: Giant Roars-Resisting Kings
 - Capped Extended Illuminating Haunt Arts, Crusher Style, Heartless Phaseless Form: Total Resonating Spiritage
 - Capped Formation Arts, Proud Style, Shadow Shura Form: Water Defending Glacier
 - Capped Many Veil Arts, Legged Shooting Indestructible Style, Dominating Split Form: Darkwind of the Subduing Paladin
 - Capped Phenomena Arts, Quanzhen Style, Unparalleled Decree Form: Triple Bound Resting Frenzy
 - Capped Radiant Thousands Arts, Dark Extreme Chackra Style, Light Form: Lake of Trident
 - Capped Shell Arts, Rising Priest Style, Erupting Qintfade Form: Polar Dispersing Pear
 - Capped Signless Arts, Mighty Strike Style, Chaotic Needle Form: Six Reflecting Assault
 - Capped Smashing Cursed Blaze Arts, Extreme Avatar Style, Heartless Polearm Form: Six Rising Quanzhen
 - Capped Specter Arts, Immortal Nature Style, Shooting Staff Form: Five-Fold Snowlocked Resting Harmony
 - Capped Sun Arts, Slicing Mindless Style, Cutting Aquatic Depth Form: Giant Emergence-Coiling Cage
 - Capped Wrath Arts, Adamantine Direction Style, Chin Form: Shaolin Piercing Stealth
 - Cardinal Advanced Avatar Arts, Bloodstained Pyrocascade Style, Perfect Leaf Form: Six Slicing Bamboo
 - Cardinal Basic Cliff Arts, Unparalleled Path Style, Tail Form: Foundation
 - Cardinal Enigma Arts, Lunar Crossing Absolute Style, Pearlflower Form: Dual-Riddle Scorching Unrestrained
 - Cardinal Gem Spring Arts, Big Glow Style, Traversing Sweeping Charge Form: Eastern Arrow Blooming Trinity
 - Cardinal Luminous Devastating Chain Arts, Western Warmaster Style, Weapon Form: Giant Sect-Flowing Kaleidoscope
 - Cardinal Mothers Arts, Riding Scarlet Style, Dual Harmonious Shadowy Form: Winds
 - Cardinal Plate Arts, Basic Slip Style, Obscure Fiendish Long Form: Protective Polearm
 - Cardinal Rectitude Arts, Intoxicated Illusory Righteous Style, Rebounding Metallic Ember Form: Five-Fold Unbound Gathering Plague
 - Cardinal Starvation Arts, Riding Fury Style, Dawn Form: Six Concealing Grip
 - Cardinal Throw Arts, Spiraling Eagle Style, Gentle Precept Form: Sui Resonating Wisdom
 - Cardinal Thunderbolt Arts, Foundational Tablet Style, Basic Volley Form: Refraction of the Ethereal Swords
\page

 - Cardinal Whirlwind Arts, Tang Style, Mirage Spiraling Direction Form: Six Walking Stroke
 - Cardinal Woods Arts, Nefarious Underworld Style, Slicing Forest Form: Flesh of the Riddle
 - Cawing Adamantine Aspects Arts, Grafting Unrestrained Style, Celestial Immortal Wheel Form: Fleche
 - Cawing Fading Giant View Arts, United Style, Coral Spread Form: Fertile Rotation Crushing Chariot
 - Cawing Final Madness Arts, Wicked Neck Style, Water Form: Five-Fold Harmonies Sleeping Sweetened
 - Cawing Gallant Vajrayana Arts, Blazing Shadow Dividing Style, Demonic Assault Form: Pierce of the Mad Ruin
 - Cawing Glacial Beak Arts, Diving Universal Dancing Style, Astral Bodhidharma Form: Frosty Man
 - Cawing Liberated Opening Arts, Defensive Double Earthly Style, Soft Form: Deities of Spiritage
 - Cawing Mothers Arts, Destructive Hoarforst Style, Blessed Consonance Form: Waterfall
 - Cawing Sheet Arts, Extreme Pure Specter Style, Whirling Wing Form: Master-Covering Sweeping Things
 - Celestial Abyssal Grafting Hawk Arts, Extended Whirling Single Style, Ceremony Form: Spin Raining Crash
 - Celestial Buddhist Silver Judgment Arts, Wounding Equal Stride Style, Heavenhold Form: Triple Kick Controlling Assault
 - Celestial Delights Arts, Living Taibai Style, Profound Tigers Form: Triple Unity Matching Spear
 - Celestial Flash Arts, Righteous Illusion Style, Lotus Form: Spiritual Range
 - Celestial Fleeting Charging Reaction Arts, Waxing Jeweled Style, Dance Form: God
 - Celestial Halo Arts, Roving Extinguishing Wanderer Style, Adaptive Patriarch Form: Giant Palms-Poking Quake
 - Celestial Harvest Arts, Aureate Touch Style, Final Tongue Form: Giant Sisi-Fighting Polar
 - Celestial Hellish Graceful Lattice Arts, Soaring Kill Style, Serene Wrath Form: Tongue of Drift
 - Celestial Maelstrom Arts, Battlefield Style, Enigma Form: Yang of the Mirror
 - Celestial Mighty Void Arts, Unified Capped Phaseless Style, Old Beast Form: Undivinable Unity Shifting Shard
 - Celestial Netherworld Arts, Consuming Shatters Style, Skeletal Chariot Form: Spin
 - Celestial Pack Arts, Formless Red Pearl Style, Stellar Countless Pillar Form: Five-Fold Transparency Confronting Toss
 - Celestial Perfusion Arts, Spirit Monk Style, Virtuous Beast Form: Dual-Manipulation Burning Roar
 - Celestial Pyrocascade Arts, Flying Trail Style, Sonic Trap Form: Six Matching Dust
 - Celestial Radiant Defense Arts, Fertile Change Style, Intoxicated Sight Form: Six Paralyzing Blister
 - Celestial Secret Divinities Arts, Healing Pearl Style, Astral Capped Warmaster Form: Giant Tail-Binding Nullification
 - Celestial Slash Arts, Extinguishing Extreme Aspects Style, Few Fate Form: Shade of the Transformations
 - Celestial Sui Arts, Traditional Ultimate Icy Style, Splitting Sword Form: Cold Disciple
 - Celestial Unrestrained Arts, Moonlit Coated Augmented Style, Diving Ocean Form: Five-Fold Body Chopping Nether
 - Center Absorption Arts, Cosmic Chin Style, Invisible Summit Form: Six Shaking Fate
 - Center Adamantine Heart Arts, Unforgiving Onyx Fading Style, Shard Form: Triple Underworld Resonating Massacre
 - Center Cloak Arts, Reflection Style, Extended Smoke Form: Fleche Revitalizing Tail
 - Center Elder Arts, Gallant Astral Stone Style, Holy Burst Form: Manifestations of the Legged Battalion
 - Center Ethereal Glacier Arts, Shattering Violent Darkwind Style, Extreme Lord Form: Triple Poisons Gathering Moonbeam
 - Center Ethereal Quartet Arts, Righteous Infinite Pearlflower Style, Slicing Authority Form: Dual-Dive Concealing Nether
 - Center Exorcism Arts, Spirit Bright Wisdom Style, Quick Equine Scripture Form: Triple Sacrificing Thousands
 - Center Full Extinguishing Viper Arts, Mysterious Black Boundless Style, Consecutive Otherness Form: Nomad of the Wheel
 - Center Great Coated Mountian Arts, Strike Style, Divine Scripture Form: Augmented Emergence
 - Center Killer Arts, North Wrath Style, Tidal Arhat Form: Equal Nomad Carrying Technique
 - Center Maelstrom Arts, Felling Things Style, Shadow Necrotoxin Form: Five-Fold Pounce Freezing Exchange
\page

 - Center Palm Arts, Limitless Smashing Cardinal Style, Healing Fiendish Veiled Form: Nothingness
 - Center Script Arts, Governing Resolve Style, Subduing Polearm Form: Cardinal Autumn
 - Center Stance Arts, Frosty Tigers Style, Endless Mountian Form: Six Grounding Sections
 - Center Tablet Arts, Abyssal Saber Style, Riding Flower Form: Six Dodging Spiritage
 - Center Unforgiving Wild Thunderwake Arts, Felling Outward Living Style, Crush Form: Serene Latch Sleeping Book
 - Chaotic Augmented Constellation Arts, Featherweight Otherness Style, Transformation Form: Turtleback-Flowing Vile Necrotoxin
 - Chaotic Beak Arts, Riding Gust Style, Bright Orthodox Form: Corvid March Freezing Force
 - Chaotic Blazing Movement Arts, Extra Defiers Style, Extinguishing Nature Form: Divinities
 - Chaotic Disruption Arts, Blazing Ancient Glide Style, Dark Graceful Mountian Form: Giant Array-Counterattacking Grip
 - Chaotic Downward Burst Arts, Invisible Cobra Style, Elements Form: Unbound
 - Chaotic Dust Arts, Old Taihua Style, Immortal Kaleidoscope Form: Triple Buddha Feinting Crow
 - Chaotic Equal Splitting Shard Arts, Waxing Punch Style, Universal Invisible Moonlight Form: Red United
 - Chaotic Fang Arts, Penetrating Crimson Elder Style, Merciful Otherness Form: Sinister-Shaking Dominating Transparency
 - Chaotic Fist Arts, Black Mountain Style, Outward Dancing Disinterment Form: Six Freezing Heart
 - Chaotic Flare Arts, Virtuous Capped Hawkstrider Style, Ascension Form: Giant Life-Carrying Kings
 - Chaotic Retribution Arts, Guard Style, Deep Riddle Form: Harvest of the Woodland
 - Chaotic Roars Arts, Whirlwind Style, Dividing Karma Form: Adaptive Drain Severing Dipper
 - Chaotic Vermillion Tremor Arts, Waxing Enigma Style, Grafting Butterfly Form: North Grip
 - Charging Breakout Arts, Yellow Mysterious Death Style, Corrupted Sugar Form: Move
 - Charging Consecutive Bloodstained Arrows Arts, Malevolent Delights Style, Fading Yellow Elegance Form: Scarlet of the Net
 - Charging Crusher Arts, Magnanimous Range Style, Elemental Kindled Form: Giant Majestic-Transforming Veiled
 - Charging Cuts Arts, Point Style, Magnanimous Cry Form: Five-Fold Ascension Burning Limbo
 - Charging Dawn Arts, Malevolent Rocky Style, Chaotic Bloodthristy Nomad Form: Triple Quake Observing Ascension
 - Charging Destiny Arts, Aureate Riddle Style, Shadow Devil Form: Leap of the Barrier
 - Charging Dragon Arts, Cawing Mirage Icy Style, Subduing Whirling Reflection Form: Five-Fold Crane Stealing Array
 - Charging Frost Arts, Descending Ocean Style, Cardinal Consuming Ripple Form: Immortal Yang
 - Charging Gentle Coral Waltz Arts, Diving Sisi Style, Southern Skills Form: Elegance
 - Charging Resonance Arts, Healing Roving Trinity Style, Countless Battalion Form: Pure Eclipse
 - Charging Shaolin Arts, Fiendish Bloody Triangle Style, Solar Vine Form: Shattering Whip Searching Soar
 - Charging Siege Arts, Profound Mountian Style, Corrupted Spread Form: Giant Skill-Leaping Staff
 - Charging Stomp Arts, Riding Perfect Shooting Style, Protective Principles Form: Icy Deity
 - Charging Throwing Dew Arts, Immortal Virtuous Astral Style, Liberated Crush Form: Triple Tempo Aiming Winter
 - Charging Vapor Arts, Jade Mirror Style, Equine Magnanimous Distinction Form: Poisonous Unveiled Countering Needles
 - Charging Void Arts, Fiendish Canyon Style, Striking Malignant Form: Giant Soul-Sleeping Taiji
 - Charging Warmaster Arts, Shattering Big Exploding Style, Crazy Maiden Form: Five-Fold Raven Rises Transparency
 - Coastal Assaliants Arts, Chaotic Transformations Style, Onyx Sweetened Form: Sharpened of Rotation
 - Coastal Blaze Arts, Paladin Style, Felling Vibrant Form: Triple Fury Breaking Pinnacle
 - Coastal Bodhi Arts, Immortal Great Stretched Style, Vile Meridian Form: Triple Otherness Grounding Ghost
 - Coastal Deep Delights Arts, Bright Divinities Style, Corvid Pattern Form: Dual-Sun Searching Soul
 - Coastal Dividing Single Wood Arts, Cloak Style, Unrivaled Featherweight Rhythm Form: Emerald Reaction
\page

 - Coastal Dominating Scarlet Arts, Encompassing Tail Style, Illuminating Spear Form: Rotation of the Cave
 - Coastal Icy Leech Arts, Quick Subduing Burst Style, Outward Unity Form: Giant Kaleidoscope-Grounding Sweep
 - Coastal Intoxicated Blooming Weaver Arts, Grappling Frontier Style, Hellish Stab Form: Element of the Unknowable Shade
 - Coastal Massacre Arts, Devouring Divine Wheel Style, Mad Bright Yang Form: Unified Road Ascending Penetration
 - Coastal Mirror Arts, Divine Beast Style, Virtuous Great Foundation Form: Needles of Disruption
 - Coastal Scheme Arts, Imperial Pure Prism Style, Wounding Inferno Form: Feral Vedas
 - Coated Basilisk Arts, Sudden Raptor Style, Unforgiving Earthquakes Form: Giant Chariot-Slicing Truth
 - Coated Claw Arts, Apex Circle Style, Harmonious Ripple Form: Mysterious Enemy
 - Coated Continuous Luminous Underworld Arts, Chill Style, Corvid Leniency Form: Five-Fold Slayer Vispering Cultivation
 - Coated Domain Arts, Striking Capped Vitality Style, Encompassing Unity Form: Sealing Shatters
 - Coated Extinguishing Gem Bone Arts, Repelling Temple Style, Serpent Form: Red Paladin Blazing Myriads
 - Coated Form Arts, Smashing Formation Style, Fiendish Motion Form: Five-Fold Consonance Attacking Palms
 - Coated Frontier Arts, Enlightened Limbo Style, Illuminating Spear Form: Wood-Countering Hidden Sky
 - Coated Frost Arts, Weaver Style, Great Descent Form: Six Flying Qintfade
 - Coated Glow Arts, Dual Sight Style, Featherweight Feather Form: Traversing Monastery
 - Coated Great Azure Man Arts, Repelling Bird Style, Limitless Silent Form: Six Attacking Penetration
 - Coated Healing Cold Sugar Arts, Elusive Virtuous Direction Style, Iron Prestissimo Form: Golden Prism
 - Coated Kick Arts, Bronze Frost Style, Counter Form: Giant Void-Stabbing Point
 - Coated Lost Arts, Corrupted Refraction Style, Blazing Fog Form: Dual-Kaleidoscope Paralizing Ascent
 - Coated Meridian Arts, Flying Wolf Style, Jade Death Form: Six Crouching Palms
 - Coated Old Whirling Storm Arts, Stellar Spiritual Mindless Style, Rightful Kill Form: United Paralyzing Truth
 - Coated Polarm Arts, Devouring Lord Style, Mirage Instance Form: Prism of the Striking Blood
 - Coated Rebounding Move Arts, Yellow Signless Style, Extra Steps Form: Six Sleeping Beggar
 - Coated Return Arts, Eternal Style, Capped Frontier Form: Holy Thrust
 - Coated Song Arts, Center Dust Style, Extinguishing Road Form: Giant Trail-Traversing Traceless
 - Cold Charging Absolute Shura Arts, Shadow Winds Style, Rising Delights Form: Wisdom Carrying Titan
 - Cold Extinguishing Repentant Poison Arts, Exploding Limitless Technique Style, Unknowable Calm Nullification Form: Night of Spirits
 - Cold Legged Turtle Arts, Resolve Style, Radiant Archery Form: Six Resonating Assaliants
 - Cold Majestic Arts, Descent Style, Cosmic Jeweled Form: Triple Shaft Resting Slashes
 - Cold Mount Arts, Felling Destiny Style, Coral Gallant Spiritage Form: Triple Snowfall Ascending Latch
 - Cold Origin Arts, Enlightened Star Style, Judgment Form: Five-Fold Radiance Counterattacking Flame
 - Cold Shooting Rage Arts, Striking Profound Strength Style, Domain Form: Universal Rain
 - Cold Silver Spread Arts, Meditation Style, Fiery Repents Form: Scholar-Matching Exploding Leaves
 - Cold Spinning Clouds Arts, Spiraling Depth Style, Descending Prestissimo Form: Lofty of the Sky
 - Cold Throwing Rebounding Leniency Arts, Vile Spike Style, Unknowable Grip Form: Team-Stabbing Sudden Warfield
 - Cold Whip Arts, Silent Style, Devastation Form: Enlightenment Traversing Spin
 - Consecutive Grafting Forged Grip Arts, Indestructible Rightful Enlightened Style, Saving Balanced Nebula Form: Lost of Elegance
 - Consecutive Hawkstrider Arts, Crossing Destructive Facing Style, Imperial Taebaek Form: Dual-Zenith Drifting Bird
 - Consecutive Ink Arts, Roving Interference Style, Malignant Form: Six Blowing Command
 - Consecutive Mindscape Arts, Perfect Red Killer Style, Feral Raven Form: Six Dispersing Origin
\page

 - Consecutive Repentant Crystalline Stance Arts, 91 Fold Technique Style, Elemental Transparency Form: Six Biting Paradise
 - Consecutive Rock Arts, Repelling Shout Style, Traditional Scheme Form: Giant Crown-Stealing Mental
 - Consecutive Shadowless Arts, Foundational Crossing Slicing Style, Petal East Form: Emptiness
 - Consecutive Starlight Arts, Trail Style, Harmonious Disinterment Form: Hidden Jewel
 - Consecutive Stretched Arts, Finishing Turtle Style, Spirit Veil Form: Moonlit Absorption Retreating Tipsy
 - Consuming Basic Scriptures Arts, Encompassing West Style, Feral Tree Form: Five-Fold Veiled Emerging Reaper
 - Consuming Boulder Arts, Old Repentant Parallel Style, Absolute Waning Weaver Form: Hawkstrider of Cosmos
 - Consuming Daybreak Arts, Smashing Mental Style, Striking Claw Form: Six Scorching Mastery
 - Consuming Delights Arts, Golden Illuminating Astral Style, Wandering Elder Form: Strike of the Nether
 - Consuming Depth Arts, Living Tipsy Style, Void Realm Form: Dual-Opening Flying Court
 - Consuming Downward Calm Quartet Arts, Extended Chaotic Chackra Style, Corrupted Talon Form: Manipulation Gathering Spring
 - Consuming Drop Arts, Consecutive Thrust Style, Distinction Form: Dual-Cove Reflecting Earth
 - Consuming Extreme Path Arts, Dark Thundershock Style, Momentum Form: Sword of the Indestructible Origin
 - Consuming Forest Arts, Continuous Scale Style, Blood Form: Five-Fold Bind Revitalizing Breakout
 - Consuming Grounded Fish Arts, Infinite Forged Stun Style, Spiraling Substitution Form: Triple Family Tearing Otherness
 - Consuming Inferno Arts, Icy Enlightened Kings Style, Illusory Volcano Form: Spin of Taihua
 - Consuming Midsummer Balanced Cliff Arts, Elegant Stomp Style, Foxform Lunar Destruction Form: Man Grounding Madness
 - Consuming Nether Arts, Cobra Style, Righteous Energy Form: Giant Wisdom-Raining Snowfield
 - Consuming Pack Arts, Whirling Spring Style, Pyrocascade Form: Tundra
 - Consuming Quake Arts, Beam Style, Shooting Taiji Form: Tearing Clarity
 - Consuming Return Arts, Evil Finger Style, Empty Gust Form: Resonance
 - Consuming Sky Arts, Mysterious Equal Shift Style, Ladder Form: Dive Ensnaring Refraction
 - Consuming Slip Arts,  Bright Countless Style, Boxing Arhat Form: Direction of Intention
 - Consuming Suffering Arts, Quick Wave Style, Defensive Tide Form: Jade Resonance Emerging Phantom
 - Consuming Tablet Arts, Dirty Fist Style, Tearing Blaze Form: Fortress of the Destroyer
 - Consuming True Lunar Illuminated Arts, Devouring Shockwave Style, Snow Resonance Form: Five-Fold Taihua Resting Trigrams
 - Consuming Weapon Arts, Great Waxing Ladder Style, Adamantine Seaspan Form: Five-Fold Cry Transforming Precept
 - Continuous Chain Arts, Bound Style, Healing Bloody Pillar Form: Six Grounding Turtle
 - Continuous Consuming Outward Waltz Arts, Unknowable Energy Style, Feral Realm Form: Six Chopping Arrow
 - Continuous Double Blossom Arts, Capped Bloodthristy Advanced Style, Enlightened Shroud Form: Bloom Sacrificing Command
 - Continuous Elegance Arts, Mirage Fertile Leniency Style, Nothingness Form: South
 - Continuous Elemental Wounding Fleche Arts, Substitution Style, Consuming Void Wildfire Form: Dual-Bat Severing Titan
 - Continuous Emerald Gold Arts, Underworld Style, Fatal Butterfly Form: Six Tangled Battalion
 - Continuous Extinguishing Corrupted Taihua Arts, Illusory Corvid Traceless Style, Drift Form: Polarm Ensnaring Emptiness
 - Continuous Fatal Ember Arts, Wild Suppression Style, Venomous Malignant Form: Giant Scarlet-Leaping United
 - Continuous Felling Phantom Arts, Mad Blooming Plume Style, Vile Crushes Form: Nebula Observing Team
 - Continuous Malignant Arts, Yin Style, Fading Moonlit Riddle Form: Path of Flight
 - Continuous Moonlit Facing United Arts, Elegant Stunning Bright Style, Wheel Form: Giant Slip-Ensnaring Dance
 - Continuous Spectral Stellar Instance Arts, Expansive Primordial Vile Style, Remains Form: Manifestations of the Killing Bloom
 - Continuous Swan Arts, Toxic Enemies Style, Spanning Eclipse Form: Dual-Cry Shifting Crane
\page

 - Continuous Tundra Arts, Unparalleled Soft Style, Augmented Kick Form: Hunyuan-Conquering Felling Mistveil
 - Copper Exchange Arts, Charging Ripple Style, Many Spiritual Meridian Form: Frontier of the Lost
 - Copper Hidden Jewel Arts, Expansive Elements Style, Obscure Yang Form: Posture of the Birthless Cut
 - Copper Mighty Overwash Arts, Flying Wraith Style, Fading Leech Form: Dual-Beggar Retreating Nomad
 - Copper Mirage Foxform Stance Arts, Protective Nail Style, Pure Veil Form: Giant Devastation-Invigorating Shaft
 - Copper Peak Arts, Cawing Waning Chaotic Style, Fiendish Plume Form: Five-Fold Fortune Paralizing Essence
 - Copper Phoenix Arts, Fading Double Constellation Style, Treading Equal Drift Form: Demonic Toxin
 - Copper Starvation Arts, Living Marquis Style, Coral Crane Form: Scatter of Enemies
 - Copper Subduing Nape Arts, Spirit Sonic Protective Style, Rebounding Web Form: Single Bow Traveling Shout
 - Coral Calm Ash Arts, Abyssal Fleeting Advanced Style, Rebounding Great Taiji Form: Flight of the Double Shapeshifter
 - Coral Earth Arts, Equine Throwing Healing Style, Spiritual Underworld Form: Mirror Linking Temper
 - Coral Elegance Arts, Lower Bow Style, Grappling Taiji Form: Giant Echo-Rises Contemplate
 - Coral Extinguishing Endless Sand Arts, Vile Massacre Style, Traditional Mountian Form: Malignant of Legacy
 - Coral Foundational Tearing Lightweight Arts, Dark Sui Style, Invisible Obsidian Jeweled Form: Dual-Rain Vispering Legacy
 - Coral Ravenous Giant Arm Arts, Righteous Veiled Style, Blooming Self Form: Six Tearing Stretched
 - Coral Soaring Hidden Comb Arts, Tidal Cloak Style, Traceless Assault Form: Giant Spread-Fighting Destiny
 - Coral Soft Arts, Slicing Cliff Style, Jade Commander Form: Beak
 - Corrupted Current Vajrayana Arts, Encompassing Patriarch Style, Dao Form: Substitution of the Parallel Court
 - Corrupted Curse Arts, Waning Illusion Style, Descending Gate Form: Mystery Matching Shell
 - Corrupted Destructive Refraction Arts, Mysterious Flashes Style, Dual Triangle Form: Five-Fold Vedas Twisting Eagle
 - Corrupted Drain Arts, Elemental Golden Gem Style, Trinity Form: Turtle
 - Corrupted Fiery Breakout Arts, Spiritual Killing Wild Style, Ravenous Toxic Metal Form: Wraith-Gathering Devouring Bird
 - Corrupted Foundational Snake Arts, Drunken Consciousness Style, Vermillion Ape Form: Red View
 - Corrupted Goldenring Arts, Venom Style, Balanced Chain Form: Defensive Essence Fighting Mystery
 - Corrupted Invisible Augmented Cremation Arts, Icy Web Style, Lower Lake Form: Nullification of Silent
 - Corrupted Kick Arts, Current Rolling Gate Style, Ghostly Stun Form: Necrotoxin of Eagle
 - Corrupted Kindled Arts, Corvid 10 Fold Mount Style, Defensive Command Form: Gate
 - Corrupted Lower Legged Drop Arts, Profound Coated Salvation Style, Advanced Trill Form: Erupting Point
 - Corrupted Mighty Redemption Arts, Blazing Disruption Style, Double Mystery Form: Needles of the Style
 - Corrupted Pattern Arts, Body Style, Limitless Wounding Glide Form: Scholar of the Empty Sweetened
 - Corrupted Rock Arts, Whirling Rolling Fiery Style, Waxing Many Swing Form: Featherweight Tong Matching Elder
 - Corrupted Sand Arts, Crusher Style, Quell Form: Triple Chariot Taking Palm
 - Corrupted Stroke Arts, Repelling Taihua Style, Stunning Elegance Form: Swift Slicing West
 - Corrupted Vajrayana Arts, Illuminating Divinities Style, Consecutive Hoarforst Form: Triple Thread Cutting Orthodox
 - Corrupted Water Arts, Formless Direction Style, Grappling Maiden Form: Five-Fold Forms Searching Yin
 - Corvid Continuous Snow Polearm Arts, Limitless Plume Style, Corrupted Soaring Grip Form: Dual-Prajna Stealing Path
 - Corvid Devil Arts, Quick Feather Style, Moonlit Shift Form: Woods of the Coral Forms
 - Corvid Dipper Arts, Immortal Temper Style, Equal Daoist Form: Reflect of the Quick
 - Corvid Distinction Arts, Ghostly Exorcism Style, Vermillion Extra Saber Form: Onyx Disruption Feinting Scriptures
 - Corvid Elemental Unshakable Storms Arts, Infinite Possession Style, Solar Coil Form: Triple Sky Countering Fang
\page

 - Corvid Family Arts, Center Coil Style, Violent Roars Form: Parallel of the Copper Yang
 - Corvid Punch Arts, Soaring Binder Style, Immortal Butterfly Form: Foundation of the Surge
 - Corvid Snowlocked Arts, Lake Style, Double Height Form: Six Blowing Center
 - Corvid Staff Arts, Coastal Thunderclap Style, Parallel Sinister Form: Variation Descending Ladder
 - Cosmic Beast Arts, Continuous Authority Style, Universal Buddha Form: Five-Fold Sharpened Conquering Tempest
 - Cosmic Block Arts, Crystalline River Style, Unforgiving Feral Millennium Form: Dual-Transparency Going Deities
 - Cosmic Creation Arts, Shattering Dual Sky Style, Roving Plume Form: Five-Fold Crusher Counterattacking Height
 - Cosmic Dipper Arts, Dancing Poisonous Equal Style, Leap Form: Southern Consciousness Flowing Bodhidharma
 - Cosmic Fleche Arts, Mindscape Style, Hidden Snowfield Form: Unrivaled Duck
 - Cosmic Leech Arts, Grand Dividing Thunderclap Style, Extinguishing Domain Form: Six Ascending Aspects
 - Cosmic Mindless Arts, Ascending View Style, Penetrating Feather Form: Whale of the Arching Flame
 - Cosmic Sinister Arts, Petal Arching Eruption Style, Double Ghostly Star Form: Phenomena of the Lower Wing
 - Cosmic Slicing Iron Beasts Arts, Subduing Stellar Old Style, Extended Echo Form: Striking Center
 - Cosmic Storm Arts, Ghostly Jade Killer Style, Extended Triple Form: Reflect
 - Cosmic Wildfire Arts, Aspects Style, Astral Barrage Form: Ripping Arrow Piercing Vajrapani
 - Countless Ancient Coral Suffering Arts, Hellish Tremor Style, Monk Form: Primordial Angel Carrying Staff
 - Countless Blessed Equal Creation Arts, Veil Style, Grand Unshakable Leaves Form: Triple Metal Shifting Nullification
 - Countless Calm Venomous Taihua Arts, Cawing True Coral Style, Saving Foundation Form: Lord
 - Countless Cutting Triadic Arts, Righteous Vibrant Style, Pearl Form: Moonbeam
 - Countless Demonic Unknowable Slash Arts, Radiant Augmented Calm Style, Sweetened Form: Giant March-Ending Specter
 - Countless Dragontail Arts, Abyssal Deep Foundational Style, Calm Profound Hand Form: Hit of the Ethereal Instance
 - Countless Emerald Rising Daybreak Arts, Dawn Style, Spirit Tundra Form: Meditation of Domain
 - Countless Foundational North Fire Arts, Precept Style, Diving Beasts Form: Fatal Infusion
 - Countless Perfusion Arts, Killing Earthquakes Style, Traditional Endless Beak Form: Dual-Sky Controlling South
 - Countless Retribution Arts, Illusory Barrage Style, Self Form: Return of the Outward Breaker
 - Countless Sheet Arts, Destroyer Style, Extreme Leniency Form: Dual-Crows Vispering Wanderer
 - Countless Unveiled Arts, Aquatic Woodland Style, Dark Palm Form: Evil Turtle Concealing Harmony
 - Crazy Blazing Devouring Mastery Arts, Spiritual Dive Style, Ultimate Strength Form: Dual-Bird Binding Swing
 - Crazy Bloodstained Inferno Arts, Veil Style, Eclipse Form: Skills Evading Refraction
 - Crazy Crushes Arts, Timberfall Style, Blooming Talon Form: Roars-Draining Martial Pounce
 - Crazy Disciple Arts, Graceful Elemental Switch Style, Obscure Nature Form: Giant Star-Cleaving Vigor
 - Crazy Ember Arts, Crossing Traversing Giant Style, Rightful Script Form: Dual-Crash Poking Nebula
 - Crazy Grasp Arts, Harmonious Spiraling Foxform Style, Karmic Form: Fleeting Shaolin Sharpening Prayer
 - Crazy Jeweled Arts, Dividing Exchange Style, Claw Form: Illuminating Vedas Deflecting Taebaek
 - Crazy Karmic Arts, Infernal Aura Style, Coastal Thousands Form: Dao of the Mystic Nether
 - Crazy Mistveil Arts, Elegant Shooting Force Style, Bloody Arching Yang Form: Triple Avatar Leaping Piercer
 - Crazy Penetration Arts, Luminous Wandering Mental Style, Petal Beasts Form: Giant Temple-Fighting Flesh
 - Crazy Precept Arts, Dividing Firebrand Style, Big Shield Form: Buddha-Searching Empty Might
 - Crazy Reflection Arts, Taebaek Style, Abyssal Thaw Form: Heritage Revitalizing Posture
 - Crazy Snowlocked Arts, Bloodstained Tong Style, Diving Starlit Form: Gem Frontier
\page

 - Crazy Spin Arts, Parallel Beast Style, Perfect Snowlocked Form: Path Falling Dipper
 - Crazy Striking Glow Arts, Cave Style, Wandering Pierce Form: Astral Arrows Resting Discipline
 - Crazy Temple Arts, Apex Endless Thunderbolt Style, Full Assaliants Form: Song of the Rebounding Intention
 - Crazy Tidal Acala Arts, Quick Cremation Style, Whirling Otherness Form: Reguard of the Single Swing
 - Crimson Buddha Arts, Fatal Extended Strikes Style, Magnanimous Absolute Sutra Form: Dual-Lost Falling Enigma
 - Crimson Distinction Arts, Spiritual Ape Style, Traversing Surface Form: Enigma of the Vermillion Gate
 - Crimson Embracing Archery Arts, Southern Mirrored Style, Dancing Rage Form: Ash Freezing Transformations
 - Crimson Fury Arts, Extreme Shade Style, Weapon Form: Triple King Conquering Millennium
 - Crimson Heart Arts, Dividing Dominating Sharpened Style, Absolute Maiden Form: Triple Shade Resonating Rhythm
 - Crimson Long Arts, Facing Perfusion Style, Frozen Shattering Goldenring Form: Authority-Rising Abyssal Monk
 - Crimson Meridian Arts, Countless Spearplay Style, Evil Sharpened Form: Six Breaking Ladder
 - Crimson Moonlight Arts, Imperial Skills Style, Golden Barrier Form: Illusion
 - Crimson Script Arts, Luminous Noble Style, Principles Form: Realm
 - Crimson Shard Arts, Magnanimous Western Grappling Style, Unrivaled Tai Form: Pierces Commanding Phaseless
 - Crimson Stunning Crows Arts, Coastal Lightning Style, Crush Form: Mothers of the Bright Triangle
 - Crimson Thunderous Pinnacle Arts, Skills Style, Gallant Repentant Shield Form: Flow
 - Crimson Thunderwake Arts, Spectral Spirits Style, Gust Form: Change of the Grafting Trial
 - Crimson Vampire Arts, Few Foundation Style, Fiery Drift Form: Merciful Noble
 - Crossing Bat Arts, Cawing Stellar Charging Style, Fading Smashing Ember Form: Triple Jewel Draining Eclipse
 - Crossing Bloodthristy Unity Arts, Fiery Iron Venomous Style, Coastal Sui Form: Needle of Jeweled
 - Crossing Coral Merciful Infusion Arts, Saving Reaction Style, Celestial Dark Scripture Form: Pack Vispering Horse
 - Crossing Energy Arts, Descending Scriptures Style, Beam Form: Triple Path Poking Taebaek
 - Crossing Featherweight Pearl Arts, Daoist Style, Perfect Shadowless Form: Triple Dust Chopping Shapeshifter
 - Crossing Nomad Arts, Luminous Surface Style, Great Heaven Form: Forest-Flowing Boxing Might
 - Crossing Prestissimo Arts, Bloodthristy Polarm Style, Unmatched Rhythm Form: Soar Airsplitting Circulation
 - Crossing Pure Transparency Arts, Grand Hellish Cloak Style, Saving Tablet Form: Six Commanding Shift
 - Crossing Root Arts, Rising Vigor Style, Legged Ink Form: Giant Resolve-Ending Gust
 - Crossing Sheet Arts, Unparalleled Haunt Style, Calm Yang Form: Goldsaber of the Nail
 - Crossing Smashing Gentle Commander Arts, Invisible Graceful Vairocana Style, Vermillion Bind Form: Six Conquering Crusher
 - Crossing Treading Sufferings Arts, Moon Style, Spinning Taibai Form: Invisible Harvest
 - Crystalline Emerald Dark Bow Arts, Legged Sonic Poisons Style, Subduing West Form: North Enigma Slicing South
 - Crystalline Extinguishing Northern Meridian Arts, Unshakable Dominating Parallel Style, Stellar Ape Form: Giant Duck-Reflecting Nail
 - Crystalline Lunar Shooting Rhythm Arts, Ravenous Web Style, Jade Suppression Form: Five-Fold Style Emerging Resolve
 - Crystalline Misty Arts, Rotation Style, Grand Enemy Form: Endless Sanctum
 - Crystalline Moonbeam Arts, Demonic Infusion Style, Mighty Bird Form: Dual-Thaw Breaking Grasp
 - Crystalline Obscure Tail Arts, Liberated Thirst Style, Facing Dao Form: Quartet Dispersing Commander
 - Crystalline Polarm Arts, Big Countless Unmatched Style, Aquatic Diving Trap Form: Shroud Resonating Pearl
 - Crystalline Serene Foundational Hands Arts, Karmic Style, Riding Volley Form: Contemplate Crouching Ladder
 - Crystalline Traceless Ultimate Heart Arts, Apex Lotus Style, Fish Form: Stalwart Carrying Swords
 - Crystalline Unknowable Living Maiden Arts, Extreme Proud Style, Grafting Commander Form: Triple Tranquil Linking Things
\page

 - Crystalline Vedas Arts, Boundless Single Sui Style, Evil Phantom Form: Dance of the Delights
 - Crystalline Zen Arts, Skeletal Temple Style, Bloodthristy Flow Form: Hit-Searching Wounding Scarlet
 - Current Aureate Shift Arts, Hand Style, Cawing Ladder Form: Tongue Resonating Crown
 - Current Blessed Incineration Arts, Dancing Chin Style, Venomous Cutting Gate Form: 93rd Phaseless
 - Current Breaker Arts, Bright Profound Cold Style, Blessing Form: Hell
 - Current Chop Arts, Augmented Obscure Advanced Style, Enlightened Primordial Grip Form: Windrider-Weakening Descending Transparency
 - Current Devil Arts, Boxing Thread Style, Traditional Karma Form: Aquatic Thirst Defending Technique
 - Current Fox Arts, Full Spiraling Obsidian Style, Crystalline Archery Form: Shatters Resisting Harmonies
 - Current Jade Defensive Cave Arts, Foundational Finger Style, Evil Book Form: Hawk of the Dipper
 - Current Mist Arts, Torment Style, Aureate Pearlflower Form: Dual-Wing Slicing Interference
 - Current Paladin Arts, Slicing Pear Style, Merciful Assaliants Form: Refraction of Warfield
 - Current Quick Gem Waltz Arts, Shadow Infinite Path Style, Bloody Destruction Form: Spanning Skull
 - Current Righteous Perfect Protector Arts, Single Punch Style, Imperial Disciple Form: Cut Traversing Talon
 - Current Throwing Unveiled Arts, Imperial Total Style, Full Swarm Form: Triple Spin Concealing Sugar
 - Current Trap Arts, Drunken Tearing Unshakable Style, North United Form: Circle Traveling Talon
 - Current Unshakable Curse Arts, Assault Style, Poisonous Tipsy Form: Immovable-Shattering Gentle Arrows
 - Current Wicked Misty Arts, Repelling Pillar Style, Fleeting Opposition Form: Veiled
 - Cursed Center Mountian Arts, Charging Plume Style, Devastating Cosmic Stun Form: Skills Invigorating Grove
 - Cursed Commander Arts, Gentle Brook Style, Cascade Form: Trigrams of the Shroud
 - Cursed Grip Arts, Metallic Bloody Soul Style, Moon Form: Dual-Ruin Counterattacking Counter
 - Cursed Haunt Arts, Waxing Trial Style, Destruction Form: Comb of the Riding Storm
 - Cursed Illusion Arts, Bloody Exploding Western Style, Skeletal Vile Basilisk Form: Scholar-Ascending Graceful Edge
 - Cursed Legged Lofty Arts, Repelling Grounded Augmented Style, Shapeshifter Form: Six Going Fate
 - Cursed Nether Arts, Cutting Way Style, Dividing Brush Form: Arm Shaking Sharpened
 - Cursed Realm Arts, Formless Goldenring Style, Stunning Consonance Form: Essence of Center
 - Cursed Starvation Arts, Forged Devastation Style, Sonata Form: Six Leaping Reflection
 - Cursed Steel Arts, Prelude Style, Many Dividing Daoist Form: Leap-Confronting Splitting Crusher
 - Cursed Warriors Arts, Defensive Inferno Style, Rebounding Mastery Form: Violent Life
 - Cutting Augmented Battalion Arts, Ravenous Ascending Rolling Style, Rightful Lofty Form: Five-Fold Cloak Stabbing Explosion
 - Cutting Bloodthristy Kick Arts, Gold Style, Extinguishing Mount Form: Dual-Nape Controlling Pattern
 - Cutting Blooming Self Arts, Bloodthristy Array Style, Enlightened Rising Refraction Form: Wandering Fist
 - Cutting Destruction Arts, Blazing Fox Style, Limitless Hell Form: Triple Mastery Observing Polar
 - Cutting Diving Feather Arts, Abyssal Unrestrained Style, Unrivaled Waters Form: Shadowless of the Skills
 - Cutting Formation Arts, Seeds Style, Blessed Slayer Form: Six Bowing Wisdom
 - Cutting Frontier Arts, Penetrating Ape Style, Celestial North Form: Heavenly Omnidirectional Falling Warmaster
 - Cutting Gateways Arts, Embrace Style, Vapor Form: Decree-Sleeping Gentle Bound
 - Cutting Goldenring Arts, Mirage Butterfly Style, Boundless Triple Form: Six Bowing Height
 - Cutting Hidden Corvid Thaw Arts, Harmonious Extreme Myriads Style, 26 Fold Ghost Form: Windrider of the Ghostly Veil
 - Cutting Infusion Arts, Redemption Style, Noble Form: Marquis of the Ripping Tempest
 - Cutting Lofty Arts, Emerald Neck Style, Charging Crows Form: Dual-Fall Revitalizing Chop
\page

 - Cutting Man Arts, Obsidian Scarlet Style, Extreme Violent Zenith Form: Royal of Crushes
 - Cutting Might Arts, Blooming Path Style, Serene Sound Form: Six Crushing Life
 - Cutting Poisonous Traceless Trail Arts, Song Style, Grafting Script Form: Five-Fold Intention Swirling Ascension
 - Cutting Posture Arts, Pounce Style, Water Form: Dual-Opposition Confronting Leap
 - Cutting Slip Arts, Ethereal Zenith Style, Lower Elegant Zen Form: Authority-Traveling Spectral Skills
 - Cutting Spin Arts, Gem Reaper Style, Righteous Palms Form: Motion of Touch
 - Cutting Staff Arts, Thunderous Elegant Wicked Style, Universal Chin Form: Facing Tea Bowing Kindled
 - Cutting Sweetened Arts, Burst Style, Mad Crushes Form: Giant Hawk-Falling Fire
 - Cutting Viper Arts, Dual Traceless Style, Space Form: Triple Brook Vispering Team
 - Dancing Ape Arts, Ethereal Ravenous Polearm Style, Wounding Devastation Form: Sonata
 - Dancing Breeze Arts, Variation Style, Heavenly King Form: Rapid of the Suffering
 - Dancing Coastal Bird Arts, Eternal Staff Style, Cardinal Living Harmony Form: Fall of the Southern Song
 - Dancing Embracing Leaf Arts, Spinning Sinister Style, North Strength Form: Waning Domain Traveling Trap
 - Dancing Endless Dominating Phenomena Arts, Subduing Thunderbolts Style, Sacred Scriptures Form: Crane of the Tong
 - Dancing Fertile Merciful Consciousness Arts, Eternal Wrath Style, Full Form Form: Killer of the Nefarious Madness
 - Dancing Ice Arts, Charging Leaves Style, Grand Zen Form: Snakeform of the Self
 - Dancing Legacy Arts, Governing Cosmic Gallant Style, Skeletal Sheet Form: Giant Sword-Breaking Pyrocascade
 - Dancing Thunderous Opening Arts, Bloodthristy Poisonous Roving Style, Sonic Flames Form: Gateways Following Emptiness
 - Dancing Thundershock Arts, Cut Style, Lower Windrider Form: Fall
 - Dancing Venomous Nomad Arts, Western Mobility Style, Invisible Basilisk Form: Triple Shadowy Shaking Starvation
 - Dancing Water Arts, Rising Liberated Snowfall Style,  Single Mothers Form: Swarm
 - Dancing Whirling Thunderous Vairocana Arts, Ripping Punch Style, Expansive Scripture Form: Elbow of the Venom
 - Dark Astral March Arts, Deep Boxing Aegis Style, Aquatic Chill Form: Distinction of the Refraction
 - Dark Cyclone Arts, Petal Treading Sect Style, Spiritage Form: Deity of the Starlit
 - Dark Direction Arts, Feral Grounded Advanced Style, Yellow Hawkstrider Form: Foundation of Shell
 - Dark Energy Arts, Dominating Moonbeam Style, Flight Form: Breakthrough Coiling Shift
 - Dark Fleeting Imperial Verdant Arts, Spinning Fairy Style, Elemental Plume Form: Fiery Crane
 - Dark Foxform Consciousness Arts, True Elegance Style, Absolute Spirits Form: Plague of Trigrams
 - Dark Full Outward Galaxy Arts, Unknowable Emerald Goldsaber Style, Shattering Pierce Form: Triple Army Stealing Trio
 - Dark Gallant Pyrocascade Arts, Unshakable Counter Style, Fading White Trill Form: Dual-Raptor Airsplitting Quanzhen
 - Dark Lord Arts, Subduing Polarm Style, Formless Momentum Form: Five-Fold Array Binding Water
 - Dark Radiant Eternal Star Arts, Sudden Tearing Ravenous Style, Body Form: Hexablaze of Shatters
 - Dark Rage Arts, Burst Style, Empty Nothingness Form: Triple Harmonies Resting Nullification
 - Dark Root Arts, Obscure Spring Style, Single Blooming Ascent Form: Five-Fold Thousands Revitalizing Warrior
 - Dark Tearing Might Arts, Slashes Style, Enlightenment Form: Shadowy of the Shadowless
 - Dark Thousand Arts, Fading Verdant Style, Imperial Sheet Form: Five-Fold Nomad Poking Enigma
 - Dark Vampire Arts, Flying Shadow Capped Style, Deep Tipsy Form: Death Draining Marquis
 - Dark Virtuous Canyon Arts, Old Crossing Equal Style, Aureate Flesh Form: Five-Fold Step Ending Leaves
 - Dark Weaver Arts, Riding Void Style, Wounding Martyr Form: Six Linking Limbo
 - Dark Wisdom Arts, Devastating Consecutive Outward Style, Repelling Specter Form: Five-Fold Flames Soaring Nature
\page

 - Deep Authority Arts, Southern Unshakable Dao Style, Leaves Form: Adaptive Chackra Aiming Embrace
 - Deep Crimson Timberfall Arts, Chaotic Grappling Grafting Style, Rotation Form: Wrath of the Dual Asterism
 - Deep Profound Unknowable Noble Arts, Roving Elbow Style, Emerald Toil Form: Six Airsplitting Beast
 - Deep Rocky Arts, Cutting Arrow Style, Destructive Triple Form: Temper of Basilisk
 - Deep Slashes Arts, Infinite Reaction Style, Astral North Form: Cross of the Basic Palm
 - Deep Southern Lightness Arts, Giant Hidden Flames Style, Mental Form: Five-Fold Elements Soaring Traceless
 - Deep Unshakable Splitting Dragontail Arts, Few True Shout Style, Exploding Pines Form: View of Trident
 - Deep Weaver Arts, Waning Cliff Style, Bloodthristy Universal Quick Form: Elder of the Coated Fiend
 - Defensive Chain Arts, Grounded Butterfly Style, Finishing Poison Form: Dual-Enemy Soaring Lord
 - Defensive Demonic Sacred Formation Arts, Height Style, Feral Silent Form: Dominating Nothingness
 - Defensive Dragon Arts, Shadow Harmonies Style, Dipper Form: Boundless Kaleidoscope Taking Latch
 - Defensive Leaf Arts, Venomous Court Style, Old Deep South Form: Six Draining Form
 - Defensive Method Arts, Grafting North Style, Elegance Form: Shout Binding King
 - Defensive Myriads Arts, Graceful North Gem Style, Gallant Shaft Form: Warmth
 - Defensive Pearl Arts, Icy Taihua Style, Hell Form: Five-Fold Web Revitalizing Intention
 - Defensive Pinnacle Arts, Ultimate Violent Salvation Style, Forged Flashes Form: Death of the Fox
 - Defensive Repents Arts, Paradise Style, Karma Form: Giant Saint-Searching Shockwave
 - Defensive Ripping Wolf Arts, Infernal Augmented Blade Style, Man Form: Prajna of Triple
 - Defensive Roar Arts, Few Wisdom Style, Brilliant Sanctum Form: Rebounding Pine Linking Otherness
 - Defensive Scale Arts, Yellow Reflect Style, Tong Form: Dawn of the Corvid Intent
 - Defensive Shaolin Arts, Emerald Firebrand Style, Dao Form: Giant Path-Carrying Flow
 - Defensive Warrior Arts, Frozen Binder Style, Spirit Shard Form: Bound of the Onyx Rectitude
 - Defensive West Arts, Spread Style, Stunning Karma Form: Height
 - Demonic Bolt Arts, Solar Spread Style, Pear Form: Punch of Spearplay
 - Demonic Deflection Arts, Legged Cosmic Starlight Style, Soaring Maiden Form: Plume of Thunder
 - Demonic Element Arts, Cutting Heritage Style, Astral Parallel Karmic Form: Cardinal Order
 - Demonic Exchange Arts, Elusive Warmth Style, Immovable Form: Variation of Shout
 - Demonic Footstep Arts, Crimson North Lance Style, Forged Primordial Fortune Form: Five-Fold Dragon Paralyzing Warfield
 - Demonic Hit Arts, Full Coated Ultimate Style, Nefarious Hellfire Form: Six Airsplitting Reflection
 - Demonic Illuminated Arts, Obsidian Waves Style, Spanning Radiant Tide Form: Rapid of the Gem Skill
 - Demonic Illuminating Pines Arts, Vile Maiden Style, Foundational Crimson Sugar Form: Sight Stealing Leaves
 - Demonic Kaleidoscope Arts, Sweeping Pinnacle Style, Birthless Stone Form: Depth Summoning Kings
 - Demonic Kindled Arts, Stellar Empty Nineteens Style, Throwing Tail Form: Soft of the Barrage
 - Demonic Madness Arts, Stun Style, Foundation Form: Elbow of the Assimilation
 - Demonic Onyx Primordial Daybreak Arts, Cosmic Full Augmented Style, Cuts Form: Earthquakes of the Coral Frost
 - Demonic Phoenix Arts, Cosmic Warriors Style, Blazing Crimson Fall Form: Five-Fold Self Following Sutra
 - Demonic Possession Arts, Crows Style, Devouring Fortune Form: Pyrocascade of the Split
 - Demonic Signless Arts, Sonata Style, Shadow Many Tablet Form: Thoughtless Enduring Hit
 - Demonic Talon Arts, Emptiness Style, Hell Form: Dual-Glow Severing North
 - Demonic Thunderous Sealing Whale Arts, Condor Style, Parallel Shura Form: Grace Aiming Pierces
\page

 - Demonic Unrivaled Taiji Arts, Frozen Coated Roar Style, Obscure Void Surge Form: Giant Bodhidharma-Flowing Turtleback
 - Demonic Web Arts, Venomous Dividing Charging Style, Shooting Obsidian Lake Form: Walk of the Ocean
 - Demonic Western Unmatched Waterfall Arts, Unforgiving Equal Sisi Style, Fiery Range Form: Trigrams Stealing Sections
 - Descending Ascending Soaring Assault Arts, Wisdom Style, Advanced Stretched Form: Sect of the Yellow Chin
 - Descending Assaliants Arts, Ethereal Signless Style, Phoenix Form: Tempest of the Wounding Form
 - Descending Blaze Arts, Flames Style, Mystic Unity Form: Consonance-Conquering Continuous Destroyer
 - Descending Dirty Incineration Arts, Thousand Style, Quick Basilisk Form: Substitution-Poking Roving Stealth
 - Descending Dust Arts, Enlightened Buddha Style, Grounded Intention Form: Dual-Legacy Lunging Blister
 - Descending Elusive Battle Arts, Few Force Style, Ascending Spring Form: Cage-Invigorating Chaotic Calamity
 - Descending Exploding Cardinal Crusher Arts, Distinction Style, Pure Ascending Gate Form: Six Flowing Surge
 - Descending Gem Nullification Arts, Woodland Style, Aureate Frontier Form: Paradise of the Featherweight Light
 - Descending Ghostly Zen Arts, Ancient Chain Style, Embracing Poisonous Severance Form: Polarm of the Rebounding Specter
 - Descending Glow Arts, Smashing Plate Style, Extra Splitting Fish Form: Unparalleled Vairocana
 - Descending Judgment Arts, Astral Boulder Style, Many Whip Form: Parallel Bite
 - Descending Radiant Throwing Stalwart Arts, Empty East Style, Invisible Many Cave Form: Battlefield of the Final Disciple
 - Descending Serpent Arts, Vedas Style, Downward Cultivation Form: Five-Fold Descent Flaming Sanctity
 - Descending Stalwart Arts, Sonic Fate Style, Extended Trill Form: Five-Fold Legs Ending Army
 - Descending Steps Arts, Dirty Arching Waning Style, Wicked Breeze Form: Poisons Traversing Curse
 - Descending Storms Arts, Bloody Gate Style, Fairy Form: Triple Hunyuan Transforming Frenzy
 - Descending Wing Arts, Buddhist Sugar Style, Unforgiving Governing Mobility Form: Spinning Path
 - Destructive Acala Arts, Boundless Radiant Vedas Style, Coated Stone Form: Scholar-Traveling Graceful Consonance
 - Destructive Arm Arts, Emerald Tipsy Style, Spiritual Unshakable Walk Form: Crusher-Slicing Cawing Mind
 - Destructive Condor Arts, Jade Pattern Style, Emerald Rolling Crushes Form: Kings of the Consuming West
 - Destructive Drunken Traceless Arts, Vermillion Forest Style, Vile Coral Self Form: Six Rising Space
 - Destructive Finishing Shattering Dawn Arts, Repentant Devastating Stunning Style, Buddha Form: Parallel Karmic
 - Destructive Gallant Staff Arts, Valley Style, Fertile Circle Form: Chackra Sacrificing Warrior
 - Destructive Grace Arts, Taming Style, Full Chackra Form: Five-Fold Flow Gathering Ripple
 - Destructive Lost Arts, Equal Snow Eagle Style, Icy Virtuous Defiers Form: Battlefield of the Spinning Scarlet
 - Destructive Mindless Arts, Nefarious Striking Mystic Style, Boundless Thousand Form: Six Scorching Way
 - Destructive Saint Arts, Extended Sheet Style, Foundational Constellation Form: Commander of Shockwave
 - Destructive Soul Arts, Advanced Intoxicated Chariot Style, Immortal Hail Form: Waves of the Nullification
 - Destructive Spiraling Balanced Manifestation Arts, Living Sharpened Style, Annihilation Form: Dual-Void Biting Kings
 - Destructive Spiritage Arts, Vermillion Midsummer Sea Style, Roving Deity Form: Riding Breakthrough
 - Destructive True Mental Arts, Corvid Countless Center Style, Birthless Hoarforst Form: Giant Retribution-Grounding Fairy
 - Devastating Embracing Abyssal Elements Arts, Sudden Burning Stun Style, Posture Form: Bodhidharma of Polar
 - Devastating Enemies Arts, Infinite Road Style, Blooming Wisdom Form: Origin of the Crimson Weaver
 - Devastating Lance Arts, Salvation Style, Felling Saint Form: Coil of Wanderer
 - Devastating Pack Arts, Winter Style,  Dawn Form: Breakthrough-Cutting Continuous Enemies
 - Devastating Responsive Chop Arts, Grand Warmaster Style, Coastal Glacial Toxin Form: Immovable of the Illuminating Leech
 - Devastating Single Basic Crows Arts, Nomad Style, Sealing Opposition Form: Dual-Demon Controlling Spirits
\page

 - Devastating Violent Cyclone Arts, Touch Style, Spanning Hellish Bat Form: Prestissimo of the Blood
 - Devastating Western Luminous Reflection Arts, Few Gate Style, Fading Monkey Form: Stroke of Tong
 - Devouring Current Arching Blaze Arts, Otherness Style, Poisonous Extended Myriads Form: Triple Circulation Summoning Shade
 - Devouring Daybreak Arts, Northern Spirit Spinning Style, Tearing Heavenly Raptor Form: Icy Sky
 - Devouring Discipline Arts, Expansive Governing Tablet Style, March Form: Triple Unveiled Gathering Sweetened
 - Devouring Earthly Frozen Lotus Arts, Foxform Sui Style, Basic Beast Form: Vajrapani-Descending Shooting Specter
 - Devouring Eternal Erupting Aspects Arts, Hellish Spiral Style, Jade Reaper Form: Dual-Roars Airsplitting Daybreak
 - Devouring Feral Form Arts, Elemental Unshakable Single Style, Stunning Snakeform Form: Wraith-Counterattacking Hidden Contemplate
 - Devouring Flame Arts, Obscure Rebounding Bright Style, Graceful Sudden Pulse Form: Giant Dawn-Ensnaring Eternal
 - Devouring Gallant Vermillion Thousand Arts, Wounding Unbounded Style, Many Stomp Form: Triple Nullification Paralizing Spear
 - Devouring Granite Arts, Cutting Wisdom Style, Equine Fiery Temper Form: Dust of the Illusory Stride
 - Devouring Mirrored Arts, Eagle Style, Dirty Way Form: Zenith
 - Devouring Myriads Arts, Mystic Paradise Style, Kindled Form: Five-Fold Soul Searching Energy
 - Devouring Otherness Arts, Outward Shooting Basic Style, Sudden Crane Form: Way-Flaming Wandering Firebrand
 - Devouring Parallel Arts, Spiraling Equal Cobra Style, Grand Destroyer Form: Magnanimous Tremor Chopping Battlefield
 - Devouring Pinnacle Arts, Advanced Holy Balance Style, Ripping Kick Form: Kundali of Opposition
 - Devouring Quake Arts, North Magnanimous Mysterious Style, Charging Whip Form: Motion of the Drunken Wrath
 - Devouring Rebounding Mountain Arts, Ghostly Trial Style, Charging Dark Weaver Form: Ridge of the Cosmic Shroud
 - Devouring Ripping Thread Arts, Soaring Vajrayana Style, Iron Rotation Form: Pearlflower-Following Finishing Heaven
 - Devouring Scripture Arts, Spirit Divine Extreme Style, Embracing Tree Form: Direction of the Maiden
 - Devouring Stab Arts, Poisonous Brook Style, Quick True Sound Form: Drop of the Rolling Timberfall
 - Devouring Talon Arts, Icy Avatar Style, Extended Sylvan Form: Giant Wraith-Matching Crush
 - Devouring Thunder Arts, Sudden Things Style, Unforgiving Chariot Form: Grafting Pulse
 - Devouring Toxic Ripping Earth Arts, Few Palm Style, Finishing Gust Form: Giant Rapid-Airsplitting Tong
 - Devouring Traditional Tearing Crusher Arts, Final Vajrapani Style, Fatal Vine Form: Sanctity of Mystery
 - Devouring Unshakable Dirty Strikes Arts, North Felling Ember Style, Punch Form: Triple Way Shattering Bound
 - Dirty Ancient Stance Arts, Boundless Dance Style, Hellish Southern Stab Form: Serpent
 - Dirty Arrow Arts, Fiendish Toxic Cultivation Style, Rebounding Web Form: Dual-Stalwart Scorching Tong
 - Dirty Charging Embracing Cuts Arts, Kings Style, Cursed Ursine Form: Arrow-Observing Rebounding Fang
 - Dirty Cry Arts, Warmth Style, Lower Depth Form: Suppression of the Space
 - Dirty Deflection Arts, Adaptive Countless Deep Style, South Form: Constellation
 - Dirty Enlightened Aspects Arts, Embracing Tang Style, Solar Echo Form: Five-Fold Binder Summoning Intention
 - Dirty Grand Iron Shockwave Arts, Throwing Defensive Abyssal Style, Giant Extended Enigma Form: Dance Tangled Might
 - Dirty Indestructible Fading Sections Arts, Polar Style, Dipper Form: Command-Retreating Violent Basilisk
 - Dirty Kindled Arts, Felling Horse Style, Unmatched Remains Form: Five-Fold Gust Rising Lotus
 - Dirty Magnanimous Weaver Arts, Final Shattering Boulder Style, Waxing Waltz Form: Destroyer of the Cutting Neck
 - Dirty Repentant Calm Tortoise Arts, Distinction Style, Waxing Volley Form: Giant Flow-Invigorating Trigrams
 - Dirty Shower Arts, Heartless Frostbite Style, Kill Form: Spirits-Breaking Universal Mist
 - Dirty Warmth Arts, Waning Daoist Style, Mad Dividing Style Form: Dual-Weapon Aiming Emperor
 - Dividing Burning Whirling Starvation Arts, Bloodthristy Governing Felling Style, Solar Obscure Bird Form: Drain-Crouching Rebounding Hands
\page

 - Dividing Echo Arts, Waxing Spike Style, Piercer Form: Flow of Patriarch
 - Dividing Encompassing Waning Peak Arts, Cutting Lance Style, Single Coral Aura Form: Leech of the Spinning Wraith
 - Dividing Hell Arts, Spectral Crystalline Tranquil Style, North Surface Form: Giant Hand-Freezing Rectitude
 - Dividing Hidden Soaring Mountian Arts, Righteous Fury Style, Repents Form: Six Paralizing Fortress
 - Dividing Killer Arts, Hidden Remains Style, Enlightened Veiled Form: Advent of the Flower
 - Dividing Phaseless Arts, Augmented Tempo Style, Snow Manifestation Form: Dual-Cross Paralyzing Kick
 - Dividing Raven Arts, Void Salvation Style, Formless Disinterment Form: Emptiness Gathering Darkwind
 - Dividing Riding Reguard Arts, Metallic Feral Skill Style, Extinguishing Pure Technique Form: Primordial Assaliants Traversing Patriarch
 - Dividing Rocky Arts, Spinning Arrow Style, Gem Enemies Form: Encompassing Galaxy Binding Tongue
 - Dividing Silver Snowlocked Arts, Vile Instance Style, Embracing Raptor Form: Zenith Countering Shapeshifter
 - Dividing Warriors Arts, Beast Style, True Burning Traceless Form: Tongue-Resisting Eternal Wheel
 - Dividing Windrider Arts, Absolute Bloom Style, Healing Night Form: Scriptures
 - Divine Blossom Arts, Sufferings Style, Quick Mirror Form: Sage of the Cultivation
 - Divine Direction Arts, Charging Deep Gentle Style, Azure Astral Fang Form: Five-Fold Beast Airsplitting Illusion
 - Divine Disruption Arts, Consecutive Cultivation Style, Shooting Noble Form: Cosmos Fighting Serpent
 - Divine Moonbeam Arts, Rebounding Luminous Bright Style, Lord Form: Basic God
 - Divine Origin Arts, Radiant Harmonious Basic Style, Eastern Trill Form: Five-Fold Comb Sacrificing Net
 - Divine Outward Fiend Arts, Dancing Throwing Ghost Style, Fiery Equal North Form: Dual-Eternal Grounding Switch
 - Divine Scholar Arts, Radiant 20 Fold Coated Style, Perfect Kundali Form: Unity-Traveling Calm Tail
 - Divine Unified Way Arts, Lost Style, Holy Wraith Form: Phaseless-Counterattacking Unforgiving Death
 - Divine Whip Arts, Riddle Style, Gallant Qintfade Form: Form of the Phaseless
 - Diving Aquatic Gold Arts, Obsidian Stalwart Style, Profound Reflection Form: Five-Fold Fortune Falling Crows
 - Diving Army Arts, Drowned Style, Edge Form: Five-Fold Pulse Rises Center
 - Diving Bodhi Arts, Dividing Tang Style, Penetrating Turtle Form: Crossing Fox
 - Diving Circle Arts, Fatal Fiendish Swarm Style, Sonic Shroud Form: Coated Swords Crushing Jeweled
 - Diving Domination Arts, Variation Style, Holy Legs Form: Starlight of Toxin
 - Diving Earth Arts, Deep Dark Toxin Style, Spirit Fist Form: Spear of the Great Coil
 - Diving Edge Arts, Devouring Circulation Style, Charging Dao Form: Sharpened of the Stalwart
 - Diving Feather Arts, Eternal Ancient Ghostly Style, Golden Tigers Form: Serene Ripple Ending Scale
 - Diving Raven Arts, Exploding Cutter Style, Switch Form: Triple Glow Confronting Strikes
 - Diving Snow Venomous Force Arts, Trident Style, Tidal Illusory Posture Form: Giant Timberfall-Countering Range
 - Diving Tablet Arts, Enlightened Stream Style, Capped Veiled Form: Giant Cultivation-Rising Haunt
 - Diving Whip Arts, Descending Infiltration Style, Primordial Marquis Form: Triple Mist Raining Mountainous
 - Diving Winds Arts, Cursed Outward Mobility Style, Blooming Slicing Slayer Form: Five-Fold Reaction Going Starlight
 - Dominating Arching South Arts, Unified Hand Style, Basilisk Form: Dual-Thousand Rising Dragontail
 - Dominating Circulation Arts, Dirty Breeze Style, Leaf Form: Giant Comb-Searching Sheet
 - Dominating Fairy Arts, Expansive Ascending Waning Style, Divine Valley Form: Destructive Trap Invigorating Master
 - Dominating Flame Arts, Responsive Veiled Style, Astral Hidden Thunderclap Form: Reaper
 - Dominating Karma Arts, Mighty Saving Elder Style, Midsummer Toxic Sections Form: Unforgiving Storm Feinting Halo
 - Dominating March Arts, Wicked Monkey Style, Riding Claw Form: Giant Pearlflower-Blazing Trigrams
\page

 - Dominating Mystery Arts, Frostbite Style, Skeletal Cobra Form: Mirror of the Wandering Seaspan
 - Dominating Origin Arts, Cursed Thunderous North Style, Elegant Stellar Brush Form: Bow of the Stab
 - Dominating Polarm Arts, Fatal Solar Fiendish Style, Ripping Authority Form: Featherweight Marquis
 - Dominating Prestissimo Arts, Seeds Style, United Form: Triple Battalion Soothing Aegis
 - Dominating Pure Sutra Arts, Erupting Obsidian Riding Style, Righteous Invisible Pounce Form: Staff
 - Dominating Spiraling Frost Arts, Wicked Shroud Style, Repentant Frozen Sound Form: Neck of the Beasts
 - Dominating Storms Arts, Onyx Trap Style, Shattering Traversing Bear Form: Thunder Resonating Phenomena
 - Dominating Unified Suffering Arts, Void Style, Mind Form: Dual-Gate Lunging Cobra
 - Dominating Unparalleled Corvid Dance Arts, Consuming Primordial Stunning Style, Repentant Rebounding Leech Form: Viper
 - Double Cyclone Arts, Return Style, Motion Form: Buddha-Binding Roving Origin
 - Double Cyclone Arts, Skull Style, Unified Noble Form: Sweeping Sugar
 - Double Fang Arts, Divine Spanning Pearl Style, Arching Shaolin Form: Pyrocascade of Pearlflower
 - Double Fiery Spirits Arts, Drunken Reaper Style, Fertile Cosmic Chain Form: Dao Confronting Zen
 - Double Final Wave Arts, Imperial Snowfall Style, Violent Bite Form: Spin
 - Double Flesh Arts, Quick Defensive Bat Style, Foundational Ethereal Essence Form: Blessing of Deity
 - Double Hidden Sylvan Arts, Rising Emptiness Style, Outward Hell Form: Massacre
 - Double Pack Arts, Felling Pines Style, Hellish Luminous Crow Form: Archery-Summoning Lower Polar
 - Double Sealing Thoughtless Arts, Frozen Lunar God Style, Deep Veiled Form: Silent-Piercing Extra Contemplate
 - Double Southern Harmonious Otherness Arts, Taebaek Style, Full Disciple Form: Five-Fold Tea Walking Sisi
 - Double Sugar Arts, Fleeting Direction Style, Deities Form: Gale of the Statue
 - Downward Balanced Kick Arts, Wandering Paladin Style, Luminous Grace Form: Yin of the Chaotic Sugar
 - Downward Big Gate Arts, Unparalleled Embrace Style, Bloody Tree Form: Sui-Descending Legged Sugar
 - Downward Bodhi Arts, Malevolent Blossoms Style, Surface Form: Repents
 - Downward Cloud Arts, Crows Style, Single Titan Form: Temper of the Many Needle
 - Downward Cloud Arts, Shooting Pounce Style, Center Enlightened East Form: Dual-Nature Lunging Scholar
 - Downward Consecutive Sevens Life Arts, Stream Style, Fury Form: Polarm
 - Downward Crane Arts, Harmonious Azure Domain Style, Consuming Spear Form: Dual-Trill Retreating Frenzy
 - Downward Cross Arts, Spirit Sealing Arhat Style, Penetrating Palms Form: Master Crouching Execution
 - Downward Cutting Abyssal Scripture Arts, Divine Destroyer Style, Sufferings Form: Things
 - Downward Form Arts, Sinister Style, Repelling Charge Form: Cavern-Vispering Secret Metal
 - Downward Onyx Harmony Arts, Sea Style, Triadic Form: Cultivation
 - Downward Perfect Horse Arts, Elegant Virtuous Sweeping Style, Constellation Form: Harmonies of the Limitless Thread
 - Downward Possession Arts, Wandering Rage Style, Immortal Snow Precept Form: Triple Emptiness Gathering Spear
 - Downward Stretched Arts, Petal Counter Style, Ghostly Wanderer Form: Coil Rises Touch
 - Downward Tong Arts, Ascending Punch Style, Daybreak Form: Five-Fold Proud Flaming Mirrored
 - Downward Unrivaled Skill Arts, Boundless Beast Style, Cultivation Form: Variation of the White Possession
 - Drunken Cage Arts, Protective Malevolent Snow Style, Endless Center Form: Five-Fold Web Draining Ocean
 - Drunken Cobra Arts, Imperial Swords Style, Coral Harvest Form: Karma of the Harmonious Range
 - Drunken Daybreak Arts, Absolute Gorge Style, Mysterious Omnidirectional Form: Illuminated of Fall
 - Drunken Frozen Diving Duck Arts, Crossing Things Style, Jewel Form: Style of the Quartet
\page

 - Drunken Hawk Arts, Cold Great Stunning Style, Hunyuan Form: Giant Possession-Raining Martyr
 - Drunken Healing Gem Bloom Arts, Nefarious Fish Style, Primordial Counter Form: Limbo
 - Drunken Intoxicated Emerald Elements Arts, Nape Style, Long Form: Triple Hands Leaping Enemies
 - Drunken Intoxicated Master Arts, Chaotic Windrider Style, Featherweight Tranquil Form: Saber-Freezing Advanced Warfield
 - Drunken Seeds Arts, Heavenly Thousands Style, Hellish Waltz Form: Commander
 - Dual Awakening Arts, Striking Storm Style, Capped Lightweight Form: Five-Fold United Biting Ember
 - Dual Descent Arts, Arching Reguard Style, Expansive White Web Form: Triple Plate Enduring Bird
 - Dual Destiny Arts, Big Flow Style, Dancing Fortress Form: Six Resonating Clarity
 - Dual Flames Arts, Illuminating Defensive Script Style, Corrupted North Beam Form: Triple Spearplay Descending Unity
 - Dual Horse Arts, Downward Infernal Encompassing Style, Demonic Mystery Form: Void Shaolin
 - Dual Jade Aquatic Lightweight Arts, Boundless Parallel Style, Subduing Substitution Form: Five-Fold Gateways Weakening Fang
 - Dual Moonlit Boxing Steel Arts, Lower Shapeshifter Style, Indestructible Full Wheel Form: Soar of Volley
 - Dual Night Arts, Mothers Style, Pure White Vedas Form: Waxing Archery Resting Weapon
 - Dual Onyx Thousands Arts, Sudden Radiant Waning Style, Spanning Sufferings Form: Breakthrough of the Subduing Web
 - Dual Pyre Arts, Waning Song Style, Eternal Book Form: Extinguishing Flameball
 - Dual Radiance Arts, Outward Big Spiraling Style, Obscure Style Form: Mistveil
 - Dual Scale Arts, Saving Earth Style, Icy Leap Form: Shield of the Illusory Rage
 - Dual Shadowy Arts, Cawing Wood Style, Diving Array Form: Mountian-Lunging Aureate Fang
 - Dual Sutra Arts, Thunderous Gallant Snowlocked Style, Bloodthristy Parallel Form: Dual-Wheel Ensnaring Veil
 - Dual Tea Arts, Coastal Shatters Style, Unified Execution Form: Giant Mindless-Confronting Asterism
 - Dual Waxing Parallel Pack Arts, Traceless Tidal Warriors Style, Soaring Staff Form: Lattice of the Destructive Nomad
 - Earthen Buddha Arts, Sweeping Toss Style, Cutting Heartless Whip Form: Six Taking Needles
 - Earthen Cave Arts, Subduing Eclipse Style, Riding Volley Form: Trail of Pulse
 - Earthen Dividing Horse Arts, Imperial Unmatched Battalion Style, Bloodstained Traversing Reaper Form: Death
 - Earthen Earthly Countless Way Arts, Mirror Style, Glow Form: Whirling Nape Gathering Decree
 - Earthen Metal Arts, Needle Style, Shooting Nullification Form: Pulse of the Advanced Calamity
 - Earthen Piercer Arts, Stellar Repentant Wounding Style, Forged Dominating Bat Form: Comb of the Serene Poisons
 - Earthen Scriptures Arts, Devouring Intoxicated Kick Style, Roving Elbow Form: Ancient Nature Going Arm
 - Earthen Seaspan Arts, Stellar Parallel Style, Nefarious Waltz Form: Six Chopping Lotus
 - Earthen Step Arts, Unrivaled Limitless Cardinal Style, Encompassing Eagle Form: Motion of the Descending Shout
 - Earthen Unrivaled Shout Arts, Grappling Scriptures Style, Cardinal Moonbeam Form: Elder-Following Crossing Quartet
 - Earthen Wrath Arts, Indestructible Battlefield Style, Mysterious Elegance Form: Rebounding Defense
 - Earthly Cawing Arching Prelude Arts, Unforgiving Talon Style, Nefarious Pillar Form: Net-Countering Secret Buddha
 - Earthly Copper Wild Edge Arts, Onyx Riddle Style, Starlight Form: Finger of Heaven
 - Earthly Daybreak Arts, Snake Style, Hand Form: Sharpened of the Diving Spirits
 - Earthly Earthen Giant Gate Arts, Wrath Style, Wicked Beak Form: Triple Mountainous Soaring Master
 - Earthly Gallant Split Arts, Enlightened Parallel Crows Style, Dancing Gateways Form: Triple Exorcism Stealing Paladin
 - Earthly Gem Adaptive Destiny Arts, Vedas Style, Grafting Total Form: Saber Severing Shaft
 - Earthly Hydra Arts, Ripping Downward Limitless Style, Subduing Cold Nether Form: Foundation of the Kick
 - Earthly Kick Arts, Invisible Warriors Style, Illusory Slayer Form: Giant Lance-Stabbing Motion
\page

 - Earthly Limitless Onyx Bodhi Arts, Spirit Fatal Fading Style, Facing Massacre Form: Five-Fold Prism Resting Ladder
 - Earthly Rolling Hawk Arts, Nefarious Spirit Countless Style, Apex Siege Form: Martyr
 - Earthly Tiger Arts, Quick Venomous Bound Style, Traditional Frenzy Form: Dual-Scale Soaring Rage
 - Earthly Transparency Arts, Beak Style, Ascending Thrust Form: Transformation of the Spanning Cut
 - Earthly Warriors Arts, Mighty Calm Ethereal Style, Gem Stealth Form: Dual-Guard Drifting Staff
 - Eastern Autumn Arts, Expansive Wall Style, Endless Crazy Sutra Form: Protector of the Venomous Halo
 - Eastern Boundless Metal Arts, Chaotic Drunken Embracing Style, Bloodthristy Mind Form: Five-Fold Self Shaking Brush
 - Eastern Cascade Arts, Evil Undivinable Prajna Style, Final Heartless Aura Form: Giant Reflection-Feinting Calamity
 - Eastern Destructive Technique Arts, Shattering Extreme Cold Style, Grace Form: Charging Throw
 - Eastern Elemental View Arts, Bright Rolling Blossoms Style, Chop Form: Kaleidoscope of Projectile
 - Eastern Extra Big Beast Arts, Wild Chaos Style, Serpent Form: Vibrant of Deities
 - Eastern Featherweight Sanctity Arts, Toxic Living Fading Style, Fairy Form: Phantom
 - Eastern Ghost Arts, Astral Expansive Mystic Style, Coastal Tai Form: Gust Weakening Crush
 - Eastern Gust Arts, Fleeting Ancient Parallel Style, Rising Nebula Form: Triple Toil Coiling Sonata
 - Eastern Illuminating Roving Snakeform Arts, Spirit Breakout Style, Radiant Shout Form: Starvation
 - Eastern Immortal Great Emperor Arts, Mighty Disinterment Style, Felling Penetration Form: Resonance of Strike
 - Eastern Noble Arts, Dominating Subduing Scatter Style, Foxform Mad Mindless Form: Center
 - Eastern Sweetened Arts, Unified Thrust Style, Foundational Wounding Sect Form: Maiden Rising Dipper
 - Eastern Switch Arts, Endless Violent Aureate Style, Millennium Form: Six Soaring Change
 - Eastern Thrust Arts, Bound Style, Coral Jewel Form: Five-Fold Punch Tearing Wanderer
 - Eastern True Infernal Motion Arts, Countless Might Style, Fiendish Hidden Sufferings Form: Repents Crushing Daoist
 - Elegant Basilisk Arts, Waning Sky Style, Mount Form: Angel
 - Elegant Cave Arts, Corvid Distinction Style, Sweeping Trigrams Form: Domination
 - Elegant Circulation Arts, Ravenous Dancing Smashing Style, Infinite Corrupted Meditation Form: Rampage of the Essence
 - Elegant Countless Grand Heat Arts, Advanced Ghostly Wisdom Style, Talon Form: Arm Aiming Life
 - Elegant Fire Arts, Twin Grace Style, Riding Soar Form: Giant Crushes-Retreating Taihua
 - Elegant Flesh Arts, Mystery Style, Smoke Form: Six Blazing Pillar
 - Elegant Granite Arts, Gallant Lost Style, Facing Sect Form: Dual-Phaseless Walking Heavenhold
 - Elegant Harmonious Shooting Heat Arts, Advanced Righteous Forged Style, Dual Pyre Form: Nails-Tangled Extreme Sword
 - Elegant Shade Arts, Exploding Malevolent Dance Style, Suffering Form: Triple Assaliants Traversing Cut
 - Elegant Tempo Arts, Riding Skills Style, Mysterious Spiritage Form: Reaper Tangled Yang
 - Elegant Toss Arts, Direction Style, Crystalline Stone Form: Thread of the Marquis
 - Elegant Toxic Harmonious Trail Arts, Forged Cawing Ultimate Style, Unrivaled Necrotoxin Form: Six Fighting Pierces
 - Elegant Undivinable Turtleback Arts, Ravenous Rolling Venomous Style, Bloody Wanderer Form: Giant Crushes-Invigorating Fury
 - Elemental Arrow Arts, Boxing Omnidirectional Style, Spearplay Form: Signless of the Advent
 - Elemental Assault Arts, Lunar Spectral Tablet Style, Throwing Tea Form: Dual-Battle Observing Tang
 - Elemental Charging Spanning Dance Arts, Rolling Toil Style, Descending Nape Form: Saber of Triadic
 - Elemental Eastern Blooming Sand Arts, Quick Assault Style, Buddhist Total Form: Triple Descent Rises Massacre
 - Elemental Equine Stunning Domination Arts, West Style, Fertile Hail Form: Triple Barrage Aiming Sage
 - Elemental Fleeting Encompassing Guard Arts, Great Sweetened Style, Hidden Crimson Lightning Form: Moonlight of Mount
\page

 - Elemental Ghost Arts, Burst Style, Waltz Form: Ethereal Starlit Leaping Crush
 - Elemental Governing Thundershock Arts, Calm Things Style, Endless Repelling Hellfire Form: Instance-Rises Cardinal Star
 - Elemental Legged Monk Arts, Diving Heart Style, Ancient Whip Form: Violent Disruption
 - Elemental Serene Demonic East Arts, Parallel Snowfield Style, Sharpened Form: Six Poking Fury
 - Elemental Taebaek Arts, Soft Style, Old Lake Form: Giant Momentum-Attacking Swing
 - Elemental Wind Arts, Soaring Nebula Style, Featherweight Walk Form: Universal Breakout
 - Elemental Winds Arts, North Final Coastal Style, Void Meditation Form: Evil Tipsy
 - Elusive Claw Arts, Glacial Scriptures Style, Shockwave Form: Triple Unbounded Aiming Vampire
 - Elusive Fortune Arts, Stunning Quick Illuminating Style, Blessed Spirits Form: Battle
 - Elusive Foxform Buddhist Heavenhold Arts, Vajrapani Style, Azure Blessing Form: Triple Feather Ending Reflect
 - Elusive Glacial Poison Arts, Extreme Tranquil Style, Frosty Dawn Form: Lost
 - Elusive Long Arts, Whirling Moonlight Style, Marquis Form: Triple Bound Gathering Thunder
 - Elusive Manifestations Arts, Silver Giant Maelstrom Style, Snake Form: Shift of the Light
 - Elusive Origin Arts, Unrivaled Sheet Style, Delights Form: Triple Cliff Resonating Vajrapani
 - Elusive Outward Rising Blossom Arts, Whirling Apex Nefarious Style, Breakout Form: Radiant Bound
 - Elusive Single Wisdom Arts, Wild Vitality Style, Crossing Void Traceless Form: Stretched of Scheme
 - Elusive Striking Buddhist Veiled Arts, Descending Frost Style, Traditional Sonic Cosmos Form: Five-Fold Chill Crouching Center
 - Elusive Stun Arts, Saving Foundational Comb Style, Divine Veiled Form: Chin-Paralizing Merciful Orthodox
 - Elusive Trail Arts, Illusory Royal Style, Coil Form: Possession-Dodging Rebounding Touch
 - Elusive Tree Arts, Creation Style, Coral Great Remains Form: Protective Dance
 - Elusive Warmth Arts, Double Starlit Style, Charging Constellation Form: Chill
 - Embracing Cavern Arts, Quick Majestic Style, Noble Form: Fortress-Tangled Mystic Domination
 - Embracing Cloud Arts, Big Gust Style, Spirit Netherworld Form: Skills of the Sudden Counter
 - Embracing Dancing Ascension Arts, Abyssal Man Style, Roving Point Form: Cold Polarm Drifting Wisdom
 - Embracing Giant Crossing Stride Arts, Moonlit Blossom Style, Final Elemental Emptiness Form: Warrior
 - Embracing Illusory Cry Arts, Protective Bloodstained Echo Style, Obscure Sutra Form: Dual-Nails Twisting Perfusion
 - Embracing Liberated Variation Arts, Waxing Skeletal Mirage Style, Precept Form: Six Enduring Sisi
 - Embracing Opening Arts, Gentle Heartless Intoxicated Style, Featherweight Skeletal Enlightenment Form: Giant Wing-Coiling Necrotoxin
 - Embracing Starlight Arts, Fiendish Outward Metal Style, Spiraling Grace Form: Moon of the Ancient Space
 - Embracing Temple Arts, Wild Spiraling Mirage Style, Treading Heartless Vedas Form: Dual-Elegance Traversing Weapon
 - Emerald Augmented Shard Arts, Limitless Lunar Sage Style, Sharpened Form: Trinity of Warrior
 - Emerald Crossing Crane Arts, Touch Style, Soaring Lord Form: Crazy Scriptures
 - Emerald Double Shade Arts, Vajrapani Style, Sanctity Form: Giant Omnidirectional-Sharpening Wheel
 - Emerald Downward Thundershock Arts, Grounded Motion Style, Scriptures Form: Dual-Mental Defending Dipper
 - Emerald Encompassing Meditation Arts, Harmonious True Suffering Style, Hellish Principles Form: Prism Leaping Hawk
 - Emerald Eruption Arts, Roving Kaleidoscope Style, Spanning Phenomena Form: Break of Manipulation
 - Emerald Ethereal Gentle Wave Arts, Devastating Illuminating Devouring Style, Sweeping Bow Form: Tai-Sleeping Unified Warmaster
 - Emerald Formless Underworld Arts, Consecutive Reaper Style, Clarity Form: Aegis Shattering Crow
 - Emerald Galaxy Arts, Arm Style, Chaotic Destructive Star Form: Five-Fold Emptiness Revitalizing West
 - Emerald Grappling Yellow Instance Arts, Pure Truth Style, Facing Defense Form: Reguard of the Featherweight Poison
\page

 - Emerald Lunar Fall Arts, Illuminating Leap Style, Encompassing Rapid Form: Triple Shell Sharpening Raptor
 - Emerald Marquis Arts, Killing Endless Stab Style, Eastern Fate Form: Binder of the Consecutive Plume
 - Emerald Nape Arts, Thoughtless Style, Ultimate Emptiness Form: Six Flying Myriads
 - Emerald Piercer Arts, Trap Style, Healing Corvid Enigma Form: Whirlwind of the Reaction
 - Emerald Pinnacle Arts, True Silent Style, Extra Grounded Guard Form: Dual-Sheet Commanding Refraction
 - Emerald Stellar Stroke Arts, Boundless Tablet Style, Binder Form: Six Traveling Martyr
 - Emerald Void Arts, Demonic Mobility Style, Subduing Torment Form: Nomad of the Devastating Raven
 - Emerald Wrath Arts, Birthless Book Style, Harmony Form: Infiltration of the Absolute Claw
 - Emerald Yin Arts, Haunt Style, Kill Form: Surface Shattering Thousand
 - Empty Arhat Arts, Sharpened Style, Hellish Augmented Heaven Form: Dual-Seaspan Transforming Glacier
 - Empty Ascent Arts, Imperial Turtleback Style, Kaleidoscope Form: Transformation of the Universal Mystery
 - Empty Circulation Arts, Azure Skill Style, Traditional Reflection Form: Six Rises Pine
 - Empty Coil Arts, Drunken Root Style, Forms Form: Shell
 - Empty Daybreak Arts, Grand Decree Style, Foxform Beasts Form: Granite of the Nomad
 - Empty Flash Arts, Apex Millennium Style, Red Triple Form: Wandering Domain
 - Empty Fog Arts, Adaptive Fate Style, Boundless Trill Form: Veil Shattering Kill
 - Empty Frozen Equine Coil Arts, Toxic Unparalleled Glacial Style, Calm Cage Form: Dual-View Soothing Defense
 - Empty Martyr Arts, Single Hand Style, Graceful Charge Form: Soar Resonating Gust
 - Empty Mighty Vajrapani Arts, Pure Unknowable Latch Style, Rising Red Circulation Form: Triple Fleche Evading Phaseless
 - Empty Palm Arts, Lattice Style, Spiral Form: Harmony of the Heavenly Ascension
 - Empty Salvation Arts, Heavenly Prism Style, Resonance Form: Featherweight Breeze Raining Origin
 - Empty Unshakable Fish Arts, Stance Style, Breakout Form: Smashing Millennium
 - Empty Winds Arts, Capped Azure Karmic Style, Abyssal Destructive Pierce Form: Song of the Foundational Sky
 - Encompassing Charging Gold Arts, Violent Calm Defensive Style, Grafting Sonic Sisi Form: Five-Fold Weapon Rising Tongue
 - Encompassing Cosmic Roars Arts, Blessed Quartet Style, Heavenly Monastery Form: Origin-Resisting Throwing Phenomena
 - Encompassing Exorcism Arts, Moonlit Yellow Cosmic Style, Solar Devastation Form: Six Rising Elements
 - Encompassing Governing Killing Heritage Arts, Transparency Style, Virtuous Sections Form: Unity-Stabbing Imperial Assaliants
 - Encompassing Poisonous Elder Arts, Prestissimo Style, Extinguishing Tide Form: Arm-Traversing Center Ceremony
 - Encompassing Rhythm Arts, Soaring Martial Storms Style, Ascending Leaves Form: Nothingness of Lightness
 - Encompassing Scatter Arts, Wheel Style, Dividing Leniency Form: Firebrand of the Retribution
 - Encompassing Shadowless Arts, Hunyuan Style, Killing Full Eclipse Form: Traditional Move
 - Encompassing Solar Priest Arts, Lower Range Style, Crystalline Reguard Form: Triple Force Defending Wisdom
 - Encompassing Taihua Arts, Sealing Penetrating Riding Style, Ancient Trigrams Form: Dual-Scripture Transforming Illusion
 - Encompassing Throwing Boxing Breakthrough Arts, Waves Style, Basic Monastery Form: Prelude-Stabbing Demonic Origin
 - Encompassing Traversing Frost Arts, Glacial Surge Style, Icebolt Form: Equal Paradise Stealing Rain
 - Endless Autumn Arts, Ghostly Heaven Style, Roving Wolf Form: Five-Fold Nebula Transforming Patriarch
 - Endless Bloodstained Stone Arts, Birthless Orthodox Style, Turtleback Form: Five-Fold Roars Coiling Sun
 - Endless Elemental Subduing Taebaek Arts, Metallic Calm Tundra Style, Formless Shattering Mastery Form: Poisonous Asterism Attacking Mind
 - Endless Gale Arts, Shura Style, Giant Thrust Form: Six Leaping Pear
 - Endless Gentle Traceless Tea Arts, Vile Spinning Tree Style, Lotus Form: Man
\page

 - Endless Karmic Arts, Stellar Heavenhold Style, Extra Riddle Form: Triple Contemplate Observing Archery
 - Endless Kick Arts, Imperial Wild Asterism Style, Crystalline Blister Form: Six Invigorating Ruin
 - Endless Legs Arts, Augmented Rising North Style, Unshakable Opening Form: Divine Pine
 - Endless Nomad Arts, Great Sage Style, Coastal West Form: Featherweight Finger
 - Endless Raven Arts, Chaotic Fertile God Style, Boundless Governing Shura Form: Five-Fold Move Dispersing Soul
 - Endless Spectral Kick Arts, Divine Midsummer Bite Style, Crusher Form: Buddha Conquering Fist
 - Endless Undivinable Fire Arts, Extra Felling Stalwart Style, Capped Enigma Form: Pierces
 - Endless Undivinable West Arts, Liberated Equal Wave Style, Thoughtless Form: Five-Fold Daybreak Rising Jeweled
 - Enlightened Authority Arts, Empty Thunderbolt Style, Onyx Big Exorcism Form: Triple Circulation Reflecting Crushes
 - Enlightened Beak Arts, Rising Void Style, Brilliant Pine Form: Six Defending Counter
 - Enlightened Crushes Arts, Holy Dawn Style, Healing Moonbeam Form: Triple South Flaming Unbounded
 - Enlightened Disruption Arts, Pine Style, Boundless Hidden Triadic Form: Parallel of the Absorption
 - Enlightened Echo Arts, Serene Fire Style, Red Slayer Form: Mirage Prajna
 - Enlightened Extreme Resonance Arts, Encompassing Noble Style, Metallic Adamantine Radiance Form: Death
 - Enlightened Flying Aegis Arts, Hellish Frosty Absolute Style, Spirit Scriptures Form: Advent of the Unshakable Spear
 - Enlightened Foundational Icy Soar Arts, Vile Cove Style, Infernal Legacy Form: Six Flowing Triadic
 - Enlightened Frosty Black Leech Arts, Spectral Sweep Style, Fiery Reflection Form: Raven of the Shura
 - Enlightened Obscure Coated Wheel Arts, Martial Drowned Style, Yang Form: Toil of the Prelude
 - Enlightened Protector Arts, Blazing Arrows Style, Evil Radiant Method Form: God of the Ultimate Massacre
 - Enlightened Rivers Arts, Nefarious Haunt Style, Undivinable Wave Form: Six Rising Chackra
 - Enlightened Thrust Arts, Encompassing Warfield Style, Birthless Spike Form: Five-Fold Poison Airsplitting Vampire
 - Enlightened Vapor Arts, Extreme Wheel Style, Undivinable Perfect Rectitude Form: Nomad
 - Enlightened Warfield Arts, Rising Repelling Extended Style, Glacier Form: Crows
 - Enlightened Woods Arts, Crane Style, Chaotic Comb Form: Dual-Zen Breaking Consciousness
 - Enlightened Yang Arts, Sweeping Bloody Full Style, Lower Ripple Form: Downward Family
 - Equal Awakening Arts, Sacred Radiance Style, Extreme Daybreak Form: Flight
 - Equal Battalion Arts, Obscure Continuous Daybreak Style, Ghostly Unbounded Form: Spearplay
 - Equal Condor Arts, Ghostly Trap Style, Southern Unified Slash Form: Dancing Hand Crushing Poison
 - Equal Earthen Glacial Cleave Arts, Liberated Finger Style, Domain Form: Swarm-Invigorating Sweeping Skill
 - Equal Feather Arts, Yellow Soft Style, Righteous Ceremony Form: Kings Rising Myriads
 - Equal Gate Arts, Corrupted Unknowable Heartless Style, Abyssal Block Form: Nail Ensnaring Interference
 - Equal Gust Arts, Foxform Shower Style, Hidden Silent Form: Triple Reflection Enduring Pear
 - Equal Intoxicated Radiant Judgment Arts, Cavern Style, Nefarious Vajrayana Form: Myriads of the Veiled
 - Equal Pyrocascade Arts, Spiraling Aureate Enigma Style, Feral Bat Form: Angel of Mindscape
 - Equal Raptor Arts, Infernal Torment Style, Secret Overwash Form: Giant Waltz-Soaring Beggar
 - Equal Thunderbolts Arts, Featherweight Yin Style, Elusive Vajrayana Form: Triple
 - Equal Traceless Arts, Encompassing Foxform Living Style, Corvid Devastation Form: Giant Earthquakes-Blowing Exorcism
 - Equal Yellow Goldenring Arts, Unified Tipsy Style, Advanced Star Form: Twin Enlightenment Taking Tempo
 - Equine Crystalline Mirage Cuts Arts, Leniency Style, Downward Expansive Tail Form: Path of the Volley
 - Equine Cultivation Arts, Full Fox Style, Slicing Priest Form: Battle of the Equal Fish
\page

 - Equine Dew Arts, Ripping Feather Style, Opening Form: Posture
 - Equine Fertile Nullification Arts, Wounding Destructive Responsive Style, Cosmic Ghostly Fairy Form: Charge
 - Equine Graypine Arts, Featherweight Prajna Style, Icy Subduing Fish Form: Five-Fold Woodland Commanding Suffering
 - Equine Lotus Arts, Sections Style, Waxing Maiden Form: Dual-Infiltration Dispersing Raptor
 - Equine Stomp Arts, Cross Style, Eternal Force Form: Sharpened of the Lunar Stretched
 - Equine Transformations Arts, Snow Rage Style, Ancient Obscure Snake Form: Giant Realm-Swirling Snowlocked
 - Equine Vitality Arts, Chill Style, Crimson Millennium Form: Hit of Protector
 - Equine Volcano Arts, Perfect Celestial Quick Style, Toxic Taihua Form: Grafting Enemy Confronting Chop
 - Equine Waves Arts, Healing Elegant Spirit Style, Flying Sealing Prayer Form: Six Retreating Angel
 - Equine Wolf Arts, Apex Crazy Flying Style, Wandering Bolt Form: Giant Advent-Leaping Shout
 - Erupting Beak Arts, Abyssal Phenomena Style, Immortal Slayer Form: Triple Taebaek Grounding Hell
 - Erupting Dancing Bloodthristy Slash Arts, Extra Form Style, Traditional Universal Wraith Form: Web Grounding Vajrapani
 - Erupting Dragon Arts, Center Spectral Dominating Style, Obsidian God Form: Six Concealing Warrior
 - Erupting Drunken Outward Volcanoes Arts, Grafting Spread Style, Giant Shura Form: Height of the Legs
 - Erupting Explosion Arts, Obscure Storm Style, Rolling Decree Form: Triple Mindscape Observing Kings
 - Erupting Foundational Phantom Arts, Luminous Endless Saving Style, Formless Gem Saber Form: Six Defending Bone
 - Erupting Grove Arts, Equal Few Corvid Style, Extinguishing Ghostly Trinity Form: Harmonies-Paralyzing Ravenous Omnidirectional
 - Erupting Icebolt Arts, Boundless Archery Style, Empty Unrestrained Form: Unshakable Nether
 - Erupting Merciful Infinite Mountain Arts, Vitality Style, Toxic Chill Form: Giant Rectitude-Carrying Grasp
 - Erupting Thunderwake Arts, Thousands Style, Cardinal Trigrams Form: Triangle of Devil
 - Erupting Vigor Arts, Ancient Basilisk Style, Healing Mirror Form: Starlight of the Orthodox
 - Erupting Wave Arts, Mysterious Mind Style, Equine Rampage Form: Giant Basilisk-Carrying Finger
 - Eternal Chop Arts, Bronze Signless Style,  Sage Form: Perfect Quick
 - Eternal Coil Arts, Mad United Style, Capped Vile Assaliants Form: Corrupted Sage
 - Eternal Condor Arts, Trinity Style, Indestructible Marquis Form: Hell-Emerging Balanced Element
 - Eternal Destructive United Arts, Throwing Stone Style, Crazy Snake Form: Grounded Meridian
 - Eternal Elusive Birthless Execution Arts, God Style, Advanced Sect Form: Five-Fold Suppression Freezing Bind
 - Eternal Exploding Self Arts, Rightful Unforgiving Storm Style, Martial Shatters Form: Giant Taming-Piercing Leech
 - Eternal Final Exploding Disciple Arts, Expansive Legged Domain Style, Capped Posture Form: Five-Fold Swords Revitalizing Distinction
 - Eternal Mindless Arts, Mighty Thundershock Style, Absolute Battle Form: Netherworld-Enduring Double Cultivation
 - Eternal Phantom Arts, Adamantine Legged Rock Style, Repelling Ripple Form: Condor of the Heartless Grace
 - Eternal Strike Arts, Riding Violent Extinguishing Style, Temple Form: Unknowable Waves Summoning Water
 - Eternal Twin Infusion Arts, Red Defense Style, Bright Disinterment Form: Radiant Polarm Following East
 - Eternal Wind Arts, Unrivaled Stride Style, Featherweight Enemies Form: Torment of the Shell
 - Ethereal Bound Arts, Frost Style, Big Violent Breakout Form: Kundali of the Malevolent Book
 - Ethereal Expansive Continuous Bird Arts, Vairocana Style, Protective Ascension Form: Brush of Monastery
 - Ethereal Forged Coil Arts, Featherweight Many Kill Style, Clouds Form: Net-Severing Eternal Protector
 - Ethereal Hawk Arts, Shattering Chain Style, Fortune Form: Swords of Form
 - Ethereal Living Grand Claw Arts, Cawing Emergence Style, Rebounding Swan Form: Five-Fold Legacy Searching Moonlight
 - Ethereal Snowfield Arts, North Prajna Style, Old Hawkstrider Form: Sea Cutting Butterfly
\page

 - Ethereal Substitution Arts, Otherness Style, Cosmic Wave Form: Chaotic Bound Traveling North
 - Ethereal Tortoise Arts, Astral Malevolent Thousands Style, Traversing Tidal Order Form: Ripping Trigrams
 - Ethereal Ultimate Nail Arts, Instance Style, Absolute Harvest Form: Fury of the Transformation
 - Ethereal Waltz Arts, Breakthrough Style, Ripple Form: Awakening of Flash
 - Evil Ascent Arts, Sudden Circulation Style, Blazing Awakening Form: Chop
 - Evil Beam Arts, Violent Crash Style, Foxform North Form: Heartless Leaves
 - Evil Encompassing Extinguishing Ripple Arts, Snow Killing Whip Style, Malevolent Waxing Fairy Form: Six Reflecting Vitality
 - Evil Final Protector Arts, Redemption Style, Encompassing Kundali Form: Fatal Crash Sharpening Tablet
 - Evil Fortune Arts, Refraction Style, Demonic Dividing Eruption Form: Giant Incineration-Fighting Starvation
 - Evil Manifestation Arts, Eastern Mystic Spiritual Style, Intoxicated Hidden Nail Form: Dividing Battlefield Soothing Sword
 - Evil Sun Arts, Wandering Shield Style, Universal Venom Form: Six Transforming Tranquil
 - Evil Thaw Arts, Crimson Coastal Center Style, Limitless Grafting Patriarch Form: Triple Hit Swirling Decree
 - Evil Unparalleled Birthless Lattice Arts, Martial Tang Style, Undivinable Salvation Form: Chaos of the Ethereal Center
 - Expansive Adamantine Deity Arts, Grand Sight Style, Cuts Form: West
 - Expansive Adaptive Daybreak Arts, Holy Trap Style, Aquatic Binder Form: Triple Posture Conquering Kick
 - Expansive Big Moonlit Sui Arts, Enlightened Sugar Style, Repentant Return Form: Six Soothing Wall
 - Expansive Delights Arts, Vile Hit Style, Dual Volcanoes Form: Giant Ink-Bowing Resolve
 - Expansive Dividing Charging Trill Arts, Encompassing Empty Unbounded Style, Earthly Soft Form: Governing Cage
 - Expansive Fiend Arts, Feral Felling Wildfire Style, Ascending Malevolent Staff Form: Six Scorching Penetration
 - Expansive Finishing Splitting Hail Arts, Sweeping Subduing Surface Style, Martyr Form: Ruin of Circulation
 - Expansive Outward Blooming Vampire Arts, Cutting Tree Style, Crimson Waltz Form: Dual-Winds Vispering Scheme
 - Expansive Pine Arts, Fiendish Needles Style, Chaotic Jade Hand Form: Aspects Confronting Long
 - Expansive Rock Arts, Liberated Equal Center Style, Single Stomp Form: Triple Zenith Observing Possession
 - Expansive Step Arts, Legged Sacred Liberated Style, Ascending Mirage Scale Form: Giant Army-Transforming Repents
 - Expansive Trio Arts, Extinguishing Traditional Refraction Style, Northern Saber Form: Execution-Dodging Evil Transformations
 - Expansive Veil Arts, Eastern Final Adaptive Style, Universal Spin Form: Dual-Bow Flying Monkey
 - Expansive Warmaster Arts, Destructive Scale Style, Clarity Form: Pierce of the Change
 - Expansive Water Arts, Virtuous Battlefield Style, Mystic Thoughtless Form: Fog Traversing Quick
 - Expansive West Arts, Old Taibai Style, Possession Form: Plume of Flashes
 - Exploding Asura Arts, Gentle Seaspan Style, Waning Fist Form: Malignant of the Tearing Hell
 - Exploding Creation Arts, Graceful Elbow Style, Rolling Thunderwake Form: Six Crouching Sufferings
 - Exploding Cutter Arts, Polar Style, Western Summit Form: Dual-Principles Going Trill
 - Exploding Daybreak Arts, Seaspan Style, Outward Augmented Fortress Form: Ghost of Tipsy
 - Exploding Defense Arts, Twin Fiendish Roving Style, Foundational Interference Form: Tang-Soothing Iron Delights
 - Exploding Defensive Battalion Arts, North Heaven Style, Mirage Shower Form: Spread of the Domain
 - Exploding Devastating Consuming Trio Arts, Sealing Quick Tongue Style, Astral Cutter Form: Five-Fold Hand Confronting Scheme
 - Exploding Family Arts, Calm Jade Touch Style, Petal Pear Form: Defiers
 - Exploding Hoarforst Arts, Unparalleled Plume Style, Magnanimous Limbo Form: Yin-Counterattacking Extra Cloak
 - Exploding Long Arts, Flash Style, Elegant Erupting Thunder Form: Serpent
 - Exploding Mastery Arts, Black Fiend Style, Underworld Form: Prayer of the Spiral
\page

 - Exploding Misty Arts, Breakout Style, Dark Buddha Form: Elder-Following Spectral Pattern
 - Exploding Moonlit Harmonies Arts, Heartless Star Style, Obscure Contemplate Form: Five-Fold Scholar Vispering Tempest
 - Exploding Ravenous Vermillion Slip Arts, Poisonous Viper Style, Featherweight Elbow Form: Absolute Bird Following Authority
 - Exploding Shard Arts, Indestructible Immortal Hell Style, Graypine Form: Battlefield of Toxin
 - Exploding Sheet Arts, Change Style, Coated Disciple Form: God of Harvest
 - Exploding Single Spectral Scholar Arts, Living Drift Style, Unrivaled Hit Form: Six Airsplitting Aura
 - Exploding Trigrams Arts, Luminous Pure Serene Style, Tiger Form: Spiritage of the Piercer
 - Exploding Way Arts, Spiraling Pearlflower Style, Ascending Sanctum Form: Manipulation
 - Exploding Wheel Arts, Sudden Cut Style, Double Tablet Form: Apex Realm Attacking Venom
 - Extended Brush Arts, Enlightened Advent Style, Immortal Redemption Form: Dual-Battalion Blowing Destroyer
 - Extended Cloak Arts, Giant Patriarch Style, Grappling Domain Form: Nomad of the Turtle
 - Extended Curse Arts, Roving Kick Style, Copper Grasp Form: Giant Tranquil-Leaping Bow
 - Extended Immortal Limitless Arm Arts, Cutting Jewel Style, Western Crane Form: Giant Beggar-Gathering Assaliants
 - Extended Snakeform Arts, Deep Meridian Style, Shooting Shout Form: Quake Matching Neck
 - Extended Spirit Formation Arts, Wandering Forged Chaotic Style, Formless Blade Form: Scriptures of the Cage
 - Extinguishing Boundless Vermillion Tail Arts, Consonance Style, Soaring Infusion Form: Manifestation of Cutter
 - Extinguishing Destructive Crossing Blood Arts, Coral Corrupted Unified Style, Western Trinity Form: Fang Rises Split
 - Extinguishing Devastating Mount Arts, Taebaek Style, Repentant Solar Awakening Form: Formless Forms Twisting Method
 - Extinguishing Distinction Arts, Lower Precept Style, Healing Mirage Taibai Form: Striking Meridian
 - Extinguishing Jade Vine Arts, Center Mysterious Roar Style, Dual Energy Form: Blooming Prestissimo Sacrificing Reflection
 - Extinguishing Salvation Arts, Traversing Encompassing Temple Style, Stunning Sea Form: Buddhist Reaper Carrying Origin
 - Extinguishing Song Arts, Graceful Many Soaring Style, Vermillion Shield Form: Coated Bound
 - Extinguishing Soul Arts, Gem Fertile Intent Style, Traversing Ladder Form: Shout Feinting Cliff
 - Extinguishing Spearplay Arts, Rising Saving Grand Style, Quartet Form: Edge-Drifting 42nd Descent
 - Extinguishing Vampire Arts, Sealing Deities Style, Advanced Waning Starvation Form: Giant Curse-Taking Crow
 - Extinguishing Waves Arts, North Finishing Basic Style, Single Eternal Flesh Form: Whirling Bodhi Walking Stance
 - Extra Abyssal Misty Arts, Feral Opposition Style, Aureate Repentant Range Form: Six Traveling Surface
 - Extra Azure Wandering Realm Arts, Dirty Stalwart Style, Radiant Palm Form: Triple Bound Searching Remains
 - Extra Blister Arts, Slip Style, Universal Reflection Form: Steel of the Asura
 - Extra Disciple Arts, Frozen Basic Thunderous Style, Crazy Rectitude Form: Spirit Sweep Enduring Circle
 - Extra Fury Arts, Rolling Plume Style, Aquatic Lotus Form: Triple Cut Retreating Nape
 - Extra Graypine Arts, Repelling Illuminated Style, Fleeting Jeweled Form: Coil of Fiend
 - Extra Invisible Temple Arts, Western Flower Style, Extinguishing Calamity Form: Kundali
 - Extra Lofty Arts, Merciful Vile Ravenous Style, Cut Form: Prism
 - Extra Nothingness Arts, Grounded Northern Yellow Style, Graceful Thousands Form: Cuts of Elbow
 - Extra Reflection Arts, Skeletal Infinite Lance Style, River Form: Triple Martyr Crouching Total
 - Extra Stellar Metal Arts, Spiraling Extended Enlightenment Style, Calm Transparency Form: Augmented Consciousness Rising Walk
 - Extra Unbounded Arts, Edge Style, Cove Form: Prayer of the Fairy
 - Extreme Dominating 60 Fold Needles Arts, Wandering Cross Style, Emerald Galaxy Form: Brilliant Elegance Crouching Thousands
 - Extreme Embracing Crazy Earth Arts, Stellar Soaring Breakout Style, Secret Monkey Form: Giant King-Reflecting Skill
\page

 - Extreme Encompassing Icy Plume Arts, Equal Devil Style, Equine Deities Form: Six Blazing Rage
 - Extreme Great Repentant Cliff Arts, Unparalleled Aureate Righteous Style, Remains Form: Sudden Qintfade Shaking Slayer
 - Extreme Mad Chaotic Scripture Arts, Thunderous Flesh Style, Saint Form: Mastery-Rising Fatal Nape
 - Extreme Mighty Graypine Arts, Drift Style, Toxic Polearm Form: Ascent-Lunging Grounded Intent
 - Extreme Snakeform Arts, Aquatic Wave Style, Deep Needle Form: Domination of Breakout
 - Extreme Throw Arts, Elegant Riding True Style, Unified Ceremony Form: Dipper of the Wrath
 - Extreme Universal Mad Rhythm Arts, Indestructible Needle Style, Cawing Shout Form: Vedas of the Cobra
 - Extreme Verdant Arts, Merciful Toxin Style, Onyx Judgment Form: Five-Fold Might Controlling Ascension
 - Extreme Way Arts, Snow Exorcism Style, North Kick Form: Triple Drop Flowing Principles
 - Extreme Windrider Arts, Storms Style, Unshakable Many Realm Form: Dual-Thundershock Counterattacking Flame
 - Facing Defense Arts, Skull Style, Dual Order Form: Erupting Royal
 - Facing Edge Arts, Dirty Extreme Heavenly Style, Petal Glacial Gorge Form: Hellish Horse
 - Facing Emergence Arts, Battlefield Style, Ascending Bound Form: Judgment of the Gold
 - Facing Equine South Arts, Wounding Gem Shroud Style, Charging Titan Form: Giant Raptor-Weakening Kundali
 - Facing Fleeting Bow Arts, Consuming Cage Style, Mysterious Prism Form: Karmic of the Augmented Darkwind
 - Facing God Arts, Bite Style, Splitting Heavenhold Form: Enlightened Elder Invigorating Pattern
 - Facing God Arts, Waning Trial Style, Living Ice Form: Five-Fold Contemplate Airsplitting Polarm
 - Facing Hellish Adamantine Barrage Arts, Spiritual Nullification Style, Taihua Form: Drain of the Night
 - Facing Illuminating Eternal Court Arts, Extinguishing Soar Style, Hidden Shadowless Form: Six Biting Shroud
 - Facing Patriarch Arts, Repelling Warmaster Style, Spectral Enemy Form: Consuming Mothers
 - Facing Script Arts, Erupting Unparalleled Grounded Style, Dividing Cold Royal Form: Heart of Pinnacle
 - Facing Shooting Sanctum Arts, Holy Current Snakeform Style, Sealing Yang Form: Five-Fold Array Falling Quick
 - Facing Vairocana Arts, Mysterious Tidal Gentle Style, Graceful Song Form: Sea of the Daoist
 - Fading Assimilation Arts, Infinite Sylvan Style, Soaring Crusher Form: Needle of the Sonic Pine
 - Fading Boxing March Arts, Sacred Team Style, Diving Method Form: Five-Fold Daoist Weakening Mental
 - Fading Corrupted Bronze Dawn Arts, Cawing Fate Style, Cardinal Swift Form: Dual-Descent Gathering Forms
 - Fading Essence Arts, Hell Style, Consuming Elevens Battle Form: Dual Madness
 - Fading Glacial Wild Palm Arts, Jade Hail Style, Final Empty Necrotoxin Form: Six Vispering Viper
 - Fading Governing Wild Eruption Arts, Red Heaven Style, Waning Crazy Wall Form: Five-Fold Thundershock Tangled Quell
 - Fading Grappling Limitless Divinities Arts, Lofty Style, Fortress Form: Righteous Cross
 - Fading Traditional Elusive Piercer Arts, Old Snowfall Style, Abyssal Dirty Immovable Form: Kaleidoscope-Flowing Poisonous Galaxy
 - Fading Unknowable Vile Spearplay Arts, Eternal Windrider Style, Continuous Harmonies Form: Astral Destiny
 - Fading Waters Arts, Descending Grappling Martial Style, Rising Moonbeam Form: Triple Skills Biting Sage
 - Fatal Book Arts, Kick Style, Elder Form: Serene Smoke Sacrificing Triple
 - Fatal Cloak Arts, Pierces Style, Illusory Blood Form: Polearm
 - Fatal Crane Arts, Ancient Point Style, Foxform United Form: Riddle of the Contemplate
 - Fatal Deep Lofty Arts, Retribution Style, Heavenly Earthen Mountainous Form: Wrath of the Poisons
 - Fatal Drop Arts,  Vitality Style, Quartet Form: Six Ensnaring Sonata
 - Fatal Eruption Arts, Illuminated Style, Chin Form: Dual-Resonance Burning Formation
 - Fatal Final Fairy Arts, Destructive Monkey Style, Subduing Aquatic Temper Form: Six Stealing Ascension
\page

 - Fatal Infinite Breakout Arts, Imperial Obscure Fox Style, Spinning Tortoise Form: Malevolent Hydra Lunging Judgment
 - Fatal Jade Ultimate Array Arts, Blazing Swift Style, Astral Hunyuan Form: Triple Triadic Countering Yin
 - Fatal Leaves Arts, Illuminating Gold Style, Venomous Wisdom Form: View
 - Fatal Shade Arts, Midsummer Sweep Style, Cold Butterfly Form: Six Stealing Suppression
 - Fatal Spirit Unified Volley Arts, Zen Style, Facing Omnidirectional Form: Marquis-Airsplitting Mysterious Assaliants
 - Fatal Strikes Arts, Spinning Thunderous Storms Style, Primordial Refraction Form: Consuming Roar
 - Fatal Warmth Arts, Flying Severance Style, Wraith Form: Giant Remains-Observing Bound
 - Featherweight Ceremony Arts, Grounded Responsive Harmony Style, Gale Form: Five-Fold Life Resonating Possession
 - Featherweight Diving Court Arts, Skeletal Spinning Double Style, Fertile Windrider Form: Vitality-Commanding Equine Ghost
 - Featherweight Eruption Arts, Waxing West Style, Giant Bolt Form: Lotus-Linking Twin Incineration
 - Featherweight Flow Arts, Fleeting Legged Titan Style, Windswept Form: Five-Fold Sections Observing Patriarch
 - Featherweight Gem Coastal Scatter Arts, Golden Shooting Quick Style, Old Mobility Form: Triple Heritage Draining Blister
 - Featherweight God Arts, Onyx Indestructible Aegis Style, Jade Momentum Form: Sword Airsplitting Vampire
 - Featherweight Immortal Balanced Disinterment Arts, Intoxicated Shadow Infusion Style, Healing Hawk Form: Triple Hands Emerging Pierce
 - Featherweight Iron Sacred Polar Arts, Onyx Ultimate Fist Style, Rising Triangle Form: Consciousness-Enduring Celestial Infiltration
 - Featherweight Killer Arts, Burning Ultimate Advanced Style, Vile Fist Form: Dual-Retribution Twisting Domain
 - Featherweight Living Thunderous Redemption Arts, Old Flesh Style, Chaotic Kill Form: Giant Force-Fighting Blister
 - Featherweight Momentum Arts, Universal Graceful Countless Style, Devouring Spiral Form: Lower Net
 - Featherweight Onyx Rolling Brook Arts, Sealing Commander Style, Spiritual Lunar Thread Form: Specter of the Binder
 - Featherweight Prism Arts, Bloodthristy Tail Style, Spectral Army Form: Five-Fold Sound Ending Fleche
 - Featherweight Reaper Arts, Tail Style, Snow White Waves Form: Triple Specter Paralizing Step
 - Featherweight Stalwart Arts, Violent Demonic Eastern Style, Intoxicated Apex Jeweled Form: Return of the Crimson Dive
 - Featherweight Thunderbolt Arts, Ravenous Devil Style, Wandering Embrace Form: Flameball of the Unrestrained
 - Featherweight Unshakable Instance Arts, Divine Unveiled Style, Repentant Mirror Form: Five-Fold Road Covering Sections
 - Featherweight Warmaster Arts, Throwing Sheet Style, Harmonious Meridian Form: Six Carrying Origin
 - Featherweight Warriors Arts, Graceful Goldenring Style, Splitting Monastery Form: Nomad Revitalizing Saber
 - Featherweight Yang Arts, Luminous Frosty Nature Style, Swords Form: Fang of the Grounded Height
 - Felling Adaptive Apex Martyr Arts, Iron Drunken Bodhidharma Style, Consecutive Few Road Form: Protector of the Cursed Toss
 - Felling Apex Basic Sweep Arts, Demonic Cawing Fertile Style, Ladder Form: Dawn Swirling Sight
 - Felling Beggar Arts, Earthly Waning Shadow Style, Striking Moonlight Form: Primordial Void Stealing Sand
 - Felling Double Heartless Soar Arts, Shadowy Style, Blooming Skills Form: Six Biting Saber
 - Felling Elbow Arts, Whirling Monk Style, Azure Thoughtless Form: Scheme-Coiling Final Exorcism
 - Felling Fiery Roving Swan Arts, Unmatched Calm Perfusion Style, Hellish Beasts Form: Giant Breakthrough-Cutting Cry
 - Felling Giant Heart Arts, Glacial Graypine Style, Consuming Slayer Form: Traditional Snakeform
 - Felling Hoarforst Arts, Downward Nothingness Style, Snow Sect Form: Six Falling Thread
 - Felling Radiance Arts, Profound Trill Style, Absolute Legs Form: Harmony Swirling Lightness
 - Felling Righteous Spirit Emergence Arts, Graceful Buddhist Grafting Style, Exorcism Form: Five-Fold Ash Leaping Thunderclap
 - Felling Rivers Arts, Judgment Style, Expansive Misty Form: Dual-Leaves Traveling Aspects
 - Felling Trial Arts, Azure Aura Style, Breakout Form: Prajna of the Monastery
 - Felling Warmaster Arts, Quick Extinguishing Cutting Style, Sonata Form: Kill of the Center Earthquakes
\page

 - Feral Change Arts, Extreme Vile Fatal Style, Echo Form: Phenomena Retreating Misty
 - Feral Fairy Arts, Absolute Warfield Style, Coated Fist Form: Quake of Archery
 - Feral Final Elbow Arts, Center Immovable Style, Embracing Flower Form: Giant Karmic-Flowing Dive
 - Feral Flames Arts, Blessed Step Style, Buddhist Indestructible Battle Form: Five-Fold United Falling Beak
 - Feral Frosty Sage Arts, Destructive Endless Immovable Style, Encompassing Pack Form: Six Vispering Shroud
 - Feral Lance Arts, Continuous Butterfly Style, Capped Scheme Form: Thoughtless of Mount
 - Feral Lunar Leniency Arts, Solar Exploding Massacre Style, Icy Formless Instance Form: Wood of the Mystic View
 - Feral Mastery Arts, Limitless Scripture Style, Otherness Form: Triple Hand Falling Surface
 - Feral Quick Arts, Gem Claw Style, Thunderous Autumn Form: Triple Assimilation Matching Hit
 - Feral Repentant Battlefield Arts, Holy Prism Style, Sudden Mountian Form: Great Jewel
 - Feral Retribution Arts, Northern Dividing Lunar Style, Dancing Elusive Realm Form: Slip of the Capped Walk
 - Feral Silver Thousands Arts, Consuming Shatter Style, Basic Awakening Form: Book of the Throwing Vajrapani
 - Feral Snowfall Arts, Harmonious Ultimate Hands Style, Scholar Form: Mount of the Battle
 - Feral Team Arts, Perfect Underworld Style, Onyx Chaos Form: Giant Intent-Gathering Infusion
 - Fertile Arching Stone Arts, Downward Cawing Old Style, Fortress Form: Six Reflecting Walk
 - Fertile Aureate Kick Arts, Undivinable Titan Style, Unified Gust Form: Few Severance
 - Fertile Balance Arts, Boundless Prism Style, Feral Felling Poison Form: Ascent of Throw
 - Fertile Buddhist Disciple Arts, Wounding Block Style, Magnanimous Web Form: Contemplate
 - Fertile Domain Arts, Dancing Illuminated Style, Truth Form: Dual-Skills Going Roars
 - Fertile Elegant Yellow Change Arts, Splitting Touch Style, Grand Zen Form: Mystery of the Equine Sun
 - Fertile Essence Arts, Basic Crazy Penetrating Style, Center Space Form: Thousands
 - Fertile Facing Consciousness Arts, True Serene Prajna Style, Unknowable King Form: Perfusion
 - Fertile Felling Wounding Palms Arts, Fading Elegance Style, Equal Center Mental Form: Galaxy of the Peak
 - Fertile Fleche Arts, Yellow Ladder Style, Tearing Grappling Truth Form: Mothers of Defiers
 - Fertile Maelstrom Arts, Perfect Aureate Vajrayana Style, Severance Form: Six Feinting Wrath
 - Fertile Monastery Arts, Dual Unknowable Magnanimous Style, Gem Battlefield Form: Blister Following Sugar
 - Fertile Moonlit Foundational Ripple Arts, Tongue Style, Cutting Perfect Suffering Form: Dual-Maiden Matching Bound
 - Fertile Neck Arts, Crows Style, Destruction Form: Proud
 - Fertile Protective Many Saint Arts, Downward Harmonious Beast Style, Void Embrace Form: Tea of the Obscure Interference
 - Fertile Script Arts, Charging Parallel Gust Style, Lower Royal Form: Touch of the Brilliant Mothers
 - Fertile Solar Striking Movement Arts, Consuming Defiers Style, Dancing Merciful Bind Form: Space
 - Fertile Storms Arts, Aureate Blessed Stretched Style, Absolute Consonance Form: Giant Punch-Dodging Gateways
 - Fertile Sui Arts, Limbo Style, Hellish Scale Form: Dual-Deity Fighting Tremor
 - Few Capped Sacred Sheet Arts, Exploding Basic Stealth Style, Smashing Realm Form: Soar-Drifting Arching Bear
 - Few East Arts, Golden Rhythm Style, Western Nape Form: Responsive Tongue Stopping Sonata
 - Few Flash Arts, Moonlit Step Style, Legged Unrivaled Turtle Form: Illuminated of the Intent
 - Few Frozen Polarm Arts, Abyssal Paladin Style, Apex Corvid Salvation Form: Giant Seal-Sharpening Reaction
 - Few Guardian Arts, Hidden Wood Style, Dominating Veiled Form: Beam Binding Starvation
 - Few Killer Arts, Big Aura Style, Unrivaled Intention Form: Giant Earth-Gathering Otherness
 - Few Leaves Arts, Formless Wood Style, Righteous Quick Form: Method of the Intoxicated Hawkstrider
\page

 - Few Maelstrom Arts, Aureate Prayer Style, Bow Form: Beast-Ensnaring Spirit Vibrant
 - Few Mountainous Arts, Consuming Splitting Foundation Style, Evil Cliff Form: Five-Fold Pattern Cleaving Daybreak
 - Few Quick Arts, Sacred Fading Nefarious Style, Center Delights Form: North of Vibrant
 - Few Scriptures Arts, Thread Style, Basic Stellar Mindless Form: Dual-Punch Sharpening Mountian
 - Fiendish Crossing Aureate Venom Arts, Hidden Sweep Style, Graceful Transformation Form: Blooming Array Stealing Karma
 - Fiendish Destiny Arts, Universal Bone Style, Earthly Death Form: Dual-Cobra Twisting Split
 - Fiendish Destructive Cascade Arts, Invisible Pearlflower Style, Counter Form: Mental of the Buddhist Infiltration
 - Fiendish Ethereal Finishing Myriads Arts, Grafting Unified Rising Style, Spectral Timberfall Form: View Ensnaring Dance
 - Fiendish Execution Arts, Unshakable Mirrored Style, True Dual Shroud Form: Split
 - Fiendish Fleeting Empty Team Arts, Tempest Style, Sudden Ursine Form: Dual-Battle Dodging Instance
 - Fiendish Gem Waning Assaliants Arts, Final Destructive Man Style, Aquatic Descent Form: Fall of Prelude
 - Fiendish Heritage Arts, Grappling Silver Sonata Style, Ghostly Countless Chop Form: Wrath of the Wolf
 - Fiendish Nether Arts, Lunar Kick Style, Stunning Shadowless Form: Palm-Piercing Ripping Manifestation
 - Fiendish Perfect Blister Arts, Featherweight Vine Style, Assaliants Form: Triple Shadowless Stealing Man
 - Fiendish Rightful Infernal Fury Arts, South Style, Final Gentle Trail Form: Mothers-Surging Sudden Hail
 - Fiendish Stunning Saint Arts, Continuous Barrage Style, Grounded Cavern Form: Trill of Foundation
 - Fiendish Treading Stunning Toil Arts, Dao Style, Riding Surface Form: Dual-Slip Stealing Zen
 - Fiendish Vitality Arts, Hellish Dive Style, Gallant Sonic Leaf Form: Dual-South Paralizing Height
 - Fiery Ascent Arts, Eternal Harmonious Old Style, Void Overwash Form: Triple Ape Weakening Blessing
 - Fiery Cuts Arts, Sweeping Ape Style, Boxing Beasts Form: Spirits-Resonating Wounding Specter
 - Fiery Elegant Sacred Fire Arts, Vermillion Bound Style, Discipline Form: Burst of the Commander
 - Fiery Foxform Augmented Pattern Arts, Unified Cave Style, Legged Fleeting Spearplay Form: Turtle-Drifting Dividing Beam
 - Fiery Height Arts, Crystalline Riding Cave Style, Ravenous Scripture Form: Formless Slip Observing Arm
 - Fiery Hellish Nebula Arts, Finishing Extinguishing White Style, Rampage Form: Six Sacrificing Crown
 - Fiery Kundali Arts, Smashing Hidden Throwing Style, Harmony Form: Six Resting Nail
 - Fiery Luminous Heat Arts, Few Martial Leaves Style, Full Sheet Form: Limitless Touch Descending Quanzhen
 - Fiery Malevolent Balance Arts, Lunar Feral Tablet Style, Crossing Space Form: Sweetened Paralyzing Hands
 - Fiery Perfusion Arts, Sharpened Style, Shattering Icebolt Form: Spanning Things
 - Fiery Piercer Arts, Dividing Pines Style, Destructive Gateways Form: Giant Nether-Carrying Claw
 - Fiery Pinnacle Arts, Apex Distinction Style, Vile Nomad Form: Triple Discipline Unwavering Pyrocascade
 - Fiery Sonata Arts, Abyssal Master Style, Basic Fleche Form: Dual-Pyrocascade Defending Neck
 - Fiery Waltz Arts, Apex Charging Avatar Style, Rebounding Pounce Form: Giant Meridian-Resonating Spirits
 - Final Bloodthristy Fleche Arts, Heartless Violent Wandering Style, Principles Form: Harmonies-Conquering Ancient Truth
 - Final Domination Arts, Fatal Sonic Big Style, Devastating Scale Form: Poison
 - Final Equine Illusion Arts, Virtuous Holy Arching Style, Boundless Warmth Form: Five-Fold Clarity Countering Pack
 - Final Height Arts, Crazy Nefarious Radiance Style, Shroud Form: North of Bone
 - Final Invisible Yin Arts, Chain Style, Downward Center Fiend Form: Dual-Cross Rising Switch
 - Final Manifestations Arts, Blazing Infiltration Style, Repelling Array Form: Giant Weapon-Conquering Pyrocascade
 - Final Meridian Arts, Blooming Encompassing Undivinable Style, Ravenous Archery Form: Rotation
 - Final Pyre Arts, Continuous Fish Style, Merciful Silent Form: Triple Kundali Resisting Suffering
\page

 - Final Rapid Arts, Frosty Nomad Style, Crushes Form: Astral Tempo
 - Final Shroud Arts, Divine Mirror Style, Unified Starvation Form: Reaper Retreating Annihilation
 - Final Trap Arts, Coastal Bind Style, Duck Form: Triple Vajrapani Feinting Shatter
 - Finishing Basic Transformation Arts, Legged Dao Style, Bronze Stealth Form: Six Defending Technique
 - Finishing Block Arts, Full Bamboo Style, Coated Orthodox Form: Triple Fortune Lunging Sections
 - Finishing Bow Arts, Blister Style, Unshakable Featherweight Pyrocascade Form: Web-Gathering Earthly Thunderwake
 - Finishing Graypine Arts, Extinguishing Immortal Sonata Style, Petal Stance Form: Dual-Lightweight Lunging Quell
 - Finishing Heavenly Coral Chackra Arts, Southern Wind Style, Waxing Mind Form: Five-Fold Shade Aiming Prestissimo
 - Finishing Horse Arts, Killing Spring Style, Coral Team Form: Coastal Variation
 - Finishing Nefarious Split Arts, Downward Cawing Shura Style, Twin Vine Form: Triple Vigor Paralizing Realm
 - Finishing Sage Arts, Many Ash Style, Absolute Tong Form: Six Resting Fate
 - Fleeting Adamantine Sufferings Arts, Chaotic Ascension Style, Clarity Form: Constellation of the Orthodox
 - Fleeting Aureate Mysterious Repents Arts, Black Lord Style, Posture Form: Coated Millennium Feinting Eclipse
 - Fleeting Autumn Arts, Corvid Metal Style, Dominating Slip Form: Vajrayana of the True Ceremony
 - Fleeting Circle Arts, Extended Bodhidharma Style, Saint Form: Redemption of the Slip
 - Fleeting Counter Arts, Spectral Orthodox Style, Southern Wandering Prelude Form: Aureate Death Rising Daoist
 - Fleeting Deep Big Sword Arts, Pure Ripple Style, Balanced Formation Form: Five-Fold Sui Concealing Riddle
 - Fleeting Defensive Traceless Enemy Arts, Consciousness Style, 64 Fold Woodland Form: Five-Fold Direction Bowing Ursine
 - Fleeting Earth Arts, Reaction Style, Twin Principles Form: Six Evading Shroud
 - Fleeting Flames Arts, Merciful Hellish Frontier Style, Few Consciousness Form: Dual-Sonata Linking Yang
 - Fleeting Malevolent Advanced Volley Arts, Cursed Onyx Solar Style, True Song Form: Five-Fold Fang Burning Stalwart
 - Fleeting Signless Arts, Prestissimo Style, Reaction Form: Dual-Manifestation Going Storm
 - Fleeting Spinning Phoenix Arts, Apex Light Style, Countless Grip Form: Grand Mental
 - Fleeting Tablet Arts, Final Trap Style, Elusive Wildfire Form: Long-Shaking Undivinable Instance
 - Fleeting Taebaek Arts, Continuous Smoke Style, Elegant Abyssal Nape Form: Giant Things-Rising Exorcism
 - Fleeting Trap Arts, Venomous Moonbeam Style, Sutra Form: Six Dodging Veiled
 - Fleeting Vine Arts, Scripture Style, Illuminating Pure Chin Form: Wild Blossoms Blowing Unity
 - Fleeting Waltz Arts, Trial Style, Coral Quake Form: Rising Toil Flying Prism
 - Fleeting Warfield Arts, Grove Style, Web Form: Unforgiving Prelude Vispering Ursine
 - Flying Aquatic Windswept Arts, Mystic Magnanimous Dual Style, Gallant Spectral Lord Form: Foundation of the Emperor
 - Flying Barrage Arts, Single Rolling Authority Style, Redemption Form: Specter of the Flames
 - Flying Chaotic Endless Claw Arts, Skeletal Trigrams Style, Extended Beggar Form: Dual-Roars Carrying Sheet
 - Flying Devouring Primordial Gate Arts, Wicked Illusory Madness Style, Capped Shura Form: Style
 - Flying Essence Arts, Fleeting Tong Style, Grounded Hellish Thunderclap Form: Death of Trial
 - Flying Glacial Rampage Arts, Grand Repelling Defiers Style, Beasts Form: Spiritual Icebolt
 - Flying Grappling Slayer Arts, Outward Pearl Style, Violent Blessing Form: Unbounded of the Intoxicated Hexablaze
 - Flying Invisible Rampage Arts, Featherweight Immortal Pulse Style, Fertile Twin Infusion Form: Jewel Taking Cry
 - Flying Limbo Arts, Mysterious Frosty Domination Style, Augmented Latch Form: Five-Fold Soft Carrying Lake
 - Flying Marquis Arts, Western Peak Style, Bright Shade Form: Force of the Drift
 - Flying Paladin Arts, Spiritual Kaleidoscope Style, Polar Form: Daoist Twisting Comb
\page

 - Flying Slicing Stream Arts, Shaft Style, Big Thaw Form: Five-Fold Pearl Binding Sound
 - Flying Space Arts, Wandering Facing Downward Style, Lower Vine Form: Violent Spread
 - Flying Trap Arts, Crimson Spanning Grappling Style, Wild Halo Form: Dual-Mental Shifting Chariot
 - Flying Trap Arts, Encompassing Basic Rising Style, Martial Fading Light Form: Ravenous Scheme Shaking Pear
 - Flying Triadic Arts, Northern Warmaster Style, Intoxicated Depth Form: Continuous Waltz Leaping Hell
 - Flying Warriors Arts, Twin Pure Martial Style, Veil Form: Five-Fold Condor Steeled West
 - Forged Black West Arts, Snow Shattering Cleave Style, Perfect Grace Form: Ursine of the Descending Tail
 - Forged Bloodthristy Skull Arts, Grappling Stellar Nefarious Style, North Grasp Form: Bodhidharma-Grounding Full Sword
 - Forged Buddhist Roars Arts, Imperial Bodhidharma Style, Spiraling Gem Lost Form: Triple Mirror Ending Order
 - Forged Center Arts, Dirty Strikes Style, Cardinal Grace Form: Dual-Possession Sacrificing Tablet
 - Forged Contemplate Arts, Infernal Lord Style, Penetrating Prestissimo Form: Rectitude of Blaze
 - Forged Cultivation Arts, Gentle Void Space Style, Jade Commander Form: Dual-Cavern Conquering Haunt
 - Forged Enlightened Frenzy Arts, Bronze Ghostly Root Style, Primordial Violent Manifestation Form: Void of the Countless Roars
 - Forged Mistveil Arts, Eternal Aureate Rising Style, Final Boxing Triple Form: Trigrams
 - Forged Nails Arts, Undivinable Augmented Limitless Style, Distinction Form: Immortal Spirits
 - Forged Nature Arts, Holy Tearing Battle Style, Final Siege Form: Giant Rain-Sharpening Style
 - Forged Qintfade Arts, Lower Heat Style, Trident Form: Triple Advent Burning Eclipse
 - Forged Self Arts, Featherweight Authority Style, Swarm Form: Grappling Palm Fighting Movement
 - Forged Spinning Twin Shadowless Arts, Great Needle Style, Iron Whirling Leech Form: Giant Snakeform-Airsplitting Taming
 - Forged Thousands Arts, Sacred Elusive Grafting Style, Long Form: Six Reflecting Soul
 - Formless Abyssal Block Arts, Capped Spin Style, Infiltration Form: Five-Fold Brook Draining Trail
 - Formless Brilliant Needle Arts, Solar Martial Exorcism Style, Lower Block Form: Five-Fold Haunt Commanding Decree
 - Formless Chariot Arts, Unknowable Ice Style, Killing Triple Form: Tundra-Tangled Luminous Yin
 - Formless Coil Arts, Empty Incineration Style, Extinguishing Scarlet Form: Beak Crushing Authority
 - Formless Death Arts, Governing Sect Style, Disciple Form: Nomad of Echo
 - Formless Elegant Grand Shout Arts, Ravenous Lotus Style, Basic Volcanoes Form: Healing Surface
 - Formless Hands Arts, Unmatched Cinder Style, Guard Form: Six Binding Triadic
 - Formless Infinite Brilliant Flower Arts, Imperial Consciousness Style, Skull Form: Giant Transparency-Tearing Paladin
 - Formless Malignant Arts, Comb Style, Shooting Stunning Thrust Form: Asura of Point
 - Formless Nebula Arts, Corrupted Angel Style, Foundational Waterfall Form: Destiny of the Cold Fist
 - Formless Ripping Book Arts, Extinguishing Claw Style, Viper Form: Six Weakening Mindscape
 - Formless Saving Book Arts, Repelling Wild Earthen Style, Waxing Polarm Form: Unmatched Ridge
 - Formless Sonic Bloody Lord Arts, Great Obsidian Opposition Style, Extra Chill Form: Triple Eclipse Resisting Enlightenment
 - Formless Splitting Assimilation Arts, North Shaolin Style, Unrivaled Warrior Form: Six Drifting Lance
 - Formless Strike Arts, Assaliants Style, Riding Ruin Form: Giant Fist-Ascending Pearl
 - Formless Tai Arts, Sugar Style, Tearing Elements Form: Skeletal Wildfire
 - Formless Unparalleled Shadow Moonbeam Arts, Toxic Immortal Infinite Style, Sealing Shell Form: Windrider of the Center Illuminated
 - Formless Wicked Ascending Gate Arts, Hunyuan Style, Tearing Dragontail Form: Sky-Drifting Immortal Commander
 - Foundational Adaptive Radiant Wall Arts, Heartless Dark Earthly Style, Jade Exchange Form: Giant Things-Traveling Temple
 - Foundational Equine Cosmic Pinnacle Arts, Responsive Illuminating Countless Style, Mystic Dipper Form: Six Dispersing Turtleback
\page

 - Foundational Foxform Aegis Arts, Waning Volcano Style, Nails Form: Serpent Controlling Arhat
 - Foundational Foxform Taiji Arts, Soaring Vairocana Style, Opposition Form: Gorge of the Felling Quartet
 - Foundational Glacial Final Thirst Arts, Infernal Forged Breakout Style, Spanning Responsive Lake Form: Giant Raptor-Evading Shadowless
 - Foundational Karmic Arts, Unshakable Advent Style, Swords Form: Triple God Stabbing Darkwind
 - Foundational Noble Arts, Mystic Canyon Style, Encompassing Shaolin Form: Triple Heaven Dodging Bodhidharma
 - Foundational Rebounding Thaw Arts, Roving Downward Veiled Style, Stellar Temper Form: Wanderer of Fang
 - Foundational Sheet Arts, Moonbeam Style, Spiraling Blood Form: Flameball of Reguard
 - Foundational Stellar Reguard Arts, Hellish Ocean Style, Halo Form: Dual-Fleche Rising Quell
 - Foundational Trio Arts, Azure Indestructible Ember Style, Malevolent Ape Form: Dual-Self Stealing Frontier
 - Foundational Vigor Arts, Many Midsummer Northern Style, Crimson Aureate Halo Form: Posture of Depth
 - Foxform Azure Grounded Grip Arts, Treading Blister Style, Profound Embracing Verdant Form: Rotation of Limbo
 - Foxform Beasts Arts, Aquatic Wandering Ancient Style, Arching Prelude Form: Six Counterattacking Thrust
 - Foxform Beggar Arts, Crash Style, Virtuous Heavenhold Form: Volcano of the Mountian
 - Foxform Brilliant Crimson Ghost Arts, Silver Bloody Few Style, Elusive Sweeping Quick Form: Wandering Advent
 - Foxform Buddhist Moonlit Rotation Arts, Wind Style, Ghostly Spinning Cloak Form: Yang of the Lower Void
 - Foxform Cuts Arts, Flower Style, Spirit Hunyuan Form: Hawkstrider of the Breakout
 - Foxform Cutting Heartless Execution Arts, Adaptive Gentle Fatal Style, Celestial Reaper Form: Triple Nebula Rising Illuminated
 - Foxform Descent Arts, Ghostly Neck Style, Responsive March Form: Dual-Bodhi Surging Constellation
 - Foxform Dividing Waterfall Arts, Stab Style, Aureate Change Form: Hands of the Full Shapeshifter
 - Foxform Earthen Trail Arts, Embracing Heaven Style, Elusive Barrage Form: Downward Statue
 - Foxform Elbow Arts, Assimilation Style, Moonlit Halo Form: Rends of Glow
 - Foxform Fog Arts, Killing Vitality Style, Traversing Devastating Battle Form: Yang Commanding Swords
 - Foxform Indestructible Warfield Arts, Body Style, Boxing Bamboo Form: Dual-Proud Sharpening Possession
 - Foxform Phenomena Arts, Finishing Shadow Dancing Style, Responsive Cascade Form: Hand of the Substitution
 - Foxform Poison Arts, Bloodthristy Team Style, Aquatic Balance Form: Triple Swift Gathering Jewel
 - Foxform Pulse Arts, Extra Dao Style, Metallic Assaliants Form: Unity Reflecting Things
 - Foxform Rhythm Arts, Governing Sonic Rapid Style, Spirit Tidal Drop Form: Forms of the Basic Lattice
 - Foxform Southern Downward Stealth Arts, Overwash Style, Grappling Manifestation Form: Space Revitalizing Polearm
 - Foxform Spear Arts, Crazy Ripping Spanning Style, Infinite Spiritual Swarm Form: Giant Transparency-Weakening Kundali
 - Foxform Spearplay Arts, Spirit Vile Roving Style, Foundational Solar Rends Form: Ancient Advent Stabbing Orthodox
 - Foxform Splitting Imperial Sharpened Arts, Ravenous Interference Style, Giant Torment Form: Golden Thunderbolts Invigorating North
 - Foxform Technique Arts, Mysterious Echo Style, Bow Form: Warmaster of the Legged Judgment
 - Foxform Woods Arts, Coastal Hunyuan Style, Petal Enlightened Shift Form: Dual-Claw Lunging Chariot
 - Frosty Curse Arts, Finger Style, Elusive Slayer Form: Remains-Rising Empty Brush
 - Frosty Mindless Arts, West Style, Perfusion Form: Throw-Dispersing Flying Frontier
 - Frosty Petal Trio Arts, Unrivaled Quanzhen Style, Tearing Tranquil Form: Warriors-Leaping Boxing Intention
 - Frosty Scriptures Arts, Mad Hoarforst Style, Shooting Intoxicated Trigrams Form: Six Rises Illusion
 - Frosty Seal Arts, Dual Things Style, Abyssal Sky Form: Buddha
 - Frosty Stunning Sight Arts, Absolute Exploding Karma Style, Bloody Fog Form: Five-Fold Total Sleeping Realm
 - Frosty Thrust Arts, Rebounding Temper Style, Poisonous Cry Form: Unrestrained-Twisting Wild Nebula
\page

 - Frosty Universal Wounding Circulation Arts, Unparalleled Center Spectral Style, Calm Drowned Form: Five-Fold Weapon Traveling Calamity
 - Frosty Venomous Metallic Cross Arts, Primordial Unified Raptor Style, Harmonious Elegant Defense Form: Five-Fold Assaliants Ascending Warmaster
 - Frosty Yin Arts, Evil Fleche Style, Unrestrained Form: Starvation
 - Frozen Bamboo Arts, Mighty Ink Style, Profound Mysterious Bound Form: Lower Pierces
 - Frozen Basic Marquis Arts, Infinite Dividing Consonance Style, Blessed Ultimate Whip Form: Lightweight-Fighting Mighty Bat
 - Frozen Blooming Rampage Arts, Mysterious Prayer Style, Serene Cardinal Arrow Form: Triple Trident Carrying Momentum
 - Frozen Erupting Cosmic Piercer Arts, Invisible True Leap Style, Absolute Equal Curse Form: Haunt-Tangled Extinguishing Pear
 - Frozen Gallant Mount Arts, Grand Dark Chill Style, Double Radiant Cutter Form: Triple Volley Falling Pearl
 - Frozen Gateways Arts, Constellation Style, Distinction Form: Sonic Lightweight Blowing Surface
 - Frozen Grand Shadowless Arts, Boundless Toxic Moonlit Style, Coastal Eclipse Form: Saving Drift
 - Frozen Leaf Arts, Icy Lance Style, Might Form: Five-Fold Tongue Lunging Daoist
 - Frozen Life Arts, Ultimate Energy Style, Aura Form: Total Cleaving Ruin
 - Frozen Monk Arts, Saving Obsidian Echo Style, Sweeping Foxform Momentum Form: Limitless Moonbeam
 - Frozen Roving Eternal Arts, Flying Timberfall Style, Crimson Fog Form: Bound-Following Aquatic Noble
 - Frozen Secret Weaver Arts, Tidal Lightweight Style, Haunt Form: Triple West Searching Rhythm
 - Frozen Team Arts, Sudden Traditional Secret Style, Disruption Form: Ascent of the Heavenly Intent
 - Full Body Arts, Leaf Style, Equine Step Form: Deities Retreating Devil
 - Full Emerald Warriors Arts, Arhat Style, Infernal Salvation Form: Woodland of the Chill
 - Full Hexablaze Arts, Embracing Principles Style, Wild Bloody Substitution Form: Five-Fold Transformation Tearing Song
 - Full Legged Aquatic Poisons Arts, Finishing Pulse Style, Wild Crazy Opening Form: Deflection of the Single Thread
 - Full Motion Arts, Thunderbolts Style, Southern Glide Form: Five-Fold Kundali Gathering Pear
 - Full Mystic Skull Arts, Continuous Enemy Style, Eastern Outward Defense Form: Marquis Traversing Grove
 - Full Perfect Petal Legacy Arts, Court Style, Gem Karma Form: Wind-Evading Violent Substitution
 - Full Polarm Arts, Onyx Decree Style, Wicked Valley Form: Fish Flowing Touch
 - Full Rebounding Sudden Taibai Arts, Boundless Crusher Style, Illusory Adamantine Stealth Form: Kaleidoscope-Paralyzing Feral Mind
 - Full Sea Arts, Northern Boundless Heritage Style, Ascension Form: Triple Destroyer Paralizing Bone
 - Full Shadow Serene Cage Arts, Hydra Style, Devouring Advanced Touch Form: Giant Acala-Traversing Parallel
 - Full Virtuous Soul Arts, Diving Projectile Style, Center Form: Arhat
 - Full Volley Arts, Rectitude Style, Flesh Form: Triple Posture Surging Chariot
 - Full Warrior Arts, Venomous Guard Style, Universal Gallant Poison Form: Giant Fortress-Enduring Binder
 - Full Wolf Arts, Augmented Rolling Luminous Style, Profound Repents Form: Intention of the Hidden Trio
 - Full Wrath Arts, Shattering Wicked Old Style, Starlit Form: Venomous Tempest Confronting Heat
 - Gallant Ape Arts, Coastal Tidal Momentum Style, Enlightened Radiance Form: Dual-Dipper Slicing Heavenhold
 - Gallant Bright Fate Arts, Rolling Legged Battalion Style, Extra Walk Form: Ember of Eagle
 - Gallant Calamity Arts, Dirty Serene Bolt Style, Ethereal Great Titan Form: Triple Trio Chopping Barrier
 - Gallant Grasp Arts, Arching Triadic Style, Mad Grounded Weaver Form: Six Slicing Pear
 - Gallant Hellish Spirit Moonlight Arts, Splitting Buddha Style, Giant Spring Form: Dual-Venom Resonating Blossoms
 - Gallant Madness Arts, Defensive Mountian Style, Crystalline Vapor Form: Command of Drop
 - Gallant Pyre Arts, Orthodox Style, Undivinable Domination Form: Method Severing Disinterment
 - Gallant Radiance Arts, White Fox Style, Mystic Cardinal Eagle Form: Spiraling Wheel
\page

 - Gallant Sky Arts, Splitting Subduing Enlightened Style, Earthly Gate Form: Dawn Cleaving Pierces
 - Gallant Slayer Arts, Quick Shattering Plume Style, Unveiled Form: Five-Fold Paradise Resting Spearplay
 - Gallant Spring Arts, Primordial Violent Madness Style, Sweeping Spearplay Form: Unity Going Consonance
 - Gallant Surface Arts, Cosmic Limitless Azure Style, Feral Variation Form: Triple Center Slicing Timberfall
 - Gem Cardinal Mothers Arts, Granite Style, Drunken Lost Form: Team-Evading Holy Cavern
 - Gem Deep Fading Counter Arts, Shooting Pierce Style, Luminous Split Form: Triple Substitution Unwavering Energy
 - Gem Ember Arts, Big Interference Style, Riding Flesh Form: Dual-Pear Severing Death
 - Gem Frozen Coated Parallel Arts, Facing Majestic Style, Scarlet Form: Guardian
 - Gem Magnanimous Vitality Arts, Iron Staff Style, Grappling Song Form: Six Sleeping Reaper
 - Gem Outward Obscure Thoughtless Arts, Gentle Needles Style, Countless Twelves Consciousness Form: Six Shifting Millennium
 - Gem Protective Double Parallel Arts, Embracing Moonbeam Style, Charging Swan Form: Fiendish Instance
 - Gem Quick Arts, Boxing Full Roving Style, Essence Form: Six Lunging Whip
 - Gem Rebounding Deflection Arts, Mad Elemental Light Style, Kaleidoscope Form: Five-Fold Resolve Summoning Barrier
 - Gem Repentant Saving Reflect Arts, Shooting Crimson Wild Style, Parallel Avatar Form: Five-Fold Rectitude Rising Lotus
 - Gem Solar Cross Arts, Brilliant Wicked Monk Style, Style Form: Dawn Searching Skills
 - Gem Starlit Arts, Rebounding Shadow Mirage Style, Expansive Emperor Form: Height-Twisting True Winter
 - Gem Stretched Arts, Switch Style, Endless 18 Fold Void Form: Dual-Step Rises Statue
 - Gem Trap Arts, Spectral Thundershock Style, Legged Height Form: Dual-Thunderbolts Matching Projectile
 - Gem Unshakable Responsive Galaxy Arts, Descending Magnanimous Qintfade Style, Protective Ape Form: Five-Fold Cove Fighting Sage
 - Gentle Book Arts, Corvid Southern Chaotic Style, Striking Center Quanzhen Form: Limbo Blowing Soul
 - Gentle Change Arts, Responsive Tearing Aura Style, Pear Form: Trail of the Total
 - Gentle Coated Swan Arts, Foxform Stretched Style, Lake Form: Emptiness
 - Gentle Drunken Grappling Snowlocked Arts, Sealing Crazy Phenomena Style, Perfect Stealth Form: Latch Flowing Comb
 - Gentle Facing Basic March Arts, Unshakable Equal Hydra Style, Grand Daoist Form: Spiritual Chaos Controlling Netherworld
 - Gentle God Arts, Throw Style, Aquatic Drowned Form: Giant Blister-Summoning Tea
 - Gentle Judgment Arts, Dancing Spectral Arhat Style, Blossoms Form: Force of Limbo
 - Gentle Legacy Arts, Steel Style, Jade Wheel Form: Abyssal Manifestations Observing Dance
 - Gentle Monkey Arts, Shooting Smashing Ridge Style, Calm Wraith Form: Walk of the Ascent
 - Gentle Rends Arts, Featherweight Elder Style, Equine Goldsaber Form: Giant Force-Descending Reflect
 - Gentle Scripture Arts, Rotation Style, Devouring Kundali Form: Prelude of the Descending Temper
 - Gentle Shadowless Arts, Exorcism Style, Few Big Tipsy Form: Cultivation of Discipline
 - Gentle Sight Arts, Universal Repentant Protector Style, Crystalline Twin Shaft Form: Five-Fold Spearplay Biting Kick
 - Gentle Sonic Wheel Arts, Ethereal Heartless Disruption Style, Stellar Felling Dust Form: Giant Quartet-Rising Toss
 - Gentle Storm Arts, Poisonous Jewel Style, Descent Form: Nullification-Blazing Stunning Saber
 - Gentle Thrust Arts, Metallic Current Seal Style, Leap Form: Giant Poisons-Crouching Basilisk
 - Gentle Twin Traceless Balance Arts, Consecutive Fish Style, Drunken Metallic Harmony Form: Hands of the Pierces
 - Gentle Void Arts, Waters Style, Dark Taiji Form: Cultivation-Shifting Bloodthristy Needles
 - Ghostly Coastal Quake Arts, Outward Intoxicated Poison Style, Chaotic Spread Form: Sutra Sharpening Latch
 - Ghostly Cutting Wheel Arts, Empty Inferno Style, Profound Devil Form: Five-Fold Sage Aiming Storm
 - Ghostly Discipline Arts, Southern Eruption Style, Malevolent Infiltration Form: Dual-Net Airsplitting Flame
\page

 - Ghostly Eternal Liberated Chin Arts, Extreme Woodland Style, Foxform Mental Form: Rectitude
 - Ghostly Exorcism Arts, Radiant Twin Soaring Style, Authority Form: Six Searing Thoughtless
 - Ghostly Fading Sonic Sight Arts, Thunderclap Style, Crazy Sugar Form: Five-Fold Flames Soaring Vairocana
 - Ghostly Flash Arts, Descending Snakeform Style, Demonic Quick Form: Trill of the Boxing Heat
 - Ghostly Flow Arts, Whirling Switch Style, Burning Family Form: Five-Fold Needle Slicing Pattern
 - Ghostly God Arts, Pyre Style, Gallant Form Form: Illuminated of the Mount
 - Ghostly Heat Arts, Crossing Healing Nefarious Style, Fish Form: Soaring Triangle Retreating Crown
 - Ghostly Ladder Arts, Ancient Divinities Style, Protective Fairy Form: Cobra
 - Ghostly Maiden Arts, Felling Chop Style, Feral Saber Form: Black Nature
 - Ghostly Mystic Ascent Arts, Indestructible United Style, Diving Crusher Form: Six Fighting Silent
 - Ghostly Righteous Unveiled Arts, Spanning Palms Style, Basic Venomous Shockwave Form: Six Paralyzing Duck
 - Ghostly Stream Arts, Demonic Crystalline Onyx Style, Hands Form: Elbow
 - Ghostly Wolf Arts, Exploding Trigrams Style, Brush Form: Five-Fold Radiance Grounding Transformations
 - Giant Dual Triangle Arts, Solar Rampage Style, Governing Finishing Destruction Form: Blade Confronting Cave
 - Giant Extreme Iron Soar Arts, Brilliant Shaft Style, Fiend Form: Phantom
 - Giant Horse Arts, Current Profound Riding Style, Spanning Astral Light Form: Guard of the Trinity
 - Giant Leaves Arts, Jade Pines Style, Obscure Polearm Form: Forms of the Rectitude
 - Giant Lower Shattering Kill Arts, Silver Crane Style, Crossing Height Form: Avatar Poking Toxin
 - Giant Moonbeam Arts, Stunning Thread Style, Basic Lattice Form: Heaven-Fighting Ghostly Suppression
 - Giant Old Vajrayana Arts, Devouring Nomad Style, Merciful Underworld Form: Five-Fold Skull Ensnaring Mastery
 - Giant Onyx Trinity Arts, Subduing Ancient Flameball Style, Mighty Cloak Form: Giant Beak-Aiming Order
 - Giant Pierces Arts, Hidden Prayer Style, Venomous United Form: Suppression Traversing Sisi
 - Giant Responsive Transformation Arts, Onyx Seeds Style, Rebounding Vampire Form: Triple Limbo Cutting Rhythm
 - Giant Shaolin Arts, Mysterious Dominating Fiend Style, Smashing Move Form: Six Attacking Spiral
 - Giant Shockwave Arts, Capped Calm View Style, Endless Wolf Form: Battle of Seal
 - Giant United Arts, Waning Death Style, Double Needles Form: Illuminating Mountain
 - Giant Wolf Arts, Adaptive Aureate Ethereal Style, Condor Form: Sutra of the Style
 - Glacial Block Arts, Taebaek Style, Descending Heavenhold Form: Six Traveling Spirits
 - Glacial Boundless Haunt Arts, Grand Lower True Style, Ethereal Destiny Form: Mist of the Rain
 - Glacial Cascade Arts, Roving Quick Pearlflower Style, Burst Form: Absolute View Emerging Tranquil
 - Glacial Devil Arts, Frozen Living Specter Style, Rising Domain Form: Dual-Deities Evading Zenith
 - Glacial Energy Arts, Absolute Piercer Style, Elegant Maiden Form: Limbo of the Aquatic Devil
 - Glacial Facing Graceful Thousands Arts, Stellar Nether Style, Great Salvation Form: Ladder Invigorating Resolve
 - Glacial Grafting Step Arts, Facing Great Venomous Style, Repelling Frostbite Form: Six Lunging Authority
 - Glacial Lotus Arts, Protective Palm Style, Onyx Intent Form: Foxform Jeweled Cleaving Seal
 - Glacial Parallel Thunderwake Arts, Drunken Martial Venomous Style, Soul Form: Dual-Stalwart Following King
 - Glacial Pear Arts, Shockwave Style, Immortal Ravenous Pearlflower Form: Sufferings
 - Glacial Rampage Arts, Fatal Void Emergence Style, Featherweight Marquis Form: Consciousness of the Battlefield
 - Glacial Sand Arts, Pulse Style, Proud Form: Giant Polar-Counterattacking Illusion
 - Glacial Throw Arts, Ripping Augmented Brilliant Style, Fiery Rapid Form: Interference
\page

 - Glacial Whip Arts, Rising Absolute Waning Style, Soft Form: Throw Traveling Cove
 - Golden Bronze Tearing Deflection Arts, Distinction Style, Full Venomous Lord Form: Glow Drifting Motion
 - Golden Crystalline Riding Claw Arts, Wanderer Style, Bloody Tranquil Form: Encompassing Move
 - Golden Fate Arts, Treading Elemental Polar Style, Illuminating Beak Form: Cage of Road
 - Golden Gem Lance Arts, Slicing Soar Style, Western Embrace Form: Five-Fold Mothers Concealing Malignant
 - Golden Grand Fatal Stealth Arts, Beasts Style, Triadic Form: Space
 - Golden Leniency Arts, Virtuous Dark Pierces Style, Liberated Nape Form: Asterism of the Night
 - Golden Protector Arts, Mad Steel Style, Few Thrust Form: Massacre of the Element
 - Golden Sand Arts, Grafting Myriads Style, North Manipulation Form: Moonlit Shapeshifter
 - Golden Scholar Arts, Unmatched Splitting Extended Style, Balanced Formless Snakeform Form: Repentant Cut Airsplitting Way
 - Golden Soaring Roving Bat Arts, Waltz Style, Skeletal Swift Form: Dual-Vampire Resting Calamity
 - Golden Thunderous Wandering Eruption Arts, Nefarious Block Style, Sonata Form: Cursed Hawk Tangled Roars
 - Golden Tide Arts, Quick Mountian Style, Tearing Polearm Form: Luminous Sharpened
 - Golden Trident Arts, Hellish Self Style, Final Aegis Form: Flow of Bat
 - Golden Unrivaled Shattering Hunyuan Arts, Basic Pure Battalion Style, Limitless Chin Form: Giant Self-Tearing Tipsy
 - Governing Apex Emergence Arts, Empty Self Style, Cut Form: Ultimate Mastery
 - Governing Blaze Arts, Bloodthristy Basic Eternal Style, Trigrams Form: Six Paralizing Plague
 - Governing Capped Quick Cutter Arts, Saber Style, Dancing Vapor Form: Triple Prelude Unwavering Exorcism
 - Governing Deep Kindled Arts, Vermillion Obscure Command Style, Radiant Bat Form: Intoxicated Deities Dodging Elbow
 - Governing Emergence Arts, Treading Emerald Rightful Style, Rising Vairocana Form: Dual-Shout Walking Divinities
 - Governing Extreme Icy Stride Arts, Living Explosion Style, Soaring Glacier Form: Five-Fold Pyrocascade Concealing Skull
 - Governing Firebrand Arts, Perfect Trigrams Style, Skills Form: Stellar Body Covering Road
 - Governing Goldenring Arts, Hellish Rising Interference Style, Cutting Substitution Form: Buddha-Weakening Single Creation
 - Governing Heaven Arts, Rolling Dance Style, Defensive Tang Form: Giant March-Paralyzing Possession
 - Governing Projectile Arts, Contemplate Style, Polarm Form: Charge of Clarity
 - Governing Seaspan Arts, Mirror Style, Apex Clarity Form: Sinister of Vigor
 - Governing Sky Arts, Blooming Poison Style, Obsidian Fury Form: Calamity-Evading Feral Arm
 - Governing Soar Arts, Coated Skills Style, Frosty Thunder Form: Chop Drifting Cut
 - Governing Storm Arts, Astral Spiraling Priest Style, Thunderous Trap Form: Triadic of the Quick Reflection
 - Governing Virtuous Illuminating Fire Arts, Twin Heaven Style, Extra Profound Pierces Form: Rends Paralyzing Sanctum
 - Graceful Blade Arts, Cutter Style, Grounded Army Form: Emptiness of the Outward Walk
 - Graceful Bound Arts, Earthquakes Style, Corrupted Swords Form: Triple Enemies Crushing Plague
 - Graceful Brilliant Parallel Assaliants Arts, Ultimate Gallant Interference Style, Extreme Marquis Form: Six Swaying Mountain
 - Graceful Chill Arts, Absolute Disruption Style, Mysterious Stun Form: Frosty Possession Traveling Bodhi
 - Graceful Destiny Arts, Soaring Metal Style, Continuous Spanning Might Form: Five-Fold Assault Dispersing Realm
 - Graceful Destructive Blazing Eclipse Arts,  Dark Stealth Style, Secret Descending Warrior Form: Giant Infusion-Drifting Soar
 - Graceful Fading Tortoise Arts, Onyx Bodhidharma Style, Fiery Bloody Tablet Form: Taebaek Swirling Monkey
 - Graceful Fleeting Mental Arts, Emerald Opposition Style, Few Adaptive Crows Form: Fish-Ascending Spectral Drift
 - Graceful Inferno Arts, Cold Countless Direction Style, Grand Creation Form: Triple Essence Weakening Madness
 - Graceful Malevolent Perfect Pyrocascade Arts, Extended Chain Style, Elemental Immovable Form: Brush of the Dual Crusher
\page

 - Graceful Mind Arts, Command Style, Imperial Grappling Tail Form: Elbow
 - Graceful Otherness Arts, Mysterious Ethereal Responsive Style, Demonic Inferno Form: Giant Reflection-Countering Breaker
 - Graceful Outward Pulse Arts, Spiraling Big Aquatic Style, Secret Waterfall Form: Total-Countering Ultimate Parallel
 - Graceful Perfect Birthless Temper Arts, Mystic Mirage Neck Style, Infinite Emerald Wanderer Form: Drain-Aiming Wicked Starlight
 - Graceful Ravenous Bear Arts, Infernal Unforgiving Vigor Style, Cawing Surface Form: Five-Fold Veiled Tangled Saber
 - Graceful Sage Arts, Brilliant Spring Style, Ripping Polar Form: Warriors of the Perfect Execution
 - Graceful Stream Arts, Featherweight Crows Style, Living Perfusion Form: Final Judgment Sleeping Darkwind
 - Graceful Substitution Arts, Bloody Spear Style, Aquatic Advanced Curse Form: Giant Sight-Drifting Otherness
 - Graceful Tai Arts, Ripping Creation Style, Bronze Spark Form: Breakthrough of the Brush
 - Grafting Butterfly Arts, Vile Legs Style, Infernal Web Form: Dual-Domain Draining Form
 - Grafting Chaotic Crusher Arts, Serene Lofty Style, Pines Form: Phaseless of the 61st Cut
 - Grafting Comb Arts, Spiraling Astral Traceless Style, Vermillion Breakthrough Form: Netherworld Scorching Thousand
 - Grafting Extended Volcano Arts, Absolute Healing Destructive Style, Aureate Luminous Riddle Form: Dual-Bodhidharma Airsplitting Fury
 - Grafting Fortress Arts, Ripping Fate Style, Capped Sight Form: Adaptive Vampire Rising Vibrant
 - Grafting Foundational Snake Arts, Final Ravenous Shower Style, Treading Radiance Form: Unrestrained of the Bodhidharma
 - Grafting Kill Arts, Forged Secret Pinnacle Style, Northern Outward Cry Form: Trinity Shaking Pack
 - Grafting Light Arts, Shattering Poisonous Swing Style, Splitting Gale Form: Giant Trinity-Binding Chackra
 - Grafting Millennium Arts, Unified Needles Style, Kundali Form: South Binding Snakeform
 - Grafting Mirrored Arts, Serene Grounded Incineration Style, Myriads Form: Redemption of the Horse
 - Grafting Moon Arts, Martial Bite Style, Northern Crazy Wheel Form: Triple Vampire Sacrificing Finger
 - Grafting Obscure Turtle Arts, Saving Barrage Style, Brilliant Warriors Form: Giant Misty-Weakening Windswept
 - Grafting Perfect Invisible Flesh Arts, Splitting Whirlwind Style, Finishing Paladin Form: Dual-South Crouching Meditation
 - Grafting Sea Arts, Felling Suffering Style, Aquatic Possession Form: Enemies of the Stunning Warrior
 - Grafting Sonata Arts, Spiritual Flash Style, Continuous Emperor Form: Execution of the Hunyuan
 - Grafting Swords Arts, Metallic Buddhist Saint Style, Snakeform Form: Giant Poison-Lunging Truth
 - Grafting Tai Arts, Defense Style, Liberated Thunderous Nails Form: Giant Surface-Falling Meridian
 - Grafting Vairocana Arts, Unmatched Rectitude Style, Earthen Sacred Sharpened Form: Web Lunging Annihilation
 - Grafting Wild Foxform Gateways Arts, Dividing Felling Southern Style, Extinguishing Acala Form: Giant Severance-Confronting Incineration
 - Grand Absorption Arts, Responsive Encompassing Repentant Style, Luminous Storm Form: Triple Vitality Rising Waltz
 - Grand Bone Arts, Mad Elusive Calm Style, God Form: Dual-Snakeform Descending Duck
 - Grand Center Arts, Dancing Army Style, Merciful Pinnacle Form: Six Piercing Volley
 - Grand Coastal Hands Arts, Harmonious Earthen Full Style, Twin Roving Embrace Form: Dual-Burst Twisting Fleche
 - Grand Exorcism Arts, Bronze Eternal Style, Great Pearlflower Form: Family Severing Wrath
 - Grand Grappling Earthly Awakening Arts, Skeletal Nebula Style, True Starlight Form: Five-Fold Sky Crouching Hands
 - Grand Midsummer Spirits Arts, Aureate Red Sonata Style, Blessing Form: Frenzy of Tempo
 - Grand Omnidirectional Arts, Wicked Court Style, Diving Elbow Form: Prajna
 - Grand Pure Limitless Chain Arts, Bright Trio Style, Assaliants Form: Giant Needles-Chopping Fortress
 - Grand Roving Aquatic Ascension Arts, Riding Burst Style, Infinite Fiendish Piercer Form: Asura of the Arching Bone
 - Grand Storm Arts, Roving Self Style, Sections Form: Bound Cleaving Protector
 - Grand Tablet Arts, Center Roving Formless Style, Many Touch Form: Vigor of the Giant Destroyer
\page

 - Grand Warmth Arts, Serene Basilisk Style, Great Order Form: Icy Sanctum Crouching Charge
 - Grand White Enlightened Soft Arts, Coral Frenzy Style, Essence Form: Deities of the Profound Song
 - Grand Wolf Arts, Ripple Style, Smashing Vermillion Tipsy Form: Mad Formation
 - Grappling Adaptive Cutter Arts, Cawing Magnanimous Obscure Style, Drunken Sight Form: Absolute Marquis
 - Grappling Ancient Galaxy Arts, Fatal Glacial Earthly Style, Stealth Form: Giant Mothers-Rises Shout
 - Grappling Northern Demon Arts, Timberfall Style, Toxic Frostbite Form: Six Gathering Saber
 - Grappling Retribution Arts, Icy Ascending Mobility Style, Death Form: Phaseless-Blazing Spiraling Life
 - Grappling Spiraling Basilisk Arts, Embracing Slash Style, Countless Radiance Form: Triple Thundershock Paralizing Intention
 - Grappling Switch Arts, Violent Southern Wing Style, Buddhist Heat Form: Slip
 - Grappling Swords Arts, Shroud Style, Apex Pillar Form: Variation of the Momentum
 - Grappling Tranquil Arts, Plume Style, Ember Form: Triple Binder Breaking Taibai
 - Grappling Vairocana Arts, Slicing Martyr Style, Bronze Gateways Form: Five-Fold Snake Linking Leaves
 - Great Blossom Arts, North Style, Foxform Signless Form: Chackra Resisting Trill
 - Great Cultivation Arts, Intoxicated Mirage Augmented Style, Redemption Form: Quanzhen of Prayer
 - Great Explosion Arts, Boxing Grappling Malevolent Style, Felling Whale Form: Possession
 - Great Intention Arts, Forged Chop Style, Embracing Trap Form: Coral Spread
 - Great Mighty Ember Arts, Chaotic Perfect Wandering Style, Spiraling Full Curse Form: Center Skull Stopping Clarity
 - Great Phantom Arts, Cursed Thunderbolts Style, Blister Form: Devouring Deity
 - Great Shooting Solar Graypine Arts, Hellish Abyssal Astral Style, Walk Form: Nebula Ensnaring Star
 - Great Suppression Arts, Destructive Shade Style, Equal Penetration Form: Bind
 - Great Tempest Arts, Healing Spirits Style, Basic Enemies Form: Giant Projectile-Ensnaring Prism
 - Great Virtuous Bloodthristy Qintfade Arts, Unparalleled Switch Style, Elder Form: Cremation
 - Grounded Autumn Arts, Mighty Repelling Killer Style, Bow Form: Shattering Style Going Eternal
 - Grounded Crush Arts, Aquatic Thunder Style, Wild Madness Form: Triple Skill Taking Pearl
 - Grounded Force Arts, Enlightened Tong Style, Golden Whirling Thunder Form: Authority
 - Grounded Parallel Arts, Wounding Consuming Flying Style, Immortal Aquatic Depth Form: Six Twisting Sufferings
 - Grounded Point Arts, Waxing Sutra Style, Righteous Metallic Snakeform Form: Circulation-Following Traceless Infusion
 - Grounded Red Battle Arts, Endless Burst Style, Cold Spiraling Transformation Form: Spark of the Repentant Net
 - Grounded Remains Arts, Merciful Tearing Acala Style, Crossing Consonance Form: Blade of the Cursed Might
 - Grounded Repelling Earthly Soar Arts, Unforgiving Nothingness Style, Full Breakthrough Form: Giant Battlefield-Deflecting Heart
 - Grounded Saving Charge Arts, Blooming Swift Style, Healing Technique Form: Life Cutting Cry
 - Grounded Soar Arts, Augmented Scatter Style, Spectral Blister Form: Army of Crusher
 - Grounded Splitting Drunken Circle Arts, Onyx Venomous Jeweled Style, Petal Enigma Form: Triple Mount Attacking Mothers
 - Grounded Tidal Lance Arts, Penetrating Ravenous Bloodthristy Style, Malevolent Ethereal South Form: Five-Fold Direction Sacrificing Vairocana
 - Harmonious Decree Arts, Charging East Style, Chop Form: Triple Cave Tearing Forest
 - Harmonious Endless Cage Arts, Old Enlightened Redemption Style, Spectral Grace Form: Bear of the Diving Prajna
 - Harmonious God Arts, Birthless Archery Style, Infusion Form: Infinite Hand
 - Harmonious Maiden Arts, Ocean Style, Augmented Assimilation Form: Five-Fold Change Severing Force
 - Harmonious Malevolent Crows Arts, Merciful Final Protective Style, Aquatic Beasts Form: Dao of the Waltz
 - Harmonious Martyr Arts, Sweeping Intoxicated Height Style, Devastating Mirror Form: Wandering Swan Reflecting Myriads
\page

 - Harmonious Merciful Exploding River Arts, Ripple Style, Equine Song Form: Madness of Trio
 - Harmonious North Arts, Finishing Cardinal Flight Style, Blooming Wing Form: Five-Fold Monkey Soothing Zenith
 - Harmonious Path Arts, Elemental Pierce Style, Azure Cinder Form: Sharpened
 - Harmonious Sharpened Arts, Calm Center Red Style, Treading Calamity Form: Dual-Talon Feinting Riddle
 - Healing 36 Fold Undivinable Cyclone Arts, Quick Gallant Saber Style, Dual Fleeting Kaleidoscope Form: Distinction
 - Healing Archery Arts, Brilliant Shroud Style, Erupting Defense Form: Asterism of the Fortune
 - Healing Battle Arts, Outward Righteous Few Style, Tree Form: Beam
 - Healing Charging Shadow Throw Arts, Unified Many Blade Style, Descending Cutting Momentum Form: Dual-Sugar Airsplitting Fairy
 - Healing Commander Arts, Stun Style, Sweeping Sinister Form: Pearl of the Traditional Shura
 - Healing Hidden Fleche Arts, Blazing Repents Style, Ascending Prestissimo Form: Single Rotation
 - Healing Holy Merciful Soar Arts, Slayer Style, Ape Form: Brook of the Thrust
 - Healing Nails Arts, Fiendish Cry Style, Twin Transparency Form: Whip
 - Healing Point Arts, Midsummer Venom Style, Wounding Limbo Form: Skeletal Needles
 - Healing Pounce Arts, Radiant Encompassing Bloody Style, Crossing Bolt Form: Projectile of Pearl
 - Healing Quake Arts, Roving Butterfly Style, Graceful Crusher Form: Deities-Grounding Sudden Master
 - Healing Sanctum Arts, Obsidian Crimson Grand Style, Dividing Saber Form: Giant Mistveil-Tangled Legs
 - Healing Shroud Arts, Defensive Point Style, Nefarious Shapeshifter Form: Pack Shaking Spring
 - Healing Traversing Aquatic Energy Arts, Current Crane Style, Defensive Eternal Form: Butterfly-Leaping Gentle Crown
 - Healing Vine Arts, Brilliant Cosmic Manipulation Style, Obscure Stride Form: Precept
 - Healing Wind Arts, Rolling Trident Style, Grasp Form: Absorption-Fighting Poisonous Cobra
 - Heartless Archery Arts, Woods Style, Spectral Wheel Form: Seeds of Parallel
 - Heartless Bloodstained Double Heat Arts, Finishing Commander Style, Ripping Fleeting Net Form: Plume of the Blessing
 - Heartless Brush Arts, Cursed Stretched Style, Warriors Form: Dual-Creation Surging Necrotoxin
 - Heartless Cutter Arts, Blazing Mobility Style, Splitting Aura Form: Six Crushing Shaolin
 - Heartless Distinction Arts, Shattering Heaven Style, Forged Skull Form: Cloud-Surging Mysterious Heritage
 - Heartless Horse Arts, Steel Style, Wild Formation Form: Giant Lightness-Conquering Meridian
 - Heartless Kick Arts, Mystery Style, Shooting Opposition Form: Marquis of the Corvid Pearlflower
 - Heartless Lofty Arts, Blazing Weapon Style, Destructive Needle Form: Spiritage of the Kindled
 - Heartless Movement Arts, Flying Fairy Style, Felling Demon Form: Giant Dawn-Ascending Lightweight
 - Heartless Siege Arts, Stellar Soaring Pear Style, Beggar Form: Earth of the Hellish Quanzhen
 - Heartless Suffering Arts, Snow Hail Style, Ethereal Glide Form: Five-Fold Reaction Airsplitting Wave
 - Heartless Talon Arts, Rapid Style, Perfect Fleeting Variation Form: Aspects of the Cliff
 - Heartless Throwing Fiery Wall Arts, Demonic Soaring Empty Style, Riding Bodhidharma Form: Giant Hands-Aiming Brook
 - Heartless Treading Drop Arts, Divine Tranquil Style, Asterism Form: Blood Blowing Sect
 - Heartless Tundra Arts, Endless Instance Style, Hidden Condor Form: Triple Triple Commanding Forms
 - Heartless Vile Mighty Dew Arts, Featherweight Augmented Wounding Style, North Form: Giant Mindscape-Linking Remains
 - Heavenly Beasts Arts, Hellish Traceless Style, Secret Foundational Needles Form: Bat-Traversing Extra Mount
 - Heavenly Break Arts, Elegant Mistveil Style, Primordial Ravenous Harmonies Form: Five-Fold Glide Reflecting Web
 - Heavenly Bright Southern Strike Arts, Radiant Ravenous Mental Style, Roving Unbounded Form: Giant Substitution-Biting Glow
 - Heavenly Coated Turtle Arts, Gem Rising Transformations Style, Unforgiving Massacre Form: Chaotic Frontier Carrying Prestissimo
\page

 - Heavenly Giant Evil Flesh Arts, Elegant Snowfall Style, Undivinable Energy Form: Triple Ripple Dodging Taebaek
 - Heavenly Grasp Arts, Yellow Infinite Cry Style, Chill Form: Giant North-Deflecting Madness
 - Heavenly Hidden Throwing Manifestation Arts, Icy Transparency Style, Immortal Unshakable Mistveil Form: Cremation-Soaring Spiraling Tong
 - Heavenly Karma Arts, Balanced Stunning Wall Style, Unrivaled Emergence Form: Liberated Rectitude Stopping Elder
 - Heavenly Legged Heaven Arts, Perfect Dancing Radiance Style, Resolve Form: Plague of the Arrows
 - Heavenly Sealing Crossing Proud Arts, Extra Zenith Style, Enlightened Fist Form: Buddhist Asura
 - Heavenly Silver Triadic Arts, Shattering Touch Style, Self Form: Hidden Stab
 - Heavenly Slash Arts, Icy Spiritage Style, Gallant Needles Form: Twin Marquis Attacking Statue
 - Hellish Burning Midsummer Crushes Arts, Big Splitting Taihua Style, Descending Ursine Form: Giant Signless-Freezing Glide
 - Hellish Cave Arts, Unknowable Rebounding Earthen Style, Unified Saving Blessing Form: Triple Explosion Resonating Domain
 - Hellish Final Whale Arts, Unified Timberfall Style, Giant Netherworld Form: Giant Myriads-Searching Exchange
 - Hellish Old Yin Arts, Deep Endless Protector Style, Cosmic Enemy Form: Web-Tearing Elegant Counter
 - Hellish Point Arts, Empty Consuming Repelling Style, Eastern Clarity Form: Crush of Myriads
 - Hellish Polarm Arts, Intoxicated Turtleback Style, Ultimate Cloak Form: Consecutive Arhat
 - Hellish Rivers Arts, Mystery Style, Snow Torment Form: Perfusion
 - Hellish Scheme Arts, Great Deities Style, Dominating Interference Form: Sun of the Palm
 - Hellish Serene Leniency Arts, Invisible Pearlflower Style, Eternal Governing Kick Form: Shatter Bowing Waters
 - Hellish Spring Arts, Demon Style, Destroyer Form: Five-Fold Graypine Matching Infusion
 - Hellish Triangle Arts, Corvid Spiritage Style, Iron Throw Form: Giant Scriptures-Weakening Swarm
 - Hidden Block Arts, Emerald Merciful Felling Style, Pure Righteous Palm Form: Shapeshifter of the Spirit Archery
 - Hidden Dominating Destruction Arts, Extinguishing Trial Style, Unshakable Ocean Form: Wandering Stealth
 - Hidden Eternal Sacred Plague Arts, Rolling Dominating Meridian Style, Intention Form: Giant Beasts-Vispering Wheel
 - Hidden Fall Arts, Ghostly Meridian Style, Ripping Thundershock Form: Giant Shadowless-Slicing Scriptures
 - Hidden Heartless Full Clouds Arts, Obscure Diving Unveiled Style, Ascent Form: Six Descending United
 - Hidden Height Arts, Black Shaft Style, Elemental Bright Sky Form: Giant Guardian-Poking Lofty
 - Hidden Incineration Arts, Lower Mastery Style, Shift Form: Six Dodging Consciousness
 - Hidden Redemption Arts, Destiny Style, Cawing Cut Form: Crimson Eruption
 - Hidden Severance Arts, Roars Style, Sweeping Emergence Form: Giant Meridian-Rises Slashes
 - Hidden Shout Arts, Giant Pear Style, Bat Form: Windrider of the Repentant Motion
 - Hidden Stab Arts, Mirage Slash Style, Flameball Form: Calm Siege
 - Hidden Swan Arts, Trill Style, Grand Fleeting Pierces Form: Command of Unity
 - Holy Aura Arts, Formless Coral Method Style, Augmented Drop Form: Marquis of the Many Hexablaze
 - Holy Chop Arts, Rolling Spiritual Elemental Style, Sacred Advent Form: Responsive Toss
 - Holy Empty Redemption Arts, Hidden Surface Style, Glide Form: Dual-Salvation Sharpening Dipper
 - Holy Fading Ceremony Arts, Celestial Mist Style, Big Destroyer Form: Distinction of the Shapeshifter
 - Holy Harmonies Arts, Eternal Skeletal Rebounding Style, Foundational Strength Form: Mistveil of Circle
 - Holy Leaf Arts, Celestial Yang Style, Fleeting Scheme Form: Ancient Self Blowing Pines
 - Holy Millennium Arts, Finishing Ancient Chill Style, Spark Form: Six Chopping Shura
 - Holy Petal Awakening Arts, Giant Ravenous Spearplay Style, Posture Form: Point Freezing Enemy
 - Holy Pillar Arts, Warriors Style, Ascension Form: Dual-Eagle Resisting Icebolt
\page

 - Holy Qintfade Arts, Roving Gentle Azure Style, Ghostly Nothingness Form: Moonlight of Light
 - Holy Quick Madness Arts, Arching United Style, Governing Wall Form: Quake Covering Blade
 - Holy Ripping Turtleback Arts, Jade Lost Style, Earthly Boulder Form: Leniency
 - Holy Script Arts, Consecutive Encompassing Void Style, Old Constellation Form: Guardian-Fighting Pure Kundali
 - Holy Starlit Arts, Whirling Blaze Style, Thunderous Return Form: Life of the Unrestrained
 - Holy Verdant Arts, Featherweight Polarm Style, Coated Myriads Form: Dual-Starlight Fighting Web
 - Holy Whirlwind Arts, Protective Reflection Style, Arching Tree Form: Illuminating Heavenhold Enduring Defense
 - Icy Abyssal Universal Ceremony Arts, Dirty Thunderous Feral Style, Shattering Swift Form: Many Unity Tearing Parallel
 - Icy Beak Arts, Double Sudden Crazy Style, Mirage Petal Spark Form: Triple Neck Counterattacking Karma
 - Icy Blooming Throwing Infiltration Arts, Destructive Starlight Style, Magnanimous Polar Form: Giant Tranquil-Coiling Proud
 - Icy Brook Arts, Unknowable Finishing Crystalline Style, Devastating Wave Form: Web of Edge
 - Icy Burning Change Arts, Subduing Heat Style, Unparalleled Sweeping Veil Form: Dual-Titan Sharpening Waltz
 - Icy Cloud Arts, Serene Lord Style, Cold Grasp Form: Lance of the Noble
 - Icy Command Arts, Corrupted Bloodthristy Ascending Style, Unmatched Equal Trial Form: Five-Fold Manipulation Descending Sonata
 - Icy Countless Slicing Tea Arts, Skeletal Diving Governing Style, Absolute Origin Form: Swan of the Cleave
 - Icy Destructive Slayer Arts, Skeletal Invisible Stellar Style, Rebounding Awakening Form: Dual-Sui Paralyzing Clouds
 - Icy Devil Arts, Killing Leaves Style, Traditional Body Form: Giant Canyon-Unwavering Wolf
 - Icy Encompassing Spiraling Necrotoxin Arts, Sudden Possession Style, Blazing Crazy Whirlwind Form: Six Cleaving Destroyer
 - Icy Encompassing Talon Arts, Double Mountainous Style, Infinite Protective Nomad Form: Triple Night Vispering Nether
 - Icy Ghostly Fatal Winds Arts, Zen Style, Gentle Wall Form: Giant Origin-Gathering Vajrapani
 - Icy Quick Great Ripple Arts, Adaptive Flight Style, Giant Mastery Form: Misty of the Hydra
 - Icy Range Arts, Bronze Temper Style, Spanning Raven Form: Six Twisting Possession
 - Icy Sight Arts, Giant Surge Style, Penetrating Illusory Rage Form: Giant Pearlflower-Transforming Lake
 - Icy Skeletal Manifestations Arts, Nefarious Destructive Formless Style, Dancing Vermillion Latch Form: Severance of Pyrocascade
 - Icy Vedas Arts, Rivers Style, Aquatic Element Form: Dual-Warmaster Countering Ripple
 - Illuminating 48th Violent Lightweight Arts, Azure Dance Style, Extreme Destruction Form: Kaleidoscope Attacking Eternal
 - Illuminating Ash Arts, Liberated Crusher Style, Brilliant Skills Form: Eternal
 - Illuminating Basilisk Arts, 82 Fold Many United Style, Bone Form: Disinterment of the Sacred Disciple
 - Illuminating Bear Arts, Exchange Style, Tearing Devil Form: Six Unwavering Drop
 - Illuminating Flower Arts, Hellish Soaring Woods Style, Great Stretched Form: Giant Leaves-Sharpening Pine
 - Illuminating Hawk Arts, Ultimate Body Style, Zenith Form: Five-Fold Waters Burning Chain
 - Illuminating Kill Arts, Spiraling Encompassing Spanning Style, Wicked Chop Form: Advanced Veiled
 - Illuminating Lightweight Arts, Foundational Parallel Style, Team Form: Extreme Trigrams
 - Illuminating Nail Arts, Maiden Style, Ultimate Wild Manipulation Form: Malevolent Demon
 - Illuminating Quick Cliff Arts, Cosmic Penetration Style, March Form: Crushes of the Fatal Pearlflower
 - Illuminating Raptor Arts, Crimson Serene Trigrams Style, Traditional Inferno Form: Domain
 - Illuminating Redemption Arts, Crossing Starlit Style, Traversing Ink Form: Thunderclap
 - Illuminating Sonata Arts, Sweeping Twin Heavenly Style, Plume Form: Expansive Stealth Biting Beasts
 - Illuminating Unshakable Brilliant Flow Arts, Blooming Enlightenment Style, Feral Snake Form: Ruin of Sweetened
 - Illusory Bodhidharma Arts, Emerald Obsidian Windswept Style, North Brilliant Chackra Form: Space of the Invisible Blossom
\page

 - Illusory Disruption Arts, Boxing Cutting Depth Style, Crystalline Thunderclap Form: Circulation of the Martial Taibai
 - Illusory Earthly Taihua Arts, Crimson Team Style, Shattering Fortress Form: Six Drifting Body
 - Illusory Fairy Arts, Embracing Vitality Style, Stellar Glacier Form: Lightness of the Corvid Command
 - Illusory Might Arts, Center Style, Azure Volcano Form: Six Traveling Piercer
 - Illusory Mighty Fox Arts, Unparalleled Pillar Style, Monastery Form: Battalion of the Phoenix
 - Illusory Poisonous Reaction Arts, Cosmic Intention Style, Punch Form: Dual-Underworld Slicing Water
 - Illusory Silver Brook Arts, Full Stab Style, Enlightened Point Form: Tearing Edge
 - Illusory Snakeform Arts, Snow Bloodstained Dark Style, Extra Triadic Form: Five-Fold Beast Conquering Frenzy
 - Illusory Snow Eternal Counter Arts, Foundational Apex Divinities Style, Gem Nebula Form: Dual-Ascent Biting Technique
 - Illusory Spanning Silver Snakeform Arts, Unrivaled Bite Style, Chaotic Stance Form: Five-Fold Wrath Weakening Elbow
 - Illusory Taming Arts, Traversing Unknowable Shield Style, Fairy Form: Madness of the Gentle Blister
 - Illusory Toxic Drop Arts, Solar Death Style, Treading Cloak Form: Spring Invigorating Thirst
 - Immortal Absolute Vampire Arts, Evil Undivinable Scheme Style, Extended Turtle Form: Projectile Cleaving Emperor
 - Immortal Beasts Arts, Facing Infernal Traceless Style, Boundless Warfield Form: Six Shattering Mist
 - Immortal Exploding Fading River Arts, Enlightened Downward Adaptive Style, Violent Hawkstrider Form: Infusion
 - Immortal Fiendish Void Waterfall Arts, Invisible Suffering Style, Formless Ink Form: Bat
 - Immortal Forms Arts, Copper Golden Southern Style, Skeletal Phaseless Form: Six Following Interference
 - Immortal Origin Arts, Malevolent South Style, Demonic Wild Myriads Form: Giant Sutra-Stealing Truth
 - Immortal Spring Arts, Throwing Single Aspects Style, Old Army Form: Leaves Concealing Beasts
 - Immortal Thunderbolt Arts, Killing Assimilation Style, Boxing Righteous Wheel Form: Hellish Spiritage
 - Immortal Toxin Arts, Bloodstained Frozen Dividing Style, Extended Millennium Form: Five-Fold Fiend Sleeping Resonance
 - Imperial Battlefield Arts, Resolve Style, Ravenous Wandering Chariot Form: Dual-Mastery Steeled Storm
 - Imperial Black Hydra Arts, Contemplate Style, Universal Shroud Form: Feral Thousands
 - Imperial Chaotic Earthen Bolt Arts, Vile Double Shadow Style, Dark Ripping Legacy Form: Triple Quanzhen Soothing Force
 - Imperial Cleave Arts, Facing Arching Thaw Style, Limitless Seaspan Form: Fang-Sleeping Sealing Vibrant
 - Imperial Element Arts, Undivinable Finishing Feral Style, Buddhist Icy Instance Form: Six Stabbing Polarm
 - Imperial Gem Traditional Rampage Arts, Frosty Realm Style, Absolute Wheel Form: Chop
 - Imperial Hellfire Arts, Hunyuan Style, Magnanimous Crazy Crow Form: Toxic Inferno Resonating Stretched
 - Imperial Madness Arts, Blazing Invisible Orthodox Style, Universal Legs Form: Dual-Death Paralizing Ruin
 - Imperial Mirage Tipsy Arts, Bright Embrace Style, Mountain Form: Scale of the Quartet
 - Imperial Mobility Arts, Calm Majestic Style, Onyx Barrier Form: Darkwind-Carrying Repentant Goldenring
 - Imperial Perfect Heavenhold Arts, Grafting Sutra Style, Heaven Form: Scripture of Tremor
 - Imperial Pyrocascade Arts, Frozen Sutra Style, Destructive Grace Form: Dual-Emptiness Paralizing Punch
 - Imperial Radiant Ghostly Poison Arts, Wicked Stretched Style, Encompassing Sonic Moonbeam Form: Triple Soul Linking Clarity
 - Imperial Skills Arts, Extinguishing Divinities Style, Dust Form: Chill of Tipsy
 - Imperial Southern Destruction Arts, Elements Style, Unified Saint Form: Triple Temper Swaying Thrust
 - Imperial Stream Arts, Riding Stunning Snake Style, Throw Form: Solar Domination
 - Imperial Touch Arts, Repelling Switch Style, Stellar Zen Form: Mirrored
 - Imperial Undivinable Shaolin Arts, Priest Style, Equine Toss Form: Truth of the Pines
 - Imperial Woods Arts, Drunken Big Polarm Style, Living Stealth Form: Angel of the Mothers
\page

 - Imperial Yang Arts, Adamantine Marquis Style, Sweeping Eagle Form: Apex Nebula
 - Indestructible Bloodthristy Charging Trio Arts, Gallant Wall Style, Daoist Form: Illusory Silent Revitalizing Lofty
 - Indestructible Chaotic Tidal Stride Arts, Gallant Suppression Style, Waning Advanced Cry Form: Dual-Man Tangled Remains
 - Indestructible Corrupted Motion Arts, Rising Wildfire Style, Endless Suffering Form: Triple Family Piercing Reflection
 - Indestructible Curse Arts, Devastating Ceremony Style, Things Form: Firebrand-Traversing Mysterious Mobility
 - Indestructible Dark Rightful Sword Arts, Toxic True Ancient Style, Treading Meridian Form: Forged Element Vispering Asura
 - Indestructible Dawn Arts, Frozen Plume Style, Frosty Condor Form: Net of Dance
 - Indestructible Downward Patriarch Arts, Augmented Boxing Eternal Style, Living Mystery Form: Five-Fold Thousands Carrying Shadowy
 - Indestructible Dragontail Arts, Giant Awakening Style, Blessing Form: Giant Penetration-Poking Wraith
 - Indestructible Energy Arts, Silver Ripple Style, Traversing Fortress Form: Venomous Balance
 - Indestructible Fleeting Statue Arts, Gem Dominating West Style, Forged Star Form: Riddle of the Sect
 - Indestructible Hellfire Arts, Encompassing Pear Style, Imperial Diving Pearlflower Form: Volcano of the Taebaek
 - Indestructible Incineration Arts, Traditional Sharpened Style, Emergence Form: Giant Pyre-Dispersing Crown
 - Indestructible Moonbeam Arts, Liberated Thunderwake Style, Luminous Drift Form: Turtleback Burning Daoist
 - Indestructible Mystic Wicked Overwash Arts, Final Graceful Spiraling Style, Toxic March Form: Stroke Revitalizing Netherworld
 - Indestructible Penetration Arts, Corvid Parallel Style, Traceless Primordial Maelstrom Form: Basilisk Conquering Star
 - Indestructible Piercer Arts, Cardinal Snowfall Style, Quick Projectile Form: Avatar-Twisting Traversing Misty
 - Indestructible Rectitude Arts, Devouring Paradise Style, Pillar Form: Six Flowing Repents
 - Indestructible Rivers Arts, Penetrating Energy Style, Rain Form: Death of the Celestial Rage
 - Indestructible Skeletal Condor Arts, Throwing Star Style, Toxic Unshakable Vairocana Form: Scriptures of Distinction
 - Indestructible Strikes Arts, Ghostly Traceless Style, Petal Karmic Form: Dual-Daoist Searching Rampage
 - Indestructible Throwing Bat Arts, Diving Flower Style, Hellish Fang Form: Rightful Whip Draining Awakening
 - Indestructible Trio Arts, Taiji Style, Tablet Form: Stride of the Shaolin
 - Indestructible Turtleback Arts, Gentle Crown Style, Dominating Nullification Form: Thousands Observing Staff
 - Infernal Bird Arts, Talon Style, Smashing Scholar Form: Snakeform Revitalizing Moonlight
 - Infernal Breaker Arts, Pack Style, Barrage Form: Stride Sleeping Frost
 - Infernal Divine Unparalleled Graypine Arts, Expansive Great Point Style, Deep Acala Form: Suffering
 - Infernal Featherweight Arching Pillar Arts, Aquatic Blazing Shadow Style, Dirty Dominating Harmonies Form: Stun of the Massacre
 - Infernal Fist Arts, Signless Style, Venomous Circulation Form: Pines-Flowing White Dew
 - Infernal Prism Arts, Wounding Guard Style, Protective Lance Form: Drift-Sacrificing Repentant Proud
 - Infernal Unparalleled Wing Arts, Gallant Absorption Style, Ultimate Statue Form: Triple Raptor Gathering Radiance
 - Infinite Ancient Illusory Warrior Arts, Fertile Vairocana Style, Snakeform Form: Resolve-Weakening Equal Karmic
 - Infinite Devouring Calm Starlit Arts, Extinguishing Fury Style, Sugar Form: Triple Earthquakes Leaping Prestissimo
 - Infinite Erupting Wicked West Arts, Intoxicated Responsive Stellar Style, Wounding Absorption Form: Triple Tipsy Matching Interference
 - Infinite Fiend Arts, Governing Riddle Style, Downward Phantom Form: Toil of the Northern Ladder
 - Infinite Fortress Arts, Astral Ghost Style, Felling Plume Form: Triple Gust Burning Strikes
 - Infinite Roving Infusion Arts, Coral Elusive Statue Style, Gem Shura Form: Five-Fold Plate Evading Cosmos
 - Intoxicated  Parallel Water Arts, Bloody Martial Intention Style, Fiendish Many Sugar Form: Height of the Volley
 - Intoxicated Ape Arts, Basic Trident Style, Shadow Thrust Form: Dual-Realm Invigorating Form
 - Intoxicated Battlefield Arts, Obsidian Explosion Style, Cosmic Dipper Form: Five-Fold Basilisk Tearing Cosmos
\page

 - Intoxicated Brilliant Fire Arts, Downward Descent Style, Poisonous Maiden Form: Limitless Team Stealing Toss
 - Intoxicated Drunken Finishing Sinister Arts, Double Emptiness Style, Red Feral Shield Form: Dual-East Resonating Mirror
 - Intoxicated Fiend Arts, Stunning Cursed Might Style, Claw Form: Battalion of Quake
 - Intoxicated Monastery Arts, Parallel Fiendish Advent Style, Waxing Cardinal King Form: Fortune of Shaolin
 - Intoxicated Northern Spanning Millennium Arts, Elegant Tearing Spin Style, Lower Authority Form: Polarm-Leaping Secret Depth
 - Intoxicated Roving Moonlit Mountain Arts, Formless Net Style, Slicing Liberated Fortune Form: Heaven
 - Intoxicated Shattering Corvid Rapid Arts, Creation Style, Cry Form: Five-Fold Discipline Freezing Thread
 - Intoxicated Stance Arts, Fatal Perfusion Style, Endless Woods Form: Sufferings of Clarity
 - Intoxicated Sweep Arts, Bloodstained Erupting Total Style, Void Mad Weaver Form: Space
 - Intoxicated Tai Arts, Killing Rampage Style, Man Form: Six Poking Skill
 - Invisible Blade Arts, Downward Few Unmatched Style, Dominating Perfect Variation Form: Graceful Net Drifting Cloak
 - Invisible Blister Arts, Encompassing Heart Style, Binder Form: Apex Finger Sacrificing Claw
 - Invisible Disruption Arts, Technique Style, Petal Aspects Form: Five-Fold Woodland Paralizing Script
 - Invisible Emerald Curse Arts, Arching Unshakable Sweeping Style, Petal Fortress Form: Grand Mind Grounding Shura
 - Invisible Emptiness Arts, Big Intoxicated Extra Style, Striking Defensive Deity Form: Dual-Wanderer Commanding Arhat
 - Invisible Enemies Arts, Advanced Domain Style, Celestial Crimson Crush Form: Six Vispering Thundershock
 - Invisible Extra Responsive Canyon Arts, Illusory Cawing Wall Style, Big Palm Form: Latch of Phantom
 - Invisible Illuminated Arts, Shatter Style, Rightful Necrotoxin Form: Throw-Following Poisonous Breakout
 - Invisible Maiden Arts, Variation Style, Wounding Divine Domain Form: Bear-Shattering Whirling Enigma
 - Invisible Polarm Arts, Legged Sweeping Storm Style, Adaptive Strike Form: Giant Annihilation-Leaping Beggar
 - Invisible Stroke Arts, Ascending Aquatic Disciple Style, Forged Obsidian Illusion Form: Six Lunging Formation
 - Invisible Swarm Arts, Slicing Sutra Style, White Diving Flow Form: Talon
 - Invisible Taihua Arts, Traversing Sections Style, Enlightened Steps Form: Unity Ascending Claw
 - Invisible Thundershock Arts, Protective Grappling Domain Style, Wild Wrath Form: Triple Light Breaking Overwash
 - Invisible Yellow Finishing Tipsy Arts, Unknowable Big Elegance Style, Elemental Salvation Form: Five-Fold Interference Matching Sanctum
 - Iron Buddhist Ocean Arts, Bloodstained Spiraling Momentum Style, Move Form: Prajna of the Tearing Warrior
 - Iron Coral Volcanoes Arts, Wild Halo Style, Diving Barrier Form: Giant Shadowless-Falling Staff
 - Iron Delights Arts, Bloodstained Toss Style, Devil Form: Beggar-Airsplitting Shadow Beasts
 - Iron Fairy Arts, Mystic Few Distinction Style, Gentle Halo Form: Guardian of Rage
 - Iron Kindled Arts, Edge Style, Big Undivinable Return Form: Triple Sheet Stealing Path
 - Iron Kings Arts, Exploding Trap Style, Ghostly Boundless Soar Form: Blood Piercing Chain
 - Iron Mount Arts, Pure Parallel Stun Style, Fading Reflect Form: Chaos of the Army
 - Iron Reflection Arts, Striking Things Style, Blessed Substitution Form: Giant Domain-Paralizing Asura
 - Iron Riding Shaft Arts, Daybreak Style, Foxform Web Form: Giant Phantom-Commanding Breakthrough
 - Iron Saber Arts, Jade Countless Phaseless Style, Facing Sections Form: Five-Fold Unveiled Counterattacking Wanderer
 - Iron Sharpened Arts, Infernal Switch Style, God Form: Triple Rapid Evading Grip
 - Iron Skills Arts, Illuminating Sharpened Style, Sudden Strike Form: Paradise of Tiger
 - Iron Thousands Arts, Countless Triadic Style, Cutting Movement Form: Five-Fold Vitality Linking Deity
 - Iron Timberfall Arts, Hidden Descending Consuming Style, Scale Form: Netherworld-Cleaving Martial Walk
 - Iron Unity Arts, Grounded View Style, Downward Monk Form: Coral Spin
\page

 - Iron Venom Arts, Copper Warfield Style, Sevens Shade Form: Ripple-Retreating Gallant Galaxy
 - Iron Vine Arts, Elemental Crimson Fleeting Style, Venomous Dawn Form: Triple Darkwind Bowing Delights
 - Jade Cawing Death Arts, Coastal East Style, Continuous Spike Form: Nomad of the Righteous Weapon
 - Jade Consecutive Shower Arts, Venom Style, Expansive Horse Form: Eternal Projectile
 - Jade Cutting Enlightened Trident Arts, Spirit Sinister Style, Southern Walk Form: Unrivaled Volcano Poking Whip
 - Jade Dragon Arts, Old Polar Style, Decree Form: Six Going Manifestation
 - Jade Earthen Abyssal Opening Arts, Mirage Cawing Wraith Style, Chaotic Forged Domain Form: Triple Trinity Slicing Bodhi
 - Jade God Arts, Dark Shadowy Style, Snow Bloodthristy Sand Form: Surface
 - Jade Illusory Shroud Arts, Waxing Luminous Ripping Style, Pyre Form: Sharpened of Daoist
 - Jade Noble Arts, Riddle Style, Old Dipper Form: Depth
 - Jade Obscure Daybreak Arts, Martial Heaven Style, Thunderclap Form: Dual-Fortress Carrying Stalwart
 - Jade Radiant Onyx South Arts, Tidal Crazy Absolute Style, Harmonious Extinguishing Nullification Form: Continuous Strength Twisting Turtle
 - Jade Song Arts, Repelling Stab Style, Abyssal Quell Form: Dual-Pyrocascade Revitalizing Polarm
 - Jade Step Arts, Thunderous Emperor Style, Flying Things Form: Cloak of the Obsidian Variation
 - Jade Whirling Calamity Arts, Body Style, Vapor Form: Demon of the Bloodstained Maelstrom
 - Killing Black Healing Guard Arts, Fatal Reaper Style, Luminous Descending Things Form: Dual-Stance Emerging Resonance
 - Killing Blood Arts, Crusher Style, Moonlit Descending Dao Form: Bone Blazing Venom
 - Killing Crossing Net Arts, Adamantine Orthodox Style, Quartet Form: Big Circle
 - Killing Distinction Arts, Spiritual Windrider Style, Smashing God Form: Kindled-Grounding Sweeping Commander
 - Killing Enlightened Lofty Arts, Aquatic Capped Ascending Style, Universal Heaven Form: Dual-Beasts Paralyzing Vigor
 - Killing Grappling Azure Vine Arts, Solar Exchange Style, Ascent Form: Profound Frenzy
 - Killing King Arts, Riding Ridge Style, Embrace Form: Liberated Qintfade
 - Killing Legs Arts, Snowfield Style, Living Foxform Consciousness Form: Authority of the Starlit
 - Killing March Arts, Shadow Azure Center Style, Repelling Nomad Form: Soar-Confronting Sweeping Fang
 - Killing Pyrocascade Arts, Onyx Spring Style, Destiny Form: Giant Transparency-Blowing Delights
 - Killing Sonic Discipline Arts, Birthless Pillar Style, Foxform Leaf Form: Subduing Limbo
 - Killing Spearplay Arts, Stealth Style, Bamboo Form: Lord-Biting Ancient Proud
 - Killing Stomp Arts, Spiraling Haunt Style, Augmented Manipulation Form: Dual-Assimilation Raining Quell
 - Killing Unified Illuminating Array Arts, Traceless Soaring Downward Style, Sonic Intoxicated Hell Form: Triple Winds Searing Blood
 - Killing Whale Arts, Unshakable Downward Calamity Style, Principles Form: Six Revitalizing Spearplay
 - Legged Bamboo Arts, Corvid Spectral Hellish Style, Illusory Mountian Form: Five-Fold Fate Tearing Fang
 - Legged Flow Arts, Rightful Sharpened Style, Intention Form: Dual-Elements Stopping Total
 - Legged Imperial Snowfield Arts, Long Style, Invisible Crusher Form: Beam Following Arrow
 - Legged Jade Deflection Arts, Thunderous Chin Style, Spiraling Scripture Form: Mountian Invigorating Guard
 - Legged Malevolent Graceful Resolve Arts, Rocky Style, Fertile Kick Form: Spear of Latch
 - Legged Monastery Arts, Radiant Luminous Boxing Style, Erupting Sufferings Form: Echo of the Starlight
 - Legged Origin Arts, Cardinal Vermillion Priest Style, Charging Tearing Serpent Form: Leniency
 - Legged Repents Arts, Tremor Style, Gentle Distinction Form: Five-Fold Lotus Twisting Rhythm
 - Legged Spearplay Arts, Blazing Scholar Style, Liberated Asterism Form: Giant Warrior-Resisting Pearlflower
 - Legged Tremor Arts, Ink Style, Single Flight Form: Giant Emptiness-Leaping Mountian
\page

 - Legged View Arts, Spectral Stunning Crossing Style, Illuminating Consecutive Pulse Form: Kindled-Linking Ripping Reaction
 - Liberated Arrows Arts, Evil Glacial Unshakable Style, Killing Primordial Authority Form: Basic Glide Flowing Warmaster
 - Liberated Bloodstained Parallel Enemies Arts, Stunning Breeze Style, Governing Taihua Form: Tong of the Nefarious Family
 - Liberated Brilliant Shapeshifter Arts, Gentle Onyx Crusher Style, Shooting Stroke Form: Leniency
 - Liberated Elemental Waning Penetration Arts, Wanderer Style, Devastating Harmonies Form: Style of Stalwart
 - Liberated Granite Arts, Boundless Traceless Crusher Style, Mysterious Responsive Bone Form: Triple Shroud Coiling Pearlflower
 - Liberated Healing Profound Bone Arts, Bronze Pearlflower Style, Fiery Cardinal Sight Form: Triangle
 - Liberated Heartless Frozen Center Arts, Direction Style, Demonic Commander Form: Sonic Scatter Lunging Waterfall
 - Liberated Hellish Cold Mountainous Arts, Imperial Manifestation Style, Mad Divinities Form: Grappling Otherness
 - Liberated Indestructible Corrupted Venom Arts, Tidal Constellation Style, Expansive Wicked Counter Form: Reaper of Palm
 - Liberated Needles Arts, Unrivaled Intoxicated Moonlit Style, Waning Bat Form: Five-Fold Surface Surging Gust
 - Liberated Shadow Stretched Arts, Hidden Pear Style, Grand Stealth Form: Snowfield of the Living Eruption
 - Liberated Slash Arts, Extended Violent Erupting Style, Infinite Divinities Form: Triple Fiend Invigorating Fate
 - Liberated Snow Bloodstained Fleche Arts, Sheet Style, Nefarious Binder Form: Giant Shaft-Tangled Lotus
 - Liberated Spear Arts, Thunderous Sui Style, Living Timberfall Form: Sound of the Southern Opposition
 - Liberated Spiral Arts, Scale Style, Formless Total Form: Expansive Shapeshifter Resisting Kaleidoscope
 - Liberated Unrivaled Severance Arts, Unveiled Style, Divine Waltz Form: Coated Mindscape
 - Liberated Valley Arts, Shade Style, Charging Limbo Form: Fang of the Throw
 - Limitless Barrier Arts, Sudden Command Style, Spinning Flow Form: Five-Fold Riddle Defending Bind
 - Limitless Consonance Arts, Continuous Assaliants Style, Violent Blazing North Form: Comb of the Cuts
 - Limitless Feather Arts, Aureate Chin Style, Sealing Sacred Frenzy Form: Contemplate of Crown
 - Limitless Heavenly Countless Duck Arts, Ravenous Outward Corvid Style, Penetrating Distinction Form: Dual-Stroke Biting Cutter
 - Limitless Illuminated Arts, Copper Manifestations Style, Might Form: Five-Fold Snakeform Sleeping Penetration
 - Limitless Many Formless Hail Arts, Touch Style, Deep Aegis Form: Assimilation of the Warfield
 - Limitless Nether Arts, Thunderous Grip Style, Crossing Mount Form: Five-Fold Beast Stabbing Meditation
 - Limitless Ravenous Astral Shadowy Arts, Drunken Invisible Shift Style, Poisonous Advanced Wisdom Form: Calamity of the Erupting Jewel
 - Limitless Triadic Arts, Shooting Refraction Style, Siege Form: Snake
 - Limitless Ultimate Extreme Qintfade Arts, Unmatched Mad Skeletal Style, Harvest Form: Ethereal Hit Twisting Rectitude
 - Limitless Vajrapani Arts, Western Facing Toil Style, Liberated Wheel Form: Sanctity of the Balance
 - Limitless Wave Arts, Equine Ocean Style, Momentum Form: Giant Venom-Gathering Asura
 - Living Coil Arts, Azure Gateways Style, Blessed Majestic Form: Scripture
 - Living Coral Full Stalwart Arts, Mirage Battle Style, Boundless Equal Clouds Form: Six Tangled Transparency
 - Living Diving Shura Arts, Boxing Awakening Style, Unparalleled Adamantine Mirror Form: Triple Pillar Concealing Decree
 - Living Drift Arts, Karma Style, Mountain Form: Giant Wrath-Gathering Specter
 - Living Elusive Glow Arts, Capped Lower Ancient Style, Vile Smoke Form: Tail
 - Living Holy Crossing Deflection Arts, Perfect Unparalleled Cawing Style, Dual Staff Form: Thunder Reflecting Spark
 - Living Holy Ravenous Glacier Arts, Bow Style, Equine Center Vibrant Form: Army of Parallel
 - Living Mirage Vine Arts, Center Tong Style, Apex Truth Form: Triple Transformations Slicing Windrider
 - Living Rising Legged Body Arts, Daoist Style, Black Warfield Form: Dual-Barrage Aiming East
 - Living Roar Arts, Cardinal Creation Style, Mistveil Form: Seal of the Energy
\page

 - Living Rocky Arts, Endless Crown Style, Moonlight Form: Dual-Resolve Ascending Net
 - Living Sand Arts, Basic Comb Style, Calm Siege Form: Extinguishing Wraith Reflecting Taiji
 - Living Specter Arts, Shattering Transformation Style, Western Comb Form: Breakthrough-Following Dominating Energy
 - Living Tortoise Arts,  Black Giant Style, Drop Form: Aura
 - Living Void Holy Taiji Arts, White Tong Style, Feral Otherness Form: Dual-Nature Ascending United
 - Lower Blessed Drowned Arts, Toxin Style, Hellish Ascending Orthodox Form: Lost
 - Lower Book Arts, Divine Traversing Gallant Style, Lunar Demonic Woods Form: Five-Fold Talon Sharpening Cobra
 - Lower Cyclone Arts, Wild North Style, Ghostly Aura Form: Unshakable Veiled
 - Lower Drain Arts, Burning Flameball Style, Repentant Lofty Form: Aureate Proud Binding Phoenix
 - Lower Martial Omnidirectional Arts, Skull Style, Embracing Return Form: Dual-Resonance Bowing North
 - Lower Mindscape Arts, Equine Resolve Style, Spear Form: Giant Wrath-Flying Remains
 - Lower Responsive North Arts, Equine Chaotic Invisible Style, Gentle Cove Form: Brook
 - Lower Salvation Arts, Arching Shadow Shroud Style, Rebounding Spiritual Gale Form: Space of the Profound Wraith
 - Lower Trident Arts, Command Style, Cosmos Form: Pure Hell Coiling Kindled
 - Luminous Asura Arts, Astral Verdant Style, Secret Holy Raven Form: Triple Noble Cleaving Asterism
 - Luminous Aureate Sacred Lattice Arts, Drunken Kings Style, Cardinal Soft Form: Hellish Hand
 - Luminous Comb Arts, Wounding Balanced Defiers Style, Fading Martial Hell Form: Torment-Severing Empty Needle
 - Luminous Grasp Arts, Lance Style, Aquatic Otherness Form: Six Traversing Volley
 - Luminous Harmonious Night Arts, Forged Unbounded Style, Unmatched Ultimate Ladder Form: Giant Distinction-Countering Heaven
 - Luminous Infernal Unified Malignant Arts, Burning Fading Frontier Style, Illusory Fiery Deity Form: Dual-Tong Soaring Veil
 - Luminous Infusion Arts, Necrotoxin Style, Gem Cosmos Form: Triple Scripture Shifting Kundali
 - Luminous Invisible Summit Arts, Penetrating Wall Style, Repentant Finishing Height Form: Technique of the Grounded Commander
 - Luminous Lord Arts, Crossing Heaven Style, Equine Profound Autumn Form: Dual-Gateways Falling Timberfall
 - Luminous North Arts, Pierce Style, Holy Hellish Vigor Form: Angel Traversing Ruin
 - Luminous Pillar Arts, Midsummer Skeletal Waning Style, Gem Thunderbolts Form: Five-Fold Mental Paralizing Point
 - Luminous Shattering Blooming Sections Arts, Downward Spirit Jeweled Style, Rage Form: Saving Family
 - Luminous Spanning Metallic Sufferings Arts, Waning Eternal 80 Fold Style, Riding Thousands Form: Momentum-Sacrificing Skeletal Scale
 - Luminous Spiritage Arts, Ravenous Infinite Ursine Style, Merciful Thread Form: Coil of Guardian
 - Luminous Thunderous Red Thundershock Arts, Harmonious Reguard Style, Universal Apex Bat Form: Dance of the Southern Shield
 - Lunar Ancient Ethereal Dragon Arts, Chaotic Manifestation Style, Many Palms Form: Yang of the Spiraling Frenzy
 - Lunar Battalion Arts, Yellow Illusory Equine Style, Devouring Statue Form: Dual-Quell Flowing Monkey
 - Lunar Comb Arts, Rolling Statue Style, Jeweled Form: View of Roars
 - Lunar Counter Arts, Bound Style, Throwing Descending Shaft Form: Big Flameball
 - Lunar Dive Arts, Serpent Style, Eastern Explosion Form: Dominating Rampage Piercing Hawk
 - Lunar North Arts, Tearing Bronze Few Style, Rightful Protective Shout Form: Twin Archery Piercing Malignant
 - Lunar Plate Arts, Giant Autumn Style, Obsidian Fortune Form: Five-Fold Drop Gathering Vibrant
 - Lunar Spearplay Arts, Ghostly Asterism Style, Grappling Wounding Pack Form: Nape
 - Lunar Stun Arts, White Embracing Center Style, Ethereal Disruption Form: Motion of the Skeletal Bodhidharma
 - Lunar Tipsy Arts, Expansive Thunderous Equal Style, Cursed Thread Form: Forged Wall
 - Lunar Triangle Arts, Grand King Style, Balanced Manifestations Form: Six Dispersing Scarlet
\page

 - Lunar Trident Arts, Adamantine Trigrams Style, Primordial Pure Bow Form: Five-Fold Paladin Reflecting Prestissimo
 - Lunar Ultimate Breaker Arts, Bloodstained Abyssal Bloody Style, Apex Crow Form: Thousands of Kill
 - Lunar Yin Arts, Smashing Blossom Style, Coated Many Unveiled Form: Giant Thousand-Soothing Snakeform
 - Mad Ancient Prelude Arts, Profound Ascending Reaction Style, Tearing Subduing Cyclone Form: Triple Daoist Resting Enemies
 - Mad Arm Arts, Adaptive Onyx Divine Style, Malevolent Enigma Form: Five-Fold Road Sharpening Transformations
 - Mad Blossom Arts, Healing Daoist Style, Blooming Lotus Form: Chin of the Commander
 - Mad Center Toxin Arts, Pure Countless Prestissimo Style, Light Form: Six Revitalizing Leniency
 - Mad Dirty Water Arts, Omnidirectional Style, Thousand Form: Bite of the Cove
 - Mad Double Cave Arts, Jade Vitality Style, Elegant Cage Form: Final Crane Shaking Dive
 - Mad Heat Arts, Descent Style, Spanning Bodhi Form: Giant Pyre-Aiming Movement
 - Mad Mystic Leniency Arts, Endless Titan Style, Earth Form: Giant Sound-Walking Stab
 - Mad Onyx Nebula Arts, Spirit Angel Style, Buddhist Copper Trap Form: Kick of the Rightful Halo
 - Mad Penetrating Void Kings Arts, Obsidian Throwing Imperial Style, Solar Single Script Form: Dual-Avatar Ending Spin
 - Mad Rectitude Arts, Fiery Granite Style, Spiraling Eternal Form: Ripping Galaxy
 - Mad Rends Arts, Arching Illuminated Style, Consecutive Waters Form: Six Transforming Moonlight
 - Mad Slicing Glacial Circulation Arts, Magnanimous Wild Bloodthristy Style, Encompassing Legged Enemy Form: Skill
 - Mad Sweetened Arts, Capped Living Sacred Style, Emperor Form: Elements
 - Mad Team Arts, Endless Nails Style, Breeze Form: Cut of the Treading Momentum
 - Mad Thunderwake Arts, Riding Celestial Slicing Style, Grip Form: Spiral of the Exorcism
 - Mad Trap Arts, Treading Plate Style, Stunning Taebaek Form: Light
 - Mad Vapor Arts, Crystalline Nails Style, Dark Saint Form: Aura of Meridian
 - Magnanimous Crown Arts, Slicing Gate Style, Fate Form: Triple Bamboo Resting Bird
 - Magnanimous Crystalline Heaven Arts, Undivinable Fairy Style, Bright Pounce Form: Chackra Transforming Ursine
 - Magnanimous Elusive Equine Substitution Arts, Abyssal Enlightenment Style, Self Form: Six Going Way
 - Magnanimous Few Rolling Orthodox Arts, Feral Penetrating Traversing Style, Taihua Form: Exploding Chaos Emerging Ripple
 - Magnanimous Foundation Arts, Old Traditional Wild Style, Red Thundershock Form: Slayer-Flowing Advanced Breaker
 - Magnanimous Incineration Arts, Coastal Moonlight Style, Wounding Massacre Form: Devil of the Outward Frontier
 - Magnanimous Legged True Monastery Arts, Massacre Style, North Thrust Form: Shaolin-Emerging Wounding Command
 - Magnanimous Motion Arts, Extended Quanzhen Style, Featherweight View Form: Coil of Net
 - Magnanimous Prism Arts, Path Style, Emerald Warfield Form: Triple Element Poking Crush
 - Magnanimous Projectile Arts, Void Profound Song Style, Extinguishing Contemplate Form: Coil Swirling Taiji
 - Magnanimous Radiance Arts, Ultimate Trill Style, Enemy Form: Formless Fortress
 - Magnanimous Spearplay Arts, Primordial Trill Style, Unshakable Adamantine Trinity Form: Taihua
 - Malevolent Claw Arts, Bloody Flight Style, Many Hail Form: Dual-Skills Blowing Shapeshifter
 - Malevolent Coastal Taihua Arts, Distinction Style, Brilliant Dark Rapid Form: Dual-Fairy Soaring Thousand
 - Malevolent Death Arts, Facing Final Demon Style, White Shroud Form: Triple Delights Soothing Jewel
 - Malevolent Eternal Arts, Total Style, Icy Shapeshifter Form: Redemption of Royal
 - Malevolent Kundali Arts, Southern Shatters Style, Unified Ash Form: Exchange of the Parallel
 - Malevolent Mirror Arts, Movement Style, Lunar Nothingness Form: Five-Fold Pattern Drifting Prajna
 - Malevolent Mountain Arts, Equine Cold Center Style, Coral Thousand Form: Five-Fold Sisi Matching Transparency
\page

 - Malevolent Obsidian Earthly Possession Arts, Illusory Responsive Cutting Style, Bloody Qintfade Form: Elemental Illuminated Traversing Ascension
 - Malevolent Phoenix Arts, Variation Style, Expansive Myriads Form: Unmatched Fortress
 - Malevolent Signless Arts, Illusory Absolute Spirit Style, Vile Big Raptor Form: Dual-Repents Attacking Gateways
 - Malevolent Unparalleled Ultimate Temple Arts, Tearing Veiled Style, Autumn Form: Five-Fold Pierce Searching Mirror
 - Malevolent Unshakable Tearing Scale Arts, Augmented Cove Style, Formless Crushes Form: Gate of Halo
 - Many Basilisk Arts, Mysterious Form Style, Abyssal Thaw Form: Triple Fate Revitalizing Drop
 - Many Crush Arts, Earthly Sylvan Style, Abyssal Basilisk Form: Six Bowing Venom
 - Many Dominating Underworld Arts, Lightweight Style, Drain Form: Dual-Asterism Lunging Waterfall
 - Many Evil Asterism Arts, Retribution Style, Martial Tiger Form: Tang of Gust
 - Many Feral Poisons Arts, Pure Cawing Soaring Style, Righteous Waxing Clouds Form: Cut of Daoist
 - Many Flying Unified Resonance Arts, Deep Commander Style, Thundershock Form: Malevolent Dipper
 - Many Frozen Fading Jewel Arts, Fleeting Chariot Style, Song Form: Meridian
 - Many Long Arts, Treading Shroud Style, Petal Sections Form: Six Flowing Quell
 - Many Mysterious Crossing Blessing Arts, Birthless Wave Style, Continuous Dipper Form: Flow of the Indestructible Vapor
 - Many Night Arts, Unrivaled Equine Malevolent Style, Rolling Flames Form: Five-Fold Bite Falling Perfusion
 - Many Principles Arts, Cliff Style, Striking Lightness Form: Dual-Decree Going Binder
 - Many Remains Arts, Profound Delights Style, Mirage Star Form: Dual-Dragontail Surging Fortress
 - Many Scriptures Arts, Equine Stretched Style, Necrotoxin Form: Waning Cyclone Soaring Reguard
 - Many Spirits Arts, Eastern Gorge Style, Blessed Elusive Pillar Form: Unbound-Emerging Big Trap
 - Many Steel Arts, Direction Style, Illusory Buddha Form: Triple Stroke Retreating Devil
 - Many Temple Arts, Ultimate Blossom Style, Striking Light Form: Phaseless of the Boxing Noble
 - Many Tong Arts, Legged Diving Inferno Style, Overwash Form: Five-Fold Majestic Severing Veiled
 - Many Vedas Arts, Shooting Defiers Style, Dividing Wolf Form: Giant Pierces-Commanding Spring
 - Many Vile Gallant Avatar Arts, Cosmic Nature Style, Forged Burning Steps Form: Triple Needle Leaping Manipulation
 - Many Windrider Arts, Posture Style, Grand Illuminating Wildfire Form: Shout of the Emergence
 - Martial Array Arts, Saving Exploding Rivers Style, Jade Crush Form: Imperial Mistveil Vispering Ghost
 - Martial Blessed Bind Arts, Stun Style, Bronze Beast Form: Illuminated of Devastation
 - Martial Contemplate Arts, Absolute Exchange Style, Equine Duck Form: Star of the Plume
 - Martial Crushes Arts, Drowned Style, Facing Man Form: Six Sharpening Radiance
 - Martial Defense Arts, White Spirits Style, Crown Form: Darkwind of the Dive
 - Martial Earth Arts, Healing Remains Style, Charging Shattering Chill Form: Six Cleaving Peak
 - Martial Forest Arts, Ultimate Crane Style, Moonlight Form: Bound
 - Martial Graceful Court Arts, Feral Radiant Fertile Style, Merciful Strength Form: Taebaek of the Corvid Chin
 - Martial Gust Arts, Cold Rapid Style, Edge Form: Forged Aspects
 - Martial Outward Grounded Cyclone Arts, Void Moonbeam Style, Evil Stab Form: Annihilation Airsplitting Fish
 - Martial Sect Arts, Bright Splitting Woods Style, Hellish Shattering Authority Form: Clarity of the Vajrapani
 - Martial Technique Arts, Cold Flower Style, Traditional Net Form: Dual-Slip Dispersing Prayer
 - Martial Tipsy Arts, Calm Thousands Style, Legged Shockwave Form: Unparalleled Rotation Emerging Array
 - Martial Vile Zenith Arts, Indestructible Suffering Style, Blazing Darkwind Form: Five-Fold Wisdom Concealing Echo
 - Merciful Binder Arts, Great Polearm Style, Glacial Fairy Form: Five-Fold Cleave Rising Swords
\page

 - Merciful Golden Acala Arts, Parallel Unmatched Traceless Style, Wounding Brilliant Reaper Form: Giant Cuts-Resonating Coil
 - Merciful Hunyuan Arts, Aquatic Wandering Heat Style, Legacy Form: Taibai of the Invisible Triple
 - Merciful Infernal Lattice Arts, Current Descent Style, Calm Many Change Form: Rising Rain Swirling Battle
 - Merciful Nebula Arts, Mad Devastation Style, Ripping Vermillion Frostbite Form: Immovable of the Traditional Fall
 - Merciful Obscure Spiritual Roar Arts, Healing Vampire Style, Adaptive Stealth Form: Sand of the Skeletal Mountainous
 - Merciful Responsive Quick Arts, Exploding Cove Style, Capped Warrior Form: Hands
 - Merciful Seaspan Arts, Brilliant Double Expansive Style, Moon Form: Veil of Vigor
 - Merciful Swarm Arts, Aureate Expansive Spectral Style, Parallel Stealth Form: Stun
 - Merciful Sweep Arts, Grounded Wood Style, Exploding Poisonous Karma Form: Dual-Truth Ascending Manifestations
 - Merciful Thrust Arts, Fiery Instance Style, Ravenous Paradise Form: Cloud of the Cyclone
 - Merciful Vitality Arts, Vile Paladin Style, Rolling Magnanimous Forest Form: Kundali of the Fox
 - Metallic Book Arts, Legacy Style, Abyssal Sections Form: Wisdom-Following Giant Coil
 - Metallic Crazy Cold Destiny Arts, Basic South Style, Moonlit Elbow Form: Way
 - Metallic Diving Radiant Sight Arts, Illusory Balanced Trill Style,  Martyr Form: Bear
 - Metallic Force Arts, Boundless Viper Style, Adaptive Prayer Form: Traceless Temper Summoning Discipline
 - Metallic Hoarforst Arts, Trinity Style, Battlefield Form: Six Rises Vedas
 - Metallic Holy Onyx Consciousness Arts, Forged Luminous Spinning Style, Waxing Claw Form: Big Strikes Reflecting Daybreak
 - Midsummer Cascade Arts, Crimson Malevolent Saint Style, Icy Cutting Scheme Form: Death of the Lost
 - Midsummer Cosmic Earth Arts, Daoist Style, Throwing Palms Form: Triple of the Sweeping Delights
 - Midsummer Divine Wheel Arts, Cawing Vedas Style, Coastal Sage Form: Stellar Temper Attacking Origin
 - Midsummer Enigma Arts, Sacred Traversing Protective Style, Spear Form: Trail Stabbing Tempo
 - Midsummer Erupting Evil Heavenhold Arts, Martial Devouring Trigrams Style, Waxing Foxform Viper Form: Majestic-Leaping Stunning Momentum
 - Midsummer Frosty Exchange Arts, Moonlit Polarm Style, Luminous Barrier Form: Unmatched Halo
 - Midsummer Galaxy Arts, Traversing Tablet Style, Pure Sinister Form: Palms
 - Midsummer Misty Arts, Poison Style, Illusory Nape Form: Harmonious Avatar
 - Midsummer Mountian Arts, Wild Sonic Illusion Style, Cursed Latch Form: Dual-Foundation Traveling Silent
 - Midsummer Necrotoxin Arts, Shadowless Style, Long Form: Blaze of the Karma
 - Midsummer Priest Arts, Rolling Element Style, Rightful Drunken Harmonies Form: Giant Thrust-Swaying Crow
 - Midsummer Qintfade Arts, Fiend Style, Unknowable Lotus Form: Kundali
 - Midsummer Tai Arts, Continuous Malevolent Corrupted Style, Few Dividing Salvation Form: Triple North Bowing Legs
 - Midsummer Tide Arts, Enlightened Unified Galaxy Style, Aureate Enemies Form: Giant Shard-Feinting Switch
 - Midsummer Vitality Arts, Holy Thunder Style, Wounding March Form: Grip of the Serene Court
 - Midsummer Way Arts, Obsidian Striking Continuous Style, Toil Form: Orthodox-Lunging Evil Cross
 - Mighty Acala Arts, Violent Daybreak Style, Azure Giant Family Form: Giant Harmonies-Biting Surface
 - Mighty Cawing Sanctum Arts, Overwash Style, Twin Blister Form: Bear of Statue
 - Mighty Cutting Mystery Arts, Gallant Beam Style, Double Merciful Truth Form: Five-Fold Charge Falling Snakeform
 - Mighty Hawk Arts, Copper Opening Style, Ravenous Element Form: Cold Nomad Vispering Stride
 - Mighty Iron Heavenly Taming Arts, Sheet Style, Mad Downward Fairy Form: Transformations-Drifting Flying Massacre
 - Mighty Lattice Arts, Astral Perfusion Style, Countless Defiers Form: Ice-Tangled Spanning Return
 - Mighty Luminous Few Talon Arts, Repelling Taebaek Style, Shatters Form: Wrath of Pearlflower
\page

 - Mighty Many Mistveil Arts, Bright Lunar Killing Style, Ethereal Prelude Form: Five-Fold Horse Aiming Assimilation
 - Mighty Metallic Coastal Stomp Arts, Fading Demonic Final Style, Ascending Zen Form: Rhythm
 - Mighty Red Pillar Arts, Big Gate Style, Holy Kindled Form: Giant Thrust-Vispering Temple
 - Mighty Specter Arts, Mirage Bird Style, Defensive Ascending Nape Form: North Bound
 - Mighty Titan Arts, Spiraling Swift Style, Living Galaxy Form: Triple Shadowless Lunging Maelstrom
 - Mighty Violent Consonance Arts, Aquatic Beam Style, Arching Cuts Form: Giant Suffering-Twisting Discipline
 - Mirage Abyssal Prajna Arts, Malevolent Astral Sisi Style, Deep Hellish Snowfield Form: Triple Wraith Paralizing Style
 - Mirage Coral Dark Tempest Arts, Protector Style, Leniency Form: Encompassing Jeweled
 - Mirage Darkwind Arts, Enlightened Harmonies Style, Grounded Road Form: Six Crouching Gate
 - Mirage Extra Single Staff Arts, Needles Style, Extinguishing Capped Goldsaber Form: Warriors Slicing Halo
 - Mirage Fang Arts, Northern Silver Style Style, Giant Solar Ascent Form: Sui of the Serene Shatter
 - Mirage Frozen Throwing Energy Arts, Secret Horse Style, Eagle Form: Vigor of the Hidden Form
 - Mirage Perfusion Arts, Sound Style, Indestructible Patriarch Form: Trap of the Body
 - Mirage Severance Arts, Mighty Disruption Style, Striking Protective Motion Form: Lightweight of the Patriarch
 - Mirage Starvation Arts, Hidden Mystery Style, Frozen Bloodstained Transformations Form: Kaleidoscope of the Palms
 - Mirage Subduing Dancing Vapor Arts, Mighty Domination Style, Stunning Shout Form: Awakening Counterattacking Starvation
 - Mirage Warfield Arts, Rightful Proud Style, Advanced Stun Form: Mindscape of the Ridge
 - Mirage Yang Arts, Facing Graceful Beasts Style, Dividing Taihua Form: Giant Protector-Resisting Buddha
 - Moonlit Breakout Arts, Thunderous Extended Luminous Style, Brilliant Volcanoes Form: Flying Phoenix Vispering Frontier
 - Moonlit Chin Arts, Countless Yin Style, Twin Patriarch Form: Giant Repents-Slicing Soul
 - Moonlit Consuming Kindled Arts, Repelling Giant Unforgiving Style, Old Destroyer Form: Dual-Thunder Conquering Sweetened
 - Moonlit Dark Balanced Pear Arts, Raven Style, Ceremony Form: Indestructible Emergence
 - Moonlit Destroyer Arts, Bright Temple Style, Blazing Polearm Form: Giant Mothers-Summoning Mindless
 - Moonlit Earthen Apex Silent Arts, Feral Protective Remains Style, Breakout Form: Mobility of the Consuming Spear
 - Moonlit Frosty Striking Nullification Arts, Tea Style, Vile Featherweight Remains Form: Giant Shadowless-Cutting Bow
 - Moonlit Myriads Arts, Warfield Style, Striking Needles Form: Giant Stance-Cleaving Devil
 - Moonlit Mysterious Absorption Arts, Skeletal Skull Style, Gentle Rotation Form: Strength of the Encompassing Lake
 - Moonlit Radiant Seeds Arts, Foxform Devastating Crane Style, Extra Cobra Form: Five-Fold Range Going Switch
 - Moonlit Siege Arts, Prelude Style, Burning Neck Form: Wild Taiji Ascending Asterism
 - Mysterious Assimilation Arts, Heavenhold Style, Snow Refraction Form: Spiral of the Soaring Sisi
 - Mysterious Boundless Lightness Arts, Icy Iron Torment Style, Forged Reflect Form: Rebounding Aura Traversing Cage
 - Mysterious Cold Aura Arts, Demon Style, Consuming Secret Titan Form: Five-Fold Whirlwind Descending Bolt
 - Mysterious Crash Arts, Blister Style, Traversing Fire Form: Book of the Sonic Ruin
 - Mysterious Disinterment Arts, White Assaliants Style, Shadow Self Form: Judgment of the Calm Nether
 - Mysterious Enemy Arts, Unveiled Style, Nefarious Thunderbolt Form: Array of Distinction
 - Mysterious Finishing Outward Tea Arts, Bronze Echo Style, Fiery Myriads Form: Dual-Shaft Evading Bear
 - Mysterious Glacier Arts, Continuous Shadowless Style, Spiritual Tearing Shura Form: Giant Neck-Raining Arrows
 - Mysterious Sharpened Arts, Empty Heat Style, Stellar Heritage Form: Infinite Leniency
 - Mysterious Spinning Bind Arts, Secret Tempest Style, Wandering Thrust Form: Pillar Commanding Unbound
 - Mysterious Stride Arts, Earthly Winter Style, Merciful Outward Bodhi Form: Majestic
\page

 - Mysterious Sun Arts, Silver Canyon Style, Evil Remains Form: Triple Crushes Concealing Cut
 - Mysterious Traversing Forged Shard Arts, Sacred Crazy Slicing Style, Legacy Form: Scholar Shaking Life
 - Mysterious Trigrams Arts, Dominating Parallel Onyx Style, Cardinal Featherweight Leap Form: Triple Annihilation Resting Stab
 - Mysterious Wing Arts, Coral Heritage Style, Disciple Form: Drift of Barrage
 - Mystic Apex Erupting Path Arts, Extinguishing Siege Style, Void Enigma Form: Trigrams of Moon
 - Mystic Black Shockwave Arts, Martyr Style, Hidden Fading Stomp Form: Reflection-Sleeping Basic Jewel
 - Mystic Crazy Method Arts, Magnanimous Transformations Style, Frontier Form: Blessed Embrace Countering Mistveil
 - Mystic Destructive Swing Arts, Mad Fate Style, Shower Form: Universal Pack
 - Mystic Earthquakes Arts, Sonic Tail Style, Unshakable Poisonous Lofty Form: Emperor-Dodging Grafting Madness
 - Mystic Echo Arts, Finger Style, Extinguishing Illuminating Wisdom Form: Giant Gust-Searching Stab
 - Mystic Fish Arts, Giant Aura Style, Subduing Flash Form: Starlight of the Cutting Grip
 - Mystic Lotus Arts, Protective Block Style, Earthly Dance Form: Giant Warmaster-Falling Polearm
 - Mystic Needle Arts, Single Nape Style, Secret Tigers Form: Cultivation of the Wisdom
 - Mystic Raptor Arts, Vigor Style, Magnanimous Frozen Triadic Form: Capped Cage Concealing Condor
 - Mystic Suffering Arts, Expansive Duck Style, Soaring Seal Form: Bloody Haunt
 - Mystic Toil Arts, Blazing Decree Style, Marquis Form: Shift
 - Mystic Trap Arts, White Jewel Style, Single Sword Form: Giant Myriads-Concealing Sweep
 - Mystic Trident Arts, Felling Shaolin Style, Cry Form: Secret Dust Stealing Flare
 - Mystic Turtle Arts, Vile Outward Rectitude Style, Thunderwake Form: Protective Curse
 - Mystic Web Arts, Cursed Sweeping Manifestation Style, Capped Riddle Form: Dual-Swing Cleaving Goldsaber
 - Nefarious Ash Arts, Orthodox Style, Demonic Legs Form: Method of the Ravenous Divinities
 - Nefarious Kick Arts, Sinister Style, Subduing Truth Form: Giant Fang-Ascending Lofty
 - Nefarious Madness Arts, Enlightened Astral Strikes Style, Equal Icy Beggar Form: Leap
 - Nefarious Poisonous Hail Arts, Throwing Splitting Spanning Style, Heartless Qintfade Form: Unrestrained of the Crimson Vairocana
 - Nefarious Principles Arts, Smashing Arrows Style, Obsidian Crown Form: Battle Reflecting Technique
 - Nefarious Redemption Arts, Endless Devil Style, Solar Maiden Form: Dual-Cinder Covering Fortress
 - Nefarious Storm Arts, Expansive Responsive Liberated Style, Ripping Marquis Form: Triple Phenomena Crouching Triangle
 - Nefarious Taiji Arts, Soaring Parallel Wheel Style, Blazing Monkey Form: Five-Fold Absorption Coiling Eagle
 - Nefarious Wandering Necrotoxin Arts, Northern Expansive Enlightenment Style, Foxform Crows Form: Absorption Freezing Range
 - Nefarious Windrider Arts, Fatal Unrivaled Martial Style, Coil Form: Six Slicing Pines
 - North Destructive Outward Orthodox Arts, Celestial Leech Style, Thunderous Ultimate Fox Form: Mindscape of the Emergence
 - North Domination Arts, Spanning Creation Style, Throwing Profound Thaw Form: Triple Embrace Taking Delights
 - North Elegant Dual Sanctum Arts, Clarity Style, Emerald Army Form: Spinning Shout Transforming Paradise
 - North Lunar Wanderer Arts, Endless Severance Style, Frosty Wounding Instance Form: Palms of the Icy Song
 - North Martial Boxing Eruption Arts, Grand Stellar Arching Style, Plague Form: Dual-Devil Sharpening Toil
 - North Rivers Arts, Diving Light Style, Secret Seaspan Form: Dual-Vajrayana Dodging Return
 - North Secret Divine Frontier Arts, Parallel Style, Onyx Scarlet Form: Six Cutting Hand
 - Northern Corrupted Blooming Valley Arts, Illusory Rage Style, Unshakable Eternal Venom Form: Fury
 - Northern Diving Final Self Arts, Demonic Majestic Style, Repelling Crazy Martyr Form: Sky of Waves
 - Northern Formless Intoxicated Circle Arts, Nature Style, Unknowable Break Form: Triple Basilisk Summoning Paladin
\page

 - Northern Iron Grove Arts, Onyx Chin Style, Calm Sisi Form: Center Prestissimo
 - Northern Midsummer Gallant Tong Arts, Grafting Lunar Barrage Style, Traversing Feral Shatter Form: Whirling Nomad
 - Northern Penetrating Brush Arts, Stunning Pillar Style, Vampire Form: Giant Perfusion-Ending Maiden
 - Northern Protective Quick Sage Arts, Dark Icy Sudden Style, Throwing Momentum Form: Dual-Point Stealing Specter
 - Northern Transformation Arts, Skeletal Cuts Style, Ghostly Orthodox Form: Giant Hands-Falling Taihua
 - Northern Vajrayana Arts, Unforgiving Sage Style, Repentant Vairocana Form: Disciple-Resisting Formless Edge
 - Obscure Annihilation Arts, Current Ancient Bright Style, Constellation Form: Dual-Turtleback Paralyzing Transformations
 - Obscure Black Tearing Scriptures Arts, Piercer Style, Empty Double Leniency Form: Giant Sutra-Cleaving Ape
 - Obscure Canyon Arts, Traditional Coil Style, Infinite Cave Form: Six Sharpening Shura
 - Obscure Consuming Weaver Arts, Mysterious Luminous Forms Style, Immortal Formation Form: Protector-Evading Boundless Army
 - Obscure Cursed Duck Arts, Coral Extended Equal Style, Chaotic Stomp Form: Mental
 - Obscure Dividing Elusive Army Arts, Glacier Style, Demonic Underworld Form: Jeweled Dispersing Claw
 - Obscure Gorge Arts, Nefarious Fairy Style, Universal Soft Form: Manifestations Gathering Raven
 - Obscure Graceful Unmatched Opposition Arts, Bronze Coral Rebounding Style, Court Form: Meditation of the Pearlflower
 - Obscure Heaven Arts, Cawing Burst Style, Protective Circle Form: Staff
 - Obscure Heaven Arts, Continuous Warmaster Style, Roving Grand Arhat Form: Iron Condor Reflecting Glacier
 - Obscure Icebolt Arts, Dark Court Style, Meditation Form: Duck of Pattern
 - Obscure Latch Arts, Waxing Heavenly Infusion Style, Encompassing Fog Form: Giant Dew-Blowing Annihilation
 - Obscure Liberated Domain Arts, Hellish Cultivation Style, Unmatched Taibai Form: Balanced Starlit
 - Obscure Moonlight Arts, Mad Repentant Infinite Style, Universal King Form: Solar Sky Soothing Drain
 - Obscure Sand Arts, Ultimate Fall Style, Cardinal Tearing Repents Form: Giant Lost-Dispersing Style
 - Obscure Steel Arts, Aureate Curse Style, Center Archery Form: Body of the Healing Daoist
 - Obscure Sui Arts, Element Style, Sacred Living Snowfall Form: Five-Fold Jeweled Resisting Resonance
 - Obscure Tundra Arts, Spectral Illuminating Tongue Style, Petal Killing Breeze Form: Signless-Stealing Pure Counter
 - Obscure Vermillion Motion Arts, Southern Cremation Style, Righteous Cleave Form: Heart-Emerging Legged Inferno
 - Obscure Wall Arts, Silver Weaver Style, Unmatched Yin Form: Bat of Roars
 - Obscure Water Arts, Whale Style, Emptiness Form: Five-Fold Strike Controlling Frenzy
 - Obsidian Coated Spin Arts, Traceless Wing Style, Riding Gentle Legacy Form: Dual-Command Summoning Timberfall
 - Obsidian Granite Arts, Old Blessing Style, Giant Arm Form: Extinguishing Starlight Cleaving Meridian
 - Obsidian Grip Arts, Empty Pounce Style, Wild Sound Form: Shroud of Radiance
 - Obsidian Penetrating Pure Lattice Arts, Polar Style, Limitless Killing Man Form: Six Taking Sweetened
 - Obsidian Rectitude Arts, Duck Style, Advanced Monastery Form: Enigma
 - Obsidian Sun Arts, Fatal Imperial Snow Style, Few Meridian Form: Brush
 - Obsidian Thread Arts, Grafting Scale Style, Golden Vile Echo Form: Empty Spiritage Sleeping Chop
 - Obsidian Thunderwake Arts, Tearing Sonata Style, Birthless Mirage Arhat Form: Triple Deity Observing Tong
 - Old Creation Arts, Yellow Cawing Coil Style, Empty Moonlight Form: Giant Tempo-Flying Trident
 - Old Dual Veiled Arts, Frozen Toxic Slip Style, Fatal Perfusion Form: Principles
 - Old Mist Arts, Precept Style, Nape Form: Mirror
 - Old Obsidian Western Unveiled Arts, Dancing Creation Style, Center Profound Blister Form: Rhythm-Taking Rightful Deity
 - Old Riddle Arts, Brilliant Capped Unrivaled Style, Leaf Form: Giant Curse-Shaking Grove
\page

 - Old Roars Arts, Ethereal Traceless Whirling Style, Wicked Crows Form: Elegant Sound
 - Old Shell Arts, Blazing Triangle Style, Turtleback Form: Triple North Coiling Vairocana
 - Old Shooting Lower Strength Arts, Charging Glacial Rising Style, Ultimate Polearm Form: Taibai of Opening
 - Old Smoke Arts, Burning Bat Style, Repelling Wrath Form: Marquis of the Death
 - Old Stunning Fang Arts, Azure Pounce Style, Graceful Shadowy Form: Illusion of the Tree
 - Old White Boundless Snake Arts, Stunning Transparency Style, Ascending Man Form: Five-Fold Trail Coiling Domination
 - Onyx Ancient Old Cinder Arts, Cosmic Skill Style, Invisible Merciful Flame Form: Five-Fold Substitution Dodging Fang
 - Onyx Creation Arts, Gallant Soaring Punch Style, Reflect Form: Thunderwake
 - Onyx Domain Arts, Ultimate Timberfall Style, Finishing Root Form: Six Tangled Beasts
 - Onyx Element Arts, Primordial Vile Guard Style, Crimson Divine Night Form: Shaft-Linking Unmatched Weapon
 - Onyx Foundational Waterfall Arts, Great Undivinable Aura Style, Abyssal Halo Form: Triple Silent Cutting Essence
 - Onyx Ice Arts, Illusory Disciple Style, Equal Pearl Form: Giant Vedas-Emerging Fortress
 - Onyx Lord Arts, Crossing Eclipse Style, Black Saber Form: Cloak Freezing North
 - Onyx Method Arts, Center Beast Style, Extended Possession Form: Prajna
 - Onyx Saving Hand Arts, Divinities Style, Touch Form: Contemplate Rising Pyrocascade
 - Onyx Spiritual Aquatic Storms Arts, Invisible Fiend Style, Devouring Taming Form: Necrotoxin
 - Onyx Storms Arts,  Holy Road Style, Destructive Sanctity Form: Strength of the Phenomena
 - Onyx Temper Arts, Astral Counter Style, Venomous Swords Form: Thunder Twisting Duck
 - Onyx Torment Arts, Southern Crush Style, Violent Resolve Form: Pierce of Daybreak
 - Onyx Vapor Arts, Whirling Poisonous Glacier Style,  Tidal Buddha Form: Dual-Neck Severing Bodhi
 - Onyx Wandering Scholar Arts, Undivinable Rectitude Style, Traceless Leap Form: Barrier
 - Outward Constellation Arts, Barrier Style, Tigers Form: Six Covering Fortune
 - Outward Equal White Madness Arts, Big Venomous Defense Style, Grounded Heavenhold Form: Five-Fold Nebula Flowing Paradise
 - Outward Grip Arts, Righteous Martial Assault Style, Crystalline Wanderer Form: Hunyuan Aiming Crushes
 - Outward Heavenly Commander Arts, Waning Mind Style, Surge Form: Rectitude
 - Outward Lance Arts, North Heritage Style, Roving Stone Form: Giant Crane-Observing Sugar
 - Outward Leaf Arts, Liberated Taiji Style, Mountian Form: Cry-Summoning Crimson Sweetened
 - Outward Mysterious Sisi Arts, Silver Fiery Veil Style, Skeletal Scheme Form: Walk-Draining Endless Wraith
 - Outward Sonic Tide Arts, Devouring Wall Style, Resonance Form: Six Descending Consciousness
 - Outward Team Arts, Flashes Style, Crossing Gate Form: Nail of Enlightenment
 - Outward Treading Countless Arm Arts, Prelude Style, Frozen Thread Form: Stretched-Surging Cawing Rain
 - Outward Wave Arts, Malevolent Descending Vibrant Style, Striking Whale Form: Energy of Ink
 - Parallel Ancient Temper Arts, Expansive Ghostly Swift Style, Man Form: Triple Venom Falling Spirits
 - Parallel Barrier Arts, Cold Sacred Buddhist Style, Facing Blessing Form: Hellish Defense Vispering Volcanoes
 - Parallel Basilisk Arts, Dual Sufferings Style, Wicked Vajrayana Form: Nether Soothing Court
 - Parallel Cage Arts, Perfect Giant Temper Style, Adamantine Icy Canyon Form: Echo
 - Parallel Ceremony Arts, Center Granite Style, Ripping Sugar Form: Kings
 - Parallel Claw Arts, Adaptive Cardinal Deflection Style, Whale Form: Triple Calamity Stealing Disinterment
 - Parallel Crossing Malevolent Authority Arts, Vermillion Sun Style, Outward Infinite Essence Form: Leniency of the Prestissimo
 - Parallel Dance Arts, Bloodstained Cremation Style, Vapor Form: Center Assaliants Leaping Gate
\page

 - Parallel Drop Arts, Gem Winds Style, Mirage Essence Form: Triple Riddle Draining Stomp
 - Parallel Exorcism Arts, Spiritual Continuous Hands Style, Crown Form: Dual-Kaleidoscope Fighting Eternal
 - Parallel Killer Arts, Repelling Projectile Style, Blooming Mindscape Form: Protector of the Coastal Tundra
 - Parallel Kindled Arts, Surface Style, Crimson Beast Form: Giant Crown-Blowing Claw
 - Parallel Lunar Bloodthristy Tea Arts, Feral Yang Style, Glacial Elder Form: Six Countering Rhythm
 - Parallel Scheme Arts, North Discipline Style, Harmonious Boxing Tempest Form: Sanctum of Break
 - Parallel Serene Spiritual Shura Arts, Twin Shell Style, Featherweight Cloud Form: Six Airsplitting Kaleidoscope
 - Parallel Shield Arts, Yellow Trial Style, Spiritual Eternal Rectitude Form: Trinity of Rage
 - Parallel Shower Arts, Underworld Style, Cardinal Unity Form: Instance-Cleaving Lunar Fox
 - Parallel Striking Fairy Arts, Titan Style, Continuous Expansive Star Form: Triple Chain Airsplitting Light
 - Parallel Venomous Thread Arts, Tortoise Style, Punch Form: Sight of the Apex Jeweled
 - Penetrating Aura Arts, Violent Sight Style, Illusory Pines Form: Triple Suffering Confronting Might
 - Penetrating Basic Nefarious Bound Arts, Primordial Shattering Sweeping Style, Aquatic Undivinable Soul Form: Five-Fold Distinction Unwavering Spin
 - Penetrating Blessing Arts, Living Duck Style, Domain Form: Taebaek-Stealing Throwing Titan
 - Penetrating Bright Traceless Arts, Deity Style, Celestial Mysterious Meditation Form: Method-Resting Grand Hawk
 - Penetrating Burst Arts, Rightful Obscure Formation Style, Poisonous Marquis Form: Venom of the Aspects
 - Penetrating Capped Brush Arts, Prestissimo Style, Sui Form: Five-Fold Assault Swaying Glacier
 - Penetrating Cyclone Arts, Infinite 62 Fold Long Style, Corvid Advent Form: Expansive Mindless
 - Penetrating East Arts, Diving Soft Style, Featherweight Arrow Form: Six Carrying Jewel
 - Penetrating Extended Incineration Arts, Poisonous Shaolin Style, Rebounding Endless Silent Form: Reflect of the Coral Nature
 - Penetrating Halo Arts, Protective Night Style, Annihilation Form: Mighty Weapon Soaring Awakening
 - Penetrating Legged Polearm Arts, Mysterious Apex Traceless Style, Cyclone Form: Six Descending Mindless
 - Penetrating Primordial Chackra Arts, Judgment Style, Earthly Warmth Form: Five-Fold Swing Traveling Unveiled
 - Penetrating Red Dipper Arts, Embracing Nail Style, Sudden Break Form: Angel of Hawkstrider
 - Penetrating Sweeping Repelling Legacy Arts, Gallant Throwing Thoughtless Style, Skeletal Sudden Repents Form: Triple Opening Matching Fire
 - Penetrating Tea Arts, Gentle Grace Style, Frosty Drowned Form: Warmaster-Attacking Protective Web
 - Penetrating Temple Arts, Mad Bite Style, Smashing Fleche Form: Spiraling Consonance Matching Mindless
 - Penetrating Vile Piercer Arts, Bear Style, Capped Circle Form: Giant Nape-Concealing Command
 - Perfect Assimilation Arts, Twin Tearing Enlightened Style, Emerald Devouring Balance Form: Liberated Sharpened
 - Perfect Blossoms Arts, Tea Style, Fiery Nether Form: Dual-Defiers Biting Flight
 - Perfect Cascade Arts, Spirit Buddhist Scheme Style, Skeletal Grafting Scale Form: Merciful Taming Binding Divinities
 - Perfect Cross Arts, Opposition Style, Dancing Wandering Asura Form: Six Resting Slashes
 - Perfect Drunken Indestructible Heritage Arts, Invisible Peak Style, Rebounding Polar Form: Rends
 - Perfect Eclipse Arts, Earthly Trident Style, Forged Shadow Total Form: Crown of the Phaseless
 - Perfect Goldenring Arts, Sonic Shadow Posture Style, Vile Assault Form: Dual-Starlight Ending Authority
 - Perfect Guardian Arts, Iron Equine Icy Style, Enlightened Prayer Form: Five-Fold Vampire Observing Frenzy
 - Perfect Hydra Arts, Imperial God Style, Reaper Form: Timberfall-Resisting Subduing Fortune
 - Perfect Seal Arts, Outward Galaxy Style, Dancing Cleave Form: Veiled-Conquering Blessed Monkey
 - Perfect Swords Arts, Illusory Roars Style, Fertile Things Form: Dao of the Advanced Priest
 - Perfect Verdant Arts, Foxform Shadow Heavenly Style, Coated Primordial Martyr Form: Forged Swift Countering Path
\page

 - Petal Black Flame Arts, Waxing Unshakable Limbo Style, Penetrating Nefarious Cobra Form: Harmony
 - Petal Condor Arts, Basic Nature Style, Malevolent Team Form: Martial Phenomena Twisting Archery
 - Petal East Arts, Slicing Arching Ghost Style, Arhat Form: Shura of the Devastating Counter
 - Petal Ink Arts, Invisible Bright Endless Style, Few Quartet Form: Bird of the Disciple
 - Petal Instance Arts, Waning Foundational Truth Style, Extreme Body Form: Six Chopping Distinction
 - Petal Martial Buddha Arts, Many Sui Style, Chill Form: Fortress Concealing Bow
 - Petal Polarm Arts, Proud Style, Descending Advanced Shaolin Form: Giant Split-Crouching Glow
 - Petal Rapid Arts, Eastern Phenomena Style, Flying Snake Form: Pillar of the Outward Gate
 - Petal Swan Arts, Wanderer Style, Encompassing Skill Form: Posture
 - Petal Trill Arts, Illuminating Dual Blessed Style, Feral Essence Form: Grip of the Sutra
 - Petal Wave Arts, Shattering Touch Style, Decree Form: Protective Warmaster Freezing Viper
 - Petal Wild Warmaster Arts, Grand Dark Stretched Style, Deep Wing Form: Exorcism
 - Poisonous Authority Arts, Balanced Harmonious Starlit Style, Elegant Warrior Form: Augmented Ghost Severing Grasp
 - Poisonous Chop Arts, Continuous Mysterious Featherweight Style, Ripping Warmaster Form: Blade
 - Poisonous Cloud Arts, Waning Nefarious Cry Style, Dancing Bird Form: Deflection of Fortress
 - Poisonous Devastating Great Overwash Arts, Destructive Extended Turtle Style, Grappling Bird Form: Rampage of the Charging Eruption
 - Poisonous Earthen Disruption Arts, Bloodstained Devil Style, Heartless Transparency Form: Toss of the Cut
 - Poisonous Enlightened Formless Sheet Arts, Fertile Pear Style, Exploding Stunning Warriors Form: Five-Fold Wing Shaking Tong
 - Poisonous Icebolt Arts, Striking Vigor Style, Demon Form: Giant Tail-Descending Resonance
 - Poisonous Point Arts, Astral Nape Style, Spiritual Shield Form: Six Paralyzing Skill
 - Poisonous Principles Arts, Facing Change Style, Mighty Hit Form: Formation of the Myriads
 - Poisonous Pyre Arts, Tearing Cursed Breakthrough Style, Drain Form: Six Fighting Heritage
 - Poisonous Road Arts, Lunar Hidden Fleeting Style, Summit Form: Scheme
 - Poisonous Scriptures Arts, Elusive Formless Principles Style, Petal Thunderous Crows Form: Temple Following Element
 - Poisonous Sonata Arts, Jade Blooming Vile Style, Ceremony Form: Six Traveling Pear
 - Poisonous Swing Arts, Phantom Style, Sinister Form: Six Going Halo
 - Poisonous Titan Arts, Grappling Canyon Style, Yellow Court Form: Gate of the Vigor
 - Poisonous Undivinable Net Arts, Dirty Ghostly Heartless Style, Ape Form: Giant Manipulation-Shaking Nullification
 - Primordial Adamantine Millennium Arts, Full Gentle Tongue Style, Charging Rage Form: Balanced Throw
 - Primordial Ascending Single Precept Arts, Sweeping Staff Style, Formless Erupting Mistveil Form: Lord Binding Suppression
 - Primordial Augmented Fiery Malignant Arts, Defensive Cavern Style, Expansive Vairocana Form: Giant Method-Bowing Dust
 - Primordial Dust Arts, Charging Corrupted Chariot Style, Spinning Equal Aura Form: Dual-Statue Covering Shout
 - Primordial Exploding Foundational Bamboo Arts, Splitting Shade Style, Spanning Sage Form: Throwing Soft Freezing Fall
 - Primordial Illusion Arts, Winds Style, Heavenly Striking Center Form: United of the Grappling Kundali
 - Primordial Leaf Arts, Soaring Phantom Style, Governing Liberated Suffering Form: Sweep Counterattacking Sage
 - Primordial Nothingness Arts, Vile Meditation Style, Body Form: Dual-Earth Swirling Skills
 - Primordial Opening Arts, Celestial Body Style, Sealing Graceful Heavenhold Form: Technique of Lattice
 - Primordial Pearl Arts, Solar Mountian Style, Eastern Vitality Form: Six Soothing Harvest
 - Primordial Plate Arts, Leech Style, Basic Jade Gateways Form: Six Grounding Transformation
 - Primordial Retribution Arts, Indestructible Warmaster Style, Giant Limitless Buddha Form: Six Counterattacking Range
\page

 - Primordial Soar Arts, Self Style, Whirling Demon Form: Six Aiming Realm
 - Primordial Tearing Circle Arts, Splitting Sealing Arrow Style, Omnidirectional Form: Paradise of Shadowy
 - Primordial Universal Ripple Arts, Volcano Style, Few Domain Form: Weapon
 - Profound Ancient Western Crush Arts, Imperial Spanning Calamity Style, Great Mindscape Form: Five-Fold Ruin Sharpening Demon
 - Profound Asura Arts, Illuminating Celestial Few Style, Southern Formless Wave Form: Intent of Grace
 - Profound Ceremony Arts, Gallant Expansive Traversing Style, Earthly Illuminating Retribution Form: Triple Deflection Conquering Lofty
 - Profound Devouring Obsidian Mystery Arts, Traceless Heritage Style, Smashing Slash Form: Sonata Breaking Motion
 - Profound Fatal Battalion Arts, Ethereal Forged Embrace Style, Roving Stalwart Form: Grove
 - Profound Featherweight Flight Arts, Fleeting Motion Style, Consciousness Form: Five-Fold Buddha Flaming Principles
 - Profound Fox Arts, Empty Misty Style, True Authority Form: Consuming Posture
 - Profound Ghostly Continuous Scriptures Arts, Great Subduing Expansive Style, Blessing Form: Giant Trigrams-Going Lost
 - Profound Red Sacred Vedas Arts, Blessing Style, Bow Form: Illusion of the Shatters
 - Profound Shatter Arts, Traceless Malevolent Onyx Style, Soar Form: Specter-Chopping Frosty Disruption
 - Profound Shatters Arts, Parallel Circle Style, Stunning Striking Sand Form: Dual-Earthquakes Paralyzing Drop
 - Profound Sisi Arts, Heartless Elegant Drunken Style, Crazy Move Form: Five-Fold Seaspan Feinting Drift
 - Profound Snowfall Arts, Few Capped Bird Style, Infusion Form: Triple Hands Dodging Tundra
 - Profound Spirit Sand Arts, Soaring Destructive Prajna Style, Boundless Bone Form: Skeletal Wing
 - Profound Spread Arts, Proud Style, Void Form: Triple Cultivation Gathering Moonbeam
 - Protective Crash Arts, Jade North Continuous Style, Infusion Form: Triple Neck Descending Cobra
 - Protective Gem Fall Arts, Spectral Descent Style, Gateways Form: Heaven of the Reflect
 - Protective Glow Arts, Blessed Spectral Azure Style, Gem Cage Form: Ravenous Woods
 - Protective Polarm Arts, Descending Execution Style, Responsive Royal Form: Hunyuan of Necrotoxin
 - Protective Rain Arts, Drunken Striking Snowfall Style, Stealth Form: Birthless Intent
 - Protective Realm Arts, Coastal Boulder Style, Rightful Illusion Form: Twin Star Drifting Dive
 - Protective Signless Arts, Mountainous Style, Extinguishing Spiraling Trap Form: Limbo-Going Secret Burst
 - Protective Sonata Arts, Venomous Buddhist Phantom Style, Ascending Midsummer Vine Form: Martial Triadic Gathering Cultivation
 - Protective Space Arts, Limitless Phantom Style, Divine Tail Form: Imperial Dragon Cleaving Beam
 - Protective Stream Arts, Boundless Boxing Defensive Style, Deep Dual Karmic Form: Stalwart
 - Protective Toil Arts, Stellar Waves Style, Waning Prajna Form: Hand of the Ultimate Seal
 - Protective Unrestrained Arts, Boxing Temper Style, Sweeping Warmth Form: Roving Pounce
 - Pure Consuming Sweeping Heavenhold Arts, Tidal Cardinal Lattice Style, Northern Fury Form: Giant Starlit-Linking Bone
 - Pure Delights Arts, Unknowable Phoenix Style, Unshakable Eruption Form: Five-Fold Stance Resting Sight
 - Pure Devouring Reflect Arts, Spiraling Great Killing Style, Way Form: Encompassing Meditation
 - Pure Eagle Arts, Trail Style, Trill Form: Giant Ruin-Resonating Swords
 - Pure Empty Final Embrace Arts, Lower Arrows Style, Emerald Truth Form: Triple Needle Binding Vajrayana
 - Pure Fire Arts, Smashing Storms Style, Grounded Sacred Cut Form: Six Traversing Glide
 - Pure Hoarforst Arts, Suffering Style, Sound Form: Dual-Rhythm Resting Warfield
 - Pure Necrotoxin Arts, Hellish Single Yin Style, Arrow Form: Six Transforming Bamboo
 - Pure Pines Arts, Boundless Elegant Leaves Style, Fatal Woods Form: Prestissimo Traveling Warrior
 - Pure Polar Arts, Full Charge Style, Radiant Wood Form: Dual-Paradise Bowing Trio
\page

 - Pure Secret Hand Arts, Destructive Pyrocascade Style, Blazing Unrestrained Form: Essence of the Charging Glow
 - Pure Subduing Unshakable Reflection Arts, Full Poisonous Crusher Style, Invisible Moonbeam Form: Star of the Healing Monastery
 - Pure Sweetened Arts, Downward Heartless Spectral Style, Charging Gorge Form: Outward Defiers
 - Pure Temper Arts, Midsummer Calm Elder Style, Hidden Posture Form: Sonata Attacking Lightness
 - Pure Whirling Great Technique Arts, Tortoise Style, Black Prestissimo Form: Sutra Taking Glide
 - Quick Awakening Arts, Corrupted Stunning Roving Style, Radiant Movement Form: Illusion of Thirst
 - Quick Balanced Protective Maelstrom Arts, Stunning Endless Spanning Style, Icy Equal Shade Form: Ghostly Circle
 - Quick Bone Arts, Mirage Burning Grip Style, Chaotic Illuminating Vibrant Form: Bright Claw
 - Quick Cascade Arts, Forged Light Style, Chill Form: Shockwave of the Stream
 - Quick Crystalline Shell Arts, Immortal Buddhist Dirty Style, Brilliant Aureate Haunt Form: Finishing Scale Flowing Nails
 - Quick Disruption Arts, Jade Triple Style, Lower Tremor Form: Five-Fold Deities Summoning Stun
 - Quick Drowned Arts, Boundless Cursed Expansive Style, Liberated Total Form: Triple Taming Lunging Moonlight
 - Quick Orthodox Arts, Cosmic Disinterment Style, Balanced Direction Form: Pulse Slicing Motion
 - Quick Secret Harvest Arts, Bind Style, Pure Mystery Form: Rightful Illuminated
 - Quick Soul Arts, Vile Vajrayana Style, Footstep Form: Frontier Coiling Sand
 - Quick Sugar Arts, Waxing Breaker Style, Rightful Scripture Form: Fog of the Essence
 - Quick Traceless Windswept Arts, Onyx Paladin Style, Palms Form: Grace
 - Quick Warmth Arts, Heritage Style, Gallant Coastal Man Form: Shooting Beast Covering Energy
 - Quick Wild Extinguishing Beam Arts, Downward Mystic Archery Style, Moonlit Trail Form: Proud of Sylvan
 - Radiant Arrows Arts, Magnanimous Governing Traditional Style, Total Form: Dual-Mindless Counterattacking Winds
 - Radiant Blade Arts, Authority Style, Skeletal Wanderer Form: Triple Moon Deflecting Trigrams
 - Radiant Crimson Cosmic Cross Arts, Bloom Style, Holy Stomp Form: Dual-Forms Chopping Immovable
 - Radiant Cutting Windswept Arts, Corrupted Nomad Style, Obscure Origin Form: Six Soaring Root
 - Radiant Diving Cold Force Arts, Lower Blaze Style, Devouring Double Radiance Form: Perfusion Controlling Flesh
 - Radiant Endless Hellish Shaft Arts, Ancient Galaxy Style, Cursed Capped Polar Form: Corvid Interference
 - Radiant Intention Arts, Dancing Trigrams Style, Exploding Sisi Form: Breakthrough Stealing Flameball
 - Radiant Move Arts, Treading Assaliants Style, Diving Lotus Form: Phenomena of the Merciful Leniency
 - Radiant Onyx Pattern Arts, Ghostly Illuminated Style, Pure Royal Form: Sage of Scripture
 - Radiant Prayer Arts, Thunderclap Style, Fading Roving Wildfire Form: Unmatched Variation Revitalizing Arrow
 - Radiant Soaring Cinder Arts, Lower Karma Style, Formless Lance Form: Giant Road-Controlling Turtleback
 - Radiant Team Arts, Moonlit Steel Style, Cutting Nefarious Man Form: Hell of the Tearing Beasts
 - Radiant Vile Healing Guard Arts, Downward Drunken Absolute Style, Fiendish Spear Form: Destiny
 - Radiant Volcano Arts, Equal Bite Style, Luminous Reflection Form: Eruption-Counterattacking Onyx Emergence
 - Radiant Volcanoes Arts, Dive Style, Heart Form: Whirling Hellfire Coiling Tipsy
 - Radiant Wheel Arts, Devouring Devastation Style, Orthodox Form: Five-Fold Repents Resting Trial
 - Ravenous Blessed Bronze Rhythm Arts, Undivinable Skeletal Touch Style, Necrotoxin Form: Mastery-Shattering Elusive Calamity
 - Ravenous Chill Arts, Dancing Sudden Infinite Style, Petal Glacier Form: Cleave-Aiming Featherweight Swords
 - Ravenous Domination Arts, Spiritual Road Style, Silver Triangle Form: Taihua of the Moonlit Buddha
 - Ravenous Duck Arts, Icebolt Style, Dirty Crossing Touch Form: Dual-Spear Aiming Defiers
 - Ravenous Flame Arts, Traversing Nail Style, Blessed Thoughtless Form: Feral Leaves Countering Mirrored
\page

 - Ravenous God Arts, Rocky Style, Perfect Posture Form: Charging Haunt
 - Ravenous Goldsaber Arts, Foundational Absolute 39th Style, Augmented Coil Form: Triple Shapeshifter Observing Sonata
 - Ravenous Hidden Feral Finger Arts, Cliff Style, Universal View Form: Six Soothing Chariot
 - Ravenous Incineration Arts, Nature Style, Parallel Continuous Specter Form: Dual-Hands Flaming Shaolin
 - Ravenous Mindless Arts, Big Sheet Style, Legged Unrestrained Form: Bamboo Searing Ursine
 - Ravenous Signless Arts, Chaotic Leaf Style, Finishing United Form: Basic Zen
 - Ravenous Treading Poison Arts, Charging Swift Style, Moonlit Governing Horse Form: Roving Life Revitalizing Bound
 - Ravenous Twin Eastern Sisi Arts, Buddhist Projectile Style, Big Riddle Form: Nails
 - Ravenous Universal Disinterment Arts, Obscure Wraith Style, Warfield Form: Mist Going Warriors
 - Ravenous Woodland Arts, Stunning Pattern Style, Evil Serpent Form: Five-Fold Frenzy Ensnaring Enemies
 - Rebounding Dancing Fatal Vajrayana Arts, Spiritual Slayer Style, Earthen Whirlwind Form: Illuminating Cobra Slicing Skull
 - Rebounding Dominating Heritage Arts, Drunken Weaver Style, Extra Calamity Form: Bloodstained Staff Resisting Deities
 - Rebounding Flame Arts, Cawing Flare Style, Evil Mount Form: Outward Yang
 - Rebounding Noble Arts, Astral Tree Style, Stunning Feather Form: Giant Slip-Summoning Dragontail
 - Rebounding Principles Arts, Wounding Endless Flash Style, Hellish Net Form: Illusory Starvation
 - Rebounding Responsive Bronze Lofty Arts, Arm Style, Subduing Enemies Form: Dual-Gust Draining Nomad
 - Rebounding Substitution Arts, Drunken Soaring Root Style, Sun Form: Triple Thousands Observing Path
 - Rebounding Team Arts, Nails Style, Eternal Shaft Form: Sisi of the Corvid Triangle
 - Rebounding Waxing Moonlit Substitution Arts, Featherweight Transformation Style, Tranquil Form: Cutter of Karmic
 - Red Adaptive Stream Arts, Corvid Royal Style, Birthless Devouring Crows Form: Gem Temper
 - Red Blood Arts, Devouring Gentle Walk Style, Enemies Form: North of Shatter
 - Red Destruction Arts, Move Style, Violent Talon Form: Saber of the Underworld
 - Red Extra Asura Arts, Outward Foxform Trident Style, Disciple Form: Triple Mind Binding Move
 - Red Glow Arts, Saving Coral Momentum Style, Devouring Nomad Form: Crazy Netherworld
 - Red Heavenhold Arts, Coated Extended Single Style, Grand Opening Form: Mountian
 - Red Lightweight Arts, Mount Style,  Breaker Form: Finger Slicing Shaft
 - Red Might Arts, Taebaek Style, Ascending Celestial Trail Form: Dual-Star Ending Bow
 - Red Sealing Absolute Shaft Arts, Dirty Foundational Fleeting Style, Mad Parallel Form: Six Resting Quell
 - Red Sixteens Embracing Snowfall Arts, Killing Warfield Style, Extended Pulse Form: Giant Galaxy-Flowing Pounce
 - Red Unmatched Illusory Lake Arts, Forged Reflect Style, Continuous Latch Form: Flesh-Stabbing Bloodstained Omnidirectional
 - Red Wing Arts, Skeletal Pulse Style, Lower Demon Form: Sinister of Vajrapani
 - Repelling Comb Arts, Finishing Crow Style, Onyx Frontier Form: Viper of the Repentant Seal
 - Repelling Coral Hellish Essence Arts, Righteous Ethereal Reaper Style, Burning Killing Hell Form: Dual-Maiden Bowing Things
 - Repelling Crush Arts, Metallic Hidden Cawing Style, Stunning Pear Form: Dual-Snake Aiming Possession
 - Repelling Defense Arts, Ethereal Unity Style, Rightful Dao Form: Triple Orthodox Twisting Vigor
 - Repelling Domination Arts, Holy Yang Style, Scale Form: Six Following Move
 - Repelling Leech Arts, Mad Tidal Waning Style, Motion Form: Skill-Biting Boxing Ascension
 - Repelling Magnanimous Crown Arts, Eternal Fortress Style, Traceless Pillar Form: Six Sacrificing Variation
 - Repelling Nefarious Yellow Darkwind Arts, Dual Self Style, Feral Bodhi Form: Five-Fold Blood Slicing View
 - Repelling Prism Arts, Brilliant Frontier Style, Traceless Chaotic Crusher Form: Giant Triadic-Matching Warfield
\page

 - Repelling Quick Unrestrained Arts, Return Style, Glacial Hunyuan Form: Scarlet of the Daoist
 - Repelling Taiji Arts, Whirling Sealing True Style, Enlightened Plume Form: Fox Summoning Angel
 - Repelling Things Arts, Felling Frontier Style, Blazing Bone Form: Unveiled of Hell
 - Repelling Unshakable Wicked Bodhidharma Arts, Few Many Unified Style, Petal Buddha Form: Dragon-Defending Rightful Exorcism
 - Repelling White Domination Arts, Unparalleled Devouring Momentum Style, Feral Violent Mothers Form: Six Observing Shadowless
 - Repelling Wisdom Arts, Cold Repentant Undivinable Style, Shower Form: Scriptures
 - Repentant Advanced Waterfall Arts, Great Illusory Point Style, Hellish Eclipse Form: Six Traversing Transparency
 - Repentant Chill Arts, Single Projectile Style, Equal Precept Form: Blade Twisting Steps
 - Repentant Erupting Nape Arts, Ascent Style, Ancient Starlit Form: Triple Rends Feinting Veil
 - Repentant Gentle Dance Arts, Scale Style, Violent Sonata Form: Deep Range Matching Orthodox
 - Repentant Guard Arts, Adaptive Venomous Discipline Style, Twin Eagle Form: Way
 - Repentant Hexablaze Arts, Illusory Mind Style, Stunning Glide Form: Cobra of the Flight
 - Repentant Martial Battle Arts, Expansive Full Wood Style, Violent Hell Form: Leaves-Sleeping Divine Grove
 - Repentant Mastery Arts, Charging Pearlflower Style, Fading Volcano Form: Range of the Wicked Destroyer
 - Repentant Spin Arts, Gorge Style, Basic United Form: Mountian-Searching Wild Pierce
 - Repentant Split Arts, Ethereal Riding Resolve Style, Crazy Master Form: Cry of Leaves
 - Repentant Taihua Arts, Wing Style, Extra Hawk Form: Giant Reguard-Concealing Aura
 - Repentant Thousands Arts, Intoxicated Lost Style, Elemental Daoist Form: Rising Scale
 - Repentant Throw Arts, Secret Grappling Statue Style, Advanced Deep Shower Form: Five-Fold Pearlflower Soaring Ursine
 - Repentant Tigers Arts, Basic Instance Style, Chop Form: Breakthrough Weakening Harmony
 - Repentant Trio Arts, Facing Stream Style, Universal Titan Form: Majestic
 - Repentant Venom Arts, Yellow Violent Sanctity Style, Dividing Adaptive Intention Form: View-Feinting Skeletal Tremor
 - Repentant Volcano Arts, Gallant Monastery Style, Hellish Saint Form: Five-Fold Spear Taking King
 - Repentant Winds Arts, Extreme Taming Style, Kaleidoscope Form: Avatar Paralyzing Hit
 - Responsive Adaptive Absolute Myriads Arts, Shapeshifter Style, Spiritual Bind Form: Hawkstrider of the Tortoise
 - Responsive Crusher Arts, Extinguishing Canyon Style, Cardinal South Form: Flesh-Sacrificing Wild Assimilation
 - Responsive Deities Arts, Serene Sweeping Cawing Style, Ripping Dragontail Form: Constellation Ending Veil
 - Responsive East Arts, Icy Feral Dominating Style, Felling Martyr Form: Triple Lattice Summoning Nape
 - Responsive Exchange Arts, Dipper Style, Sanctum Form: Hoarforst of Trail
 - Responsive Full Fleche Arts, Wildfire Style, Thunderbolts Form: Battle-Draining Facing Riddle
 - Responsive Gallant Crystalline Gorge Arts, Ravenous Foxform Drop Style, Harmonious Snake Form: Dual-Mental Leaping Vampire
 - Responsive Healing Treading Maiden Arts, Earthen Distinction Style, Dirty Sheet Form: Fate of Royal
 - Responsive Height Arts, Continuous Black East Style, Grafting Manifestations Form: Six Drifting Radiance
 - Responsive Neck Arts, Illusory Signless Style, Pure Radiance Form: Exploding Rhythm
 - Responsive Spiritage Arts, Downward Dual Rampage Style, Saving Glow Form: Calm Pack Swaying Maiden
 - Responsive Tempest Arts, Throwing Paladin Style, Universal Reflect Form: Dao of the Fate
 - Responsive Toxin Arts, Blazing Tai Style, Unshakable Snake Form: Slayer Taking Exchange
 - Riding Binder Arts, Secret Eastern Death Style, Poisonous Calamity Form: Qintfade
 - Riding Chaos Arts, Extinguishing Netherworld Style, Unmatched Projectile Form: Gate of Tang
 - Riding Constellation Arts, Healing Gem Waves Style, Distinction Form: Triple Barrier Emerging Snakeform
\page

 - Riding Double Vile Shadowy Arts, Fertile Condor Style, Sonic Dive Form: Finishing Asterism Tearing Circle
 - Riding Encompassing Frozen Cloak Arts, Holy Palm Style, Unparalleled Momentum Form: North Penetration
 - Riding Exchange Arts, Responsive Elemental Cobra Style, Trill Form: Trial of the Misty
 - Riding Fading Neck Arts, Penetrating Shade Style, Emerald Center Form: Suffering-Freezing Infernal Nature
 - Riding Grand Liberated Prism Arts, Killing Mountian Style, Magnanimous Wicked Stance Form: Penetration of Cutter
 - Riding Grip Arts, Encompassing Obscure Icy Style, Liberated Woodland Form: Chariot of United
 - Riding Prestissimo Arts, Limitless Thundershock Style, Shattering Embracing Cosmos Form: Gust of Fish
 - Riding Qintfade Arts, Toxic Tablet Style, Grand Burst Form: Five-Fold Starlit Soaring Emptiness
 - Riding Trinity Arts, Onyx Venomous Northern Style, Sudden Order Form: Giant Bat-Unwavering Dipper
 - Riding Volcano Arts, Few Nothingness Style, Extinguishing Gentle Bat Form: Meditation of the Ceremony
 - Riding Wave Arts, Drunken Unknowable Virtuous Style, Buddhist Expansive Contemplate Form: Riddle of Illusion
 - Righteous Chaotic Elusive Pounce Arts, Calm Breeze Style, Old Featherweight Eagle Form: Coastal Taming Blowing Monk
 - Righteous Command Arts, Golden Sanctity Style, Vibrant Form: Balance-Swirling Immortal Vajrapani
 - Righteous Finger Arts, Crystalline Trident Style, Dual Unbound Form: Return of the Spirit Trail
 - Righteous Lord Arts, Secret Direction Style, Basic Frost Form: Six Tangled Sect
 - Righteous Marquis Arts, Elusive Cloud Style, Radiant Warrior Form: Dual-Needle Rises Divinities
 - Righteous Pinnacle Arts, Destructive Kings Style, Scarlet Form: Five-Fold Condor Unwavering Veiled
 - Righteous Rivers Arts, Formless Embrace Style, Snow Spiraling Heart Form: Truth of the Shooting Archery
 - Righteous Royal Arts, Spring Style, Ravenous Absorption Form: Lord of the Living Mind
 - Righteous Snake Arts, Yellow Transparency Style, Full Lightness Form: Five-Fold Needles Ending Hell
 - Righteous Spread Arts, Boundless Merciful Deep Style, Illuminating Traceless Summit Form: Snakeform Cleaving Tundra
 - Righteous Thunderwake Arts, Rhythm Style, Fiery South Form: Method of the Coated Poison
 - Righteous Timberfall Arts, Birthless Bow Style, Ethereal Pulse Form: Whirlwind of the Parallel
 - Righteous Walk Arts, Cinder Style, Single Wrath Form: Dual-Resonance Gathering Windrider
 - Rightful Augmented Surface Arts, Quick Crane Style, Glacial Mount Form: Dual-Venom Enduring Lotus
 - Rightful Balanced Latch Arts, Archery Style, Spectral Toil Form: Giant Zen-Taking South
 - Rightful Circulation Arts, Imperial South Style, Bloody Fury Form: Fish of the Mountian
 - Rightful Constellation Arts, Grand Monastery Style, Fiendish Brook Form: Crossing Wheel
 - Rightful Daybreak Arts, Aureate Nail Style, Continuous Cloak Form: Resonance of the Righteous Thaw
 - Rightful Earthen Slashes Arts, Great Unity Style, Unified Exploding Cosmos Form: South
 - Rightful Equal Unforgiving Elegance Arts, Corvid Emergence Style, Extra Circulation Form: Ursine-Grounding Riding Feather
 - Rightful Fatal Grappling Step Arts, Form Style, Golden Neck Form: Shapeshifter
 - Rightful Graceful Elder Arts, Shooting Flameball Style, Corvid Deity Form: Five-Fold Emergence Tangled Blaze
 - Rightful Guardian Arts, Repelling Mirage Creation Style, Deep Many Deity Form: Waltz of the Snow Nothingness
 - Rightful Kick Arts, Beasts Style, Ascending Outward Raven Form: Ladder Controlling Spike
 - Rightful Moonlit Grappling Cutter Arts, Shooting Claw Style, Penetrating Sonic Plume Form: Strikes of the Autumn
 - Rightful Mystic Storm Arts, Saving Trident Style, Wanderer Form: Five-Fold Volcano Confronting Touch
 - Rightful Prelude Arts, Interference Style, Boundless Extinguishing Fiend Form: Flow-Steeled Iron Dragon
 - Rightful Rock Arts, Countless Healing Stone Style, Consuming Road Form: Quartet Taking Cut
 - Rightful Serene Killer Arts, Twin Mad Counter Style, Unparalleled Technique Form: Western Wheel
\page

 - Rightful Steps Arts, Cosmic Refraction Style, Monastery Form: Gale of the Crystalline Sufferings
 - Rightful Throw Arts, Illusory Duck Style, Grand Discipline Form: Five-Fold Manifestation Airsplitting Pierces
 - Rightful Titan Arts, Advanced Nefarious Gallant Style, Extreme Silent Form: Six Ascending Poisons
 - Rightful Vibrant Arts, Ravenous Pure Hail Style, Astral Void Form: Intent of the Refraction
 - Ripping Fall Arts, Snow Zen Style, Forged Starlit Form: Crown
 - Ripping Governing Snowfield Arts, North Style, Few Lost Form: Might of the Chop
 - Ripping Mad Needle Arts, Center Icebolt Style, Current Tundra Form: Obscure North
 - Ripping Maelstrom Arts, Splitting Wisdom Style, Stellar Mindless Form: Chaotic Latch
 - Ripping Needles Arts, Absolute Dragontail Style, Rightful Palms Form: Triple Beasts Crushing Eclipse
 - Ripping Scholar Arts, Drift Style, Smashing Profound Unbounded Form: Temper-Concealing Buddhist Descent
 - Ripping Spirits Arts, Eternal Tremor Style, Unknowable Asterism Form: Dual-Vajrayana Stealing Cut
 - Rising Bronze Meditation Arts, Wild Block Style, Darkwind Form: Triple Unrestrained Bowing Poison
 - Rising Brook Arts, Wicked Acala Style, Hellish Comb Form: Mirror-Unwavering Toxic Depth
 - Rising Cold Violent Summit Arts, Protective Constellation Style, Yellow Throwing Trigrams Form: Yang Poking Blood
 - Rising Downward Vile Shell Arts, Lunar Trident Style, Dancing Suffering Form: Mind of Ghost
 - Rising Elegant Wicked Barrier Arts, Unified Ember Style, Distinction Form: Five-Fold Sound Drifting Interference
 - Rising Embracing Beam Arts, 64 Fold Traditional Primordial Style, Skill Form: Five-Fold Vitality Flowing Advent
 - Rising Fiend Arts, Rotation Style, Unmatched Jeweled Form: Hand of the Quick Pyre
 - Rising Glacial Aureate Breakout Arts, Continuous Bloody Basic Style, Elemental Felling Wing Form: Five-Fold Starlight Piercing Technique
 - Rising Heavenly Tempo Arts, Spectral Assault Style, Crossing Nomad Form: Authority of Crush
 - Rising Hydra Arts, Throwing Crystalline Asterism Style, Cutting Spread Form: Six Attacking Heavenhold
 - Rising Lunar Manipulation Arts, Metallic Earthly Mobility Style, Trail Form: Infernal Nomad
 - Rising Onyx Steel Arts, Traceless Brilliant Luminous Style, Arching Spearplay Form: Heaven-Falling Formless Feather
 - Rising Qintfade Arts, Crystalline Protector Style, North Karmic Form: Dual-Range Leaping Energy
 - Rising Responsive Leaf Arts, Consecutive Step Style, Traditional Forms Form: Bind of Seeds
 - Rising Retribution Arts, Parallel Chaotic Awakening Style, Cold Fist Form: Block-Scorching 43rd Perfusion
 - Rising Toxin Arts, Ghostly Sonic Blessed Style, Indestructible Repentant Spike Form: Six Linking Tea
 - Rising Vajrapani Arts, Petal Dance Style, Elusive Fortress Form: East of the Asura
 - Rising Wounding Moonlight Arts, Rebounding Facing Cold Style, Penetrating Dragon Form: Triple Daybreak Weakening Bamboo
 - Road Arts, Forged Incineration Style, Absolute Mirror Form: Dual-Bind Burning South
 - Rolling Advanced Ethereal Bite Arts, Moonlit Center Icy Style, Feral Rising Warrior Form: Rock
 - Rolling Brilliant Azure Lattice Arts, Foxform Endless Domain Style, Cawing Equine Temple Form: Execution of the Fleeting Prelude
 - Rolling Cardinal Formation Arts, Spiritual Vitality Style, Basilisk Form: Midsummer Shaolin Stealing View
 - Rolling Coral Massacre Arts, Ethereal Siege Style, Waning Swords Form: Triple Shadowy Blowing Warmaster
 - Rolling Elusive Mothers Arts, Spiral Style, Enlightenment Form: Chaotic Man Weakening Canyon
 - Rolling Equine Ceremony Arts, Scholar Style, Legged Emergence Form: Immortal Thrust Draining Mirror
 - Rolling Fading Cloak Arts, Obsidian Devouring Sun Style, Spiritual Master Form: Dual-South Grounding Nebula
 - Rolling Fist Arts, Evil Rends Style, Intention Form: Dual-Spread Grounding Bird
 - Rolling Liberated Infernal Kill Arts, Frosty Abyssal Web Style, Birthless Total Form: Icy Calamity Fighting Rends
 - Rolling Moonlight Arts, Spiritual Cremation Style, Center Noble Form: Dual-Descent Swirling Volley
\page

 - Rolling Mystery Arts, Whirling Defense Style, Invisible Unbound Form: Beam-Ascending Coastal Rectitude
 - Rolling Nefarious Ceremony Arts, Aureate Twin Motion Style, Malevolent Patriarch Form: Salvation
 - Rolling Shadow Tipsy Arts, Responsive Dew Style, Undivinable Snake Form: Origin Flowing Arm
 - Rolling Spiritage Arts, Arching Array Style, Southern Spin Form: Buddha of the Fading Ruin
 - Rolling Woods Arts, Calm Illuminated Style, Mighty Unknowable Embrace Form: Realm-Leaping Ravenous Bite
 - Roving Advanced Triadic Arts, Bronze Unrivaled Solar Style, Corrupted Starlit Form: Hit of the Blessing
 - Roving Deities Arts, Many Protective Mothers Style, Waning Center Form: Ape of Creation
 - Roving Extreme Abyssal Demon Arts, Rolling Arm Style, Extra Turtleback Form: Triple Titan Descending Flight
 - Roving Full Grappling Wolf Arts, Pyre Style, Mystic Triangle Form: Dual-Warfield Rises Thread
 - Roving Martial Thunderclap Arts, Burning Limitless Heavenly Style, Vermillion Body Form: Vajrapani-Rising Aureate Long
 - Roving Moonbeam Arts, Waning Tea Style, Outward Illuminated Form: Edge of the Soaring Suffering
 - Roving Precept Arts,  Fate Style, Spanning Bind Form: Toxin Stopping Sheet
 - Roving Tree Arts, Fading Perfect Counter Style, Range Form: Weaver-Lunging Adaptive Substitution
 - Roving Unshakable Cutter Arts, March Style, Shattering Elegance Form: Dance of Flames
 - Roving Whale Arts, Outward Principles Style, Sage Form: Dual-Reguard Carrying Scripture
 - Roving Woods Arts, Boxing Latch Style, Refraction Form: Dual Thread Flowing Patriarch
 - Sacred Bodhi Arts, Facing Devouring Augmented Style, Serene Flare Form: Harmonies of the Traceless
 - Sacred Dew Arts, Sudden Tundra Style, Single Dividing Domination Form: Mad Sheet Following Stun
 - Sacred Double Obsidian Fortress Arts, Ancient Living Truth Style, Absolute Realm Form: Embracing Kaleidoscope
 - Sacred Duck Arts, Spiraling Team Style, Advanced Deflection Form: Graceful Mystery
 - Sacred Legged Water Arts, Tearing Sight Style, Sonic Heritage Form: Giant Weapon-Commanding Butterfly
 - Sacred Motion Arts, Formless Ash Style, Transformation Form: Bodhi-Sharpening Moonlit Advent
 - Sacred Noble Arts, Advanced Shout Style, Extended Variation Form: Triple Mobility Shifting Self
 - Sacred Opposition Arts, Downward Galaxy Style, Soaring Gateways Form: Method
 - Sacred Order Arts, Crazy Sanctity Style, Finishing Touch Form: Wandering Fall
 - Sacred Paradise Arts, Legged Thunderbolts Style, True Roars Form: Triple Prayer Flying Torment
 - Sacred Phaseless Arts, Spectral Corvid Arching Style, Equine Crane Form: Flameball-Cleaving Endless Triadic
 - Sacred Pierces Arts, Mystic Cardinal Pinnacle Style, Beasts Form: Variation of the Spectral Rectitude
 - Sacred Prestissimo Arts, Cawing Limitless Soft Style, Liberated Defensive Chaos Form: Drift Bowing Soul
 - Sacred Road Arts, Priest Style, Stretched Form: Height Countering United
 - Sacred Sanctum Arts,  Mastery Style, Center Counter Form: Triple Prelude Scorching Kick
 - Sacred Severance Arts, Unified Secret Strength Style, Foxform Limitless Lance Form: Talon-Soothing Coated Destiny
 - Sacred Sudden Spiraling Latch Arts, Energy Style, Felling Shura Form: Five-Fold Motion Ascending Thunderwake
 - Sacred Sutra Arts, Corvid Killing Treading Style, North Embracing Flash Form: Five-Fold Bone Binding Death
 - Sacred Swarm Arts, Destructive Obsidian Fatal Style, Deep Rage Form: Vajrapani-Controlling Felling Void
 - Saving Army Arts, Kaleidoscope Style, Skeletal Team Form: Northern Stalwart Linking Shaolin
 - Saving Death Arts, Traditional Stomp Style, Harmonious Spear Form: Virtuous Polarm Confronting Brush
 - Saving Dominating Calm Malignant Arts, Profound Assault Style, Empty Tree Form: Things
 - Saving Dust Arts, Mothers Style, Fading Venom Form: Drop-Retreating Unrivaled Taming
 - Saving Extra Serene Light Arts, Drunken Body Style, Balanced Web Form: Cardinal Fall Swaying Opposition
\page

 - Saving Featherweight Tidal Mindscape Arts, Facing Advanced Grace Style, Dark Spirits Form: Hellish Thrust Stealing Motion
 - Saving Forest Arts, Astral Cutting Foxform Style, Starlight Form: Royal-Linking Grappling Trap
 - Saving Hellfire Arts, Moonlit Lightning Style, Traceless Blaze Form: Bird of the Downward Master
 - Saving Jeweled Arts, Abyssal Cutter Style, Burning Dance Form: Giant Brush-Observing Counter
 - Saving Waterfall Arts, Repelling Paradise Style, Basilisk Form: Toil Cutting Prelude
 - Saving Way Arts, Ripping Cloud Style, Destructive Sinister Form: Flow Stealing Interference
 - Sealing Azure Annihilation Arts, Corrupted Priest Style, Waning Fall Form: Shura-Poking Coastal Turtleback
 - Sealing Dual Salvation Arts, Sonic Whale Style, Crossing Governing Manifestation Form: Aura of Rain
 - Sealing Enlightened Echo Arts, Flesh Style, Swan Form: Hands of Blessing
 - Sealing Flare Arts, Traversing Dive Style, Center Specter Form: Fleeting Consciousness
 - Sealing Instance Arts, Quick Range Style, Spiritual Aegis Form: Mirage Taibai
 - Sealing King Arts, Diving Final Frosty Style, Strike Form: Proud Controlling Limbo
 - Sealing Order Arts, Intoxicated Triadic Style, Striking Malignant Form: Six Controlling Nail
 - Sealing Shaft Arts, Elegant Beak Style, Brilliant Sweep Form: Five-Fold Comb Linking Priest
 - Sealing Stroke Arts, Undivinable Curse Style, Crush Form: Dual-Prayer Grounding Mastery
 - Sealing Summit Arts, Dark Encompassing Responsive Style, Devouring Crane Form: Contemplate-Traversing Consuming Hit
 - Sealing Technique Arts, Quick Stalwart Style, Elegant Pinnacle Form: Ultimate Fist Covering Foundation
 - Secret Bloodthristy Red Whale Arts, Martial Countless Energy Style, Thread Form: Six Draining Mystery
 - Secret Bone Arts, Mystic Swing Style, Consecutive Divinities Form: Formless Madness
 - Secret Chop Arts, Ripping Birthless Big Style, Spiritual Frost Form: Thrust of the Yin
 - Secret Corrupted Encompassing Maiden Arts, Stellar Path Style, Iron Void Form: Dual-Arrow Lunging Tundra
 - Secret Defensive Buddha Arts, Adaptive Sacred Eruption Style, Thunderous Spin Form: Dual-Pulse Freezing Glide
 - Secret Disciple Arts, Coated Might Style, Flash Form: Giant Tea-Bowing Enemies
 - Secret Height Arts, Formless Repents Style, Elemental Woodland Form: Soul of the Eternal
 - Secret Infinite Shaolin Arts, Center Vine Style, Unified Self Form: Dual-Unbound Descending Nape
 - Secret Nails Arts, Emerald Birthless Change Style, Angel Form: Mystic Assault
 - Secret Resolve Arts, Invisible Serene Turtle Style, Fiery Torment Form: Spiritage-Bowing Wandering Harmonies
 - Secret Tablet Arts, Whirling Assaliants Style, Black Riddle Form: Projectile-Resonating Skeletal Cutter
 - Secret Thunderous Assault Arts, Righteous Distinction Style, Fading Trap Form: Basilisk of the Crash
 - Serene Arching Old Jeweled Arts, Crimson Ridge Style, Void Form: Triple Bind Sacrificing Swing
 - Serene Ember Arts, Unforgiving Ash Style, Penetrating Kick Form: Giant Zenith-Transforming Rage
 - Serene Fatal Discipline Arts, Glacial Illuminated Style, Quick Guard Form: Viper of Polearm
 - Serene Fish Arts, Dominating Nullification Style, Granite Form: Six Walking Weaver
 - Serene Holy Vibrant Arts, Hexablaze Style, Mysterious Stretched Form: Punch Confronting Sun
 - Serene Severance Arts, Rebounding Sound Style, Dancing Graypine Form: Parallel of the Living Mystery
 - Serene Shaolin Arts, Erupting Crossing Dancing Style, Sanctity Form: Hands-Shifting Crazy Trill
 - Serene Snowlocked Arts, Harmonious Spiraling Lunar Style, Rends Form: Five-Fold Coil Falling Stun
 - Serene Taebaek Arts, Big Zen Style, Opposition Form: Giant Eruption-Controlling Vairocana
 - Serene Taiji Arts, Azure Facing Flight Style, Rebounding Gale Form: Triple Rectitude Falling Snakeform
 - Serene Void Gallant Tai Arts, Augmented Technique Style, Continuous Waterfall Form: Crusher of the Light
\page

 - Shadow Angel Arts, Charging Formless Radiant Style, Mysterious Method Form: Six Resonating Destroyer
 - Shadow Boulder Arts, Nebula Style, Magnanimous Orthodox Form: Rhythm of the Deities
 - Shadow Burning Kill Arts, Bloodthristy Needles Style, Southern Elegant Assaliants Form: Vedas-Leaping Descending Skull
 - Shadow Chackra Arts, Lunar Unified Old Style, Spectral Space Form: Giant Incineration-Flaming Crane
 - Shadow Circulation Arts, Onyx Eternal Style, Lower White Thoughtless Form: Giant Shadowless-Slicing Arhat
 - Shadow Cobra Arts, Evil Tablet Style, Dual Sealing Thunderbolt Form: Six Draining Frenzy
 - Shadow Dancing Spiral Arts, Shooting Cursed Pounce Style, Solar Eruption Form: Six Breaking Daoist
 - Shadow Elements Arts, Shooting Brilliant Roving Style, Imperial Domination Form: Roars-Flaming Finishing Tang
 - Shadow Gallant Raven Arts, Felling Slash Style, Downward Split Form: Six Observing Vajrayana
 - Shadow Luminous Hawkstrider Arts, Giant Extended Absolute Style, Killing Intent Form: Dual-Pounce Paralyzing Reflection
 - Shadow Mind Arts, Defensive Balanced Secret Style, Mighty Bear Form: Sage-Descending Extra Ripple
 - Shadow Onyx Healing Height Arts, Wounding Southern Void Style, Battle Form: Giant Turtleback-Commanding Roars
 - Shadow Poisonous Absolute Valley Arts, Dual Mount Style, Corvid Drop Form: Triple Triangle Revitalizing Rhythm
 - Shadow Song Arts, Leaf Style, Augmented Elegance Form: Dual-Blossoms Poking Gate
 - Shadow Spiraling Veil Arts, Tearing Fortress Style, Western Windrider Form: Limbo Ending Prayer
 - Shadow Taiji Arts, Scarlet Style, Rising Triangle Form: Tremor Paralyzing Order
 - Shadow Undivinable Palm Arts, Disinterment Style, Center Thirst Form: Triple Harmonies Cutting Judgment
 - Shadow Variation Arts, Equine Lance Style, Wicked Bodhi Form: Mothers of the Petal Asterism
 - Shattering Bat Arts, Azure Monkey Style, Leaves Form: Mount of the Center Maiden
 - Shattering Bronze Graceful Balance Arts, Arching Spanning Encompassing Style, Buddhist Chariot Form: Extended Starvation Taking Parallel
 - Shattering Devastation Arts, Diving Stealth Style, Frosty Yin Form: Snakeform of the Enigma
 - Shattering East Arts, Astral Ripping Wind Style, Repelling Book Form: Hell
 - Shattering Fate Arts, Celestial Rotation Style, Divinities Form: Five-Fold Lofty Emerging Ghost
 - Shattering Grip Arts, Blooming Acala Style, Eastern Fiend Form: Burst of the Proud
 - Shattering Iron Smashing Incineration Arts, Foxform Equine Prelude Style, Destructive Pillar Form: Hand of Ink
 - Shattering Mountain Arts, Ascending Forged Light Style, Toxic Specter Form: Hands of the Yellow Tempo
 - Shattering Script Arts, Equine Opening Style, Encompassing Sealing Tigers Form: Kill-Going Healing Lance
 - Shattering Secret Charging Arm Arts, Bronze Featherweight Sea Style, Governing Dance Form: Five-Fold Sisi Dispersing Noble
 - Shattering Taebaek Arts, Facing Leaf Style, Scriptures Form: Light of Split
 - Shattering Thaw Arts, Stunning Pure Double Style, Aquatic Chop Form: Sound Confronting Precept
 - Shattering Thoughtless Arts, Pulse Style, Fatal Pines Form: Bodhidharma of Sisi
 - Shattering Tremor Arts, Roving Royal Style, Protective Traditional Netherworld Form: Dual-Demon Shaking Spiritage
 - Shooting Azure Graceful Gate Arts, Downward Halo Style, Emerald Light Form: Martial Mental
 - Shooting Block Arts, Infernal Boulder Style, Fertile Whip Form: Five-Fold Skill Lunging Beasts
 - Shooting Boxing Scarlet Arts, Paradise Style, Bamboo Form: Grand Transparency Blowing Crushes
 - Shooting Bright Holy Delights Arts, Butterfly Style, Cutting Burning Mount Form: Projectile
 - Shooting Disinterment Arts, Intoxicated Advent Style, Eternal Nails Form: Millennium of the Bronze Proud
 - Shooting Dragon Arts, Spiral Style, Invisible Energy Form: Coated Throw Grounding Blossoms
 - Shooting Enigma Arts, Charging Vine Style, Birthless Nether Form: Condor of the Grace
 - Shooting Firebrand Arts, Forged Aspects Style, Basic Quanzhen Form: Spin of Reflect
\page

 - Shooting Gust Arts, Fiery Origin Style, Unified Signless Form: Dual-Thunderclap Following Waltz
 - Shooting Heritage Arts, Moonlit Paladin Style, Bright Unveiled Form: Repents
 - Shooting Ice Arts, Death Style, North Form: Six Soaring Authority
 - Shooting Lofty Arts, Bloodthristy Wood Style, Hawk Form: Triple Opening Breaking Exorcism
 - Shooting Maelstrom Arts, Perfect Unrestrained Style, Scripture Form: Radiant Siege
 - Shooting Needle Arts, Living Toxin Style, Rising Avatar Form: White Strike
 - Shooting Nether Arts, Forged Solar King Style, Sweeping Breakthrough Form: Giant Fleche-Observing Pack
 - Shooting Pack Arts, Spinning Mystic White Style, Quick Roar Form: Six Searching Retribution
 - Shooting Profound Sage Arts, Tranquil Style, Mirage Crusher Form: Dragontail
 - Shooting Raven Arts, Consecutive Granite Style, Mystic Wrath Form: Dual-Cleave Chopping Phaseless
 - Shooting Repentant Equine Tundra Arts, Lord Style, Parallel White East Form: Giant Pierce-Rises Maiden
 - Shooting River Arts, Protective Ruin Style, Enlightened Light Form: Eagle-Fighting Crystalline Thrust
 - Shooting Seaspan Arts, Bloodstained Corvid Waves Style, Rebounding Nails Form: Triple Interference Twisting Shade
 - Shooting Switch Arts, Trio Style, Unified Death Form: Triple Vampire Dispersing Summit
 - Shooting Temple Arts, Smoke Style, Advanced Butterfly Form: Dual-Manipulation Soaring Infiltration
 - Shooting Thunderous Priest Arts, Coated Void Style, Countless Shaolin Form: Saint
 - Shooting Triadic Arts, Ultimate Splitting Tidal Style, Ethereal Stance Form: Five-Fold Viper Soaring Pyrocascade
 - Shooting Vile Order Arts, Kings Style, Quick Hidden Quell Form: Endless Pear Summoning Cross
 - Silver Buddha Arts, Mysterious Onyx Kill Style, Sufferings Form: Bear Aiming Instance
 - Silver Domain Arts, Exploding Raptor Style, Lunar Calamity Form: Five-Fold Asura Vispering Reflect
 - Silver Drain Arts, Chaotic Destroyer Style, Continuous Foxform Venom Form: Giant Martyr-Controlling Sheet
 - Silver Feral Spike Arts, Pure Exchange Style, Leap Form: Six Covering Arm
 - Silver Gentle Wild Mirror Arts, Exploding Team Style, Gem Sword Form: Raptor of the Bronze Drop
 - Silver Infinite Angel Arts, Cardinal Pattern Style, Consecutive Resonance Form: Creation-Swirling Sonic Lord
 - Silver Signless Arts, Balanced Responsive Grand Style, Perfect Heritage Form: Destructive Siege Taking Counter
 - Silver Sonic Transparency Arts, Expansive Triadic Style, Aureate Ruin Form: Six Dodging Consonance
 - Silver Spiritual Barrier Arts, Continuous Titan Style, Many Rhythm Form: Tea of the Magnanimous Hawk
 - Silver Sugar Arts, Blessed Virtuous Spanning Style, Equine Projectile Form: Six Flying Claw
 - Silver Underworld Arts, Scholar Style, Starvation Form: Five-Fold Spirits Observing Enigma
 - Single Beasts Arts, Coastal Nefarious Emperor Style, Thunderous Break Form: Vampire-Revitalizing Infernal Saber
 - Single Book Arts, Qintfade Style, Consuming Decree Form: Leaves of the Toil
 - Single Calm Emptiness Arts, Intoxicated Illuminating Virtuous Style, Copper Living Refraction Form: Rapid of the Fairy
 - Single Consuming Splitting Tide Arts, Mirage Song Style, Shooting Gallant Sinister Form: Return of the Scripture
 - Single Dominating Defensive Ash Arts, Liberated Chin Style, Shadow Illuminated Form: Leniency
 - Single Fatal Silent Arts, Enemies Style, Counter Form: Riding Flashes Stealing Serpent
 - Single Myriads Arts, Elegant Legs Style, Enemy Form: Return
 - Single Myriads Arts, Traceless Luminous Canyon Style, Saving Vajrapani Form: Dancing Enemies
 - Single Nomad Arts, Throwing Magnanimous Warrior Style, Augmented Palm Form: Legged Cross Soothing Family
 - Single Ridge Arts, Sonic Rolling Trigrams Style, Extreme Thousands Form: Triple Drain Conquering Trial
 - Single Starlit Arts, Frozen Tongue Style, Shadowy Form: Six Confronting Move
\page

 - Single Surge Arts, Manipulation Style, Infinite Vairocana Form: Light of the Unrivaled Hunyuan
 - Skeletal Army Arts, Giant Cinder Style, Buddhist Midsummer Waltz Form: Mighty Ghost Matching Sound
 - Skeletal Extended Shroud Arts, Living Center Style, Chill Form: Triple Elbow Twisting Elegance
 - Skeletal Killing Twin Water Arts, Foundational Long Style, Descending Night Form: Five-Fold Destruction Traveling Horse
 - Skeletal Metal Arts, Gallant Mirror Style, Killing Skills Form: Ink of the Strike
 - Skeletal Mist Arts, Sword Style, Twin Crows Form: Onyx Beggar
 - Skeletal Nape Arts, Aura Style, Holy Claw Form: Triple Ice Crouching Consonance
 - Skeletal Ripping Bodhidharma Arts, Spiritual Cultivation Style, Downward Direction Form: Mad Martyr Paralyzing Spike
 - Skeletal Saint Arts, Bright Soul Style, Blister Form: Aegis-Airsplitting Cutting Step
 - Skeletal Shroud Arts, Saving Lunar Sylvan Style, 95th Cultivation Form: Five-Fold Leaves Biting Disruption
 - Skeletal Shura Arts, Responsive Unbound Style, Endless Viper Form: Giant Fiend-Blooming Severance
 - Skeletal Trial Arts, Stunning Traversing Blood Style, Repentant Exchange Form: Body of the East
 - Skeletal Unbound Arts, Subduing Frosty Battle Style, Seaspan Form: Triple Condor Weakening Thoughtless
 - Skeletal United Arts, Formless Ripping Facing Style, Single Giant Lofty Form: Giant Volcanoes-Aiming Protector
 - Skeletal Valley Arts, Roars Style, Crazy Transformation Form: Maiden Coiling Manifestations
 - Skeletal Wandering Great Decree Arts, Gentle Infernal Fiendish Style, Facing Sweeping Blaze Form: Thread
 - Skeletal Western Cloud Arts, Radiant Blessing Style, Traceless Weapon Form: Devastation of Hit
 - Slicing Astral Big Water Arts, Stellar Subduing Ultimate Style, Team Form: Five-Fold Hit Carrying Manifestations
 - Slicing Astral Spiraling Wheel Arts, Unparalleled Plume Style, Exploding Trill Form: Drop Rises Gorge
 - Slicing Blooming Wing Arts, Final Beam Style, Apex Woods Form: Sweetened of Nether
 - Slicing Breakout Arts, Illuminating River Style, Reaper Form: Thread-Piercing Northern Move
 - Slicing Brush Arts, Bound Style, Illusory Breakout Form: Absolute Vajrapani
 - Slicing Eruption Arts, Gentle Wanderer Style, Protective Mirrored Form: Mighty Harmony
 - Slicing Imperial Throw Arts, Parallel Reaction Style, Millennium Form: Giant Wolf-Chopping Condor
 - Slicing Intoxicated Charge Arts, True Nefarious Emerald Style, Wandering Scheme Form: Triple Breaker Paralizing Hit
 - Slicing Jade United Arts, Riddle Style, Old Forged Stone Form: Six Tangled Chackra
 - Slicing Lightweight Arts, Devastating Tongue Style, Feral Precept Form: Smashing Bow Freezing Lotus
 - Slicing Silent Arts, Few Basic Cyclone Style, Brilliant Trial Form: Giant Void-Draining Destroyer
 - Slicing Stance Arts, Rising Soul Style, Aquatic Sheet Form: Virtuous Lord
 - Slicing Stellar Brilliant Shockwave Arts, Harmonious Outward Arching Style, Moonbeam Form: Five-Fold Disciple Confronting Enigma
 - Smashing Aquatic Bodhi Arts, 60th  Suffering Style, Unknowable Fate Form: Giant Meridian-Cleaving Master
 - Smashing Dawn Arts, Martial Priest Style, Feral Hell Form: Five-Fold Sun Going Life
 - Smashing Earthen Waxing Return Arts, Crimson Trinity Style, Malignant Form: Delights Vispering Refraction
 - Smashing Grove Arts, Waxing Beasts Style, Profound Pillar Form: Annihilation-Dispersing Abyssal Light
 - Smashing Illuminating Sudden Unbound Arts, Hidden Shattering Perfect Style, Trail Form: Body of Shadowless
 - Smashing Infinite Soaring Prayer Arts, Boundless Hit Style, Slicing Rage Form: Wanderer Dispersing Talon
 - Smashing Prelude Arts, Bird Style, Infernal Bind Form: Triple Transparency Severing Spark
 - Smashing Repelling Unshakable Crows Arts, Cosmic Arrows Style, Shadow Spread Form: Five-Fold Needle Paralizing Qintfade
 - Smashing Signless Arts, Devouring Illusory North Style, Center Destruction Form: Triple Glide Slicing Devastation
 - Smashing Volcano Arts, Infinite Sanctity Style, Primordial Leech Form: Harmonies of the Invisible Wanderer
\page

 - Snow Archery Arts, Birthless Swing Style, Indestructible Frenzy Form: Change
 - Snow Asterism Arts, Few Spiritual Rapid Style, Chaotic Devastation Form: Five-Fold Polarm Counterattacking Paradise
 - Snow Earthquakes Arts, Holy Foxform Sonic Style, Moonlit Remains Form: Master Enduring Breaker
 - Snow Gold Arts, Thrust Style, Intoxicated Skills Form: Toxin of the Ascending Crusher
 - Snow Gorge Arts, Principles Style, Ripping Staff Form: Calm Circle
 - Snow King Arts, Dominating Stride Style, Heartless Shadowless Form: Timberfall
 - Snow North Arts, Immortal Way Style, Encompassing Halo Form: Total Concealing Chackra
 - Snow Onyx Shade Arts, Legged Icebolt Style, Dance Form: Slayer of the Exploding Lord
 - Snow Pine Arts, Shift Style, Invisible Breakout Form: Pure Kundali
 - Snow Posture Arts, Spiritual Truth Style, Deep Frostbite Form: Throwing Nether
 - Snow Swift Arts, Crossing Riddle Style, Foundational Punch Form: Lightweight-Poking Coastal Emptiness
 - Snow Toxin Arts, Grappling Cold Secret Style, Stunning Martyr Form: Range of the Great Asterism
 - Snow Underworld Arts, Ultimate Unified Quell Style, Tide Form: Hoarforst of the Pearlflower
 - Snow Violent Diving Pines Arts, Grappling Vigor Style, Raptor Form: Virtuous Condor
 - Soaring Daybreak Arts, Calm Western Bloody Style, Consuming Strength Form: Opposition of Lost
 - Soaring Defiers Arts, Swan Style, Extended Hail Form: Duck-Rises Coated Footstep
 - Soaring Descent Arts, Sweeping Heat Style, Foxform Roving Strikes Form: Weaver of the Wildfire
 - Soaring Final Execution Arts, Corrupted Full Duck Style, Perfect Touch Form: Giant Asura-Breaking Domain
 - Soaring Indestructible Tide Arts, Nape Style, Charging Current Sun Form: Five-Fold Fall Twisting Crow
 - Soaring March Arts, Mad Cavern Style, Grounded Absorption Form: Six Defending Truth
 - Soaring Scholar Arts, Traversing Blaze Style, Spiritual Sections Form: Illuminated-Summoning Repelling Creation
 - Soaring Stellar Toxic Song Arts, Earthen Malevolent Leap Style, Dual Pear Form: Five-Fold Elements Vispering Way
 - Soaring Storm Arts, Poisonous Cultivation Style, Gallant Thunder Form: Giant Grasp-Breaking Charge
 - Soaring Trident Arts, Embracing Fertile Bloody Style, Malevolent Vitality Form: Feral Stealth Severing Shaft
 - Soaring View Arts, Height Style, Outward Magnanimous Elegance Form: Thousands-Drifting Glacial Lofty
 - Soaring Virtuous Sun Arts, Stellar Taihua Style, Coated Circulation Form: Giant Temper-Taking Domination
 - Solar Burning Obsidian Sufferings Arts, Wild Martyr Style, Phoenix Form: Tang
 - Solar Commander Arts, Stellar Deep Capped Style, Mirage Bolt Form: Crushes of Phoenix
 - Solar Cosmic Storms Arts, Stroke Style, Crazy Opposition Form: Five-Fold Tang Controlling Fist
 - Solar Earthly Beasts Arts, Dirty Disciple Style, Ascending Polarm Form: Calm Rampage Matching Advent
 - Solar East Arts, Warmaster Style, Foundational Daoist Form: Giant Flame-Linking Snake
 - Solar Felling Element Arts, Assaliants Style, Dipper Form: Triple Glow Countering Windrider
 - Solar Final Mirage Remains Arts, Poisonous Governing Aquatic Style, Whale Form: Imperial Protector Draining Omnidirectional
 - Solar Infernal Splitting Millennium Arts, Spiraling Whale Style, Grand Family Form: Annihilation of Gust
 - Solar March Arts, Birthless Aureate Frozen Style, Unforgiving Warmaster Form: Order Concealing Mistveil
 - Solar Paradise Arts, Scriptures Style, Instance Form: Giant Triple-Transforming Zen
 - Solar Profound Gallant Mount Arts, Ascending Grappling Disinterment Style, Throwing Dust Form: Foundation of Illusion
 - Solar Quanzhen Arts, Fatal Boxing Elegance Style, Unified Tea Form: Circulation of the Equine Latch
 - Solar Ravenous Fairy Arts, Reaper Style, Diving Mystic Unrestrained Form: Hell of the Crossing Nether
 - Solar Rebounding Malevolent Waterfall Arts, Bloodstained Traversing Glacial Style, Calm Staff Form: Six Ending Yang
\page

 - Solar Shadowy Arts, Chaotic Bat Style, Traversing Cursed Polarm Form: Cremation-Commanding Empty Veil
 - Solar Shard Arts, Extreme Heavenly Capped Style, Virtuous Monastery Form: Snow Shade
 - Solar Taihua Arts, Song Style, Spectral Ocean Form: Wisdom of North
 - Solar Tiger Arts, Hidden Origin Style, Hit Form: Six Searching Center
 - Solar Transformation Arts, Serene Claw Style, Harmonious Raptor Form: Six Taking Hell
 - Solar Venomous Cutting Taibai Arts, Element Style, Imperial Flower Form: Hidden Woods
 - Solar Warfield Arts, Big Master Style, Advanced Royal Form: Six Reflecting Perfusion
 - Sonic Burning Yin Arts, Infinite Galaxy Style, Roars Form: Frenzy of Wisdom
 - Sonic Cold Omnidirectional Arts, Midsummer Titan Style, Traceless Form: Barrier
 - Sonic Crystalline Hidden Plume Arts, Healing Intention Style, Whale Form: Destroyer Crushing Moon
 - Sonic Drowned Arts, Fatal Consecutive Discipline Style, Snow Vairocana Form: Clarity of the Tail
 - Sonic Gate Arts, Bloodstained Ghostly Road Style, Endless Star Form: Chaos-Shifting Grand Cavern
 - Sonic Heavenly Creation Arts, Dominating Stalwart Style, Fatal Binder Form: Ethereal Fortress
 - Sonic Pearlflower Arts, Toxic Elusive Blessing Style, Balanced Consonance Form: Nothingness of the Foxform Substitution
 - Sonic Rivers Arts, Aegis Style, Heavenly Bat Form: Blessing of the Frontier
 - Sonic Taming Arts, Absolute Path Style, Gentle Bamboo Form: Triple Archery Flowing Tablet
 - Sonic Temple Arts, Absolute Defensive Glow Style, Galaxy Form: Grappling Millennium
 - Sonic Windswept Arts, Bloody Saint Style, Forged Breaker Form: Dual-Sylvan Leaping Cry
 - Southern Acala Arts, Limitless Noble Style, Vigor Form: Giant Cutter-Tangled Walk
 - Southern Birthless Split Arts, Corrupted Extended Unrestrained Style, Soaring Origin Form: Six Following Throw
 - Southern Counter Arts, Drift Style, Crush Form: Nebula of Acala
 - Southern Defense Arts, Nomad Style, Featherweight Elbow Form: Five-Fold Illuminated Draining Wildfire
 - Southern Golden Boxing Swan Arts, Advanced Spirits Style, Skeletal Disinterment Form: Dual-Dipper Following Neck
 - Southern Haunt Arts, Judgment Style, Dividing Rhythm Form: Volley of Wolf
 - Southern Hellish God Arts, Whirling Element Style, Interference Form: Twin Sound Ensnaring Siege
 - Southern Lattice Arts, Center Exploding Protective Style, Coated Cry Form: Triple Star Carrying Vampire
 - Southern Liberated Touch Arts, Corrupted Triple Style, Elusive Force Form: Giant Dance-Feinting Necrotoxin
 - Southern Limbo Arts, Icy Mad Moonlit Style, Enlightened Disruption Form: Giant Chill-Summoning Array
 - Southern Polarm Arts, Paladin Style, Unbounded Form: Vermillion Aspects
 - Southern Retribution Arts, Icy Wraith Style, Soaring Equal Defiers Form: Triple Pear Deflecting Torment
 - Southern Skeletal Spiraling Battalion Arts, Rolling Vermillion Finishing Style, Endless Battle Form: Triple Mindless Fighting Rotation
 - Southern Snake Arts, Universal Shura Style, Wounding Toxin Form: Swords of Vedas
 - Southern Strikes Arts, Infinite Echo Style, Sacred Buddhist Mobility Form: Shattering Fang Revitalizing Vitality
 - Southern Vairocana Arts, Parallel Jewel Style, Rising Interference Form: Volley of the Unparalleled Sound
 - Spanning Aegis Arts, Foundational Hunyuan Style, Grounded Team Form: Celestial Hawkstrider Transforming Form
 - Spanning Hexablaze Arts, Twin Equal Burning Style, Quick Inferno Form: Mirror Sleeping Block
 - Spanning Martial Equine Fairy Arts, Wild Taibai Style, Divine Forest Form: Triple Sweep Crushing Mastery
 - Spanning Secret Devastating Bodhidharma Arts, Nefarious Ravenous Forged Style, Undivinable Sky Form: Demon of Summit
 - Spanning Shower Arts, Solar Weaver Style, Bright Whirling Ascent Form: Dual-Necrotoxin Drifting Trident
 - Spanning Style Arts, Dark Mirror Style, Consuming Pines Form: Necrotoxin Shifting Mindscape
\page

 - Spectral Burning Wild Leaves Arts, Coastal Point Style, Prajna Form: Five-Fold Soul Leaping Crane
 - Spectral Force Arts, Skeletal Mind Style, Tail Form: Giant Prayer-Airsplitting Sui
 - Spectral Gate Arts, Full Adaptive Flying Style, Legged Flare Form: Dual-Judgment Ensnaring Salvation
 - Spectral Horse Arts, Violent Valley Style, Ethereal Switch Form: Transparency Freezing Limbo
 - Spectral Illusory Cosmos Arts, Incineration Style, Wild Basilisk Form: Triple Force Traveling Bite
 - Spectral Killing Roar Arts, Surface Style, Perfect Millennium Form: Triple Cutter Reflecting Beak
 - Spectral Mysterious Stun Arts, Primordial Path Style, Manifestations Form: Giant Vine-Ascending Resonance
 - Spectral Shattering Final Constellation Arts, Protective Fist Style, Saving Phenomena Form: Beak of the Cutter
 - Spectral Swarm Arts, Encompassing Web Style, Living Shura Form: Five-Fold Woodland Flying Cultivation
 - Spectral Vajrayana Arts, Twin Breaker Style, Foundational Aureate Smoke Form: Six Concealing Element
 - Spectral Veiled Arts, Ripping Frozen Celestial Style, Striking Boundless Elegance Form: Giant Body-Binding Suppression
 - Spinning Cosmic Glacial Saber Arts, Shattering Enemy Style, Strikes Form: Harmony of the Fate
 - Spinning Creation Arts, Primordial Great God Style, Spiritual Stellar Counter Form: Raven of the Crow
 - Spinning Fatal Venomous Temper Arts, Chaotic Defensive Contemplate Style, Obscure Parallel Toil Form: Dual-Energy Shaking Prayer
 - Spinning Heritage Arts, Obsidian Mind Style, Monastery Form: Dual-Array Confronting Shout
 - Spinning Inferno Arts, Killing Sinister Style, Cawing View Form: Manifestations of Piercer
 - Spinning Ladder Arts, Bloodthristy Riding Heavenhold Style, Sonic Giant Beast Form: Dual-Waters Weakening Kings
 - Spinning Lance Arts, Thaw Style, Rightful Specter Form: Unity-Draining Mighty Waltz
 - Spinning Rebounding Embrace Arts, Mad Traceless Style, Retribution Form: Swing-Grounding Extended Wave
 - Spinning Smoke Arts, Rightful Destroyer Style, Indestructible Daoist Form: Dual-Immovable Drifting Night
 - Spinning Sudden Solar Shadowy Arts, Sanctity Style, Northern Toil Form: Hit Biting Destruction
 - Spinning Wind Arts, Formless Army Style, Enlightened Shroud Form: Six Bowing Drop
 - Spiraling Crystalline Crazy Move Arts, Rising Bodhidharma Style, Fall Form: Triple Heavenhold Cutting Cove
 - Spiraling Ethereal Bodhi Arts, Mad Brook Style, Featherweight Dancing Death Form: Five-Fold Glow Walking Authority
 - Spiraling Final Total Arts, Martial Rectitude Style, Glacial Substitution Form: Skeletal Lightness Following Destiny
 - Spiraling Giant Shell Arts, Mindscape Style, Malevolent Grace Form: Fury of the Vairocana
 - Spiraling Graceful Wing Arts, Gem Undivinable Embrace Style, Basic Beasts Form: Blossom Freezing Stab
 - Spiraling Heavenly Spike Arts, Coastal Equine Obscure Style, Block Form: Unmatched Royal Ending Warfield
 - Spiraling Hit Arts, Fiendish Long Style, Fiery Frosty Kings Form: Bone of the Discipline
 - Spiraling Jewel Arts, Poisonous Glow Style, Equine Weaver Form: Dancing Hawkstrider
 - Spiraling Millennium Arts, Countless Lower Sweeping Style, Fatal Winds Form: Riddle of the Polearm
 - Spiraling Scholar Arts, Firebrand Style, Boundless Crimson Opening Form: Giant Skills-Binding Road
 - Spiraling Trail Arts, Spanning Windrider Style, Wounding Tongue Form: Forged Lotus
 - Spiraling Traversing Ethereal Forms Arts, Burst Style, Boundless Fog Form: Giant Death-Binding Spread
 - Spiraling Treading Asterism Arts, Waning Shura Style, Many Crystalline Ape Form: Rivers
 - Spiraling Whirling Finger Arts, Smashing Blade Style, Capped Hell Form: Six Summoning Creation
 - Spiraling Whirling Quick Graypine Arts, Coral Ascent Style, Vile Assimilation Form: Beasts of the Archery
 - Spirit Chariot Arts, Devouring Augmented Unforgiving Style, Skeletal Swift Form: Giant Defiers-Freezing Tail
 - Spirit Devouring Black Massacre Arts, Sinister Style, Drunken Truth Form: Decree of the Starlight
 - Spirit Elegant Thunderwake Arts, Grafting Ripping Feather Style, Luminous Lightning Form: Cinder
\page

 - Spirit Frontier Arts, Emerald Pierces Style, Shooting Reaper Form: Cleave of the Pure Quick
 - Spirit Glacier Arts, Traditional Essence Style, Elusive Breaker Form: Triple Saint Observing Remains
 - Spirit Inferno Arts, Equal Vermillion Scripture Style, Hellish Graceful Contemplate Form: Dual-Tong Draining Void
 - Spirit Ladder Arts, Expansive Dao Style, Vile Consuming Block Form: Six Scorching Ridge
 - Spirit Living Foundational Omnidirectional Arts, Dividing King Style, Single Weaver Form: Song of the Bird
 - Spirit Mind Arts, Spinning Direction Style, Perfect Sheet Form: Rotation of the Walk
 - Spirit Paladin Arts, Midsummer Moonbeam Style, Facing Bolt Form: Dual-Domination Biting Saint
 - Spirit Quick Asura Arts, Tidal Overwash Style, Equine Priest Form: Toxic Fang Confronting Triadic
 - Spirit Shattering Healing Demon Arts, Dominating Infinite Giant Style, Stride Form: Bird Sleeping Flower
 - Spirit Song Arts, Extended Profound Pearl Style, Infiltration Form: Center of the Red Lattice
 - Spirit Stretched Arts, Coral Wicked Roving Style, Destructive Mental Form: Raptor
 - Spirit Technique Arts, Elemental Spearplay Style, Mysterious Body Form: Five-Fold Stealth Defending Toil
 - Spirit Unveiled Arts, Heavenly Tranquil Style, Unmatched Vigor Form: Splitting Substitution Linking Crushes
 - Spiritual Adaptive Skull Arts, Bodhi Style, Mastery Form: Five-Fold Rocky Crouching Chain
 - Spiritual Bind Arts, Flying Bird Style, Enlightened Battle Form: Six Falling Order
 - Spiritual Butterfly Arts, Tiger Style, Formation Form: Giant Gold-Taking Paradise
 - Spiritual Calm Binder Arts, Vermillion Mind Style, Cutting Thunder Form: Six Biting Cry
 - Spiritual Flash Arts, Single Embracing Binder Style, Sun Form: Legacy Draining Asterism
 - Spiritual Incineration Arts, Prajna Style, Illusory Thousands Form: Blessing of Gust
 - Spiritual Killing Sharpened Arts, Golden Gallant Spark Style, Devastating Sect Form: Giant Infiltration-Fighting Sun
 - Spiritual Serpent Arts, Legged Fall Style, Full Illuminated Form: Graypine
 - Spiritual Silver Extended Descent Arts, Liberated Limitless Fairy Style, Radiant Lotus Form: Featherweight God
 - Spiritual Skill Arts, Unified Intoxicated Remains Style, North Hydra Form: Reflect Shattering Frontier
 - Spiritual Soar Arts, Dual Venom Style, Coastal Martyr Form: Rolling Wing Sharpening Cobra
 - Spiritual Swan Arts, Dark Eagle Style, Hellish Mountian Form: Giant Trill-Emerging Trail
 - Spiritual Tablet Arts, Expansive Rock Style, Element Form: Long
 - Spiritual Traceless Arts, Finger Style, Parallel Noble Form: Five-Fold Energy Scorching Lightning
 - Splitting Ash Arts, Apex Astral Wounding Style, Spread Form: Taming
 - Splitting Cliff Arts, Enlightened Gateways Style, Dark Wheel Form: Governing Polar Ascending Barrage
 - Splitting Lightness Arts, Transformation Style, Primordial Flash Form: Erupting Prism Stealing Shapeshifter
 - Splitting Smashing Deep Talon Arts, Grand Ash Style, Living South Form: Corvid Vairocana Sacrificing Arhat
 - Splitting Suppression Arts, Grand Beasts Style, Arrow Form: Shatters
 - Splitting White Malevolent Woodland Arts, Crossing Nail Style, Cardinal Felling Rampage Form: Five-Fold Clarity Cutting Ripple
 - Stellar Consuming Contemplate Arts, Pearlflower Style, Merciful Judgment Form: Blessed Firebrand Airsplitting Unity
 - Stellar Fleeting Drain Arts, Adamantine Flameball Style, Continuous Demonic Projectile Form: Six Dodging United
 - Stellar Icy Weaver Arts, Balanced Neck Style, Haunt Form: Destruction of Elegance
 - Stellar Mastery Arts, Indestructible Radiant North Style, Cloak Form: Triple Madness Soothing Technique
 - Stellar Needle Arts, Grafting Volley Style, Healing Mistveil Form: Triple Eternal Dispersing Gateways
 - Stellar Single Ascending Gold Arts, Skeletal Riding Sinister Style, Consuming Stalwart Form: Quick of Projectile
 - Stellar Sun Arts, Cloak Style, Pure Flame Form: Poisonous Feather
\page

 - Striking Aquatic Devastating Explosion Arts, Embrace Style, Consonance Form: Dipper of the Resolve
 - Striking Coated Wild Stretched Arts, Script Style, Icy Interference Form: Element-Resting Basic Slashes
 - Striking Counter Arts, Frozen Gentle Instance Style, Clarity Form: Talon Summoning Height
 - Striking Crimson Crusher Arts, Augmented Midsummer Stunning Style, Illusion Form: Five-Fold Vajrayana Summoning Raven
 - Striking Cursed Dividing Burst Arts, Current Nether Style, Stance Form: Sonic Cross Soaring Split
 - Striking Dancing Old Trio Arts, Unified Rapid Style, Waxing Warrior Form: Triple Cultivation Stabbing Daoist
 - Striking Formation Arts, Descending Bite Style, Buddhist Hidden Flame Form: Five-Fold Court Taking Book
 - Striking Granite Arts, Invisible Protective Sweeping Style, Consuming Radiance Form: Five-Fold Distinction Summoning Total
 - Striking Grappling Glacial Trident Arts, Enlightened Instance Style, Rebounding Perfusion Form: Dual-Comb Invigorating Raptor
 - Striking Manifestations Arts, Twin Spiral Style, Echo Form: Perfusion
 - Striking Meditation Arts, Extreme Talon Style, Flesh Form: Triple Prism Traveling Path
 - Striking Metal Arts, Specter Style, Indestructible Cry Form: Illuminated of Poisons
 - Striking Riding Heartless Vajrayana Arts, Black Illuminating Ultimate Style, Ascent Form: Six Observing Marquis
 - Striking Saber Arts, Element Style, Soaring Mad Vajrapani Form: Six Drifting Clouds
 - Striking Sacred Fall Arts, Crossing Projectile Style, Unshakable Pierce Form: Piercer-Rising Grand Polearm
 - Striking Song Arts, Crows Style, Elemental Breeze Form: Beak of the Sage
 - Stunning Barrage Arts, Devastating Heart Style, Frosty Heavenhold Form: Lake of Sight
 - Stunning Bound Arts, Demonic Vigor Style, Bear Form: Suppression
 - Stunning Circulation Arts, Wing Style, Sonic Vajrayana Form: Six Crushing Calamity
 - Stunning Exploding Man Arts, Sacred Parallel Style, Forms Form: Five-Fold Style Matching Ripple
 - Stunning Extinguishing Pierce Arts, Apex Fire Style, Descending Destiny Form: Giant Smoke-Aiming Moonlight
 - Stunning Fading Red Disruption Arts, Indestructible Ripping Spiral Style, Unshakable Explosion Form: Five-Fold Fish Emerging Stab
 - Stunning Flames Arts, Boundless Sharpened Style, Spiraling Scripture Form: Snakeform-Weakening Extinguishing Starvation
 - Stunning Hidden Enemy Arts, Hellfire Style, Roving Lost Form: Leaves-Walking Rebounding Ape
 - Stunning Pure Repelling Manipulation Arts, Mothers Style, Old Calm Movement Form: Dual-Gorge Surging Thunderclap
 - Stunning Saber Arts, Skeletal Expansive Earth Style, Stellar Halo Form: Obscure Shift Ensnaring Statue
 - Stunning Shard Arts, Bronze Assimilation Style, Descending Taebaek Form: Triple Force Revitalizing Phenomena
 - Stunning Silver Sonic Pearl Arts, Illusory Deities Style, Ethereal Vajrapani Form: Six Enduring Moon
 - Stunning Tidal Stellar Kick Arts, Full Barrage Style, Shower Form: Triple Necrotoxin Twisting Blood
 - Stunning Tipsy Arts, Ancient Striking Unforgiving Style, Spirit Mothers Form: Hail of the Heart
 - Stunning Warfield Arts, Silent Style, Bloodthristy Crusher Form: Tipsy of Spiritage
 - Stunning Wrath Arts, Beasts Style, Yellow Inferno Form: Light of the Thrust
 - Subduing Autumn Arts, Liberated Bone Style, Endless Nothingness Form: Pyrocascade of Sections
 - Subduing Current Venom Arts, Shattering Gust Style, Gentle Plume Form: Unparalleled Wave
 - Subduing Dancing Destruction Arts, Mad Traversing Current Style, Warmaster Form: Triple Waters Rising Disruption
 - Subduing Defense Arts, Cardinal Forest Style, Arching Sect Form: Wisdom Resonating Consonance
 - Subduing Devouring Corvid Death Arts, Countless Mobility Style, Invisible Outward Chackra Form: Emptiness
 - Subduing Dive Arts, Extinguishing Realm Style, Coated Needle Form: Six Rising Gateways
 - Subduing Extinguishing Wall Arts, Mirage Wood Style, Rebounding Traditional Drop Form: Dual-Scriptures Emerging Tundra
 - Subduing Fiendish Elegant Sutra Arts, Obsidian Mountian Style, Old Secret Martyr Form: Gorge of Woods
\page

 - Subduing Grip Arts, Toxic Calm Direction Style, Demonic Condor Form: Mastery of the Kaleidoscope
 - Subduing Grounded Cry Arts, Foxform Invisible Chariot Style, Grappling Sanctum Form: Fortress
 - Subduing Gust Arts, Felling Madness Style, Old Volcano Form: Paradise of Return
 - Subduing Illuminating Shift Arts, Vermillion Grand Consecutive Style, Enlightened Nape Form: Triple Thread Soothing Parallel
 - Subduing Lost Arts, Dominating Quick Frozen Style, Dividing Reflection Form: Motion-Summoning Unforgiving Foundation
 - Subduing Mount Arts, Spanning Vigor Style, Sacred Cage Form: Soul
 - Subduing Nails Arts, Whirling Granite Style, Nebula Form: Holy Army Emerging Saint
 - Subduing Roars Arts, Current Charge Style, Enlightenment Form: Striking Ocean Coiling Tranquil
 - Subduing Splitting Hidden Lofty Arts, Waning Imperial Ocean Style, Frontier Form: Grasp of the Cold Depth
 - Subduing Starvation Arts, Unknowable Quick Style, Vampire Form: Giant Incineration-Paralyzing Gale
 - Subduing Turtleback Arts, Poisonous Star Style, Abyssal Tidal Angel Form: Giant Echo-Slicing Pear
 - Subduing Unshakable Heaven Arts, Mirage Solar Bright Style, Extreme Slashes Form: Five-Fold Timberfall Cleaving Strikes
 - Sudden Brilliant Sufferings Arts, Righteous Chariot Style, Divine Riddle Form: Grand Vajrapani
 - Sudden Coral Element Arts, Glacial Distinction Style, Diving Thousands Form: Illuminated of Polearm
 - Sudden Daoist Arts, Wild Silver Dancing Style, Penetrating Bat Form: Six Soaring Martyr
 - Sudden Enlightenment Arts, Big Blossom Style, Lunar Chill Form: Five-Fold Traceless Poking Buddha
 - Sudden Ethereal Poisons Arts, Downward Range Style, Iron Flower Form: Contemplate Invigorating Curse
 - Sudden Expansive Crimson Bear Arts, Earthly Trinity Style, Grand Salvation Form: Move-Gathering Destructive Clarity
 - Sudden Harmonious Aureate Point Arts, Spiraling Balanced Violent Style, Cosmic Swing Form: Book of the Fading Shura
 - Sudden Pearl Arts, Felling Ultimate Valley Style, Hellish Tempo Form: Five-Fold Cave Bowing Harmony
 - Sudden Quell Arts, Moonlit Form Style, Void Kindled Form: Pattern
 - Sudden Titan Arts, Obsidian Dragontail Style, Graceful Moonlit Formation Form: Illusion of the Rebounding Center
 - Sudden Transformation Arts, Blooming Sight Style, Waning Rising Sky Form: Tempo of the Living Fortress
 - Sudden Viper Arts, Ancient Unforgiving Prism Style, Mirage Unknowable Wood Form: Walk-Evading Hellish Wisdom
 - Sweeping Arm Arts, Governing Lord Style, Endless Phaseless Form: Giant Possession-Sacrificing Vapor
 - Sweeping Daoist Arts, Evil Forged Trio Style, Sealing Rhythm Form: Unmatched Demon Chopping Gateways
 - Sweeping Flying Capped Water Arts, Crimson Total Style, 79 Fold Lotus Form: Drain-Airsplitting Dancing Commander
 - Sweeping God Arts, Rising Marquis Style, Latch Form: Buddhist Nape Paralyzing Fog
 - Sweeping Hellish Remains Arts, Sacred Indestructible Cove Style, Crossing Eternal Form: Domination Observing West
 - Sweeping Malevolent Divinities Arts, Ethereal Merciful Governing Style, Heartless Bear Form: Blade-Poking Continuous United
 - Sweeping Manifestation Arts, Virtuous Tortoise Style, Twin Seal Form: Giant Sweetened-Emerging Traceless
 - Sweeping Mighty Leniency Arts, Illuminating Tundra Style, Holy Silver Embrace Form: Technique of the Switch
 - Sweeping Mindless Arts, Breaker Style, Merciful Starvation Form: Glacier of the Royal
 - Sweeping Substitution Arts, Chariot Style, Elegant Divinities Form: Traditional Manipulation Sleeping Tree
 - Sweeping Twin Charge Arts, Poison Style, Graceful Ruin Form: Lotus of Fire
 - Sweeping Venomous Taiji Arts, Illusory Iron Breaker Style, Martial Hands Form: Six Airsplitting Buddha
 - Tearing Authority Arts, Astral Coastal Inferno Style, Lower Noble Form: Throwing Sonata Burning Fleche
 - Tearing Breaker Arts, Grounded Virtuous Infiltration Style, Earthen Long Form: Zenith Twisting Arm
 - Tearing Countless Bloodstained Scatter Arts, Double Strike Style, Breakout Form: Giant Surface-Stealing Spread
 - Tearing Descending Downward Tai Arts, Emerald Wild Burst Style, Boundless Destruction Form: Mysterious Crushes Attacking Severance
\page

 - Tearing Discipline Arts, Tundra Style, Brilliant Transparency Form: Triple Mountain Freezing Wood
 - Tearing Enlightened Thunderous Discipline Arts, Coated Domination Style, Dirty Web Form: Thoughtless of the Shattering Monastery
 - Tearing Expansive Cultivation Arts, Bloodthristy Slash Style, Radiant Midsummer Pillar Form: Aura-Sharpening Mirage Archery
 - Tearing Fleche Arts, Moonlit Equine Clarity Style, Red Asura Form: Inferno of the Paradise
 - Tearing Madness Arts, Moonlit Pearlflower Style, Big Ceremony Form: Tai Gathering Raven
 - Tearing Master Arts, Elemental Hail Style, Ancient Raptor Form: Dual-Maiden Rising Thoughtless
 - Tearing Mirrored Arts, Gentle God Style, Ghostly Point Form: Whip-Swirling Sudden Discipline
 - Tearing Profound Raven Arts, Great Spread Style, Dragon Form: Perfusion-Resting Sweeping Pulse
 - Tearing Reflection Arts, Striking Interference Style, Mad Descending Bodhidharma Form: Vairocana Chopping Crown
 - Tearing Ripping Slashes Arts, Venomous United Style, Traditional Crows Form: Dual-Trial Commanding Battalion
 - Tearing Slicing Boulder Arts, Coated Leech Style, Twin Radiance Form: Rapid-Freezing Full Self
 - Tearing Snowfall Arts, Indestructible Riddle Style, Legged Repentant Domination Form: Veil Observing Mindscape
 - Tearing Soar Arts, Unmatched Wing Style, Golden Continuous Crow Form: Unparalleled Crushes
 - Tearing Tigers Arts, Infernal Assimilation Style, Gentle Metal Form: Mirror Resting Fortress
 - Throwing Autumn Arts, Onyx Fish Style, Rolling Harmonies Form: Thrust of the Boundless Shard
 - Throwing Bronze Augmented Icebolt Arts, Ancient Statue Style, Aura Form: Five-Fold Crown Paralizing Refraction
 - Throwing Cuts Arts, Grip Style, Traditional Equal Ink Form: Consonance of Lord
 - Throwing Devouring Warrior Arts, Foundational Wounding Crystalline Style, Living Man Form: Giant Change-Slicing Cremation
 - Throwing Earthly Imperial Drain Arts, Emptiness Style, Shooting Edge Form: Foundational Cuts Paralizing Sun
 - Throwing Extended Elements Arts, Feral Fury Style, Erupting Legacy Form: Ghostly Void
 - Throwing Metallic Boundless Thaw Arts, Grafting Light Style, Volley Form: Drain-Reflecting Lower Ripple
 - Throwing Pine Arts, Gallant Poisons Style, Pearl Form: Giant Zen-Stabbing Wanderer
 - Throwing Starvation Arts, Final Finishing Ascending Style, Poisonous Obscure Firebrand Form: Rhythm of the Heartless Discipline
 - Throwing Sugar Arts, Heartless Clarity Style, Illusory Trill Form: Giant Strike-Matching Crow
 - Throwing Undivinable Prajna Arts, Balanced Rightful Extinguishing Style, Virtuous Script Form: Six Soothing Hunyuan
 - Throwing Unveiled Arts, Seaspan Style, Pure Demon Form: Infinite Array Summoning Rends
 - Throwing Vedas Arts, Gallant Illusory Secret Style, Spanning Vitality Form: Shatter of the Responsive Elements
 - Thunderous Absorption Arts, Double Patriarch Style, Dancing Astral Trail Form: Starvation Sacrificing Trio
 - Thunderous Cross Arts, Moonlit Unparalleled Harmonious Style, Gallant Swing Form: Projectile Flowing Transformations
 - Thunderous Crows Arts, Pulse Style, Stellar Self Form: Five-Fold Taibai Attacking Way
 - Thunderous Galaxy Arts, Liberated Eternal Chop Style, Shadow Tongue Form: Thrust
 - Thunderous Gallant Forms Arts, Ghostly Bloodthristy Aureate Style, Felling Immovable Form: Quick Vitality
 - Thunderous Man Arts, Cry Style, Killing Mindless Form: Bodhidharma of the Gentle Distinction
 - Thunderous Saint Arts, Wild Absolute Creation Style, Encompassing Cinder Form: Pure Thousands Binding Suppression
 - Thunderous Secret Eternal Formation Arts, Spirits Style, Elegant Flames Form: Six Countering Intention
 - Thunderous South Arts, Liberated Red Mount Style, Venomous Substitution Form: Six Traversing Volcano
 - Thunderous Storm Arts, Onyx Grace Style, Erupting Spectral Shade Form: Repelling Thread
 - Thunderous Sutra Arts, Wheel Style, Exploding Firebrand Form: Turtle Aiming Things
 - Thunderous Unmatched Corvid Guard Arts, Solar Spinning Suffering Style, Few Mind Form: Crown of Windrider
 - Tidal Aureate Emerald Things Arts, Demonic Road Style, Momentum Form: Downward Cry Revitalizing Self
\page

 - Tidal Break Arts, Onyx Heavenhold Style, Aquatic Move Form: Grand Hoarforst
 - Tidal Gallant Augmented Ghost Arts, Embracing Crossing Righteous Style, Many Sweep Form: Vairocana Breaking Monk
 - Tidal God Arts, Coastal Ape Style, Tai Form: Chariot-Falling Universal Constellation
 - Tidal Great Ghost Arts, Defensive Saving Equine Style, Waxing Double Intention Form: Aegis-Sacrificing Responsive Monk
 - Tidal Mirror Arts, Bloodstained Severance Style, Solar Emperor Form: Ancient Vajrapani Defending Beasts
 - Tidal Mountain Arts, Intoxicated Quanzhen Style, Luminous Grip Form: Piercer of the Frenzy
 - Tidal Old Encompassing Neck Arts, Gem Ancient Crimson Style, Imperial Skull Form: View of the Legged Beak
 - Tidal Pines Arts, Spectral Toxic Vile Style, Ripping Style Form: Six Emerging Sanctity
 - Tidal Shroud Arts, Hoarforst Style, Venom Form: Radiance-Flowing Facing Realm
 - Tidal Snowlocked Arts, Corvid Ladder Style, Coastal Wanderer Form: Phenomena Lunging Ink
 - Toxic Circulation Arts, Extended Meditation Style, Center Hit Form: Dual-Raven Summoning Wolf
 - Toxic Corvid Dividing Surge Arts, Equal Royal Style, Cawing Snow Frenzy Form: Dual-Battalion Lunging Opposition
 - Toxic Encompassing Equine Serpent Arts, Astral Spiritual Point Style, Obscure Rends Form: Dual-Kaleidoscope Invigorating Slayer
 - Toxic Grappling Forged Hunyuan Arts, Evil Deflection Style, Trial Form: Warrior of the Cage
 - Toxic Hand Arts, Ravenous Obscure Frozen Style, Crown Form: Lance of Enigma
 - Toxic Hawk Arts, Southern Gold Style, Parallel Cosmos Form: Soul Traveling Silent
 - Toxic Heavenly Realm Arts, Lunar Rebounding Cinder Style, Consecutive Beast Form: Triple Hexablaze Rises Lord
 - Toxic Lower Soar Arts, Snow Traceless Sea Style, Gallant Big Ocean Form: Giant Execution-Summoning Arm
 - Toxic Movement Arts, Foundational Single Blazing Style, Taebaek Form: Butterfly of the Discipline
 - Toxic Subduing Apex Verdant Arts, Indestructible Fox Style, North Angel Form: Five-Fold Leap Ensnaring Unveiled
 - Toxic Wild Polearm Arts, Sonic Angel Style, Unmatched Stab Form: Dominating Remains Scorching Poisons
 - Toxic Yellow Sealing Sheet Arts, Tearing Thousands Style, Traceless Vajrapani Form: Giant Starlight-Twisting Transformations
 - Traceless Angel Arts, Metallic Gateways Style, Vajrapani Form: Triple Slayer Observing Temper
 - Traceless Copper Drunken Blessing Arts, Wicked Extinguishing Chain Style, Golden Eclipse Form: Six Conquering Sugar
 - Traceless Countless Stab Arts, Ascending Spiritage Style, Silver Dominating Daoist Form: Giant Rotation-Tangled Paradise
 - Traceless Devastating Hands Arts, Responsive Asterism Style, Unshakable Shaolin Form: Giant Destiny-Descending Switch
 - Traceless Dive Arts, Repelling Radiant Way Style, Saving Double Spring Form: Six Draining King
 - Traceless Empty Darkwind Arts, Treading Sudden Meridian Style, Element Form: Giant Spike-Coiling Trail
 - Traceless Final Bow Arts, White Winter Style, Technique Form: Kings of the Mysterious Thread
 - Traceless Graceful Proud Arts, Calm Ink Style, Center Snowfall Form: Profound Delights Rises Distinction
 - Traceless Intoxicated Windswept Arts, Rebounding Discipline Style, Rolling Master Form: Unknowable Beak
 - Traceless Iron Pure Beast Arts, Great Path Style, Slicing Vedas Form: Extended Asura Transforming Stretched
 - Traceless Nothingness Arts, Endless Underworld Style, Astral Meditation Form: Triple Stride Blowing Weaver
 - Traceless Paladin Arts, Boundless Treading Luminous Style, Healing Smoke Form: Gentle Beggar
 - Traceless Prajna Arts, Gold Style, Advanced Virtuous Cage Form: Pinnacle
 - Traceless Quanzhen Arts, Unparalleled Boxing Unshakable Style, Shout Form: Lower Latch Descending Bite
 - Traceless Sacred Invisible Way Arts, Chariot Style, Crossing Harmonies Form: Shout-Aiming Soaring Quartet
 - Traceless Spirit Scheme Arts, Devastating Ruin Style, Grafting Hawkstrider Form: Triple Team Soothing Cultivation
 - Traditional Assault Arts, Tiger Style, Perfect Ceremony Form: Protector of the Finishing Buddha
 - Traditional Astral Spanning Moonlight Arts, Earthly Kundali Style, Living Roars Form: Giant Scatter-Transforming Buddha
\page

 - Traditional Charging Cawing Blood Arts, Meditation Style, Rising Defense Form: Five-Fold Leaf Swirling Goldenring
 - Traditional Clarity Arts, Thirst Style, Cosmic Battalion Form: Sui of the Command
 - Traditional Defense Arts, 13 Fold Wandering Might Style, Karmic Form: Dual-Starlit Ensnaring Triangle
 - Traditional Divine Calm Dragon Arts, Spinning Tang Style, United Form: Dual-Wing Sleeping Swing
 - Traditional Drowned Arts, Onyx Shattering Bloody Style, Drunken Forms Form: Cloak-Confronting Crystalline Army
 - Traditional Enlightened Brook Arts, Void Bone Style, Poisons Form: Team of the Unmatched Kundali
 - Traditional Extinguishing Glide Arts, Double Pillar Style, Wild Night Form: Madness
 - Traditional Facing Breeze Arts, Descending Wild Virtuous Style, Immortal Blooming Kill Form: Triple Principles Reflecting Grasp
 - Traditional Fading Adaptive Dragontail Arts, Vile Proud Style, Whirling Fleeting Galaxy Form: Wild Myriads
 - Traditional Fang Arts, Magnanimous Move Style, Crystalline Reflection Form: Five-Fold Cuts Grounding Exchange
 - Traditional Giant Spring Arts, Corvid Skills Style, Liberated Flight Form: Dual-Weapon Weakening Authority
 - Traditional Magnanimous Bronze Sonata Arts, Grand Gust Style, Starlit Form: Stomp of Beasts
 - Traditional Opposition Arts, Adaptive Scatter Style, Heavenly Fading Volcanoes Form: Archery of the Magnanimous Ash
 - Traditional Return Arts, Throwing Gust Style, Bloodthristy Enlightenment Form: Projectile-Ensnaring Gentle Cremation
 - Traditional Skills Arts, Sudden Wild Buddhist Style, Temple Form: Bird of Viper
 - Traditional Strike Arts, Single Move Style, Jade Fiery Chin Form: Manifestation
 - Traditional United Arts, Disruption Style, Felling Shadowy Form: Archery of Forms
 - Traditional Wicked Sound Arts, Glacial Sections Style, Invisible Triple Form: Dual-River Ensnaring Snowlocked
 - Traversing Battle Arts, Magnanimous Explosion Style, Moonlit Ape Form: Elemental Heritage Grounding Night
 - Traversing Cardinal Perfect Talon Arts, Waning Seeds Style, Move Form: Family-Crouching Magnanimous Halo
 - Traversing Crazy Imperial Viper Arts, Stellar Vile Assault Style, Boundless Abyssal Tea Form: Rivers Sleeping Brook
 - Traversing Creation Arts, Protective Weaver Style, Final Poison Form: Swarm of the Dominating Stride
 - Traversing Darkwind Arts, Blaze Style, Bloodthristy Return Form: Dual-Prajna Bowing Jeweled
 - Traversing Descending Rolling Pinnacle Arts, Arching Claw Style, Spirit Countless Momentum Form: Five-Fold Crown Walking Deities
 - Traversing Gold Arts, Gallant Daoist Style, Continuous Nape Form: Decree of East
 - Traversing Graceful Swan Arts, Apex Blister Style, Waning Raven Form: Arrows of Wheel
 - Traversing Karma Arts, Tidal Cove Style, Extinguishing Manifestation Form: Enemy
 - Traversing Mighty Paradise Arts, Frenzy Style, Big Dew Form: Dual-Needle Tearing Light
 - Traversing Pyrocascade Arts, Outward Gem Nomad Style, Brilliant Boxing Waterfall Form: Giant Path-Countering Rain
 - Traversing Soaring Mighty Prestissimo Arts, Enlightened Starlit Style, Spinning Canyon Form: Dirty Road Coiling Motion
 - Traversing Triadic Arts, Shooting Crimson Wanderer Style, Onyx Toss Form: Total Paralyzing Web
 - Traversing Unforgiving Spirits Arts, Dividing Rightful Remains Style, Stream Form: Enemies
 - Treading Change Arts, Rebounding Golden Formless Style, Illusory Karma Form: Six Dodging Thread
 - Treading Crow Arts, Basic Full Graypine Style, Cardinal Fleeting Plague Form: Heart Retreating Paladin
 - Treading Dance Arts, Jewel Style, Fertile Forms Form: Five-Fold Beasts Evading Orthodox
 - Treading Disciple Arts, Consonance Style, Grounded Book Form: Emperor
 - Treading Downward Stellar Metal Arts, Sudden Coated Divinities Style, Ultimate Ascending Fortress Form: Giant Sanctity-Evading Tranquil
 - Treading Earth Arts, Chaotic Fiendish Wolf Style, Unmatched Army Form: True Clarity Sleeping Tablet
 - Treading Emerald Fairy Arts, Elegant Chaos Style, Noble Form: Warmaster
 - Treading Fatal Metallic Tai Arts, Rebounding Elegance Style, Traceless Poisonous Nebula Form: Dual-Polar Coiling Reaper
\page

 - Treading Ink Arts, Cawing Comb Style, Buddhist Black West Form: Sisi-Retreating Righteous Interference
 - Treading Mind Arts, Thousands Style, Harmonious Tongue Form: Six Traveling Infiltration
 - Treading Misty Arts, Lower Limitless Nefarious Style, Facing Team Form: Giant Bird
 - Treading Monk Arts, Coastal Frenzy Style, Crazy Starlit Form: Finger of Tree
 - Treading North Asura Arts, Gallant Abyssal Holy Style, Midsummer Bound Form: Fang Rising Vedas
 - Treading Primordial Consonance Arts, Icy Hydra Style, Rolling Traceless Might Form: Nothingness-Dispersing Unshakable Talon
 - Treading Proud Arts, Universal Tree Style, Mad Blessing Form: Latch of the Cold Repents
 - Treading Quick Sword Arts, Stunning Scale Style, Edge Form: Extreme Consonance
 - Treading Saber Arts, Waters Style, Twin Soft Form: Five-Fold Palm Shaking Swan
 - Treading Snow Crusher Arts, Center Pearl Style, Omnidirectional Form: Crazy Element
 - Treading Stomp Arts, Serene Poison Style, True Ladder Form: Charging Nebula
 - Treading Twin Legged Skills Arts, Emerald Tranquil Style, Cosmic Limbo Form: Myriads Flowing Quick
 - Treading Wisdom Arts, Traditional Silent Style, South Form: Five-Fold Starlight Stealing Fog
 - True Decree Arts, Spiraling Deep Horse Style, Net Form: Harmonious Trinity
 - True Feral Split Arts, Bronze Giant Peak Style, Malevolent Destructive Darkwind Form: Dual-Soul Gathering Cage
 - True Forest Arts, Basic Healing Imperial Style, Birthless Daoist Form: Sudden Bodhidharma
 - True Foxform Dancing Nether Arts, Boundless Principles Style, Encompassing Protector Form: Ursine-Conquering Fatal Frontier
 - True Hands Arts, Crusher Style, Spanning Bat Form: Water of the Hellish Crown
 - True Invisible Drop Arts, Intoxicated Temple Style, Mad Venom Form: Man of the Onyx Limbo
 - True Kill Arts, Sweeping Drunken Harmony Style, Petal Instance Form: Shatter
 - True Pyrocascade Arts, Trigrams Style, Wandering Forms Form: Giant Pearl-Blooming Taiji
 - True Quartet Arts, Ice Style, Moonlit Bodhidharma Form: Battle Chopping Vitality
 - True Rebounding Azure Plume Arts, Claw Style, Forms Form: Dual-Pine Lunging Style
 - True Rectitude Arts, Descent Style, Windswept Form: Giant Crown-Stopping Stalwart
 - True Seeds Arts, Equal Shell Style, Meditation Form: Triple Zenith Rising Spirits
 - True Shift Arts, Deep Switch Style, Fading Boundless Snakeform Form: Current Soft Ascending Phaseless
 - True Sonata Arts, Sage Style, Giant Stun Form: Giant Blessing-Searching Explosion
 - True Sufferings Arts, Living Great Wind Style, Nether Form: Harmonies-Twisting Undivinable Assaliants
 - True Twin Mind Arts, Advanced Petal Stealth Style, Riding Manifestation Form: Pine-Draining Extinguishing Strikes
 - True United Arts, 102nd Extinguishing Hellish Style, Tidal Tipsy Form: Ape of the Center Martyr
 - True Winter Arts, Exploding Rage Style, Assault Form: Emptiness-Twisting Enlightened Stalwart
 - Twin Arrows Arts, Splitting Resonance Style, Cobra Form: Six Coiling Crown
 - Twin Barrage Arts, Fiendish Lower Dragontail Style, Aureate Gallant Sword Form: Dual-Soul Slicing Breaker
 - Twin Basic Forest Arts, Liberated Dirty Arhat Style, Ascending Timberfall Form: Triple Road Emerging Stab
 - Twin Cavern Arts, Cawing Pure Demon Style, Augmented Double Man Form: Momentum of the Rightful Heritage
 - Twin Cosmic Quick Plate Arts, Advanced Sword Style, Unbound Form: Height of the Elbow
 - Twin Descending Repentant Traceless Arts, Parallel Kaleidoscope Style, Boxing Whirling Buddha Form: God-Airsplitting Profound Winter
 - Twin Gale Arts, Cursed Consecutive Diving Style, Full Pinnacle Form: Giant Scheme-Cutting Blossom
 - Twin Many Violent Death Arts, Glacial Unified Exploding Style, Repents Form: Giant Kaleidoscope-Cutting Lake
 - Twin Poisonous Coated Riddle Arts, Astral Kundali Style, Radiant Snowfall Form: Triple Palm Controlling Fortune
\page

 - Twin Scholar Arts, Grappling Valley Style, Elegant Projectile Form: Sonata of Transformation
 - Twin Spin Arts, Bronze Ancient Defense Style, Coastal Venom Form: Six Blowing Guardian
 - Twin Western Blossoms Arts, Extreme Advanced Warfield Style, Penetrating Mastery Form: Scatter-Blowing Throwing Radiance
 - Ultimate  Penetrating Lake Arts, Karma Style, Bloodstained Devouring Resolve Form: Triple Vedas Linking Poison
 - Ultimate Beasts Arts, Elusive Stone Style, Lunar Deity Form: Sheet
 - Ultimate Copper Chariot Arts, Serene Vajrapani Style, Destructive Coil Form: Six Crushing Destroyer
 - Ultimate Decree Arts, Summit Style, Interference Form: Triple Sanctum Confronting Necrotoxin
 - Ultimate Fist Arts, Ancient Secret Northern Style, Wild Blessing Form: Five-Fold Emperor Traveling Vajrapani
 - Ultimate Invisible Breeze Arts, Shattering Chill Style, Graceful Court Form: Triple Grasp Taking Tablet
 - Ultimate Palms Arts, Diving Quick Style, Facing Vibrant Form: Triple Shield Slicing Sanctity
 - Ultimate Parallel Secret Path Arts, Abyssal Ruin Style, Featherweight Way Form: Crimson Shaolin Falling Poison
 - Ultimate Radiant Violent Triangle Arts, Center Parallel Arching Style, Deep Cold Fire Form: Dual-Ascension Walking Self
 - Ultimate Raven Arts, Crimson Birthless Blessing Style, Mistveil Form: Five-Fold Shadowless Stealing Reguard
 - Ultimate Scriptures Arts, Surge Style, Mirage Nature Form: Life of Qintfade
 - Ultimate Sealing Quell Arts, Stunning Living Brilliant Style, Violent Rectitude Form: Twin Cloak Falling Torment
 - Ultimate Spirit Golden Perfusion Arts, Equine Lightweight Style, Parallel Gate Form: Dual-Delights Emerging Turtle
 - Ultimate Strike Arts, Continuous Fall Style, Balanced Breakout Form: Orthodox-Summoning Illuminating Mindscape
 - Ultimate Unified Sword Arts, Grappling Leap Style, Demonic Autumn Form: Cardinal Soft Transforming Nape
 - Ultimate Warfield Arts, Grappling Underworld Style, Cardinal Rectitude Form: Five-Fold Tea Ending Bite
 - Undivinable Blessed Wounding Tai Arts, Mighty Repents Style, Ancient Shockwave Form: Unparalleled Mountian
 - Undivinable Feral Spiraling Nails Arts, Adamantine Way Style, White Skills Form: Featherweight Yang
 - Undivinable Frosty Heavenly King Arts, Crossing Stellar Coastal Style, Barrier Form: Waxing Crow Taking Scriptures
 - Undivinable Grounded Torment Arts, Coral Circulation Style, Crazy Tiger Form: Dual-Wheel Walking Majestic
 - Undivinable Heaven Arts, Yellow Glow Style, Absolute Tongue Form: Elements
 - Undivinable Heavenhold Arts, Fading Metallic Ancient Style, Unrivaled Kaleidoscope Form: Chill-Shattering Ghostly Tail
 - Undivinable Leniency Arts, Arching Grasp Style, Capped Flight Form: Poisons of the Obsidian Bolt
 - Undivinable Nullification Arts, Dark Southern Signless Style, Soaring Sharpened Form: Six Paralyzing Rhythm
 - Undivinable Sealing Felling Technique Arts, Solar Sound Style, Ultimate Destructive Transparency Form: Six Gathering Net
 - Undivinable Smashing Tree Arts, Hunyuan Style, Dark Single Array Form: Triple Binder Tearing Way
 - Undivinable Tongue Arts, Snow Demonic Azure Style, Ancient Wild Throw Form: Big Emptiness Summoning Karmic
 - Undivinable Transparency Arts, Extinguishing Holy Footstep Style, Birthless North Form: Five-Fold Mountain Surging Illuminated
 - Undivinable Unforgiving Sanctum Arts, Elusive Silver Slicing Style, Illusory Switch Form: Six Descending Tong
 - Undivinable West Arts, Nefarious Raven Style, Astral Foundational Crows Form: Slicing Cleave
 - Unforgiving Aureate Vapor Arts, Malevolent Scarlet Style, Spirit Fist Form: Giant Command-Dodging Transparency
 - Unforgiving Center Lunar Way Arts, Penetrating Crossing Rocky Style, Eternal Pure Martyr Form: Protector of the Buddhist Harmonies
 - Unforgiving Chop Arts, Jade Ocean Style, Spirit Repents Form: Phaseless of Piercer
 - Unforgiving Coastal Ape Arts, Destructive Bat Style, Traceless Deep Monk Form: Sudden Toil
 - Unforgiving Consuming Moonlit Spiritage Arts, Felling Misty Style, Crossing Brush Form: Dual-Spearplay Searching Pinnacle
 - Unforgiving Continuous Nail Arts, Snow Midsummer Song Style, Dominating Rebounding Drop Form: Giant Raven-Tearing Vitality
 - Unforgiving Exploding Unrestrained Arts, Ethereal Counter Style, Indestructible Interference Form: Heavenhold Lunging Hunyuan
\page

 - Unforgiving Grace Arts, Eastern Element Style, Cursed Turtleback Form: Flower of the Brilliant Yin
 - Unforgiving Kick Arts, Big Needle Style, Earth Form: Eagle Flowing Master
 - Unforgiving Move Arts, Single Tai Style, Copper Venom Form: Triple Demon Soothing Sections
 - Unforgiving Needle Arts, Giant Quick Shade Style, Divine Claw Form: Slip-Countering Descending Thread
 - Unforgiving Phoenix Arts, Extreme Starlit Style, Dividing Mystic Thrust Form: Turtle of the Omnidirectional
 - Unforgiving Polearm Arts, Calm East Style, Eternal Disruption Form: Subduing Thunderclap
 - Unforgiving Saber Arts, Luminous Sui Style, Bat Form: Five-Fold Tang Tearing Swan
 - Unforgiving Sections Arts, Movement Style, Big Court Form: Severance of the Yin
 - Unforgiving Shadow Stellar Lightning Arts, Penetrating Trial Style, Cardinal Rapid Form: Madness of the Downward Script
 - Unforgiving Shockwave Arts, Heartless Thrust Style, Traditional Snowfall Form: Nape of the Slayer
 - Unforgiving Snake Arts, Unified Beasts Style, Exploding Return Form: Giant Taihua-Chopping Disinterment
 - Unforgiving Tail Arts, Devastating Cavern Style, Healing Might Form: Giant Stab-Breaking Torment
 - Unforgiving Violent Latch Arts, Arching Hell Style, Crimson Flame Form: Triple Light Aiming Temple
 - Unforgiving West Arts, Single Chin Style, Enlightened Chackra Form: Spring of the Ice
 - Unified Abyssal Sheet Arts, Adamantine Bloodstained Infiltration Style, Waning Rapid Form: Starlight-Countering Mysterious Chop
 - Unified Ascent Arts, Eastern Grappling Stellar Style, Waxing Instance Form: Six Following Harmony
 - Unified Commander Arts, Projectile Style, Feral Expansive Talon Form: Wind of the Peak
 - Unified Corrupted Profound Phenomena Arts, Ghostly Tidal Northern Style, Battalion Form: Formation-Fighting Black Enemy
 - Unified Cry Arts, Splitting Crane Style, Chaotic Northern Gateways Form: Five-Fold Truth Cutting Taming
 - Unified Discipline Arts, Rebounding Dirty Burning Style, Old Quick Blaze Form: Rampage
 - Unified Emerald Facing Daybreak Arts, Downward Exchange Style, Mighty Gentle Taibai Form: Giant Bodhi-Descending Team
 - Unified Endless Shroud Arts, Balanced Crusher Style, Repents Form: Legacy of the Contemplate
 - Unified Expansive Poison Arts, Grand Night Style, Heavenly Toil Form: Sacred Infiltration Weakening Grasp
 - Unified Glide Arts, Cutting Woods Style, Endless Might Form: Giant Protector-Counterattacking Daoist
 - Unified Heart Arts, Wild Spring Style, Grand Spiritage Form: Six Transforming Principles
 - Unified Incineration Arts, Primordial Fatal Rightful Style, Warmaster Form: Five-Fold Tablet Resonating Total
 - Unified North Vine Arts, Countless Cobra Style, Void Millennium Form: Martyr
 - Unified Sacred Grand Mirrored Arts, View Style, Grappling Eagle Form: Waltz of the Spirit Jewel
 - Unified Snakeform Arts, Dominating Aquatic Forms Style, Wounding Pierces Form: Phantom
 - Unified Storm Arts, Burning Web Style, Legged Weapon Form: Killer of Sky
 - Unified Stroke Arts, Gentle Stalwart Style, Lattice Form: Dual-Buddha Conquering Pinnacle
 - Unified Unity Arts, Capped Prism Style, Abyssal Thunderous Condor Form: True Flare Flying Fang
 - Unified Waters Arts, Rightful Cry Style, Ravenous Stance Form: Dual-Hawk Stabbing Sanctity
 - Unified Wisdom Arts, Earthen Few Form Style, Ultimate Chill Form: Facing Decree Blowing Stone
 - Unified Wood Arts, Consecutive Evil Madness Style, View Form: Five-Fold Constellation Lunging Sisi
 - Universal Black Guard Arts, Graceful Commander Style, Outward Venomous Blister Form: Pillar of Substitution
 - Universal Bloodstained Elder Arts, Infinite Consciousness Style, Extreme Legs Form: Cage-Ensnaring Lunar Zenith
 - Universal Drain Arts, Rocky Style, Breakthrough Form: Six Soothing Polarm
 - Universal Eternal Consuming Barrage Arts, Emerald Governing Grasp Style, Rolling Ursine Form: Triple Point Poking Triadic
 - Universal Flight Arts, Aureate Cawing Equine Style, Outward Illusion Form: Six Binding Vapor
\page

 - Universal Grasp Arts, Grip Style, Onyx Scale Form: Giant Starvation-Soothing Tipsy
 - Universal Intention Arts, Silver Thunderous Starlight Style, Evil Authority Form: Butterfly
 - Universal Lattice Arts, Shattering Soft Style, Snow Contemplate Form: Jade Fog
 - Universal Magnanimous Traversing Crash Arts, Extra Smashing Sweep Style, Feral Destiny Form: Giant Cut-Piercing Tundra
 - Universal Nefarious Consecutive Triadic Arts, Rising Iron Sudden Style, Repelling Coil Form: Saving Manifestations Twisting Beast
 - Universal Order Arts, Skeletal Slashes Style, Spirit Rightful Radiance Form: Fairy
 - Universal Poisonous Elder Arts, Spiritual Paladin Style, Bite Form: Talon-Breaking Fertile Volcano
 - Universal Repelling Pierce Arts, Petal Heat Style, Sky Form: Throwing Scatter Invigorating Trap
 - Universal Skull Arts, Slicing Felling Iron Style, Dark Pearlflower Form: Turtleback Bowing Plate
 - Universal United Arts, Double Neck Style, Polarm Form: Midsummer Drowned
 - Unknowable Bloody Gallant Lost Arts, Apex Equine Giant Style, Dark Soar Form: Six Shifting Jeweled
 - Unknowable Brook Arts, Snow Karmic Style, Old Palms Form: Triple Snake Summoning Sutra
 - Unknowable Chop Arts, Unforgiving Trinity Style, Brilliant Moon Form: Cinder of the Exorcism
 - Unknowable Drowned Arts, Spirits Style, Dominating Transformation Form: Reaction of the Extreme Claw
 - Unknowable Extinguishing Thunderclap Arts, Slash Style, Subduing Eternal Form: Five-Fold Stun Biting Wolf
 - Unknowable Extinguishing Unshakable Pattern Arts, Penetrating Goldsaber Style, Buddhist Crows Form: Five-Fold Pillar Paralizing Needles
 - Unknowable Hellfire Arts, Awakening Style, Intent Form: Five-Fold March Falling Reflection
 - Unknowable Leaf Arts, Unshakable Direction Style, Blessing Form: Six Counterattacking Marquis
 - Unknowable Lightness Arts, Madness Style, Buddha Form: Sufferings of Hunyuan
 - Unknowable Midsummer Spin Arts, Rising Nothingness Style, Mysterious Bind Form: Warrior Tangled Ruin
 - Unknowable Shooting Corrupted Vajrapani Arts, Double Icy Spinning Style, Facing Overwash Form: Triple Repents Attacking Crash
 - Unknowable Snowlocked Arts, Violent Block Style, Hellish Drunken Mistveil Form: Expansive Thaw
 - Unknowable Spirit Augmented Manifestations Arts, Truth Style, Mystic Rain Form: Triangle of the Charge
 - Unknowable Waxing Traditional Arm Arts, Sudden Cyclone Style, Great Specter Form: Deflection Resting Mystery
 - Unmatched Apex Tearing South Arts, Nefarious Crane Style, Emergence Form: Grappling Nether
 - Unmatched Azure Devastation Arts, Full Jade Traditional Style, Grappling Penetration Form: Execution of the Unified Plague
 - Unmatched Boundless Bear Arts, Center Saving Scheme Style, Repelling Cutting Palm Form: Giant Heat-Unwavering United
 - Unmatched Cawing Tidal Gold Arts, Clarity Style, Coated Block Form: Giant Tea-Gathering Thread
 - Unmatched Cobra Arts, Northern Reguard Style, Downward Strength Form: Imperial Judgment
 - Unmatched Delights Arts, Black Prelude Style, Slip Form: Army
 - Unmatched Descent Arts, Reaper Style, God Form: Indestructible Tong Resisting Principles
 - Unmatched East Arts, Vairocana Style, Thirst Form: Timberfall-Surging Fiery Raven
 - Unmatched Monastery Arts, Mad Chill Style, Hidden Ceremony Form: Five-Fold Shard Shattering Elegance
 - Unmatched Penetration Arts, Bloom Style, Facing Sylvan Form: United of Frontier
 - Unmatched Solar Cage Arts, Sanctum Style, Void Poison Form: Current Rivers
 - Unmatched United Arts, Yellow Goldenring Style, Healing Sonic Block Form: Lightweight of the Traceless
 - Unmatched Vine Arts, Wing Style, Undivinable Seeds Form: Six Severing Crush
 - Unparalleled Bright Drunken Arrows Arts, Beggar Style, Southern Sisi Form: Phantom of the Equine Projectile
 - Unparalleled Crusher Arts, Waning Quanzhen Style, Jade Exchange Form: Temple of Lattice
 - Unparalleled Destructive Mad Thirst Arts, Extended Lotus Style, Evil Soft Form: Pattern of the Devouring Starlit
\page

 - Unparalleled Equal Devouring Motion Arts, Waxing Demonic Balanced Style, Ripple Form: Giant Whip-Swaying Lord
 - Unparalleled Fertile Bronze Nether Arts, Slayer Style, Cutting Origin Form: Dual-Sky Concealing Mental
 - Unparalleled Fox Arts, Solar Adaptive Poisonous Style, Soaring Nape Form: Venom Ending Tablet
 - Unparalleled Holy Moonlit Vitality Arts, Unmatched Meridian Style, Coated Night Form: Weaver
 - Unparalleled Thousand Arts, Earthen Luminous Eternal Style, Unknowable Ruin Form: Bite Chopping Transformations
 - Unparalleled Triangle Arts, Dark Weaver Style, Water Form: Vibrant of the Grappling Pattern
 - Unrivaled Augmented Pine Arts, Capped Needle Style, Defensive Palm Form: Six Defending Reguard
 - Unrivaled Bite Arts, Quick Obscure Trail Style, Vermillion Priest Form: Five-Fold Illusion Observing Buddha
 - Unrivaled Chaotic Bat Arts, Infinite West Style, Battlefield Form: Giant Bolt-Airsplitting Nature
 - Unrivaled Coral Thunderous Stone Arts, Shadow Vile Staff Style, Mystic Battalion Form: Giant Quell-Crouching Rends
 - Unrivaled Drowned Arts, Penetrating Hands Style, Tai Form: Constellation of the Night
 - Unrivaled Frostbite Arts, Dual Transparency Style, Quick Fall Form: Triple Burst Unwavering Acala
 - Unrivaled Gem Drowned Arts, Corrupted Crow Style, Enlightened Magnanimous Aura Form: Volley
 - Unrivaled Gentle Skeletal Mastery Arts, Enlightened Staff Style, Bound Form: Five-Fold Ripple Searching Mobility
 - Unrivaled Jade Wicked Surface Arts, Protector Style, Spanning Hit Form: Dipper
 - Unrivaled Origin Arts, Gallant Asura Style, Profound Unparalleled Arrow Form: Giant Stone-Counterattacking Grasp
 - Unrivaled Priest Arts, Extreme Unbounded Style, Majestic Form: Latch of Breaker
 - Unrivaled Radiant Malevolent West Arts, Demonic Fiend Style, Solar Dark Steel Form: Cleave
 - Unrivaled Repentant Dive Arts, Expansive Cosmic Boxing Style, Calm Authority Form: Six Stealing Qintfade
 - Unrivaled Responsive Flower Arts, Big Trail Style, Mystic Spearplay Form: Dual-Basilisk Draining Tablet
 - Unrivaled Retribution Arts, Tidal Dark Exploding Style, Legged Forms Form: Triple Frontier Cleaving March
 - Unrivaled Shift Arts, Eastern Dive Style, Profound Tree Form: Six Swaying Sky
 - Unrivaled Stab Arts, Crazy Posture Style, Exorcism Form: Mind of the Depth
 - Unrivaled Tai Arts, Shooting Wild Grace Style, Instance Form: Giant Blossoms-Chopping Style
 - Unrivaled Trill Arts, Unbounded Style, Boundless Tempest Form: Triple Phoenix Traversing Suffering
 - Unshakable Adaptive Balanced Nape Arts, Chaotic Absolute Tai Style, Penetrating Steel Form: Plume
 - Unshakable Arching Wandering Cosmos Arts, Martial Cutting Force Style, Saving Woods Form: Six Piercing Rectitude
 - Unshakable Elder Arts, Spiritual Wraith Style, Azure Devouring Horse Form: Chaotic Ripple Going Master
 - Unshakable Embracing Forged Enemy Arts, Roving Old Empty Style, Wandering Cloak Form: Cavern of the Eternal
 - Unshakable Extreme Sugar Arts, Vermillion Steel Style, Dark Rhythm Form: Subduing Qintfade Traversing Spiral
 - Unshakable Immortal Leaf Arts, Augmented Triadic Style, Pure Darkwind Form: Origin of the Barrage
 - Unshakable Nape Arts, Mystic Extended Bow Style, Repentant Volcano Form: Hunyuan-Searching Heartless Spirits
 - Unshakable Repelling Mirage Waves Arts, Many Flight Style, Rolling Manipulation Form: Featherweight Rectitude
 - Unshakable Shooting Seal Arts, Deep Cold Assaliants Style, Opposition Form: Thousands
 - Unshakable Signless Arts, Countless Scriptures Style, Legged Forms Form: Surface-Matching Earthen Flare
 - Unshakable Smashing Cuts Arts, Single Prestissimo Style, Tempo Form: Counter of the South
 - Unshakable Temper Arts, Azure Ultimate Piercer Style, Void Chill Form: Orthodox of the Dual Cuts
 - Unshakable Trial Arts, Embracing Whirlwind Style, Hidden Unforgiving Underworld Form: Throw Rises Mindscape
 - Unshakable Turtleback Arts, Perfect North Script Style, Dominating Balanced Autumn Form: Thrust of the Facing Grip
 - Venomous Ascending Mothers Arts, Stellar Shaft Style, Exploding Invisible Saber Form: Battle of the Taibai
\page

 - Venomous Bodhi Arts, Wisdom Style, Petal Shaolin Form: Veiled-Fighting Elemental Song
 - Venomous Copper Metallic Vapor Arts, Fiery Silent Style, Shooting Stunning Dance Form: Saber of the East
 - Venomous Extra Giant Ladder Arts, Elemental Descending Tortoise Style, Bow Form: Five-Fold North Matching Tablet
 - Venomous Lower Rock Arts, Gallant Slip Style, Foxform Nomad Form: Resonance of the Invisible Arm
 - Venomous Prestissimo Arts, Tongue Style, Infinite Torment Form: Crazy Essence Airsplitting Tranquil
 - Venomous Red Mastery Arts, Wrath Style, Endless Trinity Form: Gallant Demon
 - Venomous Skeletal Midsummer Arm Arts, Legged Vermillion Destiny Style, Mirage Energy Form: Five-Fold Bird Soothing Prism
 - Venomous Spearplay Arts, Outward Illusion Style, Lunar Starlight Form: Crimson Tipsy Breaking Deities
 - Venomous Twin Temple Arts, Unforgiving Southern Ascending Style, Elusive Vibrant Form: Unrestrained-Carrying Aureate Mobility
 - Vermillion Dominating Direction Arts, Forged Sanctity Style, Drunken Meditation Form: Sweeping Consonance
 - Vermillion Flower Arts, Destructive Abyssal Unforgiving Style, Riding Resolve Form: Five-Fold Mirror Poking Ripple
 - Vermillion Healing Cave Arts, Obsidian Momentum Style, Mirror Form: Giant Ascent-Defending Triple
 - Vermillion Malevolent Crystalline Formation Arts, Ultimate Asura Style, Encompassing Touch Form: Fish of the Eternal Tail
 - Vermillion Mystery Arts, Lunar Battle Style, Skeletal Disciple Form: Subduing Signless
 - Vermillion Sea Arts, Wild Hit Style, Calm Yin Form: Remains of the Celestial Trill
 - Vermillion Splitting Hands Arts, Obsidian Throw Style, Polar Form: Dual-Jeweled Leaping Ape
 - Vermillion Tablet Arts, Coral Basilisk Style, Holy Disinterment Form: Transformations Falling Principles
 - Vermillion West Arts, Blessed Encompassing Rolling Style, Embracing Reaction Form: Sacred Deflection
 - Vile Dual Felling Inferno Arts, Killing Repentant Hawk Style, Apex Quartet Form: Heat-Swaying Cutting Flash
 - Vile Gate Arts, Waxing Vibrant Style, Unified Crown Form: Leniency of the Roving Judgment
 - Vile Healing Long Arts, Cawing Illuminated Style, Repelling Flames Form: Giant Pattern-Poking Lofty
 - Vile Many Wild Destroyer Arts, Imperial Center Style, Saving Breakthrough Form: Giant Tong-Crushing Timberfall
 - Vile Outward Eternal Ice Arts, Spirit Ethereal Emperor Style, Fiery Crossing Trinity Form: Magnanimous Warmaster Flowing Delights
 - Vile Pinnacle Arts, Magnanimous Yellow Crash Style, Moonlit Command Form: Dual-Ascension Biting Chariot
 - Vile Single Repentant Tongue Arts, Bloodthristy Warrior Style, Crystalline Yin Form: Six Poking Trident
 - Vile Universal Glacier Arts, Quick Majestic Style, Frosty Warmaster Form: Switch of the Wounding Frontier
 - Vile Unshakable Arching Bodhi Arts, Raptor Style, Bloodstained Primordial Sun Form: Fist-Ensnaring North Cavern
 - Vile Warmth Arts, Illusory Finishing Many Style, Splitting Stun Form: Obsidian Body Chopping Raptor
 - Vile Whirling Roving Spread Arts, Vigor Style, Cold Obscure Edge Form: Stream Unwavering Leaf
 - Vile White Rhythm Arts, Unforgiving Cawing Substitution Style, Many Parallel Form: Body
 - Violent Burst Arts, Fiendish Cobra Style, Spiritual Descent Form: Five-Fold Glide Traveling Illusion
 - Violent Corvid Transformations Arts, Northern Statue Style, Downward Absolute Daoist Form: Wraith of the Riding Switch
 - Violent Drain Arts, Devastating Peak Style, Extra Thread Form: Slicing Cuts
 - Violent Elemental Quick Elbow Arts, Adaptive Hand Style, Extra Warrior Form: Redemption Leaping Barrier
 - Violent Indestructible Feral Scatter Arts, Celestial Traditional Remains Style, Mirage Swords Form: Five-Fold Drop Shaking Tail
 - Violent Lance Arts, Wounding Blade Style, Shooting Sage Form: Metal
 - Violent Noble Arts, Goldenring Style, Ancient Defiers Form: Triple Death Invigorating Execution
 - Violent Omnidirectional Arts, Cursed Monkey Style, Ruin Form: Jade Weaver Counterattacking Footstep
 - Violent Overwash Arts, Holy Grip Style, Coral Cobra Form: Triple Unity Scorching Pinnacle
 - Violent Perfect Copper Unrestrained Arts, Holy Disciple Style, Chop Form: Intoxicated Rampage Twisting Hands
\page

 - Violent Shockwave Arts, Perfect Radiant Rotation Style, Boundless Angel Form: Five-Fold Swift Falling Fury
 - Violent Slicing Devastating Breakout Arts, Awakening Style, Malevolent Arrows Form: View
 - Violent Starvation Arts, Indestructible Fairy Style, Sealing Raptor Form: Necrotoxin
 - Violent Thoughtless Arts, Crossing Rhythm Style, Vermillion Feather Form: Quartet of the Cobra
 - Violent Transformation Arts, Jewel Style, Void Beam Form: Spiraling Fox
 - Virtuous Assaliants Arts, Rotation Style, Mystic Butterfly Form: Fish of the Treading Seaspan
 - Virtuous Chariot Arts, North Interference Style, Whirling Root Form: Dual-Spread Leaping Technique
 - Virtuous Chop Arts, Throw Style, Extended Triangle Form: Triple Frost Tangled Elbow
 - Virtuous Dawn Arts, Frosty Thrust Style, Sudden Hail Form: Triple Blister Summoning Fox
 - Virtuous Divine Glacial Raven Arts, Tongue Style, Frontier Form: Fish-Walking Coated Command
 - Virtuous Earth Arts, Universal Full Range Style, Fleeting Skull Form: Perfusion
 - Virtuous Encompassing Posture Arts, Mysterious Chop Style, Spiral Form: Giant Spirits-Biting Shroud
 - Virtuous Fairy Arts, Heartless Emerald Harmonious Style, Cosmic Basilisk Form: Giant Unbound-Freezing Roars
 - Virtuous Fang Arts, Responsive Pattern Style, Old Plume Form: Six Coiling Nullification
 - Virtuous Mad Thunder Arts, Bright Beggar Style, Palm Form: Five-Fold Bite Aiming Wheel
 - Virtuous Pyre Arts, Advanced Bright Drunken Style, Outward Wolf Form: Smashing Triple Fighting Sweep
 - Virtuous Solar Comb Arts, Throwing Northern Encompassing Style, Kundali Form: Center-Sacrificing Glacial Triangle
 - Virtuous Starlit Arts, Righteous Few Ancient Style, Deep East Form: Dual-Dawn Piercing Parallel
 - Virtuous Tai Arts, Petal Sacred Birthless Style, Mountian Form: Domination Poking Posture
 - Virtuous Windswept Arts, Heritage Style, Cardinal Legacy Form: Skills Confronting Void
 - Void Bodhidharma Arts, Absolute Throwing Protector Style, Roving Cage Form: Vibrant
 - Void Extended Scripture Arts, Rebounding Spanning Thunderclap Style, Touch Form: Timberfall of the Intoxicated Chill
 - Void Iron Western River Arts, Facing Luminous Indestructible Style, Whirling Meridian Form: Triple Formation Shaking Steps
 - Void Maiden Arts, Unshakable Skeletal Magnanimous Style, Crystalline Kundali Form: Triple Assimilation Attacking Stab
 - Void Obsidian Limitless Cutter Arts, Drunken Graceful Few Style, Many Subduing Drain Form: Sonic Circulation Shaking Spring
 - Void Shadowless Arts, Traversing Marquis Style, Dancing Elder Form: Harvest Flying Self
 - Void Statue Arts, Magnanimous Cosmic Light Style, Dual Talon Form: Deflection Following Hellfire
 - Wandering Ape Arts, Traditional Instance Style, Devastating Daoist Form: Triple Night Paralyzing Fish
 - Wandering Assault Arts, Metallic Arhat Style, Mad Trio Form: North of the Haunt
 - Wandering Charging Palm Arts, Guardian Style, Violent Coastal Grace Form: Dual-Scriptures Coiling Thundershock
 - Wandering Double Absolute Lightness Arts, Spinning Snakeform Style, Universal Cold Polearm Form: Infusion Sacrificing Thread
 - Wandering Gorge Arts, Fatal Mountainous Style, Sweeping Nothingness Form: Heart Soothing Beam
 - Wandering Infinite Brook Arts, God Style, Dark Destroyer Form: Six Blowing Enemy
 - Wandering Invisible Root Arts, Foxform Illusory Apex Style, Charging Bite Form: Sheet-Conquering Shattering Sect
 - Wandering Lattice Arts, Spinning Finishing Devouring Style, Pure Duck Form: Spirit Book
 - Wandering Pack Arts, Eastern Strikes Style, Pure Cuts Form: Book of the Traversing King
 - Wandering Possession Arts, Lunar Shattering Wolf Style, Devastating Dancing Timberfall Form: Magnanimous Toss
 - Wandering Scheme Arts, Heavenly Mighty Unmatched Style, Stunning Soar Form: Five-Fold Quartet Concealing King
 - Wandering Smashing Subduing Eternal Arts, Enlightened Extended Precept Style, Sudden Breakthrough Form: Necrotoxin of the Height
 - Wandering Spark Arts, Cosmic Embrace Style, Absolute Priest Form: Sonata of the Repelling Palm
\page

 - Wandering Spread Arts, Fourteenth 22 Fold Healing Style, Soaring Drop Form: Pines of the Hit
 - Wandering Star Arts, Slashes Style, Intent Form: Giant Walk-Emerging Blessing
 - Wandering Style Arts, Twin Skill Style, Consecutive Malignant Form: Crossing Variation Stopping Disinterment
 - Waning Authority Arts, Dancing Depth Style, Poisonous Chain Form: Six Flowing Gate
 - Waning Claw Arts, Ghostly Chaotic Riddle Style, Intention Form: Dual-Thaw Airsplitting Enlightenment
 - Waning Constellation Arts, Silver Jeweled Style, Wounding Nails Form: Descent
 - Waning Continuous Unbounded Arts, Lower Flying Plate Style, Foundational Expansive Glide Form: Equal Cobra
 - Waning Crimson Finishing Crows Arts, Dawn Style, Rolling Limitless Unity Form: Latch of Warmth
 - Waning Elder Arts, Augmented Army Style, Illusion Form: Six Paralyzing Remains
 - Waning Expansive Mystic Cuts Arts, Wicked Intent Style, Feral Cove Form: Five-Fold Salvation Sharpening Advent
 - Waning Fall Arts, Many Star Style, Fish Form: Dual-Cut Swaying Sanctity
 - Waning Hand Arts, Felling Return Style, Balanced Advent Form: Meditation-Following Few Method
 - Waning Ink Arts, Downward Mount Style, Calm Royal Form: Windswept Slicing Coil
 - Waning Mighty Sword Arts, Moonlit Absorption Style, Misty Form: Triple Pattern Traveling Things
 - Waning Motion Arts, Pinnacle Style, Final Grounded Pyrocascade Form: Swing of Flow
 - Waning Mystery Arts, Pure Hawk Style, Center Elements Form: Forged Tundra Sacrificing Cloud
 - Waning North Arts, Basilisk Style, Prelude Form: Illusory Circulation Resting Unbounded
 - Waning Ridge Arts, Karmic Style,  Fleche Form: Life of the Trigrams
 - Waning Seal Arts, Whirling Final Vapor Style, Finishing Move Form: Soul
 - Waning Steps Arts, Illuminating Incineration Style, Martial Poison Form: Tempo
 - Waning Yellow Astral Chackra Arts, Style Style, Poisonous Barrage Form: Triple Paradise Following Monkey
 - Waxing Chariot Arts, Southern Slashes Style, Martial Sonata Form: Dual-Phenomena Biting Devil
 - Waxing Crush Arts, Responsive Echo Style, Lost Form: Mind
 - Waxing Elements Arts, Copper Snowfield Style, Illuminating Trinity Form: Foundational Halo
 - Waxing Extreme Wicked Serpent Arts, Sealing Forged Earthly Style, Stellar Double Move Form: Slicing Spread Countering Split
 - Waxing Gateways Arts, Magnanimous Steps Style, Finger Form: Principles Revitalizing Mindscape
 - Waxing Graypine Arts, Treading Spirit Winds Style, Fading Lightweight Form: Dual-Taibai Airsplitting Hands
 - Waxing Hellfire Arts, Cosmic Ladder Style, Unrivaled Execution Form: Infiltration-Weakening Violent Nothingness
 - Waxing Legs Arts, Lower Extreme Stellar Style, Tang Form: Giant Sheet-Rises Whip
 - Waxing Lunar Brilliant Neck Arts, Buddhist Bloodstained Assimilation Style, Striking Battalion Form: Five-Fold Dao Chopping Mount
 - Waxing Mighty Needles Arts, Great Limitless Felling Style, Striking Crush Form: Corvid Might
 - Waxing Paradise Arts, Breakout Style, Snow Halo Form: Destructive Qintfade
 - Waxing Plume Arts, Fading Steps Style, Elegant Illusory Hoarforst Form: Big Authority Ascending Suffering
 - Waxing Proud Arts, Repelling Pinnacle Style, Great Full Fire Form: Profound Embrace
 - Waxing Retribution Arts, Harmonious Flying Swan Style, Snow Death Form: Ancient Bone
 - Waxing Soaring Scarlet Arts, Lake Style, Defensive Devastating Kill Form: Triple Embrace Grounding Team
 - Waxing Vedas Arts, Roving Condor Style, Unified Shower Form: Five-Fold Opposition Walking Circulation
 - Western Archery Arts, Limitless Elder Style, Repentant Phenomena Form: Trail Transforming Infiltration
 - Western Boxing Coastal Shatter Arts, Abyssal Net Style, Obscure Gentle Majestic Form: Protective Skills Piercing North
 - Western Destroyer Arts, Extended White Cuts Style, Endless Body Form: Triple Pattern Revitalizing Chackra
\page

 - Western Fiendish Switch Arts, Skeletal Coastal Crossing Style, Mad Force Form: Monastery
 - Western Intent Arts, Authority Style, Script Form: Chain
 - Western Kundali Arts, Bloody Prajna Style, Posture Form: Six Shaking Consciousness
 - Western Momentum Arts, Wild Lord Style, Single Spread Form: Dividing Thrust
 - Western Sage Arts,  Signless Style, Defensive Nefarious Deity Form: Triple Fortress Binding Mothers
 - Western Temple Arts, Fleche Style, Boxing Striking Leap Form: Triangle Confronting Windrider
 - Western Ultimate Ascending Metal Arts, Traceless Mindscape Style, Continuous Omnidirectional Form: Crossing Commander Dispersing Signless
 - Western Wild Martyr Arts, Empty Move Style, White Pyrocascade Form: Triple Nature Steeled Spirits
 - Whirling Beast Arts, Western Fish Style, North Kill Form: Five-Fold Formation Descending Moonlight
 - Whirling Coastal Mountainous Arts, Indestructible Celestial Center Style, Sage Form: Grand Pearlflower Conquering Reguard
 - Whirling Crazy Dividing Lake Arts, Deep Total Style, Glacial Infiltration Form: Six Controlling Cobra
 - Whirling Crows Arts, Change Style, Ripping Exchange Form: Triple Torment Blazing Autumn
 - Whirling Flying Harmonious Enemies Arts, Grappling Unparalleled Obsidian Style, Burning Thunderbolts Form: Giant Scale-Controlling Priest
 - Whirling Gust Arts, Buddhist Thunderous Grappling Style, Bear Form: Giant Grasp-Paralyzing Nape
 - Whirling Infinite Few Cry Arts, Deep Responsive Fiery Style, Giant Facing Warmaster Form: Six Resonating Range
 - Whirling Martial Diving Winds Arts, Intent Style, Blessed Elegance Form: Six Sacrificing Phaseless
 - Whirling Needle Arts, Blooming Profound Mystery Style, Consuming Flight Form: Triple Cyclone Reflecting Crow
 - Whirling Shadow Resonance Arts, Indestructible Boulder Style, Script Form: Five-Fold Pulse Fighting Sinister
 - Whirling Tong Arts, Road Style, Repelling Glacial Goldenring Form: Five-Fold Master Binding Things
 - Whirling Venomous Crossing Thunder Arts, Prism Style, Protective Slayer Form: Triple Retribution Controlling Butterfly
 - Whirling Virtuous North Triple Arts, Emerald Countless Thunderous Style, Felling Formation Form: Five-Fold Skills Transforming Shatter
 - White Augmented Universal Consciousness Arts, Elusive Limitless Asura Style, Unrivaled Venomous God Form: Movement Linking Death
 - White Binder Arts, Eternal Stretched Style, Buddha Form: Downward Bone
 - White Bow Arts, Indestructible Unknowable Suffering Style, Center Karma Form: Dual-Destroyer Carrying Plate
 - White Cavern Arts, Spectral Prayer Style, Avatar Form: Five-Fold Staff Summoning Night
 - White Chill Arts, Enlightened Drift Style, Magnanimous Moonlight Form: Shooting March Vispering Elder
 - White Death Arts, Tearing Sight Style, Lunar Mighty Bodhi Form: Triple of the Mobility
 - White Drain Arts, Shadow Chariot Style, Realm Form: Triple Horse Cleaving Nothingness
 - White Duck Arts, Abyssal Horse Style, Endless Monastery Form: Flow Chopping Stretched
 - White Eternal Illuminated Arts, Descending Blessing Style, Primordial Adaptive Tong Form: Five-Fold Suffering Swirling Stalwart
 - White Graceful Claw Arts, Repentant North Parallel Style, Serene Penetrating Contemplate Form: Pattern Slicing Mental
 - White Kindled Arts, Celestial Pearlflower Style, Buddhist Torment Form: Illuminating Marquis Drifting Scarlet
 - White Nefarious Omnidirectional Arts, Many Void Return Style, Exploding Tongue Form: Hand of Frontier
 - White Piercer Arts, Few Traversing Extra Style, Extinguishing Grafting Turtle Form: Five-Fold Statue Coiling Resonance
 - White Spirit Fog Arts, Legged Holy Basic Style, Warfield Form: Giant Master-Binding Rotation
 - White Turtleback Arts, Obscure Adamantine Depth Style, Universal Dancing Dive Form: Five-Fold Millennium Going Web
 - White Wildfire Arts, Circle Style, Immortal Pillar Form: Giant Harmonies-Binding Roars
 - Wicked Arhat Arts, Energy Style, Waning North Pierces Form: Dual-Volcanoes Surging Stream
 - Wicked Asterism Arts, Ascent Style, Extinguishing Nature Form: Sight of Drift
 - Wicked Azure Light Arts, Dirty Dipper Style, Old Primordial Dive Form: Giant Sisi-Summoning Projectile
\page

 - Wicked Battalion Arts, Snow Whirlwind Style, Endless Total Form: Giant Pattern-Cutting Snakeform
 - Wicked Beast Arts, Subduing Direction Style, Brilliant Sharpened Form: Contemplate of Slash
 - Wicked Bodhi Arts, Extra Sonic Striking Style, Aquatic Quanzhen Form: Icebolt of the Underworld
 - Wicked Countless Opening Arts, Flying Devil Style, Profound Manipulation Form: Mindscape Blazing Jeweled
 - Wicked Eruption Arts, Finishing Volcano Style, Gem Authority Form: Six Swirling Crushes
 - Wicked Forged Silent Arts, Vile Quick Style, Shooting Tundra Form: Empty Yang Searching Raptor
 - Wicked Graceful Parallel Tranquil Arts, Limbo Style, Aureate River Form: Beggar of Emptiness
 - Wicked Imperial Earthly Sun Arts, Mystic Advanced Meridian Style, Shooting Roars Form: Dual-Phantom Going Mountainous
 - Wicked Moonlight Arts, Shadow Chill Style, Saving Imperial Beak Form: Five-Fold Rotation Stopping Myriads
 - Wicked Toss Arts, Western Flash Style, Awakening Form: Evil Archery Lunging Eternal
 - Wicked Transparency Arts, Repelling Burning Blaze Style, Featherweight Disruption Form: Waxing Riddle
 - Wicked Universal Elegant West Arts, Arching Swift Style, Enlightened Sonic Shade Form: Triple Truth Paralizing Trigrams
 - Wicked Whip Arts, Burning Command Style, Crazy Beggar Form: Penetration of the Netherworld
 - Wild Awakening Arts, Cawing Governing Skill Style, Devastating Shield Form: Manifestations Flowing Waves
 - Wild Commander Arts, Gallant Gentle Breakout Style, Moonlit Grounded Sight Form: Malevolent Siege
 - Wild Encompassing Elusive Array Arts, Snakeform Style, Grand Martial Mental Form: Fortress Rising Perfusion
 - Wild Fortress Arts, Twin Bone Style, Graceful Siege Form: Giant Swarm-Linking Assaliants
 - Wild Plague Arts, Unshakable Principles Style, Thunderous Tranquil Form: Triple Reguard Crouching Signless
 - Wild Stellar Hunyuan Arts, Double Repelling Fiendish Style, Deep Wing Form: Five-Fold Wall Stopping Trill
 - Wild Unshakable Road Arts, Sacred Unified Holy Style, Onyx Storm Form: Hidden Interference Searching Tea
 - Wild Warriors Arts, Erupting Gallant Tongue Style, Bloody Shard Form: Drain Severing Rhythm
 - Wild Zenith Arts, Expansive Moonbeam Style, Imperial Breakthrough Form: Posture-Bowing Parallel Mothers
 - Wounding Adamantine Treading Asterism Arts, Traceless Waning Fading Style, Enemy Form: Few Enigma
 - Wounding Blessing Arts, Crimson Living Celestial Style, Virtuous Command Form: Six Observing Frontier
 - Wounding Copper Center Arts, Unshakable Outward Evil Style, Void Stride Form: Bind Crushing Fall
 - Wounding Drunken Bodhi Arts, Taming Style, Imperial Cobra Form: Six Ending Acala
 - Wounding Edge Arts, Shooting Grappling Ink Style, Void Luminous Stomp Form: Five-Fold Eclipse Aiming Flashes
 - Wounding Emperor Arts, Dominating Crazy Starlight Style, Evil Felling North Form: Siege Swirling Frostbite
 - Wounding Exchange Arts, Walk Style, Heavenly Woods Form: Triple Rectitude Slicing Eclipse
 - Wounding Flame Arts, Foundational Rising Veil Style, Mirage Prajna Form: Five-Fold Ape Biting Element
 - Wounding Force Arts, Exchange Style, Endless Light Form: Mist of the Severance
 - Wounding Gallant Meditation Arts, Empty Foundation Style, Divine Vedas Form: Dual-Might Dispersing Binder
 - Wounding Gem Shattering Disruption Arts, Roving Windrider Style, Graceful Swift Form: Dual-Authority Binding Trial
 - Wounding Gem Unknowable Gateways Arts, Sutra Style, Single Prayer Form: Aura of Taebaek
 - Wounding Lower Shroud Arts, Astral Silver Penetrating Style, Corrupted Cold Aura Form: Dark Grace
 - Wounding Pattern Arts, Malevolent Discipline Style, Wild Copper Ascension Form: Opening of Elegance
 - Wounding Sufferings Arts, Daoist Style, Ravenous Drowned Form: Hawkstrider of Suppression
 - Wounding Universal Wrath Arts, Unknowable Sealing Spiritual Style, Roving Shatter Form: Five-Fold Pounce Gathering Arm
 - Wounding White Momentum Arts, Waning Shura Style, Grafting Spread Form: Triple Tranquil Freezing Sonata
 - Yellow Big Holy Scatter Arts, True Elegant Cold Style, Continuous Mystery Form: Triple Exorcism Poking Soul
\page

 - Yellow Cliff Arts, Fading Soul Style, Grafting Prelude Form: Triple Roars Grounding Legs
 - Yellow Demonic Trident Arts, Invisible Wicked Cry Style, Center Bow Form: Order of the Endless Assaliants
 - Yellow Downward Unparalleled View Arts, Righteous Undivinable Killing Style, Charging Tongue Form: Self Emerging Star
 - Yellow Man Arts, Saving Otherness Style, Pure Bodhidharma Form: Battle of the Continuous Assaliants
 - Yellow Reflect Arts, Legs Style, Skeletal Pearl Form: Wicked Reaper Freezing Heavenhold
 - Yellow Rends Arts, Crows Style, Magnanimous Cosmic Strikes Form: Mad Path
 - Yellow Righteous Corvid Method Arts, Unmatched Cut Style, Repentant Saint Form: Sage Piercing Tongue
 - Yellow Ripping Extreme Wrath Arts, Spinning Astral Spiritual Style, Blessed Ancient Nether Form: Violent Shard
 - Yellow Roars Arts, Chaotic Splitting Outward Style, Assimilation Form: Imperial Fury
 - Yellow Traditional Limbo Arts, Fertile Coated Vile Style, Adaptive Chill Form: Waning Torment
\page

{{backcover

}}