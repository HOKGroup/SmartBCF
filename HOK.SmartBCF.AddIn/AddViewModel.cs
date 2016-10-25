﻿using Autodesk.Revit.UI;
using HOK.SmartBCF.Schemas;
using HOK.SmartBCF.UserControls;
using HOK.SmartBCF.Utils;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HOK.SmartBCF.AddIn
{
    public class AddViewModel : INotifyPropertyChanged
    {
        private BCFViewModel bcfView;
        private bool isAddInMode = true;

        private BCFHandler m_handler;
        private ExternalEvent m_event;

        private BCFZIP selectedBCF = null;
        private Markup selectedMarkup = null;
        private ViewPoint userViewPoint = null;
        private ComponentOption selectedOption = ComponentOption.SelectedElements;

        private RelayCommand browseCommand;
        private RelayCommand addCommand;
        private RelayCommand snapshotCommand;

        public BCFViewModel BCFView { get { return bcfView; } set { bcfView = value; NotifyPropertyChanged("BCFView"); } }
        public BCFZIP SelectedBCF { get { return selectedBCF; } set { selectedBCF = value; NotifyPropertyChanged("SelectedBCF"); } }
        public Markup SelectedMarkup { get { return selectedMarkup; } set { selectedMarkup = value; NotifyPropertyChanged("SelectedMarkup"); } }
        public ViewPoint UserViewPoint { get { return userViewPoint; } set { userViewPoint = value; NotifyPropertyChanged("UserViewPoint"); } }
        public ComponentOption SelectedOption { get { return selectedOption; } set { selectedOption = value; NotifyPropertyChanged("SelectedOption"); } }
        public bool IsAddInMode { get { return isAddInMode; } set { isAddInMode = value; } }
        
        public ICommand BrowseCommand { get { return browseCommand; } }
        public ICommand AddCommand { get { return addCommand; } }
        public ICommand SnapshotCommand { get { return snapshotCommand; } }

        public AddViewModel(BCFViewModel bcfViewModel, ExternalEvent exEvent, BCFHandler handler)
        {
            bcfView = bcfViewModel;
            m_handler = handler;
            m_event = exEvent;

            browseCommand = new RelayCommand(param => this.BrowseExecuted(param));
            addCommand = new RelayCommand(param => this.AddExecuted(param));
            snapshotCommand = new RelayCommand(param => this.SnapshotExecuted(param));
            SetSelectedMarkup();
        }

        private void SetSelectedMarkup()
        {
            try
            {
                this.SelectedBCF = bcfView.BCFFiles[bcfView.SelectedIndex];
                this.SelectedMarkup = selectedBCF.Markups[selectedBCF.SelectedMarkup];
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        public void BrowseExecuted(object param)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Title = "Open a Snapshot";
                openDialog.DefaultExt = ".png";
                openDialog.Filter = "PNG (.png)|*.png";
                if ((bool)openDialog.ShowDialog())
                {
                    string fileName = openDialog.FileName;
                    this.UserViewPoint = DefineViewPoint(fileName);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        private ViewPoint DefineViewPoint(string imgFile)
        {
            ViewPoint viewPoint = new ViewPoint();
            try
            {
                viewPoint.Guid = Guid.NewGuid().ToString();
                viewPoint.TopicGuid = selectedMarkup.Topic.Guid;
                viewPoint.Snapshot = Path.GetFileName(imgFile);
                viewPoint.SnapshotImage = ImageUtil.GetImageArray(imgFile);

                VisualizationInfo visInfo = new VisualizationInfo();
                visInfo.ViewPointGuid = viewPoint.Guid;

                viewPoint.VisInfo = visInfo;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return viewPoint;
        }

        public void SnapshotExecuted(object param)
        {
            try
            { 
                m_handler.ViewPointViewModel = this;
                m_handler.Request.Make(RequestId.ExportImage);
                m_event.Raise();

            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        public void AddExecuted(object param)
        {
            try
            {
                if (!string.IsNullOrEmpty(userViewPoint.Snapshot) && null != userViewPoint.SnapshotImage)
                {
                    AddViewPoint(userViewPoint);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        private void AddViewPoint(ViewPoint vp)
        {
            try
            {
                bcfView.BCFFiles[bcfView.SelectedIndex].Markups[selectedBCF.SelectedMarkup].Viewpoints.Add(vp);
                SetSelectedMarkup();
                this.SelectedMarkup.SelectedViewpoint = vp;

                string fileId = bcfView.BCFFiles[bcfView.SelectedIndex].FileId;
                bool added = BCFDBWriter.BCFDBWriter.InsertViewPoint(fileId, vp);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
