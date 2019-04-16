﻿using ArkanoTest.App.Models.Common;
using ArkanoTest.App.Services.RequestProvider;
using ArkanoTest.Service.Computer.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArkanoTest.App.Services.RamService
{
    public class RamService : IRamService
    {
        private readonly IRequestProvider _requestProvider;

        public RamService(IRequestProvider requestProvider)
        {
            this._requestProvider = requestProvider;
        }

        public async Task<IEnumerable<RAM>> GetRAMs()
        {
            try
            {
                string uri = String.Format(Constants.BaseEndpoint + "/api/rams");
                var response = await _requestProvider.GetAsync<List<RAM>>(uri);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
