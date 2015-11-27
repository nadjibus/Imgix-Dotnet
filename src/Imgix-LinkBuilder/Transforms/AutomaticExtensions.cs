﻿namespace Imgix_LinkBuilder.Transforms.Automatic
{
    /// <summary>
    /// ImgixImage extension methods that set auto related parameters on the Url.
    /// </summary>
    public static class AutomaticExtensions
    {
        /// <summary>
        /// Will add an auto enhancement parameter to the url
        /// </summary>
        /// <param name="image">The image to transform</param>
        /// <param name="value">
        ///     The value of the auto parameter
        ///     Values: enhance, format, redeye
        /// </param>
        /// <returns></returns>
        public static ImgixImage Auto(this ImgixImage image, string value)
            => image.AddParameter("auto", value);
    }
}