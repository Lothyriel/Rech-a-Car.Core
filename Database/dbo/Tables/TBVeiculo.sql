CREATE TABLE [dbo].[TBVeiculo] (
    [MODELO]            VARCHAR (50)    NOT NULL,
    [MARCA]             VARCHAR (50)    NOT NULL,
    [ANO]               INT             NOT NULL,
    [QUILOMETRAGEM]     INT             NOT NULL,
    [PLACA]             VARCHAR (50)    NOT NULL,
    [CAPACIDADE]        INT             NOT NULL,
    [PORTAS]            INT             NOT NULL,
    [CHASSI]            VARCHAR (50)    NOT NULL,
    [PORTA_MALAS]       VARCHAR (50)    NOT NULL,
    [ID_CATEGORIA]      INT             NOT NULL,
    [AUTOMATICO]        BIT             NOT NULL,
    [FOTO]              VARBINARY (MAX) NOT NULL,
    [TIPO_COMBUSTIVEL]  INT             NOT NULL,
    [CAPACIDADE_TANQUE] INT             NOT NULL,
    [ID]                INT             IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_TBVeiculo] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_TBVeiculo_TBCategoria] FOREIGN KEY ([ID_CATEGORIA]) REFERENCES [dbo].[TBCategoria] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE
);

