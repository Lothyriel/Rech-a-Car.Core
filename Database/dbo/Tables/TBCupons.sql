CREATE TABLE [dbo].[TBCupons] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [Nome]             VARCHAR (100) NOT NULL,
    [Valor_Fixo]       DECIMAL (18)  NULL,
    [Valor_Percentual] INT           NULL,
    [Data_Validade]    DATE          NOT NULL,
    [valor_Minimo]     DECIMAL (18)  NOT NULL,
    [idParceiro]       INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBCupons_TBParceiro] FOREIGN KEY ([idParceiro]) REFERENCES [dbo].[TBParceiro] ([Id])
);

