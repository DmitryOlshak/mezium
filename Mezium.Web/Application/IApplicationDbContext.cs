﻿using Mezium.Web.Domain;
using Microsoft.EntityFrameworkCore;

namespace Mezium.Web.Application;

public interface IApplicationDbContext
{
    DbSet<Story> Stories { get; }
}