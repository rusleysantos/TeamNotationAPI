﻿CREATE TABLE [dbo].[Mockup] (
    [IDMOCKUP] INT            IDENTITY (1, 1) NOT NULL,
    [TYPE]     NVARCHAR (MAX) NULL,
    [BLOB]     TINYINT        NOT NULL,
    CONSTRAINT [PK_Mockup] PRIMARY KEY CLUSTERED ([IDMOCKUP] ASC)
);

