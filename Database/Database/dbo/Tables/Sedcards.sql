CREATE TABLE [dbo].[Sedcards] (
    [SystemId]      UNIQUEIDENTIFIER NOT NULL,
    [Id]            INT              IDENTITY (1, 1) NOT NULL,
    [UserId]        INT              NOT NULL,
    [SedcardTypeId] INT              NOT NULL,
    [Title]         VARCHAR (128)    NOT NULL,
    [IsActive]      BIT              CONSTRAINT [DF_Sedcards_IsActive] DEFAULT ((0)) NOT NULL,
    [IsBlocked]     BIT              CONSTRAINT [DF_Sedcards_IsBlocked] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Sedcards] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Sedcards_SedcardTypes] FOREIGN KEY ([SedcardTypeId]) REFERENCES [dbo].[SedcardTypes] ([Id]),
    CONSTRAINT [FK_Sedcards_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

