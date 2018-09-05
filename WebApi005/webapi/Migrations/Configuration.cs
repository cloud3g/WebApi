using System.Configuration;

namespace webapi.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<webapi.Entities.DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;//�Զ��������ݿ�
            AutomaticMigrationDataLossAllowed = true;//��������ɾ�����ֶ�ʱ�ᶪʧ���ݣ����ó���������������ͬ�����ݿ�����
            var providerName = ConfigurationManager.ConnectionStrings["DBConnection"].ProviderName;
            if (providerName == "MySql.Data.MySqlClient")
            {
                SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());//������ݿ���mysql��������һ��
            }
        }

        protected override void Seed(webapi.Entities.DB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
