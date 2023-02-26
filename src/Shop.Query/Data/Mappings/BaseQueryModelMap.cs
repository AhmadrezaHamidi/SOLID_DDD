using MongoDB.Bson.Serialization;
using Shop.Query.Abstractions;
using Shop.Query.QueriesModel;

namespace Shop.Infrastructure.Data.Mappings.ReadOnly;

public class BaseQueryModelMap : IReadDbMapping
{
    public void Configure()
    {
        BsonClassMap.TryRegisterClassMap<BaseQueryModel>(map =>
        {
            map.AutoMap();
            map.SetIgnoreExtraElements(true);
            map.SetIsRootClass(true);

            map.MapIdMember(queryModel => queryModel.Id)
                .SetIsRequired(true);
        });
    }
}