using AutoMapper;
using Internship.Business.Stocks.Commands.Create;
using Internship.Business.Stocks.Commands.Delete;
using Internship.Business.Stocks.Commands.Update;
using Internship.Business.Stocks.Queries.Filter;
using Internship.Business.Stocks.Queries.GetById;
using Internship.Controllers.Stocks.Models;
using Internship.Controllers.Stocks.ModelsStock;
using Internship.Controllers.Stocks.Pagination;
using Internship.Data;

namespace Internship.Controllers.Stocks.Mappings
{
    public class StockMapping : Profile
    {
        public StockMapping()
        {
            CreateMap<GetStockByIdQuery, Stock>();

            CreateMap<GetByIdProductQuery, GetStockIdResult>();

            CreateMap<StockRequest, CreateStockCommand>();

            CreateMap<StockRequest, UpdateStockCommand>();

            CreateMap<StockRequest, DeleteStockCommand>();

            CreateMap<Stock, GetStockIdResult>();

            CreateMap<CreateStockCommand, Stock>();

            CreateMap<Stock, DeleteStockCommand>();

            CreateMap<Stock, CreateStockCommand>();

            CreateMap<Stock, UpdateStockCommand>();

            CreateMap<GetStockIdResult, GetByIdProductQuery>();

            CreateMap<Stock, GetAllStockQuery>();
            CreateMap<Stock, StockPaginationResponse>();

            CreateMap<Stock, GetStockIdResult>().ForMember(p=>p.ProductId, map=>map.MapFrom(prop=>prop.Product.Id));
            CreateMap<Stock, StockRequest>().ForMember(p => p.ProductId, map => map.MapFrom(prop => prop.Product.Id));
            CreateMap<Stock, CreateStockCommand>().ForMember(p => p.ProductId, map => map.MapFrom(prop => prop.Product.Id));
            CreateMap<Stock, GetByIdProductQuery>().ForMember(p => p.ProductId, map => map.MapFrom(prop => prop.Product.Id));
            CreateMap<Stock, StockResult>().ForMember(p => p.ProductId, map => map.MapFrom(prop => prop.Product.Id));
        }
    }
}
