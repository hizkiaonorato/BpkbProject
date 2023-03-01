USE [Company]
GO

/****** Object:  Table [dbo].[tr_bpkb]    Script Date: 28/02/2023 22:07:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tr_bpkb](
	[agreement_number] [varchar](100) NOT NULL,
	[bpkb_no] [varchar](100) NOT NULL,
	[branch_id] [varchar](10) NOT NULL,
	[bpkb_date] [datetime] NOT NULL,
	[faktur_no] [varchar](100) NOT NULL,
	[faktur_date] [datetime] NOT NULL,
	[location_id] [varchar](10) NOT NULL,
	[police_no] [varchar](20) NOT NULL,
	[bpkb_date_in] [datetime] NOT NULL,
	[created_by] [varchar](20) NOT NULL,
	[created_on] [datetime] NOT NULL,
	[last_updated_by] [varchar](20) NULL,
	[last_updated_on] [datetime] NULL,
 CONSTRAINT [PK_tr_bpkb] PRIMARY KEY CLUSTERED 
(
	[agreement_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tr_bpkb]  WITH CHECK ADD  CONSTRAINT [FK_tr_bpkb_ms_storage_location] FOREIGN KEY([location_id])
REFERENCES [dbo].[ms_storage_location] ([location_id])
GO

ALTER TABLE [dbo].[tr_bpkb] CHECK CONSTRAINT [FK_tr_bpkb_ms_storage_location]
GO


