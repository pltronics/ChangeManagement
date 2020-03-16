/*
Create Procedure CreateStake
	@Description varchar(50),
	@CreatedBy varchar(25)
AS
	SET NOCOUNT ON;
	Insert into Stakes (Description, StartDate, CreatedBy)
	Values (@Description, GetDate(), @CreatedBy)
GO
*/
/*
Create Procedure CreateQuestion
	@StakeId int,
	@Question varchar(255),
	@Examples varchar(100),
	@CreatedBy varchar(25)
AS
	Set NOCOUNT ON;
	Insert INTO StakeQuestions (StakeId, Question, Examples, StartDate, CreatedBy)
	Values (@StakeId, @Question, @Examples, GetDate(), @CreatedBy)
GO
*/
/*
Create Procedure CreateSigner
	@StakeId int,
	@Signer varchar(25),
	@CreatedBy varchar(25)
AS
	SET NOCOUNT ON;
	INSERT INTO StakeSigners (StakeId, Signer, StartDate, CreatedBy)
	Values (@StakeId, @Signer, GetDate(), @CreatedBy)
GO
*/