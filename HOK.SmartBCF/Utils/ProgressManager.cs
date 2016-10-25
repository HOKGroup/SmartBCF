using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HOK.SmartBCF.Utils
{
    /// <summary>
    /// Progress Manager for progress bar
    /// </summary>
    public static class ProgressManager
    {
        public static ProgressBar progressBar = null;
        public static TextBlock statusLabel = null;
        public static double progressValue = 0;
        public static string databaseFilePath = "";

        private delegate void UpdateProgressBarDelegate(System.Windows.DependencyProperty dp, Object value);
        private delegate void UpdateStatusLabelDelegate(System.Windows.DependencyProperty dp, Object value);

        private static UpdateStatusLabelDelegate updateLabelDelegate = null;
        private static UpdateProgressBarDelegate updatePbDelegate = null;

        /// <summary>
        /// Reset the value
        /// </summary>
        /// <param name="statusText"></param>
        /// <param name="maximum"></param>
        public static void InitializeProgress(string statusText, int maximum)
        {
            if (null != progressBar && null != statusLabel)
            {
                progressBar.Visibility = System.Windows.Visibility.Visible;
                progressValue = 0;

                updateLabelDelegate = new UpdateStatusLabelDelegate(statusLabel.SetValue);
                System.Windows.Threading.Dispatcher.CurrentDispatcher.Invoke(updateLabelDelegate, System.Windows.Threading.DispatcherPriority.Background, new object[] { TextBlock.TextProperty, statusText});

                updatePbDelegate = new UpdateProgressBarDelegate(progressBar.SetValue);
                progressBar.Value = progressValue;
                progressBar.Maximum = maximum;
            }
        }

        /// <summary>
        /// Increase the value of the progress bar
        /// </summary>
        public static void StepForward()
        {
            if (null != progressBar && null != statusLabel)
            {
                progressValue++;
                System.Windows.Threading.Dispatcher.CurrentDispatcher.Invoke(updatePbDelegate, System.Windows.Threading.DispatcherPriority.Background, new object[] { ProgressBar.ValueProperty, progressValue });
            }
        }

        /// <summary>
        /// Hide progress bar when it is no loger needed
        /// </summary>
        public static void FinalizeProgress()
        {
            if (null != progressBar && null != statusLabel)
            {

                progressValue = 0;
                progressBar.Visibility = System.Windows.Visibility.Hidden;

                if (!string.IsNullOrEmpty(databaseFilePath))
                {
                    statusLabel.Text = databaseFilePath;
                }
                else
                {
                    statusLabel.Text = "Ready";
                }
            }
        }

    }
}
