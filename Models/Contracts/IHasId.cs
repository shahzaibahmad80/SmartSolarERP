﻿namespace SmartSolarERP.Models.Contracts
{
    public interface IHasId
    {
        int Id { get; set; }
        Guid RowGuid { get; set; }
    }
}
