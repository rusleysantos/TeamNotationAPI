CREATE TABLE [dbo].[AttachT] (
    [IDATTACH]               INT            IDENTITY (1, 1) NOT NULL,
    [TITLE]                  NVARCHAR (MAX) NULL,
    [TYPE]                   NVARCHAR (MAX) NULL,
    [BLOB]                   TINYINT        NOT NULL,
    [ExecutionTaskidTask]    INT            NULL,
    [ImpedimentidImpediment] INT            NULL,
    [KnowledgeidKnowledge]   INT            NULL,
    [NotationidNotation]     INT            NULL,
    CONSTRAINT [PK_AttachT] PRIMARY KEY CLUSTERED ([IDATTACH] ASC),
    CONSTRAINT [FK_AttachT_ExecutionTask_ExecutionTaskidTask] FOREIGN KEY ([ExecutionTaskidTask]) REFERENCES [dbo].[ExecutionTask] ([IDTASK]),
    CONSTRAINT [FK_AttachT_Impediment_ImpedimentidImpediment] FOREIGN KEY ([ImpedimentidImpediment]) REFERENCES [dbo].[Impediment] ([IDIMPEDIMENT]),
    CONSTRAINT [FK_AttachT_Knowledge_KnowledgeidKnowledge] FOREIGN KEY ([KnowledgeidKnowledge]) REFERENCES [dbo].[Knowledge] ([IDKNOWLEDGE]),
    CONSTRAINT [FK_AttachT_Notation_NotationidNotation] FOREIGN KEY ([NotationidNotation]) REFERENCES [dbo].[Notation] ([IDNOTATION])
);


GO
CREATE NONCLUSTERED INDEX [IX_AttachT_NotationidNotation]
    ON [dbo].[AttachT]([NotationidNotation] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_AttachT_KnowledgeidKnowledge]
    ON [dbo].[AttachT]([KnowledgeidKnowledge] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_AttachT_ImpedimentidImpediment]
    ON [dbo].[AttachT]([ImpedimentidImpediment] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_AttachT_ExecutionTaskidTask]
    ON [dbo].[AttachT]([ExecutionTaskidTask] ASC);

