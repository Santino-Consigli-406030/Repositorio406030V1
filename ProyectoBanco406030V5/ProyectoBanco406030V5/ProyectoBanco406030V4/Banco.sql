CREATE DATABASE ProyectoBanco406030V5
use ProyectoBanco406030V5
CREATE TABLE [dbo].[TipoCuentas](
	[id_tipo_cuenta] [int] NOT NULL,
	[tipo_cuenta] [varchar](80) NULL,
 CONSTRAINT [pk_id_tipo_cuenta] PRIMARY KEY CLUSTERED 
(
	[id_tipo_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[dni] [int] NULL,
 CONSTRAINT [pk_id_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Cuentas](
	[id_cuenta] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NULL,
	[id_tipo_cuenta] [int] NULL,
	[cbu] [int] NULL,
	[saldo] [int] NULL,
	[ultimoMovimiento] [datetime] NULL,
 CONSTRAINT [pk_id_cuenta] PRIMARY KEY CLUSTERED 
(
	[id_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [fk_id_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO

ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [fk_id_cliente]
GO

ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [fk_id_tipo_cuenta] FOREIGN KEY([id_tipo_cuenta])
REFERENCES [dbo].[TipoCuentas] ([id_tipo_cuenta])
GO

ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [fk_id_tipo_cuenta]
GO


go
create procedure SP_INSERTAR_CLIENTE--Consultar Maestro
@nombre varchar(100),
@apellido varchar(100),
@dni int,
@id_cliente int output
AS
BEGIN
    INSERT INTO Clientes(nombre,apellido,dni)
	VALUES(@nombre,@apellido,@dni)

	SET @id_cliente= SCOPE_IDENTITY();

END
GO

create procedure [dbo].[SP_CONSULTAR_TIPO_CUENTA] --Insertar ComboBox
as 
begin
select * from TipoCuentas
end
GO

go 
create procedure SP_INSERTAR_CUENTA--Insertar Detalle
@id_cuenta int output,
@id_cliente int,
@id_tipo_cuenta int,
@cbu int,
@saldo int,
@ultimoMovimiento datetime
AS
BEGIN
   INSERT INTO Cuentas(id_cliente,id_tipo_cuenta,cbu,saldo,ultimoMovimiento)
   VALUES(@id_cliente,@id_tipo_cuenta,@cbu,@saldo,@ultimoMovimiento)
   SET @id_cuenta= SCOPE_IDENTITY();
END

INSERT INTO TipoCuentas(id_tipo_cuenta,tipo_cuenta)
VALUES(1,'Cuenta Corriente')
INSERT INTO TipoCuentas(id_tipo_cuenta,tipo_cuenta)
VALUES(2,'Caja Ahorro')
INSERT INTO Cuentas(id_cliente,id_tipo_cuenta,cbu,saldo,ultimoMovimiento)
VALUES(1,2,9223332,1000,'10/08/22')
INSERT INTO Clientes(nombre,apellido,dni)
VALUES('Pedro','Mendez',45833400)
set dateformat dmy
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_PROXIMO_ID_CLIENTE]--ProximoCliente
@nextCLIENTE int output
AS
BEGIN 
    SET @nextCLIENTE = NEXT VALUE FOR SeqProximoIDCliente;
END

-- Modificar SP_PROXIMO_ID_CUENTA
GO



/** Object:  StoredProcedure [dbo].[SP_PROXIMO_ID_CUENTA]    Script Date: 03/09/2023 21:10:39 **/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_PROXIMO_ID_CUENTA]--Proxima Cuenta
@nextCuenta int output
AS
BEGIN 
    SET @nextCuenta = NEXT VALUE FOR SeqProximoIDCuenta;
END
GO

-- Crear una secuencia para el ID de cliente
CREATE SEQUENCE SeqProximoIDCliente
START WITH 1
INCREMENT BY 1;

-- Crear una secuencia para el ID de cuenta
CREATE SEQUENCE SeqProximoIDCuenta
START WITH 1
INCREMENT BY 1;