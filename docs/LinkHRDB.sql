USE [master]
GO
/****** Object:  Database [linkhrdb]    Script Date: 5/1/2025 6:24:24 PM ******/
CREATE DATABASE [linkhrdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'linkhrdb', FILENAME = N'\\204.246.56.84\c$\databases\linkhrdb\linkhrdb.mdf' , SIZE = 8192KB , MAXSIZE = 20971520KB , FILEGROWTH = 10%)
 LOG ON 
( NAME = N'linkhrdb_log', FILENAME = N'\\204.246.56.84\c$\databases\linkhrdb\linkhrdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 1048576KB , FILEGROWTH = 10%)
GO
ALTER DATABASE [linkhrdb] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [linkhrdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [linkhrdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [linkhrdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [linkhrdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [linkhrdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [linkhrdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [linkhrdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [linkhrdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [linkhrdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [linkhrdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [linkhrdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [linkhrdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [linkhrdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [linkhrdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [linkhrdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [linkhrdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [linkhrdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [linkhrdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [linkhrdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [linkhrdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [linkhrdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [linkhrdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [linkhrdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [linkhrdb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [linkhrdb] SET  MULTI_USER 
GO
ALTER DATABASE [linkhrdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [linkhrdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [linkhrdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [linkhrdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [linkhrdb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'linkhrdb', N'ON'
GO
ALTER DATABASE [linkhrdb] SET QUERY_STORE = ON
GO
ALTER DATABASE [linkhrdb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [linkhrdb]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 5/1/2025 6:24:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[id] [int] NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[role] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 5/1/2025 6:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendance](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [nvarchar](50) NULL,
	[date] [date] NOT NULL,
	[check_in] [time](7) NULL,
	[check_out] [time](7) NULL,
	[hours_worked] [decimal](5, 2) NULL,
 CONSTRAINT [PK__Attendan__3213E83F4FBE9226] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 5/1/2025 6:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[id] [int] NOT NULL,
	[name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 5/1/2025 6:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [int] NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[contact_no] [varchar](15) NULL,
	[address] [varchar](255) NULL,
	[department_id] [int] NULL,
	[role] [varchar](20) NOT NULL,
	[dob] [date] NULL,
	[gender] [char](1) NULL,
	[joining_date] [date] NULL,
 CONSTRAINT [PK__Employee__3213E83F7BE27B0E] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Employee__AB6E6164EBD367B7] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Employee__F3DBC572D741F087] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Leaves]    Script Date: 5/1/2025 6:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leaves](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [int] NULL,
	[requested_date] [date] NULL,
	[from_date] [date] NULL,
	[to_date] [date] NULL,
	[type] [varchar](20) NULL,
	[status] [varchar](20) NULL,
	[manager_id] [int] NULL,
 CONSTRAINT [PK__Leaves__3213E83F390747B2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 5/1/2025 6:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[id] [nvarchar](50) NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](255) NOT NULL,
	[role] [varchar](20) NOT NULL,
 CONSTRAINT [PK__Manager__3213E83F20BB735A] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payroll]    Script Date: 5/1/2025 6:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payroll](
	[id] [int] NOT NULL,
	[employee_id] [int] NULL,
	[net_amount] [decimal](10, 2) NOT NULL,
	[bonus] [decimal](10, 2) NULL,
	[deductions] [decimal](10, 2) NULL,
	[overtime] [decimal](10, 2) NULL,
	[basic] [decimal](10, 2) NOT NULL,
	[status] [varchar](20) NOT NULL,
	[month] [int] NOT NULL,
	[year] [int] NOT NULL,
 CONSTRAINT [PK__Payroll__3213E83F61391F5E] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestConnection]    Script Date: 5/1/2025 6:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestConnection](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Admin] ADD  DEFAULT ('admin') FOR [role]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF__Employee__role__403A8C7D]  DEFAULT ('emp') FOR [role]
GO
ALTER TABLE [dbo].[Leaves] ADD  CONSTRAINT [DF__Leaves__status__440B1D61]  DEFAULT ('Pending') FOR [status]
GO
ALTER TABLE [dbo].[Manager] ADD  CONSTRAINT [DF__Manager__role__47DBAE45]  DEFAULT ('mng') FOR [role]
GO
ALTER TABLE [dbo].[Payroll] ADD  CONSTRAINT [DF__Payroll__bonus__4AB81AF0]  DEFAULT ((0)) FOR [bonus]
GO
ALTER TABLE [dbo].[Payroll] ADD  CONSTRAINT [DF__Payroll__deducti__4BAC3F29]  DEFAULT ((0)) FOR [deductions]
GO
ALTER TABLE [dbo].[Payroll] ADD  CONSTRAINT [DF__Payroll__overtim__4CA06362]  DEFAULT ((0)) FOR [overtime]
GO
ALTER TABLE [dbo].[Payroll] ADD  CONSTRAINT [DF__Payroll__status__4D94879B]  DEFAULT ('Pending') FOR [status]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Attendance] FOREIGN KEY([id])
REFERENCES [dbo].[Attendance] ([id])
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Attendance]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK__Employee__depart__52593CB8] FOREIGN KEY([department_id])
REFERENCES [dbo].[Department] ([id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK__Employee__depart__52593CB8]
GO
ALTER TABLE [dbo].[Payroll]  WITH CHECK ADD  CONSTRAINT [FK__Payroll__employe__5535A963] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([id])
GO
ALTER TABLE [dbo].[Payroll] CHECK CONSTRAINT [FK__Payroll__employe__5535A963]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [CK__Employee__gender__70DDC3D8] CHECK  (([gender]='F' OR [gender]='M'))
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [CK__Employee__gender__70DDC3D8]
GO
ALTER TABLE [dbo].[Leaves]  WITH CHECK ADD  CONSTRAINT [CK__Leaves__status__44FF419A] CHECK  (([status]='Pending' OR [status]='Approved' OR [status]='Rejected'))
GO
ALTER TABLE [dbo].[Leaves] CHECK CONSTRAINT [CK__Leaves__status__44FF419A]
GO
ALTER TABLE [dbo].[Leaves]  WITH CHECK ADD  CONSTRAINT [CK__Leaves__type__4316F928] CHECK  (([type]='Sick' OR [type]='Half day' OR [type]='Full day' OR [type]='Annual'))
GO
ALTER TABLE [dbo].[Leaves] CHECK CONSTRAINT [CK__Leaves__type__4316F928]
GO
ALTER TABLE [dbo].[Payroll]  WITH CHECK ADD  CONSTRAINT [CK__Payroll__status__4E88ABD4] CHECK  (([status]='Pending' OR [status]='Processed' OR [status]='Failed'))
GO
ALTER TABLE [dbo].[Payroll] CHECK CONSTRAINT [CK__Payroll__status__4E88ABD4]
GO
USE [master]
GO
ALTER DATABASE [linkhrdb] SET  READ_WRITE 
GO
