USE [Project_Organizer]
GO

/****** Object:  Table [dbo].[Department]    Script Date: 6/12/2017 8:21:34 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Department](
	[department_num] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[department_num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

-------------------------------------------------------------------------------------------------------------------------------------------
USE [Project_Organizer]
GO

/****** Object:  Table [dbo].[Department_project]    Script Date: 6/12/2017 8:40:21 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Department_project](
	[project_id] [int] IDENTITY(1,1) NOT NULL,
	[start_date] [date] NOT NULL,
	[department_num] [int] NOT NULL,
 CONSTRAINT [PK_Department_project] PRIMARY KEY CLUSTERED 
(
	[project_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Department_project]  WITH CHECK ADD  CONSTRAINT [FK_Department_project_Department] FOREIGN KEY([department_num])
REFERENCES [dbo].[Department] ([department_num])
GO

ALTER TABLE [dbo].[Department_project] CHECK CONSTRAINT [FK_Department_project_Department]
GO

----------------------------------------------------------------------------------------------------------------------------------------------
USE [Project_Organizer]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 6/12/2017 8:40:59 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[employee_num] [int] IDENTITY(1,1) NOT NULL,
	[job_id] [int] NOT NULL,
	[project_id] [int] NULL,
	[last_name] [nchar](20) NOT NULL,
	[first_name] [nchar](20) NOT NULL,
	[gender] [nchar](10) NULL,
	[DOB] [date] NOT NULL,
	[DOH] [date] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[employee_num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department_project] FOREIGN KEY([project_id])
REFERENCES [dbo].[Department_project] ([project_id])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department_project]
GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Job] FOREIGN KEY([job_id])
REFERENCES [dbo].[Job] ([job_id])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Job]
GO

---------------------------------------------------------------------------------------------------------------------------------------------
USE [Project_Organizer]
GO

/****** Object:  Table [dbo].[Job]    Script Date: 6/12/2017 8:42:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Job](
	[department_num] [int] NOT NULL,
	[job_id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[job_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [FK_Job_Department] FOREIGN KEY([department_num])
REFERENCES [dbo].[Department] ([department_num])
GO

ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [FK_Job_Department]
GO

---------------------------------------------------------------------------------------------------------------------------------------------

USE [Project_Organizer]
GO

/****** Object:  Table [dbo].[Project]    Script Date: 6/12/2017 8:45:07 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Project](
	[project_id] [int] NOT NULL,
	[project_name] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[project_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_Department_project] FOREIGN KEY([project_id])
REFERENCES [dbo].[Department_project] ([project_id])
GO

ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Department_project]
GO


