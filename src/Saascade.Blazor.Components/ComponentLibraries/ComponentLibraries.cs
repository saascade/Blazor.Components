using Saascade.Blazor.Components.Base;
using Saascade.Blazor.Components.ComponentLibraries.BlankSlate;
using Saascade.Blazor.Components.ComponentLibraries.Bootstrap5;
using Saascade.Blazor.Components.ComponentLibraries.Tailwind;

namespace Saascade.Blazor.Components.ComponentLibraries;

public static class ComponentLibraries
{
    //https://www.reddit.com/r/tailwindcss/comments/1mkso56/best_tailwind_component_libraries_free/

    public static class BlankSlate
    {
        public static IComponentLibrary EmptyComponentLibrary = new EmptyComponentLibrary();
    }

    public static class Bootstrap5
    {
        public static IComponentLibrary VanillaBootstrap5 = new VanillaBootstrap5ComponentLibrary();
    }

    public static class Tailwind
    {
        public static IComponentLibrary DaisyUI = new DaisyUIComponentLibrary();
        public static IComponentLibrary Basecoat = new BasecoatComponentLibrary();
    }  
}
