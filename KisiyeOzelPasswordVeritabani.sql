CREATE TRIGGER [dbo].[trg_InsertNewRecord]
   ON  [dbo].[Sites]
   AFTER INSERT
AS 
BEGIN
INSERT INTO ChangeHistory (IslemTarihi,IDSites,IDType,NewMail,NewName,NewPassword)
SELECT GETDATE(),inserted.ID,0,(Select EMailAdress from Emails where ID=inserted.IDEmail),(Select UserName from Names WHERE ID=inserted.IDSiteUserName),(Select PasswordName from Passwords where ID=inserted.IDPassword) from inserted




END
GO
CREATE TRIGGER [dbo].[trg_UpdateRecord]
   ON  [dbo].[Sites]
   FOR UPDATE
AS 
BEGIN
INSERT INTO ChangeHistory (IslemTarihi,IDSites,IDType,OldMail,NewMail,OldName,NewName,OldPassword,NewPassword)
SELECT	GETDATE(),
		inserted.ID,
		1,
		(Select EMailAdress from Emails where ID=deleted.IDEmail),
		(Select EMailAdress from Emails where ID=inserted.IDEmail),
		(Select UserName from Names WHERE ID=deleted.IDSiteUserName),
		(Select UserName from Names WHERE ID=inserted.IDSiteUserName),
		(Select PasswordName from Passwords where ID=deleted.IDPassword),
		(Select PasswordName from Passwords where ID=inserted.IDPassword) from inserted
		INNER JOIN deleted ON deleted.ID=inserted.ID




END
GO