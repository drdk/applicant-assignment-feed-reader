// Type: System.ServiceModel.Syndication.SyndicationItem
// Assembly: System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.ServiceModel.dll

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Xml;

namespace System.ServiceModel.Syndication
{
    /// <summary>
    /// Represents a feed item, for example an RSS &lt;item&gt; or an Atom &lt;entry&gt;.
    /// </summary>
    [TypeForwardedFrom("System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public class SyndicationItem : IExtensibleSyndicationObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> class.
        /// </summary>
        public SyndicationItem();

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> class with the specified title, content, and link.
        /// </summary>
        /// <param name="title">The item title.</param><param name="content">The item content.</param><param name="itemAlternateLink">The item URL.</param>
        public SyndicationItem(string title, string content, Uri itemAlternateLink);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> class.
        /// </summary>
        /// <param name="title">The title of the syndication item.</param><param name="content">The content of the syndication item.</param><param name="itemAlternateLink">The alternate URI for the syndication item.</param><param name="id">The ID of the syndication item.</param><param name="lastUpdatedTime">The <see cref="T:System.DateTimeOffset"/> that contains the last time the syndication item was last updated.</param>
        public SyndicationItem(string title, string content, Uri itemAlternateLink, string id, DateTimeOffset lastUpdatedTime);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> class.
        /// </summary>
        /// <param name="title">The title of the syndication item.</param><param name="content">A <see cref="T:System.ServiceModel.Syndication.SyndicationContent"/> instance containing the content of the syndication item.</param><param name="itemAlternateLink">The alternate URI for the syndication item.</param><param name="id">The ID of the syndication item.</param><param name="lastUpdatedTime">The <see cref="T:System.DateTimeOffset"/> that contains the last time the syndication item was last updated.</param>
        public SyndicationItem(string title, SyndicationContent content, Uri itemAlternateLink, string id, DateTimeOffset lastUpdatedTime);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> class with the specified <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> instance.
        /// </summary>
        /// <param name="source">A <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> instance used to initialize the new <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> instance.</param>
        protected SyndicationItem(SyndicationItem source);

        /// <summary>
        /// Loads a <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> instance from the specified <see cref="T:System.Xml.XmlReader"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> instance.
        /// </returns>
        /// <param name="reader">The <see cref="T:System.Xml.XmlReader"/> to read from. </param><exception cref="T:System.Xml.XmlException">Invalid XML encountered during read.</exception>
        public static SyndicationItem Load(XmlReader reader);

        /// <summary>
        /// Loads a <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> derived object from the specified <see cref="T:System.Xml.XmlReader"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> derived object that contains the syndication item.
        /// </returns>
        /// <param name="reader">The <see cref="T:System.Xml.XmlReader"/> to read from.</param><typeparam name="TSyndicationItem">The <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/>-derived class to load.</typeparam>
        public static TSyndicationItem Load<TSyndicationItem>(XmlReader reader) where TSyndicationItem : new(), SyndicationItem;

        /// <summary>
        /// Adds a permalink to the <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/>.
        /// </summary>
        /// <param name="permalink">The <see cref="T:System.Uri"/> that points to the content.</param>
        public void AddPermalink(Uri permalink);

        /// <summary>
        /// Creates a copy of the <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> instance.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> instance.
        /// </returns>
        public virtual SyndicationItem Clone();

        /// <summary>
        /// Gets an <see cref="T:System.ServiceModel.Syndication.Atom10FeedFormatter"/> instance.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.ServiceModel.Syndication.Atom10FeedFormatter"/> instance.
        /// </returns>
        public Atom10ItemFormatter GetAtom10Formatter();

        /// <summary>
        /// Gets an <see cref="T:System.ServiceModel.Syndication.Rss20FeedFormatter"/> instance.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.ServiceModel.Syndication.Rss20FeedFormatter"/> instance.
        /// </returns>
        public Rss20ItemFormatter GetRss20Formatter();

        /// <summary>
        /// Gets an <see cref="T:System.ServiceModel.Syndication.Rss20FeedFormatter"/> instance.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.ServiceModel.Syndication.Rss20FeedFormatter"/> instance.
        /// </returns>
        /// <param name="serializeExtensionsAsAtom">A value that specifies whether to serialize element and attribute extensions with an Atom 1.0 namespace.</param>
        public Rss20ItemFormatter GetRss20Formatter(bool serializeExtensionsAsAtom);

        /// <summary>
        /// Write the syndication item to the specified <see cref="T:System.Xml.XmlWriter"/> in Atom 1.0 format.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Xml.XmlWriter"/> to write to.</param>
        public void SaveAsAtom10(XmlWriter writer);

        /// <summary>
        /// Write the syndication item to the specified <see cref="T:System.Xml.XmlWriter"/> in RSS 2.0 format.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Xml.XmlWriter"/> to write to.</param>
        public void SaveAsRss20(XmlWriter writer);

        /// <summary>
        /// Creates a new category.
        /// </summary>
        /// 
        /// <returns>
        /// A new <see cref="T:System.ServiceModel.Syndication.SyndicationCategory"/> object.
        /// </returns>
        protected internal virtual SyndicationCategory CreateCategory();

        /// <summary>
        /// Creates a new <see cref="T:System.ServiceModel.Syndication.SyndicationLink"/> instance.
        /// </summary>
        /// 
        /// <returns>
        /// A new <see cref="T:System.ServiceModel.Syndication.SyndicationLink"/> instance.
        /// </returns>
        protected internal virtual SyndicationLink CreateLink();

        /// <summary>
        /// Creates a new person.
        /// </summary>
        /// 
        /// <returns>
        /// A new <see cref="T:System.ServiceModel.Syndication.SyndicationPerson"/> object.
        /// </returns>
        protected internal virtual SyndicationPerson CreatePerson();

        /// <summary>
        /// Attempts to parse an attribute extension.
        /// </summary>
        /// 
        /// <returns>
        /// A value that specifies whether the attribute extension was parsed successfully.
        /// </returns>
        /// <param name="name">The name of the element.</param><param name="ns">The namespace of the element.</param><param name="value">The attribute to parse.</param><param name="version">The syndication version to use when parsing.</param><exception cref="T:System.Xml.XmlException">Invalid XML encountered during read.</exception>
        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version);

        /// <summary>
        /// Attempts to parse content.
        /// </summary>
        /// 
        /// <returns>
        /// A value that specifies whether the content was parsed successfully.
        /// </returns>
        /// <param name="reader">The <see cref="T:System.Xml.XmlReader"/> to read from.</param><param name="contentType">The content type of the content.</param><param name="version">The syndication version to use while parsing.</param><param name="content">The <see cref="T:System.ServiceModel.Syndication.SyndicationContent"/> instance to load the parsed content into.</param>
        protected internal virtual bool TryParseContent(XmlReader reader, string contentType, string version, out SyndicationContent content);

        /// <summary>
        /// Attempts to parse an element extension.
        /// </summary>
        /// 
        /// <returns>
        /// A value that specifies whether the element extension was parsed successfully.
        /// </returns>
        /// <param name="reader">The <see cref="T:System.Xml.XmlReader"/> to read from.</param><param name="version">The syndication version to use while parsing.</param><exception cref="T:System.Xml.XmlException">Invalid XML encountered during read.</exception>
        protected internal virtual bool TryParseElement(XmlReader reader, string version);

        /// <summary>
        /// Writes the attribute extensions to the specified <see cref="T:System.Xml.XmlWriter"/> using the specified syndication version.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Xml.XmlReader"/> to write to.</param><param name="version">The syndication version to use while writing.</param>
        protected internal virtual void WriteAttributeExtensions(XmlWriter writer, string version);

        /// <summary>
        /// Writes the element extensions to the specified <see cref="T:System.Xml.XmlWriter"/> using the specific syndication version.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Xml.XmlReader"/> to write to.</param><param name="version">The syndication version to use while writing.</param>
        protected internal virtual void WriteElementExtensions(XmlWriter writer, string version);

        /// <summary>
        /// Gets the attribute extensions for the syndication item.
        /// </summary>
        /// 
        /// <returns>
        /// A dictionary that contains a collection of attribute extensions.
        /// </returns>
        public Dictionary<XmlQualifiedName, string> AttributeExtensions { get; }

        /// <summary>
        /// Gets the authors of the syndication item.
        /// </summary>
        /// 
        /// <returns>
        /// A collection of <see cref="T:System.ServiceModel.Syndication.SyndicationPerson"/> objects that represent the authors of the syndication item.
        /// </returns>
        public Collection<SyndicationPerson> Authors { get; }

        /// <summary>
        /// Gets and sets the base Uniform Resource Identifier (URI) for the <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/> instance.
        /// </summary>
        /// 
        /// <returns>
        /// The base URI of the <see cref="T:System.ServiceModel.Syndication.SyndicationItem"/>.
        /// </returns>
        public Uri BaseUri { get; set; }

        /// <summary>
        /// Gets the syndication categories for the syndication item.
        /// </summary>
        /// 
        /// <returns>
        /// A collection of <see cref="T:System.ServiceModel.Syndication.SyndicationCategory"/> objects that represent the categories of the syndication item.
        /// </returns>
        public Collection<SyndicationCategory> Categories { get; }

        /// <summary>
        /// Gets and sets the content of the syndication item.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.ServiceModel.Syndication.SyndicationContent"/> instance that contains the content of the syndication item.
        /// </returns>
        public SyndicationContent Content { get; set; }

        /// <summary>
        /// Gets the contributors of the syndication item.
        /// </summary>
        /// 
        /// <returns>
        /// A collection of <see cref="T:System.ServiceModel.Syndication.SyndicationPerson"/> objects that represent the contributors of the syndication item.
        /// </returns>
        public Collection<SyndicationPerson> Contributors { get; }

        /// <summary>
        /// Gets and sets the copyright information for the syndication item.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.ServiceModel.Syndication.TextSyndicationContent"/> instance that represents copyright information.
        /// </returns>
        public TextSyndicationContent Copyright { get; set; }

        /// <summary>
        /// Gets the element extensions contained in the syndication item.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.ServiceModel.Syndication.SyndicationElementExtensionCollection"/> that contains the element extensions.
        /// </returns>
        public SyndicationElementExtensionCollection ElementExtensions { get; }

        /// <summary>
        /// Gets and sets the ID of the syndication item.
        /// </summary>
        /// 
        /// <returns>
        /// The ID of the syndication item.
        /// </returns>
        public string Id { get; set; }

        /// <summary>
        /// Gets and sets the last updated time for the syndication item.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.DateTimeOffset"/> instance that represents the time the syndication item was last updated.
        /// </returns>
        public DateTimeOffset LastUpdatedTime { get; set; }

        /// <summary>
        /// Gets the links contained in the syndication item.
        /// </summary>
        /// 
        /// <returns>
        /// A collection of <see cref="T:System.ServiceModel.Syndication.SyndicationLink"/> objects.
        /// </returns>
        public Collection<SyndicationLink> Links { get; }

        /// <summary>
        /// Gets and sets the publish date for the syndication item.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.DateTimeOffset"/> object that represents the publish date for the syndication item.
        /// </returns>
        public DateTimeOffset PublishDate { get; set; }

        /// <summary>
        /// Gets and sets the source feed of the syndication item.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.ServiceModel.Syndication.SyndicationFeed"/> instance where the syndication item is located.
        /// </returns>
        public SyndicationFeed SourceFeed { get; set; }

        /// <summary>
        /// Gets and sets the summary of the syndication item.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.ServiceModel.Syndication.TextSyndicationContent"/> that contains a summary of the item.
        /// </returns>
        public TextSyndicationContent Summary { get; set; }

        /// <summary>
        /// Gets and sets the title of the syndication item.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.ServiceModel.Syndication.TextSyndicationContent"/> object that contains the title of the syndication item.
        /// </returns>
        public TextSyndicationContent Title { get; set; }
    }
}
