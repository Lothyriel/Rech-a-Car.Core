CREATE TABLE [dbo].[TBFuncionario] (
    [ID]        INT             IDENTITY (1, 1) NOT NULL,
    [NOME]      VARCHAR (50)    NOT NULL,
    [DOCUMENTO] VARCHAR (11)    NOT NULL,
    [TELEFONE]  VARCHAR (11)    NOT NULL,
    [ENDERECO]  VARCHAR (100)   NOT NULL,
    [FOTO]      VARBINARY (MAX) NULL,
    [USER]      VARCHAR (100)   NOT NULL,
    [CARGO]     INT             NOT NULL,
    CONSTRAINT [PK_TBFuncionario] PRIMARY KEY CLUSTERED ([ID] ASC)
);

