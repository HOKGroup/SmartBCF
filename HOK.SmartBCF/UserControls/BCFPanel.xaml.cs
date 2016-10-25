﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HOK.SmartBCF.Schemas;
using HOK.SmartBCF.Utils;
using HOK.SmartBCF.Windows;
using System.IO;
using System.Diagnostics;

namespace HOK.SmartBCF.UserControls
{
    /// <summary>
    /// Interaction logic for BCFPanel.xaml
    /// </summary>
    public partial class BCFPanel : UserControl
    {
        //Selected Markup to bind
        private Markup selectedMarkup = null;

        public TopicType[] topicTypes = new TopicType[] { TopicType.Error, TopicType.Info, TopicType.Unknown, TopicType.Warning, 
            /*BIMCollab*/ TopicType.Issue, TopicType.Fault, TopicType.Clash, TopicType.Request, TopicType.Inquiry, TopicType.Remark, TopicType.Undefined };
        public TopicStatus[] topicStatus = new TopicStatus[] { TopicStatus.Active, TopicStatus.Assigned, TopicStatus.Closed, TopicStatus.Open, TopicStatus.Resolved };

        private bool loadedUI = false;
        private bool isCellEditable = true;

        public BCFPanel()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
            comboBoxTopicType.ItemsSource = null;
            comboBoxTopicType.ItemsSource = topicTypes;
            comboBoxTopicStatus.ItemsSource = null;
            comboBoxTopicStatus.ItemsSource = topicStatus;
            

            bool foucsed = buttonForward.Focus();
            loadedUI = true;
        }

        private void comboBoxIssue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (null != comboBoxIssue.SelectedItem)
                {
                    selectedMarkup = (Markup)comboBoxIssue.SelectedItem;
                    textBlockIndex.Text = "( " + (selectedMarkup.Topic.Index+1) + " of " + comboBoxIssue.Items.Count + " ) ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to select an issue.\n" + ex.Message, "Select an Issue", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void buttonForward_Click(object sender, RoutedEventArgs e)
        {
            MoveForward();
        }

        private void MoveForward_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MoveForward();
        }

