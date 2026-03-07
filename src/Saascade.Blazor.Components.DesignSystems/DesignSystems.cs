using Saascade.Blazor.Components.Base; 
using Saascade.Blazor.Components.DesignSystems.BlankSlate.Empty; 
using Saascade.Blazor.Components.DesignSystems.Bootstrap5.Vanilla; 
using Saascade.Blazor.Components.DesignSystems.Tailwind.Basecoat;
using Saascade.Blazor.Components.DesignSystems.Tailwind.DaisyUI;

namespace Saascade.Blazor.Components.DesignSystems;

public static class DesignSystems
{
    //https://www.reddit.com/r/tailwindcss/comments/1mkso56/best_tailwind_component_libraries_free/

    public static class BlankSlate
    {
        public static IDesignSystem EmptyDesignSystem = new EmptyDesignSystem();
    }

    public static class Bootstrap4
    { 
    }

    public static class Bootstrap5
    {
        public static IDesignSystem VanillaBootstrap5 = new VanillaBootstrap5DesignSystem();
    }

    public static class Tailwind
    {
        public static IDesignSystem DaisyUI = new DaisyUiDesignSystem();
        public static IDesignSystem Basecoat = new BasecoatDesignSystem();
    }  
}
