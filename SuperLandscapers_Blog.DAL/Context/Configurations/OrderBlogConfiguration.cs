using DAL.Context.Configurations.Base;
using DAL.Entities;
using DAL.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Context.Configurations
{
    public class OrderBlogConfiguration : BaseConfiguration<OrderBlog>
    {
        public override void Configure(EntityTypeBuilder<OrderBlog> builder)
        {
            builder.ToTable("OrderBlog");
            builder.Property(x => x.Username).HasMaxLength(25);
            builder.Property(x => x.Email).HasMaxLength(30);

            builder.HasData(
            new OrderBlog
            {
                Id = Guid.NewGuid(),
                Username = "User1",
                Email = "user1@example.com",
                ShortDescription = "Description 1",
                OrderType = OrderTypeEnum.New
            },
            new OrderBlog
            {
                Id = Guid.NewGuid(),
                Username = "User2",
                Email = "user2@example.com",
                ShortDescription = "Description 2",
                OrderType = OrderTypeEnum.Rejected
            },
            new OrderBlog
            {
                Id = Guid.NewGuid(),
                Username = "User3",
                Email = "user3@example.com",
                ShortDescription = "Description 3",
                OrderType = OrderTypeEnum.Accepted
            },
            new OrderBlog
            {
                Id = Guid.NewGuid(),
                Username = "User4",
                Email = "user4@example.com",
                ShortDescription = "Description 4",
                OrderType = OrderTypeEnum.New
            },
            new OrderBlog
            {
                Id = Guid.NewGuid(),
                Username = "User5",
                Email = "user5@example.com",
                ShortDescription = "Description 5",
                OrderType = OrderTypeEnum.Accepted
            },
            new OrderBlog
            {
                Id = Guid.NewGuid(),
                Username = "User6",
                Email = "user6@example.com",
                ShortDescription = "Description 6",
                OrderType = OrderTypeEnum.Rejected
            },
            new OrderBlog
            {
                Id = Guid.NewGuid(),
                Username = "User7",
                Email = "user7@example.com",
                ShortDescription = "Description 7",
                OrderType = OrderTypeEnum.Accepted
            },
            new OrderBlog
            {
                Id = Guid.NewGuid(),
                Username = "User8",
                Email = "user8@example.com",
                ShortDescription = "Description 8",
                OrderType = OrderTypeEnum.New
            },
            new OrderBlog
            {
                Id = Guid.NewGuid(),
                Username = "User9",
                Email = "user9@example.com",
                ShortDescription = "Description 9",
                OrderType = OrderTypeEnum.Accepted
            },
            new OrderBlog
            {
                Id = Guid.NewGuid(),
                Username = "User10",
                Email = "user10@example.com",
                ShortDescription = "Description 10",
                OrderType = OrderTypeEnum.Rejected
            }
        );

        }
    }
}
