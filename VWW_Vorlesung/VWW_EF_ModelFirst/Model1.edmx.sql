
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/12/2016 14:32:58
-- Generated from EDMX file: C:\Sources\VWW\VWW_Vorlesung\VWW_EF_ModelFirst\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [VWW];
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

-- Creating table 'MonitorSet'
CREATE TABLE [dbo].[MonitorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [HerstellerId] int  NOT NULL,
    [Preis_Preis] float  NOT NULL,
    [Preis_Währung] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HerstellerSet'
CREATE TABLE [dbo].[HerstellerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'MonitorSet'
ALTER TABLE [dbo].[MonitorSet]
ADD CONSTRAINT [PK_MonitorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HerstellerSet'
ALTER TABLE [dbo].[HerstellerSet]
ADD CONSTRAINT [PK_HerstellerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [HerstellerId] in table 'MonitorSet'
ALTER TABLE [dbo].[MonitorSet]
ADD CONSTRAINT [FK_HerstellerMonitor]
    FOREIGN KEY ([HerstellerId])
    REFERENCES [dbo].[HerstellerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HerstellerMonitor'
CREATE INDEX [IX_FK_HerstellerMonitor]
ON [dbo].[MonitorSet]
    ([HerstellerId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------