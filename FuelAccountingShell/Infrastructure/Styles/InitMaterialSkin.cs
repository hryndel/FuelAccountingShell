using MaterialSkin;
using MaterialSkin.Controls;

namespace FuelAccountingShell.Infrastructure.Styles
{
    public static class InitMaterialSkin
    {
        public static void StylizationUI(MaterialForm form)
        {
            var material = MaterialSkinManager.Instance;
            material.AddFormToManage(form);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Grey50, Primary.Grey600, Primary.Grey900, Accent.Blue100, TextShade.BLACK);
        }
    }
}
