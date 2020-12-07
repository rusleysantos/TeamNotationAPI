﻿CREATE TABLE [dbo].[Project] (
    [IDPROJECT]   INT            IDENTITY (1, 1) NOT NULL,
    [TITLE]       NVARCHAR (MAX) NULL,
    [DESCRIPTION] NVARCHAR (MAX) NULL,
    [PERCENTDONE] FLOAT (53)     NOT NULL,
    CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED ([IDPROJECT] ASC)
);
