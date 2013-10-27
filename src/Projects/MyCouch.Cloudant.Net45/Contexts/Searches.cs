﻿using System.Threading.Tasks;
using MyCouch.Cloudant.Requests;
using MyCouch.Cloudant.Responses;
using MyCouch.Contexts;

namespace MyCouch.Cloudant.Contexts
{
    public class Searches : ApiContextBase, ISearches
    {
        public Searches(IConnection connection) : base(connection)
        {
        }

        public virtual Task<SearchIndexResponse> SearchAsync(SearchIndexRequest search)
        {
            throw new System.NotImplementedException();
        }

        public virtual Task<SearchIndexResponse<TValue>> SearchAsync<TValue>(SearchIndexRequest search)
        {
            throw new System.NotImplementedException();
        }

        public virtual Task<SearchIndexResponse<TValue, TIncludedDoc>> SearchAsync<TValue, TIncludedDoc>(SearchIndexRequest search)
        {
            throw new System.NotImplementedException();
        }
    }
}