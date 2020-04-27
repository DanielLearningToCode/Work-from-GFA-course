Select * From dbo.Tasks
WHERE Status != 'true';

DELETE FROM dbo.Tasks
WHERE [Description] LIKE 'Relax'

Update dbo.Tasks 
SET Status = 'false'
WHERE [Description] = 'Jog';

INSERT INTO dbo.Tasks (Description, Status)
VALUES ('Relax', 'false');

