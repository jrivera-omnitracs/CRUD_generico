------------------------------------------------------
--------- SE CREA LA BASE DE TABLA DE USUARIOS -------
------------------------------------------------------
CREATE TABLE usuarios(
		  id int IDENTITY(1,1) primary key
		, nombre varchar(25)
		, aPaterno varchar(25)
		, aMaterno varchar(25)
		, usuario varchar(25) not null unique
		, contrasena varchar(45) not null
	)
GO
------------------------------------------------------
--------- SE CREA EL PROCEDIMIENTO CREATE		------
------------------------------------------------------
CREATE PROCEDURE proc_Create_Usuarios
	@nombre varchar(25) = null,
	@aPaterno varchar(25) = null,
	@aMaterno varchar(25) = null,
	@usuario varchar(25) = null,
	@contrasena varchar(45) = null
AS
INSERT usuarios VALUES (@nombre, @aPaterno, @aMaterno, @usuario, @contrasena)
GO
------------------------------------------------------
--------- SE CREA EL PROCEDIMIENTO DELETE		------
------------------------------------------------------
CREATE PROCEDURE proc_Delete_Usuarios
	@id int
AS
DELETE FROM usuarios WHERE id = @id
GO
------------------------------------------------------
--------- SE CREA EL PROCEDIMIENTO SELECT		------
------------------------------------------------------
CREATE PROCEDURE proc_Select_Usuarios
	@id int = null
AS
IF @id IS null
	BEGIN
		SELECT * FROM usuarios
	END
ELSE
	BEGIN
		SELECT * FROM usuarios WHERE id = @id
	END
GO
------------------------------------------------------
--------- SE CREA EL PROCEDIMIENTO LOGIN		------
-- Si regresa 1, la combinación usuario existe y deja acceder
------------------------------------------------------	
CREATE PROCEDURE proc_Login_Usuarios
	@usuario varchar(25) = null,
	@contrasena varchar(45) = null
AS
	SELECT COUNT(usuario) FROM usuarios WHERE usuario = @usuario AND contrasena = @contrasena
GO
------------------------------------------------------
--------- SE CREA EL PROCEDIMIENTO UPDATE		------
------------------------------------------------------	
CREATE PROCEDURE proc_Update_Usuarios
	@usuario varchar(25) = null,
	@contrasena varchar(45) = null,
	@nueva_cont varchar(45) = null,
	@aux int = null

AS
	SET @aux = (SELECT COUNT(usuario) FROM usuarios WHERE usuario = @usuario AND contrasena = @contrasena)
	IF @aux = 1
		BEGIN
			UPDATE usuarios SET contrasena = @nueva_cont WHERE usuario = @usuario
		END
	


proc_Create_Usuarios 'nombre', 'aParterno', 'aMaterno', 'usuario', 'constrasena'
proc_Select_Usuarios
proc_Login_Usuarios 'ususario', 'constrasena'
proc_Delete_Usuarios 4
proc_Update_Usuarios 'ususario', 'constrasena', 'password2'





