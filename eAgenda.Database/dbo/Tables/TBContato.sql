CREATE TABLE [dbo].[TBContato] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Nome]     VARCHAR (50) NOT NULL,
    [Email]    VARCHAR (50) NOT NULL,
    [Telefone] VARCHAR (50) NOT NULL,
    [Empresa]  VARCHAR (50) NOT NULL,
    [Cargo]    VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_TBContato] PRIMARY KEY CLUSTERED ([Id] ASC)
);

