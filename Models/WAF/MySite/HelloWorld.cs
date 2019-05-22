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
    public partial class HelloWorld: WAF.Engine.Content.Native.HierarchicalContent {
        EnumerationPropertyValue _typeOfHello;
        public virtual MySite.TypeOfHello TypeOfHello {
        get { return (MySite.TypeOfHello) EnumerationPropertyValue.GetValue(WAFID.GetDataValueId("74ff0f17-7d29-45ff-af98-e64511eb6abe"), ref _typeOfHello, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); EnumerationPropertyValue.SetValue(WAFID.GetDataValueId("74ff0f17-7d29-45ff-af98-e64511eb6abe"), ref _typeOfHello, this.Session, this.ContentId, this.ContentData.DataValueById, (int)value); }
        }
      
        LongStringPropertyValue _ingress;
        public virtual string Ingress {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("d8befa00-9c1d-4fff-9f82-01865a3c5ef1"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("d8befa00-9c1d-4fff-9f82-01865a3c5ef1"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        FilePropertyValue _ingressPicture;
        public virtual FilePropertyValue IngressPicture {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("7243e380-2fe4-4af5-a959-b763c5bbe85d"),WAFID.GetDataValueId("6db2fc03-d37f-4c84-8af4-8767a0eb7e2b"),WAFID.GetDataValueId("62a9a907-32dc-48d1-a301-a4b6d976ee68"),WAFID.GetDataValueId("ddb93c77-7942-4f38-acba-3ef7a185b719"),WAFID.GetDataValueId("159b0435-0c87-4274-8497-60dd90ab411b"),WAFID.GetDataValueId("aa637b67-48f8-43e5-8da8-64293b5eb346"), ref _ingressPicture, this, WAFID.GetDataValueId("d8ae88fe-4a85-4eae-a387-f79ab1472d26")); }
        }
      
        HTMLPropertyValue _content;
        public virtual string Content {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("300e0041-8116-4721-8b17-c5afec2daf82"), ref _content, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("300e0041-8116-4721-8b17-c5afec2daf82"), ref _content, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase> _files;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase> Files{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase>.GetValue(WAFID.GetDataValueId("1e881cf8-49c7-4496-89c8-9cfebe1fb093"), ref _files, this);}
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.MySite.Quote> _quotes;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.MySite.Quote> Quotes{
        get {EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.MySite.Quote>.GetValue(WAFID.GetDataValueId("38c0ea84-3604-4fa5-af27-8419115f4831"), ref _quotes, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.Native.ArticleBase> _relatedArticles;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.Native.ArticleBase> RelatedArticles{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.Native.ArticleBase>.GetValue(WAFID.GetDataValueId("e3b65c50-4cc3-4de5-b7b2-5cac97bbfa6c"), ref _relatedArticles, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<HelloWorld>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<HelloWorld>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<HelloWorld>(NodeId, lcid, revision);
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
                return WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f");
            }
        }

        public static int PropertyIdTypeOfHello {
            get {
                return WAFID.GetPropertyId("e7c45ff5-6a2b-4902-ba07-2659ce79b85f");
            }
        }

        public static int DataValueIdTypeOfHelloTypeOfHello {
            get {
                return WAFID.GetDataValueId("74ff0f17-7d29-45ff-af98-e64511eb6abe");
            }
        }

        public static int PropertyIdIngress {
            get {
                return WAFID.GetPropertyId("bb08276f-e760-4aa2-a98f-6d2fd00d8e22");
            }
        }

        public static int DataValueIdIngressIngress {
            get {
                return WAFID.GetDataValueId("d8befa00-9c1d-4fff-9f82-01865a3c5ef1");
            }
        }

        public static int PropertyIdIngressPicture {
            get {
                return WAFID.GetPropertyId("d8ae88fe-4a85-4eae-a387-f79ab1472d26");
            }
        }

        public static int DataValueIdIngressPictureIngressPictureFilename {
            get {
                return WAFID.GetDataValueId("6db2fc03-d37f-4c84-8af4-8767a0eb7e2b");
            }
        }

        public static int DataValueIdIngressPictureIngressPictureTypeName {
            get {
                return WAFID.GetDataValueId("62a9a907-32dc-48d1-a301-a4b6d976ee68");
            }
        }

        public static int DataValueIdIngressPictureIngressPictureExtension {
            get {
                return WAFID.GetDataValueId("ddb93c77-7942-4f38-acba-3ef7a185b719");
            }
        }

        public static int DataValueIdIngressPictureIngressPictureBytes {
            get {
                return WAFID.GetDataValueId("159b0435-0c87-4274-8497-60dd90ab411b");
            }
        }

        public static int DataValueIdIngressPictureIngressPictureInfo {
            get {
                return WAFID.GetDataValueId("aa637b67-48f8-43e5-8da8-64293b5eb346");
            }
        }

        public static int DataValueIdIngressPictureIngressPictureInt {
            get {
                return WAFID.GetDataValueId("7243e380-2fe4-4af5-a959-b763c5bbe85d");
            }
        }

        public static int PropertyIdContent {
            get {
                return WAFID.GetPropertyId("eb985ce1-c69a-473e-b250-95d0eeafb8f4");
            }
        }

        public static int DataValueIdContentContent {
            get {
                return WAFID.GetDataValueId("300e0041-8116-4721-8b17-c5afec2daf82");
            }
        }

        public static int PropertyIdFiles {
            get {
                return WAFID.GetPropertyId("1e881cf8-49c7-4496-89c8-9cfebe1fb093");
            }
        }

        public static int PropertyIdQuotes {
            get {
                return WAFID.GetPropertyId("38c0ea84-3604-4fa5-af27-8419115f4831");
            }
        }

        public static int PropertyIdRelatedArticles {
            get {
                return WAFID.GetPropertyId("e3b65c50-4cc3-4de5-b7b2-5cac97bbfa6c");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("e7c45ff5-6a2b-4902-ba07-2659ce79b85f")) {
                object init = TypeOfHello;
                return _typeOfHello;
            }
            else if (propertyId == WAFID.GetPropertyId("bb08276f-e760-4aa2-a98f-6d2fd00d8e22")) {
                object init = Ingress;
                return _ingress;
            }
            else if (propertyId == WAFID.GetPropertyId("d8ae88fe-4a85-4eae-a387-f79ab1472d26")) {
                object init = IngressPicture;
                return _ingressPicture;
            }
            else if (propertyId == WAFID.GetPropertyId("eb985ce1-c69a-473e-b250-95d0eeafb8f4")) {
                object init = Content;
                return _content;
            }
            else if (propertyId == WAFID.GetPropertyId("1e881cf8-49c7-4496-89c8-9cfebe1fb093")) {
                object init = Files;
                return _files;
            }
            else if (propertyId == WAFID.GetPropertyId("38c0ea84-3604-4fa5-af27-8419115f4831")) {
                object init = Quotes;
                return _quotes;
            }
            else if (propertyId == WAFID.GetPropertyId("e3b65c50-4cc3-4de5-b7b2-5cac97bbfa6c")) {
                object init = RelatedArticles;
                return _relatedArticles;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _typeOfHello = null;
            _ingress = null;
            _ingressPicture = null;
            _content = null;
            _files = null;
            _quotes = null;
            _relatedArticles = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.MySite {
    public abstract class SqlHelloWorld {
        public static SqlTable Table {
            get {
                return new SqlTable("hello_world", WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldInteger TypeOfHello {
                get {
                    return new SqlFieldInteger("type_of_hello", Table, WAFID.GetDataValueId("74ff0f17-7d29-45ff-af98-e64511eb6abe"));
                }
            }

            public static SqlFieldLongString Ingress {
                get {
                    return new SqlFieldLongString("ingress", Table, WAFID.GetDataValueId("d8befa00-9c1d-4fff-9f82-01865a3c5ef1"));
                }
            }

            public static SqlFieldShortString IngressPicture_ingress_picture_filename {
                get {
                    return new SqlFieldShortString("ingress_picture_filename", Table, WAFID.GetDataValueId("6db2fc03-d37f-4c84-8af4-8767a0eb7e2b"));
                }
            }

            public static SqlFieldShortString IngressPicture_ingress_picture_type_name {
                get {
                    return new SqlFieldShortString("ingress_picture_type_name", Table, WAFID.GetDataValueId("62a9a907-32dc-48d1-a301-a4b6d976ee68"));
                }
            }

            public static SqlFieldShortString IngressPicture_ingress_picture_extension {
                get {
                    return new SqlFieldShortString("ingress_picture_extension", Table, WAFID.GetDataValueId("ddb93c77-7942-4f38-acba-3ef7a185b719"));
                }
            }

            public static SqlFieldFloat IngressPicture_ingress_picture_bytes {
                get {
                    return new SqlFieldFloat("ingress_picture_bytes", Table, WAFID.GetDataValueId("159b0435-0c87-4274-8497-60dd90ab411b"));
                }
            }

            public static SqlFieldLongString IngressPicture_ingress_picture_info {
                get {
                    return new SqlFieldLongString("ingress_picture_info", Table, WAFID.GetDataValueId("aa637b67-48f8-43e5-8da8-64293b5eb346"));
                }
            }

            public static SqlFieldInteger IngressPicture_ingress_picture_int {
                get {
                    return new SqlFieldInteger("ingress_picture_int", Table, WAFID.GetDataValueId("7243e380-2fe4-4af5-a959-b763c5bbe85d"));
                }
            }

            public static SqlFieldLongString Content {
                get {
                    return new SqlFieldLongString("content", Table, WAFID.GetDataValueId("300e0041-8116-4721-8b17-c5afec2daf82"));
                }
            }

        }
    }
    public class SqlAliasHelloWorld : SqlAlias {
        public SqlAliasHelloWorld()
            : base(SqlHelloWorld.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlHelloWorld.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldInteger TypeOfHello {
            get {
                return new SqlExpressionFieldInteger(SqlHelloWorld.Field.TypeOfHello, this);
            }
        }

        public SqlExpressionFieldLongString Ingress {
            get {
                return new SqlExpressionFieldLongString(SqlHelloWorld.Field.Ingress, this);
            }
        }

        public SqlExpressionFieldShortString IngressPicture_ingress_picture_filename {
            get {
                return new SqlExpressionFieldShortString(SqlHelloWorld.Field.IngressPicture_ingress_picture_filename, this);
            }
        }

        public SqlExpressionFieldShortString IngressPicture_ingress_picture_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlHelloWorld.Field.IngressPicture_ingress_picture_type_name, this);
            }
        }

        public SqlExpressionFieldShortString IngressPicture_ingress_picture_extension {
            get {
                return new SqlExpressionFieldShortString(SqlHelloWorld.Field.IngressPicture_ingress_picture_extension, this);
            }
        }

        public SqlExpressionFieldFloat IngressPicture_ingress_picture_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlHelloWorld.Field.IngressPicture_ingress_picture_bytes, this);
            }
        }

        public SqlExpressionFieldLongString IngressPicture_ingress_picture_info {
            get {
                return new SqlExpressionFieldLongString(SqlHelloWorld.Field.IngressPicture_ingress_picture_info, this);
            }
        }

        public SqlExpressionFieldInteger IngressPicture_ingress_picture_int {
            get {
                return new SqlExpressionFieldInteger(SqlHelloWorld.Field.IngressPicture_ingress_picture_int, this);
            }
        }

        public SqlExpressionFieldLongString Content {
            get {
                return new SqlExpressionFieldLongString(SqlHelloWorld.Field.Content, this);
            }
        }

    }
}
namespace WAF.Engine.Query.MySite {
    [System.Serializable]
    public partial class AqlHelloWorld{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")); 
            }
        }

        public static AqlPropertyInteger TypeOfHello {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.MySite.SqlHelloWorld.Field.TypeOfHello, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyLongString Ingress {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlHelloWorld.Field.Ingress, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyShortString IngressPicture_ingress_picture_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlHelloWorld.Field.IngressPicture_ingress_picture_filename, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyShortString IngressPicture_ingress_picture_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlHelloWorld.Field.IngressPicture_ingress_picture_type_name, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyShortString IngressPicture_ingress_picture_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlHelloWorld.Field.IngressPicture_ingress_picture_extension, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyFloat IngressPicture_ingress_picture_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.MySite.SqlHelloWorld.Field.IngressPicture_ingress_picture_bytes, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyLongString IngressPicture_ingress_picture_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlHelloWorld.Field.IngressPicture_ingress_picture_info, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyInteger IngressPicture_ingress_picture_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.MySite.SqlHelloWorld.Field.IngressPicture_ingress_picture_int, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyLongString Content {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlHelloWorld.Field.Content, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyRelation RelatedArticles {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("e3b65c50-4cc3-4de5-b7b2-5cac97bbfa6c"), new AqlAliasRelation(new WAF.Engine.Query.MySite.AqlAliasHelloWorld(), new WAF.Engine.Query.Native.AqlAliasArticleBase(), WAF.Engine.Query.MySite.AqlRelHelloWorldArticles.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyRelation ContentTags {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a4e4d56c-8ff9-4ede-9232-094e72398668"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasContentTag(), WAF.Engine.Query.Native.AqlRelTaxonomyHierarchical.Relation));
            }
        }

        public static AqlPropertyRelation Children {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("cc90eccd-1d77-40c8-aab7-5262842a66e2"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.Native.AqlRelHierarchical.Relation));
            }
        }

        public static AqlPropertyRelation Parent {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a1eca898-8f93-4522-a46c-669c56af9b55"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.Native.AqlRelHierarchical.Relation));
            }
        }

        public static AqlPropertyBoolean ShowInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasHelloWorld
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasHelloWorld()
            : base(WAFID.GetContentClassId("99219e40-ccf2-4f38-95ec-8a1e723fc43f")) {

        }

        public AqlAliasHelloWorld(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyInteger TypeOfHello {
            get {
                return new AqlExpressionPropertyInteger(AqlHelloWorld.TypeOfHello, this);
            }
        }

        public AqlExpressionPropertyLongString Ingress {
            get {
                return new AqlExpressionPropertyLongString(AqlHelloWorld.Ingress, this);
            }
        }

        public AqlExpressionPropertyShortString IngressPicture_ingress_picture_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlHelloWorld.IngressPicture_ingress_picture_filename, this);
            }
        }

        public AqlExpressionPropertyShortString IngressPicture_ingress_picture_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlHelloWorld.IngressPicture_ingress_picture_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString IngressPicture_ingress_picture_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlHelloWorld.IngressPicture_ingress_picture_extension, this);
            }
        }

        public AqlExpressionPropertyFloat IngressPicture_ingress_picture_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlHelloWorld.IngressPicture_ingress_picture_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString IngressPicture_ingress_picture_info {
            get {
                return new AqlExpressionPropertyLongString(AqlHelloWorld.IngressPicture_ingress_picture_info, this);
            }
        }

        public AqlExpressionPropertyInteger IngressPicture_ingress_picture_int {
            get {
                return new AqlExpressionPropertyInteger(AqlHelloWorld.IngressPicture_ingress_picture_int, this);
            }
        }

        public AqlExpressionPropertyLongString Content {
            get {
                return new AqlExpressionPropertyLongString(AqlHelloWorld.Content, this);
            }
        }

    }
}
