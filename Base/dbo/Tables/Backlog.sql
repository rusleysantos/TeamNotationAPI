CREATE TABLE [dbo].[Backlog] (
    [IDBACKLOG]           INT            IDENTITY (1, 1) NOT NULL,
    [CATEGORY]            NVARCHAR (MAX) NULL,
    [PRECEDENCE]          NVARCHAR (MAX) NULL,
    [ESTIMATE]            NVARCHAR (MAX) NULL,
    [IMPORTANCE]          NVARCHAR (MAX) NULL,
    [STORY]               NVARCHAR (MAX) NULL,
    [IDPROJECT]           INT            NOT NULL,
    [IDMOCKUP]            INT            NOT NULL,
    [IDSTATUS]            INT            NOT NULL,
    [ExecutionTaskidTask] INT            NULL,
    CONSTRAINT [PK_Backlog] PRIMARY KEY CLUSTERED ([IDBACKLOG] ASC),
    CONSTRAINT [FK_Backlog_ExecutionTask_ExecutionTaskidTask] FOREIGN KEY ([ExecutionTaskidTask]) REFERENCES [dbo].[ExecutionTask] ([IDTASK])
);


GO
CREATE NONCLUSTERED INDEX [IX_Backlog_ExecutionTaskidTask]
    ON [dbo].[Backlog]([ExecutionTaskidTask] ASC);

