CREATE TABLE [dbo].[TBCategoria] (
    [PRECO_KM]               DECIMAL (18) NOT NULL,
    [PRECO_DIARIA]           DECIMAL (18) NOT NULL,
    [QUILOMETRAGEM_FRANQUIA] INT          NOT NULL,
    [PRECO_LIVRE]            DECIMAL (18) NOT NULL,
    [NOME]                   VARCHAR (50) NOT NULL,
    [TIPO_CNH]               INT          NOT NULL,
    [ID]                     INT          IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_TBCategoria] PRIMARY KEY CLUSTERED ([ID] ASC)
);

