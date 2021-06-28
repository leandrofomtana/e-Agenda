CREATE TABLE [dbo].[TBCompromisso] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Assunto]      VARCHAR (200) NOT NULL,
    [Local]        VARCHAR (200) NULL,
    [Data]         DATETIME      NOT NULL,
    [Hora_Inicio]  TIME (7)      NOT NULL,
    [Hora_Termino] TIME (7)      NOT NULL,
    [Link_Online]  VARCHAR (200) NULL,
    [Id_Contato]   INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBCompromisso_TBContato] FOREIGN KEY ([Id_Contato]) REFERENCES [dbo].[TBContato] ([Id])
);

