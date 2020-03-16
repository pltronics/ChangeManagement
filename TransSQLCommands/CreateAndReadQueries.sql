--Select c.Title, c.Description, c.CreatedOn, s.Description--, m.MtgDate, t.TargetDate, u.Description
--From Changes c Join Signatures g ON c.Id = g.ChangeId  Join Stakes s on s.Id = g.StakeId

--exec CreateStake N'StakeDescription', N'CreatedBy';
--exec CreateQuestion N'1', N'TestQuestion?', N'Example1, Example2, Example3', N'CreatedByMe';
--exec CreateSigner N'1', N'TheSigner', N'CreatedByMe';
	
Select s.Description, sq.Question, sq.Examples, ss.Signer
from Stakes s LEFT JOIN StakeQuestions sq ON s.Id = sq.StakeId Left Join StakeSigners ss ON s.Id = ss.StakeId
where (s.EndDate <= GetDate() OR s.EndDate IS NULL) AND (sq.EndDate <= GetDate() OR sq.EndDate IS NULL) 
		AND (ss.EndDate <= GetDate() OR ss.EndDate IS NULL)