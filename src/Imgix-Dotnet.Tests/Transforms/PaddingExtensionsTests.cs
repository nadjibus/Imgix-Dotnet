﻿using Imgix_Dotnet.Tests.TestHelpers;
using Imgix_Dotnet.Transforms.Padding;
using NUnit.Framework;

namespace Imgix_Dotnet.Tests.Transforms
{
    [TestFixture]
    public class PaddingExtensionsTests : TransformsTests
    {
        public class Padding : PaddingExtensionsTests
        {
            [Test]
            public void Given_an_integer_value_it_will_add_a_parameter_pad_with_the_integer_as_value()
            {
                ImgixImageAsserts.HasQueryParameter(Image.Padding(20), "pad", "20");
            }
        }
    }
}