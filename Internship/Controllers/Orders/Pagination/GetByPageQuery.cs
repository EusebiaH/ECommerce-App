﻿using MediatR;

namespace Internship.Controllers.Orders.Pagination
{
    public class GetByPageQuery:IRequest<Response>
    {
        public int Page { get; set; }
        public double ObjectsOnPage { get; set; }
        public GetByPageQuery( int page, double objectsOnPage)
        {
            Page = page;    
            ObjectsOnPage = objectsOnPage;
        }
    }
}
