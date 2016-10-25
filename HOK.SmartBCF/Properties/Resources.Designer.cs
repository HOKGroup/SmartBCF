﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HOK.SmartBCF.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HOK.SmartBCF.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS `BCFFileInfo` (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`FileName`	TEXT,
        ///	`FilePath`	TEXT,
        ///	`UploadedBy`	TEXT,
        ///	`UploadedDate`	DATETIME,
        ///	`CreationDate`	DATETIME,
        ///	`IsPrimary` 	BOOLEAN,
        ///	PRIMARY KEY(Guid)
        ///);.
        /// </summary>
        internal static string BCFFileInfo {
            get {
                return ResourceManager.GetString("BCFFileInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS `BimSnippet` (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`SnippetType`	TEXT,
        ///	`isExternal`	BOOLEAN,
        ///	`Reference`	TEXT,
        ///	`ReferenceSchema`	TEXT,
        ///	`FileContent`	BLOB,
        ///	`Topic_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`Topic_Guid`) REFERENCES Topic ( Guid )
        ///).
        /// </summary>
        internal static string BimSnippet {
            get {
                return ResourceManager.GetString("BimSnippet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS &quot;Bitmaps&quot; (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`Bitmap`	TEXT,
        ///	`Bitmap_Image`	BLOB,
        ///	`Reference`	TEXT,
        ///	`Location`	TEXT,
        ///	`Normal`	TEXT,
        ///	`Up`	TEXT,
        ///	`Height`	REAL,
        ///	`Viewpoints_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`Viewpoints_Guid`) REFERENCES Viewpoints ( Guid )
        ///).
        /// </summary>
        internal static string Bitmaps {
            get {
                return ResourceManager.GetString("Bitmaps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS &quot;ClippingPlane&quot; (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`Location`	TEXT,
        ///	`Direction`	TEXT,
        ///	`Viewpoints_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`Viewpoints_Guid`) REFERENCES Viewpoints ( Guid )
        ///).
        /// </summary>
        internal static string ClippingPlane {
            get {
                return ResourceManager.GetString("ClippingPlane", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS &quot;Comment&quot; (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`VerbalStatus`	TEXT,
        ///	`Status`	TEXT,
        ///	`Date`	NUMERIC,
        ///	`Author`	TEXT,
        ///	`Comment`	TEXT,
        ///	`ModifiedDate`	NUMERIC,
        ///	`ModifiedAuthor`	TEXT,
        ///	`Topic_Guid`	TEXT,
        ///	`Viewpoint_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`Topic_Guid`) REFERENCES Topic ( Guid ),
        ///	FOREIGN KEY(`Viewpoint_Guid`) REFERENCES Viewpoints (Guid)
        ///).
        /// </summary>
        internal static string Comment {
            get {
                return ResourceManager.GetString("Comment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS `Components` (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`IfcGuid`	TEXT,
        ///	`Selected`	BOOLEAN,
        ///	`Visible`	BOOLEAN,
        ///	`Color`	BLOB,
        ///	`OriginatingSystem`	TEXT,
        ///	`AuthoringToolId`	TEXT,
        ///	`Viewpoints_Guid`	TEXT,
        ///	`ElementName`	TEXT,
        ///	`Action`	TEXT,
        ///	`Responsibility`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`Viewpoints_Guid`) REFERENCES Viewpoints ( Guid )
        ///);.
        /// </summary>
        internal static string Components {
            get {
                return ResourceManager.GetString("Components", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS &quot;Direction&quot; (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`X`	REAL,
        ///	`Y`	REAL,
        ///	`Z`	REAL,
        ///	`Viewpoints_Guid`	TEXT,
        ///	`File_Guid`	INTEGER,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`File_Guid`) REFERENCES BCFFileInfo ( Guid )
        ///).
        /// </summary>
        internal static string Direction {
            get {
                return ResourceManager.GetString("Direction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS `DocumentReferences` (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`isExternal`	BOOLEAN,
        ///	`ReferenceDocument`	TEXT,
        ///	`FileContent`	BLOB,
        ///	`Description`	TEXT,
        ///	`Topic_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`Topic_Guid`) REFERENCES Topic ( Guid )
        ///).
        /// </summary>
        internal static string DocumentReferences {
            get {
                return ResourceManager.GetString("DocumentReferences", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS `HeaderFile` (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`IfcProject`	TEXT,
        ///	`IfcSpatialStructureElement`	TEXT,
        ///	`isExternal`	BOOLEAN,
        ///	`FileName`	TEXT,
        ///	`Date`	DATETIME,
        ///	`Reference`	TEXT,
        ///	`Topic_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`Topic_Guid`) REFERENCES Topic ( Guid )
        ///).
        /// </summary>
        internal static string HeaderFile {
            get {
                return ResourceManager.GetString("HeaderFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS `Labels` (
        ///	`Label`	TEXT,
        ///	`Topic_Guid`	TEXT,
        ///	FOREIGN KEY(`Topic_Guid`) REFERENCES Topic ( Guid )
        ///).
        /// </summary>
        internal static string Labels {
            get {
                return ResourceManager.GetString("Labels", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE  IF NOT EXISTS &quot;Lines&quot; (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`StartPoint`	TEXT,
        ///	`EndPoint`	TEXT,
        ///	`Viewpoints_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`Viewpoints_Guid`) REFERENCES Viewpoints ( Guid )
        ///).
        /// </summary>
        internal static string Lines {
            get {
                return ResourceManager.GetString("Lines", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS &quot;OrthogonalCamera&quot; (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`CameraViewPoint`	TEXT,
        ///	`CameraDirection`	TEXT,
        ///	`CameraUpVector`	TEXT,
        ///	`ViewToWorldScale`	REAL,
        ///	`Viewpoints_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`Viewpoints_Guid`) REFERENCES Viewpoints ( Guid )
        ///).
        /// </summary>
        internal static string OrthogonalCamera {
            get {
                return ResourceManager.GetString("OrthogonalCamera", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS &quot;PerspectiveCamera&quot; (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`CameraViewPoint`	TEXT,
        ///	`CameraDirection`	TEXT,
        ///	`CameraUpVector`	TEXT,
        ///	`FieldOfView`	REAL,
        ///	`Viewpoints_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`Viewpoints_Guid`) REFERENCES Viewpoints ( Guid )
        ///).
        /// </summary>
        internal static string PerspectiveCamera {
            get {
                return ResourceManager.GetString("PerspectiveCamera", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS &quot;Point&quot; (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`X`	REAL,
        ///	`Y`	REAL,
        ///	`Z`	REAL,
        ///	`Viewpoints_Guid`	TEXT,
        ///	`File_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`File_Guid`) REFERENCES BCFFileInfo ( Guid )
        ///).
        /// </summary>
        internal static string Point {
            get {
                return ResourceManager.GetString("Point", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS `Project` (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`ProjectId`	TEXT,
        ///	`ProjectName`	TEXT,
        ///	`ProjectExtension_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`ProjectExtension_Guid`) REFERENCES ProjectExtension ( Guid )
        ///).
        /// </summary>
        internal static string Project {
            get {
                return ResourceManager.GetString("Project", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS &quot;ProjectExtension&quot; (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`ExtensionSchema`	TEXT,
        ///	`File_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`File_Guid`) REFERENCES BCFFileInfo ( Guid )
        ///).
        /// </summary>
        internal static string ProjectExtension {
            get {
                return ResourceManager.GetString("ProjectExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS `RelatedTopics` (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`Topic_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`Topic_Guid`) REFERENCES Topic ( Guid )
        ///).
        /// </summary>
        internal static string RelatedTopics {
            get {
                return ResourceManager.GetString("RelatedTopics", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS `RevitExtensions` (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`ParameterName`	TEXT,
        ///	`ParameterValue`	TEXT,
        ///	`Color`	BLOB,
        ///	PRIMARY KEY(Guid)
        ///);.
        /// </summary>
        internal static string RevitExtensions {
            get {
                return ResourceManager.GetString("RevitExtensions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS &quot;Topic&quot; (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`TopicType`	TEXT,
        ///	`TopicStatus`	TEXT,
        ///	`Title`	TEXT,
        ///	`ReferenceLink`	TEXT,
        ///	`Description`	TEXT,
        ///	`Priority`	TEXT,
        ///	`TopicIndex`	INTEGER,
        ///	`CreationDate`	DATETIME,
        ///	`CreationAuthor`	TEXT,
        ///	`ModifiedDate`	DATETIME,
        ///	`ModifiedAuthor`	TEXT,
        ///	`AssignedTo`	TEXT,
        ///	`File_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`File_Guid`) REFERENCES BCFFileInfo ( Guid )
        ///).
        /// </summary>
        internal static string Topic {
            get {
                return ResourceManager.GetString("Topic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS &quot;Version&quot; (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`VersionId`	TEXT,
        ///	`DetailedVersion`	TEXT,
        ///	`File_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`File_Guid`) REFERENCES BCFFileInfo ( Guid )
        ///).
        /// </summary>
        internal static string Version {
            get {
                return ResourceManager.GetString("Version", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS &quot;Viewpoints&quot; (
        ///	`Guid`	TEXT NOT NULL UNIQUE,
        ///	`Viewpoint`	TEXT,
        ///	`Snapshot`	TEXT,
        ///	`Snapshot_Image`	BLOB,
        ///	`Topic_Guid`	TEXT,
        ///	PRIMARY KEY(Guid),
        ///	FOREIGN KEY(`Topic_Guid`) REFERENCES Topic ( Guid )
        ///).
        /// </summary>
        internal static string Viewpoints {
            get {
                return ResourceManager.GetString("Viewpoints", resourceCulture);
            }
        }
    }
}
