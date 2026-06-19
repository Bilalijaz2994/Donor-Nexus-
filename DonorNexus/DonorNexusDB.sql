 C   REATE DATABASE DonorNexusDB;

 GO
UPDATE D
SET TotalDonations = dbo.fn_GetDonorTotalDonations(D.DonorID)
FROM Donors D;

    INSERT INTO Admins
    (
        AdminName,
        Password
    )
    VALUES
    (
        'Admin',
        'admin123'
    );

 CREATE TABLE DeletedDonors
(
    DonorID INT,
    FullName VARCHAR(100),
    CNIC VARCHAR(13),
    PhoneNumber VARCHAR(11),
    Gender VARCHAR(10),
    Age INT,
    Email VARCHAR(100),
    Password VARCHAR(100),
    BloodGroup VARCHAR(5),
    City VARCHAR(50),
    District VARCHAR(50),
    GoogleMapLink VARCHAR(MAX),
    IsAvailable BIT,
    TotalDonations INT,
    DeletedDate DATETIME DEFAULT GETDATE()
);

    CREATE TABLE Donors
    (DonorID INT PRIMARY KEY IDENTITY(1,1),
        FullName VARCHAR(100) NOT NULL,
        CNIC VARCHAR(13) UNIQUE NOT NULL,
        PhoneNumber VARCHAR(11) NOT NULL,
        Gender VARCHAR(10) NOT NULL,
        Age INT NOT NULL,
        Email VARCHAR(100) UNIQUE NOT NULL,
        Password VARCHAR(100) NOT NULL,
        BloodGroup VARCHAR(5) NOT NULL,
        City VARCHAR(50) NOT NULL,
        District VARCHAR(50) NOT NULL,
        GoogleMapLink VARCHAR(MAX) NULL,
        IsAvailable BIT DEFAULT 1,
        TotalDonations INT DEFAULT 0 );

    CREATE TABLE Admins
    (AdminID INT PRIMARY KEY IDENTITY(1,1),
     AdminName VARCHAR(100) NOT NULL,
     Password VARCHAR(100) NOT NULL);


    CREATE TABLE Hospitals
    (HospitalID INT PRIMARY KEY IDENTITY(1,1),
     HospitalName VARCHAR(100) NOT NULL,
     City VARCHAR(50) NOT NULL,
     District VARCHAR(50) NOT NULL,
     PhoneNumber VARCHAR(11) NOT NULL);

    CREATE TABLE BloodInventory
    (InventoryID INT PRIMARY KEY IDENTITY(1,1),
     HospitalID INT NOT NULL,
     BloodGroup VARCHAR(5) NOT NULL,
     UnitsAvailable INT NOT NULL,
    CONSTRAINT FK_BloodInventory_Hospitals
    FOREIGN KEY (HospitalID)REFERENCES Hospitals(HospitalID)ON DELETE CASCADE);

    CREATE TABLE DonationRecords
    (DonationID INT PRIMARY KEY IDENTITY(1,1),
     DonorID INT NOT NULL,
     HospitalID INT NOT NULL,
     DonationDate DATE NOT NULL,
     UnitsDonated INT NOT NULL,
     CONSTRAINT FK_DonationRecords_Donors
     FOREIGN KEY (DonorID)
     REFERENCES Donors(DonorID)
     ON DELETE CASCADE,
     CONSTRAINT FK_DonationRecords_Hospitals
     FOREIGN KEY (HospitalID)
    REFERENCES Hospitals(HospitalID)
    ON DELETE CASCADE);

    CREATE TABLE ContactMessages
    (MessageID INT PRIMARY KEY IDENTITY(1,1),
        SenderName VARCHAR(100) NOT NULL,
        SenderEmail VARCHAR(100) NOT NULL,
        Subject VARCHAR(200) NOT NULL,
        MessageText VARCHAR(MAX) NOT NULL,
        SentDate DATE NOT NULL );


        INSERT INTO Hospitals
    ( HospitalName,
        City,
        District,
        PhoneNumber)

    VALUES
    ('Jinnah Hospital',
        'Lahore',
        'Lahore',
        '03043812245'), 
    ('Mayo Hospital',
        'Lahore',
        'Johar Town',
        '03111234567' );

Go
CREATE FUNCTION fn_IsEligibleForDonation
(
    @DonorID INT,
    @DonationDate DATE
)
RETURNS VARCHAR(20)
AS
BEGIN
    DECLARE @LastDonationDate DATE;

    SELECT @LastDonationDate = MAX(DonationDate)
    FROM DonationRecords
    WHERE DonorID = @DonorID;

    IF @LastDonationDate IS NULL
        RETURN 'Eligible';

    IF DATEDIFF(DAY, @LastDonationDate, @DonationDate) >= 90
        RETURN 'Eligible';

    RETURN 'Not Eligible';
END

GO


CREATE FUNCTION fn_GetDonorTotalDonations
(
    @DonorID INT
)
RETURNS INT
AS
BEGIN
    DECLARE @Total INT;

    SELECT @Total = COUNT(*)
    FROM DonationRecords
    WHERE DonorID = @DonorID;

    RETURN ISNULL(@Total, 0);
END

