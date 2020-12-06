CREATE TABLE [dbo].[ExecutionTask] (
    [IDTASK]                 INT            IDENTITY (1, 1) NOT NULL,
    [TITLE]                  NVARCHAR (MAX) NULL,
    [DESCRIPTION]            NVARCHAR (MAX) NULL,
    [WEIGHT]                 NVARCHAR (MAX) NULL,
    [EFFORT]                 NVARCHAR (MAX) NULL,
    [IDSTATUS]               INT            NOT NULL,
    [IDUSER]                 INT            NOT NULL,
    [IDPROJECT]              INT            NOT NULL,
    [ImpedimentidImpediment] INT            NULL,
    [KnowledgeidKnowledge]   INT            NULL,
    [ProjectidProject]       INT            NULL,
    CONSTRAINT [PK_ExecutionTask] PRIMARY KEY CLUSTERED ([IDTASK] ASC),
    CONSTRAINT [FK_ExecutionTask_Impediment_ImpedimentidImpediment] FOREIGN KEY ([ImpedimentidImpediment]) REFERENCES [dbo].[Impediment] ([IDIMPEDIMENT]),
    CONSTRAINT [FK_ExecutionTask_Knowledge_KnowledgeidKnowledge] FOREIGN KEY ([KnowledgeidKnowledge]) REFERENCES [dbo].[Knowledge] ([IDKNOWLEDGE]),
    CONSTRAINT [FK_ExecutionTask_Project_ProjectidProject] FOREIGN KEY ([ProjectidProject]) REFERENCES [dbo].[Project] ([IDPROJECT])
);


GO
CREATE NONCLUSTERED INDEX [IX_ExecutionTask_ProjectidProject]
    ON [dbo].[ExecutionTask]([ProjectidProject] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ExecutionTask_KnowledgeidKnowledge]
    ON [dbo].[ExecutionTask]([KnowledgeidKnowledge] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ExecutionTask_ImpedimentidImpediment]
    ON [dbo].[ExecutionTask]([ImpedimentidImpediment] ASC);

