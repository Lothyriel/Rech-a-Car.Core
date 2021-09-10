CREATE TABLE [dbo].[TBServico] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Nome]       VARCHAR (100) NOT NULL,
    [Taxa]       DECIMAL (19)  NOT NULL,
    [ID_ALUGUEL] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBServico_TBAluguel] FOREIGN KEY ([ID_ALUGUEL]) REFERENCES [dbo].[TBAluguel] ([ID]) ON DELETE SET NULL ON UPDATE SET NULL
);

