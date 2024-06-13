@import 'normalize.css';

:root {
  --color-primary: #d73953;
  --color-black: #090909;
  --color-white: #ffffff;
  --color-light-grey: #f3f3f3;
  --color-dark-grey: #353535;
  --text-color: var(--color-black);
  --font-family-base: 'Open Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif;
  --font-family-title: 'Raleway', 'Helvetica Neue', Helvetica, Arial, sans-serif;
  --font-size-small: 1.2rem;
  --font-size-medium: 1.6rem;
  --font-size-large: 1.8rem;
  --font-size-x-large: 2.3rem;
  --font-size-xx-large: 4.8rem;
  --font-weight-regular: 400;
  --font-weight-bold: 700;
  --line-height-small: 1.2;
  --line-height-base: 1.5;
  --line-height-big: 1.8;
  --section-header-align: center;
  --section-tagline-transform: uppercase;
  --section-title-margin: 0;
  --section-title-color: var(--color-black);
  --section-padding: 5rem 0;
  --section-header-padding: 0 0 3rem;
  --section-body-padding: 0 0 3rem;
  --section-footer-padding: 3rem 0 0;
  --section-footer-align: center;
  --footer-padding: 5rem 0 1rem;
  --nav-item-font-family: var(--font-family-title);
  --nav-item-font-weight: var(--font-weight-bold);
  --nav-item-font-size: var(--font-size-medium);
  --nav-item-letter-spacing: 4%;
  --nav-item-display: inline-block;
  --nav-item-margin: 0 0 3rem 0;
  --nav-item-link-hover: var(--color-white);
  --section-tagline-margin: 0;
  --button-display: inline-block;
  --button-padding: 1.5rem 3rem;
  --button-border: 0.2rem solid var(--color-primary);
  --button-color: var(--color-black);
  --button-text-decoration: none;
  --button-font-size: var(--font-size-large);
  --button-hover-color: var(--color-white);
  --button-hover-text-decoration: none;
  --button-hover-background: var(--color-primary);
  --header-padding: 4rem 0 0;
  --header-logo-position: relative;
  --header-logo-link-display: inline-block;
  --header-logo-link-position: absolute;
  --header-logo-link-top: -1rem;
  --header-logo-link-left: 0;
}

[data-section-theme='dark'] {
  --text-color: var(--color-white);
  --section-title-color: var(--color-white);
  background-color: var(--color-black);
  --button-color: var(--color-white);
}

*,
*::before,
*::after {
  box-sizing: border-box;
}

html {
  scroll-behavior: smooth;
  font-size: 62.5%;
}

body {
  font-family: var(--font-family-base);
  font-size: var(--font-size-medium);
  font-weight: var(--font-weight-regular);
  color: var(--text-color);
  line-height: var(--line-height-base);
}

.header {
  padding: var(--header-padding);
}

.header-logo {
  position: var(--header-logo-position);
}

.header-logo a {
  display: var(--header-logo-link-display);
  position: var(--header-logo-link-position);
  top: var(--header-logo-link-top);
  left: var(--header-logo-link-left);
}

h1,
h2,
h3,
h4,
h5,
h6 {
  font-family: var(--font-family-title);
  font-weight: var(--font-weight-bold);
}

a:link {
  color: var(--text-color);
  text-decoration: none;
}

a:visited {
  font-style: italic;
}

a:hover {
  text-decoration: underline;
}

a:active {
  background-color: var(--color-light-grey);
}

.button {
  display: var(--button-display);
  padding: var(--button-padding);
  border: var(--button-border);
  font-size: var(--button-font-size);
  color: var(--button-color);
  text-decoration: var(--button-text-decoration);
}

.button:hover {
  color: var(--button-hover-color);
  text-decoration: var(--button-hover-text-decoration);
  background-color: var(--button-hover-background);
}

.visually-hidden {
  display: none;
}

.section {
  padding: var(--section-body-padding);
}

.section-header {
  text-align: var(--section-header-align);
  padding: var(--section-header-padding);
}

.section-body {
  padding: var(--section-body-padding);
}

.section-footer {
  text-align: var(--section-footer-align);
  padding: var(--section-footer-padding);
}

