use [master];

--BACKUP
BACKUP DATABASE [SoftUni]
TO DISK = N'D:\SoftUniDB.bak'
WITH NOFORMAT, NOINIT,
NAME = N'SoftUni-Full DB Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10;

DROP DATABASE SoftUni;

--RESTORE BACKUP
RESTORE DATABASE [SoftUni]
FROM DISK = N'D:\SoftUniDB.bak' WITH FILE = 1, NOUNLOAD, STATS = 5;