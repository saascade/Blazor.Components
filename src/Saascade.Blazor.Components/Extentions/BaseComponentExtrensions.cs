using Humanizer;

namespace Saascade.Blazor.Components.Base;

public static class BaseComponentExtensions
{ 
    extension(BaseComponent component)
    {
        /// <summary>
        /// Returns css classes for H1-6.
        /// Otherwise returns null
        /// </summary>
        /// <returns></returns>
        public string? GetStandardCssClassesForBasicHtmlElements() => component.GetType().Name switch
        {
            nameof(H1) => "h1",
            nameof(H2) => "h2",
            nameof(H3) => "h3",
            nameof(H4) => "h4",
            nameof(H5) => "h5",
            nameof(H6) => "h6",
            _ => null
        };
    } 
}