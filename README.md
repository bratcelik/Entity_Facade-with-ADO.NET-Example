# ADO.NET ile Veritabani Programlama ve Entity/Facade Katmanlı Mimari Örneği

## Bu repo ADO.NET ile veritabanı işlemleri için örnek teşkil eder.

### Mimari

- Projede Entity/Facade deseni kullanılmıştır.
- Entity, BLL, Facade ve UI katmanlarından oluşur. 

### Veritabanı

- Northwind veritabanındaki Shippers tablosuna ekleme, silme ve güncelleme işlemleri yapar.
- DB olarak MSSQL kullanılmıştır.

#### Shipper Tablosu


|Column Name|Data Type|Allow Nulls|
|:---|:---:|---:|
|ShipperID|int|false|
|CompanyName|nvarchar(50)|false|
|Phone|varchar(30)|false|

#### Stored Procedures

``` sql
CREATE PROCEDURE [dbo].[pr_ShipperAdd]
(
	@CompanyName	NVARCHAR(40),
	@Phone			NVARCHAR(24)
)
AS
BEGIN
	INSERT INTO Shippers(CompanyName, Phone) VALUES(@CompanyName, @Phone);
END;
```

``` sql
CREATE PROCEDURE [dbo].[pr_ShipperDelete]
(
	@ShipperID		INT
)
AS
BEGIN
	DELETE FROM Shippers
	WHERE ShipperID = @ShipperID
END
```

``` sql
ALTER PROCEDURE [dbo].[pr_ShipperUpdate]
(
	@ShipperID		INT,
	@CompanyName	NVARCHAR(40),
	@Phone			NVARCHAR(24)
)
AS
BEGIN
	UPDATE Shippers
	SET 
	CompanyName= @CompanyName,
	Phone= @Phone
	WHERE ShipperID = @ShipperID
END
```