        private void MoveForward()
        {
            try
            {
                if (comboBoxIssue.SelectedIndex > -1)
                {
                    int selectedIndex = comboBoxIssue.SelectedIndex;
                    selectedIndex++;
                    if (selectedIndex < comboBoxIssue.Items.Count)
                    {
                        comboBoxIssue.SelectedIndex = selectedIndex;
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        private void buttonBackward_Click(object sender, RoutedEventArgs e)
        {
            MoveBackward();
        }

        private void MoveBackward_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MoveBackward();
        }

        private void MoveBackward()
        {
            try
            {
                if (comboBoxIssue.SelectedIndex > -1)
                {
                    int selectedIndex = comboBoxIssue.SelectedIndex;
                    selectedIndex--;
                    if (selectedIndex > -1)
                    {
                        comboBoxIssue.SelectedIndex = selectedIndex;
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }
        /// <summary>
        /// Expand the snapshot image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonView_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (buttonView.Tag.ToString() == "Expand")
                {
                    commentGrid.Visibility = Visibility.Collapsed;
                    commentColumn.Width = GridLength.Auto;
                    buttonView.Tag = "Collapse";
                    expanderComponent.IsExpanded = false;
                    descriptionGrid.Visibility = Visibility.Collapsed;
                }
                else if (buttonView.Tag.ToString() == "Collapse")
                {
                    commentGrid.Visibility = Visibility.Visible;
                    commentColumn.Width = new GridLength(1, GridUnitType.Star);
                    buttonView.Tag = "Expand";
                    descriptionGrid.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to maximize or minimize the view.\n" + ex.Message, "Adjust View", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Add a new comment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddComment_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ObservableCollection<Comment> comments = (ObservableCollection<Comment>)dataGridComment.ItemsSource;

                Comment comment = new Comment();
                comment.Guid = Guid.NewGuid().ToString();
                comment.VerbalStatus = "Open";
                comment.Status = "Error";
                comment.Comment1 = "New Comment";
                comment.Author = Environment.UserName;
                comment.Date = DateTime.Now;
                comment.ModifiedAuthor = Environment.UserName;
                comment.ModifiedDate = DateTime.Now;
                comment.TopicGuid = selectedMarkup.Topic.Guid;
                comment.Viewpoint.Guid = (null != selectedMarkup.SelectedViewpoint) ? selectedMarkup.SelectedViewpoint.Guid : "";
                comments.Add(comment);

                selectedMarkup.Comment.Add(comment);

                bool updated = BCFDBWriter.BCFDBWriter.InsertComment(comment);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add comment.\n" + ex.Message, "Add Comment", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Delete a selected comment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteComment_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (null != dataGridComment.SelectedItem)
                {
                    Comment selectedComment =(Comment)dataGridComment.SelectedItem;
                    ObservableCollection<Comment> comments = (ObservableCollection<Comment>)dataGridComment.ItemsSource;
                    comments.Remove(selectedComment);

                    var comment = from com in selectedMarkup.Comment where com.Guid == selectedComment.Guid select com;
                    if (comment.Count() > 0)
                    {
                        bool deleted = BCFDBWriter.BCFDBWriter.DeleteComment(comment.First());
                        selectedMarkup.Comment.Remove(comment.First());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add comment.\n" + ex.Message, "Add Comment", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Update Modified Author when cell edit is ending
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridComment_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                if (!loadedUI) { return; }
                if (isCellEditable)
                {
                    isCellEditable = false;
                    bool edited = dataGridComment.CommitEdit(DataGridEditingUnit.Row, true);
                    if (edited)
                    {
                        DataGridRow row = e.Row;
                        Comment comment = row.Item as Comment;
                        comment.ModifiedAuthor = Environment.UserName;
                        comment.ModifiedDate = DateTime.Now;

                        ObservableCollection<Comment> comments = (ObservableCollection<Comment>)dataGridComment.ItemsSource;
                        int rowIndex = row.GetIndex();
                        comments[rowIndex].ModifiedAuthor = Environment.UserName;
                        comments[rowIndex].ModifiedDate = DateTime.Now;

                        bool updated = BCFDBWriter.BCFDBWriter.UpdateComment(comment);
                    }
                    isCellEditable = true;
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        /// <summary>
        /// Collapse the expander for components
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void expanderComponent_Collapsed(object sender, RoutedEventArgs e)
        {
            try
            {
                expanderComponent.Header = "Show Revit Elements";
                GridLength collapsedHeight = new GridLength(40, GridUnitType.Pixel);
                expanderRowDefinition.Height = collapsedHeight;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        /// <summary>
        /// Expand the expander for components
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void expanderComponent_Expanded(object sender, RoutedEventArgs e)
        {
            try
            {
                expanderComponent.Header = "Hide Revit Elements";
                GridLength expandedHeight = new GridLength(1, GridUnitType.Star);
                expanderRowDefinition.Height = expandedHeight;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        /// <summary>
        /// Update selected topic type in the database when selection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTopicType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (!loadedUI) { return; }
                 UIElement uiElement = e.OriginalSource as UIElement;
                 if (uiElement.IsMouseCaptured)
                 {
                     bool updated = BCFDBWriter.BCFDBWriter.UpdateTopic(selectedMarkup.Topic);
                 }
                
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        /// <summary>
        /// Update selected topic status in the database when selection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTopicStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (!loadedUI) { return; }
                UIElement uiElement = e.OriginalSource as UIElement;
                if (uiElement.IsMouseCaptured)
                {
                    bool updated = BCFDBWriter.BCFDBWriter.UpdateTopic(selectedMarkup.Topic);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        /// <summary>
        /// Update Assign To in the database when the text box lost its focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAssignedTo_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!loadedUI) { return; }
                selectedMarkup.Topic.AssignedTo = textBoxAssignedTo.Text;
                bool updated = BCFDBWriter.BCFDBWriter.UpdateTopicAssign(selectedMarkup.Topic);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        /// <summary>
        /// Update Action in the database  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAction_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (!loadedUI) { return; }
                UIElement uiElement = e.OriginalSource as UIElement;
                if (uiElement.IsMouseCaptured)
                {
                    DataGridRow row = WPFUtil.FindVisualParent<DataGridRow>(uiElement);
                    if (null != row)
                    {
                        Component component = row.Item as Component;
                        bool updated = BCFDBWriter.BCFDBWriter.UpdateComponent(component);
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        /// <summary>
        /// Update Responsibility in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxResponsibility_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (!loadedUI) { return; }

                UIElement uiElement = e.OriginalSource as UIElement;
                if (uiElement.IsMouseCaptured)
                {
                    DataGridRow row = WPFUtil.FindVisualParent<DataGridRow>(uiElement);
                    if (null != row)
                    {
                        Component component = row.Item as Component;
                        bool updated = BCFDBWriter.BCFDBWriter.UpdateComponent(component);
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        /// <summary>
        /// Move to the next viewpoint image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int vpIndex = selectedMarkup.Viewpoints.IndexOf(selectedMarkup.SelectedViewpoint);
                if (vpIndex < selectedMarkup.Viewpoints.Count - 1)
                {
                    vpIndex++;
                    selectedMarkup.SelectedViewpoint = selectedMarkup.Viewpoints[vpIndex];
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        /// <summary>
        /// Move to the previous viewpoint image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int vpIndex = selectedMarkup.Viewpoints.IndexOf(selectedMarkup.SelectedViewpoint);
                if (vpIndex > 0)
                {
                    selectedMarkup.SelectedViewpoint = selectedMarkup.Viewpoints[vpIndex - 1];
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        /// <summary>
        /// Delete the selected viewpoint image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteView_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool deleted = BCFDBWriter.BCFDBWriter.DeleteViewPoint(selectedMarkup.SelectedViewpoint.Guid);
                int vpIndex = selectedMarkup.Viewpoints.IndexOf(selectedMarkup.SelectedViewpoint);
                selectedMarkup.Viewpoints.RemoveAt(vpIndex);
                selectedMarkup.SelectedViewpoint = null;
                if (selectedMarkup.Viewpoints.Count > 0)
                {
                    selectedMarkup.SelectedViewpoint = selectedMarkup.Viewpoints[0];
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        /// <summary>
        /// Open a default image editor to add markups by users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditView_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                byte[] imageArray = selectedMarkup.SelectedViewpoint.SnapshotImage;
                string tempImg = ImageUtil.ConvertToImageFile(imageArray);
                if (!string.IsNullOrEmpty(tempImg))
                {
                    Process paint = new Process();
                    ProcessStartInfo paintInfo = new ProcessStartInfo(tempImg);
                    paintInfo.Verb = "edit";
                    paint.StartInfo = paintInfo;
                    paint.Start();
                    paint.WaitForExit();

                    //addViewPoint
                    EditViewPoint(tempImg);
                    File.Delete(tempImg);
                }

            }
            catch (Exception ex)
            {
                string messag = ex.Message;
            }
        }

        /// <summary>
        /// Update Viewpoint image in the database
        /// </summary>
        /// <param name="tempImg"></param>
        private void EditViewPoint(string tempImg)
        {
            try
            {
                byte[] imgArray = ImageUtil.GetImageArray(tempImg);

                int vpIndex = selectedMarkup.Viewpoints.IndexOf(selectedMarkup.SelectedViewpoint);
                selectedMarkup.Viewpoints[vpIndex].SnapshotImage = imgArray;
                selectedMarkup.SelectedViewpoint = selectedMarkup.Viewpoints[vpIndex];

                bool dbUpdated = BCFDBWriter.BCFDBWriter.UpdateViewPointImage(selectedMarkup.SelectedViewpoint);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        
    }
}
