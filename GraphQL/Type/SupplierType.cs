using GraphQLAPI.Infra.Models;

namespace GraphQLAPI.GraphQL.Type
{
    public class SupplierType : ObjectType<SupplierDTO>
    {
        protected override void Configure(IObjectTypeDescriptor <SupplierDTO> descriptor)
        {
            descriptor.Field(a => a.Id).Type<IdType>();
            descriptor.Field(a => a.FirstName).Type<StringType>();
            descriptor.Field(a => a.LastName).Type<StringType>();
            descriptor.Field(a => a.Address).Type<StringType>();
            descriptor.Field(a => a.Phone).Type<StringType>();
        }
    }
}