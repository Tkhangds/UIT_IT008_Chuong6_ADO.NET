CREATE DATABASE StudentDB;

USE StudentDB;

CREATE TABLE SINHVIEN(
    MASO INT PRIMARY KEY NOT NULL,
    HOTEN NVARCHAR(50) NOT NULL,
    NGAYSINH DATETIME NOT NULL,
    GIOITINH BIT NOT NULL,
    DIACHI NVARCHAR(50),
    DIENTHOAI INTEGER
);

INSERT INTO SINHVIEN (MASO, HOTEN, NGAYSINH, GIOITINH, DIACHI, DIENTHOAI)
VALUES
(1, 'nguyen van a', '1999-09-20', 1, 'ha noi', 123456789),
(2, 'tran thi b', '2000-01-10', 0, 'da nang', 987654321),
(3, 'le van c', '1998-12-31', 1, 'tp. ho chi minh', 112233445),
(4, 'pham thi d', '2001-05-05', 0, 'can tho', 223344556),
(5, 'do van e', '1997-03-08', 1, 'hai phong', 334455667),
(6, 'vu thi f', '2002-08-12', 0, 'hue', 445566778),
(7, 'hoang van g', '1996-11-25', 1, 'nha trang', 556677889),
(8, 'nguyen thi h', '2003-02-14', 0, 'bien hoa', 667788990),
(9, 'truong van i', '1995-04-19', 1, 'vung tau', 778899001),
(11, 'truong van TEST', '1800-04-19', 1, 'vung tau', 778899001),
(10, 'le thi j', '2004-07-27', 0, 'rach gia', 889900112);

