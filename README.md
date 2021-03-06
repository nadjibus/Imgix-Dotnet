# Imgix-Dotnet (Net Standard Fork)

**Note: This project is still in its infancy**

[![Build status](https://ci.appveyor.com/api/projects/status/3otyegok2cu9h983/branch/master?svg=true)](https://ci.appveyor.com/project/RasmusLauridsen/imgix-dotnet/branch/master)

A fluent imgix link builder library.
[Imgix](https://www.imgix.com/) is a hosted real time image processing service.

## Features

* Fluent interface
* Easily extensible
* Sharded sources
* Full support for [request signing](https://www.imgix.com/docs/tutorials/securing-images)
* Flexible configuration options


## Getting started

Make sure you have an account set up at [imgix](https://www.imgix.com/)
Next install the package with the following command

``` powershell
PM> Install-Package Imgix-NetStandard
```

Once you have installed the package to your project, you can get started creating image links.

``` csharp
/* https://assets.imgix.net/blog/woman-hat.jpg?w=200&h=200&mask=ellipse&fit=crop&crop=faces&fm=png */
var result = Imgix.CreateImage("blog/woman-hat.jpg", "assets")
                  .Width(200)
                  .Height(200)
                  .EllipseMask()
                  .Fit("crop")
                  .Crop("faces")
                  .AddParameter("fm", "png") //If there is no method for an operation just add a manual parameter.
```

[![Example](https://assets.imgix.net/blog/woman-hat.jpg?w=200&h=200&mask=ellipse&fit=crop&crop=faces&fm=png)](https://assets.imgix.net/blog/woman-hat.jpg?w=200&h=200&mask=ellipse&fit=crop&crop=faces&fm=png)

*Example image from the [imgix sandbox](https://sandbox.imgix.com/create)*

The ImgixImage class is immutable so it is always a new image that is returned.
This means that you can use the same image to create multiple resulting images, without worrying about shared state.

Multiple different formats are quickly created in a very dry way.

``` csharp

//Setting up the base shape and format of the image
var baseImage = Imgix.CreateImage("blog/woman-hat.jpg", "assets")
    .Fit("crop")
    .Crop("faces")
    .AddParameter("faceindex", "1");
//Creating multiple sizes
var image400x200 = baseImage.Width(400).Height(200);
var image200x400 = baseImage.Width(200).Height(400);

```

[![Example](https://assets.imgix.net/blog/woman-hat.jpg?fit=crop&crop=faces&faceindex=1&w=400&h=200)](https://assets.imgix.net/blog/woman-hat.jpg?fit=crop&crop=faces&faceindex=1&w=400&h=200) 400x200px
[![Example](https://assets.imgix.net/blog/woman-hat.jpg?fit=crop&crop=faces&faceindex=1&w=200&h=400)](https://assets.imgix.net/blog/woman-hat.jpg?fit=crop&crop=faces&faceindex=1&w=200&h=400) 200x400px

*Example image from the [imgix sandbox](https://sandbox.imgix.com/create)*

## Changes

* 2018-11-11 - Ported to .NET Standard 2.0 on [nuget](https://www.nuget.org/packages/Imgix-NetStandard/)
* 2015-12-02 - Version 0.0.1 Released on [nuget](https://www.nuget.org/packages/Imgix-Dotnet/)
