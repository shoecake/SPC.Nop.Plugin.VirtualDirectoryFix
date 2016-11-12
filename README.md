# SPC Fix for bundling CSS in a Virtual Directory
Currently the CSS bundling service does not transform links to images correctly (i.e. css using the url method).

e.g. a css line of:
background: url('../img/rss-icon.png'); gets transformed to /img/rss-icon.png when it should get transformed to /virtualdir/img/rss-icon.png

There is a bug in the Microsoft.AspNet.Web.Optimization project where the code does not take into account the application path when transforming relative links. It does not look like that code is being maintained as this fix has been available for some time. The original fix I took from https://github.com/benmccallum/AspNetBundling/blob/master/AspNetBundling/CssRewriteUrlTransformFixed.cs

This plugin will fix this issue with CSS bundling when nopCommerce is installed in a virtual directory. 

