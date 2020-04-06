
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/06/2020 16:39:19
-- Generated from EDMX file: C:\Users\Bogdan\Documents\GitHub\fiidotnet\MyPhotos\ModelWCF\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [PhotoId] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(100)  NOT NULL,
    [CreatedAt] datetime  NOT NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'Tags'
CREATE TABLE [dbo].[Tags] (
    [TagId] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(20)  NOT NULL,
    [Name] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'PhotoTag'
CREATE TABLE [dbo].[PhotoTag] (
    [Photos_PhotoId] int  NOT NULL,
    [Tags_TagId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PhotoId] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([PhotoId] ASC);
GO

-- Creating primary key on [TagId] in table 'Tags'
ALTER TABLE [dbo].[Tags]
ADD CONSTRAINT [PK_Tags]
    PRIMARY KEY CLUSTERED ([TagId] ASC);
GO

-- Creating primary key on [Photos_PhotoId], [Tags_TagId] in table 'PhotoTag'
ALTER TABLE [dbo].[PhotoTag]
ADD CONSTRAINT [PK_PhotoTag]
    PRIMARY KEY CLUSTERED ([Photos_PhotoId], [Tags_TagId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Photos_PhotoId] in table 'PhotoTag'
ALTER TABLE [dbo].[PhotoTag]
ADD CONSTRAINT [FK_PhotoTag_Photo]
    FOREIGN KEY ([Photos_PhotoId])
    REFERENCES [dbo].[Photos]
        ([PhotoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Tags_TagId] in table 'PhotoTag'
ALTER TABLE [dbo].[PhotoTag]
ADD CONSTRAINT [FK_PhotoTag_Tag]
    FOREIGN KEY ([Tags_TagId])
    REFERENCES [dbo].[Tags]
        ([TagId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoTag_Tag'
CREATE INDEX [IX_FK_PhotoTag_Tag]
ON [dbo].[PhotoTag]
    ([Tags_TagId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------