CREATE DATABASE promajafishing

use promajafishing

CREATE TABLE VrsteRiba (
    RibljiID INT PRIMARY KEY IDENTITY(1,1),
    Naziv VARCHAR(255) NOT NULL,
    Opis TEXT,
    StatusZastite VARCHAR(50)
);

CREATE TABLE Stapovi (
    StapID INT PRIMARY KEY IDENTITY(1,1),
    Model VARCHAR(255) NOT NULL,
    Duzina DECIMAL(5,2),
    Tezina DECIMAL(5,2),
    Materijal VARCHAR(100)
);

CREATE TABLE Masinice (
    MasinicaID INT PRIMARY KEY IDENTITY(1,1),
    Model VARCHAR(255) NOT NULL,
    Tip VARCHAR(100),
    BrojLezajeva INT,
);

CREATE TABLE Najloni (
    NajlonID INT PRIMARY KEY IDENTITY(1,1),
    Tip VARCHAR(100) NOT NULL,
    Debljina DECIMAL(5,2),
    Nosivost DECIMAL(5,2)
);

CREATE TABLE Udice (
    UdicaID INT PRIMARY KEY IDENTITY(1,1),
    Veličina INT NOT NULL,
    Tip VARCHAR(50),
    Firma VARCHAR(255)
);


ALTER TABLE VrsteRiba
DROP COLUMN IF EXISTS StatusZastite;

CREATE TABLE StatusiZastite (
    StatusZastiteID INT PRIMARY KEY IDENTITY(1,1),
    OpisStatusaZastite VARCHAR(255) NOT NULL
);

INSERT INTO StatusiZastite (OpisStatusaZastite)
VALUES ('Nije ugrožena'), ('Ugrožena'), ('Kritično ugrožena'), ('Zaštićena vrsta');

ALTER TABLE VrsteRiba
ADD StatusZastiteID INT;

ALTER TABLE VrsteRiba
ADD CONSTRAINT FK_StatusZastite
FOREIGN KEY (StatusZastiteID)
REFERENCES StatusiZastite (StatusZastiteID);

ALTER TABLE VrsteRiba
DROP COLUMN IF EXISTS StatusZastiteID;

ALTER TABLE VrsteRiba
ADD StatusZastite VARCHAR(255);

select * from VrsteRiba

ALTER TABLE VrsteRiba DROP CONSTRAINT IF EXISTS FK_StatusZastite;

ALTER TABLE VrsteRiba DROP COLUMN IF EXISTS StatusZastiteID;

select * from VrsteRiba

DBCC CHECKIDENT ('VrsteRiba', RESEED, 0);

select * from VrsteRiba

use promajafishing

ALTER TABLE VrsteRiba
ALTER COLUMN Opis VARCHAR(MAX);

EXEC sp_rename 'VrsteRiba.Opis', 'Porodica', 'COLUMN';

select * from stapovi

ALTER TABLE masinice DROP COLUMN IF EXISTS KapacitetNamotaja;

select * from masinice
select * from udice

ALTER TABLE udice DROP COLUMN IF EXISTS materijal;

select * from udice

ALTER TABLE udice
ADD Firma VARCHAR(255);

create table tabelaKorisnici
(
    Id int primary key identity(1,1) not null,
    UserId varchar(50) not null,
    Password nvarchar(50) not null
)

insert into tabelaKorisnici (userid, password) values ('dimitrijekokovic', '123')
insert into tabelaKorisnici (userid, password) values ('alekgera', '123')

create proc provera_login
(
    @UserId varchar(50),
    @Password nvarchar(50)
)
as
begin
    Select * from tabelaKorisnici where UserId=@UserId and Password=@Password
end;

exec provera_login
@UserId='dimitrijekokovic', @Password='123'


use promajafishing
select * from VrsteRiba

USE promajafishing;
GO
SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'VrsteRiba';

DBCC CHECKIDENT ('VrsteRiba', RESEED, 0);

