CREATE TABLE [dbo].[SedcardTypes] (
    [SystemId]    UNIQUEIDENTIFIER NOT NULL,
    [Id]          INT              IDENTITY (1, 1) NOT NULL,
    [SedcardType] VARCHAR (128)    NOT NULL,
    [IsActive]    BIT              CONSTRAINT [DF_SedcardTypes_IsActive] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_SedcardTypes] PRIMARY KEY CLUSTERED ([Id] ASC) ON [CORE]
) ON [CORE];

