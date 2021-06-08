using LCA_Core.Entity;
using LCA_Core.Map;
using LCA_Model.SeedData;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LCA_Model.Context
{
    public class DataContext : DbContext
    {
        private readonly IHttpContextAccessor _accessor;
        public DataContext(DbContextOptions options, IHttpContextAccessor accessor)
            : base(options)
        {
            _accessor = accessor;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            RegisterMapping(modelBuilder);
            modelBuilder.ApplyConfiguration(new MemberSeedData());
            modelBuilder.ApplyConfiguration(new FriendshipSeedData());
            modelBuilder.ApplyConfiguration(new MessageSeedData());
        }

        private void RegisterMapping(ModelBuilder modelBuilder)
        {
            var typeToRegister = new List<Type>();
            var dataAssembly = Assembly.GetExecutingAssembly();

            typeToRegister.AddRange(dataAssembly.DefinedTypes.Select(x => x.AsType()));

            foreach (var builderType in typeToRegister.Where(x => typeof(IEntityBuilder).IsAssignableFrom(x)))
            {
                if (builderType != null && builderType != typeof(IEntityBuilder))
                {
                    var builder = (IEntityBuilder)Activator.CreateInstance(builderType);
                    builder.Builder(modelBuilder);
                }
            }
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var modifiedEntities = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified || x.State == EntityState.Added).ToList();

            string computerName = Environment.MachineName;
            string IPaddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            DateTime date = DateTime.Now;

            foreach (var item in modifiedEntities)
            {
                CoreEntity entity = item.Entity as CoreEntity;
                if (item != null)
                {
                    switch (item.State)
                    {
                        case EntityState.Modified:
                            entity.ModifiedComputerName = computerName;
                            entity.ModifiedDate = date;
                            entity.ModifiedIp = IPaddress;
                            break;
                        case EntityState.Added:
                            entity.CreatedComputerName = computerName;
                            entity.CreatedDate = date;
                            entity.CreatedIp = IPaddress;
                            break;
                        default:
                            break;
                    }
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
