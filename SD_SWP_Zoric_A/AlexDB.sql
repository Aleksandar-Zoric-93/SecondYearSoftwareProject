DROP TABLE Stock;
DROP TABLE Order_Items
DROP TABLE Staff;
DROP TABLE Orders;
DROP TABLE Payments;

CREATE TABLE Stock
(StockNo numeric(4) NOT NULL,
Title char(12) NOT NULL,
Description char(25) NOT NULL,
Ingridients char(25) NOT NULL,
Category char(10) NOT NULL,
Price numeric(4) NOT NULL,
Available char(4) DEFAULT 'YES',
CONSTRAINT pk_Stock PRIMARY KEY(StockNo));

CREATE TABLE Staff
(StaffID numeric(4) NOT NULL,
Surname char(20) NOT NULL,
Forename char(20) NOT NULL,
dob date NOT NULL,
Email char(30) NOT NULL,
Phone char(10) NOT NULL,
Status char(2) DEFAULT 'A' NOT NULL,
CONSTRAINT pk_Staff PRIMARY KEY(StaffID));

CREATE TABLE Orders
(OrderID numeric(4) NOT NULL,
OrderDate Date,
OrderValue numeric(5,2),
Dispatched char(4) DEFAULT 'NO' NOT NULL,
CONSTRAINT fk_Stock FOREIGN KEY(StockNo) REFERENCES Stock(StockNo),
CONSTRAINT pk_order PRIMARY KEY(OrderID));

CREATE TABLE Order_Items
(OrderID numeric(4),
StockNo numeric(4),
Quantity numeric(2),
Price numeric(4,2)
CONSTRAINT Pk_Order_Items PRIMARY KEY(OrderID),
CONSTRAINT fk_OI_Orders FOREIGN KEY(OrderID) REFERENCES Stock(OrderID));


CREATE TABLE Payments
(PaymentID numeric(4) NOT NULL,
OrderID numeric(4),
Total numeric(4) NOT NULL,
payDate date NOT NULL,
CONSTRAINT fk_Order FOREIGN KEY(OrderID) REFERENCES Orders(OrderID),
CONSTRAINT pk_payment PRIMARY KEY(PaymentID));


commit;

