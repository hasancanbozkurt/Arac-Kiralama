﻿namespace CarBook1.Application.Features.Mediator.Results.BlogResults
{
    public class GetLast3BlogsWitAuthorsQueryResult
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryID { get; set; }
        public string AuthorName { get; set; }
    }
}
