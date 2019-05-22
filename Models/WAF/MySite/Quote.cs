// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************


using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WAF.Common;
using WAF.Definition;
using WAF.Engine;
using WAF.Engine.Content;
using WAF.Engine.Content.Native;
using WAF.Engine.Query;
using WAF.Engine.Query.Advanced;
using WAF.Engine.Property;
using WAF.Data;
using WAF.Data.Query;
using WAF.Data.Query.MySite;
using WAF.Data.Content;
using WAF.Data.DataValue;
using WAF.Presentation.Web;

namespace WAF.Engine.Content.MySite {
    [Serializable]
    public partial class Quote: WAF.Engine.Content.InnerContentBase {
        LongStringPropertyValue _title;
        public virtual string Title {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("b4c88ad8-7fb2-45d8-838a-a2119e0aa6ed"), ref _title, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("b4c88ad8-7fb2-45d8-838a-a2119e0aa6ed"), ref _title, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        HTMLPropertyValue _text;
        public virtual string Text {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("f0f70939-ce38-4f55-af41-9e34515c1b64"), ref _text, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("f0f70939-ce38-4f55-af41-9e34515c1b64"), ref _text, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        FilePropertyValue _image;
        public virtual FilePropertyValue Image {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("7aecc3eb-ca19-4ea8-b481-865b3a91618b"),WAFID.GetDataValueId("4d9011b7-0658-4a0a-9ab0-ffe02703c975"),WAFID.GetDataValueId("7cdae8a1-ab7f-4fb9-a560-e51e223fe90c"),WAFID.GetDataValueId("aa9e38e6-da90-42e9-b18b-b3b5a829e2d9"),WAFID.GetDataValueId("d15db98b-148f-4d63-9bc8-5e8631ab86c5"),WAFID.GetDataValueId("c59b87d5-24cc-4535-8b97-72a1cd62f1c1"), ref _image, this, WAFID.GetDataValueId("de2ba9dc-00fb-473e-a99a-49191b1c1211")); }
        }
      
        LinkPropertyValue _moreLink;
        public virtual LinkPropertyValue MoreLink {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("3d53c493-e1c0-4380-a290-2a1401ea7de0"), ref _moreLink, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        public override DateTime LastCompile {
            get {
                return new DateTime(2019, 5, 16, 11, 34, 1);
            }
        }

        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("e14fe1c4-70d5-43dc-8e7a-4df83d5f19a9");
            }
        }

        public static int PropertyIdTitle {
            get {
                return WAFID.GetPropertyId("2298c8c8-b594-436a-8507-295780be610c");
            }
        }

        public static int DataValueIdTitleTitle {
            get {
                return WAFID.GetDataValueId("b4c88ad8-7fb2-45d8-838a-a2119e0aa6ed");
            }
        }

        public static int PropertyIdText {
            get {
                return WAFID.GetPropertyId("ca3581d1-994d-4183-a7f7-c5829b31bb3e");
            }
        }

        public static int DataValueIdTextText {
            get {
                return WAFID.GetDataValueId("f0f70939-ce38-4f55-af41-9e34515c1b64");
            }
        }

        public static int PropertyIdImage {
            get {
                return WAFID.GetPropertyId("de2ba9dc-00fb-473e-a99a-49191b1c1211");
            }
        }

        public static int DataValueIdImageImageFilename {
            get {
                return WAFID.GetDataValueId("4d9011b7-0658-4a0a-9ab0-ffe02703c975");
            }
        }

        public static int DataValueIdImageImageTypeName {
            get {
                return WAFID.GetDataValueId("7cdae8a1-ab7f-4fb9-a560-e51e223fe90c");
            }
        }

        public static int DataValueIdImageImageExtension {
            get {
                return WAFID.GetDataValueId("aa9e38e6-da90-42e9-b18b-b3b5a829e2d9");
            }
        }

        public static int DataValueIdImageImageBytes {
            get {
                return WAFID.GetDataValueId("d15db98b-148f-4d63-9bc8-5e8631ab86c5");
            }
        }

        public static int DataValueIdImageImageInfo {
            get {
                return WAFID.GetDataValueId("c59b87d5-24cc-4535-8b97-72a1cd62f1c1");
            }
        }

        public static int DataValueIdImageImageInt {
            get {
                return WAFID.GetDataValueId("7aecc3eb-ca19-4ea8-b481-865b3a91618b");
            }
        }

        public static int PropertyIdMoreLink {
            get {
                return WAFID.GetPropertyId("fc16c7f7-167e-4023-93e2-4fbcf44e4dff");
            }
        }

        public static int DataValueIdMoreLinkMoreLink {
            get {
                return WAFID.GetDataValueId("3d53c493-e1c0-4380-a290-2a1401ea7de0");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("2298c8c8-b594-436a-8507-295780be610c")) {
                object init = Title;
                return _title;
            }
            else if (propertyId == WAFID.GetPropertyId("ca3581d1-994d-4183-a7f7-c5829b31bb3e")) {
                object init = Text;
                return _text;
            }
            else if (propertyId == WAFID.GetPropertyId("de2ba9dc-00fb-473e-a99a-49191b1c1211")) {
                object init = Image;
                return _image;
            }
            else if (propertyId == WAFID.GetPropertyId("fc16c7f7-167e-4023-93e2-4fbcf44e4dff")) {
                object init = MoreLink;
                return _moreLink;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _title = null;
            _text = null;
            _image = null;
            _moreLink = null;
            base.ResetPropertyValues();
        }
    }
}
