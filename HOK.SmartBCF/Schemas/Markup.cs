﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOK.SmartBCF.Schemas
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class Markup : INotifyPropertyChanged 
    {
        private List<HeaderFile> headerField;
        private Topic topicField;
        private byte[] topicImage = null;
        private ObservableCollection<Comment> commentField;
        private ObservableCollection<ViewPoint> viewpointsField;
        private ViewPoint selectedViewpoint = new ViewPoint();

        public Markup()
        {
            this.viewpointsField = new ObservableCollection<ViewPoint>();
            this.commentField = new ObservableCollection<Comment>();
            this.topicField = new Topic();
            this.headerField = new List<HeaderFile>();
        }

        public Markup(Markup markup)
        {
            this.Viewpoints = markup.Viewpoints;
            this.Comment = markup.Comment;
            this.Topic = markup.Topic;
            this.Header = markup.Header;
        }

        public Markup Clone()
        {
            return ((Markup)(this.MemberwiseClone()));
        }

        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("File", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<HeaderFile> Header 
        {
            get { return this.headerField; }
            set { this.headerField = value; NotifyPropertyChanged("Header"); }
        }
       
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Topic Topic
        {
            get{return this.topicField;}
            set{this.topicField = value; NotifyPropertyChanged("Topic");}
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public byte[] TopicImage
        {
            get { return this.topicImage; }
            set { this.topicImage = value; NotifyPropertyChanged("TopicImage"); }
        }

        [System.Xml.Serialization.XmlElementAttribute("Comment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ObservableCollection<Comment> Comment
        {
            get { return this.commentField; }
            set { this.commentField = value; NotifyPropertyChanged("Comment"); }
        }

        [System.Xml.Serialization.XmlElementAttribute("Viewpoints", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ObservableCollection<ViewPoint> Viewpoints
        {
            get { return this.viewpointsField; }
            set { this.viewpointsField = value; NotifyPropertyChanged("Viewpoints"); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ViewPoint SelectedViewpoint
        {
            get { return selectedViewpoint; }
            set { selectedViewpoint = value; NotifyPropertyChanged("SelectedViewpoint"); }
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class HeaderFile
    {
        private string guidField = "";
        private string filenameField = "";
        private System.DateTime dateField;
        private bool dateFieldSpecified;
        private string referenceField = "";
        private string ifcProjectField = "";
        private string ifcSpatialStructureElementField = "";
        private bool isExternalField;
        private string topicGuidField = "";

        public HeaderFile()
        {
            this.guidField = System.Guid.NewGuid().ToString();
            this.isExternalField = true;
        }

        public HeaderFile(HeaderFile headerFile)
        {
            this.Guid = headerFile.Guid;
            this.Filename = headerFile.Filename;
            this.Date = headerFile.Date;
            this.Reference = headerFile.Reference;
            this.IfcProject = headerFile.IfcProject;
            this.IfcSpatialStructureElement = headerFile.IfcSpatialStructureElement;
            this.isExternal = headerFile.isExternal;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public string Guid
        {
            get { return this.guidField; }
            set { this.guidField = value; }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Filename
        {
            get { return this.filenameField; }
            set { this.filenameField = value; }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime Date
        {
            get { return this.dateField; }
            set { this.dateField = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateSpecified
        {
            get { return this.dateFieldSpecified; }
            set { this.dateFieldSpecified = value; }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Reference
        {
            get { return this.referenceField; }
            set { this.referenceField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IfcProject
        {
            get { return this.ifcProjectField; }
            set { this.ifcProjectField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IfcSpatialStructureElement
        {
            get { return this.ifcSpatialStructureElementField; }
            set { this.ifcSpatialStructureElementField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool isExternal
        {
            get { return this.isExternalField; }
            set { this.isExternalField = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public string TopicGuid
        {
            get { return this.topicGuidField; }
            set { this.topicGuidField = value; }
        }

        #region Clone method
        /// <summary>
        /// Create a clone of this HeaderFile object
        /// </summary>
        public virtual HeaderFile Clone()
        {
            return ((HeaderFile)(this.MemberwiseClone()));
        }
        #endregion
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class ViewPoint : INotifyPropertyChanged
    {
        private string viewpointField = "";
        private string snapshotField = "";
        private string guidField = "";
        private byte[] snapshotImageField;
        private VisualizationInfo visInfoField = null;
        private string topicGuidField = "";

        public ViewPoint()
        {
        }

        public ViewPoint(ViewPoint viewPoint)
        {
            this.Viewpoint = viewPoint.Viewpoint;
            this.Snapshot = viewPoint.Snapshot;
            this.Guid = viewPoint.Guid;
            this.SnapshotImage = viewPoint.SnapshotImage;
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Viewpoint
        {
            get { return this.viewpointField; }
            set { this.viewpointField = value; }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Snapshot
        {
            get { return this.snapshotField; }
            set { this.snapshotField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Guid
        {
            get { return this.guidField; }
            set { this.guidField = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public byte[] SnapshotImage
        {
            get { return this.snapshotImageField; }
            set { this.snapshotImageField = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public VisualizationInfo VisInfo { get { return visInfoField; } set { visInfoField = value; } }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public string TopicGuid
        {
            get { return topicGuidField; }
            set { topicGuidField = value; }
        }

        #region Clone method
        /// <summary>
        /// Create a clone of this ViewPoint object
        /// </summary>
        public virtual ViewPoint Clone()
        {
            return ((ViewPoint)(this.MemberwiseClone()));
        }
        #endregion

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Comment : INotifyPropertyChanged
    {
        private string verbalStatusField = "";
        private string statusField = "";
        private System.DateTime dateField;
        private string authorField = "";
        private string comment1Field = "";
        private CommentViewpoint viewpointField = new CommentViewpoint();
        private System.DateTime modifiedDateField;
        private bool modifiedDateFieldSpecified;
        private string modifiedAuthorField = "";
        private string guidField = "";
        private string topicGuidField = "";
        
        public Comment()
        {
            this.viewpointField = new CommentViewpoint();
            this.statusField = "Unknown";
            this.verbalStatusField = "Open";
        }

        public Comment(Comment comment)
        {
            this.VerbalStatus = comment.VerbalStatus;
            this.Status = comment.Status;
            this.Date = comment.Date;
            this.Author = comment.Author;
            this.Comment1 = comment.Comment1;
            this.Viewpoint = comment.Viewpoint;
            this.ModifiedDate = comment.ModifiedDate;
            this.ModifiedDateSpecified = comment.ModifiedDateSpecified;
            this.ModifiedAuthor = comment.ModifiedAuthor;
            this.Guid = comment.Guid;
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VerbalStatus
        {
            get
            {
                return this.verbalStatusField;
            }
            set
            {
                this.verbalStatusField = value;
                NotifyPropertyChanged("VerbalStatus");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                NotifyPropertyChanged("Status");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
                if (!modifiedDateFieldSpecified) { this.modifiedDateField = value; }
                NotifyPropertyChanged("Date");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
                NotifyPropertyChanged("Author");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Comment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Comment1
        {
            get
            {
                return this.comment1Field;
            }
            set
            {
                this.comment1Field = value;
                NotifyPropertyChanged("Comment1");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CommentViewpoint Viewpoint
        {
            get
            {
                return this.viewpointField;
            }
            set
            {
                this.viewpointField = value;
                NotifyPropertyChanged("Viewpoint");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime ModifiedDate
        {
            get
            {
                return this.modifiedDateField;
            }
            set
            {
                this.modifiedDateField = value;
                NotifyPropertyChanged("ModifiedDate");
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifiedDateSpecified
        {
            get
            {
                return this.modifiedDateFieldSpecified;
            }
            set
            {
                this.modifiedDateFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ModifiedAuthor
        {
            get
            {
                return this.modifiedAuthorField;
            }
            set
            {
                this.modifiedAuthorField = value;
                NotifyPropertyChanged("ModifiedAuthor");
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public string TopicGuid
        {
            get
            {
                return this.topicGuidField;
            }
            set
            {
                this.topicGuidField = value;
            }
        }

        #region Clone method
        /// <summary>
        /// Create a clone of this Comment object
        /// </summary>
        public virtual Comment Clone()
        {
            return ((Comment)(this.MemberwiseClone()));
        }
        #endregion

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class CommentViewpoint
    {

        private string guidField = "";

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }

        public CommentViewpoint()
        {
        }

        public CommentViewpoint(CommentViewpoint commentViewpoint)
        {
            this.Guid = commentViewpoint.Guid;
        }

        #region Clone method
        /// <summary>
        /// Create a clone of this CommentViewpoint object
        /// </summary>
        public virtual CommentViewpoint Clone()
        {
            return ((CommentViewpoint)(this.MemberwiseClone()));
        }
        #endregion
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class BimSnippet
    {

        private string guidField = "";

        private string referenceField = "";

        private string referenceSchemaField = "";

        private string snippetTypeField = "";

        private bool isExternalField;

        private byte[] fileContentField;

        private string topicGuidField = "";

        public BimSnippet()
        {
            this.guidField = System.Guid.NewGuid().ToString();
            this.isExternalField = false;
        }

        public BimSnippet(BimSnippet bimSnippet)
        {
            this.Guid = bimSnippet.Guid;
            this.Reference = bimSnippet.Reference;
            this.ReferenceSchema = bimSnippet.ReferenceSchema;
            this.SnippetType = bimSnippet.SnippetType;
            this.isExternal = bimSnippet.isExternal;
            this.FileContent = bimSnippet.FileContent;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public string Guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReferenceSchema
        {
            get
            {
                return this.referenceSchemaField;
            }
            set
            {
                this.referenceSchemaField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SnippetType
        {
            get
            {
                return this.snippetTypeField;
            }
            set
            {
                this.snippetTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool isExternal
        {
            get
            {
                return this.isExternalField;
            }
            set
            {
                this.isExternalField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public byte[] FileContent
        {
            get
            {
                return this.fileContentField;
            }
            set
            {
                this.fileContentField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public string TopicGuid
        {
            get
            {
                return this.topicGuidField;
            }
            set
            {
                this.topicGuidField = value;
            }
        }

        #region Clone method
        /// <summary>
        /// Create a clone of this BimSnippet object
        /// </summary>
        public virtual BimSnippet Clone()
        {
            return ((BimSnippet)(this.MemberwiseClone()));
        }
        #endregion
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Topic :INotifyPropertyChanged
    {
        private string referenceLinkField = "";
        private string titleField = "";
        private string priorityField = "";
        private int indexField = 0;
        private List<string> labelsField;
        private System.DateTime creationDateField;
        private string creationAuthorField = "";
        private System.DateTime modifiedDateField;
        private bool modifiedDateFieldSpecified;
        private string modifiedAuthorField = "";
        private string assignedToField = "";
        private string descriptionField = "";
        private BimSnippet bimSnippetField;
        private List<TopicDocumentReferences> documentReferencesField;
        private List<TopicRelatedTopics> relatedTopicsField;
        private string guidField = "";
        private TopicType topicTypeField = TopicType.Unknown;
        private TopicStatus topicStatusField = TopicStatus.Open;
        private string fileId = "";

        public Topic()
        {
            this.relatedTopicsField = new List<TopicRelatedTopics>();
            this.documentReferencesField = new List<TopicDocumentReferences>();
            this.bimSnippetField = new BimSnippet();
            this.labelsField = new List<string>();
        }

        public Topic(Topic topic)
        {
            this.ReferenceLink = topic.ReferenceLink;
            this.Title = topic.Title;
            this.Priority = topic.Priority;
            this.Index = topic.Index;
            this.Labels = topic.Labels;
            this.CreationDate = topic.CreationDate;
            this.CreationAuthor = topic.CreationAuthor;
            this.ModifiedDate = topic.ModifiedDate;
            this.ModifiedDateSpecified = topic.ModifiedDateSpecified;
            this.ModifiedAuthor = topic.ModifiedAuthor;
            this.AssignedTo = topic.AssignedTo;
            this.Description = topic.Description;
            this.BimSnippet = topic.BimSnippet;
            this.DocumentReferences = topic.DocumentReferences;
            this.RelatedTopics = topic.RelatedTopics;
            this.Guid = topic.Guid;
            this.TopicType = topic.TopicType;
            this.TopicStatus = topic.TopicStatus;
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReferenceLink
        {
            get { return this.referenceLinkField; }
            set { this.referenceLinkField = value; NotifyPropertyChanged("ReferenceLink"); }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Title
        {
            get { return this.titleField; }
            set { this.titleField = value; NotifyPropertyChanged("Title"); }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Priority
        {
            get { return this.priorityField; }
            set { this.priorityField = value; NotifyPropertyChanged("Priority"); }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Index
        {
            get { return this.indexField; }
            set { this.indexField = value; NotifyPropertyChanged("Index"); }
        }

        [System.Xml.Serialization.XmlElementAttribute("Labels", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<string> Labels
        {
            get { return this.labelsField; }
            set { this.labelsField = value; NotifyPropertyChanged("Labels"); }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime CreationDate
        {
            get { return this.creationDateField; }
            set { this.creationDateField = value; NotifyPropertyChanged("CreationDate"); }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CreationAuthor
        {
            get { return this.creationAuthorField; }
            set { this.creationAuthorField = value; NotifyPropertyChanged("CreationAuthor"); }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime ModifiedDate
        {
            get { return this.modifiedDateField; }
            set { this.modifiedDateField = value; NotifyPropertyChanged("ModifiedDate"); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifiedDateSpecified
        {
            get { return this.modifiedDateFieldSpecified; }
            set { this.modifiedDateFieldSpecified = value; NotifyPropertyChanged("ModifiedDateSpecified"); }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ModifiedAuthor
        {
            get { return this.modifiedAuthorField; }
            set { this.modifiedAuthorField = value; NotifyPropertyChanged("ModifiedAuthor"); }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AssignedTo
        {
            get { return this.assignedToField; }
            set { this.assignedToField = value; NotifyPropertyChanged("AssignedTo"); }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; NotifyPropertyChanged("Description"); }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BimSnippet BimSnippet
        {
            get { return this.bimSnippetField; }
            set { this.bimSnippetField = value; NotifyPropertyChanged("BimSnippet"); }
        }

        [System.Xml.Serialization.XmlElementAttribute("DocumentReferences", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<TopicDocumentReferences> DocumentReferences
        {
            get { return this.documentReferencesField; }
            set { this.documentReferencesField = value; NotifyPropertyChanged("DocumentReferences"); }
        }

        [System.Xml.Serialization.XmlElementAttribute("RelatedTopics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<TopicRelatedTopics> RelatedTopics
        {
            get { return this.relatedTopicsField; }
            set { this.relatedTopicsField = value; NotifyPropertyChanged("RelatedTopics"); }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Guid
        {
            get { return this.guidField; }
            set { this.guidField = value; NotifyPropertyChanged("Guid"); }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TopicType TopicType
        {
            get { return topicTypeField; }
            set { this.topicTypeField = value; NotifyPropertyChanged("TopicType"); }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TopicStatus TopicStatus
        {
            get { return this.topicStatusField; }
            set { this.topicStatusField = value; NotifyPropertyChanged("TopicStatus"); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public string FileId
        {
            get { return fileId; }
            set { fileId = value; }
        }

        #region Clone method
        /// <summary>
        /// Create a clone of this Topic object
        /// </summary>
        public virtual Topic Clone()
        {
            return ((Topic)(this.MemberwiseClone()));
        }
        #endregion

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TopicDocumentReferences
    {
        private string referencedDocumentField = "";
        private string descriptionField = "";
        private string guidField = "";
        private bool isExternalField;
        private byte[] fileContentField;
        private string topicGuidField = "";

        public TopicDocumentReferences()
        {
            this.isExternalField = false;
        }

        public TopicDocumentReferences(TopicDocumentReferences topicReference)
        {
            this.ReferencedDocument = topicReference.ReferencedDocument;
            this.Description = topicReference.Description;
            this.Guid = topicReference.Guid;
            this.isExternal = topicReference.isExternal;
            this.FileContent = topicReference.FileContent;
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReferencedDocument
        {
            get { return this.referencedDocumentField; }
            set { this.referencedDocumentField = value; }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Guid
        {
            get { return this.guidField; }
            set { this.guidField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool isExternal
        {
            get { return this.isExternalField; }
            set { this.isExternalField = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public byte[] FileContent
        {
            get { return this.fileContentField; }
            set { this.fileContentField = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public string TopicGuid { get { return topicGuidField; } set { topicGuidField = value; } }

        #region Clone method
        /// <summary>
        /// Create a clone of this TopicDocumentReferences object
        /// </summary>
        public virtual TopicDocumentReferences Clone()
        {
            return ((TopicDocumentReferences)(this.MemberwiseClone()));
        }
        #endregion
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TopicRelatedTopics
    {
        private string guidField = "";
        private string topicGuidField = "";

        public TopicRelatedTopics()
        {
        }

        public TopicRelatedTopics(TopicRelatedTopics relatedTopics)
        {
            this.Guid = relatedTopics.Guid;
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Guid
        {
            get { return this.guidField; }
            set { this.guidField = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public string TopicGuid { get { return topicGuidField; } set { topicGuidField = value; } }

        #region Clone method
        /// <summary>
        /// Create a clone of this TopicRelatedTopics object
        /// </summary>
        public virtual TopicRelatedTopics Clone()
        {
            return ((TopicRelatedTopics)(this.MemberwiseClone()));
        }
        #endregion
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Header
    {
        private List<HeaderFile> fileField;

        public Header()
        {
            this.fileField = new List<HeaderFile>();
        }

        public Header(Header header)
        {
            this.File = header.File;
        }

        [System.Xml.Serialization.XmlElementAttribute("File", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<HeaderFile> File
        {
            get { return this.fileField; }
            set { this.fileField = value; }
        }

        #region Clone method
        /// <summary>
        /// Create a clone of this Header object
        /// </summary>
        public virtual Header Clone()
        {
            return ((Header)(this.MemberwiseClone()));
        }
        #endregion
    }
}
