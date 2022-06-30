create Database FoodRegister;
use FoodRegister;

create table Departamentos(
IdDepartamento numeric(4) Primary Key NOT NULL IDENTITY(0,1),
Departamento varchar(15),
);

create table TipoEmpleado(
IdTipoEmpleado numeric(4) Primary Key NOT NULL IDENTITY(0,1),
Departamento varchar(15),
);

create table Empleados(
IdEmpleado numeric(8) PRIMARY KEY NOT NULL,
Nombre varchar(50),
Apellidos varchar(50),
NombreApellido varchar(100),
Identidad numeric(13),
FKDepartamento numeric(4),
FKTipoEmpleado numeric(4),
Foreign key(FKDepartamento) references Departamentos(IdDepartamento),
Foreign key(FKTipoEmpleado) references TipoEmpleado(IdTipoEmpleado),
);

create table Consumo(
IdConsumo numeric(8) PRIMARY KEY NOT NULL IDENTITY(0,1),
Fecha Date,
FKEmpleado numeric(8),
Desayuno numeric(4),
Almuerzo numeric(4),
Cena numeric(4),
Extras numeric(5),
Total numeric(5),
Foreign Key(FKEmpleado) references Empleados(IdEmpleado),
);

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE insertar_departamento
@departamento varchar(15)
AS BEGIN
IF EXISTS (SELECT Departamento FROM Departamentos WHERE Departamento=@departamento)
		RAISERROR ('Ya existe este departamento.',16,1)
		ELSE
		INSERT INTO Departamentos VALUES(@departamento) 
END 

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE editar_departamento
    @iddepartamento INT,
	@departamento VARCHAR(50)
	as
    UPDATE Departamentos SET Departamento = @departamento
     WHERE IdDepartamento = @iddepartamento
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE borrar_departamento
@iddepartamento INT
as begin
Delete From [dbo].[Departamentos] 
	Where IdDepartamento = @iddepartamento
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE mostrar_departamento
as
SELECT idDepartamento as 'Codigo Departamento', Departamento as 'Departamento' from Departamentos order by IdDepartamento desc
go