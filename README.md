# HXML.NET

![Hyperview Logo](./hv.svg)

This is a package designed to add server side helper methods for Razor. This makes serving HXML (Hyperview) content from ASP.NET Core projects a lot simpler. 

## What is HXML and Hyperview?

1. For a detailed explanation of HXML and Hyperview technical and architectural concepts see [Hypermedia Systems](https://hypermedia.systems).
2. For the specs behind HXML see [the Hyperview website](https://hyperview.org/docs/reference_index).

## Why HXML.NET?

HXML is not HTML, therefore the ASP.NET Core Razor Engine, which was made for HTML templating, is not set up to be an HXML templating engine. Although it can be used as an HXML (and XML, generally) templating engine, there will be no IDE support which is what makes Razor so powerful and valuable. While it is completely viable to model HXML as objects (e.g. System.Xml.Linq), it does not feel as natural as using a templating engine.

However, ASP.NET Core does provide tag helpers. Tag helpers allow us to create custom XML tags and attributes to use within Razor files and thus providing syntax highlighting and IDE support to non-HTML tags. This is what HXML.NET is. It is a bunch of tag helpers to enable syntax highlighting to make writing HXML with Razor a much better developer experience. 