.card-work .card-outer {
  position: relative;
  overflow: hidden;
}

.card-work .card-image img {
  height: 30rem;
  width: 100%;
  object-fit: cover;
  vertical-align: bottom;
}

.card-work .card-inner {
  position: absolute;
  top: -0.1rem;
  left: -0.1rem;
  right: -0.1rem;
  z-index: 1;
}

.card-work:hover .card-inner {
  background-color: rgba(0, 0, 0, 0.7);
}

.card-work .card-title {
  text-align: center;
  margin: 0;
  opacity: 0;
  height: 100%;
  position: relative;
}

.card-work .card-title a {
  display: block;
  text-decoration: none;
  padding-top: 45%;
}

.card-work .card-title a::after {
  position: absolute;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  content: '';
}

.card-work:hover .card-title {
  opacity: 1;
}

.card-category {
  color: var(--color-primary);
}

.section-title {
  font-family: var(--font-family-title);
  font-size: var(--font-size-x-large);
  font-weight: var(--font-weight-bold);
  margin: var(--section-title-margin);
  color: var(--section-title-color);
}

.section-tagline {
  color: var(--color-primary);
  font-family: var(--font-family-title);
  text-transform: var(--section-tagline-transform);
  font-weight: var(--font-weight-bold);
  margin: var(--section-tagline-margin);
}

.container {
  width: 960px;
  margin-left: auto;
  margin-right: auto;
}

.navbar-menu {
  float: right;
}

.nav {
  margin: 0;
  padding: 0;
  list-style: none;
  text-align: center;
}

.nav-item {
  font-family: var(--nav-item-font-family);
  font-weight: var(--nav-item-font-weight);
  font-size: var(--nav-item-font-size);
  letter-spacing: var(--nav-item-letter-spacing);
  display: var(--nav-item-display);
  margin: var(--nav-item-margin);
}

.nav-link {
  display: block;
  padding: 0.5rem 1rem;
}

.nav .nav-link::before {
  content: '';
  position: absolute;
  top: 0;
  left: 0;
  background-color: var(--color-white);
  width: 0;
  height: 0.2rem;
}

.nav .nav-item:hover .nav-link::before {
  background-color: var(--color-primary);
  width: 100%;
}

.nav-link:hover {
  color: var(--nav-item-link-hover);
}

ul.row {
  margin: 0;
  padding: 0;
  list-style: none;
}

.col-1-3 {
  width: 33.33%;
}

.col-1-2 {
  width: 50%;
}

.footer-copyright {
  margin: 0;
  font-size: var(--font-size-small);
  color: var(--text-color);
}

.row::after {
  content: '';
  display: table;
  clear: both;
}

[class*='col-'] {
  float: left;
  padding: 0.5rem;
}

.card-services .card-title {
  margin: 0;
}

.card-services a {
  display: block;
  padding: 2rem;
  background-color: var(--color-light-grey);
}

.card-services a:hover {
  color: var(--color-white);
  background-color: var(--color-primary);
  text-decoration: none;
}

.card-testimonial {
  text-align: center;
}

.card-testimonial .card-avatar {
  border-radius: 50%;
  width: 10rem;
  height: 10rem;
}

.card-testimonial .card-quote cite {
  display: block;
  padding-top: 1rem;
  color: var(--color-primary);
}

.card-testimonial .card-quote {
  position: relative;
}

.card-testimonial .card-quote::before {
  content: '\201C';
  position: absolute;
  top: -4.5rem;
  left: -1rem;
  color: #efeded;
  font-size: 10rem;
  z-index: -1;
}

.section-hero {
  background-size: 90rem auto;
}

.section-hero .section-title {
  margin

  .section-hero .section-title {
    margin-bottom: 5rem;
  }

  .section-hero .section-inner {
    padding: 10rem 40rem 2rem 0;
  }

  .social-link {
    display: block;
  }

  .social-link > svg {
    fill: var(--text-color);
  }

  .footer-address {
    color: var(--text-color);
  }

  .footer ul {
    text-align: right;
  }

  .footer {
    padding: var(--footer-padding);
  }
}


