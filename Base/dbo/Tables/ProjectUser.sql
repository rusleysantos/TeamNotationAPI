CREATE TABLE [dbo].[ProjectUser] (
    [IDPROJECTUSER]    INT IDENTITY (1, 1) NOT NULL,
    [ProjectidProject] INT NULL,
    [IDUSER]           INT NOT NULL,
    [IDPROJECT]        INT NOT NULL,
    CONSTRAINT [PK_ProjectUser] PRIMARY KEY CLUSTERED ([IDPROJECTUSER] ASC),
    CONSTRAINT [FK_ProjectUser_Project_ProjectidProject] FOREIGN KEY ([ProjectidProject]) REFERENCES [dbo].[Project] ([IDPROJECT])
);


GO
CREATE NONCLUSTERED INDEX [IX_ProjectUser_ProjectidProject]
    ON [dbo].[ProjectUser]([ProjectidProject] ASC);