GO
CREATE PROCEDURE sp_RegisterDonor
    @FullName VARCHAR(100),
    @CNIC VARCHAR(13),
    @PhoneNumber VARCHAR(11),
    @Gender VARCHAR(10),
    @Age INT,
    @Email VARCHAR(100),
    @Password VARCHAR(100),
    @BloodGroup VARCHAR(5),
    @City VARCHAR(50),
    @District VARCHAR(50),
    @GoogleMapLink VARCHAR(MAX) = NULL,
    @IsAvailable BIT = 1
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Donors
    (FullName,
     CNIC,
     PhoneNumber,
     Gender,
     Age,
     Email,
     Password,
     BloodGroup,
     City,
     District,
     GoogleMapLink,
     IsAvailable,
    TotalDonations)
    VALUES
    (
        LTRIM(RTRIM(@FullName)),
        LTRIM(RTRIM(@CNIC)),
        LTRIM(RTRIM(@PhoneNumber)),
        LTRIM(RTRIM(@Gender)),
        @Age,
        LTRIM(RTRIM(@Email)),
        @Password,
        LTRIM(RTRIM(@BloodGroup)),
        LTRIM(RTRIM(@City)),
        LTRIM(RTRIM(@District)),
        @GoogleMapLink,
        ISNULL(@IsAvailable, 1),
        0  );
END

GO
CREATE PROCEDURE sp_RecordDonation
    @DonorID INT,
    @HospitalID INT,
    @DonationDate DATE,
    @UnitsDonated INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM Donors WHERE DonorID = @DonorID)
        THROW 50001, 'Selected donor was not found.', 1;

    IF NOT EXISTS (SELECT 1 FROM Hospitals WHERE HospitalID = @HospitalID)
        THROW 50002, 'Selected hospital was not found.', 1;

    IF @UnitsDonated <= 0
        THROW 50003, 'Units donated must be greater than zero.', 1;

    IF @DonationDate > CAST(GETDATE() AS DATE)
        THROW 50004, 'Donation date cannot be in the future.', 1;

    IF dbo.fn_IsEligibleForDonation(@DonorID, @DonationDate) = 'Not Eligible'
        THROW 50005, 'Donor is not eligible. At least 90 days are required between donations.', 1;

    INSERT INTO DonationRecords
    (
        DonorID,
        HospitalID,
        DonationDate,
        UnitsDonated
    )
    VALUES
    (
        @DonorID,
        @HospitalID,
        @DonationDate,
        @UnitsDonated
    );
END

GO
CREATE TRIGGER trg_BackupDeletedDonor
ON Donors
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO DeletedDonors
    (
        DonorID,
        FullName,
        CNIC,
        PhoneNumber,
        Gender,
        Age,
        Email,
        Password,
        BloodGroup,
        City,
        District,
        GoogleMapLink,
        IsAvailable,
        TotalDonations
    )
    SELECT
        DonorID,
        FullName,
        CNIC,
        PhoneNumber,
        Gender,
        Age,
        Email,
        Password,
        BloodGroup,
        City,
        District,
        GoogleMapLink,
        IsAvailable,
        TotalDonations
    FROM deleted;

   
    DELETE FROM Donors
    WHERE DonorID IN (SELECT DonorID FROM deleted);
END;    


    EXEC sp_RegisterDonor
        @FullName = 'Ali Khan',
        @CNIC = '3520212345671',
        @PhoneNumber = '03001234567',
        @Gender = 'Male',
        @Age = 25,
        @Email = 'ali@gmail.com',
        @Password = 'ali123',
        @BloodGroup = 'A+',
        @City = 'Lahore',
        @District = 'Johar Town',
        @GoogleMapLink = '',
        @IsAvailable = 1;



 -------1 how many donors belong to each blood groups
SELECT BloodGroup, 
COUNT(*) AS TotalDonors 
FROM Donors 
GROUP BY BloodGroup;

----2 donors avilable for donation
SELECT COUNT(*) AS AvailableDonors 
FROM Donors
WHERE IsAvailable = 1;

----3 which blood group has heighest number of donors
SELECT TOP 1
    BloodGroup,
    COUNT(*) AS TotalDonors
FROM Donors
GROUP BY BloodGroup
ORDER BY TotalDonors DESC;

------4 how many donors are registered in each city
SELECT City,
COUNT(*) ASDonorCount
FROM Donors 
GROUP BY City;

--------5 how many blood units are avialabe for each blood group  in invertory
SELECT BloodGroup, 
SUM(UnitsAvailable)AS TotalUnits 
FROM BloodInventory 
GROUP BY BloodGroup;


---6 total blood units doanted by donors to invertory
SELECT 
SUM(UnitsDonated) 
AS TotalBloodUnits 
FROM DonationRecords;

---7 District with higher number of donors
SELECT TOP 1 District,
COUNT(*) AS TotalDonors 
FROM Donors GROUP BY District 
ORDER BY TotalDonors DESC;

---8 which donors are currentlly eligible;
SELECT *
FROM
(
    SELECT
        DonorID,
        FullName,
        dbo.fn_IsEligibleForDonation(DonorID, GETDATE()) AS Status
    FROM Donors
) AS DonorStatus
WHERE Status = 'Eligible';


----9 which donor has donated the most 
SELECT TOP 1 FullName, 
TotalDonations 
FROM Donors 
ORDER BY TotalDonations DESC;

------10 donors and hospitals where they donated
SELECT
    D.FullName,
    H.HospitalName
FROM DonationRecords DR
INNER JOIN Donors D
    ON DR.DonorID = D.DonorID
INNER JOIN Hospitals H
  ON DR.HospitalID = H.HospitalID;