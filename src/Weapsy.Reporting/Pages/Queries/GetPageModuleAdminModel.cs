﻿using System;
using Weapsy.Infrastructure.Queries;

namespace Weapsy.Reporting.Pages.Queries
{
    public class GetPageModuleAdminModel : IQuery
    {
        public Guid SiteId { get; set; }
        public Guid PageId { get; set; }
        public Guid PageModuleId { get; set; }
    }
}
