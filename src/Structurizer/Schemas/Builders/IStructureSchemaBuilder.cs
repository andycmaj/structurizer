﻿namespace Structurizer.Schemas.Builders
{
    public interface IStructureSchemaBuilder
    {
        IDataTypeConverter DataTypeConverter { get; set; }
        IStructureSchema CreateSchema(IStructureType structureType);
    }
}