// <auto-generated />
namespace IntroToEntityFramework.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.2.0-61023")]
    public sealed partial class Addedrequireminmaxlengthtoorderandcustomerproperties : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(Addedrequireminmaxlengthtoorderandcustomerproperties));
        
        string IMigrationMetadata.Id
        {
            get { return "201802221604274_Added require, min, max length to order and customer properties"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}