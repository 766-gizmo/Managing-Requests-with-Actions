--tablo_kullanici
CREATE TABLE Users(
Id INT primary key IDENTITY(1,1),
Username NVARCHAR(50) NOT NULL,
PasswordHash NVARCHAR(255) NOT NULL,
Email NVARCHAR(100) NOT NULL,
Role NVARCHAR(20) NOT NULL, --ADMIN VEYA KULLANICI
CreatedAt DATETIME DEFAULT GETDATE()
);

--TABLO_TALEP
CREATE TABLE Requests(
Id INT PRIMARY KEY IDENTITY(1,1),
UserId INT NOT NULL,
Title NVARCHAR(100) NOT NULL,
Description NVARCHAR(MAX) NOT NULL,
Status NVARCHAR(20) DEFAULT 'Pending', --TALEP DURUMU
CreatedAt DATETIME DEFAULT GETDATE(),
FOREIGN KEY (UserId) REFERENCES Users(Id)
);

--TABLO_AKSÝYON
CREATE TABLE Actions(
Id INT PRIMARY KEY IDENTITY(1,1),
RequestId INT NULL,
AssignedToUserId INT NULL,
Note NVARCHAR(MAX),
DocumentPath NVARCHAR(255),
CreatedAt DATETIME DEFAULT GETDATE(),
FOREIGN KEY (RequestId) REFERENCES Requests(Id),
FOREIGN KEY (AssignedToUserId) REFERENCES Users(Id)
);

CREATE INDEX IDX_Requests_UserId ON Requests(UserId);
CREATE INDEX IDX_Actions_RequestId ON Actions(RequestId);

--kullaniciEkleme
INSERT INTO Users (Username, PasswordHash, Email, Role)
VALUES
('admin' , 'hashed_password_here' , 'admin@gmail.com', 'Admin'),
('user1', 'hashed_password_here' , 'user1@gmail.com' , 'User');
--talepEkleme
INSERT INTO Requests (UserId, Title, Description)
VALUES
(2,'Yeni Talep', 'Talebin eklenmesi gerekiyor.'),
(2, 'Hata', 'Bir hata var gibi duruyor.');

-- Kullanýcýlarý Listeleme
SELECT * FROM Users;

-- Talepleri Listeleme
SELECT * FROM Requests;

-- Aksiyonlarý Listeleme
SELECT * FROM Actions;
