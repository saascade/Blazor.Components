using Saascade.Blazor.Components.Base; 
using Saascade.Blazor.DesignSystems.Custom.Empty; 
using Saascade.Blazor.DesignSystems.Bootstrap5.Vanilla; 
using Saascade.Blazor.DesignSystems.Tailwind.Basecoat;
using Saascade.Blazor.DesignSystems.Tailwind.DaisyUI;
using Saascade.Blazor.DesignSystems.Custom.Handdrawn;
using Saascade.Blazor.DesignSystems.Custom.Basic1;

namespace Saascade.Blazor.DesignSystems;

public static class DesignSystems
{
    //https://www.reddit.com/r/tailwindcss/comments/1mkso56/best_tailwind_component_libraries_free/

    public static class Custom
    {
        public static IDesignSystem EmptyDesignSystem = new EmptyDesignSystem();
        public static IDesignSystem Basic1 = new Basic1DesignSystem();
 
        public static IDesignSystem HanddrawnAssessible = new HanddrawnAssessibleDesignSystem();
        public static IDesignSystem HanddrawnBlackAndWhite = new HanddrawnBlackAndWhiteDesignSystem();
        public static IDesignSystem HanddrawnColor = new HanddrawnColorDesignSystem();
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
