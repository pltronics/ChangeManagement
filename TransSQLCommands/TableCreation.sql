--Changes
Create Table Changes (
	Id int Identity(1,1) Primary Key NOT NULL,
	CreatedOn DateTime,
	CreatedBy varchar(25),
	Title varchar(50),
	Description varchar(255),
	Owner varchar(50)
);
--Id	CreatedOn	CreatedBy	Title	Description	Owner
--Int	Date		Varchar(50)	Varchar(255)	

--ChangeTargets
Create Table ChangeTargets (
	Id int Identity(1,1) Primary Key NOT NULL,
	ChangeId int,
	SetBy varchar(25),
	SetOn DateTime,
	Target Date
);
--Id	ChangeId	SetBy	SetOn	Target
--Int	Int		Date	Date

--Statuses
Create Table Statuses (
	Id int Identity(1,1) Primary Key NOT NULL,
	Description varchar(25),
	StartDate DateTime,
	EndDate DateTime,
	Required Bit
);
--Id	Description	StartDate	EndDate	Required
--Int	VarChar(50)	Date	Date	Boolean

--ChangeStatus
Create Table ChangeStatus (
	Id int Identity(1,1) PRIMARY KEY NOT NULL,
	ChangeId int,
	Status int,
	Date DateTime,
	ChangedBy varchar(25)
);
--Id	ChangeId	Status	Date	ChangedBy
--Int	Int	Int	Date	


--Stakes
Create Table Stakes (
	Id int Identity(1,1) PRIMARY KEY NOT NULL,
	Description varchar(50),
	StartDate DateTime,
	CreatedBy varchar(25),
	EndDate DateTime,
	EndBy varchar(25)
);
--Id	Desc	StartDate	CreatedBy	EndDate	EndBy
--Int	VarChar(50)	Date		Date	

--StakeSigners
Create Table StakeSigners (
	Id int Identity(1,1) PRIMARY KEY NOT NULL,
	StakeId int,
	Signer varchar(25),
	StartDate DateTime,
	CreatedBy varchar(25),
	EndDate DateTime,
	EndBy varchar(25)
);
--Id	StateId	Signer	StartDate	CreatedBy	EndDate	EndBy
--Int	Int		Date		Date	

--Signatures
Create Table Signatures (
	Id int Identity(1,1) PRIMARY KEY NOT NULL,
	ChangeId int,
	StakeId int,
	SignedById int,
	DateAdded DateTime,
	AddBy varchar(25),
	EndDate DateTime,
	EndBy varchar(25),
	Status varchar(15) Check (Status IN ('Complete', 'Canceled'))
);
--Id	ChangeId	StakeId	SignedById	DateAdded	AddBy	EndDate	EndBy	Status
--Int	Int	Int	Int	Date		Date		

--Reference
Create Table Reference (
	Id int Identity(1,1) PRIMARY KEY NOT NULL,
	ChangeId int,
	StartDate DateTime,
	EndDate DateTime,
	LastStakeId int
);
--Id	ChangeId	StartDate	EndDate	LastStakeId
--Int	Int	Date	Date	Int

--FollowUps
Create Table FollowUps (
	Id int Identity(1,1) PRIMARY KEY NOT NULL,
	ChangeId int,
	CreatedOn DateTime,
	CreatedBy varchar(25),
	FollowUp varchar(255),
	CompleteOn DateTime,
	CompletedBy varchar(25)
);
--Id	ChangeId	CreatedOn	CreatedBy	FollowUp	CompleteOn	CompleteBy
--Int	Int	Date		VarChar(255)	Date	

--FollowUpTarget
Create Table FollowUpTarget (
	Id int Identity(1,1) PRIMARY KEY NOT NULL,
	FollowUpId int,
	SetBy varchar(25),
	SetOn DateTime,
	Target DateTime
);
--Id	FollowUpId	SetBy	SetOn	Target
--Int	Int		Date	Date

--Meetings
Create Table Meetings (
	Id int Identity(1,1) PRIMARY KEY NOT NULL,
	ChangeId int,
	CreatedBy varchar(25),
	CreatedOn DateTime,
	MtgDate DateTime,
	Invitees nvarchar(255)
);
--Id	ChangeId	CreatedBy	CreatedOn	MtgDate	Invitees
--Int	Int		Date	Date	Varchar()

--StakeQuestions
Create Table StakeQuestions (
	Id int Identity(1,1) Primary Key Not Null,
	StakeId int,
	Question varchar(255),
	Examples varchar(100),
	StartDate DateTime,
	CreatedBy varchar(25),
	EndDate DateTime,
	EndBy varchar(25)
);
