const { DateTime } = require('luxon')
const pluginRss = require('@11ty/eleventy-plugin-rss')
const pluginSyntaxHighlight = require('@11ty/eleventy-plugin-syntaxhighlight')
const pluginTOC = require('eleventy-plugin-nesting-toc')
const eleventyNavigationPlugin = require('@11ty/eleventy-navigation')
require("dotenv").config();

var cleanCSS = require("clean-css");

var fs = require("fs");

var pluginRSS = require("@11ty/eleventy-plugin-rss");

var localImages = require("eleventy-plugin-local-images");

var lazyImages = require("eleventy-plugin-lazyimages");

var ghostContentAPI = require("@tryghost/content-api");


var htmlMinTransform = require("./_config/html-min-transform.js"); // Init Ghost API


var api = new ghostContentAPI({
  url: process.env.GHOST_API_URL,
  key: process.env.GHOST_CONTENT_API_KEY,
  version: "v2"
}); // Strip Ghost domain from urls

var stripDomain = function stripDomain(url) {
  return url.replace(process.env.GHOST_API_URL, "");
};


module.exports = function(eleventyConfig) {

  eleventyConfig.addFilter("getReadingTime", function (text) {
    var wordsPerMinute = 200;
    var numberOfWords = text.split(/\s/g).length;
    return Math.ceil(numberOfWords / wordsPerMinute);
  }); // Date formatting filter

  eleventyConfig.addFilter("htmlDateString", function (dateObj) {
    return new Date(dateObj).toISOString().split("T")[0];
  }); // Don't ignore the same files ignored in the git repo

  eleventyConfig.setUseGitIgnore(false); // Get all pages, called 'docs' to prevent
  // conflicting the eleventy page object

  eleventyConfig.addCollection("docs", function _callee(collection) {
    return regeneratorRuntime.async(function _callee$(_context) {
      while (1) {
        switch (_context.prev = _context.next) {
          case 0:
            _context.next = 2;
            return regeneratorRuntime.awrap(api.pages.browse({
              include: "authors",
              limit: "all"
            })["catch"](function (err) {
              console.error(err);
            }));

          case 2:
            collection = _context.sent;
            collection.map(function (doc) {
              doc.url = stripDomain(doc.url);
              doc.primary_author.url = stripDomain(doc.primary_author.url); // Convert publish date into a Date object

              doc.published_at = new Date(doc.published_at);
              return doc;
            });
            return _context.abrupt("return", collection);

          case 5:
          case "end":
            return _context.stop();
        }
      }
    });
  }); // Get all posts

  eleventyConfig.addCollection("posts", function _callee2(collection) {
    return regeneratorRuntime.async(function _callee2$(_context2) {
      while (1) {
        switch (_context2.prev = _context2.next) {
          case 0:
            _context2.next = 2;
            return regeneratorRuntime.awrap(api.posts.browse({
              include: "tags,authors",
              limit: "all"
            })["catch"](function (err) {
              console.error(err);
            }));

          case 2:
            collection = _context2.sent;
            collection.forEach(function (post) {
              post.url = stripDomain(post.url);
              post.primary_author.url = stripDomain(post.primary_author.url);
              post.tags.map(function (tag) {
                return tag.url = stripDomain(tag.url);
              }); // Convert publish date into a Date object

              post.published_at = new Date(post.published_at);
            }); // Bring featured post to the top of the list

            collection.sort(function (post, nextPost) {
              return nextPost.featured - post.featured;
            });
            return _context2.abrupt("return", collection);

          case 6:
          case "end":
            return _context2.stop();
        }
      }
    });
  }); // Get all authors

  eleventyConfig.addCollection("authors", function _callee4(collection) {
    var posts;
    return regeneratorRuntime.async(function _callee4$(_context4) {
      while (1) {
        switch (_context4.prev = _context4.next) {
          case 0:
            _context4.next = 2;
            return regeneratorRuntime.awrap(api.authors.browse({
              limit: "all"
            })["catch"](function (err) {
              console.error(err);
            }));

          case 2:
            collection = _context4.sent;
            _context4.next = 5;
            return regeneratorRuntime.awrap(api.posts.browse({
              include: "authors",
              limit: "all"
            })["catch"](function (err) {
              console.error(err);
            }));

          case 5:
            posts = _context4.sent;
            // Attach posts to their respective authors
            collection.forEach(function _callee3(author) {
              var authorsPosts;
              return regeneratorRuntime.async(function _callee3$(_context3) {
                while (1) {
                  switch (_context3.prev = _context3.next) {
                    case 0:
                      authorsPosts = posts.filter(function (post) {
                        post.url = stripDomain(post.url);
                        return post.primary_author.id === author.id;
                      });
                      if (authorsPosts.length) author.posts = authorsPosts;
                      author.url = stripDomain(author.url);

                    case 3:
                    case "end":
                      return _context3.stop();
                  }
                }
              });
            });
            return _context4.abrupt("return", collection);

          case 8:
          case "end":
            return _context4.stop();
        }
      }
    });
  }); // Get all tags

  eleventyConfig.addCollection("tags", function _callee6(collection) {
    var posts;
    return regeneratorRuntime.async(function _callee6$(_context6) {
      while (1) {
        switch (_context6.prev = _context6.next) {
          case 0:
            _context6.next = 2;
            return regeneratorRuntime.awrap(api.tags.browse({
              include: "count.posts",
              limit: "all"
            })["catch"](function (err) {
              console.error(err);
            }));

          case 2:
            collection = _context6.sent;
            _context6.next = 5;
            return regeneratorRuntime.awrap(api.posts.browse({
              include: "tags,authors",
              limit: "all"
            })["catch"](function (err) {
              console.error(err);
            }));

          case 5:
            posts = _context6.sent;
            // Attach posts to their respective tags
            collection.forEach(function _callee5(tag) {
              var taggedPosts;
              return regeneratorRuntime.async(function _callee5$(_context5) {
                while (1) {
                  switch (_context5.prev = _context5.next) {
                    case 0:
                      taggedPosts = posts.filter(function (post) {
                        post.url = stripDomain(post.url);
                        return post.primary_tag && post.primary_tag.slug === tag.slug;
                      });
                      if (taggedPosts.length) tag.posts = taggedPosts;
                      tag.url = stripDomain(tag.url);

                    case 3:
                    case "end":
                      return _context5.stop();
                  }
                }
              });
            });
            return _context6.abrupt("return", collection);

          case 8:
          case "end":
            return _context6.stop();
        }
      }
    });
  });
  eleventyConfig.addPlugin(pluginRss)
  eleventyConfig.addPlugin(pluginSyntaxHighlight)

  eleventyConfig.addFilter('simpleDate', dateObj => {
    return DateTime.fromJSDate(dateObj, { zone: 'utc' }).toFormat('LLL dd, yyyy')
  })

  eleventyConfig.addPlugin(pluginTOC, {
    tags: ['h2'],
    wrapper: 'div',
    wrapperClass: ''
  })

  eleventyConfig.addPlugin(eleventyNavigationPlugin)

  // Get the first `n` elements of a collection.
  eleventyConfig.addFilter('head', (array, n) => {
    if (n < 0) {
      return array.slice(n)
    }
    return array.slice(0, n)
  })

  // https://html.spec.whatwg.org/multipage/common-microsyntaxes.html#valid-date-string
  eleventyConfig.addFilter('htmlDateString', dateObj => {
    return DateTime.fromJSDate(dateObj).toFormat('yyyy-LL-dd')
  })

  // only content in the `posts` directory
  eleventyConfig.addCollection('posts2', function(collection) {
    return collection.getFilteredByGlob('./_site/posts2/*.md').reverse()
  })

  // only content in the `courses` directory
  eleventyConfig.addCollection('courses', function(collection) {
    return collection.getFilteredByGlob('./_site/courses/*.md').reverse()
  })

  // only content in the `projects` directory
  eleventyConfig.addCollection('projects', function(collection) {
    return collection.getFilteredByGlob('./_site/projects/**/*.md')
  })

  // only content in the `rayveal` directory
  eleventyConfig.addCollection('rayveal', function(collection) {
    return collection.getFilteredByGlob('./_site/projects/rayveal/*.md')
  })

  // only content in the `seven` directory
  eleventyConfig.addCollection('seven', function(collection) {
    return collection.getFilteredByGlob('./_site/projects/seven/*.md')
  })

  eleventyConfig.addCollection('searchable', function(collection) {
    return collection
      .getFilteredByGlob(['./_site/courses/*.md', './_site/posts/*.md', './_site/projects/**/*.md'])
      .reverse()
  })

  eleventyConfig.addCollection('tagList', require('./_site/_templates/getTagList'))

  eleventyConfig.addPassthroughCopy('./_site/images')

  /* Markdown Plugins */
  let markdownIt = require('markdown-it')
  let markdownItAnchor = require('markdown-it-anchor')
  let options = {
    html: true,
    breaks: true,
    linkify: true
  }
  let opts = {
    permalink: true,
    permalinkClass: 'direct-link',
    permalinkSymbol: ' '
  }

  eleventyConfig.setLibrary('md', markdownIt(options).use(markdownItAnchor, opts))

  return {
    templateFormats: ['md', 'njk', 'html', 'liquid', 'pug', 'hbs'],
    pathPrefix: '/',
    markdownTemplateEngine: 'liquid',
    htmlTemplateEngine: 'njk',
    dataTemplateEngine: 'njk',
    setQuietMode: true,
    passthroughFileCopy: true,
    dir: {
      input: '_site',
      includes: '_templates',
      data: '_data',
      output: 'dist'
    }
  }
}
