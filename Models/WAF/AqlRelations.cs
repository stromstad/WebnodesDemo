// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************

using WAF.Data.Query;
using WAF.Engine.Query;
using WAF.Engine.Query.Advanced;

namespace WAF.Data.Query.MySite {

    public abstract class SqlRelHelloWorldArticles {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_rel_hello_world_articles", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Engine.Query.MySite{

    [System.Serializable]
    public abstract class AqlRelHelloWorldArticles{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("97e1bea7-8f10-48e3-aed3-0d240b5e391d") );
            }
        }

    }
}
namespace WAF.Engine.Query.MySite{

    [System.Serializable]
    public class AqlAliasRelHelloWorldArticles: AqlAliasRelation {

        public AqlAliasRelHelloWorldArticles(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelHelloWorldArticles.Relation) {

        }
        public AqlAliasRelHelloWorldArticles(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelHelloWorldArticles.Relation, onParent ) {

        }
        public AqlAliasRelHelloWorldArticles(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelHelloWorldArticles.Relation, onChild ) {

        }
        public AqlAliasRelHelloWorldArticles(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelHelloWorldArticles.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Content.MySite{
    [System.Serializable]
    public partial class RelHelloWorldArticles: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("97e1bea7-8f10-48e3-aed3-0d240b5e391d");
            }
        }

    }
}
namespace WAF.Engine.Content.MySite{

    public enum TypeOfHello: int{

        Velkommen=0,
        Welcome=1,
        Welkom=2,
        Bienvenue=3,
    }
}
