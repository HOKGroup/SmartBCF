using Autodesk.Revit.UI;
using HOK.SmartBCF.AddIn.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HOK.SmartBCF.AddIn
{
    /// <summary>
    /// External Application
    /// </summary>
    public class AppCommand : IExternalApplication
    {
        internal static AppCommand thisApp = null;
        private MainWindow mainWindow = null;
        private string tabName = "  HOK - Beta";

        /// <summary>
        /// On Shut Down
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        public Result OnShutdown(UIControlledApplication application)
        {
            if (mainWindow != null && mainWindow.IsVisible)
            {
                mainWindow.Close();
            }
            return Result.Succeeded;
        }

        /// <summary>
        /// On Start Up
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        public Result OnStartup(UIControlledApplication application)
        {
            try
            {
                thisApp = this;
                mainWindow = null;
                //Create a tab named HOK - Beta
                try { application.CreateRibbonTab(tabName); }
                catch { }

                //ribbon panel named BCF
                RibbonPanel panel = application.CreateRibbonPanel(tabName, "BCF");
                string currentAssembly = System.Reflection.Assembly.GetAssembly(this.GetType()).Location;
                //button image from resources
                BitmapSource sheetImage = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(Resources.walker.GetHbitmap(), IntPtr.Zero, System.Windows.Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

                PushButton sheetButton = panel.AddItem(new PushButtonData("Smart BCF", "Smart BCF", currentAssembly, "HOK.SmartBCF.AddIn.Command")) as PushButton;
                sheetButton.LargeImage = sheetImage;
                sheetButton.AvailabilityClassName = "HOK.SmartBCF.AddIn.Availability";

                //instruction file to open by F1 key
                string instructionFile = @"https://github.com/HOKGroup/SmartBCF";
                if (File.Exists(instructionFile))
                {
                    ContextualHelp contextualHelp = new ContextualHelp(ContextualHelpType.Url, instructionFile);
                    sheetButton.SetContextualHelp(contextualHelp);
                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            return Result.Succeeded;
        }

        /// <summary>
        /// Open Modeless Dialog
        /// </summary>
        /// <param name="uiapp"></param>
        public void ShowWindow(UIApplication uiapp)
        {
            if (mainWindow == null)
            {
                BCFHandler handler = new BCFHandler(uiapp);
                ExternalEvent exEvent = ExternalEvent.Create(handler);

                mainWindow = new MainWindow(exEvent, handler);
                mainWindow.Closed += WindowClosed;
                mainWindow.Show();
            }
        }

        /// <summary>
        /// Close Database Connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void WindowClosed(object sender, System.EventArgs e)
        {
            mainWindow = null;
            bool closed = BCFDBWriter.BCFDBWriter.CloseConnection();
        }
    }

    /// <summary>
    /// This addin will be always enabled.
    /// </summary>
    public class Availability : IExternalCommandAvailability
    {
        public bool IsCommandAvailable(UIApplication applicationData, Autodesk.Revit.DB.CategorySet selectedCategories)
        {
            return true;
        }
    }
}
