CREATE TABLE [dbo].[first_name] (
    [Name]    VARCHAR (20) NOT NULL,
    [Active]  BIT          NOT NULL,
    [FirstID] INT          IDENTITY (1, 1) NOT NULL
);

GO
CREATE TABLE [dbo].[full_name] (
    [FirstID]  INT NOT NULL,
    [MiddleID] INT NOT NULL,
    [Good]     BIT NOT NULL,
    [ID]       INT IDENTITY (1, 1) NOT NULL
);

GO
CREATE TABLE [dbo].[middle_name] (
    [Name]     VARCHAR (20) NOT NULL,
    [Active]   BIT          NOT NULL,
    [MiddleID] INT          IDENTITY (1, 1) NOT NULL
);

GO
ALTER TABLE [dbo].[full_name]
    ADD CONSTRAINT [FK_full_name_first_name] FOREIGN KEY ([FirstID]) REFERENCES [dbo].[first_name] ([FirstID]);

GO
ALTER TABLE [dbo].[full_name]
    ADD CONSTRAINT [FK_full_name_middle_name] FOREIGN KEY ([MiddleID]) REFERENCES [dbo].[middle_name] ([MiddleID]);

GO
ALTER TABLE [dbo].[first_name]
    ADD CONSTRAINT [PK_first_name] PRIMARY KEY CLUSTERED ([FirstID] ASC);

GO
ALTER TABLE [dbo].[full_name]
    ADD CONSTRAINT [PK_full_name] PRIMARY KEY CLUSTERED ([ID] ASC);

GO
ALTER TABLE [dbo].[middle_name]
    ADD CONSTRAINT [PK_middle_name] PRIMARY KEY CLUSTERED ([MiddleID] ASC);

GO
ALTER TABLE [dbo].[first_name]
    ADD CONSTRAINT [UK_first_name] UNIQUE NONCLUSTERED ([Name] ASC);

GO
ALTER TABLE [dbo].[full_name]
    ADD CONSTRAINT [UK_full_name] UNIQUE NONCLUSTERED ([FirstID] ASC, [MiddleID] ASC);

GO
ALTER TABLE [dbo].[middle_name]
    ADD CONSTRAINT [UK_middle_name] UNIQUE NONCLUSTERED ([Name] ASC);

GO
CREATE LOGIN [namedb]
    WITH PASSWORD = N'x{yzc{kdflt|qtuor=tbzxpQmsFT7_&#$!~<htVUPgg{{yVc';

GO
CREATE USER [namedb] FOR LOGIN [namedb];

GO
ALTER ROLE [db_owner] ADD MEMBER [namedb];

GO
ALTER ROLE [db_accessadmin] ADD MEMBER [namedb];

GO
ALTER ROLE [db_securityadmin] ADD MEMBER [namedb];

GO
ALTER ROLE [db_ddladmin] ADD MEMBER [namedb];

GO
ALTER ROLE [db_backupoperator] ADD MEMBER [namedb];

GO
ALTER ROLE [db_datareader] ADD MEMBER [namedb];

GO
ALTER ROLE [db_datawriter] ADD MEMBER [namedb];

GO
ALTER ROLE [db_denydatareader] ADD MEMBER [namedb];

GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [namedb];

GO
GRANT CONNECT TO [namedb]
    AS [dbo];

GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'First Name Relationship', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'full_name', @level2type = N'CONSTRAINT', @level2name = N'FK_full_name_first_name';

GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Middle Name Relationship', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'full_name', @level2type = N'CONSTRAINT', @level2name = N'FK_full_name_middle_name';

GO
